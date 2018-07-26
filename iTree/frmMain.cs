using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iTree
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private bool LoadChildMdiForm(string formName)
        {
            if (this.MdiChildren.Length > 0)
            {
                for (int x = 0; x < this.MdiChildren.Length; x++)
                {
                    if (this.MdiChildren[x].Name == formName)
                    {
                        this.MdiChildren[x].Focus();
                        return true;
                    }
                }
            }
            return false;
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            if (!LoadChildMdiForm("frmAsset"))
            {
                Category.frmAsset frm = new Category.frmAsset();
                frm.MdiParent = this;
                frm.Show();
            }
        }
    }
}
