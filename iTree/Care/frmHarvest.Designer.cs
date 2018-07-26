namespace iTree.Care
{
    partial class frmHarvest
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.dpMonth = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel7 = new Telerik.WinControls.UI.RadLabel();
            this.dpYear = new Telerik.WinControls.UI.RadDropDownList();
            this.grdHarvest = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdHarvest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdHarvest.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
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
            this.splitContainer1.Panel2.Controls.Add(this.grdHarvest);
            this.splitContainer1.Size = new System.Drawing.Size(1158, 813);
            this.splitContainer1.SplitterDistance = 26;
            this.splitContainer1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.radLabel6);
            this.flowLayoutPanel1.Controls.Add(this.dpMonth);
            this.flowLayoutPanel1.Controls.Add(this.radLabel7);
            this.flowLayoutPanel1.Controls.Add(this.dpYear);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1158, 26);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // radLabel6
            // 
            this.radLabel6.Location = new System.Drawing.Point(3, 3);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(37, 18);
            this.radLabel6.TabIndex = 0;
            this.radLabel6.Text = "Tháng";
            // 
            // dpMonth
            // 
            this.dpMonth.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.dpMonth.Location = new System.Drawing.Point(46, 3);
            this.dpMonth.Name = "dpMonth";
            this.dpMonth.Size = new System.Drawing.Size(80, 20);
            this.dpMonth.TabIndex = 1;
            this.dpMonth.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.dpMonth_SelectedIndexChanged);
            // 
            // radLabel7
            // 
            this.radLabel7.Location = new System.Drawing.Point(132, 3);
            this.radLabel7.Name = "radLabel7";
            this.radLabel7.Size = new System.Drawing.Size(30, 18);
            this.radLabel7.TabIndex = 2;
            this.radLabel7.Text = "Năm";
            // 
            // dpYear
            // 
            this.dpYear.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.dpYear.Location = new System.Drawing.Point(168, 3);
            this.dpYear.Name = "dpYear";
            this.dpYear.Size = new System.Drawing.Size(80, 20);
            this.dpYear.TabIndex = 3;
            this.dpYear.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.dpYear_SelectedIndexChanged);
            // 
            // grdHarvest
            // 
            this.grdHarvest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdHarvest.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.grdHarvest.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.grdHarvest.Name = "grdHarvest";
            this.grdHarvest.Size = new System.Drawing.Size(1158, 783);
            this.grdHarvest.TabIndex = 0;
            this.grdHarvest.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.grdHarvest_CellDoubleClick);
            this.grdHarvest.DataBindingComplete += new Telerik.WinControls.UI.GridViewBindingCompleteEventHandler(this.grdHarvest_DataBindingComplete);
            // 
            // frmHarvest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 813);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmHarvest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập sản lượng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHarvest_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdHarvest.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdHarvest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadDropDownList dpMonth;
        private Telerik.WinControls.UI.RadLabel radLabel7;
        private Telerik.WinControls.UI.RadDropDownList dpYear;
        private Telerik.WinControls.UI.RadGridView grdHarvest;
    }
}