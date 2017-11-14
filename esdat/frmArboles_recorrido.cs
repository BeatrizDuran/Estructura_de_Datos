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
    public partial class frmArboles_recorrido : Form
    {
        public bool valor = false;
        private List<String> Lista = new List<String>();
        private string cadena;
        
        public frmArboles_recorrido()
        {
            InitializeComponent();
        }
        private void enabled()
        {
            txtRAIZ.Enabled = !txtRAIZ.Enabled;
            btnAGREGARRAIZ.Enabled = !btnAGREGARRAIZ.Enabled;
        }
        private void limpiar()
        {
            tvNODOS.Nodes.Clear();
            if (valor)
            {
                btnAGREGARRAIZ.Enabled = false;
                txtRAIZ.Enabled = false;
            }else 
            {
                btnAGREGARRAIZ.Enabled = true;
                txtRAIZ.Enabled = true;
            }
        }
        private void CallRecursive(TreeView view)
        {
            TreeNodeCollection nodos = view.Nodes;
            foreach (TreeNode item  in nodos)
            {
                ImprimirRecursivo(item);
            }
        }
        private void ImprimirRecursivo(TreeNode treeNode)
        {
            cmbPADRE.Items.Add(treeNode.Text);
            foreach (TreeNode item in treeNode.Nodes)
            {
                ImprimirRecursivo(item);
            }
        }
        private void CallRecursive2(TreeView treeView)
        {
            TreeNodeCollection nodos = treeView.Nodes;
            foreach (TreeNode item in nodos)
            {
                ImprimirRecursivo2(item);
            }
        }
        private void ImprimirRecursivo2(TreeNode treeNode)
        {
            foreach (TreeNode item in treeNode.Nodes)
            {
                ImprimirRecursivo2(item);
            }
            if(treeNode.Text == cmbPADRE.Text)
            {
                if (Lista.Contains(txtHIJO.Text))
                {
                    MessageBox.Show("No repetidos!!!","Aviso");
                }
                else
                {
                    treeNode.Nodes.Add(txtHIJO.Text);
                    Lista.Add(txtHIJO.Text);
                }
            }
            
        }
        private void ImprimirRecursivo3(TreeNode treeNode)
        {
            foreach (TreeNode item in treeNode.Nodes)
            {
                if (item.Text == cmbPADRE.Text)
                {
                    item.Remove();
                    Lista.Remove(item.Text);
                    break;

                }
                else
                {
                    MessageBox.Show(item.Text);
                    ImprimirRecursivo3(item);
                }
            }
        }
        private void CallRecursive3(TreeView treeView)
        {
            TreeNodeCollection nodos = treeView.Nodes;
            foreach (TreeNode item in nodos)
            {
                ImprimirRecursivo3(item);
            }
        }
        private void recorrido(TreeNodeCollection treeNodeCollection)
        {
            foreach (TreeNode item in treeNodeCollection)
            {
                if (item.Nodes.Count == 0)
                {
                    cadena +="\n Nodo hijo:  " + item.Text;
                }
                else
                {
                    cadena += "\n Nodo padre: " + item.Text;
                    recorrido(item.Nodes);
                }
            }
        }

        private void btnEXPANDIR_Click(object sender, EventArgs e)
        {
            tvNODOS.ExpandAll();
        }

        private void btnCONTRAER_Click(object sender, EventArgs e)
        {
            tvNODOS.CollapseAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtRAIZ.Clear();
            txtHIJO.Clear();
            cmbPADRE.Items.Clear();
            limpiar();
        }

        private void arboles_recorrido_Load(object sender, EventArgs e)
        {
            enabled();
            CallRecursive(tvNODOS);
            tvNODOS.ExpandAll();
            tvNODOS.Nodes.Add("Nodo0");
            tvNODOS.Nodes[0].Nodes.Add("Nodo1");
            tvNODOS.Nodes[0].Nodes.Add("Nodo2");
            tvNODOS.Nodes[0].Nodes[1].Nodes.Add("Nodo3");
            tvNODOS.Nodes[0].Nodes[1].Nodes.Add("Nodo4");
        }

        private void btnPODAR_Click(object sender, EventArgs e)
        {
            CallRecursive3(tvNODOS);
            foreach (var item in Lista)
            {
                cmbPADRE.Items.Add(ToString());
            }
            //cmbPADRE.Text = cmbPADRE.Items[0].ToString();
        }

        private void btnAGREGARRAIZ_Click(object sender, EventArgs e)
        {
            Lista.Clear();
            
            tvNODOS.Nodes.Add(txtRAIZ.Text);
            CallRecursive(tvNODOS);
            cmbPADRE.Text = cmbPADRE.Items[0].ToString();
            valor = false;
            enabled();
        }

        private void btnAGREGARHIJO_Click(object sender, EventArgs e)
        {
            if (txtHIJO.Text.Trim()=="")
            {
                MessageBox.Show("El campo esta vacío","Error");
            }
            else
            {
                CallRecursive2(tvNODOS);
                cmbPADRE.Items.Clear();
                CallRecursive(tvNODOS);
                cmbPADRE.Text = cmbPADRE.Items[0].ToString();
                txtHIJO.Clear();
                txtHIJO.Focus();
            }
        }

        private void btnRECORRIDO_Click(object sender, EventArgs e)
        {
            //..............Realiza el recorrido en los arboles.................
            cadena = "Imprimir el recorrido";
            recorrido(tvNODOS.Nodes);
            MessageBox.Show(cadena);
 ;      }
    }
}
