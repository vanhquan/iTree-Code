namespace iTree.Care
{
    partial class frmWater
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
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.dpTreeType = new Telerik.WinControls.UI.RadDropDownList();
            this.dpType = new Telerik.WinControls.UI.RadDropDownList();
            this.txtTimes = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpTreeType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.radLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dpTreeType, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dpType, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTimes, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.radLabel2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(322, 90);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(3, 3);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(65, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Tên loại cây";
            // 
            // dpTreeType
            // 
            this.dpTreeType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dpTreeType.Location = new System.Drawing.Point(147, 3);
            this.dpTreeType.Name = "dpTreeType";
            this.dpTreeType.Size = new System.Drawing.Size(138, 20);
            this.dpTreeType.TabIndex = 1;
            this.dpTreeType.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.dpTreeType_SelectedIndexChanged);
            // 
            // dpType
            // 
            this.dpType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dpType.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.dpType.Location = new System.Drawing.Point(3, 33);
            this.dpType.Name = "dpType";
            this.dpType.Size = new System.Drawing.Size(138, 20);
            this.dpType.TabIndex = 2;
            // 
            // txtTimes
            // 
            this.txtTimes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimes.Location = new System.Drawing.Point(147, 33);
            this.txtTimes.MaskType = Telerik.WinControls.UI.MaskType.Numeric;
            this.txtTimes.Name = "txtTimes";
            this.txtTimes.Size = new System.Drawing.Size(138, 20);
            this.txtTimes.TabIndex = 3;
            this.txtTimes.TabStop = false;
            this.txtTimes.Text = "0";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(291, 33);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(28, 18);
            this.radLabel2.TabIndex = 4;
            this.radLabel2.Text = "(lần)";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel1.SetColumnSpan(this.btnSave, 3);
            this.btnSave.Location = new System.Drawing.Point(106, 63);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 24);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Lưu...";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmWater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 90);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmWater";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Định nghĩa loại cây";
            this.Load += new System.EventHandler(this.frmWater_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpTreeType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadDropDownList dpTreeType;
        private Telerik.WinControls.UI.RadDropDownList dpType;
        private Telerik.WinControls.UI.RadMaskedEditBox txtTimes;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadButton btnSave;
    }
}