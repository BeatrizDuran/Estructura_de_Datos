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
    public partial class Arboles : Form
    {
        public Arboles()
        {
            InitializeComponent();
        }

        private void tvBASEDATOS_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void tvBASEDATOS_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Estoy seleccionado" + ((TreeView)sender).SelectedNode.ToString());
            
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
                    item.ImageIndex = 2;
                }
            }
            //((TreeView)sender).SelectedNode.ImageIndex = 1;
        }
    }
}
