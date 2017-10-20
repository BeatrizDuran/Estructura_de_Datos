namespace esdat
{
    partial class Principal
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
            this.SuspendLayout();
            // 
            // tvBASEDATOS
            // 
            this.tvBASEDATOS.Location = new System.Drawing.Point(0, 0);
            this.tvBASEDATOS.Name = "tvBASEDATOS";
            this.tvBASEDATOS.Size = new System.Drawing.Size(176, 343);
            this.tvBASEDATOS.TabIndex = 0;
            // 
            // tvPRUEBA
            // 
            this.tvPRUEBA.Location = new System.Drawing.Point(182, 0);
            this.tvPRUEBA.Name = "tvPRUEBA";
            this.tvPRUEBA.Size = new System.Drawing.Size(191, 343);
            this.tvPRUEBA.TabIndex = 1;
            // 
            // tvpruebita
            // 
            this.tvpruebita.Location = new System.Drawing.Point(379, 0);
            this.tvpruebita.Name = "tvpruebita";
            this.tvpruebita.Size = new System.Drawing.Size(197, 131);
            this.tvpruebita.TabIndex = 2;
            // 
            // tvSHOWTABLES
            // 
            this.tvSHOWTABLES.Location = new System.Drawing.Point(379, 147);
            this.tvSHOWTABLES.Name = "tvSHOWTABLES";
            this.tvSHOWTABLES.Size = new System.Drawing.Size(197, 131);
            this.tvSHOWTABLES.TabIndex = 3;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 364);
            this.Controls.Add(this.tvSHOWTABLES);
            this.Controls.Add(this.tvpruebita);
            this.Controls.Add(this.tvPRUEBA);
            this.Controls.Add(this.tvBASEDATOS);
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvBASEDATOS;
        private System.Windows.Forms.TreeView tvPRUEBA;
        private System.Windows.Forms.TreeView tvpruebita;
        private System.Windows.Forms.TreeView tvSHOWTABLES;
    }
}