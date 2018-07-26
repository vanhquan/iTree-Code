namespace iTree.Category
{
    partial class frmTreeConfig
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
            this.txtLong = new Telerik.WinControls.UI.RadTextBox();
            this.txtPlantYear = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.txtTreeCode = new Telerik.WinControls.UI.RadTextBox();
            this.dpTreeType = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.txtPlantMonth = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.txtLat = new Telerik.WinControls.UI.RadTextBox();
            this.gMap = new GMap.NET.WindowsForms.GMapControl();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblLatLng = new Telerik.WinControls.UI.RadLabel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlantYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTreeCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpTreeType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlantMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblLatLng)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Controls.Add(this.txtLong, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtPlantYear, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.radLabel5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.radLabel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.radLabel2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.radLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTreeCode, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dpTreeType, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.radLabel4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.radLabel6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtPlantMonth, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtLat, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(809, 79);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtLong
            // 
            this.txtLong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLong.Location = new System.Drawing.Point(528, 55);
            this.txtLong.Name = "txtLong";
            this.txtLong.ReadOnly = true;
            this.txtLong.Size = new System.Drawing.Size(278, 21);
            this.txtLong.TabIndex = 10;
            // 
            // txtPlantYear
            // 
            this.txtPlantYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPlantYear.Location = new System.Drawing.Point(528, 29);
            this.txtPlantYear.MaskType = Telerik.WinControls.UI.MaskType.Numeric;
            this.txtPlantYear.Name = "txtPlantYear";
            this.txtPlantYear.Size = new System.Drawing.Size(278, 20);
            this.txtPlantYear.TabIndex = 8;
            this.txtPlantYear.TabStop = false;
            this.txtPlantYear.Text = "0";
            // 
            // radLabel5
            // 
            this.radLabel5.Location = new System.Drawing.Point(3, 55);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(21, 18);
            this.radLabel5.TabIndex = 1;
            this.radLabel5.Text = "Lat";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(3, 29);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(68, 18);
            this.radLabel3.TabIndex = 4;
            this.radLabel3.Text = "Tháng trồng";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(407, 3);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(46, 18);
            this.radLabel2.TabIndex = 2;
            this.radLabel2.Text = "Loại cây";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(3, 3);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(55, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Mã cây";
            // 
            // txtTreeCode
            // 
            this.txtTreeCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTreeCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTreeCode.Location = new System.Drawing.Point(124, 3);
            this.txtTreeCode.Name = "txtTreeCode";
            this.txtTreeCode.Size = new System.Drawing.Size(277, 20);
            this.txtTreeCode.TabIndex = 1;
            // 
            // dpTreeType
            // 
            this.dpTreeType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dpTreeType.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.dpTreeType.Location = new System.Drawing.Point(528, 3);
            this.dpTreeType.Name = "dpTreeType";
            this.dpTreeType.Size = new System.Drawing.Size(278, 20);
            this.dpTreeType.TabIndex = 3;
            this.dpTreeType.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.dpTreeType_SelectedIndexChanged);
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(407, 29);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(61, 18);
            this.radLabel4.TabIndex = 5;
            this.radLabel4.Text = "Năm trồng";
            // 
            // radLabel6
            // 
            this.radLabel6.Location = new System.Drawing.Point(407, 55);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(31, 18);
            this.radLabel6.TabIndex = 6;
            this.radLabel6.Text = "Long";
            // 
            // txtPlantMonth
            // 
            this.txtPlantMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPlantMonth.Location = new System.Drawing.Point(124, 29);
            this.txtPlantMonth.MaskType = Telerik.WinControls.UI.MaskType.Numeric;
            this.txtPlantMonth.Name = "txtPlantMonth";
            this.txtPlantMonth.Size = new System.Drawing.Size(277, 20);
            this.txtPlantMonth.TabIndex = 7;
            this.txtPlantMonth.TabStop = false;
            this.txtPlantMonth.Text = "0";
            // 
            // txtLat
            // 
            this.txtLat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLat.Location = new System.Drawing.Point(124, 55);
            this.txtLat.Name = "txtLat";
            this.txtLat.ReadOnly = true;
            this.txtLat.Size = new System.Drawing.Size(277, 21);
            this.txtLat.TabIndex = 9;
            // 
            // gMap
            // 
            this.gMap.Bearing = 0F;
            this.gMap.CanDragMap = true;
            this.gMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMap.GrayScaleMode = false;
            this.gMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMap.LevelsKeepInMemmory = 5;
            this.gMap.Location = new System.Drawing.Point(0, 0);
            this.gMap.MarkersEnabled = true;
            this.gMap.MaxZoom = 2;
            this.gMap.MinZoom = 2;
            this.gMap.MouseWheelZoomEnabled = true;
            this.gMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMap.Name = "gMap";
            this.gMap.NegativeMode = false;
            this.gMap.PolygonsEnabled = true;
            this.gMap.RetryLoadTile = 0;
            this.gMap.RoutesEnabled = true;
            this.gMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMap.ShowTileGridLines = false;
            this.gMap.Size = new System.Drawing.Size(809, 602);
            this.gMap.TabIndex = 1;
            this.gMap.Zoom = 0D;
            this.gMap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gMap_MouseClick);
            this.gMap.MouseLeave += new System.EventHandler(this.gMap_MouseLeave);
            this.gMap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gMap_MouseMove);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 685);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(3, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblLatLng);
            this.splitContainer1.Panel2.Controls.Add(this.gMap);
            this.splitContainer1.Size = new System.Drawing.Size(809, 685);
            this.splitContainer1.SplitterDistance = 79;
            this.splitContainer1.TabIndex = 3;
            // 
            // lblLatLng
            // 
            this.lblLatLng.Location = new System.Drawing.Point(9, 3);
            this.lblLatLng.Name = "lblLatLng";
            this.lblLatLng.Size = new System.Drawing.Size(2, 2);
            this.lblLatLng.TabIndex = 2;
            // 
            // frmTreeConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 685);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.splitter1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTreeConfig";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTreeConfig_FormClosing);
            this.Load += new System.EventHandler(this.frmTreeConfig_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlantYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTreeCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpTreeType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlantMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLat)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lblLatLng)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox txtLong;
        private Telerik.WinControls.UI.RadMaskedEditBox txtPlantYear;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox txtTreeCode;
        private Telerik.WinControls.UI.RadDropDownList dpTreeType;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadMaskedEditBox txtPlantMonth;
        private Telerik.WinControls.UI.RadTextBox txtLat;
        private GMap.NET.WindowsForms.GMapControl gMap;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Telerik.WinControls.UI.RadLabel lblLatLng;
    }
}