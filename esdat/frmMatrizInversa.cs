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
    public partial class frmMatrizInversa : Form
    {
        public frmMatrizInversa()
        {
            InitializeComponent();
        }
        private Random R = new Random();
        private void renglones()
        {
            int celda=0, conteo = 1;
            for (int i = 1; i <= 3; i++)
            {
                dgvA.Rows.Add();
                dgvA.Rows[celda].HeaderCell.Value = conteo.ToString();
                dgvApor.Rows.Add();
                dgvApor.Rows[celda].HeaderCell.Value = conteo.ToString();
                dgvAport.Rows.Add();
                dgvAport.Rows[celda].HeaderCell.Value = conteo.ToString();
                dgvRESULTADO1.Rows.Add();
                dgvRESULTADO1.Rows[celda].HeaderCell.Value = conteo.ToString();
                dgvRESULTADOFINAL.Rows.Add();
                dgvRESULTADOFINAL.Rows[celda].HeaderCell.Value = conteo.ToString();
                conteo++;
                celda++;
            }
        }
        private void random()
        {
            int celda = 0, conteo = 1;
            dgvA.Rows.Clear();
            for (int i = 0; i < 3; i++)
            {
                dgvA.Rows.Add();
                for (int j = 0; j < 3; j++)
                {
                    dgvA[j, i].Value = R.Next(0, 10).ToString();
                    dgvA.Rows[celda].HeaderCell.Value = conteo.ToString();
                }
                conteo++;
                celda++;
            }
        }
        private void MatrizInversa_Load(object sender, EventArgs e)
        {
            renglones();
        }

        private void btnRANDOM_Click(object sender, EventArgs e)
        {
            random();
        }
    }
}
