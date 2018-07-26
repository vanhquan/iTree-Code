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
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
            //radGridView1.AutoGenerateColumns = false;
        }

        private int product_id = 0;
        private Class.iTree.ProductRow product_row;

        private void frmProduct_Load(object sender, EventArgs e)
        {
            LoadTreeType();
        }
        void LoadTreeType()
        {
            Class.iTreeTableAdapters.TreeTypeTableAdapter _treetype = new Class.iTreeTableAdapters.TreeTypeTableAdapter();
            dpTreeType.DisplayMember = "TreeType";
            dpTreeType.ValueMember = "TreeTypeId";
            dpTreeType.DataSource = _treetype.GetData();
        }
        void LoadProduct()
        {
            Class.iTreeTableAdapters.ProductTableAdapter _product = new Class.iTreeTableAdapters.ProductTableAdapter();
            dpProduct.DisplayMember = "ProductName";
            dpProduct.ValueMember = "ProductId";
            dpProduct.DataSource = _product.GetByTreeTypeNew(Convert.ToInt32(dpTreeType.SelectedValue));
            dpProduct.SelectedValue = -1;
        }
        //void LoadProductQuality()
        //{

        //    Class.iTreeTableAdapters.ProductQualityTableAdapter _productquality = new Class.iTreeTableAdapters.ProductQualityTableAdapter();
        //    radGridView1.DataSource = _productquality.GetByProduct(product_id);
        //}
        private void dpProduct_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            try { product_id = Convert.ToInt32(dpProduct.SelectedValue); }
            catch { }

            if (dpProduct.SelectedValue == null) return;

            if (dpProduct.SelectedValue.ToString().Equals("0"))
            {
                txtProductName.Text = string.Empty;
                chkDiffQuantity.Checked = false;
                product_id = 0;
                btnSave.Text = "Thêm mới...";
            }
            else if (product_id > 0)
            {
                btnSave.Text = "Lưu...";
            }

            if (product_id > 0)
            {
                Class.iTreeTableAdapters.ProductTableAdapter _product = new Class.iTreeTableAdapters.ProductTableAdapter();
                product_row = _product.GetByKey(product_id).Rows[0] as Class.iTree.ProductRow;
                txtProductName.Text = product_row.ProductName;
                chkDiffQuantity.Checked = product_row.DiffQuantity;
            }

            //LoadProductQuality();
        }

        private void dpTreeType_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            LoadProduct();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Class.iTreeTableAdapters.ProductTableAdapter _product = new Class.iTreeTableAdapters.ProductTableAdapter();
            if (product_id > 0)
            {

                product_row.ProductName = txtProductName.Text;
                product_row.DiffQuantity = chkDiffQuantity.Checked;
                _product.Update(product_row);
            }
            else if (product_id.Equals(0))
            {
                _product.Insert(txtProductName.Text, Convert.ToInt32(dpTreeType.SelectedValue), chkDiffQuantity.Checked);
                LoadProduct();
            }

        }

     

     

        
    }

}
