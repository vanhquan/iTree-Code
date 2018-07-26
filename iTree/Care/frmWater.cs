using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iTree.Care
{
    public partial class frmWater : Form
    {
        public frmWater()
        {
            InitializeComponent();
        }
        public int tree_type_id = 0;
        private Class.iTree.TreeTypeRow row_tree_type;
        private void frmWater_Load(object sender, EventArgs e)
        {
            Class.iTreeTableAdapters.TreeTypeTableAdapter _treetype = new Class.iTreeTableAdapters.TreeTypeTableAdapter();
            dpTreeType.DisplayMember = "TreeType";
            dpTreeType.ValueMember = "TreeTypeId";
            dpTreeType.DataSource = _treetype.GetData();
           

            DataTable dt = new DataTable();
            dt.Columns.Add("Type");
            dt.Columns.Add("TypeName");
            dt.Rows.Add("D", "Ngày");
            dt.Rows.Add("W", "Tuần");
            dpType.DisplayMember = "TypeName";
            dpType.ValueMember = "Type";
            dpType.DataSource = dt;
         

            if (this.tree_type_id > 0)
            {
                row_tree_type = _treetype.GetByKey(this.tree_type_id).Rows[0] as Class.iTree.TreeTypeRow;
                dpTreeType.SelectedValue = row_tree_type.TreeTypeId;
                dpType.SelectedValue = row_tree_type.WaterType;
                txtTimes.Value = row_tree_type.Times;
            }

        }

        private void dpTreeType_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            Class.iTreeTableAdapters.TreeTypeTableAdapter _adapter = new Class.iTreeTableAdapters.TreeTypeTableAdapter();
            Class.iTree.TreeTypeDataTable dt = _adapter.GetByKey(Convert.ToInt32(dpTreeType.SelectedValue));
            if (dt.Rows.Count > 0)
            {
                row_tree_type = dt.Rows[0] as Class.iTree.TreeTypeRow;
                dpType.SelectedValue = row_tree_type.WaterType;
                txtTimes.Value = row_tree_type.Times;
                this.tree_type_id = row_tree_type.TreeTypeId;
            }
            else
            {
                dpTreeType.SelectedValue = "D";
                txtTimes.Value = 0;
                this.tree_type_id = 0;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Class.iTreeTableAdapters.TreeTypeTableAdapter _adapter = new Class.iTreeTableAdapters.TreeTypeTableAdapter();
            if (this.tree_type_id.Equals(0))
                _adapter.Insert(dpTreeType.Text, dpType.SelectedValue.ToString(), Convert.ToInt32(txtTimes.Value));
            else
            {
                row_tree_type.WaterType = dpType.SelectedValue.ToString();
                row_tree_type.Times = Convert.ToInt32(txtTimes.Value);
                _adapter.Update(row_tree_type);
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
