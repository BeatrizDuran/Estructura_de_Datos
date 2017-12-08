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
        private int mcg;
        private double[,] Matriz;
        private DataGridView grid_Matriz;
        private double determinantedeMatriz;
        private int r;
        private Random R = new Random();
        public frmMatrizInversa()
        {
            InitializeComponent();
        }
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
        private void DeterminantePaso1()
        {
            this.determinantedeMatriz = 0.0;
            for (int i = 0; i < this.mcg; i++)
            {
                for (int j = 0; j < this.mcg; j++)
                {
                    this.Matriz[i, j] = double.Parse(this.grid_Matriz.Rows[i].Cells[j].Value.ToString());
                }
            }
            this.determinantedeMatriz = this.Determinante(this.Matriz);
            this.txtRESULTADO.Text = this.determinantedeMatriz.ToString();
            //int campo0 = int.Parse(dgvA.CurrentRow.Cells[0].Value.ToString());
            //int campo1 = int.Parse(dgvA.CurrentRow.Cells[1].Value.ToString());
            //int campo2 = int.Parse(dgvA.CurrentRow.Cells[2].Value.ToString());
            //int campo3 = int.Parse(dgvA.CurrentRow.Cells[3].Value.ToString());
            ////int mulTotal = campo1 * campo3;
            //MessageBox.Show(campo0.ToString());
        }
        private double[,] ConseguirMatrizAlterna(double[,] inMatriz2, int posicioni, int posicionj)
        {
            int num = Convert.ToInt32(Math.Pow(double.Parse(inMatriz2.Length.ToString()), 0.5)) - 1;
            double[,] array = new double[num, num];
            int num2 = 0;
            for (int i = 0; i < num; i++)
            {
                if (i == posicionj)
                {
                    num2 = 1;
                }
                if (num2 == 0)
                {
                    int num3 = 0;
                    for (int j = 0; j < num; j++)
                    {
                        if (j == posicioni)
                        {
                            num3 = 1;
                        }
                        if (num3 == 0)
                        {
                            array[j, i] = inMatriz2[j, i];
                        }
                        else
                        {
                            array[j, i] = inMatriz2[j + 1, i];
                        }
                    }
                }
                else
                {
                    int num3 = 0;
                    for (int j = 0; j < num; j++)
                    {
                        if (j == posicioni)
                        {
                            num3 = 1;
                        }
                        if (num3 == 0)
                        {
                            array[j, i] = inMatriz2[j, i + 1];
                        }
                        else
                        {
                            array[j, i] = inMatriz2[j + 1, i + 1];
                        }
                    }
                }
            }
            return array;
        }
        private double Determinante(double[,] inMatriz)
        {
            double num = 0.0;
            double num2 = Math.Pow(double.Parse(inMatriz.Length.ToString()), 0.5);
            if (num2 == 2.0)
            {
                num = inMatriz[0, 0] * inMatriz[1, 1] - inMatriz[0, 1] * inMatriz[1, 0];
            }
            else
            {
                int num3 = Convert.ToInt32(num2 - 1.0);
                double[,] inMatriz2 = new double[num3, num3];
                int num4 = 0;
                while ((double)num4 < num2)
                {
                    inMatriz2 = this.ConseguirMatrizAlterna(inMatriz, 0, num4);
                    num += Math.Pow(-1.0, (double)num4) * inMatriz[0, num4] * this.Determinante(inMatriz2);
                    num4++;
                }
            }
            return num;
        }
        private void MatrizInversa_Load(object sender, EventArgs e) => renglones();
        private void btnRANDOM_Click(object sender, EventArgs e) => random();
        private void btnAmenos1_Click(object sender, EventArgs e) => DeterminantePaso1();
        private void button1_Click(object sender, EventArgs e) => this.Close();
    }
}
