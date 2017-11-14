namespace esdat
{
    partial class frmArboles_recorrido
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
            this.btnCONTRAER = new System.Windows.Forms.Button();
            this.btnEXPANDIR = new System.Windows.Forms.Button();
            this.tvNODOS = new System.Windows.Forms.TreeView();
            this.btnRECORRIDO = new System.Windows.Forms.Button();
            this.btnPODAR = new System.Windows.Forms.Button();
            this.txtRAIZ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHIJO = new System.Windows.Forms.TextBox();
            this.cmbPADRE = new System.Windows.Forms.ComboBox();
            this.btnAGREGARRAIZ = new System.Windows.Forms.Button();
            this.btnAGREGARHIJO = new System.Windows.Forms.Button();
            this.btnPodarTodo = new System.Windows.Forms.Button();
            this.btnSALIR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCONTRAER
            // 
            this.btnCONTRAER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCONTRAER.Location = new System.Drawing.Point(424, 210);
            this.btnCONTRAER.Name = "btnCONTRAER";
            this.btnCONTRAER.Size = new System.Drawing.Size(184, 33);
            this.btnCONTRAER.TabIndex = 9;
            this.btnCONTRAER.Text = "Contraer";
            this.btnCONTRAER.UseVisualStyleBackColor = true;
            this.btnCONTRAER.Click += new System.EventHandler(this.btnCONTRAER_Click);
            // 
            // btnEXPANDIR
            // 
            this.btnEXPANDIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEXPANDIR.Location = new System.Drawing.Point(424, 169);
            this.btnEXPANDIR.Name = "btnEXPANDIR";
            this.btnEXPANDIR.Size = new System.Drawing.Size(184, 35);
            this.btnEXPANDIR.TabIndex = 8;
            this.btnEXPANDIR.Text = "Expandir";
            this.btnEXPANDIR.UseVisualStyleBackColor = true;
            this.btnEXPANDIR.Click += new System.EventHandler(this.btnEXPANDIR_Click);
            // 
            // tvNODOS
            // 
            this.tvNODOS.Location = new System.Drawing.Point(3, 3);
            this.tvNODOS.Name = "tvNODOS";
            this.tvNODOS.Size = new System.Drawing.Size(273, 350);
            this.tvNODOS.TabIndex = 7;
            // 
            // btnRECORRIDO
            // 
            this.btnRECORRIDO.BackColor = System.Drawing.Color.LimeGreen;
            this.btnRECORRIDO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRECORRIDO.Location = new System.Drawing.Point(424, 249);
            this.btnRECORRIDO.Name = "btnRECORRIDO";
            this.btnRECORRIDO.Size = new System.Drawing.Size(184, 32);
            this.btnRECORRIDO.TabIndex = 6;
            this.btnRECORRIDO.Text = "Recorrido";
            this.btnRECORRIDO.UseVisualStyleBackColor = false;
            this.btnRECORRIDO.Click += new System.EventHandler(this.btnRECORRIDO_Click);
            // 
            // btnPODAR
            // 
            this.btnPODAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPODAR.Location = new System.Drawing.Point(504, 54);
            this.btnPODAR.Name = "btnPODAR";
            this.btnPODAR.Size = new System.Drawing.Size(104, 27);
            this.btnPODAR.TabIndex = 5;
            this.btnPODAR.Text = "Podar";
            this.btnPODAR.UseVisualStyleBackColor = true;
            this.btnPODAR.Click += new System.EventHandler(this.btnPODAR_Click);
            // 
            // txtRAIZ
            // 
            this.txtRAIZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRAIZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRAIZ.Location = new System.Drawing.Point(333, 13);
            this.txtRAIZ.Name = "txtRAIZ";
            this.txtRAIZ.Size = new System.Drawing.Size(165, 26);
            this.txtRAIZ.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Raíz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(282, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Padre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(282, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Hijo:";
            // 
            // txtHIJO
            // 
            this.txtHIJO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHIJO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHIJO.Location = new System.Drawing.Point(333, 96);
            this.txtHIJO.Name = "txtHIJO";
            this.txtHIJO.Size = new System.Drawing.Size(165, 26);
            this.txtHIJO.TabIndex = 15;
            // 
            // cmbPADRE
            // 
            this.cmbPADRE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPADRE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPADRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPADRE.FormattingEnabled = true;
            this.cmbPADRE.Items.AddRange(new object[] {
            "Nodo0"});
            this.cmbPADRE.Location = new System.Drawing.Point(333, 53);
            this.cmbPADRE.Name = "cmbPADRE";
            this.cmbPADRE.Size = new System.Drawing.Size(165, 28);
            this.cmbPADRE.TabIndex = 16;
            // 
            // btnAGREGARRAIZ
            // 
            this.btnAGREGARRAIZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAGREGARRAIZ.Location = new System.Drawing.Point(504, 12);
            this.btnAGREGARRAIZ.Name = "btnAGREGARRAIZ";
            this.btnAGREGARRAIZ.Size = new System.Drawing.Size(104, 27);
            this.btnAGREGARRAIZ.TabIndex = 17;
            this.btnAGREGARRAIZ.Text = "Agregar";
            this.btnAGREGARRAIZ.UseVisualStyleBackColor = true;
            this.btnAGREGARRAIZ.Click += new System.EventHandler(this.btnAGREGARRAIZ_Click);
            // 
            // btnAGREGARHIJO
            // 
            this.btnAGREGARHIJO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAGREGARHIJO.Location = new System.Drawing.Point(504, 95);
            this.btnAGREGARHIJO.Name = "btnAGREGARHIJO";
            this.btnAGREGARHIJO.Size = new System.Drawing.Size(104, 27);
            this.btnAGREGARHIJO.TabIndex = 18;
            this.btnAGREGARHIJO.Text = "Agregar";
            this.btnAGREGARHIJO.UseVisualStyleBackColor = true;
            this.btnAGREGARHIJO.Click += new System.EventHandler(this.btnAGREGARHIJO_Click);
            // 
            // btnPodarTodo
            // 
            this.btnPodarTodo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPodarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPodarTodo.Location = new System.Drawing.Point(424, 287);
            this.btnPodarTodo.Name = "btnPodarTodo";
            this.btnPodarTodo.Size = new System.Drawing.Size(184, 32);
            this.btnPodarTodo.TabIndex = 19;
            this.btnPodarTodo.Text = "Podar todo";
            this.btnPodarTodo.UseVisualStyleBackColor = false;
            this.btnPodarTodo.Click += new System.EventHandler(this.btnPodarTodo_Click);
            // 
            // btnSALIR
            // 
            this.btnSALIR.BackColor = System.Drawing.Color.LightCoral;
            this.btnSALIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSALIR.Location = new System.Drawing.Point(423, 325);
            this.btnSALIR.Name = "btnSALIR";
            this.btnSALIR.Size = new System.Drawing.Size(184, 33);
            this.btnSALIR.TabIndex = 20;
            this.btnSALIR.Text = "Cerrar";
            this.btnSALIR.UseVisualStyleBackColor = false;
            this.btnSALIR.Click += new System.EventHandler(this.btnSALIR_Click);
            // 
            // frmArboles_recorrido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 366);
            this.Controls.Add(this.btnSALIR);
            this.Controls.Add(this.btnPodarTodo);
            this.Controls.Add(this.btnAGREGARHIJO);
            this.Controls.Add(this.btnAGREGARRAIZ);
            this.Controls.Add(this.cmbPADRE);
            this.Controls.Add(this.txtHIJO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRAIZ);
            this.Controls.Add(this.btnCONTRAER);
            this.Controls.Add(this.btnEXPANDIR);
            this.Controls.Add(this.tvNODOS);
            this.Controls.Add(this.btnRECORRIDO);
            this.Controls.Add(this.btnPODAR);
            this.Name = "frmArboles_recorrido";
            this.Text = "arboles_recorrido";
            this.Load += new System.EventHandler(this.arboles_recorrido_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCONTRAER;
        private System.Windows.Forms.Button btnEXPANDIR;
        private System.Windows.Forms.TreeView tvNODOS;
        private System.Windows.Forms.Button btnRECORRIDO;
        private System.Windows.Forms.Button btnPODAR;
        private System.Windows.Forms.TextBox txtRAIZ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHIJO;
        private System.Windows.Forms.ComboBox cmbPADRE;
        private System.Windows.Forms.Button btnAGREGARRAIZ;
        private System.Windows.Forms.Button btnAGREGARHIJO;
        private System.Windows.Forms.Button btnPodarTodo;
        private System.Windows.Forms.Button btnSALIR;
    }
}