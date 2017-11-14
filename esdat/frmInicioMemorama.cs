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
    public partial class frmInicioMemorama : Form
    {       
        public frmInicioMemorama()
        {
            InitializeComponent();
            //this.nivel = nivel;
           
        }
        public static string nombre;
        private int nivel;
        private void button1_Click(object sender, EventArgs e)
        {
            nombre = textBox1.Text;
            new frmMemorama_b(nivel, nombre).ShowDialog();
        }

    

        private void button2_Click(object sender, EventArgs e)
        {
            nombre = textBox1.Text;
            new frmMemorama_g(nivel, nombre).ShowDialog();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            nivel = 1000;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            nivel = 500;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            nivel = 100;
        }
    }
}
