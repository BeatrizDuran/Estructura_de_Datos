using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//validaciones
//boton limpiar
namespace esdat
{
    public partial class Maximo_como_un_divisor : Form
    {
        public Maximo_como_un_divisor()
        {
            InitializeComponent();
        }
        private int mcdMETODO(int a, int b)
        {
           
            if (a < 0 || b < 0)
            {
                //MessageBox.Show("Solo positivos");
                //return -1;
                a = a < 0 ? a * -1 : a;
                b = b < 0 ? b * -1 : b;
                return mcdMETODO(a, b);
            }
            else if (b > a)
            {
                return mcdMETODO(b, a);
            }
            else if (b==0)
            {
                return a;
            }
            else
            {
                return mcdMETODO(a-b,b);
            }
        }

        private void btnCALCULAR_Click(object sender, EventArgs e)
        {
            lblRESULTADO.Text=(mcdMETODO(int.Parse(txtENTERO1.Text),int.Parse(txtENTERO2.Text)).ToString());
        }

        private void Maximo_como_un_divisor_Load(object sender, EventArgs e)
        {

        }
    }
}
