namespace iTree.Category
{
    partial class frmProductPrice
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.dtpDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
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
            this.splitContainer1.Size = new System.Drawing.Size(285, 280);
            this.splitContainer1.SplitterDistance = 32;
            this.splitContainer1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.radLabel1);
            this.flowLayoutPanel1.Controls.Add(this.dtpDate);
            this.flowLayoutPanel1.Controls.Add(this.btnSave);
            this.flowLayoutPanel1.Controls.Add(this.radLabel2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(285, 32);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(3, 3);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(33, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Ngày";
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(42, 3);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(91, 20);
            this.dtpDate.TabIndex = 3;
            this.dtpDate.TabStop = false;
            this.dtpDate.Text = "01/07/2018";
            this.dtpDate.Value = new System.DateTime(2018, 7, 1, 20, 49, 35, 363);
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(139, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(71, 24);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Lưu...";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            gridViewTextBoxColumn1.FieldName = "ProductPriceId";
            gridViewTextBoxColumn1.HeaderText = "ProductPriceId";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "ProductPriceId";
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
            gridViewTextBoxColumn4.Width = 45;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "ProductName";
            gridViewTextBoxColumn5.HeaderText = "Thành phẩm";
            gridViewTextBoxColumn5.Name = "ProductName";
            gridViewTextBoxColumn5.ReadOnly = true;
            gridViewTextBoxColumn5.Width = 133;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "Quality";
            gridViewTextBoxColumn6.HeaderText = "Chất lượng";
            gridViewTextBoxColumn6.IsVisible = false;
            gridViewTextBoxColumn6.Name = "Quality";
            gridViewTextBoxColumn6.ReadOnly = true;
            gridViewTextBoxColumn6.Width = 101;
            gridViewDecimalColumn1.DecimalPlaces = 0;
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "Price";
            gridViewDecimalColumn1.FormatString = "{0:N0}";
            gridViewDecimalColumn1.HeaderText = "Đơn giá (đ)";
            gridViewDecimalColumn1.Name = "Price";
            gridViewDecimalColumn1.ShowUpDownButtons = false;
            gridViewDecimalColumn1.ThousandsSeparator = true;
            gridViewDecimalColumn1.Width = 88;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewDecimalColumn1});
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radGridView1.Size = new System.Drawing.Size(285, 244);
            this.radGridView1.TabIndex = 0;
            this.radGridView1.ViewCellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.radGridView1_ViewCellFormatting);
            // 
            // radLabel2
            // 
            this.radLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Underline);
            this.radLabel2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.radLabel2.Location = new System.Drawing.Point(216, 3);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(64, 18);
            this.radLabel2.TabIndex = 5;
            this.radLabel2.Text = "Tham chiếu";
            this.radLabel2.Click += new System.EventHandler(this.radLabel2_Click);
            // 
            // frmProductPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 280);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProductPrice";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đơn giá thành phẩm";
            this.Load += new System.EventHandler(this.frmProductPrice_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadDateTimePicker dtpDate;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
    }
}