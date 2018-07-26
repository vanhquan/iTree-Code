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
using Telerik.WinControls;
using Telerik.WinControls.UI.Scheduler.Dialogs;

namespace iTree.Category
{
    public partial class frmTree : Form
    {
        Class.iTreeTableAdapters.TreeWaterTableAdapter _treeWater = new Class.iTreeTableAdapters.TreeWaterTableAdapter();
        public frmTree()
        {
            InitializeComponent();
            SchedulerMonthView monthView = this.radScheduler1.ActiveView as SchedulerMonthView;
            monthView.ShowWeeksHeader = false;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.radScheduler1.AppointmentFactory = new CustomAppointmentFactory();
            this.radScheduler1.AppointmentEditDialogShowing += RadScheduler1_AppointmentEditDialogShowing;
        }
        private IEditAppointmentDialog appointmentDialog = null;

        private int ROWCOUNT = 0;
        private int COLUMNCOUNT = 0;
        public int AreaId = 0;
        private int SelectedTreeId = 0;
        private void frmTree_Load(object sender, EventArgs e)
        {
            LoadGrid();
            LoadData();
            ApplyGreen();
        }
        void LoadGrid()
        {
            Class.iTreeTableAdapters.AreaTableAdapter _area = new Class.iTreeTableAdapters.AreaTableAdapter();
            Class.iTree.AreaRow row = _area.GetByKey(this.AreaId)[0] as Class.iTree.AreaRow;
            this.ROWCOUNT = row.Rows;
            this.COLUMNCOUNT = row.Columns;
            this.Text = string.Concat("Cây - ", row.AreaName);

            this.radGridView1.ShowGroupPanel = false;
            //this.radGridView1.VirtualMode = true;
            this.radGridView1.RowCount = ROWCOUNT;
            this.radGridView1.ColumnCount = COLUMNCOUNT;
            this.radGridView1.BackColor = Color.Transparent;
            this.radGridView1.ReadOnly = true;
            this.radGridView1.TableElement.DrawFill = false;
            this.radGridView1.TableElement.RowHeight = 50;
            this.radGridView1.TableElement.CellSpacing = 0;
            this.radGridView1.TableElement.RowSpacing = 0;
            this.radGridView1.MasterTemplate.ShowRowHeaderColumn = false;
            this.radGridView1.MasterTemplate.ShowColumnHeaders = false;
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.SelectionMode = Telerik.WinControls.UI.GridViewSelectionMode.CellSelect;
        }
        void LoadData()
        {
            Class.iTreeTableAdapters.TreeTableAdapter _tree = new Class.iTreeTableAdapters.TreeTableAdapter();
            Class.iTree.TreeDataTable dt = _tree.GetByArea(this.AreaId);
            foreach (Class.iTree.TreeRow dr in dt.Rows)
            {
                radGridView1.Rows[dr.Row].Cells[dr.Column].Value = dr.TreeCode;
                radGridView1.Rows[dr.Row].Cells[dr.Column].Tag = string.Concat(dr.TreeId, ";", dr["Green"].ToString());
            }
        }
        private void radGridView1_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            Point location = this.radGridView1.CurrentCell.GridControl.PointToScreen(this.radGridView1.CurrentCell.ControlBoundingRectangle.Location);
            location.Y += this.radGridView1.CurrentCell.Size.Height;
            int treeId = 0;
            try { treeId = Convert.ToInt32(radGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag.ToString().Split(new char[] { ';' })[0]); }
            catch { }

            Category.frmTreeConfig frm = new frmTreeConfig();
            frm.p = location;
            frm.AreaId = this.AreaId;
            frm.TreeId = treeId;

            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(frm.TreeCode))
                {
                    Class.iTreeTableAdapters.TreeTableAdapter _tree = new Class.iTreeTableAdapters.TreeTableAdapter();
                    if (treeId.Equals(0))
                        _tree.Insert(this.AreaId, frm.TreeCode, frm.TreeTypeId, frm.PlantMonth, frm.PlantYear, e.RowIndex, e.ColumnIndex, frm.Lat, frm.Long, 1);
                    else
                        _tree.Update1(frm.TreeCode, frm.TreeTypeId, frm.PlantMonth, frm.PlantYear, frm.Lat, frm.Long, 1, treeId);

                    radGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = frm.TreeCode;

                }

            }

        }

        private void RadScheduler1_AppointmentEditDialogShowing(object sender, AppointmentEditDialogShowingEventArgs e)
        {
            if (this.appointmentDialog == null)
            { this.appointmentDialog = new CustomAppointmentEditForm(); }
            e.AppointmentEditDialog = this.appointmentDialog;
        }


        private void BindToDataSet(int TreeId)
        {

            this.iTree1 = new Class.iTree();
            this._treeWater.FillByGetByTree(this.iTree1.TreeWater, SelectedTreeId);

            Class.iTreeTableAdapters.ResourcesTableAdapter resourcesAdapter = new Class.iTreeTableAdapters.ResourcesTableAdapter();
            resourcesAdapter.Fill(this.iTree1.Resources);

            Class.iTreeTableAdapters.TreeWaterResourcesTableAdapter appointmentsResourcesAdapter = new Class.iTreeTableAdapters.TreeWaterResourcesTableAdapter();
            appointmentsResourcesAdapter.Fill(this.iTree1.TreeWaterResources);


            SchedulerBindingDataSource dataSource = new SchedulerBindingDataSource();
            dataSource.EventProvider.AppointmentFactory = this.radScheduler1.AppointmentFactory;

            AppointmentMappingInfo appointmentMappingInfo = new AppointmentMappingInfo();

            //appointmentMappingInfo.Mappings.Add(new SchedulerMapping("ReserveId", "ReserveId"));

            appointmentMappingInfo.UniqueId = "TreeWaterId";
            appointmentMappingInfo.Start = "From";
            appointmentMappingInfo.End = "To";
            appointmentMappingInfo.Summary = "Remarks";
            appointmentMappingInfo.Description = "User";
            appointmentMappingInfo.BackgroundId = "BackgroundId";
            appointmentMappingInfo.AllDay = "AllDay";
            appointmentMappingInfo.StatusId = "TreeId";

            appointmentMappingInfo.Resources = "AppointmentsAppointmentsResources";
            appointmentMappingInfo.ResourceId = "ID";

            dataSource.EventProvider.Mapping = appointmentMappingInfo;
            dataSource.EventProvider.DataSource = this.iTree1.TreeWater;

            ResourceMappingInfo resourceMappingInfo = new ResourceMappingInfo();
            resourceMappingInfo.Id = "ID";
            resourceMappingInfo.Name = "Name";

            dataSource.ResourceProvider.Mapping = resourceMappingInfo;
            dataSource.ResourceProvider.DataSource = this.iTree1.TreeWater;

            this.radScheduler1.DataSource = dataSource;
        }

        private void radGridView1_CurrentCellChanged(object sender, CurrentCellChangedEventArgs e)
        {
            if (this.radGridView1.CurrentCell != null)
            {
                pageWater.Text = string.Concat("Lịch tưới: ", radGridView1.CurrentCell.Text);
                try { SelectedTreeId = Convert.ToInt32(radGridView1.Rows[radGridView1.CurrentCell.RowIndex].Cells[radGridView1.CurrentCell.ColumnIndex].Tag.ToString().Split(new char[] { ';' })[0]); }
                catch { }
                if (this.SelectedTreeId > 0)
                    BindToDataSet(this.SelectedTreeId);
            }

        }
        
        private void ApplyGreen()
        {
            for (int y = 0; y < this.radGridView1.RowCount; y++)
            {
                for (int x = 0; x < this.radGridView1.ColumnCount; x++)
                {
                    bool green = false;
                    try { green = radGridView1.Rows[y].Cells[x].Tag.ToString().Split(new char[] { ';' })[1].Equals("1") ? true : false; }
                    catch { }

                    if (green)
                    {
                        this.radGridView1.Rows[y].Cells[x].Style.CustomizeFill = true;
                        this.radGridView1.Rows[y].Cells[x].Style.DrawFill = true;
                        this.radGridView1.Rows[y].Cells[x].Style.BackColor = Color.LightGreen;
                    }
                }
            }
        }

        private void radPageView1_SelectedPageChanged(object sender, EventArgs e)
        {
            if (radPageView1.SelectedPage.Name.Equals("pageTree"))
                ApplyGreen();
        }
    }

    public class CustomAppointment : Appointment
    {
        public CustomAppointment()
            : base()
        {
        }
    }
    public class CustomAppointmentFactory : IAppointmentFactory
    {
        #region IAppointmentFactory Members 

        public IEvent CreateNewAppointment()
        {
            return new CustomAppointment();
        }

        #endregion
    }
}
