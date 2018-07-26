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
    public partial class frmListItem : Form
    {
        public frmListItem()
        {
            InitializeComponent();
        }

        private void frmListItem_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            Class.iTreeTableAdapters.ListItemTableAdapter _listitem = new Class.iTreeTableAdapters.ListItemTableAdapter();
            radGridView1.DataSource = _listitem.GetData();
        }

        private void radGridView1_ViewCellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            if (e.Column.Name.Equals("No")) e.CellElement.Text = (e.RowIndex + 1).ToString();
        }

        private void radGridView1_UserDeletingRow(object sender, Telerik.WinControls.UI.GridViewRowCancelEventArgs e)
        {
            int item_list_id = 0;
            try { item_list_id = int.Parse(e.Rows[0].Cells["ItemListId"].Value.ToString()); }
            catch { }
            if (item_list_id > 0)
            {
                Class.iTreeTableAdapters.ListItemTableAdapter _listitem = new Class.iTreeTableAdapters.ListItemTableAdapter();
                _listitem.Delete1(item_list_id);
            }
        }

        private void radGridView1_UserAddedRow(object sender, Telerik.WinControls.UI.GridViewRowEventArgs e)
        {
            Class.iTreeTableAdapters.ListItemTableAdapter _listitem = new Class.iTreeTableAdapters.ListItemTableAdapter();
            _listitem.Insert(e.Row.Cells["ItemName"].Value.ToString(), e.Row.Cells["Unit"].Value.ToString());
            LoadData();
        }

        private void radGridView1_CellEndEdit(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            int item_list_id = 0;
            try
            {
                item_list_id = Convert.ToInt32(radGridView1.CurrentRow.Cells["ItemListId"].Value);

                Class.iTreeTableAdapters.ListItemTableAdapter _listitem = new Class.iTreeTableAdapters.ListItemTableAdapter();
                if (e.Column.Name.Equals("ItemName"))
                    _listitem.Update1(radGridView1.CurrentRow.Cells["ItemName"].Value.ToString(), item_list_id);
                else if (e.Column.Name.Equals("Unit"))
                    _listitem.Update2(radGridView1.CurrentRow.Cells["Unit"].Value.ToString(), item_list_id);
            }
            catch { }
        }
    }
}
