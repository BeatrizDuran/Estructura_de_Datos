namespace esdat
{
    partial class frmArbolesImagenes
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Table1", 2, 3);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Table2", 2, 3);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Punto_venta", 0, -2, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Table1", 2, 3);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Table2", 2, 3);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Consultorio", 0, -2, new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Table1", 2, 3);
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Table2", 2, 3);
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Control_escolar", 0, -2, new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArbolesImagenes));
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
            treeNode1.ImageIndex = 2;
            treeNode1.Name = "Node1";
            treeNode1.SelectedImageIndex = 3;
            treeNode1.Text = "Table1";
            treeNode2.ImageIndex = 2;
            treeNode2.Name = "Node2";
            treeNode2.SelectedImageIndex = 3;
            treeNode2.Text = "Table2";
            treeNode3.ImageIndex = 0;
            treeNode3.Name = "Node1";
            treeNode3.SelectedImageIndex = -2;
            treeNode3.Text = "Punto_venta";
            treeNode4.ImageIndex = 2;
            treeNode4.Name = "Node4";
            treeNode4.SelectedImageIndex = 3;
            treeNode4.Text = "Table1";
            treeNode5.ImageIndex = 2;
            treeNode5.Name = "Node5";
            treeNode5.SelectedImageIndex = 3;
            treeNode5.Text = "Table2";
            treeNode6.ImageIndex = 0;
            treeNode6.Name = "Node3";
            treeNode6.SelectedImageIndex = -2;
            treeNode6.Text = "Consultorio";
            treeNode7.ImageIndex = 2;
            treeNode7.Name = "Node7";
            treeNode7.SelectedImageIndex = 3;
            treeNode7.Text = "Table1";
            treeNode8.ImageIndex = 2;
            treeNode8.Name = "Node8";
            treeNode8.SelectedImageIndex = 3;
            treeNode8.Text = "Table2";
            treeNode9.ImageIndex = 0;
            treeNode9.Name = "Node6";
            treeNode9.SelectedImageIndex = -2;
            treeNode9.Text = "Control_escolar";
            this.tvBASEDATOS.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6,
            treeNode9});
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
            // frmArbolesImagenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 325);
            this.Controls.Add(this.tvBASEDATOS);
            this.Name = "frmArbolesImagenes";
            this.Text = "   ";
            this.Load += new System.EventHandler(this.Arboles_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvBASEDATOS;
        private System.Windows.Forms.ImageList imageList1;
    }
}