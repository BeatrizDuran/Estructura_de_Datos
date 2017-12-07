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
    public partial class frmTranspuesta : Form
    {
        private int columnas, renglones;
        private Random R = new Random();
        int r;
        public frmTranspuesta(int columnas, int renglones)
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
                    if ((String)dgvM.Rows[h].Cells[d].Value == null)
                    {
                        MessageBox.Show("Algún campo está vacío en la primera matriz", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        dgvMT[h, d].Value = dgvM[d, h].Value.ToString();
                    }
            }
        private void CellEndEdit()
        {
            if ((String)dgvM.CurrentCell.Value == null)
            {
                MessageBox.Show("Alguna celda esta vacia", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (int.TryParse(dgvM.CurrentCell.Value.ToString(), out r))
                {
                    // MessageBox.Show("Correcto");
                }
                else
                {
                    MessageBox.Show("Solo numeros enteros", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    int column = dgvM.CurrentCell.ColumnIndex;
                    int row = dgvM.CurrentCell.RowIndex;
                    dgvM.CurrentCell = dgvM.Rows[row].Cells[column];
                }
            }
        }
        private void btnTRANSPUESTA_Click(object sender, EventArgs e) => transpuesta();
        private void dgvM_CellEndEdit(object sender, DataGridViewCellEventArgs e) => CellEndEdit();

        private void button1_Click(object sender, EventArgs e) => this.Close();

        private void Transpuesta_Load(object sender, EventArgs e) => generar();
    }
}
