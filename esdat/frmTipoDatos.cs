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
    public partial class frmTipoDatos : Form
    {
        public frmTipoDatos()
        {
            InitializeComponent();
        } 
        private void btnCOMENZAR_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked==false || radioButton2.Checked==false || radioButton3.Checked==false || radioButton4.Checked==false || radioButton5.Checked==false)
            {
                MessageBox.Show("Es necesario seleccionar una opción","aviso",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            new frmPractica1_2(selected_RadioButton()).ShowDialog();            
        }
        private string selected_RadioButton()
        {
            string resultado = null;
            resultado = radioButton1.Checked == true ? "int" : resultado;
            resultado = radioButton2.Checked == true ? "double" : resultado;
            resultado = radioButton3.Checked == true ? "decimal" : resultado;
            resultado = radioButton4.Checked == true ? "char" : resultado;
            resultado = radioButton5.Checked == true ? "string" : resultado;
            resultado = rbNUMEROSCOMPLEJOS.Checked == true ? "Numeros Complejos" : resultado;
            resultado = radioButton7.Checked == true ? "..." : resultado;
           
            return resultado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
