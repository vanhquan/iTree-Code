using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace iTree.Care
{
    public partial class frmExportHarvest : Form
    {
        public frmExportHarvest()
        {
            InitializeComponent();
        }

        private void radGridView1_ViewCellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            if (e.Column.Name.Equals("No")) e.CellElement.Text = (e.RowIndex + 1).ToString();
        }

        private void radGridView2_ViewCellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            if (e.Column.Name.Equals("No")) e.CellElement.Text = (e.RowIndex + 1).ToString();
        }

        private void radDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void frmExportHarvest_Load(object sender, EventArgs e)
        {
            radDateTimePicker1.Value = DateTime.Today;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Class.iTreeTableAdapters.HarvestTableAdapter harvest = new Class.iTreeTableAdapters.HarvestTableAdapter();
            foreach (GridViewRowInfo row in radGridView1.Rows)
            {
                int product_id = 0;
                decimal quantity = 0;

                try { product_id = Convert.ToInt32(row.Cells["ProductId"].Value); }
                catch { }
                try { quantity = Convert.ToDecimal(row.Cells["Quantity"].Value); }
                catch { }
                if (quantity > 0)
                    harvest.Insert(product_id, 0, radDateTimePicker1.Value, 0, quantity, "X", 0);

            }
            MessageBox.Show("Xuất kho thành công.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
        }

        private void radGridView2_CommandCellClick(object sender, GridViewCellEventArgs e)
        {
            if (e.Column.Name.Equals("Delete"))
            {
                Class.iTreeTableAdapters.HarvestTableAdapter harvest = new Class.iTreeTableAdapters.HarvestTableAdapter();
                harvest.Delete1(Convert.ToInt32(radGridView2.Rows[e.RowIndex].Cells["HarvestId"].Value));

                LoadData();
            }
        }

        private void radGridView1_CellEndEdit(object sender, GridViewCellEventArgs e)
        {
            decimal stock_quantity = 0;
            try { stock_quantity = Convert.ToDecimal(radGridView1.Rows[e.RowIndex].Cells["StockQuantity"].Value); }
            catch { }
            if (Convert.ToDecimal(e.Value) > stock_quantity)
            {
                MessageBox.Show("Số lượng xuất vượt quá tồn kho.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Row.Cells[e.ColumnIndex].Value = 0;
                e.Row.Cells[e.ColumnIndex].EndEdit();
            }

        }

        void LoadData()
        {
            Class.iTreeTableAdapters.Sel_Harvest_ExportTableAdapter harvestexport = new Class.iTreeTableAdapters.Sel_Harvest_ExportTableAdapter();
            radGridView1.DataSource = harvestexport.GetData(radDateTimePicker1.Value);

            Class.iTreeTableAdapters.HarvestTableAdapter harvest = new Class.iTreeTableAdapters.HarvestTableAdapter();
            radGridView2.DataSource = harvest.GetByDateAndType(radDateTimePicker1.Value, "X");
        }
        
    }
}
