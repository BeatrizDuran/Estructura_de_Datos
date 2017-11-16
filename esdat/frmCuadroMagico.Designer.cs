namespace esdat
{
    partial class frmCuadroMagico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCuadroMagico));
            this.dgvCUADROMAGICO = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCOL1 = new System.Windows.Forms.Label();
            this.lblCOL2 = new System.Windows.Forms.Label();
            this.lblCOL3 = new System.Windows.Forms.Label();
            this.lblCOL4 = new System.Windows.Forms.Label();
            this.lblDIAGONAL1 = new System.Windows.Forms.Label();
            this.lblRENGLON4 = new System.Windows.Forms.Label();
            this.lblRENGLON3 = new System.Windows.Forms.Label();
            this.lblRENGLON2 = new System.Windows.Forms.Label();
            this.lblRENGLON1 = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.btnLIMPIAR = new System.Windows.Forms.Button();
            this.lblDIAGONAL2 = new System.Windows.Forms.Label();
            this.btnEJEMPLO2 = new System.Windows.Forms.Button();
            this.btnCALCULAR = new System.Windows.Forms.Button();
            this.lblmostrar = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCERRAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCUADROMAGICO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCUADROMAGICO
            // 
            this.dgvCUADROMAGICO.AllowUserToAddRows = false;
            this.dgvCUADROMAGICO.AllowUserToDeleteRows = false;
            this.dgvCUADROMAGICO.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCUADROMAGICO.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCUADROMAGICO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCUADROMAGICO.ColumnHeadersVisible = false;
            this.dgvCUADROMAGICO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvCUADROMAGICO.Location = new System.Drawing.Point(295, 41);
            this.dgvCUADROMAGICO.Name = "dgvCUADROMAGICO";
            this.dgvCUADROMAGICO.RowHeadersVisible = false;
            this.dgvCUADROMAGICO.Size = new System.Drawing.Size(213, 100);
            this.dgvCUADROMAGICO.TabIndex = 0;
            this.dgvCUADROMAGICO.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCUADROMAGICO_CellEndEdit);
            this.dgvCUADROMAGICO.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvCUADROMAGICO_CellValidating);
            // 
            // Column1
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ToolTipText = "g";
            // 
            // Column2
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column3.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column4.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            // 
            // lblCOL1
            // 
            this.lblCOL1.AutoSize = true;
            this.lblCOL1.Location = new System.Drawing.Point(318, 149);
            this.lblCOL1.Name = "lblCOL1";
            this.lblCOL1.Size = new System.Drawing.Size(13, 13);
            this.lblCOL1.TabIndex = 1;
            this.lblCOL1.Text = "0";
            // 
            // lblCOL2
            // 
            this.lblCOL2.AutoSize = true;
            this.lblCOL2.Location = new System.Drawing.Point(370, 149);
            this.lblCOL2.Name = "lblCOL2";
            this.lblCOL2.Size = new System.Drawing.Size(13, 13);
            this.lblCOL2.TabIndex = 2;
            this.lblCOL2.Text = "0";
            // 
            // lblCOL3
            // 
            this.lblCOL3.AutoSize = true;
            this.lblCOL3.Location = new System.Drawing.Point(423, 149);
            this.lblCOL3.Name = "lblCOL3";
            this.lblCOL3.Size = new System.Drawing.Size(13, 13);
            this.lblCOL3.TabIndex = 3;
            this.lblCOL3.Text = "0";
            // 
            // lblCOL4
            // 
            this.lblCOL4.AutoSize = true;
            this.lblCOL4.Location = new System.Drawing.Point(471, 149);
            this.lblCOL4.Name = "lblCOL4";
            this.lblCOL4.Size = new System.Drawing.Size(13, 13);
            this.lblCOL4.TabIndex = 4;
            this.lblCOL4.Text = "0";
            // 
            // lblDIAGONAL1
            // 
            this.lblDIAGONAL1.AutoSize = true;
            this.lblDIAGONAL1.Location = new System.Drawing.Point(276, 149);
            this.lblDIAGONAL1.Name = "lblDIAGONAL1";
            this.lblDIAGONAL1.Size = new System.Drawing.Size(13, 13);
            this.lblDIAGONAL1.TabIndex = 5;
            this.lblDIAGONAL1.Text = "0";
            // 
            // lblRENGLON4
            // 
            this.lblRENGLON4.AutoSize = true;
            this.lblRENGLON4.Location = new System.Drawing.Point(276, 118);
            this.lblRENGLON4.Name = "lblRENGLON4";
            this.lblRENGLON4.Size = new System.Drawing.Size(13, 13);
            this.lblRENGLON4.TabIndex = 6;
            this.lblRENGLON4.Text = "0";
            // 
            // lblRENGLON3
            // 
            this.lblRENGLON3.AutoSize = true;
            this.lblRENGLON3.Location = new System.Drawing.Point(276, 94);
            this.lblRENGLON3.Name = "lblRENGLON3";
            this.lblRENGLON3.Size = new System.Drawing.Size(13, 13);
            this.lblRENGLON3.TabIndex = 7;
            this.lblRENGLON3.Text = "0";
            // 
            // lblRENGLON2
            // 
            this.lblRENGLON2.AutoSize = true;
            this.lblRENGLON2.Location = new System.Drawing.Point(276, 70);
            this.lblRENGLON2.Name = "lblRENGLON2";
            this.lblRENGLON2.Size = new System.Drawing.Size(13, 13);
            this.lblRENGLON2.TabIndex = 8;
            this.lblRENGLON2.Text = "0";
            // 
            // lblRENGLON1
            // 
            this.lblRENGLON1.AutoSize = true;
            this.lblRENGLON1.Location = new System.Drawing.Point(276, 45);
            this.lblRENGLON1.Name = "lblRENGLON1";
            this.lblRENGLON1.Size = new System.Drawing.Size(13, 13);
            this.lblRENGLON1.TabIndex = 9;
            this.lblRENGLON1.Text = "0";
            // 
            // btn
            // 
            this.btn.AccessibleDescription = "EJEMPLO1";
            this.btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.Location = new System.Drawing.Point(39, 96);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(94, 46);
            this.btn.TabIndex = 10;
            this.btn.Text = "Ejemplo 1";
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.btnEJEMPLO1_Click);
            // 
            // btnLIMPIAR
            // 
            this.btnLIMPIAR.BackColor = System.Drawing.Color.White;
            this.btnLIMPIAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLIMPIAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLIMPIAR.Location = new System.Drawing.Point(525, 96);
            this.btnLIMPIAR.Name = "btnLIMPIAR";
            this.btnLIMPIAR.Size = new System.Drawing.Size(113, 45);
            this.btnLIMPIAR.TabIndex = 11;
            this.btnLIMPIAR.Text = "Limpiar";
            this.btnLIMPIAR.UseVisualStyleBackColor = false;
            this.btnLIMPIAR.Click += new System.EventHandler(this.btnLIMPIAR_Click);
            // 
            // lblDIAGONAL2
            // 
            this.lblDIAGONAL2.AutoSize = true;
            this.lblDIAGONAL2.Location = new System.Drawing.Point(276, 23);
            this.lblDIAGONAL2.Name = "lblDIAGONAL2";
            this.lblDIAGONAL2.Size = new System.Drawing.Size(13, 13);
            this.lblDIAGONAL2.TabIndex = 12;
            this.lblDIAGONAL2.Text = "0";
            // 
            // btnEJEMPLO2
            // 
            this.btnEJEMPLO2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEJEMPLO2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEJEMPLO2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEJEMPLO2.Location = new System.Drawing.Point(149, 96);
            this.btnEJEMPLO2.Name = "btnEJEMPLO2";
            this.btnEJEMPLO2.Size = new System.Drawing.Size(94, 45);
            this.btnEJEMPLO2.TabIndex = 13;
            this.btnEJEMPLO2.Text = "Ejemplo 2";
            this.btnEJEMPLO2.UseVisualStyleBackColor = false;
            this.btnEJEMPLO2.Click += new System.EventHandler(this.btnEJEMPLO2_Click);
            // 
            // btnCALCULAR
            // 
            this.btnCALCULAR.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCALCULAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCALCULAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCALCULAR.Location = new System.Drawing.Point(525, 41);
            this.btnCALCULAR.Name = "btnCALCULAR";
            this.btnCALCULAR.Size = new System.Drawing.Size(113, 46);
            this.btnCALCULAR.TabIndex = 14;
            this.btnCALCULAR.Text = "Calcular";
            this.btnCALCULAR.UseVisualStyleBackColor = false;
            this.btnCALCULAR.Click += new System.EventHandler(this.btnCALCULAR_Click);
            // 
            // lblmostrar
            // 
            this.lblmostrar.AutoSize = true;
            this.lblmostrar.Font = new System.Drawing.Font("Playbill", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmostrar.ForeColor = System.Drawing.Color.Sienna;
            this.lblmostrar.Location = new System.Drawing.Point(60, 45);
            this.lblmostrar.Name = "lblmostrar";
            this.lblmostrar.Size = new System.Drawing.Size(13, 24);
            this.lblmostrar.TabIndex = 15;
            this.lblmostrar.Text = "-";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::esdat.Properties.Resources.cuadrado_magico_walfk;
            this.pictureBox1.Image = global::esdat.Properties.Resources.cuadrado_magico_walfk;
            this.pictureBox1.Location = new System.Drawing.Point(39, 183);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 100);
            this.label1.TabIndex = 17;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // btnCERRAR
            // 
            this.btnCERRAR.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCERRAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCERRAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCERRAR.Location = new System.Drawing.Point(425, 320);
            this.btnCERRAR.Name = "btnCERRAR";
            this.btnCERRAR.Size = new System.Drawing.Size(213, 45);
            this.btnCERRAR.TabIndex = 18;
            this.btnCERRAR.Text = "Cerrar";
            this.btnCERRAR.UseVisualStyleBackColor = false;
            this.btnCERRAR.Click += new System.EventHandler(this.btnCERRAR_Click);
            // 
            // frmCuadroMagico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 395);
            this.Controls.Add(this.btnCERRAR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblmostrar);
            this.Controls.Add(this.btnCALCULAR);
            this.Controls.Add(this.btnEJEMPLO2);
            this.Controls.Add(this.lblDIAGONAL2);
            this.Controls.Add(this.btnLIMPIAR);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.lblRENGLON1);
            this.Controls.Add(this.lblRENGLON2);
            this.Controls.Add(this.lblRENGLON3);
            this.Controls.Add(this.lblRENGLON4);
            this.Controls.Add(this.lblDIAGONAL1);
            this.Controls.Add(this.lblCOL4);
            this.Controls.Add(this.lblCOL3);
            this.Controls.Add(this.lblCOL2);
            this.Controls.Add(this.lblCOL1);
            this.Controls.Add(this.dgvCUADROMAGICO);
            this.Name = "frmCuadroMagico";
            this.Text = "CuadroMagico";
            this.Load += new System.EventHandler(this.CuadroMagico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCUADROMAGICO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCUADROMAGICO;
        private System.Windows.Forms.Label lblCOL1;
        private System.Windows.Forms.Label lblCOL2;
        private System.Windows.Forms.Label lblCOL3;
        private System.Windows.Forms.Label lblCOL4;
        private System.Windows.Forms.Label lblDIAGONAL1;
        private System.Windows.Forms.Label lblRENGLON4;
        private System.Windows.Forms.Label lblRENGLON3;
        private System.Windows.Forms.Label lblRENGLON2;
        private System.Windows.Forms.Label lblRENGLON1;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnLIMPIAR;
        private System.Windows.Forms.Label lblDIAGONAL2;
        private System.Windows.Forms.Button btnEJEMPLO2;
        private System.Windows.Forms.Button btnCALCULAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label lblmostrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCERRAR;
    }
}