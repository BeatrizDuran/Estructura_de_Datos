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
    public partial class frmTorresDeHanoi : Form
    {
        private int con = 0;
        private string origin = "";
        public frmTorresDeHanoi()
        {
            InitializeComponent();
            //Forma en la cual se realiza los movimientos mediante los metodos de panel_Dragenter, panel_DragDrop.
            foreach (Panel item in this.Controls.OfType<Panel>())
            {
               item.AllowDrop = true;
                item.DragEnter += panel_DragEnter;
                item.DragDrop += panel_DragDrop;
            }
            //Permite mover los picturebox de la forma.
            pcbD1.MouseMove += pcbD1_MouseDown;
            pcbD2.MouseMove += pcbD2_MouseDown;
            pcbD3.MouseMove += pcbD3_MouseDown;
            pcbD4.MouseMove += pcbD4_MouseDown;
            pcbD5.MouseMove += pcbD5_MouseDown;
        }
        /// <summary>
        /// Metodo que permite contar las veces que movio el pictureBox.
        /// </summary>
        private void CuentaMueve(PictureBox pic)
        {
            origin = pic.Parent.Name;
           // MessageBox.Show("Estaba en: " + origin);
            //Permite que se mueva el picturebox.
            pic.DoDragDrop(pic, DragDropEffects.Move);
            //Que el picture box se observe por encima de la barra.
            pic.BringToFront();
            lblMOVIMIENTO.Text = con++.ToString();
        }
        private void pcbD1_MouseDown(object sender, MouseEventArgs e)
        {
            //origin = pcbD1.Parent.Name;
            //MessageBox.Show("Estaba en: "+origin);
            ////Permite que se mueva el picturebox.
            //pcbD1.DoDragDrop(pcbD1, DragDropEffects.Move);
            ////Que el picture box se observe por encima de la barra.
            //pcbD1.BringToFront();
            CuentaMueve(pcbD1);
        }
        private void pcbD2_MouseDown(object sender, MouseEventArgs e)
        {
            CuentaMueve(pcbD2);
        }
        private void pcbD3_MouseDown(object sender, MouseEventArgs e)
        {
            CuentaMueve(pcbD3);
        }
        private void pcbD4_MouseDown(object sender, MouseEventArgs e)
        {
            CuentaMueve(pcbD4);
        }
        private void pcbD5_MouseDown(object sender, MouseEventArgs e)
        {
           CuentaMueve(pcbD5);
        }

        private void panel_DragDrop(object sender, DragEventArgs e)
        {
            //Habilita en el panel para recibir propiedades de pictureBox cuando lo arrastra.
            ((PictureBox)e.Data.GetData(typeof(PictureBox))).Parent=(Panel)sender;
        }
        private void panel_DragEnter(object sender, DragEventArgs e)
        {
            //Permite mover el picture box
            e.Effect = DragDropEffects.Move;
        }
        private void frmTorresDeHanoi_Load(object sender, EventArgs e)
        {
            //Inicializando el contador.
            con = 0;
            lblMOVIMIENTO.Text = this.con.ToString();
            //Permite que los picturebox se queden en el panel1
            pcbD1.Parent = panel1;
            pcbD2.Parent = panel1;
            pcbD3.Parent = panel1;
            pcbD4.Parent = panel1;
            pcbD5.Parent = panel1;
            //Permite que esten encima los discos de las barras
            pcbD1.BringToFront();
            pcbD2.BringToFront();
            pcbD3.BringToFront();
            pcbD4.BringToFront();
            pcbD5.BringToFront();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Enlazar con una solucion al youtube
            System.Diagnostics.Process.Start("");
        }
        private void btnSALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnREINICIO_Click(object sender, EventArgs e)
        {
            //Volver a cargar el form
            frmTorresDeHanoi_Load(sender, e);
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Permite enlazar con el link de wikipedia
            System.Diagnostics.Process.Start("https://es.wikipedia.org/wiki/Torres_de_Han%C3%B3i");
        }
    }
}
