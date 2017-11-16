﻿using System;
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
    public partial class Generación_de_la_suma : Form
    {
        private int columnas, renglones;
        private Random R = new Random();
        public Generación_de_la_suma(int columnas,int renglones)
        {
            InitializeComponent();
            this.columnas = columnas;
            this.renglones = renglones;
        }
        private Boolean EsEntero(String entero)
        {
            try
            {
                int.Parse(entero);
                return true;
            }
            catch
            {
                return false;
            }
        }
        private void resultado()
        {
            if (dgvMATRIZ1.Rows.Count==0 || dgvMATRIZ2.Rows.Count==0)
            {
                MessageBox.Show("No hay valores para sumar");
            }else
            {
                    for (int s = 0; s < columnas; s++)
                {
                    for (int r = 0; r < renglones; r++)
                    {
                        dgvRESULTADO[s, r].Value = int.Parse(dgvMATRIZ1[s, r].Value.ToString()) + int.Parse(dgvMATRIZ2[s, r].Value.ToString());
                        RenglonesMatriz3(dgvRESULTADO);
                    }
                }
               
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

        private void Generación_de_la_suma_Load(object sender, EventArgs e)
        {
            operacion();
        }
    }
}
