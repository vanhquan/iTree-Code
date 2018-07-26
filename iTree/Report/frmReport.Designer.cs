namespace iTree.Report
{
    partial class frmReport
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
            this.radPageView1 = new Telerik.WinControls.UI.RadPageView();
            this.pageLCN = new Telerik.WinControls.UI.RadPageViewPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.dpMonth = new Telerik.WinControls.UI.RadDropDownList();
            this.dpYear = new Telerik.WinControls.UI.RadDropDownList();
            this.dpUser = new Telerik.WinControls.UI.RadDropDownList();
            this.btnView = new Telerik.WinControls.UI.RadButton();
            this.dpAccountant = new Telerik.WinControls.UI.RadDropDownList();
            this.crvReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.pageTHL = new Telerik.WinControls.UI.RadPageViewPage();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).BeginInit();
            this.radPageView1.SuspendLayout();
            this.pageLCN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpAccountant)).BeginInit();
            this.SuspendLayout();
            // 
            // radPageView1
            // 
            this.radPageView1.Controls.Add(this.pageLCN);
            this.radPageView1.Controls.Add(this.pageTHL);
            this.radPageView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPageView1.Location = new System.Drawing.Point(0, 0);
            this.radPageView1.Name = "radPageView1";
            this.radPageView1.SelectedPage = this.pageLCN;
            this.radPageView1.Size = new System.Drawing.Size(1017, 731);
            this.radPageView1.TabIndex = 0;
            // 
            // pageLCN
            // 
            this.pageLCN.Controls.Add(this.splitContainer1);
            this.pageLCN.ItemSize = new System.Drawing.SizeF(104F, 28F);
            this.pageLCN.Location = new System.Drawing.Point(10, 37);
            this.pageLCN.Name = "pageLCN";
            this.pageLCN.Size = new System.Drawing.Size(996, 683);
            this.pageLCN.Text = "Lương công nhân";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.crvReport);
            this.splitContainer1.Size = new System.Drawing.Size(996, 683);
            this.splitContainer1.SplitterDistance = 211;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.radLabel4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.radLabel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.radLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.radLabel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dpMonth, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dpYear, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dpUser, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnView, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.dpAccountant, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(211, 150);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(3, 93);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(44, 18);
            this.radLabel4.TabIndex = 6;
            this.radLabel4.Text = "Kế toán";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(3, 63);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(57, 18);
            this.radLabel3.TabIndex = 1;
            this.radLabel3.Text = "Công nhân";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(3, 3);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(55, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Tháng";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(3, 33);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(30, 18);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "Năm";
            // 
            // dpMonth
            // 
            this.dpMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dpMonth.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.dpMonth.Location = new System.Drawing.Point(66, 3);
            this.dpMonth.Name = "dpMonth";
            this.dpMonth.Size = new System.Drawing.Size(142, 24);
            this.dpMonth.TabIndex = 2;
            // 
            // dpYear
            // 
            this.dpYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dpYear.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.dpYear.Location = new System.Drawing.Point(66, 33);
            this.dpYear.Name = "dpYear";
            this.dpYear.Size = new System.Drawing.Size(142, 24);
            this.dpYear.TabIndex = 3;
            // 
            // dpUser
            // 
            this.dpUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dpUser.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.dpUser.Location = new System.Drawing.Point(66, 63);
            this.dpUser.Name = "dpUser";
            this.dpUser.Size = new System.Drawing.Size(142, 24);
            this.dpUser.TabIndex = 4;
            this.dpUser.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.dpUser_SelectedIndexChanged);
            // 
            // btnView
            // 
            this.btnView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnView.Location = new System.Drawing.Point(66, 123);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(142, 24);
            this.btnView.TabIndex = 5;
            this.btnView.Text = "Xem...";
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // dpAccountant
            // 
            this.dpAccountant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dpAccountant.Location = new System.Drawing.Point(66, 93);
            this.dpAccountant.Name = "dpAccountant";
            this.dpAccountant.Size = new System.Drawing.Size(142, 24);
            this.dpAccountant.TabIndex = 7;
            // 
            // crvReport
            // 
            this.crvReport.ActiveViewIndex = -1;
            this.crvReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvReport.Location = new System.Drawing.Point(0, 0);
            this.crvReport.Name = "crvReport";
            this.crvReport.ShowGroupTreeButton = false;
            this.crvReport.Size = new System.Drawing.Size(781, 683);
            this.crvReport.TabIndex = 0;
            this.crvReport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
           
            // 
            // pageTHL
            // 
            this.pageTHL.ItemSize = new System.Drawing.SizeF(123F, 28F);
            this.pageTHL.Location = new System.Drawing.Point(10, 37);
            this.pageTHL.Name = "pageTHL";
            this.pageTHL.Size = new System.Drawing.Size(996, 683);
            this.pageTHL.Text = "Bảng tổng hợp lương";
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 731);
            this.Controls.Add(this.radPageView1);
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).EndInit();
            this.radPageView1.ResumeLayout(false);
            this.pageLCN.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpAccountant)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPageView radPageView1;
        private Telerik.WinControls.UI.RadPageViewPage pageLCN;
        private Telerik.WinControls.UI.RadPageViewPage pageTHL;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadDropDownList dpMonth;
        private Telerik.WinControls.UI.RadDropDownList dpYear;
        private Telerik.WinControls.UI.RadDropDownList dpUser;
        private Telerik.WinControls.UI.RadButton btnView;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvReport;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadDropDownList dpAccountant;
    }
}