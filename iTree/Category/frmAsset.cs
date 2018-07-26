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
using Telerik.WinControls;

namespace iTree.Category
{
    public partial class frmAsset : Form
    {
        public frmAsset()
        {
            //MessageBox.Show("a");
         
                InitializeComponent();
          
        }

        private void frmAsset_Load(object sender, EventArgs e)
        {
          
            gMap.MapProvider = GMap.NET.MapProviders.BingHybridMapProvider.Instance;
            GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;

            //gMap.SetPositionByKeywords("Vietnam");
            gMap.Position = new PointLatLng(10.830341, 106.650880);

            gMap.DragButton = System.Windows.Forms.MouseButtons.Left;
            gMap.MinZoom = 3;
            gMap.MaxZoom = 19;
            gMap.AutoScroll = true;
            gMap.Overlays.Add(markersOverlay);
            gMap.Overlays.Add(polygonsOverlay);
           

            LoadTree();
          
            trZoom.Value = 16;
        }
        void DrawNewPolygons()
        {
            polygonsOverlay.Clear();
            List<PointLatLng> points = new List<PointLatLng>();
            foreach (GMapMarker mk in markersOverlay.Markers)
            {
                points.Add(new PointLatLng(mk.Position.Lat, mk.Position.Lng));
            }

            GMapPolygon polygon = new GMapPolygon(points, string.Empty);
            polygonsOverlay.Polygons.Add(polygon);
            //gMap.Overlays.Add(polygons);
        }
        bool moved = true;
        void DrawPolygons(int Id, int level)
        {
            List<PointLatLng> points = new List<PointLatLng>();
            switch (level)
            {
                case 0:
                    Class.iTreeTableAdapters.LocationPointTableAdapter _locationPoint = new Class.iTreeTableAdapters.LocationPointTableAdapter();
                    Class.iTree.LocationPointDataTable dtLocation = _locationPoint.GetByLocation(Id);
                    foreach (Class.iTree.LocationPointRow dr in dtLocation.Rows)
                    {
                        points.Add(new PointLatLng(dr.Lat, dr.Long));
                        if (!moved)
                        {
                            gMap.Position = new PointLatLng(dr.Lat, dr.Long);
                            moved = true;
                        }
                    }
                    GMapPolygon polygon0 = new GMapPolygon(points, string.Empty);
                    polygon0.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
                    polygon0.Stroke = new Pen(Color.Red, 1);
                    polygonsOverlay.Polygons.Add(polygon0);
                    break;
                case 1:
                    Class.iTreeTableAdapters.AreaPointTableAdapter _areaPoint = new Class.iTreeTableAdapters.AreaPointTableAdapter();
                    Class.iTree.AreaPointDataTable dtArea = _areaPoint.GetByArea(Id);
                    foreach (Class.iTree.AreaPointRow dr in dtArea.Rows)
                    {
                        points.Add(new PointLatLng(dr.Lat, dr.Long));
                        //if (!moved)
                        //{
                        //    gMap.Position = new PointLatLng(dr.Lat, dr.Long);
                        //    moved = true;
                        //}
                    }
                    GMapPolygon polygon1 = new GMapPolygon(points, string.Empty);
                    polygon1.Fill = new SolidBrush(Color.FromArgb(50, Color.GreenYellow));
                    polygon1.Stroke = new Pen(Color.GreenYellow, 1);
                    polygonsOverlay.Polygons.Add(polygon1);
                    break;
                case 2:
                    Class.iTreeTableAdapters.TreeTableAdapter _tree = new Class.iTreeTableAdapters.TreeTableAdapter();
                    Class.iTree.TreeRow rowTree = _tree.GetByKey(Id).Rows[0] as Class.iTree.TreeRow;

                    GMapMarker marker = new GMarkerGoogle(new PointLatLng(rowTree.Lat, rowTree.Long), new Bitmap(Properties.Resources.big_tree));
                    markersOverlay.Markers.Add(marker);
                    //if (!moved)
                    //{
                    //    gMap.Position = new PointLatLng(rowTree.Lat, rowTree.Long);
                    //    moved = true;
                    //}

                    break;
            }
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
        GMap.NET.WindowsForms.GMapOverlay markersOverlay = new GMap.NET.WindowsForms.GMapOverlay("markers");
        GMap.NET.WindowsForms.GMapOverlay polygonsOverlay = new GMap.NET.WindowsForms.GMapOverlay("polygons");

        private void gMap_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                GMap.NET.WindowsForms.GMapMarker marker =
                    new GMap.NET.WindowsForms.Markers.GMarkerGoogle(
                        new GMap.NET.PointLatLng(gMap.FromLocalToLatLng(e.X, e.Y).Lat, gMap.FromLocalToLatLng(e.X, e.Y).Lng),
                        GMap.NET.WindowsForms.Markers.GMarkerGoogleType.red_pushpin);

                markersOverlay.Markers.Add(marker);

                DrawNewPolygons();
            }
        }
        int LocationId = 0;
        int AreaId = 0;
        int TreeId = 0;
        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            if (polygonsOverlay.Polygons.Count > 0)
            {
                if (polygonsOverlay.Polygons[0].Points.Count > 2)
                {
                    Category.frmName frm = new frmName();
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        Class.iTreeTableAdapters.LocationTableAdapter _location = new Class.iTreeTableAdapters.LocationTableAdapter();
                        Class.iTreeTableAdapters.LocationPointTableAdapter _point = new Class.iTreeTableAdapters.LocationPointTableAdapter();

                        LocationId = (Int32)_location.Insert1(frm.Name);
                        if (LocationId > 0)
                        {
                            foreach (GMap.NET.PointLatLng p in polygonsOverlay.Polygons[0].Points)
                            {
                                _point.Insert(LocationId, p.Lat, p.Lng);
                            }
                        }
                    }
                }
                else { MessageBox.Show("Vị trí lô đất chưa được tạo. Dùng chuột phải để chọn vị trí trên bản đồ", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else { MessageBox.Show("Vị trí lô đất chưa được tạo. Dùng chuột phải để chọn vị trí trên bản đồ", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        void LoadTree()
        {
            this.Cursor = Cursors.WaitCursor;
            this.radTreeView1.Nodes.Clear();
            this.radTreeView1.Controls.Clear();


            Class.iTreeTableAdapters.Sel_LocationTreeTableAdapter _locationTree = new Class.iTreeTableAdapters.Sel_LocationTreeTableAdapter();
            DataTable dt = _locationTree.GetData(0, 0);
            foreach (DataRow dr in dt.Rows)
            {
                RadTreeNode root = new RadTreeNode();
                root.Text = dr["Name"].ToString();
                root.Value = dr["Id"];
                LoadNode(Convert.ToInt32(root.Value), root.Level + 1, root);
                radTreeView1.Nodes.Add(root);
            }

            radTreeView1.ExpandAll();
            this.Cursor = Cursors.Default;
        }
        void LoadNode(int id, int level, RadTreeNode nodeParent)
        {
            Class.iTreeTableAdapters.Sel_LocationTreeTableAdapter _locationTree = new Class.iTreeTableAdapters.Sel_LocationTreeTableAdapter();
            DataTable dt = _locationTree.GetData(id, level);
            foreach (DataRow row in dt.Rows)
            {
                RadTreeNode node = new RadTreeNode();
                node.Value = row["Id"].ToString();
                node.Text = row["Name"].ToString();
                nodeParent.Nodes.Add(node);
                LoadNode(Convert.ToInt32(row["Id"]), node.Level + 1, node);
            }
        }

        private void radTreeView1_SelectedNodeChanged(object sender, RadTreeViewEventArgs e)
        {
            try
            {
                if (e.Node.Level.Equals(0))
                {
                    this.LocationId = Convert.ToInt32(e.Node.Value);
                }
                if (e.Node.Level.Equals(1))
                {
                    this.AreaId = Convert.ToInt32(e.Node.Value);
                }
                if (e.Node.Level.Equals(2))
                {
                    this.TreeId = Convert.ToInt32(e.Node.Value);
                }
            }
            catch
            {
                this.LocationId = 0;
                this.AreaId = 0;
                this.TreeId = 0;
            }
        }

        private void btnClearPoint_Click(object sender, EventArgs e)
        {
            markersOverlay.Clear();
            polygonsOverlay.Clear();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            if (polygonsOverlay.Polygons.Count > 0)
            {
                if (polygonsOverlay.Polygons[0].Points.Count > 2)
                {
                    Category.frmArea frm = new frmArea();
                    frm.LocationId = this.LocationId;
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        int areaId = frm.AreaId;
                        if (areaId > 0)
                        {
                            Class.iTreeTableAdapters.AreaPointTableAdapter _point = new Class.iTreeTableAdapters.AreaPointTableAdapter();
                            foreach (GMap.NET.PointLatLng p in polygonsOverlay.Polygons[0].Points)
                            {
                                _point.Insert(areaId, p.Lat, p.Lng);
                            }
                        }
                    }
                }
                else { MessageBox.Show("Vị trí khu chưa được tạo. Dùng chuột phải để chọn vị trí trên bản đồ", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else { MessageBox.Show("Vị trí khu chưa được tạo. Dùng chuột phải để chọn vị trí trên bản đồ", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void radTreeView1_NodeCheckedChanged(object sender, TreeNodeCheckedEventArgs e)
        {
            polygonsOverlay.Clear();
            markersOverlay.Clear();
            moved = false;
            foreach (RadTreeNode node in radTreeView1.CheckedNodes)
            {
                DrawPolygons(Convert.ToInt32(node.Value), node.Level);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                RadTreeNode node = radTreeView1.SelectedNode;
                if (node.Level.Equals(0))
                {
                    Category.frmName frm = new frmName();
                    frm.LocationId = this.LocationId;
                    if (frm.ShowDialog() == DialogResult.OK)
                    { btnRefresh_Click(null, null); }

                }
                if (node.Level.Equals(1))
                {
                    Category.frmArea frm = new frmArea();
                    frm.LocationId = this.LocationId;
                    frm.AreaId = this.AreaId;
                    if (frm.ShowDialog() == DialogResult.OK)
                    { btnRefresh_Click(null, null); }
                }
                if (node.Level.Equals(2))
                {
                    Category.frmTreeConfig frm = new frmTreeConfig();
                    frm.AreaId = this.AreaId;
                    frm.TreeId = this.TreeId;
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        Class.iTreeTableAdapters.TreeTableAdapter _tree = new Class.iTreeTableAdapters.TreeTableAdapter();
                        _tree.Update1(frm.TreeCode, frm.TreeTypeId, frm.PlantMonth, frm.PlantYear, frm.Lat, frm.Long, 1, this.TreeId);
                    }
                    btnRefresh_Click(null, null);

                }
            }
            catch { }
        }

        private void btnTree_Click(object sender, EventArgs e)
        {
            if(this.AreaId.Equals(0))
            {
                MessageBox.Show("Chưa chọn khu vực.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Category.frmTree frm = new frmTree();
            frm.AreaId = this.AreaId;
            frm.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadTree();
        }

     

        private void btnImport_Click(object sender, EventArgs e)
        {
            Category.frmImport frm = new frmImport();
            frm.ShowDialog();
        }

        private void trZoom_ValueChanged(object sender, EventArgs e)
        {
            gMap.Zoom = trZoom.Value;
        }

        private void radButtonElement2_Click(object sender, EventArgs e)
        {
            Care.frmExport frm = new Care.frmExport();
            frm.ShowDialog();
        }
        Bitmap file = iTree.Properties.Resources.tree;
        private void radTreeView1_NodeFormatting(object sender, TreeNodeFormattingEventArgs e)
        {
            if (e.Node.Level.Equals(2))
            {
                e.NodeElement.ImageElement.Image = file;
            }
            else
            {
                e.NodeElement.ImageElement.ResetValue(LightVisualElement.ImageProperty, ValueResetFlags.Local);
            }
        }

        private void dpMapProvider_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            switch(dpMapProvider.Text)
            {
                case "":
                    break;
                case "BingSatelliteMap":
                    gMap.MapProvider = GMap.NET.MapProviders.BingHybridMapProvider.Instance;
                    break;
                case "GoogleMap":
                    gMap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
                    break;
            }
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            Category.frmUser frm = new frmUser();
            frm.ShowDialog();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            Category.frmProduct frm = new frmProduct();
            frm.ShowDialog();
        }

        private void btnProductPrice_Click(object sender, EventArgs e)
        {
            Category.frmProductPrice frm = new frmProductPrice();
            frm.ShowDialog();
        }

        private void btnListItem_Click(object sender, EventArgs e)
        {
            Category.frmListItem frm = new frmListItem();
            frm.ShowDialog();
        }

        private void btnTreeType_Click(object sender, EventArgs e)
        {
            Care.frmWater frm = new Care.frmWater();
            frm.ShowDialog();
        }

        private void btnLedgerN_Click(object sender, EventArgs e)
        {
            Category.frmLedger frm = new frmLedger();
            frm.mode = "N";
            frm.ShowDialog();
        }

        private void btnLedgerX_Click(object sender, EventArgs e)
        {
            Category.frmLedger frm = new frmLedger();
            frm.mode = "X";
            frm.ShowDialog();
        }

        private void btnLedgerU_Click(object sender, EventArgs e)
        {
            Category.frmLedger frm = new frmLedger();
            frm.mode = "U";
            frm.ShowDialog();
        }

        private void btnHarvest_Click(object sender, EventArgs e)
        {
            Care.frmHarvest frm = new Care.frmHarvest();
            frm.Show();
        }

        private void btnExportHarvest_Click(object sender, EventArgs e)
        {
            Care.frmExportHarvest frm = new Care.frmExportHarvest();
            frm.ShowDialog();
        }

        private void btnListWork_Click(object sender, EventArgs e)
        {
            Category.frmListWork frm = new frmListWork();
            frm.ShowDialog();
        }

        private void btnWorkNote_Click(object sender, EventArgs e)
        {
            Care.frmWorkNote frm = new Care.frmWorkNote();
            frm.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Report.frmReport frm = new Report.frmReport();
            frm.Show();
        }
    }

}
