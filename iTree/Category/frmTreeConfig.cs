using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

using Telerik.WinControls.UI;

namespace iTree.Category
{
    public partial class frmTreeConfig : Form
    {
        public frmTreeConfig()
        {
            InitializeComponent();
        }
        public Point p;
        public string TreeCode = string.Empty;
        public int TreeTypeId = 0;
        public int PlantMonth = 0;
        public int PlantYear = 0;
        public double Lat = 0;
        public double Long = 0;

        public int AreaId = 0;
        public int TreeId = 0;

        GMap.NET.WindowsForms.GMapOverlay markersOverlay = new GMap.NET.WindowsForms.GMapOverlay("markers");
        GMap.NET.WindowsForms.GMapOverlay polygonsOverlay = new GMap.NET.WindowsForms.GMapOverlay("polygons");

        private void frmTreeConfig_FormClosing(object sender, FormClosingEventArgs e)
        {
            TreeCode = txtTreeCode.Text;
            TreeTypeId = Convert.ToInt32(dpTreeType.SelectedValue);
            PlantMonth = Convert.ToInt32(txtPlantMonth.Text.Replace(",", ""));
            PlantYear = Convert.ToInt32(txtPlantYear.Text.Replace(",", ""));
            try { Lat = Convert.ToDouble(txtLat.Text); }
            catch { }
            try { Long = Convert.ToDouble(txtLong.Text); }
            catch { }
            this.DialogResult = DialogResult.OK;

        }

        private void frmTreeConfig_Load(object sender, EventArgs e)
        {
            if (p.X.Equals(0) && p.Y.Equals(0))
            {
                this.StartPosition = FormStartPosition.WindowsDefaultLocation;
            }
            else
            {

                this.StartPosition = FormStartPosition.Manual;
                this.Location = new Point(p.X, p.Y);
            }

            if (this.AreaId.Equals(0) && this.TreeId > 0)
            {
                Class.iTreeTableAdapters.TreeTableAdapter _tree = new Class.iTreeTableAdapters.TreeTableAdapter();
                Class.iTree.TreeRow row = _tree.GetByKey(this.TreeId).Rows[0] as Class.iTree.TreeRow;
                this.AreaId = row.AreaId;
            }

            LoadCombo();
            InitialMap();
            if (this.TreeId > 0)
                LoadEdit();
        }
        void LoadCombo()
        {
            Class.iTreeTableAdapters.TreeTypeTableAdapter _treetype = new Class.iTreeTableAdapters.TreeTypeTableAdapter();
           
            dpTreeType.DisplayMember = "TreeType";
            dpTreeType.ValueMember = "TreeTypeId";
            dpTreeType.DataSource = _treetype.GetDataNew();
        }
        void LoadEdit()
        {
            Class.iTreeTableAdapters.TreeTableAdapter _tree = new Class.iTreeTableAdapters.TreeTableAdapter();
            Class.iTree.TreeRow row = _tree.GetByKey(this.TreeId).Rows[0] as Class.iTree.TreeRow;
            txtTreeCode.Text = row.TreeCode;
            dpTreeType.SelectedValue = row.TreeTypeId;
            txtPlantMonth.Value = row.PlantMonth;
            txtPlantYear.Value = row.PlantYear;
            txtLat.Text = row.Lat.ToString();
            txtLong.Text = row.Long.ToString();

            markersOverlay.Clear();
            GMap.NET.WindowsForms.GMapMarker marker =
                new GMap.NET.WindowsForms.Markers.GMarkerGoogle(
                    new GMap.NET.PointLatLng(row.Lat, row.Long),
                    new Bitmap(Properties.Resources.big_tree));

            markersOverlay.Markers.Add(marker);

        }
        void InitialMap()
        {
            bool moved = false;
            gMap.MapProvider = GMap.NET.MapProviders.BingSatelliteMapProvider.Instance;
            GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gMap.DragButton = System.Windows.Forms.MouseButtons.Left;

            List<PointLatLng> points = new List<PointLatLng>();
            Class.iTreeTableAdapters.AreaPointTableAdapter _areaPoint = new Class.iTreeTableAdapters.AreaPointTableAdapter();
            Class.iTree.AreaPointDataTable dtArea = _areaPoint.GetByArea(this.AreaId);
            foreach (Class.iTree.AreaPointRow dr in dtArea.Rows)
            {
                points.Add(new PointLatLng(dr.Lat, dr.Long));
                if (!moved)
                {
                    gMap.Position = new PointLatLng(dr.Lat, dr.Long);
                    moved = true;
                }
            }
            GMapPolygon polygon1 = new GMapPolygon(points, string.Empty);
            polygon1.Fill = new SolidBrush(Color.FromArgb(50, Color.GreenYellow));
            polygon1.Stroke = new Pen(Color.GreenYellow, 1);
            polygonsOverlay.Polygons.Add(polygon1);

            gMap.Overlays.Add(markersOverlay);
            gMap.Overlays.Add(polygonsOverlay);

            gMap.MinZoom = 14;
            gMap.MaxZoom = 19;
            gMap.Zoom = 17;
        }

        private void gMap_MouseMove(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);
            lblLatLng.Visible = true;
            double X = gMap.FromLocalToLatLng(e.X, e.Y).Lng;
            double Y = gMap.FromLocalToLatLng(e.X, e.Y).Lat;

            string longitude = X.ToString();
            string latitude = Y.ToString();
            lblLatLng.Text = latitude + " " + longitude;
            lblLatLng.BackColor = Color.Transparent;
            lblLatLng.Location = new Point(e.Location.X, e.Location.Y + 20);
        }

        private void gMap_MouseLeave(object sender, EventArgs e)
        {
            lblLatLng.Visible = false;
        }

        private void gMap_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                markersOverlay.Clear();
                GMap.NET.WindowsForms.GMapMarker marker =
                    new GMap.NET.WindowsForms.Markers.GMarkerGoogle(
                        new GMap.NET.PointLatLng(gMap.FromLocalToLatLng(e.X, e.Y).Lat, gMap.FromLocalToLatLng(e.X, e.Y).Lng),
                        new Bitmap(Properties.Resources.big_tree));

                markersOverlay.Markers.Add(marker);
                txtLat.Text = gMap.FromLocalToLatLng(e.X, e.Y).Lat.ToString();
                txtLong.Text = gMap.FromLocalToLatLng(e.X, e.Y).Lng.ToString();

            }
        }

        private void dpTreeType_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            try
            {
                if (dpTreeType.SelectedValue.ToString().Equals("0"))
                {
                    Care.frmWater frm = new Care.frmWater();
                    frm.tree_type_id = 0;
                    if (frm.ShowDialog() == DialogResult.OK)
                        LoadCombo();
                }
            }
            catch { }

        }
    }
}
