namespace esdat
{
    partial class frmMenuTranspuestas
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnGENERAR = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRENGLONES = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCOLUMNAS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(28, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 40);
            this.button1.TabIndex = 13;
            this.button1.Text = "Volver al menu";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnGENERAR
            // 
            this.btnGENERAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGENERAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGENERAR.Location = new System.Drawing.Point(28, 121);
            this.btnGENERAR.Name = "btnGENERAR";
            this.btnGENERAR.Size = new System.Drawing.Size(233, 39);
            this.btnGENERAR.TabIndex = 12;
            this.btnGENERAR.Text = "Generar";
            this.btnGENERAR.UseVisualStyleBackColor = true;
            this.btnGENERAR.Click += new System.EventHandler(this.btnGENERAR_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Favor de ingresar los valores";
            // 
            // txtRENGLONES
            // 
            this.txtRENGLONES.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRENGLONES.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRENGLONES.Location = new System.Drawing.Point(114, 73);
            this.txtRENGLONES.Name = "txtRENGLONES";
            this.txtRENGLONES.Size = new System.Drawing.Size(147, 26);
            this.txtRENGLONES.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Renglones:";
            // 
            // txtCOLUMNAS
            // 
            this.txtCOLUMNAS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCOLUMNAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCOLUMNAS.Location = new System.Drawing.Point(114, 41);
            this.txtCOLUMNAS.Name = "txtCOLUMNAS";
            this.txtCOLUMNAS.Size = new System.Drawing.Size(147, 26);
            this.txtCOLUMNAS.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Columnas:";
            // 
            // frmMenuTranspuestas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 225);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGENERAR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRENGLONES);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCOLUMNAS);
            this.Controls.Add(this.label1);
            this.Name = "frmMenuTranspuestas";
            this.Text = "Menu transpuesta";
            this.Load += new System.EventHandler(this.frmMenuTranspuestas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGENERAR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRENGLONES;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCOLUMNAS;
        private System.Windows.Forms.Label label1;
    }
}