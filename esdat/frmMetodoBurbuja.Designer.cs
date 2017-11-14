namespace esdat
{
    partial class frmMetodoBurbuja
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvORIGINAL = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvBURBUJA = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvINSERT = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvSHELL = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvQUICKSORT = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLI = new System.Windows.Forms.TextBox();
            this.txtLS = new System.Windows.Forms.TextBox();
            this.btnGENERAR = new System.Windows.Forms.Button();
            this.btnCALCULAR = new System.Windows.Forms.Button();
            this.lblITERACIONES1 = new System.Windows.Forms.Label();
            this.lblITERACIONES2 = new System.Windows.Forms.Label();
            this.lblITERACIONES3 = new System.Windows.Forms.Label();
            this.lblITERACIONES4 = new System.Windows.Forms.Label();
            this.lblIT1 = new System.Windows.Forms.Label();
            this.lblIT2 = new System.Windows.Forms.Label();
            this.lblIT3 = new System.Windows.Forms.Label();
            this.lblIT4 = new System.Windows.Forms.Label();
            this.btnLIMPIAR = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvORIGINAL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBURBUJA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvINSERT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSHELL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQUICKSORT)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // dgvORIGINAL
            // 
            this.dgvORIGINAL.AllowUserToAddRows = false;
            this.dgvORIGINAL.AllowUserToDeleteRows = false;
            this.dgvORIGINAL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvORIGINAL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvORIGINAL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvORIGINAL.Location = new System.Drawing.Point(16, 32);
            this.dgvORIGINAL.Name = "dgvORIGINAL";
            this.dgvORIGINAL.ReadOnly = true;
            this.dgvORIGINAL.Size = new System.Drawing.Size(170, 377);
            this.dgvORIGINAL.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Original";
            // 
            // dgvBURBUJA
            // 
            this.dgvBURBUJA.AllowUserToAddRows = false;
            this.dgvBURBUJA.AllowUserToDeleteRows = false;
            this.dgvBURBUJA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBURBUJA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBURBUJA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2});
            this.dgvBURBUJA.Location = new System.Drawing.Point(192, 32);
            this.dgvBURBUJA.Name = "dgvBURBUJA";
            this.dgvBURBUJA.ReadOnly = true;
            this.dgvBURBUJA.Size = new System.Drawing.Size(173, 377);
            this.dgvBURBUJA.TabIndex = 3;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(241, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Burbuja";
            // 
            // dgvINSERT
            // 
            this.dgvINSERT.AllowUserToAddRows = false;
            this.dgvINSERT.AllowUserToDeleteRows = false;
            this.dgvINSERT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvINSERT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvINSERT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3});
            this.dgvINSERT.Location = new System.Drawing.Point(371, 32);
            this.dgvINSERT.Name = "dgvINSERT";
            this.dgvINSERT.ReadOnly = true;
            this.dgvINSERT.Size = new System.Drawing.Size(177, 377);
            this.dgvINSERT.TabIndex = 5;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(485, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(429, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Insert";
            // 
            // dgvSHELL
            // 
            this.dgvSHELL.AllowUserToAddRows = false;
            this.dgvSHELL.AllowUserToDeleteRows = false;
            this.dgvSHELL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSHELL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSHELL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4});
            this.dgvSHELL.Location = new System.Drawing.Point(553, 32);
            this.dgvSHELL.Name = "dgvSHELL";
            this.dgvSHELL.ReadOnly = true;
            this.dgvSHELL.Size = new System.Drawing.Size(179, 377);
            this.dgvSHELL.TabIndex = 8;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(621, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Shell";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(788, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "QuickSort";
            // 
            // dgvQUICKSORT
            // 
            this.dgvQUICKSORT.AllowUserToAddRows = false;
            this.dgvQUICKSORT.AllowUserToDeleteRows = false;
            this.dgvQUICKSORT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQUICKSORT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQUICKSORT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5});
            this.dgvQUICKSORT.Location = new System.Drawing.Point(738, 32);
            this.dgvQUICKSORT.Name = "dgvQUICKSORT";
            this.dgvQUICKSORT.ReadOnly = true;
            this.dgvQUICKSORT.Size = new System.Drawing.Size(186, 377);
            this.dgvQUICKSORT.TabIndex = 11;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 484);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Li=";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(180, 484);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Ls=";
            // 
            // txtLI
            // 
            this.txtLI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLI.Location = new System.Drawing.Point(51, 478);
            this.txtLI.Name = "txtLI";
            this.txtLI.Size = new System.Drawing.Size(123, 26);
            this.txtLI.TabIndex = 14;
            // 
            // txtLS
            // 
            this.txtLS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLS.Location = new System.Drawing.Point(218, 478);
            this.txtLS.Name = "txtLS";
            this.txtLS.Size = new System.Drawing.Size(123, 26);
            this.txtLS.TabIndex = 15;
            // 
            // btnGENERAR
            // 
            this.btnGENERAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGENERAR.Location = new System.Drawing.Point(356, 473);
            this.btnGENERAR.Name = "btnGENERAR";
            this.btnGENERAR.Size = new System.Drawing.Size(123, 31);
            this.btnGENERAR.TabIndex = 16;
            this.btnGENERAR.Text = "Generar";
            this.btnGENERAR.UseVisualStyleBackColor = true;
            this.btnGENERAR.Click += new System.EventHandler(this.btnGENERAR_Click);
            // 
            // btnCALCULAR
            // 
            this.btnCALCULAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCALCULAR.Location = new System.Drawing.Point(485, 473);
            this.btnCALCULAR.Name = "btnCALCULAR";
            this.btnCALCULAR.Size = new System.Drawing.Size(123, 31);
            this.btnCALCULAR.TabIndex = 17;
            this.btnCALCULAR.Text = "Calcular";
            this.btnCALCULAR.UseVisualStyleBackColor = true;
            this.btnCALCULAR.Click += new System.EventHandler(this.btnCALCULAR_Click);
            // 
            // lblITERACIONES1
            // 
            this.lblITERACIONES1.AutoSize = true;
            this.lblITERACIONES1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblITERACIONES1.Location = new System.Drawing.Point(188, 412);
            this.lblITERACIONES1.Name = "lblITERACIONES1";
            this.lblITERACIONES1.Size = new System.Drawing.Size(92, 20);
            this.lblITERACIONES1.TabIndex = 18;
            this.lblITERACIONES1.Text = "Iteraciones:";
            // 
            // lblITERACIONES2
            // 
            this.lblITERACIONES2.AutoSize = true;
            this.lblITERACIONES2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblITERACIONES2.Location = new System.Drawing.Point(367, 412);
            this.lblITERACIONES2.Name = "lblITERACIONES2";
            this.lblITERACIONES2.Size = new System.Drawing.Size(92, 20);
            this.lblITERACIONES2.TabIndex = 19;
            this.lblITERACIONES2.Text = "Iteraciones:";
            // 
            // lblITERACIONES3
            // 
            this.lblITERACIONES3.AutoSize = true;
            this.lblITERACIONES3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblITERACIONES3.Location = new System.Drawing.Point(549, 412);
            this.lblITERACIONES3.Name = "lblITERACIONES3";
            this.lblITERACIONES3.Size = new System.Drawing.Size(92, 20);
            this.lblITERACIONES3.TabIndex = 20;
            this.lblITERACIONES3.Text = "Iteraciones:";
            // 
            // lblITERACIONES4
            // 
            this.lblITERACIONES4.AutoSize = true;
            this.lblITERACIONES4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblITERACIONES4.Location = new System.Drawing.Point(734, 412);
            this.lblITERACIONES4.Name = "lblITERACIONES4";
            this.lblITERACIONES4.Size = new System.Drawing.Size(92, 20);
            this.lblITERACIONES4.TabIndex = 21;
            this.lblITERACIONES4.Text = "Iteraciones:";
            // 
            // lblIT1
            // 
            this.lblIT1.AutoSize = true;
            this.lblIT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIT1.Location = new System.Drawing.Point(274, 412);
            this.lblIT1.Name = "lblIT1";
            this.lblIT1.Size = new System.Drawing.Size(18, 20);
            this.lblIT1.TabIndex = 22;
            this.lblIT1.Text = "0";
            // 
            // lblIT2
            // 
            this.lblIT2.AutoSize = true;
            this.lblIT2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIT2.Location = new System.Drawing.Point(451, 412);
            this.lblIT2.Name = "lblIT2";
            this.lblIT2.Size = new System.Drawing.Size(18, 20);
            this.lblIT2.TabIndex = 23;
            this.lblIT2.Text = "0";
            // 
            // lblIT3
            // 
            this.lblIT3.AutoSize = true;
            this.lblIT3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIT3.Location = new System.Drawing.Point(635, 412);
            this.lblIT3.Name = "lblIT3";
            this.lblIT3.Size = new System.Drawing.Size(18, 20);
            this.lblIT3.TabIndex = 24;
            this.lblIT3.Text = "0";
            // 
            // lblIT4
            // 
            this.lblIT4.AutoSize = true;
            this.lblIT4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIT4.Location = new System.Drawing.Point(820, 412);
            this.lblIT4.Name = "lblIT4";
            this.lblIT4.Size = new System.Drawing.Size(18, 20);
            this.lblIT4.TabIndex = 25;
            this.lblIT4.Text = "0";
            // 
            // btnLIMPIAR
            // 
            this.btnLIMPIAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLIMPIAR.Location = new System.Drawing.Point(614, 473);
            this.btnLIMPIAR.Name = "btnLIMPIAR";
            this.btnLIMPIAR.Size = new System.Drawing.Size(123, 31);
            this.btnLIMPIAR.TabIndex = 26;
            this.btnLIMPIAR.Text = "Limpiar";
            this.btnLIMPIAR.UseVisualStyleBackColor = true;
            this.btnLIMPIAR.Click += new System.EventHandler(this.btnLIMPIAR_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 432);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 20);
            this.label10.TabIndex = 27;
            this.label10.Text = "I";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 452);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 20);
            this.label11.TabIndex = 28;
            this.label11.Text = "F";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(188, 432);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 20);
            this.label12.TabIndex = 29;
            this.label12.Text = "I";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(188, 452);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 20);
            this.label13.TabIndex = 30;
            this.label13.Text = "F";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(367, 432);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 20);
            this.label14.TabIndex = 31;
            this.label14.Text = "I";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(367, 450);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(19, 20);
            this.label15.TabIndex = 32;
            this.label15.Text = "F";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(549, 432);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(14, 20);
            this.label16.TabIndex = 33;
            this.label16.Text = "I";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(549, 452);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(19, 20);
            this.label17.TabIndex = 34;
            this.label17.Text = "F";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(734, 432);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(14, 20);
            this.label18.TabIndex = 35;
            this.label18.Text = "I";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(734, 452);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(19, 20);
            this.label19.TabIndex = 36;
            this.label19.Text = "F";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Enabled = false;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(80, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(14, 20);
            this.label20.TabIndex = 37;
            this.label20.Text = "-";
            // 
            // MetodoBurbuja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 538);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnLIMPIAR);
            this.Controls.Add(this.lblIT4);
            this.Controls.Add(this.lblIT3);
            this.Controls.Add(this.lblIT2);
            this.Controls.Add(this.lblIT1);
            this.Controls.Add(this.lblITERACIONES4);
            this.Controls.Add(this.lblITERACIONES3);
            this.Controls.Add(this.lblITERACIONES2);
            this.Controls.Add(this.lblITERACIONES1);
            this.Controls.Add(this.btnCALCULAR);
            this.Controls.Add(this.btnGENERAR);
            this.Controls.Add(this.txtLS);
            this.Controls.Add(this.txtLI);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvQUICKSORT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvSHELL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvINSERT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvBURBUJA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvORIGINAL);
            this.Controls.Add(this.label1);
            this.Name = "MetodoBurbuja";
            this.Text = "Metodo de Ordenamiento y Busqueda";
            this.Load += new System.EventHandler(this.MetodoBurbuja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvORIGINAL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBURBUJA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvINSERT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSHELL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQUICKSORT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvORIGINAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvBURBUJA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvINSERT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvSHELL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvQUICKSORT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLI;
        private System.Windows.Forms.TextBox txtLS;
        private System.Windows.Forms.Button btnGENERAR;
        private System.Windows.Forms.Button btnCALCULAR;
        private System.Windows.Forms.Label lblITERACIONES1;
        private System.Windows.Forms.Label lblITERACIONES2;
        private System.Windows.Forms.Label lblITERACIONES3;
        private System.Windows.Forms.Label lblITERACIONES4;
        private System.Windows.Forms.Label lblIT1;
        private System.Windows.Forms.Label lblIT2;
        private System.Windows.Forms.Label lblIT3;
        private System.Windows.Forms.Label lblIT4;
        private System.Windows.Forms.Button btnLIMPIAR;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
    }
}