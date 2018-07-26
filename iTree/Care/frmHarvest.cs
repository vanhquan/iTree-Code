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
using System.Globalization;
namespace iTree.Care
{
    public partial class frmHarvest : Form
    {
        public frmHarvest()
        {
            InitializeComponent();
            grdHarvest.AutoGenerateColumns = true;
            grdHarvest.EnableGrouping = false;
            grdHarvest.AllowAddNewRow = false;
            grdHarvest.AllowDeleteRow = false;
            grdHarvest.ReadOnly = true;
            grdHarvest.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            grdHarvest.AutoSizeRows = true;
        }
        private bool bLoading = true;
        private void frmHarvest_Load(object sender, EventArgs e)
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
            bLoading = false;
            dpYear.SelectedValue = DateTime.Today.Year;
        }

        void LoadData()
        {
            if (!bLoading)
            {
                DateTime from = new DateTime(int.Parse(dpYear.SelectedValue.ToString()), int.Parse(dpMonth.SelectedValue.ToString()), 1);
                DateTime firstOfNextMonth = from.AddMonths(1);
                DateTime to = firstOfNextMonth.AddDays(-1);

                Class.iTreeTableAdapters.Sel_HarvestTableAdapter _harvest = new Class.iTreeTableAdapters.Sel_HarvestTableAdapter();
                grdHarvest.DataSource = _harvest.GetData(from, to);
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

        private void grdHarvest_DataBindingComplete(object sender, GridViewBindingCompleteEventArgs e)
        {
            grdHarvest.Columns["UserId"].IsVisible = false;

            grdHarvest.Columns["FullName"].Width = 150;
            grdHarvest.Columns["FullName"].HeaderText = "Nhân viên";
            grdHarvest.Columns["FullName"].IsPinned = true;

            for (int i = 2; i < grdHarvest.Columns.Count; i++)
            {
                //grdHarvest.Columns[i].TextAlignment = ContentAlignment.MiddleCenter;
                //grdHarvest.Columns[i].AllowFiltering = false;
                //grdHarvest.Columns[i].Width = 50;
                grdHarvest.Columns[i].WrapText = true;
            }
        }

        private void grdHarvest_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int user_id = Convert.ToInt32(grdHarvest.Rows[e.RowIndex].Cells["UserId"].Value);
            string dt = string.Empty;
            dt = grdHarvest.Columns[e.ColumnIndex].Name;
            DateTime date = new DateTime(1900, 1, 1);
            try { date = DateTime.ParseExact(dt, "dd/MM/yy", CultureInfo.InvariantCulture); }
            catch { }

            Care.frmAddHarvest frm = new frmAddHarvest();
            frm.date = date;
            frm.user_id = user_id;
            if (frm.ShowDialog() == DialogResult.OK)
                LoadData();
        }
    }
}
