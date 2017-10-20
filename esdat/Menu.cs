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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        public int nivel;
        public static string nombre;
       
        private void practica1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Practica1_2().ShowDialog();
        }

        private void fibonacciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Fibonacci().ShowDialog();
        }

        private void mCDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Maximo_como_un_divisor().ShowDialog();
        }

        private void fractalDeHilbertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Hilbert().ShowDialog();
        }

        private void memoramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InicioMemorama().ShowDialog();
        }

        private void pruebaDeFibonacciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Prueba_de_Fibonacci().ShowDialog();
        }

        private void busquedaBinariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Busqueda_binaria().ShowDialog();
        }

        private void métodosDeOrdenamientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MetodoBurbuja().ShowDialog();
        }

        private void cuadradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CuadroMagico().ShowDialog();
        }

        private void sumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Suma_de_matrices().ShowDialog();
        }
    }
}
