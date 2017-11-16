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
    public partial class Suma_de_matrices : Form
    { 
        public Suma_de_matrices()
        {
            InitializeComponent();
         
        }
        private int res;
        private void validar()
        {
            if (txtCOLUMNAS.Text.Trim() == "" || txtRENGLONES.Text.Trim() == "") //se verifica si el campo esta vacio
            {
                MessageBox.Show("El campo está vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCOLUMNAS.Focus();
            }
            else
            {
                if (int.TryParse(txtCOLUMNAS.Text, out res) && int.TryParse(txtRENGLONES.Text, out res)) //res no se utiliza, es solo para poder hacer el parceo
                {
                    if (int.Parse(txtCOLUMNAS.Text) >= 1 && int.Parse(txtRENGLONES.Text) >= 1)
                    {
                        new Generación_de_la_suma(int.Parse(txtCOLUMNAS.Text), int.Parse(txtRENGLONES.Text)).Show();
                    }
                    else
                    {
                        MessageBox.Show("La columna debe ser mayor a 1", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); // marca el error y no captua :(
                        txtCOLUMNAS.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); // marca el error y no captua :(
                    txtCOLUMNAS.Focus();
                }
            }

            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            new frmMenu().ShowDialog();
        }

        private void btnGENERAR_Click(object sender, EventArgs e)
        {
            validar();
        }

        private void Suma_de_matrices_Load(object sender, EventArgs e)
        {

        }
    }
}
