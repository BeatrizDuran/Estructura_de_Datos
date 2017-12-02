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
    public partial class Maximo_como_un_divisor : Form
    {
        public Maximo_como_un_divisor()
        {
            InitializeComponent();
        }
        private int res;
        /// <summary>
        /// Valida los campos  que son ingresados o ya sea otra acción.
        /// </summary>
        private void validar() 
        {
            if (txtENTERO1.Text.Trim() == "" || txtENTERO2.Text.Trim() == "")
            {
                MessageBox.Show("Los campos están vacíos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtENTERO1.Focus();
            }
            else
            {
                if (int.TryParse(txtENTERO1.Text, out res) || int.TryParse(txtENTERO2.Text, out res) || txtENTERO1.Text=="0"|| txtENTERO2.Text=="0")
                {
                    lblRESULTADO.Text = (mcdMETODO(int.Parse(txtENTERO1.Text), int.Parse(txtENTERO2.Text)).ToString());
                }
                else
                {
                    MessageBox.Show("Deben ser números enteros", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtENTERO1.Focus();
                }
            }
        }
        /// <summary>
        /// Realiza el metodo de el maximo comun divisor.
        /// </summary>
        /// <param name="a">numero x</param>
        /// <param name="b">otro numero x</param>
        /// <returns></returns>
        private int mcdMETODO(int a, int b)
        {
           
                if (a < 0 || b < 0)
                {
                    a = a < 0 ? a * -1 : a;
                    b = b < 0 ? b * -1 : b;
                    return mcdMETODO(a, b);
                }
                else if (b > a)
                {
                    return mcdMETODO(b, a);
                }
                else if (b == 0)
                {
                    return a;
                }
                else
                {
                    return mcdMETODO(a - b, b);
                }
            
        }
        private void btnCALCULAR_Click(object sender, EventArgs e) => validar();

        private void btnSALIR_Click(object sender, EventArgs e) => this.Close();
    }
}
