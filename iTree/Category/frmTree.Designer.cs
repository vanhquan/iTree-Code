namespace iTree.Category
{
    partial class frmTree
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
            Telerik.WinControls.UI.SchedulerDailyPrintStyle schedulerDailyPrintStyle1 = new Telerik.WinControls.UI.SchedulerDailyPrintStyle();
            this.radRibbonBar1 = new Telerik.WinControls.UI.RadRibbonBar();
            this.ribbonTab1 = new Telerik.WinControls.UI.RibbonTab();
            this.radRibbonBarGroup1 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.radPageView1 = new Telerik.WinControls.UI.RadPageView();
            this.pageTree = new Telerik.WinControls.UI.RadPageViewPage();
            this.pageWater = new Telerik.WinControls.UI.RadPageViewPage();
            this.radScheduler1 = new Telerik.WinControls.UI.RadScheduler();
            this.pageItem = new Telerik.WinControls.UI.RadPageViewPage();
            this.iTree1 = new iTree.Class.iTree();
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).BeginInit();
            this.radPageView1.SuspendLayout();
            this.pageTree.SuspendLayout();
            this.pageWater.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radScheduler1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTree1)).BeginInit();
            this.SuspendLayout();
            // 
            // radRibbonBar1
            // 
            this.radRibbonBar1.CommandTabs.AddRange(new Telerik.WinControls.RadItem[] {
            this.ribbonTab1});
            // 
            // 
            // 
            this.radRibbonBar1.ExitButton.Text = "Exit";
            this.radRibbonBar1.ExitButton.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            this.radRibbonBar1.Location = new System.Drawing.Point(0, 0);
            this.radRibbonBar1.Name = "radRibbonBar1";
            // 
            // 
            // 
            this.radRibbonBar1.OptionsButton.Text = "Options";
            this.radRibbonBar1.OptionsButton.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            this.radRibbonBar1.Size = new System.Drawing.Size(585, 104);
            this.radRibbonBar1.TabIndex = 1;
            this.radRibbonBar1.Text = "Cây";
            ((Telerik.WinControls.UI.RadRibbonBarElement)(this.radRibbonBar1.GetChildAt(0))).Text = "Cây";
            ((Telerik.WinControls.UI.RadQuickAccessToolBar)(this.radRibbonBar1.GetChildAt(0).GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.UI.RadRibbonBarCaption)(this.radRibbonBar1.GetChildAt(0).GetChildAt(3))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.UI.StripViewItemContainer)(this.radRibbonBar1.GetChildAt(0).GetChildAt(4).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)(this.radRibbonBar1.GetChildAt(0).GetChildAt(4).GetChildAt(1))).Margin = new System.Windows.Forms.Padding(0);
            ((Telerik.WinControls.UI.RadApplicationMenuButtonElement)(this.radRibbonBar1.GetChildAt(0).GetChildAt(5))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.UI.StackLayoutElement)(this.radRibbonBar1.GetChildAt(0).GetChildAt(6))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.IsSelected = true;
            this.ribbonTab1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarGroup1});
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Text = "...";
            this.ribbonTab1.UseMnemonic = false;
            // 
            // radRibbonBarGroup1
            // 
            this.radRibbonBarGroup1.Name = "radRibbonBarGroup1";
            this.radRibbonBarGroup1.Text = "A";
            // 
            // radGridView1
            // 
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Size = new System.Drawing.Size(564, 408);
            this.radGridView1.TabIndex = 2;
            this.radGridView1.CurrentCellChanged += new Telerik.WinControls.UI.CurrentCellChangedEventHandler(this.radGridView1_CurrentCellChanged);
            this.radGridView1.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.radGridView1_CellDoubleClick);
            // 
            // radPageView1
            // 
            this.radPageView1.Controls.Add(this.pageTree);
            this.radPageView1.Controls.Add(this.pageWater);
            this.radPageView1.Controls.Add(this.pageItem);
            this.radPageView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPageView1.Location = new System.Drawing.Point(0, 104);
            this.radPageView1.Name = "radPageView1";
            this.radPageView1.SelectedPage = this.pageTree;
            this.radPageView1.Size = new System.Drawing.Size(585, 452);
            this.radPageView1.TabIndex = 3;
            this.radPageView1.SelectedPageChanged += new System.EventHandler(this.radPageView1_SelectedPageChanged);
            // 
            // pageTree
            // 
            this.pageTree.Controls.Add(this.radGridView1);
            this.pageTree.ItemSize = new System.Drawing.SizeF(30F, 24F);
            this.pageTree.Location = new System.Drawing.Point(10, 33);
            this.pageTree.Name = "pageTree";
            this.pageTree.Size = new System.Drawing.Size(564, 408);
            this.pageTree.Text = "Cây";
            // 
            // pageWater
            // 
            this.pageWater.Controls.Add(this.radScheduler1);
            this.pageWater.ItemSize = new System.Drawing.SizeF(55F, 24F);
            this.pageWater.Location = new System.Drawing.Point(10, 37);
            this.pageWater.Name = "pageWater";
            this.pageWater.Size = new System.Drawing.Size(564, 404);
            this.pageWater.Text = "Lịch tưới";
            // 
            // radScheduler1
            // 
            this.radScheduler1.ActiveViewType = Telerik.WinControls.UI.SchedulerViewType.Month;
            this.radScheduler1.Culture = new System.Globalization.CultureInfo("en-US");
            this.radScheduler1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radScheduler1.Location = new System.Drawing.Point(0, 0);
            this.radScheduler1.Name = "radScheduler1";
            schedulerDailyPrintStyle1.AppointmentFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            schedulerDailyPrintStyle1.DateEndRange = new System.DateTime(2018, 7, 5, 0, 0, 0, 0);
            schedulerDailyPrintStyle1.DateHeadingFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            schedulerDailyPrintStyle1.DateStartRange = new System.DateTime(2018, 6, 30, 0, 0, 0, 0);
            schedulerDailyPrintStyle1.PageHeadingFont = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.radScheduler1.PrintStyle = schedulerDailyPrintStyle1;
            this.radScheduler1.Size = new System.Drawing.Size(564, 404);
            this.radScheduler1.TabIndex = 0;
            // 
            // pageItem
            // 
            this.pageItem.ItemSize = new System.Drawing.SizeF(42F, 24F);
            this.pageItem.Location = new System.Drawing.Point(10, 37);
            this.pageItem.Name = "pageItem";
            this.pageItem.Size = new System.Drawing.Size(564, 404);
            this.pageItem.Text = "Vật tư";
            // 
            // iTree1
            // 
            this.iTree1.DataSetName = "iTree";
            this.iTree1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 556);
            this.Controls.Add(this.radPageView1);
            this.Controls.Add(this.radRibbonBar1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTree";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cây";
            this.Load += new System.EventHandler(this.frmTree_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).EndInit();
            this.radPageView1.ResumeLayout(false);
            this.pageTree.ResumeLayout(false);
            this.pageWater.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radScheduler1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTree1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadRibbonBar radRibbonBar1;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadPageView radPageView1;
        private Telerik.WinControls.UI.RadPageViewPage pageTree;
        private Telerik.WinControls.UI.RadPageViewPage pageWater;
        private Telerik.WinControls.UI.RadPageViewPage pageItem;
        private Telerik.WinControls.UI.RibbonTab ribbonTab1;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup1;
        private Telerik.WinControls.UI.RadScheduler radScheduler1;
        private Class.iTree iTree1;
    }
}