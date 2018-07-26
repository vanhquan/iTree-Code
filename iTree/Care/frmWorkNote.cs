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
    public partial class frmWorkNote : Form
    {
        public frmWorkNote()
        {
            InitializeComponent();
        }
        private bool bLoading = true;
        private int work_note_id = 0;
        private void frmWorkNote_Load(object sender, EventArgs e)
        {
            dtpWorkDate.Value = DateTime.Today;
            dtpFromDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpToDate.Value = dtpToDate.Value.AddMonths(1).AddDays(-1);
            LoadCombo();
            bLoading = false;
            LoadData();
        }
        void LoadCombo()
        {
            Class.iTreeTableAdapters.UserTableAdapter _user = new Class.iTreeTableAdapters.UserTableAdapter();
            dpUser.DisplayMember = "FullName";
            dpUser.ValueMember = "UserId";
            dpUserSearch.DisplayMember = "FullName";
            dpUserSearch.ValueMember = "UserId";

            dpUser.DataSource = _user.GetDataPlus();
            dpUserSearch.DataSource = _user.GetDataPlus();

            Class.iTreeTableAdapters.ListWorkTableAdapter _listwork = new Class.iTreeTableAdapters.ListWorkTableAdapter();
            dpWork.DisplayMember = "Name";
            dpWork.ValueMember = "WorkId";
            //dpWork.CheckedMember = ""
            dpWork.DataSource = _listwork.GetData();

            Class.iTreeTableAdapters.LocationTableAdapter _location = new Class.iTreeTableAdapters.LocationTableAdapter();
            dpLocation.DisplayMember = "LocationName";
            dpLocation.ValueMember = "LocationId";
            dpLocation.DataSource = _location.GetDataPlus();
        }

        private void dpLocation_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            Class.iTreeTableAdapters.AreaTableAdapter _area = new Class.iTreeTableAdapters.AreaTableAdapter();
            dpArea.DisplayMember = "AreaName";
            dpArea.ValueMember = "AreaId";
            dpArea.DataSource = _area.GetByLocation((int)dpLocation.SelectedValue);
        }
        void LoadData()
        {
            Class.iTreeTableAdapters.WorkNoteTableAdapter _worknote = new Class.iTreeTableAdapters.WorkNoteTableAdapter();
            radGridView1.DataSource = _worknote.GetByFilter(dtpFromDate.Value, dtpToDate.Value, (int)dpUserSearch.SelectedValue);
        }

        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            if (!bLoading)
                LoadData();
        }

        private void dtpToDate_ValueChanged(object sender, EventArgs e)
        {
            if (!bLoading)
                LoadData();
        }

        private void dpUserSearch_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (!bLoading)
                LoadData();
        }
        void LoadEdit()
        {
            Class.iTreeTableAdapters.WorkNoteTableAdapter _worknote = new Class.iTreeTableAdapters.WorkNoteTableAdapter();
            Class.iTree.WorkNoteRow _row = _worknote.GetByKey(work_note_id).Rows[0] as Class.iTree.WorkNoteRow;

            dtpWorkDate.Value = _row.WorkDate;
            dpUser.SelectedValue = _row.UserId;

            foreach(RadCheckedListDataItem itm in dpWork.Items)
            {
                if (itm.Value.Equals(_row.WorkId))
                    itm.Checked = true;
            }

            dpLocation.SelectedValue = _row.LocationId;
            dpArea.SelectedValue = _row.AreaId;
            txtMissBowl.Value = _row.MissBowl;
            txtMissTree.Value = _row.MissTree;
            txtMissOther.Value = _row.MissOther;
            txtRemarks.Text = _row.Remarks;
            btnSave.Text = "Cập nhật...";

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try { dpWork.CheckedItems.Clear(); }
            catch { }
            dtpWorkDate.Value = DateTime.Today;
            txtMissBowl.Value = 0;
            txtMissTree.Value = 0;
            txtMissOther.Value = 0;
            this.work_note_id = 0;
            btnSave.Text = "Lưu...";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Class.iTreeTableAdapters.WorkNoteTableAdapter _worknote = new Class.iTreeTableAdapters.WorkNoteTableAdapter();
            for (int i = 0; i < dpWork.CheckedItems.Count; i++)
            {
                int location_id =0, area_id = 0;
                try { location_id = (int)dpLocation.SelectedValue; }
                catch { }
                try { area_id = (int)dpArea.SelectedValue; }
                catch { }
                _worknote.Ins_WorkNote((int)dpWork.CheckedItems[i].Value, (int)dpUser.SelectedValue, dtpWorkDate.Value,
                    location_id, area_id,
                    Convert.ToInt32(txtMissBowl.Value), Convert.ToInt32(txtMissTree.Value), Convert.ToInt32(txtMissOther.Value),
                    txtRemarks.Text, clsGlobal.UserId, this.work_note_id);
            }
            MessageBox.Show("Lưu thành công.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
            pictureBox1_Click(null,null);
            LoadData();
        }

        private void radGridView1_ViewCellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            if (e.Column.Name.Equals("No")) e.CellElement.Text = (e.RowIndex + 1).ToString();
        }

        private void radGridView1_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            this.work_note_id = Convert.ToInt32(radGridView1.Rows[e.RowIndex].Cells["WorkNoteId"].Value);
            if (e.Column.Name.Equals("Edit"))
            {
                LoadEdit();

            }
            if (e.Column.Name.Equals("Delete"))
            {
                Class.iTreeTableAdapters.WorkNoteTableAdapter _worknote = new Class.iTreeTableAdapters.WorkNoteTableAdapter();
                _worknote.Delete1(this.work_note_id);
                LoadData();
            }
        }
    }
}
