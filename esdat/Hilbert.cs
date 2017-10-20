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
    public partial class Hilbert : Form
    {
        public Hilbert()
        {
            InitializeComponent();
           
        }
        private bool DoRefresh;
        private float LastX, LastY;
        private Bitmap HilbertImage;
        private void GENERAR()
        {
            if (cmbVALOR.Text.Trim() == "")
            {
                MessageBox.Show("Es necesario un valor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int depth = int.Parse(cmbVALOR.Text);
                if (depth > 8) return;

                this.Cursor = Cursors.WaitCursor;
                Application.DoEvents();

                //Ver mas a detalle el proceso
                DoRefresh = ckBREFRESCAR.Checked;
                // Get the parameters.
                float total_length, start_x, start_y, start_length;

                // See how big we can make the curve.
                if (pcBHILBERT.ClientSize.Height < pcBHILBERT.ClientSize.Width)
                {
                    total_length = (float)(0.9 * pcBHILBERT.ClientSize.Height);
                }
                else
                {
                    total_length = (float)(0.9 * pcBHILBERT.ClientSize.Width);
                }

                start_x = (pcBHILBERT.ClientSize.Width - total_length) / 2;
                start_y = (pcBHILBERT.ClientSize.Height - total_length) / 2;

                // Compute the side length for this level.
                start_length = (float)(total_length / (Math.Pow(2, depth) - 1));

                HilbertImage = new Bitmap(pcBHILBERT.ClientSize.Width, pcBHILBERT.ClientSize.Height);
                pcBHILBERT.Image = HilbertImage;

                using (Graphics gr = Graphics.FromImage(HilbertImage))
                {
                    // Draw the curve.
                    gr.Clear(pcBHILBERT.BackColor);
                    LastX = (int)start_x;
                    LastY = (int)start_y;
                    Hilbertt(gr, depth, start_length, 0);
                }

                // Display the result.
                pcBHILBERT.Refresh();
                this.Cursor = Cursors.Default;
            }
        }
       
        private void btnINICIAR_Click(object sender, EventArgs e)
        {
            GENERAR();

        }
        private void Hilbertt(Graphics gr, int depth, float dx, float dy)
        {
            if (depth > 1) Hilbertt(gr, depth - 1, dy, dx);
            DrawRelative(gr, dx, dy);
            if (depth > 1) Hilbertt(gr, depth - 1, dx, dy);
            DrawRelative(gr, dy, dx);
            if (depth > 1) Hilbertt(gr, depth - 1, dx, dy);
            DrawRelative(gr, -dx, -dy);
            if (depth > 1) Hilbertt(gr, depth - 1, -dy, -dx);

            if (DoRefresh) pcBHILBERT.Refresh();
        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            GuardarImagen();
        }
        private void GuardarImagen()
        {
            //bool isNullEmpty = pcBHILBERT == null || pcBHILBERT.Image == null;      
            if (pcBHILBERT.Image==null)
            {
              MessageBox.Show("La imagen aun no ha sido generada","Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
            } else {
                SaveFileDialog Guardar = new SaveFileDialog();
                Guardar.Filter = "JPEG(*.JPG)|*.JPG|PNG(*.PNG)|*.PNG";
                Image Imagen = pcBHILBERT.Image;
                Guardar.ShowDialog();
                Imagen.Save(Guardar.FileName);

                MessageBox.Show("Imagen guardada con exito!");
            }
        }

        private void Hilbert_Load(object sender, EventArgs e)
        {
            cmbVALOR.Text = cmbVALOR.Items[4].ToString();//Empezando en el 4
        }

        private void DrawRelative(Graphics gr, float dx, float dy)
        {
            gr.DrawLine(Pens.Black, LastX, LastY, LastX + dx, LastY + dy);
            LastX = LastX + dx;
            LastY = LastY + dy;
        }
    }
    }

