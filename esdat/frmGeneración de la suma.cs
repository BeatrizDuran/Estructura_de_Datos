using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace esdat
{
    public partial class Generación_de_la_suma : Form
    {
        private int columnas, renglones;
        private Random R = new Random();
        Regex regex = new Regex(@"(?:\d*\.)?\d+");
        int r;
        public Generación_de_la_suma(int columnas,int renglones)
        {
            InitializeComponent();
            this.columnas = columnas;
            this.renglones = renglones;
        }
    
        private void resultado()
        {
            try {

                for (int s = 0; s < columnas; s++)
                {
                    for (int r = 0; r < renglones; r++)
                    {
                        if ((String)dgvMATRIZ1.Rows[r].Cells[s].Value == null)
                        {
                            MessageBox.Show("Algún campo está vacío de la Matriz 1","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                        else
                        {
                            if ((String)dgvMATRIZ2.Rows[r].Cells[s].Value == null)
                            {
                                MessageBox.Show("Algún campo está vacío de la Matriz 2", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                dgvRESULTADO[s, r].Value = int.Parse(dgvMATRIZ1[s, r].Value.ToString()) + int.Parse(dgvMATRIZ2[s, r].Value.ToString());
                                RenglonesMatriz3(dgvRESULTADO);
                            }
                        }
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Los datos que se ingresaron son incorrectos","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
        private void operacion()
        {
            dgvMATRIZ1.Rows.Clear();
            dgvMATRIZ1.Columns.Clear();
            dgvMATRIZ2.Rows.Clear();
            dgvMATRIZ2.Columns.Clear();
            dgvRESULTADO.Rows.Clear();
            dgvRESULTADO.Columns.Clear();
            for (int m = 0; m < columnas; m++)
            {
                dgvMATRIZ1.Columns.Add("C" + (m+1), "C" + m.ToString());
                dgvMATRIZ2.Columns.Add("C" + (m + 1), "C" + m.ToString());
                dgvRESULTADO.Columns.Add("C" + (m + 1), "C" + m.ToString());
            }
            for (int i = 0; i < renglones; i++)
            {
                dgvMATRIZ1.Rows.Add();
                for (int l = 0; l < columnas; l++)
                {
                    dgvMATRIZ1.Rows[i].Cells[l].Value=R.Next(0, 10).ToString();
                    Renglones(dgvMATRIZ1);
                }
                dgvMATRIZ2.Rows.Add();
                for (int k = 0; k < columnas; k++)
                {
                    dgvMATRIZ2.Rows[i].Cells[k].Value = R.Next(0, 10).ToString();
                    RenglonesMatriz2(dgvMATRIZ2);
                }
                dgvRESULTADO.Rows.Add();
               
            }
            
        }
        private void Renglones(DataGridView view)
        {
            foreach (DataGridViewRow row in dgvMATRIZ1.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
        }
        private void RenglonesMatriz2(DataGridView view)
        {
            foreach (DataGridViewRow row in dgvMATRIZ2.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
        }
        private void RenglonesMatriz3(DataGridView view)
        {
            foreach (DataGridViewRow row in dgvRESULTADO.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
        }
        private void Matriz1Entero()
        {
            if ((String)dgvMATRIZ1.CurrentCell.Value == null)
            {
                MessageBox.Show("Alguna celda debe estar vacía", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (int.TryParse(dgvMATRIZ1.CurrentCell.Value.ToString(), out r))
                {
                    // MessageBox.Show("Correcto");
                }
                else
                {
                    MessageBox.Show("Solo numeros enteros", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    int column = dgvMATRIZ1.CurrentCell.ColumnIndex;
                    int row = dgvMATRIZ1.CurrentCell.RowIndex;
                    dgvMATRIZ1.CurrentCell = dgvMATRIZ1.Rows[row].Cells[column];
                }
            }
        }
        private void Matriz2Entero()
        {
            if ((String)dgvMATRIZ2.CurrentCell.Value == null)
            {
                MessageBox.Show("Alguna celda esta vacia", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (int.TryParse(dgvMATRIZ2.CurrentCell.Value.ToString(), out r))
                {
                   // MessageBox.Show("Correcto");
                }
                else
                {
                    MessageBox.Show("Solo numeros enteros", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    int column = dgvMATRIZ2.CurrentCell.ColumnIndex;
                    int row = dgvMATRIZ2.CurrentCell.RowIndex;
                    dgvMATRIZ2.CurrentCell = dgvMATRIZ2.Rows[row].Cells[column];
                }
            }
        }
        
        private void btnRESULTADO_Click(object sender, EventArgs e)
        {
            resultado();
        }
        private void btnRANDOM_Click(object sender, EventArgs e)
        {
            operacion();
        }
        private void btnCERRAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgvMATRIZ1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Matriz1Entero();
        }
        private void dgvMATRIZ2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Matriz2Entero();
        }
     
        private void Generación_de_la_suma_Load(object sender, EventArgs e)
        {
            operacion();
        }
    }
}
