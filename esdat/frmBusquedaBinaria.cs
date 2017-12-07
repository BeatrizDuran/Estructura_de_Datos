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
                int txtNum = int.Parse(txtNUMEROELEMENTOS.Text);
                int txtLimite = int.Parse(txtLIMITE.Text);           
                    if (int.TryParse(txtLIMITE.Text, out resl) && int.TryParse(txtNUMEROELEMENTOS.Text,out resl) && txtNum >= 0 && txtLimite >= 0) //res no se utiliza, es solo para poder hacer el parceo
                {
                    BUSQUEDA(); //captura si es valido :)
                }
                else
                {
                    MessageBox.Show("Solo se permiten numeros enteros o positivos, no se capturo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); // marca el error y no captua :(
                }
            }
        }
        /// <summary>
        /// Metodo original de la búsqueda
        /// </summary>
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
                    Renglones(dgvBusquedaBinaria);
                    //  dgvBusquedaBinaria.Rows[i].HeaderCell.Value = i.ToString();
                }
            
        }
        /// <summary>
        /// Realliza el recorrido renglon por rengón del datagridview
        /// </summary>
        /// <param name="view"></param>
        private void Renglones(DataGridView view)
        {
            foreach (DataGridViewRow row in dgvBusquedaBinaria.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
        }
        /// <summary>
        /// Realiza la limpieza de los campos
        /// </summary>
        private void Limpiar()
        {
            txtNUMEROELEMENTOS.Clear();
            txtNUMEROELEMENTOS.Focus();
            txtLIMITE.Clear();
            txtBUSCAR.Clear();
            dgvBusquedaBinaria.Rows.Clear();
        }
        /// <summary>
        /// Realiza la busqueda desde el textbox
        /// </summary>
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

        private void btnGENERAR_Click(object sender, EventArgs e) => validacion();
        private void btnLIMPIAR_Click(object sender, EventArgs e) => Limpiar();
        private void btnBUSQUEDA_Click(object sender, EventArgs e) => BuscarTextChanged();
        private void button1_Click(object sender, EventArgs e) => this.Close();

        private void Busqueda_binaria_Load(object sender, EventArgs e)
        {

        }
    }
}