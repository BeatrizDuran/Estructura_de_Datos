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
//limpiar datos

namespace esdat
{
    public partial class Busqueda_binaria : Form
    {
        public Busqueda_binaria()
        {
            InitializeComponent();
        }
        private int resl;
        private int[] valores;
        private void validacion()
        {
            if (txtNUMEROELEMENTOS.Text.Trim() == "" || txtLIMITE.Text.Trim()== "") //se verifica si el campo esta vacio
            {
                MessageBox.Show("El campo a capturar esta vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNUMEROELEMENTOS.Focus();
            }
            else
            {
                if (int.TryParse(txtLIMITE.Text, out resl) && int.TryParse(txtNUMEROELEMENTOS.Text,out resl)) //res no se utiliza, es solo para poder hacer el parceo
                {
                    BUSQUEDA(); //captura si es valido :)
                }
                else
                {
                    MessageBox.Show("Solo se permiten numeros enteros, no se capturo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); // marca el error y no captua :(
                }
            }
        }
        private void BUSQUEDA()
        {
            dgvBusquedaBinaria.Rows.Clear();
            valores = new int[20];
            Random r = new Random();
            for (int i = 0; i < valores.Length; i++)
            {
                valores[i] = r.Next(50);
            }
            Array.Sort(valores);
            for (int i = 0; i < valores.Length; i++)
            {
                dgvBusquedaBinaria.Rows.Add(valores[i].ToString());
                dgvBusquedaBinaria.Rows[i].HeaderCell.Value = i.ToString();
            }
        }
        private void Limpiar()
        {
            txtNUMEROELEMENTOS.Clear();
            txtNUMEROELEMENTOS.Focus();
            txtLIMITE.Clear();
            txtBUSCAR.Clear();
            dgvBusquedaBinaria.Rows.Clear();
        }
        private void BuscarTextChanged()
        {
            if (txtBUSCAR.Text.Trim() == "")
            {
                MessageBox.Show("El campo de busqueda esta vació.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBUSCAR.Focus();
            }
            else
            {
                if (int.TryParse(txtBUSCAR.Text, out resl))
                {
               
                    foreach (DataGridViewRow Row in dgvBusquedaBinaria.Rows)
                    {
                        String strFila = Row.Index.ToString();
                        string Valor = Convert.ToString(Row.Cells["Column1"].Value);
                        dgvBusquedaBinaria.Rows[Convert.ToInt32(strFila)].DefaultCellStyle.BackColor = Color.White;
                        if (this.txtBUSCAR.Text == Valor)
                        {
                            dgvBusquedaBinaria.Rows[Convert.ToInt32(strFila)].DefaultCellStyle.BackColor = Color.LightGreen;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Solo se permiten números enteros.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBUSCAR.Focus();
                }
                
            }
        }
            
        private void btnGENERAR_Click(object sender, EventArgs e)
        {
            validacion();
        }
        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
                BuscarTextChanged();
        }
        private void btnLIMPIAR_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void btnCERRAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
 
    }
}
