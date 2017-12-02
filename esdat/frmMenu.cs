using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace esdat
{
    public partial class frmMenu : Form
    {
        public frmMenu() => InitializeComponent();
        public int nivel;
        public static string nombre;

        private void practica1ToolStripMenuItem_Click(object sender, EventArgs e) => new frmTipoDatos().ShowDialog();

        private void fibonacciToolStripMenuItem_Click(object sender, EventArgs e) => new frmFibonacci().ShowDialog();

        private void mCDToolStripMenuItem_Click(object sender, EventArgs e) => new Maximo_como_un_divisor().ShowDialog();

        private void fractalDeHilbertToolStripMenuItem_Click(object sender, EventArgs e) => new frmHilbert().ShowDialog();

        private void memoramaToolStripMenuItem_Click(object sender, EventArgs e) => new frmInicioMemorama().ShowDialog();

        private void pruebaDeFibonacciToolStripMenuItem_Click(object sender, EventArgs e) => new Prueba_de_Fibonacci().ShowDialog();

        private void busquedaBinariaToolStripMenuItem_Click(object sender, EventArgs e) => new Busqueda_binaria().ShowDialog();

        private void métodosDeOrdenamientoToolStripMenuItem_Click(object sender, EventArgs e) => new frmMetodoBurbuja().ShowDialog();

        private void cuadradoToolStripMenuItem_Click(object sender, EventArgs e) => new frmCuadroMagico().ShowDialog();

        private void sumaToolStripMenuItem_Click(object sender, EventArgs e) => new Suma_de_matrices().ShowDialog();

        private void recorridoToolStripMenuItem_Click(object sender, EventArgs e) => new frmArboles_recorrido().ShowDialog();

        private void exploradorToolStripMenuItem_Click(object sender, EventArgs e) => new frmArbolesExplorador().ShowDialog();

        private void conDatosToolStripMenuItem_Click(object sender, EventArgs e) => new frmArboles_BD().ShowDialog();

        private void imagenesToolStripMenuItem_Click(object sender, EventArgs e) => new frmArbolesImagenes().ShowDialog();

        private void pilasToolStripMenuItem_Click(object sender, EventArgs e) => new frmPilas().ShowDialog();

        private void evaluacionesDeExpresionesPostfijasToolStripMenuItem_Click(object sender, EventArgs e) => new frmExpresiones_Postfijas().ShowDialog();

        private void torresDeHanoiToolStripMenuItem_Click(object sender, EventArgs e) => new frmTorresDeHanoi().ShowDialog();

        private void inversaToolStripMenuItem_Click(object sender, EventArgs e) => new frmMatrizInversa().ShowDialog();

        private void transpuestaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmMenuTranspuestas().ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new About().ShowDialog();
        }
    }
}
