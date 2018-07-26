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
    public partial class frmImport : Form
    {
        public frmImport()
        {
            InitializeComponent();
        }
        private int ItemId = 0;

        private void btnSave_Click(object sender, EventArgs e)
        {
          

            Class.iTreeTableAdapters.ItemTableAdapter _item = new Class.iTreeTableAdapters.ItemTableAdapter();
            if (this.ItemId.Equals(0))
            {
                _item.Insert(Convert.ToInt32(dpItemList.SelectedValue), "N", dtpTranDate.Value, dpUnit.SelectedValue.ToString(),
                    Convert.ToDecimal(txtUnitPrice.Value), Convert.ToDecimal(txtQuantity.Value), 0,0, dpTreeType.SelectedValue.ToString(), 0, txtRemarks.Text, 0);

            }
            else
            {
                _itemRow.ItemListId = Convert.ToInt32(dpItemList.SelectedValue);
                _itemRow.TranDate = dtpTranDate.Value;
                _itemRow.Unit = dpUnit.SelectedValue.ToString();
                _itemRow.UnitPrice = Convert.ToDecimal(txtUnitPrice.Value);
                _itemRow.Quantity = Convert.ToDecimal(txtQuantity.Value);
                _itemRow.TreeType = dpTreeType.SelectedValue.ToString();
                _itemRow.Remarks = txtRemarks.Text;
                _item.Update(_itemRow);

            }
            pictureBox1_Click(null, null);
            LoadGrid();
        }

        private void frmImport_Load(object sender, EventArgs e)
        {
            LoadCombo();
            LoadGrid();
        }

        void LoadCombo()
        {
            Class.iTreeTableAdapters.ListItemTableAdapter _listitem = new Class.iTreeTableAdapters.ListItemTableAdapter();
            dpItemList.DisplayMember = "ItemName";
            dpItemList.ValueMember = "ItemListId";
            dpItemList.DataSource = _listitem.GetData();

            //Class.iTreeTableAdapters.ItemTableAdapter _item = new Class.iTreeTableAdapters.ItemTableAdapter();
            //txtUnit.AutoCompleteDisplayMember = "Unit";
            //txtUnit.AutoCompleteValueMember = "Unit";
            //txtUnit.AutoCompleteDataSource = _item.GetUnit();

            Class.iTreeTableAdapters.TreeTypeTableAdapter _treetype = new Class.iTreeTableAdapters.TreeTypeTableAdapter();
            dpTreeType.DisplayMember = "TreeType";
            dpTreeType.ValueMember = "TreeTypeId";
            dpTreeType.DataSource = _treetype.GetData();
           

            dtpTranDate.Value = DateTime.Today;
        }
       
        void LoadGrid()
        {
            Class.iTreeTableAdapters.ItemTableAdapter _item = new Class.iTreeTableAdapters.ItemTableAdapter();
            radGridView1.DataSource = _item.GetByTranType("N");
        }
        Class.iTree.ItemRow _itemRow;
        void LoadEdit()
        {
            if (this.ItemId > 0)
            {
                Class.iTreeTableAdapters.ItemTableAdapter _item = new Class.iTreeTableAdapters.ItemTableAdapter();
                _itemRow = _item.GetByKey(ItemId).Rows[0] as Class.iTree.ItemRow;
                dpItemList.SelectedValue = _itemRow.ItemListId;
                dpUnit.SelectedValue = _itemRow.Unit;
                dtpTranDate.Value = _itemRow.TranDate;
                dpTreeType.SelectedValue = Convert.ToInt32(_itemRow.TreeType);
                txtUnitPrice.Value = _itemRow.UnitPrice;
                txtQuantity.Value = _itemRow.Quantity;
                txtRemarks.Text = _itemRow.Remarks;
                btnSave.Text = "Cập nhật...";
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra. Vui lòng chọn lại", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void radGridView1_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (e.Column.Name.Equals("Edit"))
            {
                try { this.ItemId = Convert.ToInt32(radGridView1.Rows[e.RowIndex].Cells["ItemId"].Value); }
                catch { }
                LoadEdit();
            }
            if (e.Column.Name.Equals("Delete"))
            {
                int id = 0;
                try { id = Convert.ToInt32(radGridView1.Rows[e.RowIndex].Cells["ItemId"].Value); }
                catch { }
                if (id > 0)
                {
                    Class.iTreeTableAdapters.ItemTableAdapter _item = new Class.iTreeTableAdapters.ItemTableAdapter();
                    _item.Delete1(id);

                    LoadGrid();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.ItemId = 0;
            
            dtpTranDate.Value = DateTime.Today;
            dpTreeType.SelectedText = string.Empty;
            txtUnitPrice.Value = 0;
            txtQuantity.Value = 0;
            txtRemarks.Text = string.Empty;
            btnSave.Text = "Nhập kho...";
        }

        private void dpItemList_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            Class.iTreeTableAdapters.ListItemTableAdapter listitem = new Class.iTreeTableAdapters.ListItemTableAdapter();
            dpUnit.DisplayMember = "Unit";
            dpUnit.ValueMember = "Unit";
            dpUnit.DataSource = listitem.GetByKey(Convert.ToInt32(dpItemList.SelectedValue));
        }
    }
}
