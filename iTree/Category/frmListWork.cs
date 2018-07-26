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
    public partial class frmListWork : Form
    {
        public frmListWork()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            Class.iTreeTableAdapters.ListWorkTableAdapter _listwork = new Class.iTreeTableAdapters.ListWorkTableAdapter();
            radGridView1.DataSource = _listwork.GetData();
        }

        private void radGridView1_UserAddedRow(object sender, Telerik.WinControls.UI.GridViewRowEventArgs e)
        {
            Class.iTreeTableAdapters.ListWorkTableAdapter _listwork = new Class.iTreeTableAdapters.ListWorkTableAdapter();
            _listwork.Insert(e.Row.Cells["Name"].Value.ToString());
            LoadData();
        }

        private void radGridView1_UserDeletingRow(object sender, Telerik.WinControls.UI.GridViewRowCancelEventArgs e)
        {
            int work_id = 0;
            try { work_id = int.Parse(e.Rows[0].Cells["WorkId"].Value.ToString()); }
            catch { }
            if (work_id > 0)
            {
                Class.iTreeTableAdapters.ListWorkTableAdapter _listwork = new Class.iTreeTableAdapters.ListWorkTableAdapter();
                _listwork.Delete1(work_id);
            }

        }

        private void radGridView1_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if(e.Column.Name.Equals("Delete"))
            {
                Class.iTreeTableAdapters.ListWorkTableAdapter _listwork = new Class.iTreeTableAdapters.ListWorkTableAdapter();
                _listwork.Delete1(Convert.ToInt32(radGridView1.Rows[e.RowIndex].Cells["WorkId"].Value));

                LoadData();
            }
        }

        private void radGridView1_CellEndEdit(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            int work_id = 0;
            try
            {
                work_id = Convert.ToInt32(radGridView1.CurrentRow.Cells["WorkId"].Value);
                Class.iTreeTableAdapters.ListWorkTableAdapter _listwork = new Class.iTreeTableAdapters.ListWorkTableAdapter();
                _listwork.Update1(radGridView1.CurrentRow.Cells["Name"].Value.ToString(), work_id);

            }
            catch { }
        }

        private void radGridView1_ViewCellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.Column.Name.Equals("No")) e.CellElement.Text = (e.RowIndex + 1).ToString();
        }

        private void frmListWork_Load(object sender, EventArgs e)
        {
            Class.iTreeTableAdapters.ListWorkTableAdapter _listwork = new Class.iTreeTableAdapters.ListWorkTableAdapter();
            radGridView1.DataSource = _listwork.GetData();
        }
    }
}
