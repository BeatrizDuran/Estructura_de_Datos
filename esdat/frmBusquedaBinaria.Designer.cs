namespace esdat
{
    partial class Busqueda_binaria
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
            this.dgvBusquedaBinaria = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNUMEROELEMENTOS = new System.Windows.Forms.TextBox();
            this.txtLIMITE = new System.Windows.Forms.TextBox();
            this.txtBUSCAR = new System.Windows.Forms.TextBox();
            this.btnGENERAR = new System.Windows.Forms.Button();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            this.btnLIMPIAR = new System.Windows.Forms.Button();
            this.btnCERRAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusquedaBinaria)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBusquedaBinaria
            // 
            this.dgvBusquedaBinaria.AllowUserToAddRows = false;
            this.dgvBusquedaBinaria.AllowUserToDeleteRows = false;
            this.dgvBusquedaBinaria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBusquedaBinaria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusquedaBinaria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvBusquedaBinaria.Location = new System.Drawing.Point(-1, 2);
            this.dgvBusquedaBinaria.Name = "dgvBusquedaBinaria";
            this.dgvBusquedaBinaria.ReadOnly = true;
            this.dgvBusquedaBinaria.Size = new System.Drawing.Size(240, 359);
            this.dgvBusquedaBinaria.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Elementos";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numeros de elementos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Limite:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(264, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Buscar:";
            // 
            // txtNUMEROELEMENTOS
            // 
            this.txtNUMEROELEMENTOS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNUMEROELEMENTOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNUMEROELEMENTOS.Location = new System.Drawing.Point(268, 44);
            this.txtNUMEROELEMENTOS.Name = "txtNUMEROELEMENTOS";
            this.txtNUMEROELEMENTOS.Size = new System.Drawing.Size(221, 26);
            this.txtNUMEROELEMENTOS.TabIndex = 4;
            // 
            // txtLIMITE
            // 
            this.txtLIMITE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLIMITE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLIMITE.Location = new System.Drawing.Point(268, 96);
            this.txtLIMITE.Name = "txtLIMITE";
            this.txtLIMITE.Size = new System.Drawing.Size(221, 26);
            this.txtLIMITE.TabIndex = 5;
            // 
            // txtBUSCAR
            // 
            this.txtBUSCAR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBUSCAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBUSCAR.Location = new System.Drawing.Point(268, 148);
            this.txtBUSCAR.Name = "txtBUSCAR";
            this.txtBUSCAR.Size = new System.Drawing.Size(221, 26);
            this.txtBUSCAR.TabIndex = 6;
            // 
            // btnGENERAR
            // 
            this.btnGENERAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGENERAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGENERAR.Location = new System.Drawing.Point(268, 189);
            this.btnGENERAR.Name = "btnGENERAR";
            this.btnGENERAR.Size = new System.Drawing.Size(221, 40);
            this.btnGENERAR.TabIndex = 7;
            this.btnGENERAR.Text = "Generar o llenar elementos";
            this.btnGENERAR.UseVisualStyleBackColor = true;
            this.btnGENERAR.Click += new System.EventHandler(this.btnGENERAR_Click);
            // 
            // btnBUSCAR
            // 
            this.btnBUSCAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBUSCAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBUSCAR.Location = new System.Drawing.Point(268, 235);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(221, 38);
            this.btnBUSCAR.TabIndex = 8;
            this.btnBUSCAR.Text = "Buscar";
            this.btnBUSCAR.UseVisualStyleBackColor = true;
            this.btnBUSCAR.Click += new System.EventHandler(this.btnBUSCAR_Click);
            // 
            // btnLIMPIAR
            // 
            this.btnLIMPIAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLIMPIAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLIMPIAR.Location = new System.Drawing.Point(268, 279);
            this.btnLIMPIAR.Name = "btnLIMPIAR";
            this.btnLIMPIAR.Size = new System.Drawing.Size(221, 38);
            this.btnLIMPIAR.TabIndex = 9;
            this.btnLIMPIAR.Text = "Limpiar";
            this.btnLIMPIAR.UseVisualStyleBackColor = true;
            this.btnLIMPIAR.Click += new System.EventHandler(this.btnLIMPIAR_Click);
            // 
            // btnCERRAR
            // 
            this.btnCERRAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCERRAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCERRAR.Location = new System.Drawing.Point(268, 323);
            this.btnCERRAR.Name = "btnCERRAR";
            this.btnCERRAR.Size = new System.Drawing.Size(221, 38);
            this.btnCERRAR.TabIndex = 10;
            this.btnCERRAR.Text = "Cerrar";
            this.btnCERRAR.UseVisualStyleBackColor = true;
            this.btnCERRAR.Click += new System.EventHandler(this.btnBUSCAR_Click);
            // 
            // Busqueda_binaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 368);
            this.Controls.Add(this.btnCERRAR);
            this.Controls.Add(this.btnLIMPIAR);
            this.Controls.Add(this.btnBUSCAR);
            this.Controls.Add(this.btnGENERAR);
            this.Controls.Add(this.txtBUSCAR);
            this.Controls.Add(this.txtLIMITE);
            this.Controls.Add(this.txtNUMEROELEMENTOS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBusquedaBinaria);
            this.Name = "Busqueda_binaria";
            this.Text = "Busqueda_binaria";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusquedaBinaria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBusquedaBinaria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.TextBox txtNUMEROELEMENTOS;
        private System.Windows.Forms.TextBox txtLIMITE;
        private System.Windows.Forms.TextBox txtBUSCAR;
        private System.Windows.Forms.Button btnGENERAR;
        private System.Windows.Forms.Button btnBUSCAR;
        private System.Windows.Forms.Button btnLIMPIAR;
        private System.Windows.Forms.Button btnCERRAR;
    }
}