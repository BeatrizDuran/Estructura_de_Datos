using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace esdat
{
    public partial class Explorador : Form
    {
        public Explorador()
        {
            InitializeComponent();
        }
        private void cargarDirectorio()
        {
            TreeNode noRoot;
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.SelectedPath = @"C:\Users\BeatrizDuran\Documents\tree";
            folder.ShowDialog();
            DirectoryInfo info = new DirectoryInfo(folder.SelectedPath);
            if (info.Exists)
            {
                noRoot = new TreeNode(info.Name);
                noRoot.Tag = info;
                GetDirectories(info.GetDirectories(), noRoot);
                tvNODOS.Nodes.Add(noRoot);
                FileInfo[] archivos = info.GetFiles();
                foreach (FileInfo item in archivos)
                {
                    noRoot.Nodes.Add(item.ToString());
                }
            }
            else
            {
                MessageBox.Show("Directorio no existe");
            }
        }
        private void GetDirectories(DirectoryInfo[] subDirs, TreeNode nodoPadre)
        {
            TreeNode nodoHijo;
            DirectoryInfo[] carpetainfo;
            foreach (DirectoryInfo subDir in subDirs)
            {
                nodoHijo = new TreeNode(subDir.Name, 0, 0);
                nodoHijo.Tag = subDir;
               // nodoHijo.ImageKey = "folder";
                carpetainfo = subDir.GetDirectories();
                FileInfo[] Files = subDir.GetFiles();
                if (carpetainfo.Length != 0)
                {
                    GetDirectories(carpetainfo, nodoHijo);
                }
                nodoPadre.Nodes.Add(nodoHijo);
                foreach (FileInfo file in Files)
                {
                    nodoHijo.Nodes.Add(file.ToString());
                }
            }
        }
        private void btnLIMPIAR_Click(object sender, EventArgs e)
        {
            tvNODOS.Nodes.Clear();
        }

        private void btnEXPANDIR_Click(object sender, EventArgs e)
        {
            tvNODOS.ExpandAll();
        }

        private void btnCARGARDOCUMENTOS_Click(object sender, EventArgs e)
        {
            cargarDirectorio();
        }

        private void btnCONTRAER_Click(object sender, EventArgs e)
        {
            tvNODOS.CollapseAll();
        }
    }
}
