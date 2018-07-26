using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Telerik.WinControls.UI;

namespace iTree.Category
{
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
            radGridView1.AutoGenerateColumns = false;
            grdUser.AutoGenerateColumns = false;
        }
        public int UserId = 0;
        byte[] identity;
        byte[] staying;
        byte[] contract;
        byte[] other;
        private void frmUser_Load(object sender, EventArgs e)
        {
            LoadCombo();
            LoadData();
        }
        void LoadCombo()
        {
            Class.iTreeTableAdapters.vw_TitleTableAdapter _title = new Class.iTreeTableAdapters.vw_TitleTableAdapter();
            dpTitle.ValueMember = "TitleId";
            dpTitle.DisplayMember = "TitleName";
            dpTitle.DataSource = _title.GetData();
        }
        void LoadData()
        {
            Class.iTreeTableAdapters.UserTableAdapter _user = new Class.iTreeTableAdapters.UserTableAdapter();
            grdUser.DataSource = _user.GetData2();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFullName.Text))
            {
                errorProvider1.SetError(txtFullName, "*");
                return;
            }
            Class.iTreeTableAdapters.UserTableAdapter _user = new Class.iTreeTableAdapters.UserTableAdapter();
            Class.iTreeTableAdapters.UserAreaTableAdapter _area = new Class.iTreeTableAdapters.UserAreaTableAdapter();


            this.UserId = (Int32)_user.Ins_User(txtFullName.Text, "123456", Convert.ToInt32(dpTitle.SelectedValue),
                dtpFrom.Value, dtpTo.Checked ? dtpTo.Value : new DateTime(1900, 1, 1),
                this.identity, this.staying, this.contract, this.other, Convert.ToDecimal(txtSalary.Value), this.UserId);


            foreach (GridViewRowInfo rowInfo in radGridView1.Rows)
            {
                DateTime f = new DateTime(1900, 1, 1);
                DateTime t = new DateTime(1900, 1, 1);
                try { f = Convert.ToDateTime(rowInfo.Cells["From"].Value); }
                catch { }
                try { t = Convert.ToDateTime(rowInfo.Cells["To"].Value); }
                catch { }

                try
                {
                    _area.Ins_UserArea(this.UserId,
                  rowInfo.Cells["LocationName"].Value.ToString(),
                  rowInfo.Cells["AreaName"].Value.ToString(),
                  f, t);
                }
                catch { }
            }
            LoadData();
        }
        Class.iTree.UserRow _rowUser;
        void LoadEdit()
        {
            Class.iTreeTableAdapters.UserTableAdapter _user = new Class.iTreeTableAdapters.UserTableAdapter();
            _rowUser = _user.GetByKey(this.UserId).Rows[0] as Class.iTree.UserRow;
            txtFullName.Text = _rowUser.FullName;
            dpTitle.SelectedValue = _rowUser.TitleId;
            dtpFrom.Value = _rowUser.From;
            dtpTo.Checked = !_rowUser.To.Year.Equals(1900);
            dtpTo.Value = !_rowUser.To.Year.Equals(1900) ? _rowUser.To : DateTime.Today;
            txtSalary.Value = _rowUser.Salary;

            Class.iTreeTableAdapters.Sel_UserArea_ByUserTableAdapter _userArea = new Class.iTreeTableAdapters.Sel_UserArea_ByUserTableAdapter();
            radGridView1.DataSource = _userArea.GetData(this.UserId);
            btnSave.Text = "Cập nhật...";
        }

        private void radGridView1_CellEditorInitialized(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            RadDropDownListEditor editor = e.ActiveEditor as RadDropDownListEditor;
            try
            {
                if (editor != null)
                {

                    RadDropDownListEditorElement element = (RadDropDownListEditorElement)editor.EditorElement;
                    if (e.Column.Name.Equals("LocationName"))
                    {
                        Class.iTreeTableAdapters.LocationTableAdapter _location = new Class.iTreeTableAdapters.LocationTableAdapter();
                        element.DisplayMember = "LocationName";
                        element.ValueMember = "LocationName";

                        element.DataSource = _location.GetData();
                        element.ShowPopup();
                    }
                    if (e.Column.Name.Equals("AreaName"))
                    {
                        Class.iTreeTableAdapters.AreaTableAdapter _area = new Class.iTreeTableAdapters.AreaTableAdapter();
                        element.DisplayMember = "AreaName";
                        element.ValueMember = "AreaName";
                        element.DataSource = _area.GetByLocationName(e.Row.Cells["LocationName"].Value.ToString());
                        element.ShowPopup();
                    }
                    if (e.RowIndex >= 0)
                        element.SelectedIndex = element.FindString(e.Value.ToString());
                }
            }
            catch { }
        }

        private void radGridView1_CellValueChanged(object sender, GridViewCellEventArgs e)
        {
            if (e.Column.Name.Equals("LocationName"))
            {

                Class.iTreeTableAdapters.AreaTableAdapter _area = new Class.iTreeTableAdapters.AreaTableAdapter();
                Class.iTree.AreaDataTable dt = _area.GetByLocationName(e.Value.ToString());
                if (dt.Rows.Count > 0)
                    e.Row.Cells["AreaName"].Value = dt.Rows[0]["AreaName"];

            }
        }

        private void grdUser_CommandCellClick(object sender, GridViewCellEventArgs e)
        {
            this.UserId = Convert.ToInt32(grdUser.Rows[e.RowIndex].Cells["UserId"].Value);
            if (e.Column.Name.Equals("Edit"))
            {
                LoadEdit();

            }
            if (e.Column.Name.Equals("Delete"))
            {
                Class.iTreeTableAdapters.UserTableAdapter _user = new Class.iTreeTableAdapters.UserTableAdapter();
                _rowUser = _user.GetByKey(this.UserId).Rows[0] as Class.iTree.UserRow;
                _rowUser.Status = false;
                _user.Update(_rowUser);
                LoadData();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            txtFullName.Text = string.Empty;
            dtpFrom.Value = DateTime.Today;
            dtpTo.Checked = false;
            dtpTo.Value = DateTime.Today;
            txtSalary.Value = 0;

            this.identity = null;
            this.staying = null;
            this.contract = null;
            this.other = null;

            radGridView1.DataSource = new DataTable();
            this.UserId = 0;
            btnSave.Text = "Tạo mới...";
        }

        private void btnIdentity_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileStream fs = File.OpenRead(openFileDialog1.FileName);
                identity = new byte[fs.Length];
                fs.Read(identity, 0, (int)fs.Length);
                fs.Close();
            }
        }

        private void btnStaying_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileStream fs = File.OpenRead(openFileDialog1.FileName);
                staying = new byte[fs.Length];
                fs.Read(staying, 0, (int)fs.Length);
                fs.Close();
            }
        }

        private void btnContract_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileStream fs = File.OpenRead(openFileDialog1.FileName);
                contract = new byte[fs.Length];
                fs.Read(contract, 0, (int)fs.Length);
                fs.Close();
            }
        }

        private void btnOther_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileStream fs = File.OpenRead(openFileDialog1.FileName);
                other = new byte[fs.Length];
                fs.Read(contract, 0, (int)fs.Length);
                fs.Close();
            }
        }

        private void grdUser_CellEditorInitialized(object sender, GridViewCellEventArgs e)
        {
            RadDropDownListEditor editor = e.ActiveEditor as RadDropDownListEditor;
            if (editor != null)
            {
                RadDropDownListEditorElement element = (RadDropDownListEditorElement)editor.EditorElement;
                if (e.Column.Name.Equals("Files"))
                {
                    element.DataSource = new string[] { "CMND", "Tạm trú", "Hợp đồng", "Khác" };
                    element.DropDownWidth = 100;
                    element.ShowPopup();
                }
            }
        }

        private void grdUser_CellValueChanged(object sender, GridViewCellEventArgs e)
        {
            if (e.Column.Name.Equals("Files"))
            {
                this.Cursor = Cursors.WaitCursor;
                string file_name = string.Empty;
                System.IO.Directory.CreateDirectory("Temp");
                Class.iTreeTableAdapters.UserTableAdapter _user = new Class.iTreeTableAdapters.UserTableAdapter();
                Class.iTree.UserDataTable _dt_user = _user.GetByKey(this.UserId);
                if (_dt_user.Rows.Count > 0)
                {
                    _rowUser = _dt_user.Rows[0] as Class.iTree.UserRow;

                    if (e.Value.ToString().ToLower().Equals("cmnd"))
                    {
                        try
                        {
                            byte[] file_data = (byte[])_rowUser.Identity;
                            file_name = string.Concat("Temp\\", this.UserId.ToString(), "_CMND.pdf");

                            using (System.IO.FileStream fs = new System.IO.FileStream(file_name, System.IO.FileMode.Create, System.IO.FileAccess.ReadWrite))
                            {
                                using (System.IO.BinaryWriter bw = new System.IO.BinaryWriter(fs))
                                {
                                    bw.Write(file_data);
                                    bw.Close();
                                }
                            }
                            System.Diagnostics.Process.Start(file_name);
                        }
                        catch
                        {
                            MessageBox.Show("File không có hoặc bị lỗi.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Cursor = Cursors.Default;
                        }
                    }
                    if (e.Value.ToString().ToLower().Equals("tạm trú"))
                    {

                        try
                        {
                            byte[] file_data = (byte[])_rowUser.Staying;
                            file_name = string.Concat("Temp\\", this.UserId.ToString(), "_tạm_trú.pdf");

                            using (System.IO.FileStream fs = new System.IO.FileStream(file_name, System.IO.FileMode.Create, System.IO.FileAccess.ReadWrite))
                            {
                                using (System.IO.BinaryWriter bw = new System.IO.BinaryWriter(fs))
                                {
                                    bw.Write(file_data);
                                    bw.Close();
                                }
                            }
                            System.Diagnostics.Process.Start(file_name);
                        }
                        catch
                        {
                            MessageBox.Show("File không có hoặc bị lỗi.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Cursor = Cursors.Default;
                        }

                    }
                    if (e.Value.ToString().ToLower().Equals("hợp đồng"))
                    {
                        try
                        {
                            byte[] file_data = (byte[])_rowUser.Contract;
                            file_name = string.Concat("Temp\\", this.UserId.ToString(), "_hợp_đồng.pdf");

                            using (System.IO.FileStream fs = new System.IO.FileStream(file_name, System.IO.FileMode.Create, System.IO.FileAccess.ReadWrite))
                            {
                                using (System.IO.BinaryWriter bw = new System.IO.BinaryWriter(fs))
                                {
                                    bw.Write(file_data);
                                    bw.Close();
                                }
                            }
                            System.Diagnostics.Process.Start(file_name);
                        }
                        catch
                        {
                            MessageBox.Show("File không có hoặc bị lỗi.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Cursor = Cursors.Default;
                        }
                    }
                    if (e.Value.ToString().ToLower().Equals("khác"))
                    {
                        try
                        {
                            byte[] file_data = (byte[])_rowUser.Other;
                            file_name = string.Concat("Temp\\", this.UserId.ToString(), "_khác.pdf");

                            using (System.IO.FileStream fs = new System.IO.FileStream(file_name, System.IO.FileMode.Create, System.IO.FileAccess.ReadWrite))
                            {
                                using (System.IO.BinaryWriter bw = new System.IO.BinaryWriter(fs))
                                {
                                    bw.Write(file_data);
                                    bw.Close();
                                }
                            }
                            System.Diagnostics.Process.Start(file_name);
                        }
                        catch
                        {
                            MessageBox.Show("File không có hoặc bị lỗi.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Cursor = Cursors.Default;
                        }
                    }
                

                }
                this.Cursor = Cursors.Default;
            }
        }

        private void grdUser_CellClick(object sender, GridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            this.UserId = Convert.ToInt32(grdUser.Rows[e.RowIndex].Cells["UserId"].Value);
        }

        private void grdUser_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.CellElement.ColumnInfo.Name.Equals("To"))
            {
                if (e.CellElement.Text != null)
                    if (e.CellElement.Text.Contains("1900"))
                        e.CellElement.Text = string.Empty;
            }
        }
    }
}
