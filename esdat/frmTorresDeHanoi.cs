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
        private Stack<PictureBox> pila1 = new Stack<PictureBox>();
        private Stack<PictureBox> pila2 = new Stack<PictureBox>();
        private Stack<PictureBox> pila3 = new Stack<PictureBox>();

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
            #region
            pcbD1.MouseMove += pcbD1_MouseDown;
            pcbD2.MouseMove += pcbD2_MouseDown;
            pcbD3.MouseMove += pcbD3_MouseDown;
            pcbD4.MouseMove += pcbD4_MouseDown;
            pcbD5.MouseMove += pcbD5_MouseDown;
#endregion
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
            if (!SetPosition(pic, origin))
            {
                switch (origin)
                {
                    case "panel1":
                        pic.Parent = panel1;
                        break;
                    case "panel2":
                        pic.Parent = panel2;
                        break;
                    case "panel3":
                        pic.Parent = panel3;
                        break;
                }
            }
            pic.BringToFront();
           // lblMOVIMIENTO.Text = con++.ToString();
        }
        private bool SetPosition(PictureBox pic, string origin)
        {
            if (origin == pic.Parent.Name)
            {
                return false;
            }
            //MessageBox.Show("Vienes de " + origin + " y vas a "+pic.Parent.Name);
            switch (pic.Parent.Name)
            {
                case "panel1":
                    pic.Top = panel1.Height - pic.Height - pila1.Count * pic.Height;
                    break;
                case "panel2":
                    pic.Top = panel2.Height - pic.Height - pila2.Count * pic.Height;
                    break;
                case "panel3":
                    pic.Top = panel3.Height - pic.Height - pila3.Count * pic.Height;
                    break;
            }
            return true;
        }

        private void pcbD1_MouseDown(object sender, MouseEventArgs e) => CuentaMueve(pcbD1);
        private void pcbD2_MouseDown(object sender, MouseEventArgs e) => CuentaMueve(pcbD2);
        private void pcbD3_MouseDown(object sender, MouseEventArgs e) => CuentaMueve(pcbD3);
        private void pcbD4_MouseDown(object sender, MouseEventArgs e) => CuentaMueve(pcbD4);
        private void pcbD5_MouseDown(object sender, MouseEventArgs e) => CuentaMueve(pcbD5);
        //Habilita en el panel para recibir propiedades de pictureBox cuando lo arrastra.
        private void panel_DragDrop(object sender, DragEventArgs e) => ((PictureBox)e.Data.GetData(typeof(PictureBox))).Parent = (Panel)sender;
        private void panel_DragEnter(object sender, DragEventArgs e) => e.Effect = DragDropEffects.Move;
        private void frmTorresDeHanoi_Load(object sender, EventArgs e)
        {
            //Inicializando el contador.
            con = 0;
            lblMOVIMIENTO.Text = this.con.ToString();
            //Permite que los picturebox se queden en el panel1
            #region
            pcbD1.Parent = panel1;
            pcbD2.Parent = panel1;
            pcbD3.Parent = panel1;
            pcbD4.Parent = panel1;
            pcbD5.Parent = panel1;
            #endregion
            pcbD1.Top = panel1.Height - pcbD1.Height - 0 * pcbD1.Height - pcbBASE1.Height;
            pcbD2.Top = panel1.Height - pcbD2.Height - 0 * pcbD2.Height - pcbBASE1.Height;
            pcbD3.Top = panel1.Height - pcbD3.Height - 0 * pcbD3.Height - pcbBASE1.Height;
            pcbD4.Top = panel1.Height - pcbD4.Height - 0 * pcbD4.Height - pcbBASE1.Height;
            pcbD5.Top = panel1.Height - pcbD5.Height - 0 * pcbD5.Height - pcbBASE1.Height;
            //Permite que esten encima los discos de las barras
            #region
            pcbD1.BringToFront();
            pcbD2.BringToFront();
            pcbD3.BringToFront();
            pcbD4.BringToFront();
            pcbD5.BringToFront();
#endregion
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => System.Diagnostics.Process.Start("");
        private void btnSALIR_Click(object sender, EventArgs e) => this.Close();
        private void btnREINICIO_Click(object sender, EventArgs e) => frmTorresDeHanoi_Load(sender, e);
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => System.Diagnostics.Process.Start("https://es.wikipedia.org/wiki/Torres_de_Han%C3%B3i");
    }
}
