namespace esdat
{
    partial class Maximo_como_un_divisor
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
            this.txtENTERO1 = new System.Windows.Forms.TextBox();
            this.txtENTERO2 = new System.Windows.Forms.TextBox();
            this.btnCALCULAR = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRESULTADO = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entero 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Entero 2:";
            // 
            // txtENTERO1
            // 
            this.txtENTERO1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtENTERO1.Location = new System.Drawing.Point(83, 12);
            this.txtENTERO1.Name = "txtENTERO1";
            this.txtENTERO1.Size = new System.Drawing.Size(135, 26);
            this.txtENTERO1.TabIndex = 2;
            // 
            // txtENTERO2
            // 
            this.txtENTERO2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtENTERO2.Location = new System.Drawing.Point(83, 60);
            this.txtENTERO2.Name = "txtENTERO2";
            this.txtENTERO2.Size = new System.Drawing.Size(135, 26);
            this.txtENTERO2.TabIndex = 3;
            // 
            // btnCALCULAR
            // 
            this.btnCALCULAR.Location = new System.Drawing.Point(265, 12);
            this.btnCALCULAR.Name = "btnCALCULAR";
            this.btnCALCULAR.Size = new System.Drawing.Size(139, 26);
            this.btnCALCULAR.TabIndex = 4;
            this.btnCALCULAR.Text = "Calcular";
            this.btnCALCULAR.UseVisualStyleBackColor = true;
            this.btnCALCULAR.Click += new System.EventHandler(this.btnCALCULAR_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resultado:";
            // 
            // lblRESULTADO
            // 
            this.lblRESULTADO.AutoSize = true;
            this.lblRESULTADO.Location = new System.Drawing.Point(326, 68);
            this.lblRESULTADO.Name = "lblRESULTADO";
            this.lblRESULTADO.Size = new System.Drawing.Size(19, 13);
            this.lblRESULTADO.TabIndex = 6;
            this.lblRESULTADO.Text = "----";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::esdat.Properties.Resources.MCD;
            this.pictureBox1.Location = new System.Drawing.Point(0, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(444, 243);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Maximo_como_un_divisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 346);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblRESULTADO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCALCULAR);
            this.Controls.Add(this.txtENTERO2);
            this.Controls.Add(this.txtENTERO1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Maximo_como_un_divisor";
            this.Text = "Maximo como un divisor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtENTERO1;
        private System.Windows.Forms.TextBox txtENTERO2;
        private System.Windows.Forms.Button btnCALCULAR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRESULTADO;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}