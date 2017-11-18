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
    public partial class frmPilas : Form
    {
        public frmPilas()
        {
            InitializeComponent();
        }
        Stack<string> stackString = new Stack<string>();
        private void ImprimirPila()
        {
            if (txtELEMENTO.Text.Trim() == "")
            {
                MessageBox.Show("El campo del elemento está vacío","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                dgvPILA.Rows.Clear();
                foreach (string item in stackString)
                {
                    dgvPILA.Rows.Add(item);
                    Renglones(dgvPILA);
                }
            }
        }
        private void Renglones(DataGridView view)
        {
            foreach (DataGridViewRow row in dgvPILA.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
        }
        private void Reverse(Stack<string> input)
        {
            if (dgvPILA.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para realizar la acción","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                dgvPILA.Rows.Clear();
                Stack<string> temp = new Stack<string>();
                while (input.Count != 0)
                {
                    temp.Push(input.Pop());
                }
                foreach (string item in temp)
                {
                    dgvPILA.Rows.Add(item);
                    Renglones(dgvPILA);
                }
                stackString.Clear();
                stackString = temp;
            }
        }
        private void btnPop()
        {
            if (stackString.Count == 0)
            {
                MessageBox.Show("No hay elementos en la pila", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                stackString.Pop();
                ImprimirPila();
            }
        }
        
        private void Pilas_Load(object sender, EventArgs e)
        {
            txtELEMENTO.Focus();
        }
        private void btnPUSH_Click(object sender, EventArgs e)
        {
            stackString.Push(txtELEMENTO.Text);
            ImprimirPila();
        }
        private void btnPOP_Click(object sender, EventArgs e)
        {
            btnPop();
        }
        private void txtELEMENTO_TextChanged(object sender, EventArgs e)
        {
            btnCONTAINS.Text = "Contains(\"" + txtELEMENTO.Text + "\")";
            btnPUSH.Text = "Push(\"" + txtELEMENTO.Text + "\")";
       
           //validString(x);
        }
        private void btnCLEAR_Click(object sender, EventArgs e)
        {
            txtELEMENTO.Clear();
            dgvPILA.Rows.Clear();
            stackString.Clear();
            txtELEMENTO.Focus();
        }
        private void btnREVERSA_Click(object sender, EventArgs e)
        {
            Reverse(stackString);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
