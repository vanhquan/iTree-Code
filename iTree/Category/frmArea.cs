using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iTree.Category
{
    public partial class frmArea : Form
    {
        public frmArea()
        {
            InitializeComponent();
        }
        public int AreaId = 0;
        public int LocationId = 0;
        string TreeType
        {
            get
            {
                string s = string.Empty;
                for (int i = 0; i < txtTreeType.Items.Count; i++)
                {
                    s += txtTreeType.Items[i].Text + ";";
                }
                if (s.Length > 0) s = s.Substring(0, s.Length - 1);
                return s;
            }
            set
            {
                txtTreeType.Text = value;
            }
        }
        private void frmArea_Load(object sender, EventArgs e)
        {
            LoadTreeType();
            if (this.AreaId > 0)
            {
                LoadEdit();
            }
        }
        void LoadTreeType()
        {
            Class.iTreeTableAdapters.AreaTableAdapter _area = new Class.iTreeTableAdapters.AreaTableAdapter();
            txtTreeType.AutoCompleteDataSource = _area.GetTreeType();
            txtTreeType.AutoCompleteDisplayMember = "TreeType";
            txtTreeType.AutoCompleteValueMember = "TreeType";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAreaName.Text) && this.LocationId > 0)
            {
                try
                {
                    Class.iTreeTableAdapters.AreaTableAdapter _area = new Class.iTreeTableAdapters.AreaTableAdapter();
                    if (this.AreaId.Equals(0))
                    {
                        AreaId = (Int32)_area.Insert1(this.LocationId, txtAreaName.Text, this.TreeType, Convert.ToInt32(txtRows.Value), 
                            Convert.ToInt32(txtColumns.Value), Convert.ToInt32(txtTotalTree.Value), Convert.ToInt32(txtDisable.Value));
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        row.AreaName = txtAreaName.Text;
                        row.TreeType = this.TreeType;
                        row.Rows = Convert.ToInt32(txtRows.Value);
                        row.Columns = Convert.ToInt32(txtColumns.Value);
                        row.TotalTree = Convert.ToInt32(txtTotalTree.Value.ToString().Replace(",",""));
                        row.Disable = Convert.ToInt32(txtDisable.Value.ToString().Replace(",",""));
                        _area.Update(row);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else { errorProvider1.SetError(txtAreaName, "!"); }
        }

        private void txtTreeType_Leave(object sender, EventArgs e)
        {
            if (txtTreeType.Text.Length > 0)
                txtTreeType.Text = txtTreeType.Text + ";";
        }
        Class.iTree.AreaRow row;
        void LoadEdit()
        {
            Class.iTreeTableAdapters.AreaTableAdapter _adapter = new Class.iTreeTableAdapters.AreaTableAdapter();
            row = (Class.iTree.AreaRow)_adapter.GetByKey(this.AreaId).Rows[0];
            txtAreaName.Text = row.AreaName;
            txtTreeType.Text = string.Concat(row.TreeType, ";");
            txtRows.Value = row.Rows;
            txtColumns.Value = row.Columns;
            txtTotalTree.Value = row.TotalTree;
            txtDisable.Value = row.Disable;
            this.LocationId = row.LocationId;
        }
        void LoadPoint()
        {
            Class.iTreeTableAdapters.AreaPointTableAdapter _areapoint = new Class.iTreeTableAdapters.AreaPointTableAdapter();
            radGridView1.DataSource = _areapoint.GetByArea(this.AreaId);
        }

        private void radGridView1_ViewCellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            if (e.Column.Name.Equals("No")) e.CellElement.Text = (e.RowIndex + 1).ToString();
        }

        private void radGridView1_UserDeletingRow(object sender, Telerik.WinControls.UI.GridViewRowCancelEventArgs e)
        {
            int area_point_id = 0;
            try { area_point_id = int.Parse(e.Rows[0].Cells["AreaPointId"].Value.ToString()); }
            catch { }
            if (area_point_id > 0)
            {
                Class.iTreeTableAdapters.AreaPointTableAdapter _areapoint = new Class.iTreeTableAdapters.AreaPointTableAdapter();
                _areapoint.Delete1(area_point_id);
            }
        }

        private void radGridView1_UserAddedRow(object sender, Telerik.WinControls.UI.GridViewRowEventArgs e)
        {
            Class.iTreeTableAdapters.AreaPointTableAdapter _areapoint = new Class.iTreeTableAdapters.AreaPointTableAdapter();
            _areapoint.Insert(this.AreaId, Convert.ToDouble(e.Row.Cells["Lat"].Value), Convert.ToDouble(e.Row.Cells["Long"].Value));
            LoadPoint();
        }

        private void radGridView1_CellEndEdit(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            int area_point_id = 0;
            string _lat = string.Empty;
            string _long = string.Empty;
            try
            {
                area_point_id = Convert.ToInt32(radGridView1.CurrentRow.Cells["AreaPointId"].Value);
                _lat = radGridView1.CurrentRow.Cells["Lat"].Value.ToString();
                _long = radGridView1.CurrentRow.Cells["Long"].Value.ToString();
                Class.iTreeTableAdapters.AreaPointTableAdapter _areapoint = new Class.iTreeTableAdapters.AreaPointTableAdapter();
                _areapoint.Update1(Convert.ToDouble(_lat), Convert.ToDouble(_long), area_point_id);
            }
            catch { }
        }
    }
}
