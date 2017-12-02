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
    public partial class frmMetodoBurbuja : Form
    {
        private int resl;
        public frmMetodoBurbuja()
        {
            InitializeComponent();
        }
        private int cont = 0;
        int[] a_original = new int[50000];
        int[] a_burbuja = new int [50000];
        int[] a_quicksort = new int[50000];
        int[] a_shell = new int[50000];
        int[] a_insert = new int[50000];

        /// <summary>
        /// metodo validar los campos cuando se generan
        /// </summary>
        private void validar()
        {
            if (txtLI.Text.Trim() == "" || txtLS.Text.Trim() == "") //se verifica si el campo esta vacio
            {
                MessageBox.Show("El campo está vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtLI.Focus();
            }
            else
            {
                if (int.TryParse(txtLI.Text, out resl) || int.TryParse(txtLS.Text, out resl))
                {
                    if (int.Parse(txtLI.Text) < int.Parse(txtLS.Text))
                    {
                        generar(); //captura si es valido :)
                    }
                    else
                    {
                        MessageBox.Show("Verificar los valores ingresados","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        txtLI.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); // marca el error y no captua :(
                    txtLI.Focus();
                }
            }
        }
        /// <summary>
        /// validar el datagridview principal si esta vacio
        /// </summary>
        private void calcular()
        {
            if (txtLI.Text.Trim() == "" || txtLS.Text.Trim() == "")
            {
                MessageBox.Show("Hay campos vacíos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (dgvORIGINAL.Rows.Count == 0) //se verifica si el campo esta vacio
                {
                    MessageBox.Show("Es necesario tener datos previos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtLI.Focus();
                }
                else
                {
                    burbuja();
                    insert();
                    shell();
                    label18.Text = "I :" + DateTime.Now.ToLongTimeString();
                    label12.Update();
                    cont = 0;
                    quicksort(0, a_quicksort.Length - 1);
                    imprimirArreglo(dgvQUICKSORT, a_quicksort);
                    label19.Text = "F :" + DateTime.Now.ToLongTimeString();
                    label12.Update();
                    lblIT4.Text = cont.ToString();
                }
            }
        }
        /// <summary>
        /// Genera los numeros en el dataGridView de manera aleatoria
        /// </summary>
        private void generar()
        {
            dgvORIGINAL.Rows.Clear();
            Random r = new Random();
            int LI = int.Parse(txtLI.Text), LS = int.Parse(txtLS.Text);           
            label10.Text = "I " +DateTime.Now.ToLongTimeString();
            label10.Update();
            for (int i = 0; i < 50000; i++)
            {
                a_original[i] = r.Next(LI, LS);            
            }
            imprimirArreglo(dgvORIGINAL, a_original);        
            label11.Text = "F "+DateTime.Now.ToLongTimeString(); 
            //asignando los arreglos a cada uno.
            a_burbuja = a_original;
            a_insert = a_burbuja;
            a_quicksort = a_burbuja;
            a_shell = a_burbuja;
        }
        /// <summary>
        /// Limpia todos los campos del form junto con los dataGridView
        /// </summary>
        private void limpiar()
        {
            dgvORIGINAL.Rows.Clear();
            dgvINSERT.Rows.Clear();
            dgvBURBUJA.Rows.Clear();
            dgvQUICKSORT.Rows.Clear();
            dgvSHELL.Rows.Clear();
            label10.Text = "Inicio ";
            label11.Text = "Final ";
            label12.Text = "Inicio ";
            label13.Text = "Final ";
            label14.Text = "Inicio ";
            label15.Text = "Final ";
            label16.Text = "Inicio ";
            label17.Text = "Final ";
            label18.Text = "Inicio";
            label19.Text = "Final";
            lblIT1.Text = "0";
            lblIT2.Text = "0";
            lblIT3.Text = "0";
            lblIT4.Text = "0";
            txtLI.Focus();
            txtLI.Clear();
            txtLS.Clear();
        }
        /// <summary>
        /// Realiza la impresión de forma generica en los datagridviews.
        /// </summary>
        /// <param name="view">Parametro para el datagridview</param>
        /// <param name="arreglo">Parametro para el arreglo</param>
        private void imprimirArreglo(DataGridView view, int [] arreglo)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                view.Rows.Add(arreglo[i].ToString());
                view.Rows[i].HeaderCell.Value = i.ToString();
               // lblIT2.Text = i.ToString();
            }
        }
        /// <summary>
        /// Realiza el metodo de la burbuja mediante el método de la impresión
        /// </summary>
        private void burbuja()
        {
            
            label12.Text = "I :" + DateTime.Now.ToLongTimeString();
            label12.Update();
            int temp =0;
            double cont = 0;
            for (int i = 0; i < a_burbuja.Length; i++)
            {
                for (int j = 0; j < a_burbuja.Length; j++)
                {
                    cont++;
                    if (a_burbuja[i]<a_burbuja[j])
                    {
                        temp = a_burbuja[i];
                        a_burbuja[i] = a_burbuja[j];
                        a_burbuja[j] = temp;
                    }
                }
            }
            imprimirArreglo(dgvBURBUJA,a_burbuja);
            label13.Text = "F :" + DateTime.Now.ToLongTimeString();
            label12.Update();
            lblIT1.Text = cont.ToString();
        }
        /// <summary>
        /// Realiza lo del metodo quicksort
        /// </summary>
        private void quicksort(int primero,int ultimo)
        {
           
            int i, j, central,temp;
            double privote;
            central= (primero+ultimo)/2;
            privote = a_quicksort[central];
            i = primero;
            j = ultimo;
            do
            {
               
                while (a_quicksort[i]<privote)  i++;
                while (a_quicksort[j] > privote) j--;
                if (i<=j)
                {
                    temp = a_quicksort[i];
                    a_quicksort[i] = a_quicksort[j];
                    a_quicksort[j] = temp;
                    i++;
                    j--;
                    cont++;
                 }
            } while (i<=j);
            if (primero<j)
            {
                quicksort(primero, j);
            }
            if (i < ultimo)
            {
                quicksort(i, ultimo);
            }
            
        }
        /// <summary>
        /// Realiza el metodo de ordenamiento de insert con el arreglo y el insert 
        /// declarado
        /// </summary>
        private void insert()
        {
            label14.Text = "I :" + DateTime.Now.ToLongTimeString();
            label14.Update();
            int auxiliar;
            int j;
            int cont=0;
            for (int i = 0; i < a_insert.Length; i++)
            {
                auxiliar = a_insert[i];
                j = i - 1;
                cont++;
                    while (j>=0 && a_insert[j]>auxiliar)
                {
                    a_insert[j + 1] = a_insert[j];
                    j--;
                }
                a_insert[j + 1] = auxiliar;
            }
            imprimirArreglo(dgvINSERT, a_insert);
            label15.Text = "F :" + DateTime.Now.ToLongTimeString();
            label12.Update();
            lblIT2.Text = cont.ToString();
        }
        /// <summary>
        /// Realiza el metodo de ordenamiento del shell
        /// </summary>
        private void shell()
        {
            label16.Text = "I :" + DateTime.Now.ToLongTimeString();
            label16.Update();
            int salto = 0, siguiente =0, auxiliar =0 , e=0, cont=0;

            salto = a_shell.Length / 2;
            while (salto>0)
            {
                siguiente = 1;
                while (siguiente!=0)
                {
                    siguiente = 0;
                    e = 1;
                    while (e<=(a_shell.Length-salto))
                    {
                        cont++;
                        if (a_shell[e-1]>a_shell[(e-1)+salto])
                        {
                            auxiliar = a_shell[(e - 1) + salto];
                            a_shell[(e - 1) + salto] = a_shell[e - 1];
                            a_shell[e - 1] = auxiliar;
                            siguiente = 1;
                        }
                        e++;
                    }
                    salto = salto / 2;
                }
            }

            imprimirArreglo(dgvSHELL, a_shell);
            label17.Text = "F :" + DateTime.Now.ToLongTimeString();
            label12.Update();
            lblIT3.Text = cont.ToString();
        }

        private void btnGENERAR_Click(object sender, EventArgs e) => validar();
        private void btnLIMPIAR_Click(object sender, EventArgs e) => limpiar();
        private void btnCALCULAR_Click(object sender, EventArgs e) => calcular();

        private void btnCERRAR_Click(object sender, EventArgs e) => this.Close();
    }
}
