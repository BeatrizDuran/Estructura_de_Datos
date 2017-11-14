namespace esdat
{
    partial class frmArboles_BD
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
            this.tvBASEDATOS = new System.Windows.Forms.TreeView();
            this.tvPRUEBA = new System.Windows.Forms.TreeView();
            this.tvpruebita = new System.Windows.Forms.TreeView();
            this.tvSHOWTABLES = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tvBASEDATOS
            // 
            this.tvBASEDATOS.Location = new System.Drawing.Point(1, 58);
            this.tvBASEDATOS.Name = "tvBASEDATOS";
            this.tvBASEDATOS.Size = new System.Drawing.Size(254, 329);
            this.tvBASEDATOS.TabIndex = 0;
            // 
            // tvPRUEBA
            // 
            this.tvPRUEBA.Location = new System.Drawing.Point(614, 58);
            this.tvPRUEBA.Name = "tvPRUEBA";
            this.tvPRUEBA.Size = new System.Drawing.Size(156, 329);
            this.tvPRUEBA.TabIndex = 1;
            // 
            // tvpruebita
            // 
            this.tvpruebita.Location = new System.Drawing.Point(261, 58);
            this.tvpruebita.Name = "tvpruebita";
            this.tvpruebita.Size = new System.Drawing.Size(174, 329);
            this.tvpruebita.TabIndex = 2;
            // 
            // tvSHOWTABLES
            // 
            this.tvSHOWTABLES.Location = new System.Drawing.Point(441, 58);
            this.tvSHOWTABLES.Name = "tvSHOWTABLES";
            this.tvSHOWTABLES.Size = new System.Drawing.Size(167, 329);
            this.tvSHOWTABLES.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ejemplo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(290, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 48);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ejemplo de \r\nintegradora";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(450, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Show databases";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(614, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "databases Games";
            // 
            // frmArboles_BD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 390);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tvSHOWTABLES);
            this.Controls.Add(this.tvpruebita);
            this.Controls.Add(this.tvPRUEBA);
            this.Controls.Add(this.tvBASEDATOS);
            this.Name = "frmArboles_BD";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvBASEDATOS;
        private System.Windows.Forms.TreeView tvPRUEBA;
        private System.Windows.Forms.TreeView tvpruebita;
        private System.Windows.Forms.TreeView tvSHOWTABLES;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}