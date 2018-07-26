namespace iTree.Category
{
    partial class frmListWork
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            this.SuspendLayout();
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
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "WorkId";
            gridViewTextBoxColumn4.HeaderText = "WorkId";
            gridViewTextBoxColumn4.IsVisible = false;
            gridViewTextBoxColumn4.Name = "WorkId";
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.HeaderText = "STT";
            gridViewTextBoxColumn5.Name = "No";
            gridViewTextBoxColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "Name";
            gridViewTextBoxColumn6.HeaderText = "Công việc";
            gridViewTextBoxColumn6.Name = "Name";
            gridViewTextBoxColumn6.Width = 200;
            gridViewCommandColumn2.DefaultText = "X";
            gridViewCommandColumn2.EnableExpressionEditor = false;
            gridViewCommandColumn2.HeaderText = "Xóa";
            gridViewCommandColumn2.Name = "Delete";
            gridViewCommandColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewCommandColumn2.UseDefaultText = true;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewCommandColumn2});
            this.radGridView1.MasterTemplate.EnableGrouping = false;
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radGridView1.Size = new System.Drawing.Size(337, 336);
            this.radGridView1.TabIndex = 0;
            this.radGridView1.ViewCellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.radGridView1_ViewCellFormatting);
            this.radGridView1.CellEndEdit += new Telerik.WinControls.UI.GridViewCellEventHandler(this.radGridView1_CellEndEdit);
            this.radGridView1.UserAddedRow += new Telerik.WinControls.UI.GridViewRowEventHandler(this.radGridView1_UserAddedRow);
            this.radGridView1.UserDeletingRow += new Telerik.WinControls.UI.GridViewRowCancelEventHandler(this.radGridView1_UserDeletingRow);
            this.radGridView1.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.radGridView1_CommandCellClick);
            // 
            // frmListWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 336);
            this.Controls.Add(this.radGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListWork";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Định nghĩa công việc";
            this.Load += new System.EventHandler(this.frmListWork_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView1;
    }
}