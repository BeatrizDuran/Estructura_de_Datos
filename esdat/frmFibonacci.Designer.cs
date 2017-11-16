namespace esdat
{
    partial class frmFibonacci
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
            this.btnGENERAR = new System.Windows.Forms.Button();
            this.dgvFIBONACCI = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLIMITE = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSALIR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFIBONACCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGENERAR
            // 
            this.btnGENERAR.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGENERAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGENERAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGENERAR.Location = new System.Drawing.Point(250, 23);
            this.btnGENERAR.Name = "btnGENERAR";
            this.btnGENERAR.Size = new System.Drawing.Size(121, 26);
            this.btnGENERAR.TabIndex = 0;
            this.btnGENERAR.Text = "Generar";
            this.btnGENERAR.UseVisualStyleBackColor = false;
            this.btnGENERAR.Click += new System.EventHandler(this.btnGENERAR_Click);
            // 
            // dgvFIBONACCI
            // 
            this.dgvFIBONACCI.AllowUserToAddRows = false;
            this.dgvFIBONACCI.AllowUserToDeleteRows = false;
            this.dgvFIBONACCI.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFIBONACCI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFIBONACCI.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvFIBONACCI.Location = new System.Drawing.Point(22, 55);
            this.dgvFIBONACCI.Name = "dgvFIBONACCI";
            this.dgvFIBONACCI.ReadOnly = true;
            this.dgvFIBONACCI.Size = new System.Drawing.Size(350, 331);
            this.dgvFIBONACCI.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Fibonacci";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Limite:";
            // 
            // txtLIMITE
            // 
            this.txtLIMITE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLIMITE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLIMITE.Location = new System.Drawing.Point(76, 23);
            this.txtLIMITE.Name = "txtLIMITE";
            this.txtLIMITE.Size = new System.Drawing.Size(168, 26);
            this.txtLIMITE.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::esdat.Properties.Resources.dd_2;
            this.pictureBox1.Location = new System.Drawing.Point(397, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 180);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(393, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 80);
            this.label2.TabIndex = 5;
            this.label2.Text = "La sucesión comienza con los números 0 y 1,\r\ny a partir de estos, «cada término e" +
    "s la suma \r\nde los dos anteriores»,  es   la   relación    de\r\nrecurrencia que l" +
    "a define.";
            // 
            // btnSALIR
            // 
            this.btnSALIR.BackColor = System.Drawing.Color.IndianRed;
            this.btnSALIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSALIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSALIR.Location = new System.Drawing.Point(579, 350);
            this.btnSALIR.Name = "btnSALIR";
            this.btnSALIR.Size = new System.Drawing.Size(141, 36);
            this.btnSALIR.TabIndex = 6;
            this.btnSALIR.Text = "Cerrar";
            this.btnSALIR.UseVisualStyleBackColor = false;
            this.btnSALIR.Click += new System.EventHandler(this.btnSALIR_Click);
            // 
            // frmFibonacci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 410);
            this.Controls.Add(this.btnSALIR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtLIMITE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFIBONACCI);
            this.Controls.Add(this.btnGENERAR);
            this.Name = "frmFibonacci";
            this.Text = "Fibonacci";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFIBONACCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGENERAR;
        private System.Windows.Forms.DataGridView dgvFIBONACCI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLIMITE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSALIR;
    }
}