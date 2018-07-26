namespace iTree.Care
{
    partial class frmAddHarvest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewSummaryItem gridViewSummaryItem1 = new Telerik.WinControls.UI.GridViewSummaryItem();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn1 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.dpUser = new Telerik.WinControls.UI.RadDropDownList();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.radSplitContainer1 = new Telerik.WinControls.UI.RadSplitContainer();
            this.splitPanel1 = new Telerik.WinControls.UI.SplitPanel();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.splitPanel2 = new Telerik.WinControls.UI.SplitPanel();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.grdWeather = new Telerik.WinControls.UI.RadGridView();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).BeginInit();
            this.radSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).BeginInit();
            this.splitPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).BeginInit();
            this.splitPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdWeather)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdWeather.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.radLabel1);
            this.flowLayoutPanel1.Controls.Add(this.dpUser);
            this.flowLayoutPanel1.Controls.Add(this.btnSave);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(294, 29);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(3, 3);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(57, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Nhân viên";
            // 
            // dpUser
            // 
            this.dpUser.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.dpUser.Location = new System.Drawing.Point(66, 3);
            this.dpUser.Name = "dpUser";
            this.dpUser.Size = new System.Drawing.Size(135, 20);
            this.dpUser.TabIndex = 1;
            this.dpUser.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.dpUser_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(207, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(77, 24);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Lưu...";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // radSplitContainer1
            // 
            this.radSplitContainer1.Controls.Add(this.splitPanel1);
            this.radSplitContainer1.Controls.Add(this.splitPanel2);
            this.radSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.radSplitContainer1.Name = "radSplitContainer1";
            this.radSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // 
            // 
            this.radSplitContainer1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.radSplitContainer1.Size = new System.Drawing.Size(298, 472);
            this.radSplitContainer1.TabIndex = 1;
            this.radSplitContainer1.TabStop = false;
            // 
            // splitPanel1
            // 
            this.splitPanel1.Controls.Add(this.radGroupBox1);
            this.splitPanel1.Location = new System.Drawing.Point(0, 0);
            this.splitPanel1.Name = "splitPanel1";
            // 
            // 
            // 
            this.splitPanel1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel1.Size = new System.Drawing.Size(298, 294);
            this.splitPanel1.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0F, 0.1282051F);
            this.splitPanel1.SizeInfo.SplitterCorrection = new System.Drawing.Size(0, 29);
            this.splitPanel1.TabIndex = 0;
            this.splitPanel1.TabStop = false;
            this.splitPanel1.Text = "splitPanel1";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.splitContainer1);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.HeaderText = "Nhập sản lượng cho";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(298, 294);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "Nhập sản lượng cho";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(2, 18);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.radGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(294, 274);
            this.splitContainer1.SplitterDistance = 29;
            this.splitContainer1.TabIndex = 0;
            // 
            // radGridView1
            // 
            this.radGridView1.BackColor = System.Drawing.SystemColors.Control;
            this.radGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radGridView1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radGridView1.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AllowDeleteRow = false;
            this.radGridView1.MasterTemplate.AllowDragToGroup = false;
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "HarvestId";
            gridViewTextBoxColumn1.HeaderText = "HarvestId";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "HarvestId";
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "ProductId";
            gridViewTextBoxColumn2.HeaderText = "ProductId";
            gridViewTextBoxColumn2.IsVisible = false;
            gridViewTextBoxColumn2.Name = "ProductId";
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "ProductQualityId";
            gridViewTextBoxColumn3.HeaderText = "ProductQualityId";
            gridViewTextBoxColumn3.IsVisible = false;
            gridViewTextBoxColumn3.Name = "ProductQualityId";
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.HeaderText = "STT";
            gridViewTextBoxColumn4.Name = "No";
            gridViewTextBoxColumn4.ReadOnly = true;
            gridViewTextBoxColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn4.Width = 39;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "ProductName";
            gridViewTextBoxColumn5.HeaderText = "Sản phẩm";
            gridViewTextBoxColumn5.Name = "ProductName";
            gridViewTextBoxColumn5.ReadOnly = true;
            gridViewTextBoxColumn5.Width = 116;
            gridViewDecimalColumn1.FieldName = "Degree";
            gridViewDecimalColumn1.HeaderText = "Độ mủ";
            gridViewDecimalColumn1.Name = "Degree";
            gridViewDecimalColumn1.Width = 43;
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "Quantity";
            gridViewDecimalColumn2.FormatString = "{0:N2}";
            gridViewDecimalColumn2.HeaderText = "Số lượng (kgs)";
            gridViewDecimalColumn2.Name = "Quantity";
            gridViewDecimalColumn2.ShowUpDownButtons = false;
            gridViewDecimalColumn2.ThousandsSeparator = true;
            gridViewDecimalColumn2.Width = 78;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewDecimalColumn1,
            gridViewDecimalColumn2});
            this.radGridView1.MasterTemplate.EnableGrouping = false;
            gridViewSummaryItem1.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Sum;
            gridViewSummaryItem1.AggregateExpression = null;
            gridViewSummaryItem1.FormatString = "{0}";
            gridViewSummaryItem1.Name = "Quantity";
            this.radGridView1.MasterTemplate.SummaryRowsBottom.Add(new Telerik.WinControls.UI.GridViewSummaryRowItem(new Telerik.WinControls.UI.GridViewSummaryItem[] {
                gridViewSummaryItem1}));
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radGridView1.Size = new System.Drawing.Size(294, 241);
            this.radGridView1.TabIndex = 1;
            this.radGridView1.ViewCellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.radGridView1_ViewCellFormatting);
            // 
            // splitPanel2
            // 
            this.splitPanel2.Controls.Add(this.radGroupBox2);
            this.splitPanel2.Location = new System.Drawing.Point(0, 298);
            this.splitPanel2.Name = "splitPanel2";
            // 
            // 
            // 
            this.splitPanel2.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel2.Size = new System.Drawing.Size(298, 174);
            this.splitPanel2.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0F, -0.1282051F);
            this.splitPanel2.SizeInfo.SplitterCorrection = new System.Drawing.Size(0, -29);
            this.splitPanel2.TabIndex = 1;
            this.splitPanel2.TabStop = false;
            this.splitPanel2.Text = "splitPanel2";
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Controls.Add(this.grdWeather);
            this.radGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox2.HeaderText = "Thời thiết";
            this.radGroupBox2.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(298, 174);
            this.radGroupBox2.TabIndex = 1;
            this.radGroupBox2.Text = "Thời thiết";
            // 
            // grdWeather
            // 
            this.grdWeather.BackColor = System.Drawing.SystemColors.Control;
            this.grdWeather.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdWeather.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdWeather.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.grdWeather.ForeColor = System.Drawing.Color.Black;
            this.grdWeather.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grdWeather.Location = new System.Drawing.Point(2, 18);
            // 
            // 
            // 
            this.grdWeather.MasterTemplate.AllowDragToGroup = false;
            this.grdWeather.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "From";
            gridViewTextBoxColumn6.HeaderText = "Từ";
            gridViewTextBoxColumn6.Name = "From";
            gridViewTextBoxColumn6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn6.Width = 66;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "To";
            gridViewTextBoxColumn7.HeaderText = "Đến";
            gridViewTextBoxColumn7.Name = "To";
            gridViewTextBoxColumn7.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn7.Width = 66;
            gridViewComboBoxColumn1.EnableExpressionEditor = false;
            gridViewComboBoxColumn1.FieldName = "Weather";
            gridViewComboBoxColumn1.HeaderText = "Thời tiết";
            gridViewComboBoxColumn1.Name = "Weather";
            gridViewComboBoxColumn1.Width = 143;
            this.grdWeather.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewComboBoxColumn1});
            this.grdWeather.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.grdWeather.Name = "grdWeather";
            this.grdWeather.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grdWeather.Size = new System.Drawing.Size(294, 154);
            this.grdWeather.TabIndex = 0;
            this.grdWeather.CellEditorInitialized += new Telerik.WinControls.UI.GridViewCellEventHandler(this.grdWeather_CellEditorInitialized);
            // 
            // frmAddHarvest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 472);
            this.Controls.Add(this.radSplitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddHarvest";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmAddHarvest_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).EndInit();
            this.radSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).EndInit();
            this.splitPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).EndInit();
            this.splitPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdWeather.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdWeather)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadDropDownList dpUser;
        private Telerik.WinControls.UI.RadSplitContainer radSplitContainer1;
        private Telerik.WinControls.UI.SplitPanel splitPanel1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Telerik.WinControls.UI.SplitPanel splitPanel2;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadGridView grdWeather;
    }
}