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
    public partial class frmCuadroMagico : Form
    {
        public frmCuadroMagico()
        {
            InitializeComponent();
        }
        private void calcular(){
            //REALIZAR LA SUMA
           
                        int[] suma = new int[10];
                        for (int i = 0, r = 3; i < 4; i++, r--)
              {
                            lblDIAGONAL1.Text = (suma[0] += int.Parse(dgvCUADROMAGICO[i, i].Value.ToString())).ToString();
                            lblDIAGONAL2.Text = (suma[1] += int.Parse(dgvCUADROMAGICO[i, r].Value.ToString())).ToString(); lblCOL1.Text = (suma[2] += int.Parse(dgvCUADROMAGICO[0, i].Value.ToString())).ToString();
                            lblCOL2.Text = (suma[3] += int.Parse(dgvCUADROMAGICO[1, i].Value.ToString())).ToString();
                            lblCOL3.Text = (suma[4] += int.Parse(dgvCUADROMAGICO[2, i].Value.ToString())).ToString();
                            lblCOL4.Text = (suma[5] += int.Parse(dgvCUADROMAGICO[3, i].Value.ToString())).ToString();
                            lblRENGLON1.Text = (suma[6] += int.Parse(dgvCUADROMAGICO[r, 0].Value.ToString())).ToString();
                            lblRENGLON2.Text = (suma[7] += int.Parse(dgvCUADROMAGICO[r, 1].Value.ToString())).ToString();
                            lblRENGLON3.Text = (suma[8] += int.Parse(dgvCUADROMAGICO[r, 2].Value.ToString())).ToString();
                            lblRENGLON4.Text = (suma[9] += int.Parse(dgvCUADROMAGICO[r, 3].Value.ToString())).ToString();
               }      
                        if(suma[9]==suma[8] && suma[8]== suma[7] &&
                           suma[7]==suma[6]&& suma[6] == suma[5] &&
                           suma [5] == suma[4] && suma[4]==suma[3]&&
                           suma[3]==suma[2]&& suma[2]==suma[1]&&
                           suma[1]==suma[0])
                        {
                            lblmostrar.Text = "CUADRADO MÁGICO!";
                        }else
                        {
                            lblmostrar.Text = "VERIFICA LOS CAMPOS";
                        }                  
                    }
        private void validar()
        {
            for (int ren = 0, cel = 0; ren < 4; ren++)
            {
                if ((String)dgvCUADROMAGICO.Rows[ren].Cells[cel].Value == null)
                {
                    MessageBox.Show("Verifique las celdas", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                }
                else
                {
                    calcular();
                    break;

                }
            }
        }             
        
     
        private void CuadroMagico_Load(object sender, EventArgs e)
        {
            dgvCUADROMAGICO.Columns[0].Width = 50;
            dgvCUADROMAGICO.Columns[1].Width = 50;
            dgvCUADROMAGICO.Columns[2].Width = 50;
            dgvCUADROMAGICO.Columns[3].Width = 50;
            dgvCUADROMAGICO.Width = 200;
            dgvCUADROMAGICO.Height = 110;
            dgvCUADROMAGICO.Rows.Add();
            dgvCUADROMAGICO.Rows.Add();
            dgvCUADROMAGICO.Rows.Add();
            dgvCUADROMAGICO.Rows.Add();
        }
        private void btnEJEMPLO1_Click(object sender, EventArgs e)
        {
            dgvCUADROMAGICO.Rows.Clear();
            dgvCUADROMAGICO.Rows.Add("16", "3" , "2" , "13");
            dgvCUADROMAGICO.Rows.Add("5" , "10", "11", "8");
            dgvCUADROMAGICO.Rows.Add("9" , "6" , "7" , "12");
            dgvCUADROMAGICO.Rows.Add("4" , "15", "14", "1");
        }
        private void btnLIMPIAR_Click(object sender, EventArgs e)
        {
            dgvCUADROMAGICO.Rows.Clear();
            dgvCUADROMAGICO.Rows.Add();
            dgvCUADROMAGICO.Rows.Add();
            dgvCUADROMAGICO.Rows.Add();
            dgvCUADROMAGICO.Rows.Add();
            lblCOL1.Text = "0";
            lblCOL2.Text = "0";
            lblCOL3.Text = "0";
            lblCOL4.Text = "0";
            lblDIAGONAL1.Text = "0";
            lblDIAGONAL2.Text = "0";
            lblRENGLON1.Text = "0";
            lblRENGLON2.Text = "0";
            lblRENGLON3.Text = "0";
            lblRENGLON4.Text = "0";
            lblmostrar.Text = "";
        }
        private void btnCALCULAR_Click(object sender, EventArgs e)
        {
            validar();
        }

        private void dgvCUADROMAGICO_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (Char.IsNumber(e.KeyChar) || e.KeyChar == (Char)Keys.Back)
            //    MessageBox.Show("Solo numeros enteros");
            //else
            //    MessageBox.Show("...");
        }
    }
}
