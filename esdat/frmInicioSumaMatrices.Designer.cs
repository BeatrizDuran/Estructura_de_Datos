namespace esdat
{
    partial class Suma_de_matrices
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
            this.txtCOLUMNAS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRENGLONES = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGENERAR = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Columnas:";
            // 
            // txtCOLUMNAS
            // 
            this.txtCOLUMNAS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCOLUMNAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCOLUMNAS.Location = new System.Drawing.Point(128, 47);
            this.txtCOLUMNAS.Name = "txtCOLUMNAS";
            this.txtCOLUMNAS.Size = new System.Drawing.Size(147, 26);
            this.txtCOLUMNAS.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Renglones:";
            // 
            // txtRENGLONES
            // 
            this.txtRENGLONES.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRENGLONES.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRENGLONES.Location = new System.Drawing.Point(128, 79);
            this.txtRENGLONES.Name = "txtRENGLONES";
            this.txtRENGLONES.Size = new System.Drawing.Size(147, 26);
            this.txtRENGLONES.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Favor de ingresar los valores";
            // 
            // btnGENERAR
            // 
            this.btnGENERAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGENERAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGENERAR.Location = new System.Drawing.Point(42, 127);
            this.btnGENERAR.Name = "btnGENERAR";
            this.btnGENERAR.Size = new System.Drawing.Size(233, 39);
            this.btnGENERAR.TabIndex = 5;
            this.btnGENERAR.Text = "Generar";
            this.btnGENERAR.UseVisualStyleBackColor = true;
            this.btnGENERAR.Click += new System.EventHandler(this.btnGENERAR_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(42, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Volver al menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Suma_de_matrices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 240);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGENERAR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRENGLONES);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCOLUMNAS);
            this.Controls.Add(this.label1);
            this.Name = "Suma_de_matrices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de la suma de matrices";
            this.Load += new System.EventHandler(this.Suma_de_matrices_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCOLUMNAS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRENGLONES;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGENERAR;
        private System.Windows.Forms.Button button1;
    }
}