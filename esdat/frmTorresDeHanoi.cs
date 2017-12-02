using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

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
            pcbD1.MouseDown += pcbD1_MouseDown;
            pcbD2.MouseDown += pcbD2_MouseDown;
            pcbD3.MouseDown += pcbD3_MouseDown;
            pcbD4.MouseDown += pcbD4_MouseDown;
            pcbD5.MouseDown += pcbD5_MouseDown;
        }
        private void Solucion(Stack<PictureBox> pila1, Stack<PictureBox> pila2, PictureBox pictureBox, Panel panel)
        {
            Validador(pila1, pila2, pictureBox);
            pictureBox.Parent = panel;
            panel1.Update();
            panel2.Update();
            panel3.Update();
            pictureBox.BringToFront();
            pictureBox.Update();
            Thread.Sleep(700);
        }
        /// <summary>
        /// Metodo que permite contar las veces que movio el pictureBox.
        /// </summary>
        private void CuentaMueve(PictureBox pic)
        {
            origin = pic.Parent.Name;
            pic.DoDragDrop(pic, DragDropEffects.Move);
            if (!SetPosition(pic, origin))
            {
                switch (origin)
                {
                    case "panel1":  pic.Parent = panel1;
                        break;
                    case "panel2":  pic.Parent = panel2;
                        break;
                    case "panel3": pic.Parent = panel3;
                        break;
                }
            }
            pic.BringToFront();
        }
        private bool SetPosition(PictureBox pic, string origin)
        {
            if (origin == pic.Parent.Name)  return false;
            //MessageBox.Show("Vienes de " + origin + " y vas a "+pic.Parent.Name);
            switch (pic.Parent.Name)
            {
                case "panel1":
                    if (origin == "panel2")  return Validador(pila2, pila1, pic);
                    if (origin == "panel3")  return Validador(pila3, pila1, pic);
                    break;
                case "panel2":
                    if (origin == "panel1") return Validador(pila1, pila2, pic);
                    if (origin == "panel3") return Validador(pila3, pila2, pic);
                    break;
                case "panel3":
                    if (origin == "panel1") return Validador(pila1, pila3, pic);
                    if (origin == "panel2") return Validador(pila2, pila3, pic);
                    break;
            }
            return true;
        }
        private bool Validador(Stack<PictureBox> origen,Stack<PictureBox> destino, PictureBox pictureBox)
        {
            if ((destino.Count == 0 && 
                pictureBox.Tag == origen.Peek().Tag) ||   
                (destino.Count != 0 &&
                int.Parse(destino.Peek().Tag.ToString()) > int.Parse(pictureBox.Tag.ToString())
              //  && origen.Peek().Tag.ToString() == pictureBox.Tag.ToString()))
            && pictureBox.Tag.ToString() == origen.Peek().Tag.ToString()))
            {
                destino.Push(origen.Pop());
                pictureBox.Top = panel1.Height - pictureBox.Height - destino.Count * pictureBox.Height;
                lblMOVIMIENTO.Text = (++con).ToString();
                lblMOVIMIENTO.Update();
            }
                else  return false;
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

            //Permite que los picturebox se queden en el panel1
            pcbD1.Parent = panel1;
            pcbD2.Parent = panel1;
            pcbD3.Parent = panel1;
            pcbD4.Parent = panel1;
            pcbD5.Parent = panel1;

            pcbD1.Top = panel1.Height - pcbD1.Height - 0 * pcbD1.Height - pcbBASE1.Height;
            pcbD2.Top = panel1.Height - pcbD2.Height - 1 * pcbD2.Height - pcbBASE1.Height;
            pcbD3.Top = panel1.Height - pcbD3.Height - 2 * pcbD3.Height - pcbBASE1.Height;
            pcbD4.Top = panel1.Height - pcbD4.Height - 3 * pcbD4.Height - pcbBASE1.Height;
            pcbD5.Top = panel1.Height - pcbD5.Height - 4 * pcbD5.Height - pcbBASE1.Height;

            pcbD1.BringToFront();
            pcbD2.BringToFront();
            pcbD3.BringToFront();
            pcbD4.BringToFront();
            pcbD5.BringToFront();

            //Permite que esten encima los discos de las barras
            pila1.Clear();

            pila1.Push(pcbD1);
            pila1.Push(pcbD2);
            pila1.Push(pcbD3);
            pila1.Push(pcbD4);
            pila1.Push(pcbD5);

            pila2.Clear();
            pila3.Clear();
            //Inicializando el contador.
            con = 0;
            lblMOVIMIENTO.Text = this.con.ToString();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=yrNWiFFbcEY");
        private void btnSALIR_Click(object sender, EventArgs e) => this.Close();
        private void btnREINICIO_Click(object sender, EventArgs e) => frmTorresDeHanoi_Load(sender, e);
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => System.Diagnostics.Process.Start("https://es.wikipedia.org/wiki/Torres_de_Han%C3%B3i");

        private void btnSOLUCION_Click(object sender, EventArgs e)
        {
            frmTorresDeHanoi_Load(sender, e);
            Solucion(pila1, pila3, pcbD5, panel3); // 1..1C
            Solucion(pila1, pila2, pcbD4, panel2);//2...2B
            Solucion(pila3, pila2, pcbD5, panel2);//3...1B
            Solucion(pila1, pila3, pcbD3, panel3);//4...3C
            Solucion(pila2, pila1, pcbD5, panel1);//5...1A
            Solucion(pila2, pila3, pcbD4, panel3);//6...2C
            Solucion(pila1, pila3, pcbD5, panel3);//7...1C
            Solucion(pila1, pila2, pcbD2, panel2);//8....4B
            Solucion(pila3, pila2, pcbD5, panel2);//9...1B
            Solucion(pila3, pila1, pcbD4, panel1);//10....2A
            Solucion(pila2, pila1, pcbD5, panel1);//11...1A
            Solucion(pila3, pila2, pcbD3, panel2);//12...3B.
           Solucion(pila1, pila3, pcbD5, panel3);//13...1C
            Solucion(pila1, pila2, pcbD4, panel2);//14...2B
            Solucion(pila3, pila2, pcbD5, panel2);//15...1B........5C
            Solucion(pila1, pila3, pcbD1, panel3);//16...5C.......1A
            Solucion(pila2, pila3, pcbD5, panel3);//18...1C
            Solucion(pila2, pila1, pcbD4, panel1);//19...3A
            Solucion(pila3, pila1, pcbD5, panel1);//20...1B
            Solucion(pila1, pila2, pcbD5, panel2);//21...2A
            Solucion(pila1, pila3, pcbD4, panel3);//22...1A
            Solucion(pila2, pila3, pcbD5, panel3);//23...4C
            Solucion(pila2, pila1, pcbD3, panel1);//24...1C
           Solucion(pila3, pila2, pcbD5, panel2);//25...2B
            Solucion(pila3, pila1, pcbD4, panel1);//26...1B
            Solucion(pila2, pila1, pcbD5, panel1);//27...3C
            Solucion(pila2, pila3, pcbD2, panel3);//28...1A
            Solucion(pila1, pila3, pcbD5, panel3);//29...2C
            Solucion(pila1, pila2, pcbD4, panel2);//30...1C
            Solucion(pila3, pila2, pcbD5, panel2);//31...1C
           Solucion(pila1, pila3, pcbD3, panel3);//32...1C
           Solucion(pila2, pila1, pcbD5, panel1);//33...1C
          Solucion(pila2, pila3, pcbD4, panel3);//34...1C
           Solucion(pila1, pila3, pcbD5, panel3);//35...1C
        }
    }
}
