namespace esdat
{
    partial class frmPilas
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
            this.dgvPILA = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPUSH = new System.Windows.Forms.Button();
            this.btnPOP = new System.Windows.Forms.Button();
            this.btnPEEK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtELEMENTO = new System.Windows.Forms.TextBox();
            this.btnCLEAR = new System.Windows.Forms.Button();
            this.btnCONTAINS = new System.Windows.Forms.Button();
            this.btnELEMENT_A = new System.Windows.Forms.Button();
            this.btnREVERSA = new System.Windows.Forms.Button();
            this.lblNUMEROELEMENTO = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPILA)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPILA
            // 
            this.dgvPILA.AllowUserToAddRows = false;
            this.dgvPILA.AllowUserToDeleteRows = false;
            this.dgvPILA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPILA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPILA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvPILA.Location = new System.Drawing.Point(67, 12);
            this.dgvPILA.Name = "dgvPILA";
            this.dgvPILA.ReadOnly = true;
            this.dgvPILA.Size = new System.Drawing.Size(214, 420);
            this.dgvPILA.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Pila";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // btnPUSH
            // 
            this.btnPUSH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPUSH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPUSH.Location = new System.Drawing.Point(302, 90);
            this.btnPUSH.Name = "btnPUSH";
            this.btnPUSH.Size = new System.Drawing.Size(248, 35);
            this.btnPUSH.TabIndex = 1;
            this.btnPUSH.Text = "Push()";
            this.btnPUSH.UseVisualStyleBackColor = true;
            this.btnPUSH.Click += new System.EventHandler(this.btnPUSH_Click);
            // 
            // btnPOP
            // 
            this.btnPOP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPOP.Location = new System.Drawing.Point(302, 131);
            this.btnPOP.Name = "btnPOP";
            this.btnPOP.Size = new System.Drawing.Size(248, 35);
            this.btnPOP.TabIndex = 2;
            this.btnPOP.Text = "Pop()";
            this.btnPOP.UseVisualStyleBackColor = true;
            this.btnPOP.Click += new System.EventHandler(this.btnPOP_Click);
            // 
            // btnPEEK
            // 
            this.btnPEEK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPEEK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPEEK.Location = new System.Drawing.Point(302, 172);
            this.btnPEEK.Name = "btnPEEK";
            this.btnPEEK.Size = new System.Drawing.Size(248, 35);
            this.btnPEEK.TabIndex = 3;
            this.btnPEEK.Text = "Peek()";
            this.btnPEEK.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Elemento:";
            // 
            // txtELEMENTO
            // 
            this.txtELEMENTO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtELEMENTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtELEMENTO.Location = new System.Drawing.Point(385, 13);
            this.txtELEMENTO.Name = "txtELEMENTO";
            this.txtELEMENTO.Size = new System.Drawing.Size(165, 26);
            this.txtELEMENTO.TabIndex = 5;
            this.txtELEMENTO.TextChanged += new System.EventHandler(this.txtELEMENTO_TextChanged);
            // 
            // btnCLEAR
            // 
            this.btnCLEAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCLEAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCLEAR.Location = new System.Drawing.Point(302, 213);
            this.btnCLEAR.Name = "btnCLEAR";
            this.btnCLEAR.Size = new System.Drawing.Size(248, 35);
            this.btnCLEAR.TabIndex = 6;
            this.btnCLEAR.Text = "Clear()";
            this.btnCLEAR.UseVisualStyleBackColor = true;
            this.btnCLEAR.Click += new System.EventHandler(this.btnCLEAR_Click);
            // 
            // btnCONTAINS
            // 
            this.btnCONTAINS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCONTAINS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCONTAINS.Location = new System.Drawing.Point(302, 254);
            this.btnCONTAINS.Name = "btnCONTAINS";
            this.btnCONTAINS.Size = new System.Drawing.Size(248, 35);
            this.btnCONTAINS.TabIndex = 7;
            this.btnCONTAINS.Text = "Contains()";
            this.btnCONTAINS.UseVisualStyleBackColor = true;
            // 
            // btnELEMENT_A
            // 
            this.btnELEMENT_A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnELEMENT_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnELEMENT_A.Location = new System.Drawing.Point(302, 295);
            this.btnELEMENT_A.Name = "btnELEMENT_A";
            this.btnELEMENT_A.Size = new System.Drawing.Size(248, 35);
            this.btnELEMENT_A.TabIndex = 8;
            this.btnELEMENT_A.Text = "ElementA()";
            this.btnELEMENT_A.UseVisualStyleBackColor = true;
            // 
            // btnREVERSA
            // 
            this.btnREVERSA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnREVERSA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnREVERSA.Location = new System.Drawing.Point(302, 336);
            this.btnREVERSA.Name = "btnREVERSA";
            this.btnREVERSA.Size = new System.Drawing.Size(248, 35);
            this.btnREVERSA.TabIndex = 9;
            this.btnREVERSA.Text = "Reverse()";
            this.btnREVERSA.UseVisualStyleBackColor = true;
            this.btnREVERSA.Click += new System.EventHandler(this.btnREVERSA_Click);
            // 
            // lblNUMEROELEMENTO
            // 
            this.lblNUMEROELEMENTO.AutoSize = true;
            this.lblNUMEROELEMENTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNUMEROELEMENTO.Location = new System.Drawing.Point(298, 57);
            this.lblNUMEROELEMENTO.Name = "lblNUMEROELEMENTO";
            this.lblNUMEROELEMENTO.Size = new System.Drawing.Size(161, 20);
            this.lblNUMEROELEMENTO.TabIndex = 10;
            this.lblNUMEROELEMENTO.Text = "Número de elemento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tope->";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(302, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 35);
            this.button1.TabIndex = 12;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPilas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 446);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNUMEROELEMENTO);
            this.Controls.Add(this.btnREVERSA);
            this.Controls.Add(this.btnELEMENT_A);
            this.Controls.Add(this.btnCONTAINS);
            this.Controls.Add(this.btnCLEAR);
            this.Controls.Add(this.txtELEMENTO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPEEK);
            this.Controls.Add(this.btnPOP);
            this.Controls.Add(this.btnPUSH);
            this.Controls.Add(this.dgvPILA);
            this.Name = "frmPilas";
            this.Text = "Pilas";
            this.Load += new System.EventHandler(this.Pilas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPILA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPILA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button btnPUSH;
        private System.Windows.Forms.Button btnPOP;
        private System.Windows.Forms.Button btnPEEK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtELEMENTO;
        private System.Windows.Forms.Button btnCLEAR;
        private System.Windows.Forms.Button btnCONTAINS;
        private System.Windows.Forms.Button btnELEMENT_A;
        private System.Windows.Forms.Button btnREVERSA;
        private System.Windows.Forms.Label lblNUMEROELEMENTO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}