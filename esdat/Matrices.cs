using esdat.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace esdat
{
	public class Matrices : Form
	{
		private double[,] Matriz;
		private double[,] MatrizAdjunta;
		private double[,] MatrizTranspuestaAdjunta;
		private double[,] MatrizInvertida;
		private double[,] MatrizIdentidad;
		private int mcg;
		private Random r = new Random();
		private double determinantedeMatriz;
		private IContainer components = null;
		private TextBox txt_x;
		private Button btn_ok;
		private TextBox txt_respuesta;
		private DataGridView grid_Matriz;
		private DataGridView grid2;
		private DataGridView gridtrans;
		private DataGridView gridinversa;
		private DataGridView grididentiti;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
        private Label label6;
        private Label label7;
        private Label label9;
        private Label label8;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Button btnLIMPIAR;
        private Button btnCERRAR;
        private Label label14;
        private Label label15;
        private Label lblMATRIZA;
		public Matrices()
		{
			this.InitializeComponent();
			this.mcg = this.r.Next(3, 5);
			this.txt_x.Text = this.mcg.ToString();
			this.CrearMatriz(this.mcg);
		}
	
		private void CrearMatriz(int mc)
		{
			this.grid_Matriz.Rows.Clear();
			this.grid_Matriz.Columns.Clear();
			this.gridinversa.Rows.Clear();
			this.gridinversa.Columns.Clear();
			this.grid2.Rows.Clear();
			this.grid2.Columns.Clear();
			this.gridtrans.Rows.Clear();
			this.gridtrans.Columns.Clear();
			this.grididentiti.Rows.Clear();
			this.grididentiti.Columns.Clear();
			this.Matriz = new double[mc, mc];
			for (int i = 0; i < mc; i++)
			{
				this.grid_Matriz.Columns.Add("Columna" + i.ToString(), i.ToString());
				this.grid_Matriz.Columns[i].Width = 60;
				this.grid2.Columns.Add("Columna" + i.ToString(), i.ToString());
				this.grid2.Columns[i].Width = 60;
				this.gridtrans.Columns.Add("Columna" + i.ToString(), i.ToString());
				this.gridtrans.Columns[i].Width = 60;
				this.gridinversa.Columns.Add("Columna" + i.ToString(), i.ToString());
				this.gridinversa.Columns[i].Width = 60;
				this.grididentiti.Columns.Add("Columna" + i.ToString(), i.ToString());
				this.grididentiti.Columns[i].Width = 60;
			}
			this.grid_Matriz.Rows.Add(mc);
			this.grid2.Rows.Add(mc);
			this.gridtrans.Rows.Add(mc);
			this.gridinversa.Rows.Add(mc);
			this.grididentiti.Rows.Add(mc);
			for (int i = 0; i < mc; i++)
			{
				for (int j = 0; j < mc; j++)
				{
					int num = this.r.Next(0, 10);
					this.grid_Matriz.Rows[i].Cells[j].Value = num;
				}
			}
		}
        /// <summary>
        /// Realiza todos los métodos de la matriz inversa.
        /// </summary>
        /// <param name="sender">nn</param>
        /// <param name="e">nn</param>
		private void btn_ok_Click(object sender, EventArgs e)
		{
            this.mcg = int.Parse(this.txt_x.Text);
            this.CrearMatriz(this.mcg);
            this.determinantedeMatriz = 0.0;
			for (int i = 0; i < this.mcg; i++)
			{
				for (int j = 0; j < this.mcg; j++)
				{
                    try
                    {
                        this.Matriz[i, j] = double.Parse(this.grid_Matriz.Rows[i].Cells[j].Value.ToString());
                    }
                    catch (NullReferenceException)
                    {
                        MessageBox.Show("Verifique los campos, algún campo está vacío","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Solo se permiten números enteros","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
				}
			}
			this.determinantedeMatriz = this.Determinante(this.Matriz);
			this.txt_respuesta.Text = this.determinantedeMatriz.ToString();
			this.MatrizAdjunta = this.Adjunta(this.Matriz);
			for (int i = 0; i < this.mcg; i++)
			{
				for (int j = 0; j < this.mcg; j++)
				{
					this.grid2.Rows[i].Cells[j].Value = this.MatrizAdjunta[i, j];
				}
			}
			this.MatrizTranspuestaAdjunta = this.TransponerMatriz(this.MatrizAdjunta);
			for (int i = 0; i < this.mcg; i++)
			{
				for (int j = 0; j < this.mcg; j++)
				{
					this.gridtrans.Rows[i].Cells[j].Value = this.MatrizTranspuestaAdjunta[i, j];
				}
			}
			this.MatrizInvertida = this.matrizmenosuno(this.MatrizTranspuestaAdjunta, this.determinantedeMatriz);
			for (int i = 0; i < this.mcg; i++)
			{
				for (int j = 0; j < this.mcg; j++)
				{
					this.gridinversa.Rows[i].Cells[j].Value = this.MatrizInvertida[i, j];
				}
			}
			this.MatrizIdentidad = this.identidad(this.MatrizInvertida, this.Matriz);
			for (int i = 0; i < this.mcg; i++)
			{
				for (int j = 0; j < this.mcg; j++)
				{
					this.grididentiti.Rows[i].Cells[j].Value = this.MatrizIdentidad[i, j];
				}
			}
		}
        /// <summary>
        /// Multiplica la primera matriz por la inversa.
        /// </summary>
        /// <param name="inmi">dato de la matriz</param>
        /// <param name="inm">dato de la matriz</param>
        /// <returns></returns>
		private double[,] identidad(double[,] inmi, double[,] inm)
		{
			int num = Convert.ToInt32(Math.Pow(double.Parse(inmi.Length.ToString()), 0.5));
			double[,] array = new double[num, num];
			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j < num; j++)
				{
					for (int k = 0; k < num; k++)
					{
						array[i, j] += inm[i, k] * inmi[k, j];
					}
				}
			}
			return array;
		}
        /// <summary>
        /// realiza la inversa lo fracciona.
        /// </summary>
        /// <param name="mta">matriz transpuesta</param>
        /// <param name="deter">determinante</param>
        /// <returns></returns>
		private double[,] matrizmenosuno(double[,] mta, double deter)
		{
			int num = Convert.ToInt32(Math.Pow(double.Parse(mta.Length.ToString()), 0.5));
			double[,] array = new double[num, num];
			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j < num; j++)
				{
					array[i, j] = mta[i, j] / deter;
				}
			}
			return array;
		}
        /// <summary>
        /// Realiza la matriz transpuesta
        /// </summary>
        /// <param name="inmattrans">tipo de dato de la matriz transpuesta</param>
        /// <returns></returns>
		private double[,] TransponerMatriz(double[,] inmattrans)
		{
			int num = Convert.ToInt32(Math.Pow(double.Parse(inmattrans.Length.ToString()), 0.5));
			double[,] array = new double[num, num];
			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j < num; j++)
				{
					array[i, j] = inmattrans[j, i];
				}
			}
			return array;
		}
        /// <summary>
        /// Realiza la matriz adjunta.
        /// </summary>
        /// <param name="inMatriz3">nombre de la matriz</param>
        /// <returns></returns>
		private double[,] Adjunta(double[,] inMatriz3)
		{
			int num = Convert.ToInt32(Math.Pow(double.Parse(inMatriz3.Length.ToString()), 0.5));
			double[,] array = new double[num, num];
			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j < num; j++)
				{
					array[i, j] = Math.Pow(-1.0, (double)(i + j)) * this.Determinante(this.ConseguirMatrizAlterna(inMatriz3, i, j));
				}
			}
			return array;
		}
        /// <summary>
        /// Calcula la determinante
        /// </summary>
        /// <param name="inMatriz">nombre de la matriz</param>
        /// <returns></returns>
		private double Determinante(double[,] inMatriz)
		{
			double num = 0.0;
			double num2 = Math.Pow(double.Parse(inMatriz.Length.ToString()), 0.5);
			if (num2 == 2.0)
			{
				num = inMatriz[0, 0] * inMatriz[1, 1] - inMatriz[0, 1] * inMatriz[1, 0];
			}
			else
			{
				int num3 = Convert.ToInt32(num2 - 1.0);
				double[,] inMatriz2 = new double[num3, num3];
				int num4 = 0;
				while ((double)num4 < num2)
				{
					inMatriz2 = this.ConseguirMatrizAlterna(inMatriz, 0, num4);
					num += Math.Pow(-1.0, (double)num4) * inMatriz[0, num4] * this.Determinante(inMatriz2);
					num4++;
				}
			}
			return num;
		}
        /// <summary>
        /// Realiza el proceso de la determinante con una matriz alterna
        /// </summary>
        /// <param name="inMatriz2"></param>
        /// <param name="posicioni"></param>
        /// <param name="posicionj"></param>
        /// <returns></returns>
		private double[,] ConseguirMatrizAlterna(double[,] inMatriz2, int posicioni, int posicionj)
		{
			int num = Convert.ToInt32(Math.Pow(double.Parse(inMatriz2.Length.ToString()), 0.5)) - 1;
			double[,] array = new double[num, num];
			int num2 = 0;
			for (int i = 0; i < num; i++)
			{
				if (i == posicionj)
				{
					num2 = 1;
				}
				if (num2 == 0)
				{
					int num3 = 0;
					for (int j = 0; j < num; j++)
					{
						if (j == posicioni)
						{
							num3 = 1;
						}
						if (num3 == 0)
						{
							array[j, i] = inMatriz2[j, i];
						}
						else
						{
							array[j, i] = inMatriz2[j + 1, i];
						}
					}
				}
				else
				{
					int num3 = 0;
					for (int j = 0; j < num; j++)
					{
						if (j == posicioni)
						{
							num3 = 1;
						}
						if (num3 == 0)
						{
							array[j, i] = inMatriz2[j, i + 1];
						}
						else
						{
							array[j, i] = inMatriz2[j + 1, i + 1];
						}
					}
				}
			}
			return array;
		}
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}
		private void InitializeComponent()
		{
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_x = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.txt_respuesta = new System.Windows.Forms.TextBox();
            this.grid_Matriz = new System.Windows.Forms.DataGridView();
            this.grid2 = new System.Windows.Forms.DataGridView();
            this.gridtrans = new System.Windows.Forms.DataGridView();
            this.gridinversa = new System.Windows.Forms.DataGridView();
            this.grididentiti = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMATRIZA = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnLIMPIAR = new System.Windows.Forms.Button();
            this.btnCERRAR = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Matriz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridtrans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridinversa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grididentiti)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_x
            // 
            this.txt_x.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_x.Enabled = false;
            this.txt_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_x.Location = new System.Drawing.Point(31, 451);
            this.txt_x.Name = "txt_x";
            this.txt_x.Size = new System.Drawing.Size(61, 26);
            this.txt_x.TabIndex = 1;
            this.txt_x.Text = "3";
            this.txt_x.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_x.Visible = false;
            // 
            // btn_ok
            // 
            this.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.Location = new System.Drawing.Point(525, 414);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(156, 41);
            this.btn_ok.TabIndex = 3;
            this.btn_ok.Text = "Calcular";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // txt_respuesta
            // 
            this.txt_respuesta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_respuesta.Enabled = false;
            this.txt_respuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_respuesta.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txt_respuesta.Location = new System.Drawing.Point(135, 170);
            this.txt_respuesta.Name = "txt_respuesta";
            this.txt_respuesta.Size = new System.Drawing.Size(209, 26);
            this.txt_respuesta.TabIndex = 1;
            this.txt_respuesta.Text = "Determinante";
            // 
            // grid_Matriz
            // 
            this.grid_Matriz.AllowUserToAddRows = false;
            this.grid_Matriz.AllowUserToDeleteRows = false;
            this.grid_Matriz.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_Matriz.BackgroundColor = System.Drawing.Color.White;
            this.grid_Matriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Matriz.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_Matriz.DefaultCellStyle = dataGridViewCellStyle1;
            this.grid_Matriz.Location = new System.Drawing.Point(82, 50);
            this.grid_Matriz.Name = "grid_Matriz";
            this.grid_Matriz.RowHeadersVisible = false;
            this.grid_Matriz.Size = new System.Drawing.Size(262, 118);
            this.grid_Matriz.TabIndex = 4;
            // 
            // grid2
            // 
            this.grid2.AllowUserToAddRows = false;
            this.grid2.AllowUserToDeleteRows = false;
            this.grid2.BackgroundColor = System.Drawing.Color.White;
            this.grid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid2.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid2.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid2.Location = new System.Drawing.Point(525, 50);
            this.grid2.Name = "grid2";
            this.grid2.ReadOnly = true;
            this.grid2.RowHeadersVisible = false;
            this.grid2.Size = new System.Drawing.Size(262, 115);
            this.grid2.TabIndex = 5;
            // 
            // gridtrans
            // 
            this.gridtrans.AllowUserToAddRows = false;
            this.gridtrans.AllowUserToDeleteRows = false;
            this.gridtrans.BackgroundColor = System.Drawing.Color.White;
            this.gridtrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridtrans.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridtrans.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridtrans.Location = new System.Drawing.Point(82, 261);
            this.gridtrans.Name = "gridtrans";
            this.gridtrans.ReadOnly = true;
            this.gridtrans.RowHeadersVisible = false;
            this.gridtrans.Size = new System.Drawing.Size(262, 117);
            this.gridtrans.TabIndex = 6;
            // 
            // gridinversa
            // 
            this.gridinversa.AllowUserToAddRows = false;
            this.gridinversa.AllowUserToDeleteRows = false;
            this.gridinversa.BackgroundColor = System.Drawing.Color.White;
            this.gridinversa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridinversa.ColumnHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridinversa.DefaultCellStyle = dataGridViewCellStyle4;
            this.gridinversa.Location = new System.Drawing.Point(525, 261);
            this.gridinversa.Name = "gridinversa";
            this.gridinversa.ReadOnly = true;
            this.gridinversa.RowHeadersVisible = false;
            this.gridinversa.Size = new System.Drawing.Size(262, 117);
            this.gridinversa.TabIndex = 6;
            // 
            // grididentiti
            // 
            this.grididentiti.AllowUserToAddRows = false;
            this.grididentiti.AllowUserToDeleteRows = false;
            this.grididentiti.BackgroundColor = System.Drawing.Color.White;
            this.grididentiti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grididentiti.ColumnHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grididentiti.DefaultCellStyle = dataGridViewCellStyle5;
            this.grididentiti.Location = new System.Drawing.Point(889, 157);
            this.grididentiti.Name = "grididentiti";
            this.grididentiti.ReadOnly = true;
            this.grididentiti.RowHeadersVisible = false;
            this.grididentiti.Size = new System.Drawing.Size(246, 111);
            this.grididentiti.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Matriz A";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(572, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Matriz Adjunta";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(572, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Matriz Inversa";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(106, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 42);
            this.label4.TabIndex = 8;
            this.label4.Text = "Matriz Transpuesta\r\n     de la Adjunta\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(927, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Matriz Identidad";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMATRIZA
            // 
            this.lblMATRIZA.AutoSize = true;
            this.lblMATRIZA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMATRIZA.Location = new System.Drawing.Point(36, 50);
            this.lblMATRIZA.Name = "lblMATRIZA";
            this.lblMATRIZA.Size = new System.Drawing.Size(40, 25);
            this.lblMATRIZA.TabIndex = 9;
            this.lblMATRIZA.Text = "A=";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(77, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "|A|=";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(470, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "A*=";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "(A*)ͭ=";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(350, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "A   =";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(368, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 15);
            this.label10.TabIndex = 15;
            this.label10.Text = "-1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(413, 281);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 25);
            this.label11.TabIndex = 16;
            this.label11.Text = " 1 ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(413, 306);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 25);
            this.label12.TabIndex = 17;
            this.label12.Text = "|A|";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(454, 291);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 25);
            this.label13.TabIndex = 18;
            this.label13.Text = "(A*)ͭ=";
            // 
            // btnLIMPIAR
            // 
            this.btnLIMPIAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLIMPIAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLIMPIAR.Location = new System.Drawing.Point(687, 414);
            this.btnLIMPIAR.Name = "btnLIMPIAR";
            this.btnLIMPIAR.Size = new System.Drawing.Size(156, 41);
            this.btnLIMPIAR.TabIndex = 19;
            this.btnLIMPIAR.Text = "Limpiar";
            this.btnLIMPIAR.UseVisualStyleBackColor = true;
            this.btnLIMPIAR.Click += new System.EventHandler(this.btnLIMPIAR_Click);
            // 
            // btnCERRAR
            // 
            this.btnCERRAR.BackColor = System.Drawing.Color.Salmon;
            this.btnCERRAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCERRAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCERRAR.Location = new System.Drawing.Point(849, 414);
            this.btnCERRAR.Name = "btnCERRAR";
            this.btnCERRAR.Size = new System.Drawing.Size(156, 41);
            this.btnCERRAR.TabIndex = 20;
            this.btnCERRAR.Text = "Cerrar";
            this.btnCERRAR.UseVisualStyleBackColor = false;
            this.btnCERRAR.Click += new System.EventHandler(this.btnCERRAR_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(774, 189);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 25);
            this.label14.TabIndex = 21;
            this.label14.Text = "|=A·A    =";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(836, 189);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 15);
            this.label15.TabIndex = 22;
            this.label15.Text = "-1";
            // 
            // Matrices
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1146, 489);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnCERRAR);
            this.Controls.Add(this.btnLIMPIAR);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblMATRIZA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grididentiti);
            this.Controls.Add(this.gridinversa);
            this.Controls.Add(this.gridtrans);
            this.Controls.Add(this.grid2);
            this.Controls.Add(this.grid_Matriz);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.txt_respuesta);
            this.Controls.Add(this.txt_x);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Matrices";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matriz Inversa";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Matrices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Matriz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridtrans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridinversa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grididentiti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
        private void Matrices_Load(object sender, EventArgs e)
        {
            txt_x.Clear();
            txt_x.Text = "3";
        }
        private void btnCERRAR_Click(object sender, EventArgs e) => this.Close();
        private void btnLIMPIAR_Click(object sender, EventArgs e)
        {
            grid2.Rows.Clear();
            grididentiti.Rows.Clear();
            gridinversa.Rows.Clear();
            grid_Matriz.Rows.Clear();
            gridtrans.Rows.Clear();
            txt_x.Clear();
            txt_x.Focus();
            Matrices_Load(sender, e);
        }
    }
}
