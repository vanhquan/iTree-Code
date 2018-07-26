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

namespace iTree.Category
{
    public partial class frmProductPrice : Form
    {
        public frmProductPrice()
        {
            InitializeComponent();
            radGridView1.AutoGenerateColumns = false;
        }

        private void radGridView1_ViewCellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            if (e.Column.Name.Equals("No")) e.CellElement.Text = (e.RowIndex + 1).ToString();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            Class.iTreeTableAdapters.Sel_ProductPriceByDateTableAdapter _productprice = new Class.iTreeTableAdapters.Sel_ProductPriceByDateTableAdapter();
            radGridView1.DataSource = _productprice.GetData(dtpDate.Value);
        }

        private void frmProductPrice_Load(object sender, EventArgs e)
        {
            dtpDate.Value = DateTime.Today;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Class.iTreeTableAdapters.ProductPriceTableAdapter _productprice = new Class.iTreeTableAdapters.ProductPriceTableAdapter();
            foreach (GridViewRowInfo row in radGridView1.Rows)
            {
                int product_price_id = 0;
                int product_id = 0;
                int product_quality_id = 0;
                decimal price = 0;

                try { product_price_id = Convert.ToInt32(row.Cells["ProductPriceId"].Value); }
                catch { }
                try { product_id = Convert.ToInt32(row.Cells["ProductId"].Value); }
                catch { }
                try { product_quality_id = Convert.ToInt32(row.Cells["ProductQualityId"].Value); }
                catch { }
                try { price = Convert.ToDecimal(row.Cells["Price"].Value); }
                catch { }

                if (product_price_id.Equals(0))
                    _productprice.Insert(product_id, product_quality_id, dtpDate.Value, price);
                else _productprice.Update1(price, product_price_id);
            }
        }

        private void radLabel2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.locninhrubber.vn/bang-gia/");
        }
    }
}
