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
    public partial class Transpuesta : Form
    {
        private int columnas, renglones;
        private Random R = new Random();
        public Transpuesta(int columnas, int renglones)
        {
            InitializeComponent();
            this.columnas = columnas;
            this.renglones = renglones;
        }
        private void generar()
        {
            for (int i = 0; i < columnas; i++)
            {
                dgvM.Columns.Add("C" + (i + 1), "C" + (i+1));
            }
            for (int i = 0; i < renglones; i++)
            {
                dgvM.Rows.Add();
                for (int k = 0; k < columnas; k++)
                {
                    dgvM[k,i].Value = R.Next(0, 10).ToString();
                }
            }
            //INVERTIR
            for (int h = 0; h < renglones; h++)
            {
                dgvMT.Columns.Add("C" + (h + 1), "C" + (h + 1));
            }
            for (int d = 0; d < columnas; d++)
            {
                dgvMT.Rows.Add();
            }
        }
        private void transpuesta()
        {
            for (int h = 0; h < renglones; h++)
                for (int d = 0; d < columnas; d++)
                    dgvMT[h, d].Value = dgvM[d, h].Value.ToString();
        }

        private void btnTRANSPUESTA_Click(object sender, EventArgs e)
        {
            transpuesta();
        }

        private void Transpuesta_Load(object sender, EventArgs e)
        {
            generar();
        }
    }
}
