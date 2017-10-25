namespace esdat
{
    partial class Explorador
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
            this.btnCARGARDOCUMENTOS = new System.Windows.Forms.Button();
            this.btnLIMPIAR = new System.Windows.Forms.Button();
            this.tvNODOS = new System.Windows.Forms.TreeView();
            this.btnEXPANDIR = new System.Windows.Forms.Button();
            this.btnCONTRAER = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCARGARDOCUMENTOS
            // 
            this.btnCARGARDOCUMENTOS.Location = new System.Drawing.Point(309, 12);
            this.btnCARGARDOCUMENTOS.Name = "btnCARGARDOCUMENTOS";
            this.btnCARGARDOCUMENTOS.Size = new System.Drawing.Size(184, 40);
            this.btnCARGARDOCUMENTOS.TabIndex = 0;
            this.btnCARGARDOCUMENTOS.Text = "Cargar Documentos";
            this.btnCARGARDOCUMENTOS.UseVisualStyleBackColor = true;
            this.btnCARGARDOCUMENTOS.Click += new System.EventHandler(this.btnCARGARDOCUMENTOS_Click);
            // 
            // btnLIMPIAR
            // 
            this.btnLIMPIAR.Location = new System.Drawing.Point(309, 171);
            this.btnLIMPIAR.Name = "btnLIMPIAR";
            this.btnLIMPIAR.Size = new System.Drawing.Size(184, 44);
            this.btnLIMPIAR.TabIndex = 1;
            this.btnLIMPIAR.Text = "Limpiar";
            this.btnLIMPIAR.UseVisualStyleBackColor = true;
            this.btnLIMPIAR.Click += new System.EventHandler(this.btnLIMPIAR_Click);
            // 
            // tvNODOS
            // 
            this.tvNODOS.Location = new System.Drawing.Point(3, 12);
            this.tvNODOS.Name = "tvNODOS";
            this.tvNODOS.Size = new System.Drawing.Size(273, 350);
            this.tvNODOS.TabIndex = 2;
            // 
            // btnEXPANDIR
            // 
            this.btnEXPANDIR.Location = new System.Drawing.Point(309, 58);
            this.btnEXPANDIR.Name = "btnEXPANDIR";
            this.btnEXPANDIR.Size = new System.Drawing.Size(184, 40);
            this.btnEXPANDIR.TabIndex = 3;
            this.btnEXPANDIR.Text = "Expandir";
            this.btnEXPANDIR.UseVisualStyleBackColor = true;
            this.btnEXPANDIR.Click += new System.EventHandler(this.btnEXPANDIR_Click);
            // 
            // btnCONTRAER
            // 
            this.btnCONTRAER.Location = new System.Drawing.Point(309, 104);
            this.btnCONTRAER.Name = "btnCONTRAER";
            this.btnCONTRAER.Size = new System.Drawing.Size(184, 40);
            this.btnCONTRAER.TabIndex = 4;
            this.btnCONTRAER.Text = "Contraer";
            this.btnCONTRAER.UseVisualStyleBackColor = true;
            this.btnCONTRAER.Click += new System.EventHandler(this.btnCONTRAER_Click);
            // 
            // Explorador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 374);
            this.Controls.Add(this.btnCONTRAER);
            this.Controls.Add(this.btnEXPANDIR);
            this.Controls.Add(this.tvNODOS);
            this.Controls.Add(this.btnLIMPIAR);
            this.Controls.Add(this.btnCARGARDOCUMENTOS);
            this.Name = "Explorador";
            this.Text = "Explorador";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCARGARDOCUMENTOS;
        private System.Windows.Forms.Button btnLIMPIAR;
        private System.Windows.Forms.TreeView tvNODOS;
        private System.Windows.Forms.Button btnEXPANDIR;
        private System.Windows.Forms.Button btnCONTRAER;
    }
}