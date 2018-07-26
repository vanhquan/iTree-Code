namespace iTree.Category
{
    partial class frmProduct
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dpProduct = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.chkDiffQuantity = new Telerik.WinControls.UI.RadCheckBox();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.dpTreeType = new Telerik.WinControls.UI.RadDropDownList();
            this.txtProductName = new Telerik.WinControls.UI.RadTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dpProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDiffQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpTreeType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Controls.Add(this.dpProduct, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.radLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.radLabel2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.radLabel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chkDiffQuantity, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.dpTreeType, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtProductName, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(486, 58);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dpProduct
            // 
            this.dpProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dpProduct.Location = new System.Drawing.Point(317, 3);
            this.dpProduct.Name = "dpProduct";
            this.dpProduct.Size = new System.Drawing.Size(166, 20);
            this.dpProduct.TabIndex = 6;
            this.dpProduct.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.dpProduct_SelectedIndexChanged);
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(3, 3);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(46, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Loại cây";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(245, 3);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(69, 18);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "Thành phẩm";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(3, 32);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(24, 18);
            this.radLabel3.TabIndex = 2;
            this.radLabel3.Text = "Tên";
            // 
            // chkDiffQuantity
            // 
            this.chkDiffQuantity.Location = new System.Drawing.Point(245, 32);
            this.chkDiffQuantity.Name = "chkDiffQuantity";
            this.chkDiffQuantity.Size = new System.Drawing.Size(107, 18);
            this.chkDiffQuantity.TabIndex = 3;
            this.chkDiffQuantity.Text = "Nhiều chất lượng";
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.Location = new System.Drawing.Point(373, 32);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Lưu...";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dpTreeType
            // 
            this.dpTreeType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dpTreeType.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.dpTreeType.Location = new System.Drawing.Point(75, 3);
            this.dpTreeType.Name = "dpTreeType";
            this.dpTreeType.Size = new System.Drawing.Size(164, 20);
            this.dpTreeType.TabIndex = 5;
            this.dpTreeType.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.dpTreeType_SelectedIndexChanged);
            // 
            // txtProductName
            // 
            this.txtProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProductName.Location = new System.Drawing.Point(75, 32);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(164, 20);
            this.txtProductName.TabIndex = 7;
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 58);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProduct";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thành phẩm";
            this.Load += new System.EventHandler(this.frmProduct_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dpProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDiffQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpTreeType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Telerik.WinControls.UI.RadDropDownList dpProduct;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadCheckBox chkDiffQuantity;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadDropDownList dpTreeType;
        private Telerik.WinControls.UI.RadTextBox txtProductName;
    }
}