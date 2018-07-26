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
    public partial class frmLedger : Form
    {
        public frmLedger()
        {
            InitializeComponent();
            radGridView1.AutoGenerateColumns = false;

            ConditionalFormattingObject obj = new ConditionalFormattingObject("MyCondition", ConditionTypes.Less, "0", "", false);
            obj.CellForeColor = Color.Red;
            this.radGridView1.Columns["SignAmount"].ConditionalFormattingObjectList.Add(obj);

        }
        public string mode = string.Empty;
        private int ledger_id = 0;
        private bool bLoading = true;
        Class.iTree.LedgerRow ledger_row;

        private void frmLedger_Load(object sender, EventArgs e)
        {
            for (int m = 1; m <= 12; m++)
            {
                dpMonth.Items.Add(new RadListDataItem(m.ToString(), m));
            }
            for (int y = DateTime.Today.Year - 3; y <= DateTime.Today.Year + 1; y++)
            {
                dpYear.Items.Add(new RadListDataItem(y.ToString(), y));
            }
            dpMonth.SelectedValue = DateTime.Today.Month;
            dpYear.SelectedValue = DateTime.Today.Year;

            DataTable dtTranType = new DataTable();
            dtTranType.Columns.Add("Value", typeof(string));
            dtTranType.Columns.Add("Text", typeof(string));
            dtTranType.Rows.Add(" ", " ");
            dtTranType.Rows.Add("N", "Phiếu nhập");
            dtTranType.Rows.Add("X", "Phiếu xuất");
            dtTranType.Rows.Add("U", "Tạm ứng");
            dpTranType.DisplayMember = "Text";
            dpTranType.ValueMember = "Value";
            dpTranType.DataSource = dtTranType;

            Class.iTreeTableAdapters.UserTableAdapter _user = new Class.iTreeTableAdapters.UserTableAdapter();
            dpUser.DisplayMember = "FullName";
            dpUser.ValueMember = "UserId";
            dpUser.DataSource = _user.GetData();

            bLoading = false;

            if (mode.Equals("U"))
            { rbU.IsChecked = true; }
            else if (mode.Equals("X"))
            { rbX.IsChecked = true; }
            else { rbN.IsChecked = true; }

            dpTranType.SelectedValue = mode;


        }
        void LoadEdit()
        {
            Class.iTreeTableAdapters.LedgerTableAdapter _ledger = new Class.iTreeTableAdapters.LedgerTableAdapter();
            ledger_row = _ledger.GetByKey(this.ledger_id).Rows[0] as Class.iTree.LedgerRow;

            this.ledger_id = ledger_row.LedgerId;
            switch (ledger_row.TranType)
            {
                case "N":
                    rbN.IsChecked = true;
                    break;
                case "X":
                    rbX.IsChecked = true;
                    break;
                case "U":
                    rbU.IsChecked = true;
                    break;
            }
            dtpTranDate.Value = ledger_row.TranDate;
            txtInvoice.Text = ledger_row.Invoice;
            dpUser.SelectedValue = ledger_row.UserId;
            txtAmount.Value = ledger_row.Amount;
            txtContent.Text = ledger_row.Content;
            btnSave.Text = "Cập nhật...";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Class.iTreeTableAdapters.LedgerTableAdapter _ledger = new Class.iTreeTableAdapters.LedgerTableAdapter();
            string tran_type = string.Empty;
            if (rbN.IsChecked) tran_type = "N";
            else if (rbX.IsChecked) tran_type = "X";
            else if (rbU.IsChecked) tran_type = "U";
            if (this.ledger_id.Equals(0))
            {
                _ledger.Insert(tran_type, dtpTranDate.Value, txtInvoice.Text, txtContent.Text, Convert.ToDecimal(txtAmount.Value), (int)dpUser.SelectedValue, 1, clsGlobal.UserId, DateTime.Now, clsGlobal.UserId, DateTime.Now);
            }
            else
            {
                ledger_row.TranType = tran_type;
                ledger_row.TranDate = dtpTranDate.Value;
                ledger_row.Invoice = txtInvoice.Text;
                ledger_row.UserId = (int)dpUser.SelectedValue;
                ledger_row.Amount = Convert.ToDecimal(txtAmount.Value);
                ledger_row.Content = txtContent.Text;
                _ledger.Update(ledger_row);
            }
            LoadData();
        }
        void LoadData()
        {
            if (!bLoading)
            {
                Class.iTreeTableAdapters.LedgerTableAdapter _ledger = new Class.iTreeTableAdapters.LedgerTableAdapter();
                radGridView1.DataSource = _ledger.GetByFilter((int)dpMonth.SelectedValue, (int)dpYear.SelectedValue, dpTranType.SelectedValue.ToString());
            }
        }

        private void dpMonth_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            LoadData();
        }

        private void dpYear_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            LoadData();
        }

        private void dpTranType_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            LoadData();
        }

        private void MasterTemplate_ViewCellFormatting(object sender, CellFormattingEventArgs e)
        {
            if (e.Column.Name.Equals("No")) e.CellElement.Text = (e.RowIndex + 1).ToString();
        }

        private void MasterTemplate_CommandCellClick(object sender, GridViewCellEventArgs e)
        {
            if (e.Column.Name.Equals("Edit"))
            {
                try { this.ledger_id = Convert.ToInt32(radGridView1.Rows[e.RowIndex].Cells["LedgerId"].Value); }
                catch { }
                LoadEdit();
            }
            if (e.Column.Name.Equals("Del"))
            {
                int id = 0;
                try { id = Convert.ToInt32(radGridView1.Rows[e.RowIndex].Cells["LedgerId"].Value); }
                catch { }
                if (id > 0)
                {
                    Class.iTreeTableAdapters.LedgerTableAdapter _ledger = new Class.iTreeTableAdapters.LedgerTableAdapter();
                    _ledger.Delete1(id);

                    LoadData();
                }
            }
        }
    }
}
