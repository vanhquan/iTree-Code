using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI.Scheduler.Dialogs;
namespace iTree.Category
{
    public partial class CustomAppointmentEditForm : Telerik.WinControls.UI.Scheduler.Dialogs.EditAppointmentDialog
    {
        public CustomAppointmentEditForm()
        {
            InitializeComponent();
        }
        private DateTime SelectedDate;
        private int TreeWaterId = 0;
        public int TreeId = 0;
        protected override void LoadSettingsFromEvent(Telerik.WinControls.UI.IEvent ev)
        {
            base.LoadSettingsFromEvent(ev);
            try { TreeWaterId = Convert.ToInt32(ev.UniqueId.ToString()); }
            catch { TreeWaterId = 0; }
            try { TreeId = Convert.ToInt32(ev.StatusId.ToString()); }
            catch { TreeId = 0; }

            Class.iTreeTableAdapters.TreeWaterTableAdapter _treeWater = new Class.iTreeTableAdapters.TreeWaterTableAdapter();
            txtUser.AutoCompleteDataSource = _treeWater.GetUser();
            txtUser.AutoCompleteDisplayMember = "User";
            txtUser.AutoCompleteValueMember = "User";

            this.SelectedDate = new DateTime(ev.Start.Year, ev.Start.Month, ev.Start.Day);

            if (TreeWaterId > 0)
            {
                Class.iTree.TreeWaterDataTable dt = _treeWater.GetByKey(this.TreeWaterId);
                if (dt.Rows.Count > 0)
                {
                    Class.iTree.TreeWaterRow row = dt.Rows[0] as Class.iTree.TreeWaterRow;
                    this.txtUser.Text = string.Concat(row["User"].ToString(), ";");
                    cmbBackground.SelectedValue = row.BackgroundId;
                    dateStart.Value = row.From;
                    dateEnd.Value = row.To;
                    timeStart.Value = row.From;
                    timeEnd.Value = row.To;
                    textBoxDescription.Text = row.Remarks;
                }
            }


        }

        protected override void ApplySettingsToEvent(Telerik.WinControls.UI.IEvent ev)
        {
            txtSubject.Text = txtUser.Text.Length > 0 ? txtUser.Items[0].Text : "Noboby";
            txtLocation.Text = textBoxDescription.Text;

            Class.iTreeTableAdapters.TreeWaterTableAdapter _treeWater = new Class.iTreeTableAdapters.TreeWaterTableAdapter();
            if (this.TreeWaterId > 0)
            {
                _treeWater.Update1(dateStart.Value, dateEnd.Value, txtUser.Items[0].Text, textBoxDescription.Text,
                    Convert.ToInt32(cmbBackground.SelectedValue), chkAllDay.Checked, this.TreeWaterId);
            }
            else
            {
                _treeWater.Insert(this.TreeId, dateStart.Value, dateEnd.Value, txtUser.Items[0].Text, textBoxDescription.Text,
                                      Convert.ToInt32(cmbBackground.SelectedValue), chkAllDay.Checked);
            }
            base.ApplySettingsToEvent(ev);
        }

        protected override Telerik.WinControls.UI.IEvent CreateNewEvent()
        {
            return new CustomAppointment();
        }

        private void CustomAppointmentEditForm_Load(object sender, EventArgs e)
        {

        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Class.iTreeTableAdapters.TreeWaterTableAdapter _treeWater = new Class.iTreeTableAdapters.TreeWaterTableAdapter();
                _treeWater.Delete1(this.TreeWaterId);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text.Length > 0)
                txtUser.Text = txtUser.Text + ";";
        }
    }
}
