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
    public partial class Fibonacci : Form
    {
        private int resl;
        public Fibonacci()
        {
            InitializeComponent();
        }

        private void btnGENERAR_Click(object sender, EventArgs e)
        {
            validar();
        }
        public void calcular(){
            dgvFIBONACCI.Rows.Clear();
            double a = 0;
            double b = 1;
            for (double c = 0; c <= int.Parse(txtLIMITE.Text);)
            {
                dgvFIBONACCI.Rows.Add(c.ToString());
                if (c == 1) dgvFIBONACCI.Rows.Add("1");
                c = a + b;
                a = b;
                b = c;
            }
        }

        public void validar()
        {          
                if (txtLIMITE.Text.Trim() == "") //se verifica si el campo esta vacio
                {
                    MessageBox.Show("El campo a capturar esta vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtLIMITE.Focus();
                }
                else
                {
                    if (int.TryParse(txtLIMITE.Text, out resl)) //res no se utiliza, es solo para poder hacer el parceo
                    {
                        calcular(); //captura si es valido :)
                    }
                    else
                    {
                        MessageBox.Show("Solo se permiten numeros enteros, no se capturo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); // marca el error y no captua :(
                    }
                }            
        }
    }
}

