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
        private int[] valores;
        private void validacion()
        {

        }
        private void BUSQUEDA()
        {
            dataGridView1.Rows.Clear();
            valores = new int[20];
            Random r = new Random();
            for (int i = 0; i < valores.Length; i++)
            {
                valores[i] = r.Next(50);
            }
            Array.Sort(valores);
            for (int i = 0; i < valores.Length; i++)
            {
                dataGridView1.Rows.Add(valores[i].ToString());
                dataGridView1.Rows[i].HeaderCell.Value = i.ToString();
            }
        }
        private void btnGENERAR_Click(object sender, EventArgs e)
        {
            BUSQUEDA();
        }

        private void Busqueda_binaria_Load(object sender, EventArgs e)
        {

        }

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {

        }
    }
}
