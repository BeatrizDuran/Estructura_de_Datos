namespace esdat
{
    partial class frmPractica1_2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblELEMENTO = new System.Windows.Forms.Label();
            this.btnCAPTURAR = new System.Windows.Forms.Button();
            this.btnREINICIAR = new System.Windows.Forms.Button();
            this.lblELEMENTO_SELECCIONADO = new System.Windows.Forms.Label();
            this.dgvELEMENTOS = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblVALOR = new System.Windows.Forms.Label();
            this.txtELEMENTO = new System.Windows.Forms.TextBox();
            this.btSalir = new System.Windows.Forms.Button();
            this.txtNUMCOMPLEJO = new System.Windows.Forms.TextBox();
            this.lblNumComplejos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvELEMENTOS)).BeginInit();
            this.SuspendLayout();
            // 
            // lblELEMENTO
            // 
            this.lblELEMENTO.AutoSize = true;
            this.lblELEMENTO.Location = new System.Drawing.Point(12, 19);
            this.lblELEMENTO.Name = "lblELEMENTO";
            this.lblELEMENTO.Size = new System.Drawing.Size(84, 13);
            this.lblELEMENTO.TabIndex = 0;
            this.lblELEMENTO.Text = "Elemento [0,0] =";
            // 
            // btnCAPTURAR
            // 
            this.btnCAPTURAR.Location = new System.Drawing.Point(454, 14);
            this.btnCAPTURAR.Name = "btnCAPTURAR";
            this.btnCAPTURAR.Size = new System.Drawing.Size(107, 23);
            this.btnCAPTURAR.TabIndex = 2;
            this.btnCAPTURAR.Text = "Capturar";
            this.btnCAPTURAR.UseVisualStyleBackColor = true;
            this.btnCAPTURAR.Click += new System.EventHandler(this.btnCAPTURAR_Click);
            // 
            // btnREINICIAR
            // 
            this.btnREINICIAR.Location = new System.Drawing.Point(454, 46);
            this.btnREINICIAR.Name = "btnREINICIAR";
            this.btnREINICIAR.Size = new System.Drawing.Size(107, 23);
            this.btnREINICIAR.TabIndex = 3;
            this.btnREINICIAR.Text = "Limpiar";
            this.btnREINICIAR.UseVisualStyleBackColor = true;
            this.btnREINICIAR.Click += new System.EventHandler(this.btnREINICIAR_Click);
            // 
            // lblELEMENTO_SELECCIONADO
            // 
            this.lblELEMENTO_SELECCIONADO.AutoSize = true;
            this.lblELEMENTO_SELECCIONADO.Location = new System.Drawing.Point(12, 131);
            this.lblELEMENTO_SELECCIONADO.Name = "lblELEMENTO_SELECCIONADO";
            this.lblELEMENTO_SELECCIONADO.Size = new System.Drawing.Size(152, 13);
            this.lblELEMENTO_SELECCIONADO.TabIndex = 4;
            this.lblELEMENTO_SELECCIONADO.Text = "Elemento [0,0] Seleccionado =";
            // 
            // dgvELEMENTOS
            // 
            this.dgvELEMENTOS.AllowUserToAddRows = false;
            this.dgvELEMENTOS.AllowUserToDeleteRows = false;
            this.dgvELEMENTOS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvELEMENTOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvELEMENTOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvELEMENTOS.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvELEMENTOS.Location = new System.Drawing.Point(15, 161);
            this.dgvELEMENTOS.Name = "dgvELEMENTOS";
            this.dgvELEMENTOS.ReadOnly = true;
            this.dgvELEMENTOS.Size = new System.Drawing.Size(546, 150);
            this.dgvELEMENTOS.TabIndex = 5;
            this.dgvELEMENTOS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvELEMENTOS_CellClick);
            // 
            // Column1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "0";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "1";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "2";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // lblVALOR
            // 
            this.lblVALOR.AutoSize = true;
            this.lblVALOR.Location = new System.Drawing.Point(290, 19);
            this.lblVALOR.Name = "lblVALOR";
            this.lblVALOR.Size = new System.Drawing.Size(10, 13);
            this.lblVALOR.TabIndex = 6;
            this.lblVALOR.Text = "-";
            // 
            // txtELEMENTO
            // 
            this.txtELEMENTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtELEMENTO.Location = new System.Drawing.Point(102, 11);
            this.txtELEMENTO.Name = "txtELEMENTO";
            this.txtELEMENTO.Size = new System.Drawing.Size(167, 26);
            this.txtELEMENTO.TabIndex = 7;
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(437, 317);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(124, 41);
            this.btSalir.TabIndex = 8;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // txtNUMCOMPLEJO
            // 
            this.txtNUMCOMPLEJO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNUMCOMPLEJO.Location = new System.Drawing.Point(102, 43);
            this.txtNUMCOMPLEJO.Name = "txtNUMCOMPLEJO";
            this.txtNUMCOMPLEJO.Size = new System.Drawing.Size(167, 26);
            this.txtNUMCOMPLEJO.TabIndex = 9;
            // 
            // lblNumComplejos
            // 
            this.lblNumComplejos.AutoSize = true;
            this.lblNumComplejos.Location = new System.Drawing.Point(290, 56);
            this.lblNumComplejos.Name = "lblNumComplejos";
            this.lblNumComplejos.Size = new System.Drawing.Size(10, 13);
            this.lblNumComplejos.TabIndex = 10;
            this.lblNumComplejos.Text = "-";
            // 
            // Practica1_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 370);
            this.Controls.Add(this.lblNumComplejos);
            this.Controls.Add(this.txtNUMCOMPLEJO);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.txtELEMENTO);
            this.Controls.Add(this.lblVALOR);
            this.Controls.Add(this.dgvELEMENTOS);
            this.Controls.Add(this.lblELEMENTO_SELECCIONADO);
            this.Controls.Add(this.btnREINICIAR);
            this.Controls.Add(this.btnCAPTURAR);
            this.Controls.Add(this.lblELEMENTO);
            this.Name = "Practica1_2";
            this.Text = "Practica1_2";
            this.Load += new System.EventHandler(this.Pu_1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvELEMENTOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblELEMENTO;
        private System.Windows.Forms.Button btnCAPTURAR;
        private System.Windows.Forms.Button btnREINICIAR;
        private System.Windows.Forms.Label lblELEMENTO_SELECCIONADO;
        private System.Windows.Forms.DataGridView dgvELEMENTOS;
        private System.Windows.Forms.Label lblVALOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TextBox txtELEMENTO;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.TextBox txtNUMCOMPLEJO;
        private System.Windows.Forms.Label lblNumComplejos;
    }
}