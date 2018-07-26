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

using CrystalDecisions.CrystalReports;
using CrystalDecisions.ReportSource;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace iTree.Report
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }
        private decimal salary_unit = 0;
        private string location = string.Empty;
        private int title_id = 0;
        private int area_d3 = 0;

        private void frmReport_Load(object sender, EventArgs e)
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

            Class.iTreeTableAdapters.UserTableAdapter _user = new Class.iTreeTableAdapters.UserTableAdapter();
            dpUser.DisplayMember = "FullName";
            dpUser.ValueMember = "UserId";
            dpUser.DataSource = _user.GetData();

            dpAccountant.DisplayMember = "FullName";
            dpAccountant.ValueMember = "UserId";
            dpAccountant.DataSource = _user.GetAccountant();
            try { dpAccountant.SelectedIndex = 0; }
            catch { }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (this.title_id.Equals(4))
                LoadReportCNHT();
            else if (this.title_id.Equals(3))
                LoadReportCNCM();

        }

        private void SetParameterToReport(string[] arrParameterFieldName, string[] arrParameterDiscreteValue)
        {
            ParameterFields crParameterFields;
            ParameterField crParameterField;
            ParameterDiscreteValue crParameterDiscreteValue;
            try
            {
                crParameterFields = new ParameterFields();
                for (int i = 0; i < arrParameterFieldName.Length; i++)
                {
                    crParameterDiscreteValue = new ParameterDiscreteValue();
                    crParameterDiscreteValue.Value = arrParameterDiscreteValue[i];
                    crParameterField = new ParameterField();
                    crParameterField.CurrentValues.Clear();
                    crParameterField.ParameterFieldName = arrParameterFieldName[i];
                    crParameterField.CurrentValues.Add(crParameterDiscreteValue);
                    crParameterField.HasCurrentValue = true;
                    crParameterFields.Add(crParameterField);
                }
                crvReport.ParameterFieldInfo = crParameterFields;
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dpUser_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            Class.iTreeTableAdapters.UserTableAdapter _user = new Class.iTreeTableAdapters.UserTableAdapter();
            Class.iTree.UserRow _rowuser = _user.GetByKey((int)dpUser.SelectedValue).Rows[0] as Class.iTree.UserRow;
            this.salary_unit = _rowuser.Salary/30;
            this.title_id = _rowuser.TitleId;

            try
            {
                Class.iTreeTableAdapters.UserAreaTableAdapter _userarea = new Class.iTreeTableAdapters.UserAreaTableAdapter();
                Class.iTree.UserAreaRow _rowuserarea = _userarea.GetByUser((int)dpUser.SelectedValue).Rows[0] as Class.iTree.UserAreaRow;
                this.location = string.Concat(_rowuserarea["LocationName"].ToString(), " - ", _rowuserarea["AreaName"].ToString());

                Class.iTreeTableAdapters.AreaTableAdapter _area = new Class.iTreeTableAdapters.AreaTableAdapter();
                Class.iTree.AreaRow _rowarea = _area.GetByKey(_rowuserarea.AreaId).Rows[0] as Class.iTree.AreaRow;
                this.area_d3 = _rowarea.TotalTree;
            }
            catch { }
        }

        void LoadReportCNHT()
        {
            DateTime f = new DateTime((int)dpYear.SelectedValue, (int)dpMonth.SelectedValue, 1);
            DateTime t = f.AddMonths(1).AddDays(-1);
            decimal salary = 0;

            Class.iTreeTableAdapters.Sel_Salary_ByUserTableAdapter _salary = new Class.iTreeTableAdapters.Sel_Salary_ByUserTableAdapter();
            DataTable dt = _salary.GetData(f, t, (int)dpUser.SelectedValue, 0);
            dt.Columns["Check"].ReadOnly = false;
            dt.Columns["Check"].MaxLength = 200;
            foreach (DataRow dr in dt.Rows)
            {
                dr.BeginEdit();
                dr["Check"] = "Mất: ";
                if (!dr["MissBowl"].ToString().Equals("0")) dr["Check"] += string.Concat(dr["MissBowl"].ToString(), " chén; ");
                if (!dr["MissTree"].ToString().Equals("0")) dr["Check"] += string.Concat(dr["MissTree"].ToString(), " cây; ");
                if (!dr["MissOther"].ToString().Equals("0")) dr["Check"] += string.Concat(dr["MissOther"].ToString(), " khác");

                if (dr["Check"].ToString().Length.Equals(5)) dr["Check"] = string.Empty;
                dr.EndEdit();

                salary = salary_unit * Convert.ToUInt32(dr["WorkDays"]);
            }
            dt.AcceptChanges();

            ReportDocument oRpt = new ReportDocument();
            oRpt.Load(Application.StartupPath + @"\Rpt\CNHT.rpt");
            oRpt.SetDataSource(dt);

            SetParameterToReport(new string[] { "pMonth", "pYear", "pFullName", "pUserId", "pLocation", "pAccountant", "pAmount" },
                new string[] { dpMonth.Text, dpYear.Text, dpUser.Text, dpUser.SelectedValue.ToString(), this.location, dpAccountant.Text, salary.ToString("N0") }
                );

            oRpt.Refresh();
            crvReport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            crvReport.ReportSource = oRpt;
            crvReport.RefreshReport();
        }

        void LoadReportCNCM()
        {
            DateTime f = new DateTime((int)dpYear.SelectedValue, (int)dpMonth.SelectedValue, 1);
            DateTime t = f.AddMonths(1).AddDays(-1);

            Class.iTreeTableAdapters.Sel_Salary_ByUserTableAdapter _salary = new Class.iTreeTableAdapters.Sel_Salary_ByUserTableAdapter();
            DataTable dt = _salary.GetData(f, t, (int)dpUser.SelectedValue, 1);

            ReportDocument oRpt = new ReportDocument();
            oRpt.Load(Application.StartupPath + @"\Rpt\CNCM.rpt");
            oRpt.SetDataSource(dt);

            SetParameterToReport(new string[] { "pMonth", "pYear", "pFullName", "pUserId", "pLocation", "pAccountant", "pD3" },
                new string[] { dpMonth.Text, dpYear.Text, dpUser.Text, dpUser.SelectedValue.ToString(), this.location, dpAccountant.Text, area_d3.ToString("N0") }
                );

            oRpt.Refresh();
            crvReport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            crvReport.ReportSource = oRpt;
            crvReport.RefreshReport();
        }
    }
}
