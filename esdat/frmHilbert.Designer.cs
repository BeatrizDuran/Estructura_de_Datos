namespace esdat
{
    partial class frmHilbert
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
            this.pcBHILBERT = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbVALOR = new System.Windows.Forms.ComboBox();
            this.btnINICIAR = new System.Windows.Forms.Button();
            this.ckBREFRESCAR = new System.Windows.Forms.CheckBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcBHILBERT)).BeginInit();
            this.SuspendLayout();
            // 
            // pcBHILBERT
            // 
            this.pcBHILBERT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcBHILBERT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcBHILBERT.Location = new System.Drawing.Point(0, 0);
            this.pcBHILBERT.Name = "pcBHILBERT";
            this.pcBHILBERT.Size = new System.Drawing.Size(712, 474);
            this.pcBHILBERT.TabIndex = 0;
            this.pcBHILBERT.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor: ";
            // 
            // cmbVALOR
            // 
            this.cmbVALOR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVALOR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbVALOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVALOR.FormattingEnabled = true;
            this.cmbVALOR.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cmbVALOR.Location = new System.Drawing.Point(16, 41);
            this.cmbVALOR.Name = "cmbVALOR";
            this.cmbVALOR.Size = new System.Drawing.Size(102, 28);
            this.cmbVALOR.TabIndex = 2;
            // 
            // btnINICIAR
            // 
            this.btnINICIAR.BackColor = System.Drawing.Color.LightGreen;
            this.btnINICIAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnINICIAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnINICIAR.Location = new System.Drawing.Point(16, 75);
            this.btnINICIAR.Name = "btnINICIAR";
            this.btnINICIAR.Size = new System.Drawing.Size(102, 28);
            this.btnINICIAR.TabIndex = 3;
            this.btnINICIAR.Text = "Iniciar";
            this.btnINICIAR.UseVisualStyleBackColor = false;
            this.btnINICIAR.Click += new System.EventHandler(this.btnINICIAR_Click);
            // 
            // ckBREFRESCAR
            // 
            this.ckBREFRESCAR.AutoSize = true;
            this.ckBREFRESCAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckBREFRESCAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckBREFRESCAR.Location = new System.Drawing.Point(16, 177);
            this.ckBREFRESCAR.Name = "ckBREFRESCAR";
            this.ckBREFRESCAR.Size = new System.Drawing.Size(95, 24);
            this.ckBREFRESCAR.TabIndex = 4;
            this.ckBREFRESCAR.Text = "Refrescar";
            this.ckBREFRESCAR.UseVisualStyleBackColor = true;
            // 
            // btnGUARDAR
            // 
            this.btnGUARDAR.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGUARDAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGUARDAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGUARDAR.Location = new System.Drawing.Point(16, 109);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(102, 28);
            this.btnGUARDAR.TabIndex = 5;
            this.btnGUARDAR.Text = "Guardar";
            this.btnGUARDAR.UseVisualStyleBackColor = false;
            this.btnGUARDAR.Click += new System.EventHandler(this.btnGUARDAR_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(16, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmHilbert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 474);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGUARDAR);
            this.Controls.Add(this.ckBREFRESCAR);
            this.Controls.Add(this.btnINICIAR);
            this.Controls.Add(this.cmbVALOR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcBHILBERT);
            this.Name = "frmHilbert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hilbert";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Hilbert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcBHILBERT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcBHILBERT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbVALOR;
        private System.Windows.Forms.Button btnINICIAR;
        private System.Windows.Forms.CheckBox ckBREFRESCAR;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.Button button1;
    }
}