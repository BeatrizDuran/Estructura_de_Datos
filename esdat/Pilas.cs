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
    public partial class Pilas : Form
    {
        public Pilas()
        {
            InitializeComponent();
        }
        Stack<string> stackString = new Stack<string>();
        private void ImprimirPila()
        {
            dgvPILA.Rows.Clear();
            foreach (string item in stackString)
            {
                dgvPILA.Rows.Add(item);
            }
        }
        private bool validString(string c)
        {
            if (char.IsNumber(char.Parse(c.Substring(0, 1))))
            {
                return false;
            }
            else
            {
                return true;
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
            stackString.Pop();
            ImprimirPila();
        }
        private void txtELEMENTO_TextChanged(object sender, EventArgs e)
        {
            btnCONTAINS.Text = "Contains(\"" + txtELEMENTO.Text + "\")";
            btnPUSH.Text = "Push(\"" + txtELEMENTO.Text + "\")";
            string x = txtELEMENTO.Text;
           validString(x);
        }

        private void btnCLEAR_Click(object sender, EventArgs e)
        {
            txtELEMENTO.Clear();
            dgvPILA.Rows.Clear();
            stackString.Clear();
            txtELEMENTO.Focus();
        }
    }
}
