using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace esdat
{
    public partial class frmArbolesImagenes : Form
    {
        public frmArbolesImagenes()
        {
            InitializeComponent();
        }
        
        private void tvBASEDATOS_Click(object sender, EventArgs e)
        {
            foreach (TreeNode item in ((TreeView)sender).Nodes)
            {
                if (item.Parent==null)
                {
                    if (item.IsSelected)
                    {
                        item.ImageIndex = 1;
                    }else
                    {
                        item.ImageIndex = 0;
                    }
                }
                else
                {
                    item.ImageIndex = 1;
                }
            }
        }
    }
}
