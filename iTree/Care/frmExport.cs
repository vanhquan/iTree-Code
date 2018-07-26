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
    public partial class frmExport : Form
    {
        public frmExport()
        {
            InitializeComponent();
        }
        private int ItemId = 0;
        Class.iTree.ItemRow _itemRow;
        private void frmExport_Load(object sender, EventArgs e)
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

            Class.iTreeTableAdapters.LocationTableAdapter _location = new Class.iTreeTableAdapters.LocationTableAdapter();
            dpLocation.DisplayMember = "LocationName";
            dpLocation.ValueMember = "LocationId";
            dpLocation.DataSource = _location.GetData();


            dtpTranDate.Value = DateTime.Today;

            Class.iTreeTableAdapters.UserTableAdapter _user = new Class.iTreeTableAdapters.UserTableAdapter();
            dpUser.DisplayMember = "FullName";
            dpUser.ValueMember = "UserId";
            dpUser.DataSource = _user.GetData();

        }
        void LoadUnit()
        {
            Class.iTreeTableAdapters.ItemTableAdapter _item = new Class.iTreeTableAdapters.ItemTableAdapter();

            dpUnit.DisplayMember = "Unit";
            dpUnit.ValueMember = "Unit";
            dpUnit.DataSource = _item.GetByItemList(Convert.ToInt32(dpItemList.SelectedValue));
        }


        private void dpLocation_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            Class.iTreeTableAdapters.AreaTableAdapter _area = new Class.iTreeTableAdapters.AreaTableAdapter();
            dpArea.DisplayMember = "AreaName";
            dpArea.ValueMember = "AreaId";
            dpArea.DataSource = _area.GetByLocation(Convert.ToInt32(dpLocation.SelectedValue));

        }

        private void dpArea_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            Class.iTreeTableAdapters.TreeTableAdapter _tree = new Class.iTreeTableAdapters.TreeTableAdapter();
            dpTree.DisplayMember = "TreeCode";
            dpTree.ValueMember = "TreeId";
            dpTree.DataSource = _tree.GetByArea(Convert.ToInt32(dpArea.SelectedValue));

        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            Class.iTreeTableAdapters.ItemTableAdapter _item = new Class.iTreeTableAdapters.ItemTableAdapter();
            if (this.ItemId.Equals(0))
            {
                _item.Insert(Convert.ToInt32(dpItemList.SelectedValue), "X", dtpTranDate.Value, dpUnit.SelectedValue.ToString(),
                    0, Convert.ToDecimal(txtQuantity.Value), Convert.ToInt32(dpTree.SelectedValue), Convert.ToInt32(dpArea.SelectedValue),
                                 string.Empty, Convert.ToInt32(dpUser.SelectedValue), txtRemarks.Text, Convert.ToInt32(dpLocation.SelectedValue));
            }
            else
            {
                _itemRow.ItemListId = Convert.ToInt32(dpItemList.SelectedValue);
                _itemRow.TranDate = dtpTranDate.Value;
                _itemRow.Unit = dpUnit.SelectedValue.ToString();
                _itemRow.Quantity = Convert.ToDecimal(txtQuantity.Value);
                _itemRow.LocationId = Convert.ToInt32(dpLocation.SelectedValue);
                _itemRow.AreaId = Convert.ToInt32(dpArea.SelectedValue);
                _itemRow.TreeId = Convert.ToInt32(dpTree.SelectedValue);
                _itemRow.UserId = Convert.ToInt32(dpUser.SelectedValue);
                _itemRow.Remarks = txtRemarks.Text;
                _item.Update(_itemRow);

            }
            pictureBox1_Click(null, null);
            LoadGrid();
        }

        void LoadGrid()
        {
            Class.iTreeTableAdapters.ItemTableAdapter _item = new Class.iTreeTableAdapters.ItemTableAdapter();
            radGridView1.DataSource = _item.GetByTranType("X");
        }
        void LoadEdit()
        {
            if (this.ItemId > 0)
            {
                Class.iTreeTableAdapters.ItemTableAdapter _item = new Class.iTreeTableAdapters.ItemTableAdapter();
                _itemRow = _item.GetByKey(ItemId).Rows[0] as Class.iTree.ItemRow;
                dpItemList.SelectedValue = _itemRow.ItemListId;
                LoadUnit();
                dpUnit.SelectedValue = _itemRow.Unit;
                dtpTranDate.Value = _itemRow.TranDate;
                txtQuantity.Value = _itemRow.Quantity;
                txtRemarks.Text = _itemRow.Remarks;
                dpLocation.SelectedValue = _itemRow.LocationId;

                //Class.iTreeTableAdapters.TreeTableAdapter _tree = new Class.iTreeTableAdapters.TreeTableAdapter();
                //DataRow dr = _tree.GetInformation(_itemRow.TreeId).Rows[0] as DataRow;
                //dpLocation.SelectedValue = Convert.ToInt32(dr["LocationId"]);
                dpArea.SelectedValue = _itemRow.AreaId;
                dpTree.SelectedValue = _itemRow.TreeId;
                dpUser.SelectedValue = _itemRow.UserId;
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
            //txtItemName.Text = string.Empty;
            dpUnit.SelectedValue = string.Empty;
            dtpTranDate.Value = DateTime.Today;
            txtQuantity.Value = 0;
            txtRemarks.Text = string.Empty;
            btnSave.Text = "Nhập kho...";
        }

        private void dpItemList_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            LoadUnit();
        }
    }
}
