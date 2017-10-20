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
    public partial class Prueba_de_Fibonacci : Form
    {
        private int resl;
        public Prueba_de_Fibonacci()
        {
            InitializeComponent();
        }
        private long Pruebita(int n)
        {
            if (n == 0|| n==1)
            {
                return 1;
            }else
            {
                return Pruebita(n-1)+Pruebita(n-2);
            }        
        }
        private void calculandooo()
        {
            if (int.Parse(txtFIBONACCI.Text) == 1)
            {
                label3.Text = "El 1 numero de Fibonacci es: 0";
            }
            else if (int.Parse(txtFIBONACCI.Text) == 2)
            {
                label3.Text = "El 2 numero de Fibonacci es: 1";
            }
            else
            {
                label3.Text = "El " + txtFIBONACCI.Text + " numero de Fibonacci es : " + Pruebita(int.Parse(txtFIBONACCI.Text)-2);
            }
        }
        private void calcular()
        {
            dgvFIBONACCI.Rows.Clear();
            double a = 0;
            double b = 1;
            int celda = 0;
            int conteo = 1;
            string valor = "20";
            for (double c = 0; c <= 4181;)
            {
                dgvFIBONACCI.Rows.Add(c.ToString());
                if (c == 1) dgvFIBONACCI.Rows.Add("1");
                dgvFIBONACCI.Rows[celda].HeaderCell.Value = conteo.ToString();
                c = a + b;
                a = b;
                b = c;
                conteo++;
                celda++;
            }
            dgvFIBONACCI.Rows[celda].HeaderCell.Value = valor.ToString();
        }
        private void validar()
        {
            if (txtFIBONACCI.Text.Trim() == "") //se verifica si el campo esta vacio
            {
                MessageBox.Show("El campo a capturar esta vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtFIBONACCI.Focus();
            }
            else
            {
                if (int.TryParse(txtFIBONACCI.Text, out resl)) //res no se utiliza, es solo para poder hacer el parceo
                {
                    calcular(); //captura si es valido :)
                }
                else
                {
                    MessageBox.Show("Solo se permiten numeros enteros, no se capturo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); // marca el error y no captua :(
                }
            }
        }
        private void Prueba_de_Fibonacci_Load(object sender, EventArgs e)
        {
            calcular();        
        }

        private void btnGENERAR_Click(object sender, EventArgs e)
        {
            validar();
            calculandooo();
        }
    }
}
