namespace esdat
{
    partial class frmExpresiones_Postfijas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEXPRESIONES = new System.Windows.Forms.TextBox();
            this.dgvOPERANDOS = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEVALUAR = new System.Windows.Forms.Button();
            this.btnPASOAPASO = new System.Windows.Forms.Button();
            this.btnREINICIAR = new System.Windows.Forms.Button();
            this.lblRESULTADO = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEJEMPLO1 = new System.Windows.Forms.Button();
            this.EJEMPLO2 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOPERANDOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Expresiones:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tope->";
            // 
            // txtEXPRESIONES
            // 
            this.txtEXPRESIONES.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEXPRESIONES.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEXPRESIONES.Location = new System.Drawing.Point(108, 12);
            this.txtEXPRESIONES.Name = "txtEXPRESIONES";
            this.txtEXPRESIONES.Size = new System.Drawing.Size(510, 29);
            this.txtEXPRESIONES.TabIndex = 2;
            // 
            // dgvOPERANDOS
            // 
            this.dgvOPERANDOS.AllowUserToAddRows = false;
            this.dgvOPERANDOS.AllowUserToDeleteRows = false;
            this.dgvOPERANDOS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOPERANDOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOPERANDOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvOPERANDOS.Location = new System.Drawing.Point(108, 116);
            this.dgvOPERANDOS.Name = "dgvOPERANDOS";
            this.dgvOPERANDOS.Size = new System.Drawing.Size(216, 285);
            this.dgvOPERANDOS.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Operandos";
            this.Column1.Name = "Column1";
            // 
            // btnEVALUAR
            // 
            this.btnEVALUAR.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEVALUAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEVALUAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEVALUAR.Location = new System.Drawing.Point(108, 78);
            this.btnEVALUAR.Name = "btnEVALUAR";
            this.btnEVALUAR.Size = new System.Drawing.Size(112, 32);
            this.btnEVALUAR.TabIndex = 4;
            this.btnEVALUAR.Text = "Evaluar";
            this.btnEVALUAR.UseVisualStyleBackColor = false;
            this.btnEVALUAR.Click += new System.EventHandler(this.btnEVALUAR_Click);
            // 
            // btnPASOAPASO
            // 
            this.btnPASOAPASO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPASOAPASO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPASOAPASO.Location = new System.Drawing.Point(226, 78);
            this.btnPASOAPASO.Name = "btnPASOAPASO";
            this.btnPASOAPASO.Size = new System.Drawing.Size(136, 32);
            this.btnPASOAPASO.TabIndex = 5;
            this.btnPASOAPASO.Text = "Paso a paso";
            this.btnPASOAPASO.UseVisualStyleBackColor = true;
            this.btnPASOAPASO.Click += new System.EventHandler(this.btnPASOAPASO_Click);
            // 
            // btnREINICIAR
            // 
            this.btnREINICIAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnREINICIAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnREINICIAR.Location = new System.Drawing.Point(368, 78);
            this.btnREINICIAR.Name = "btnREINICIAR";
            this.btnREINICIAR.Size = new System.Drawing.Size(105, 32);
            this.btnREINICIAR.TabIndex = 6;
            this.btnREINICIAR.Text = "Reiniciar";
            this.btnREINICIAR.UseVisualStyleBackColor = true;
            // 
            // lblRESULTADO
            // 
            this.lblRESULTADO.AutoSize = true;
            this.lblRESULTADO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRESULTADO.Location = new System.Drawing.Point(330, 116);
            this.lblRESULTADO.Name = "lblRESULTADO";
            this.lblRESULTADO.Size = new System.Drawing.Size(86, 20);
            this.lblRESULTADO.TabIndex = 7;
            this.lblRESULTADO.Text = "Resultado:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::esdat.Properties.Resources.postfija;
            this.pictureBox1.Location = new System.Drawing.Point(334, 162);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(377, 239);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(360, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "*Es necesario poner un espacio en cada caracter.";
            // 
            // btnEJEMPLO1
            // 
            this.btnEJEMPLO1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEJEMPLO1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEJEMPLO1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEJEMPLO1.Location = new System.Drawing.Point(3, 3);
            this.btnEJEMPLO1.Name = "btnEJEMPLO1";
            this.btnEJEMPLO1.Size = new System.Drawing.Size(121, 35);
            this.btnEJEMPLO1.TabIndex = 10;
            this.btnEJEMPLO1.Text = "Ejemplo 1";
            this.btnEJEMPLO1.UseVisualStyleBackColor = false;
            this.btnEJEMPLO1.Click += new System.EventHandler(this.btnEJEMPLO1_Click);
            // 
            // EJEMPLO2
            // 
            this.EJEMPLO2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EJEMPLO2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EJEMPLO2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EJEMPLO2.Location = new System.Drawing.Point(3, 44);
            this.EJEMPLO2.Name = "EJEMPLO2";
            this.EJEMPLO2.Size = new System.Drawing.Size(121, 32);
            this.EJEMPLO2.TabIndex = 11;
            this.EJEMPLO2.Text = "Ejemplo 2";
            this.EJEMPLO2.UseVisualStyleBackColor = false;
            this.EJEMPLO2.Click += new System.EventHandler(this.EJEMPLO2_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.flowLayoutPanel1.Controls.Add(this.btnEJEMPLO1);
            this.flowLayoutPanel1.Controls.Add(this.EJEMPLO2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(643, 18);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(131, 82);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(479, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 32);
            this.button1.TabIndex = 13;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Expresiones_Postfijas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 423);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblRESULTADO);
            this.Controls.Add(this.btnREINICIAR);
            this.Controls.Add(this.btnPASOAPASO);
            this.Controls.Add(this.btnEVALUAR);
            this.Controls.Add(this.dgvOPERANDOS);
            this.Controls.Add(this.txtEXPRESIONES);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Expresiones_Postfijas";
            this.Text = "Expresiones Postfijas (utilización de pilas)";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOPERANDOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEXPRESIONES;
        private System.Windows.Forms.DataGridView dgvOPERANDOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button btnEVALUAR;
        private System.Windows.Forms.Button btnPASOAPASO;
        private System.Windows.Forms.Button btnREINICIAR;
        private System.Windows.Forms.Label lblRESULTADO;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEJEMPLO1;
        private System.Windows.Forms.Button EJEMPLO2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
    }
}