namespace iTree.Care
{
    partial class frmExportHarvest
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radDateTimePicker1 = new Telerik.WinControls.UI.RadDateTimePicker();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.radGridView2 = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView2.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(402, 382);
            this.splitContainer1.SplitterDistance = 33;
            this.splitContainer1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.radLabel1);
            this.flowLayoutPanel1.Controls.Add(this.radDateTimePicker1);
            this.flowLayoutPanel1.Controls.Add(this.btnSave);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(402, 33);
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
            // radDateTimePicker1
            // 
            this.radDateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.radDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.radDateTimePicker1.Location = new System.Drawing.Point(42, 3);
            this.radDateTimePicker1.Name = "radDateTimePicker1";
            this.radDateTimePicker1.Size = new System.Drawing.Size(87, 20);
            this.radDateTimePicker1.TabIndex = 1;
            this.radDateTimePicker1.TabStop = false;
            this.radDateTimePicker1.Text = "24/07/2018";
            this.radDateTimePicker1.Value = new System.DateTime(2018, 7, 24, 14, 46, 42, 158);
            this.radDateTimePicker1.ValueChanged += new System.EventHandler(this.radDateTimePicker1_ValueChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(135, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 24);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Xuất kho...";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.radGroupBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.radGroupBox2);
            this.splitContainer2.Size = new System.Drawing.Size(402, 345);
            this.splitContainer2.SplitterDistance = 200;
            this.splitContainer2.TabIndex = 0;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radGridView1);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.HeaderText = "Tồn kho";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(402, 200);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "Tồn kho";
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Controls.Add(this.radGridView2);
            this.radGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox2.HeaderText = "Đã xuất";
            this.radGroupBox2.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(402, 141);
            this.radGroupBox2.TabIndex = 0;
            this.radGroupBox2.Text = "Đã xuất";
            // 
            // radGridView1
            // 
            this.radGridView1.BackColor = System.Drawing.SystemColors.Control;
            this.radGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radGridView1.ForeColor = System.Drawing.Color.Black;
            this.radGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radGridView1.Location = new System.Drawing.Point(2, 18);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AllowDeleteRow = false;
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "ProductId";
            gridViewTextBoxColumn1.HeaderText = "ProductId";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "ProductId";
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.HeaderText = "STT";
            gridViewTextBoxColumn2.Name = "No";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn2.Width = 54;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "ProductName";
            gridViewTextBoxColumn3.HeaderText = "Sản phẩm";
            gridViewTextBoxColumn3.Name = "ProductName";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.Width = 109;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "StockQuantity";
            gridViewTextBoxColumn4.HeaderText = "Tồn kho";
            gridViewTextBoxColumn4.Name = "StockQuantity";
            gridViewTextBoxColumn4.ReadOnly = true;
            gridViewTextBoxColumn4.Width = 109;
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.HeaderText = "Xuất kho";
            gridViewDecimalColumn1.Name = "Quantity";
            gridViewDecimalColumn1.Width = 108;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewDecimalColumn1});
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radGridView1.ShowGroupPanel = false;
            this.radGridView1.Size = new System.Drawing.Size(398, 180);
            this.radGridView1.TabIndex = 0;
            this.radGridView1.ViewCellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.radGridView1_ViewCellFormatting);
            this.radGridView1.CellEndEdit += new Telerik.WinControls.UI.GridViewCellEventHandler(this.radGridView1_CellEndEdit);
            // 
            // radGridView2
            // 
            this.radGridView2.BackColor = System.Drawing.SystemColors.Control;
            this.radGridView2.Cursor = System.Windows.Forms.Cursors.Default;
            this.radGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radGridView2.ForeColor = System.Drawing.Color.Black;
            this.radGridView2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radGridView2.Location = new System.Drawing.Point(2, 18);
            // 
            // 
            // 
            this.radGridView2.MasterTemplate.AllowAddNewRow = false;
            this.radGridView2.MasterTemplate.AllowDeleteRow = false;
            this.radGridView2.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn5.FieldName = "HarvestId";
            gridViewTextBoxColumn5.HeaderText = "HarvestId";
            gridViewTextBoxColumn5.IsVisible = false;
            gridViewTextBoxColumn5.Name = "HarvestId";
            gridViewTextBoxColumn5.Width = 59;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.HeaderText = "STT";
            gridViewTextBoxColumn6.Name = "No";
            gridViewTextBoxColumn6.ReadOnly = true;
            gridViewTextBoxColumn6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn6.Width = 67;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "ProductName";
            gridViewTextBoxColumn7.HeaderText = "Sản phẩm";
            gridViewTextBoxColumn7.Name = "ProductName";
            gridViewTextBoxColumn7.ReadOnly = true;
            gridViewTextBoxColumn7.Width = 135;
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "Quantity";
            gridViewDecimalColumn2.HeaderText = "Xuất kho";
            gridViewDecimalColumn2.Name = "Quantity";
            gridViewDecimalColumn2.ReadOnly = true;
            gridViewDecimalColumn2.Width = 134;
            gridViewCommandColumn1.DefaultText = "X";
            gridViewCommandColumn1.HeaderText = "Xóa";
            gridViewCommandColumn1.Name = "Delete";
            gridViewCommandColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewCommandColumn1.UseDefaultText = true;
            gridViewCommandColumn1.Width = 44;
            this.radGridView2.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewDecimalColumn2,
            gridViewCommandColumn1});
            this.radGridView2.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.radGridView2.Name = "radGridView2";
            this.radGridView2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radGridView2.ShowGroupPanel = false;
            this.radGridView2.Size = new System.Drawing.Size(398, 121);
            this.radGridView2.TabIndex = 1;
            this.radGridView2.ViewCellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.radGridView2_ViewCellFormatting);
            this.radGridView2.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.radGridView2_CommandCellClick);
            // 
            // frmExportHarvest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 382);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmExportHarvest";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xuất sản phẩm";
            this.Load += new System.EventHandler(this.frmExportHarvest_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView2.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadDateTimePicker radDateTimePicker1;
        private Telerik.WinControls.UI.RadButton btnSave;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadGridView radGridView2;
    }
}