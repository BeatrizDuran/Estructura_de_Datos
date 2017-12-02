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
    public partial class frmInicioMemorama : Form
    {       
        public frmInicioMemorama()
        {
            InitializeComponent();
            //this.nivel = nivel;
        }
        public static string nombre;
        private int nivel;
        /// <summary>
        /// Abre y valida el memorama niño.
        /// </summary>
        private void btnBoy()
        {
            if (txtNOMBRE.Text.Trim() == "")
            {
                MessageBox.Show("Favor de ingresar un nombre de usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (radioButton1.Checked==false && radioButton2.Checked== false && radioButton3.Checked==false) {
                    MessageBox.Show("Favor de seleccionar un nivel","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Error);
                } else {
                    nombre = txtNOMBRE.Text;
                    new frmMemorama_b(nivel, nombre).ShowDialog();
                }
            }
        }
        /// <summary>
        /// Abre y valida el memorama niña.
        /// </summary>
        private void btnGirl()
        {
            if (txtNOMBRE.Text.Trim() == "")
            {
                MessageBox.Show("Favor de ingresar un nombre de usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
                {
                    MessageBox.Show("Favor de seleccionar un nivel", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    nombre = txtNOMBRE.Text;
                    new frmMemorama_g(nivel, nombre).ShowDialog();
                }
            }
        }

        private void btnBOY_Click(object sender, EventArgs e) => btnBoy();
        private void btnGIRL_Click(object sender, EventArgs e) => btnGirl();
        private void radioButton1_CheckedChanged(object sender, EventArgs e) => nivel = 1000;
        private void radioButton2_CheckedChanged(object sender, EventArgs e) => nivel = 500;
        private void radioButton3_CheckedChanged(object sender, EventArgs e) => nivel = 100;

        private void btnCERRAR_Click(object sender, EventArgs e) => this.Close();
    }
}
