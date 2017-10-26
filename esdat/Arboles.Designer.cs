namespace esdat
{
    partial class Arboles
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Table1", 2, 3);
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Table2", 2, 3);
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Punto_venta", 0, -2, new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Table1", 2, 3);
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Table2", 2, 3);
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Consultorio", 0, -2, new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Table1", 2, 3);
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Table2", 2, 3);
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Control_escolar", 0, -2, new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Arboles));
            this.tvBASEDATOS = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // tvBASEDATOS
            // 
            this.tvBASEDATOS.ImageIndex = 0;
            this.tvBASEDATOS.ImageList = this.imageList1;
            this.tvBASEDATOS.Location = new System.Drawing.Point(3, 4);
            this.tvBASEDATOS.Name = "tvBASEDATOS";
            treeNode10.ImageIndex = 2;
            treeNode10.Name = "Node1";
            treeNode10.SelectedImageIndex = 3;
            treeNode10.Text = "Table1";
            treeNode11.ImageIndex = 2;
            treeNode11.Name = "Node2";
            treeNode11.SelectedImageIndex = 3;
            treeNode11.Text = "Table2";
            treeNode12.ImageIndex = 0;
            treeNode12.Name = "Node1";
            treeNode12.SelectedImageIndex = -2;
            treeNode12.Text = "Punto_venta";
            treeNode13.ImageIndex = 2;
            treeNode13.Name = "Node4";
            treeNode13.SelectedImageIndex = 3;
            treeNode13.Text = "Table1";
            treeNode14.ImageIndex = 2;
            treeNode14.Name = "Node5";
            treeNode14.SelectedImageIndex = 3;
            treeNode14.Text = "Table2";
            treeNode15.ImageIndex = 0;
            treeNode15.Name = "Node3";
            treeNode15.SelectedImageIndex = -2;
            treeNode15.Text = "Consultorio";
            treeNode16.ImageIndex = 2;
            treeNode16.Name = "Node7";
            treeNode16.SelectedImageIndex = 3;
            treeNode16.Text = "Table1";
            treeNode17.ImageIndex = 2;
            treeNode17.Name = "Node8";
            treeNode17.SelectedImageIndex = 3;
            treeNode17.Text = "Table2";
            treeNode18.ImageIndex = 0;
            treeNode18.Name = "Node6";
            treeNode18.SelectedImageIndex = -2;
            treeNode18.Text = "Control_escolar";
            this.tvBASEDATOS.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode15,
            treeNode18});
            this.tvBASEDATOS.SelectedImageIndex = 0;
            this.tvBASEDATOS.Size = new System.Drawing.Size(165, 317);
            this.tvBASEDATOS.TabIndex = 1;
            this.tvBASEDATOS.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvBASEDATOS_AfterSelect);
            this.tvBASEDATOS.Click += new System.EventHandler(this.tvBASEDATOS_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "if_Streamline-77_185097.png");
            this.imageList1.Images.SetKeyName(1, "if_database_298757.png");
            this.imageList1.Images.SetKeyName(2, "if_table_64790.png");
            this.imageList1.Images.SetKeyName(3, "if_table_1608863.png");
            // 
            // Arboles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 325);
            this.Controls.Add(this.tvBASEDATOS);
            this.Name = "Arboles";
            this.Text = "   ";
            this.Load += new System.EventHandler(this.Arboles_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvBASEDATOS;
        private System.Windows.Forms.ImageList imageList1;
    }
}