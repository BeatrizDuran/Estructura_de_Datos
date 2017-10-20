namespace esdat
{
    partial class Transpuesta
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
            this.dgvM = new System.Windows.Forms.DataGridView();
            this.dgvMT = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTRANSPUESTA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMT)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvM
            // 
            this.dgvM.AllowUserToAddRows = false;
            this.dgvM.AllowUserToDeleteRows = false;
            this.dgvM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvM.Location = new System.Drawing.Point(1, 37);
            this.dgvM.Name = "dgvM";
            this.dgvM.Size = new System.Drawing.Size(409, 134);
            this.dgvM.TabIndex = 0;
            // 
            // dgvMT
            // 
            this.dgvMT.AllowUserToAddRows = false;
            this.dgvMT.AllowUserToDeleteRows = false;
            this.dgvMT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMT.Location = new System.Drawing.Point(1, 217);
            this.dgvMT.Name = "dgvMT";
            this.dgvMT.Size = new System.Drawing.Size(409, 134);
            this.dgvMT.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "M=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-2, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mᵀ=";
            // 
            // btnTRANSPUESTA
            // 
            this.btnTRANSPUESTA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTRANSPUESTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTRANSPUESTA.Location = new System.Drawing.Point(289, 176);
            this.btnTRANSPUESTA.Name = "btnTRANSPUESTA";
            this.btnTRANSPUESTA.Size = new System.Drawing.Size(121, 35);
            this.btnTRANSPUESTA.TabIndex = 4;
            this.btnTRANSPUESTA.Text = "Transpuestas";
            this.btnTRANSPUESTA.UseVisualStyleBackColor = true;
            this.btnTRANSPUESTA.Click += new System.EventHandler(this.btnTRANSPUESTA_Click);
            // 
            // Transpuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 354);
            this.Controls.Add(this.btnTRANSPUESTA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMT);
            this.Controls.Add(this.dgvM);
            this.Name = "Transpuesta";
            this.Text = "Transpuesta";
            this.Load += new System.EventHandler(this.Transpuesta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvM;
        private System.Windows.Forms.DataGridView dgvMT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTRANSPUESTA;
    }
}