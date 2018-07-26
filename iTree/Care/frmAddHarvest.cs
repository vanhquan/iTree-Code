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
    public partial class frmAddHarvest : Form
    {
        public frmAddHarvest()
        {
            InitializeComponent();
        }
        public int user_id = 0;
        public DateTime date;
        private void frmAddHarvest_Load(object sender, EventArgs e)
        {
            Class.iTreeTableAdapters.UserTableAdapter _user = new Class.iTreeTableAdapters.UserTableAdapter();
            dpUser.DisplayMember = "FullName";
            dpUser.ValueMember = "UserId";
            dpUser.DataSource = _user.GetData();
            dpUser.SelectedValue = user_id;

            this.Text = string.Concat("Thu hoạch ngày ", date.ToString("dd/MM/yyyy"));
            LoadWeather();
        }

        private void dpUser_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            LoadHarvest();
        }

        void LoadHarvest()
        {
            Class.iTreeTableAdapters.Sel_Harvest_ByUserTableAdapter _harvest = new Class.iTreeTableAdapters.Sel_Harvest_ByUserTableAdapter();
            radGridView1.DataSource = _harvest.GetData(date, (int)dpUser.SelectedValue);
        }
        void LoadWeather()
        {
            Class.iTreeTableAdapters.WeatherTableAdapter _weather = new Class.iTreeTableAdapters.WeatherTableAdapter();
            grdWeather.DataSource = _weather.GetByDate(this.date);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Class.iTreeTableAdapters.HarvestTableAdapter _harvest = new Class.iTreeTableAdapters.HarvestTableAdapter();
            _harvest.DeleteByUserDate(this.date, (int)dpUser.SelectedValue);
            foreach (GridViewRowInfo row in radGridView1.Rows)
            {
                int harvest_id = 0;
                int product_id = 0;
                decimal degree = 0;
                decimal quantity = 0;

                try { harvest_id = Convert.ToInt32(row.Cells["HarvestId"].Value); }
                catch { }
                try { product_id = Convert.ToInt32(row.Cells["ProductId"].Value); }
                catch { }
                try { quantity = Convert.ToDecimal(row.Cells["Quantity"].Value); }
                catch { }
                try { degree = Convert.ToDecimal(row.Cells["Degree"].Value); }
                catch { }

                if (quantity > 0)
                    _harvest.Insert(product_id, 0, this.date, (int)dpUser.SelectedValue, quantity, "N", degree);

            }

            Class.iTreeTableAdapters.WeatherTableAdapter _weather = new Class.iTreeTableAdapters.WeatherTableAdapter();
            _weather.DeleteByDate(this.date);
            foreach (GridViewRowInfo row in grdWeather.Rows)
            {
                _weather.Insert(this.date, row.Cells["Weather"].Value.ToString(), row.Cells["From"].Value.ToString(), row.Cells["To"].Value.ToString());
            }

            this.DialogResult = DialogResult.OK;
        }
        private void grdWeather_CellEditorInitialized(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            RadDropDownListEditor editor = e.ActiveEditor as RadDropDownListEditor;
            try
            {
                if (editor != null)
                {

                    RadDropDownListEditorElement element = (RadDropDownListEditorElement)editor.EditorElement;
                    if (e.Column.Name.Equals("Weather"))
                    {
                        Class.iTreeTableAdapters.vw_WeatherTableAdapter _weather = new Class.iTreeTableAdapters.vw_WeatherTableAdapter();
                        element.DisplayMember = "Weather";
                        element.ValueMember = "Weather";

                        element.DataSource = _weather.GetData();
                        element.ShowPopup();
                    }

                    if (e.RowIndex >= 0)
                        element.SelectedIndex = element.FindString(e.Value.ToString());
                }
            }
            catch { }
        }

        private void radGridView1_ViewCellFormatting(object sender, CellFormattingEventArgs e)
        {
            if (e.Column.Name.Equals("No")) e.CellElement.Text = (e.RowIndex + 1).ToString();
        }
    }
}
