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
    public partial class frmName : Form
    {
        public frmName()
        {
            InitializeComponent();
        }
        public string Name = string.Empty;
        public int LocationId = 0;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.LocationId > 0)
            {
                Class.iTreeTableAdapters.LocationTableAdapter _location = new Class.iTreeTableAdapters.LocationTableAdapter();
                _location.Update1(txtName.Text.Trim(), this.LocationId);
            }
            Name = txtName.Text.Trim();
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void frmName_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            Class.iTreeTableAdapters.LocationPointTableAdapter _locationpoint = new Class.iTreeTableAdapters.LocationPointTableAdapter();
            radGridView1.DataSource = _locationpoint.GetByLocation(this.LocationId);
        }
        private void radGridView1_ViewCellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            if (e.Column.Name.Equals("No")) e.CellElement.Text = (e.RowIndex + 1).ToString();
        }

        private void radGridView1_UserDeletingRow(object sender, Telerik.WinControls.UI.GridViewRowCancelEventArgs e)
        {
            int  location_point_id = 0;
            try { location_point_id = int.Parse(e.Rows[0].Cells["LocationPointId"].Value.ToString()); }
            catch { }
            if (location_point_id > 0)
            {
                Class.iTreeTableAdapters.LocationPointTableAdapter _locationpoint = new Class.iTreeTableAdapters.LocationPointTableAdapter();
                _locationpoint.Delete1(location_point_id);
            }
        }

        private void radGridView1_CellEndEdit(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            int location_point_id = 0;
            string _lat = string.Empty;
            string _long = string.Empty;
            try
            {
                location_point_id = Convert.ToInt32(radGridView1.CurrentRow.Cells["LocationPointId"].Value);
                _lat = radGridView1.CurrentRow.Cells["Lat"].Value.ToString();
                _long = radGridView1.CurrentRow.Cells["Long"].Value.ToString();
                Class.iTreeTableAdapters.LocationPointTableAdapter _locationpoint = new Class.iTreeTableAdapters.LocationPointTableAdapter();
                _locationpoint.Update1(Convert.ToDouble(_lat), Convert.ToDouble(_long), location_point_id);
            }
            catch { }
        }

        private void radGridView1_UserAddedRow(object sender, Telerik.WinControls.UI.GridViewRowEventArgs e)
        {
            Class.iTreeTableAdapters.LocationPointTableAdapter _locationpoint = new Class.iTreeTableAdapters.LocationPointTableAdapter();
            _locationpoint.Insert(this.LocationId, Convert.ToDouble(e.Row.Cells["Lat"].Value), Convert.ToDouble(e.Row.Cells["Long"].Value));
            LoadData();
        }
    }
}
