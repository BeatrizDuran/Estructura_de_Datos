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
    public partial class frmMemorama_b : Form
    {
        public frmMemorama_b(int nivel,string nombre)
        {
            InitializeComponent();
            this.nivel = nivel;
           // this.nombre = nombre;
        }
        public static string nombre;
        private int nivel;
        private int[] set = { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8 };
        private bool esperando = false;
        private int temporal;
        private PictureBox imagentemporal;
        private int intentos;
        private void restart()
        {
            set = set.OrderBy(s => Guid.NewGuid()).ToArray();//generar el guid para barajear.
            //MessageBox.Show(string.Join("  ", set));
            pictureBox1.Image = esdat.Properties.Resources.miREVERSITOOOOOOO;
            pictureBox2.Image = esdat.Properties.Resources.miREVERSITOOOOOOO;
            pictureBox3.Image = esdat.Properties.Resources.miREVERSITOOOOOOO;
            pictureBox4.Image = esdat.Properties.Resources.miREVERSITOOOOOOO;
            pictureBox5.Image = esdat.Properties.Resources.miREVERSITOOOOOOO;
            pictureBox6.Image = esdat.Properties.Resources.miREVERSITOOOOOOO;
            pictureBox7.Image = esdat.Properties.Resources.miREVERSITOOOOOOO;
            pictureBox8.Image = esdat.Properties.Resources.miREVERSITOOOOOOO;
            pictureBox9.Image = esdat.Properties.Resources.miREVERSITOOOOOOO;
            pictureBox10.Image = esdat.Properties.Resources.miREVERSITOOOOOOO;
            pictureBox11.Image = esdat.Properties.Resources.miREVERSITOOOOOOO;
            pictureBox12.Image = esdat.Properties.Resources.miREVERSITOOOOOOO;
            pictureBox13.Image = esdat.Properties.Resources.miREVERSITOOOOOOO;
            pictureBox14.Image = esdat.Properties.Resources.miREVERSITOOOOOOO;
            pictureBox15.Image = esdat.Properties.Resources.miREVERSITOOOOOOO;
            pictureBox17.Image = esdat.Properties.Resources.miREVERSITOOOOOOO;
            //foreach (PictureBox item in collection)
            //{

            //}
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox8.Visible = true;
            pictureBox9.Visible = true;
            pictureBox10.Visible = true;
            pictureBox11.Visible = true;
            pictureBox12.Visible = true;
            pictureBox13.Visible = true;
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox17.Visible = true;
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;
            pictureBox7.Enabled = true;
            pictureBox8.Enabled = true;
            pictureBox9.Enabled = true;
            pictureBox10.Enabled = true;
            pictureBox11.Enabled = true;
            pictureBox12.Enabled = true;
            pictureBox13.Enabled = true;
            pictureBox14.Enabled = true;
            pictureBox15.Enabled = true;
            pictureBox17.Enabled = true;
            intentos = 0;
        }
        private void flip(PictureBox voltear, int elemento)
        {
            // voltear.Enabled = false;
            //voltear.Visible = false;
            if (set[elemento] == 1) voltear.Image = Properties.Resources.minion1;
            if (set[elemento] == 2)  voltear.Image = Properties.Resources.minion2;
            if (set[elemento] == 3)  voltear.Image = Properties.Resources.minon3;
           if (set[elemento] == 4)   voltear.Image = Properties.Resources.minion4;
             if (set[elemento] == 5) voltear.Image = Properties.Resources.minion5;
           if (set[elemento] == 6) voltear.Image = Properties.Resources.minion6;
            if (set[elemento] == 7) voltear.Image = Properties.Resources.minion7;
            if (set[elemento] == 8) voltear.Image = Properties.Resources.minion88;
            voltear.Update();
            if (esperando == false)
            {
                temporal = elemento;
                imagentemporal = voltear;
                esperando = true;              
            }
            else
            {
                intentos++;
               tlblINTENTOS.Text = "Intentos: " + intentos.ToString();
               
                if (set[elemento] == set[temporal])//el que se presion tenga la misma carta
                {
                    //MessageBox.Show("Que inteligencia la tuya!!");
                    imagentemporal.Enabled = false;
                    imagentemporal.Visible = false;
                    voltear.Enabled = false;
                    voltear.Visible = false;
                    if (pictureBox1.Visible == false && pictureBox2.Visible == false && pictureBox3.Visible == false && pictureBox4.Visible == false && pictureBox5.Visible == false &&
                        pictureBox5.Visible == false && pictureBox6.Visible == false && pictureBox7.Visible == false && pictureBox8.Visible == false && pictureBox9.Visible == false &&
                        pictureBox10.Visible == false && pictureBox11.Visible == false && pictureBox12.Visible == false && pictureBox13.Visible == false && pictureBox14.Visible == false &&
                        pictureBox15.Visible == false && pictureBox17.Visible == false && intentos == 9)
                    {
                        MessageBox.Show("Felicidades!: " + frmInicioMemorama.nombre + " eres un genio!. Intentos = " + intentos);
                    }
                    else if (pictureBox1.Visible == false && pictureBox2.Visible == false && pictureBox3.Visible == false && pictureBox4.Visible == false && pictureBox5.Visible == false &&
                        pictureBox5.Visible == false && pictureBox6.Visible == false && pictureBox7.Visible == false && pictureBox8.Visible == false && pictureBox9.Visible == false &&
                        pictureBox10.Visible == false && pictureBox11.Visible == false && pictureBox12.Visible == false && pictureBox13.Visible == false && pictureBox14.Visible == false &&
                        pictureBox15.Visible == false && pictureBox17.Visible == false && intentos > 9 && intentos < 20)
                    {
                        MessageBox.Show("Muy bien!: " + frmInicioMemorama.nombre + " practica más. Intentos = " + intentos);
                    }
                    else if (pictureBox1.Visible == false && pictureBox2.Visible == false && pictureBox3.Visible == false && pictureBox4.Visible == false && pictureBox5.Visible == false &&
                        pictureBox5.Visible == false && pictureBox6.Visible == false && pictureBox7.Visible == false && pictureBox8.Visible == false && pictureBox9.Visible == false &&
                        pictureBox10.Visible == false && pictureBox11.Visible == false && pictureBox12.Visible == false && pictureBox13.Visible == false && pictureBox14.Visible == false &&
                        pictureBox15.Visible == false && pictureBox17.Visible == false && intentos > 20)
                    {
                        MessageBox.Show("Lo siento: " + frmInicioMemorama.nombre + " no sirves para esto. Intentos = " + intentos);
                    }
                }
                else
                {
                    Thread.Sleep(nivel);
                    imagentemporal.Image = Properties.Resources.miREVERSITOOOOOOO;
                    voltear.Image = Properties.Resources.miREVERSITOOOOOOO;                    
                }
                esperando = false;              
            }
        }      
        private void Memorama_b_Load(object sender, EventArgs e)
        {
            tsbNOMBRE.Text = "Participante: " + frmInicioMemorama.nombre;
            restart();
        }
        private void pictureBox1_Click(object sender, EventArgs e) => flip(pictureBox1, 0);
        private void pictureBox2_Click(object sender, EventArgs e) => flip(pictureBox2, 1);
        private void toolStripButton1_Click(object sender, EventArgs e) => restart();
        private void pictureBox3_Click(object sender, EventArgs e) => flip(pictureBox3, 2);
        private void pictureBox4_Click(object sender, EventArgs e) => flip(pictureBox4, 3);
        private void pictureBox5_Click(object sender, EventArgs e) => flip(pictureBox5, 4);
        private void pictureBox6_Click(object sender, EventArgs e) => flip(pictureBox6, 5);
        private void pictureBox7_Click(object sender, EventArgs e) => flip(pictureBox7, 6);
        private void pictureBox8_Click(object sender, EventArgs e) => flip(pictureBox8, 7);
        private void pictureBox9_Click(object sender, EventArgs e) => flip(pictureBox9, 8);
        private void pictureBox10_Click(object sender, EventArgs e) => flip(pictureBox10, 9);
        private void pictureBox11_Click(object sender, EventArgs e) => flip(pictureBox11, 10);
        private void pictureBox12_Click(object sender, EventArgs e) => flip(pictureBox12, 11);
        private void pictureBox13_Click(object sender, EventArgs e) => flip(pictureBox13, 12);
        private void pictureBox14_Click(object sender, EventArgs e) => flip(pictureBox14, 13);
        private void pictureBox15_Click(object sender, EventArgs e) => flip(pictureBox15, 14);
        private void pictureBox17_Click(object sender, EventArgs e) => flip(pictureBox17, 15);
    }
}
