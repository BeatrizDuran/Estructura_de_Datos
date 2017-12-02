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
    public partial class frmPractica1_2 : Form
    {
        //Declaracion de variables de clase privadas.
        private int column = 0;
        private int row = 0;
        private int res; //dato de salida de los parceos.
        private double res1;
        private decimal res3;
        //Creando objeto de validaciones
        public void botones()
        {
            txtELEMENTO.Enabled = true;
            btnCAPTURAR.Enabled = true;
        }
        public void txtbox()
        {
            txtNUMCOMPLEJO.Visible = true;
            lblNumComplejos.Visible = true;
        }
        public frmPractica1_2() => InitializeComponent();
        //static public void SNF(TextBox text)
        //{
        //    frm childForm = new frmTipoDatos(text);
        //    childForm.MdiParent = Application.OpenForms[0];
        //    childForm.Height = Application.OpenForms[0].Height -
        //        Application.OpenForms[0].Controls[0].Height -
        //        Application.OpenForms[0].Controls[1].Height -
        //        Application.OpenForms[0].Controls[2].Height - 50;
        //    childForm.Show();
        //}
        private void Pu_1_Load(object sender, EventArgs e)
        {
            initialize_dgvELEMENTOS();
            txtNUMCOM();
        }
        private void txtNUMCOM()
        {
            if (lblVALOR.Text == "(Numeros Complejos)")
            {
                txtNUMCOMPLEJO.Visible = true;
            }
            else
            {
                txtNUMCOMPLEJO.Visible = false;
            }
        }
        public frmPractica1_2(string dataType)
        {
            InitializeComponent();
            lblVALOR.Text = "("+dataType+")";
        }
        private void initialize_dgvELEMENTOS()
        {
            dgvELEMENTOS.Rows.Add();
            dgvELEMENTOS.Rows.Add();
            dgvELEMENTOS.Rows.Add();
            dgvELEMENTOS.Rows[0].HeaderCell.Value = "0";
            dgvELEMENTOS.Rows[1].HeaderCell.Value = "1";
            dgvELEMENTOS.Rows[2].HeaderCell.Value = "2";
            dgvELEMENTOS.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvELEMENTOS.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvELEMENTOS.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
        }
        private void btnCAPTURAR_Click(object sender, EventArgs e) => Validar();
        private void capturar()
        {
            dgvELEMENTOS[column, row].Value = txtELEMENTO.Text;
            dgvELEMENTOS[column, row].Selected = false;
            column++;
            if (column == 3)
            {
                row++;
                column = 0;
            }
            if (row == 3)
            {
                txtELEMENTO.Enabled = false;
                btnCAPTURAR.Enabled = false;
                txtELEMENTO.Focus();
            }
            else
            {
                dgvELEMENTOS.CurrentCell = dgvELEMENTOS[1, row];
                dgvELEMENTOS[1, row].Selected = false;
                dgvELEMENTOS[column, row].Selected = true;
            }
            if (row < 3)
            {
                lblELEMENTO.Text = "Elemento [" + row + "," + column + "]:";
            }
      
            txtELEMENTO.Clear();
            txtELEMENTO.Focus();
        }
        private void Validar()
        {
            //VALIDANDO INT
            if (lblVALOR.Text == "(int)") //seleccionado int
            {
                if (txtELEMENTO.Text.Trim() == "") //se verifica si el campo esta vacio
                {
                    MessageBox.Show("El campo a capturar esta vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtELEMENTO.Focus();
                }
                else
                {
                    if (int.TryParse(txtELEMENTO.Text, out res)) //res no se utiliza, es solo para poder hacer el parceo
                    {
                        capturar(); //captura si es valido :)
                    }
                    else
                    {
                        MessageBox.Show("Solo se permiten numeros enteros, no se capturo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); // marca el error y no captua :(
                    }
                }
            }
            //VALIDANDO DOUBLE
            if (lblVALOR.Text == "(double)") //seleccionado double
            {
                txtNUMCOMPLEJO.Visible = false;
                lblNumComplejos.Visible = false;
                if (txtELEMENTO.Text.Trim() == "") //que no exista campo vacio a capturar
                {
                    MessageBox.Show("El campo a capturar esta vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtELEMENTO.Focus();
                }
                else
                {
                    if (double.TryParse(txtELEMENTO.Text, out res1)) //valida si es double
                    {
                        if (int.TryParse(res.ToString(), out res)) //verificar si se colo un entero
                        {
                            MessageBox.Show("Solo se permiten numeros fraccionados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); //segunda verificación para descartar el entero
                        }
                        else
                        {
                            capturar(); //captura si es valido :)
                        }
                    }
                    else
                    {
                        MessageBox.Show("Solo se permiten numeros fraccionados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            //VALIDANDO DECIMAL
            if (lblVALOR.Text == "(decimal)") //seleccionado decimal
            {
                txtNUMCOMPLEJO.Visible = false;
                lblNumComplejos.Visible = false;
                if (txtELEMENTO.Text == "")
                {
                    MessageBox.Show("El campo esta vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtELEMENTO.Focus();
                }
                else
                {
                    if (decimal.TryParse(txtELEMENTO.Text, out res3))
                    {
                        capturar(); //captura si es valido :)
                    }
                    else
                    {
                        MessageBox.Show("Solo se permiten cifras con decimales", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            //VALIDANDO STRING
            if (lblVALOR.Text == "(string)") //seleccionado string
            {
                txtNUMCOMPLEJO.Visible = false;
                lblNumComplejos.Visible = false;
                if (txtELEMENTO.Text == "")
                {
                    MessageBox.Show("El campo esta vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtELEMENTO.Focus();
                }
                else
                {
                    if (txtELEMENTO.Text.Length >=2) //se valida que se cuente con mas de un caracter para ser string
                    {
                        capturar(); //captura si es valido :)
                    }
                    else
                    {
                        MessageBox.Show("Se debe capturar uno mas caracteres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtELEMENTO.Focus();
                    }
                }
            }         
            //VALIDANDO CHAR
            if (lblVALOR.Text == "(char)") //seleccionado string
            {
                txtNUMCOMPLEJO.Visible = false;
                if (txtELEMENTO.Text == "")
                {
                    MessageBox.Show("El campo esta vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtELEMENTO.Focus();
                }
                else
                {
                    if (txtELEMENTO.Text.Length == 1) //se valida que sa un caracter
                    {
                        capturar(); //captura si es valido :)
                    }
                    else
                    {
                        MessageBox.Show("Se debe capturar un caracter", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtELEMENTO.Focus();
                    }
                }
            }
            //NUMEROS COMPLEJOS......................................................................
            if (lblVALOR.Text == "(Numeros Complejos)") //seleccionado NC1
            {

                lblNumComplejos.Text = "(int)";
                txtNUMCOMPLEJO.Visible = true;
                if (txtELEMENTO.Text == "" || txtNUMCOMPLEJO.Text == "")
                {
                    MessageBox.Show("El campo esta vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtELEMENTO.Focus();
                }
                else
                {
                    if (int.TryParse(txtNUMCOMPLEJO.Text, out res)) //res no se utiliza, es solo para poder hacer el parceo
                    {
                        capturarNumComplejos(); //captura si es valido :)
                    }
                    else
                    {
                        MessageBox.Show("Solo se permiten numeros enteros, no se capturo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); // marca el error y no captua :(
                    }

                }
            }
            // capturar numeros complejos...............................................

        }
        private void capturarNumComplejos()
        {
            dgvELEMENTOS[column, row].Value = txtELEMENTO.Text+" + "+txtNUMCOMPLEJO.Text+"i";
            dgvELEMENTOS[column, row].Selected = false;
            column++;
            if (column == 3)
            {
                row++;
                column = 0;
            }
            if (row == 3)
            {
                txtELEMENTO.Enabled = false;
                btnCAPTURAR.Enabled = false;
                txtNUMCOMPLEJO.Enabled = false;
                txtELEMENTO.Focus();
            }
            else
            {
                dgvELEMENTOS.CurrentCell = dgvELEMENTOS[1, row];
                dgvELEMENTOS[1, row].Selected = false;
                dgvELEMENTOS[column, row].Selected = true;
            }
            if (row < 3)
            {
                lblELEMENTO.Text = "Elemento [" + row + "," + column + "]:";
            }

            txtELEMENTO.Clear();
            txtNUMCOMPLEJO.Clear();
            txtELEMENTO.Focus();
        }
        private void btnREINICIAR_Click(object sender, EventArgs e)
        {
            dgvELEMENTOS.Rows.Clear();
            Pu_1_Load(sender, e);          
            botones();
        }
        private void btSalir_Click(object sender, EventArgs e) => this.Close();
        private void dgvELEMENTOS_CellClick(object sender, DataGridViewCellEventArgs e) => lblELEMENTO_SELECCIONADO.Text = " Elemento + [" + e.ColumnIndex + "," + e.RowIndex + "]. Seleccionado = ";
    }
}