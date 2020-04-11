namespace GPRO_QMS_Counter
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNormalSize = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnMaximize = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statusTotalDone = new System.Windows.Forms.Label();
            this.statusTotalWaiting = new System.Windows.Forms.Label();
            this.btPrintStatus = new System.Windows.Forms.Button();
            this.btDisplayStatus = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.txtma = new System.Windows.Forms.TextBox();
            this.txtDOB = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtParam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbWaiting = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbCurrentTicket = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btFinish = new System.Windows.Forms.Button();
            this.btTranfer = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btRecall = new System.Windows.Forms.Button();
            this.btCallAnyTicket = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btActive = new System.Windows.Forms.Button();
            this.circlePictureBox1 = new GPRO_QMS_Counter.CirclePictureBox();
            this.btTemplate = new System.Windows.Forms.Button();
            this.btConnectSQL = new System.Windows.Forms.Button();
            this.btSetting = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timerDocAmThanh = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNormalSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDOB)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circlePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnNormalSize);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnMaximize);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1245, 38);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GPRO_QMS_Counter.Properties.Resources._1499069963_headphone;
            this.pictureBox1.Location = new System.Drawing.Point(5, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(45, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "GPRO Gọi số - Hệ thống xếp hàng tự động";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnNormalSize
            // 
            this.btnNormalSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNormalSize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNormalSize.Image = global::GPRO_QMS_Counter.Properties.Resources.res;
            this.btnNormalSize.Location = new System.Drawing.Point(1092, 9);
            this.btnNormalSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNormalSize.Name = "btnNormalSize";
            this.btnNormalSize.Size = new System.Drawing.Size(21, 22);
            this.btnNormalSize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNormalSize.TabIndex = 3;
            this.btnNormalSize.TabStop = false;
            this.btnNormalSize.Visible = false;
            this.btnNormalSize.Click += new System.EventHandler(this.btnNormalSize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = global::GPRO_QMS_Counter.Properties.Resources.minimazar;
            this.btnMinimize.Location = new System.Drawing.Point(1131, 9);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(21, 22);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.Image = global::GPRO_QMS_Counter.Properties.Resources.maxi;
            this.btnMaximize.Location = new System.Drawing.Point(1168, 9);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(21, 22);
            this.btnMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximize.TabIndex = 1;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::GPRO_QMS_Counter.Properties.Resources.cerrar;
            this.btnClose.Location = new System.Drawing.Point(1205, 9);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(21, 22);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.statusTotalDone);
            this.panel2.Controls.Add(this.statusTotalWaiting);
            this.panel2.Controls.Add(this.btPrintStatus);
            this.panel2.Controls.Add(this.btDisplayStatus);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 763);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1245, 37);
            this.panel2.TabIndex = 2;
            // 
            // statusTotalDone
            // 
            this.statusTotalDone.AutoSize = true;
            this.statusTotalDone.Font = new System.Drawing.Font("Arial", 10.2F);
            this.statusTotalDone.ForeColor = System.Drawing.Color.Yellow;
            this.statusTotalDone.Location = new System.Drawing.Point(515, 10);
            this.statusTotalDone.Name = "statusTotalDone";
            this.statusTotalDone.Size = new System.Drawing.Size(126, 19);
            this.statusTotalDone.TabIndex = 29;
            this.statusTotalDone.Text = "Đã giao dịch : 0";
            // 
            // statusTotalWaiting
            // 
            this.statusTotalWaiting.AutoSize = true;
            this.statusTotalWaiting.Font = new System.Drawing.Font("Arial", 10.2F);
            this.statusTotalWaiting.ForeColor = System.Drawing.Color.Yellow;
            this.statusTotalWaiting.Location = new System.Drawing.Point(379, 9);
            this.statusTotalWaiting.Name = "statusTotalWaiting";
            this.statusTotalWaiting.Size = new System.Drawing.Size(102, 19);
            this.statusTotalWaiting.TabIndex = 28;
            this.statusTotalWaiting.Text = "Đang đợi : 0";
            // 
            // btPrintStatus
            // 
            this.btPrintStatus.FlatAppearance.BorderSize = 0;
            this.btPrintStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPrintStatus.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPrintStatus.ForeColor = System.Drawing.Color.Yellow;
            this.btPrintStatus.Image = global::GPRO_QMS_Counter.Properties.Resources.com_port_dis;
            this.btPrintStatus.Location = new System.Drawing.Point(192, 0);
            this.btPrintStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btPrintStatus.Name = "btPrintStatus";
            this.btPrintStatus.Size = new System.Drawing.Size(181, 34);
            this.btPrintStatus.TabIndex = 2;
            this.btPrintStatus.Text = "Print COM";
            this.btPrintStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btPrintStatus.UseVisualStyleBackColor = true;
            // 
            // btDisplayStatus
            // 
            this.btDisplayStatus.FlatAppearance.BorderSize = 0;
            this.btDisplayStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDisplayStatus.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDisplayStatus.ForeColor = System.Drawing.Color.Yellow;
            this.btDisplayStatus.Image = global::GPRO_QMS_Counter.Properties.Resources.com_port_dis;
            this.btDisplayStatus.Location = new System.Drawing.Point(5, 1);
            this.btDisplayStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btDisplayStatus.Name = "btDisplayStatus";
            this.btDisplayStatus.Size = new System.Drawing.Size(181, 34);
            this.btDisplayStatus.TabIndex = 1;
            this.btDisplayStatus.Text = "Display COM";
            this.btDisplayStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btDisplayStatus.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(108, 38);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1137, 725);
            this.panel3.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.AutoScroll = true;
            this.panel8.Controls.Add(this.panel11);
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Location = new System.Drawing.Point(5, 6);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1125, 438);
            this.panel8.TabIndex = 1;
            // 
            // panel11
            // 
            this.panel11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel11.AutoScroll = true;
            this.panel11.Location = new System.Drawing.Point(0, 49);
            this.panel11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1125, 386);
            this.panel11.TabIndex = 1;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(68)))), ((int)(((byte)(114)))));
            this.panel10.Controls.Add(this.txtAdd);
            this.panel10.Controls.Add(this.txtma);
            this.panel10.Controls.Add(this.txtDOB);
            this.panel10.Controls.Add(this.label10);
            this.panel10.Controls.Add(this.label5);
            this.panel10.Controls.Add(this.label9);
            this.panel10.Controls.Add(this.txtname);
            this.panel10.Controls.Add(this.label8);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1125, 46);
            this.panel10.TabIndex = 0;
            // 
            // txtAdd
            // 
            this.txtAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAdd.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdd.Location = new System.Drawing.Point(815, 4);
            this.txtAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAdd.Multiline = true;
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(308, 38);
            this.txtAdd.TabIndex = 31;
            // 
            // txtma
            // 
            this.txtma.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtma.Location = new System.Drawing.Point(76, 4);
            this.txtma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(191, 28);
            this.txtma.TabIndex = 33;
            // 
            // txtDOB
            // 
            this.txtDOB.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDOB.Location = new System.Drawing.Point(651, 7);
            this.txtDOB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDOB.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtDOB.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(83, 28);
            this.txtDOB.TabIndex = 30;
            this.txtDOB.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Yellow;
            this.label10.Location = new System.Drawing.Point(740, 7);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 21);
            this.label10.TabIndex = 28;
            this.label10.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(4, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 21);
            this.label5.TabIndex = 32;
            this.label5.Text = "Mã KH";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Yellow;
            this.label9.Location = new System.Drawing.Point(553, 7);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 21);
            this.label9.TabIndex = 27;
            this.label9.Text = "Năm sinh";
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(352, 4);
            this.txtname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(191, 28);
            this.txtname.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Yellow;
            this.label8.Location = new System.Drawing.Point(277, 7);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 21);
            this.label8.TabIndex = 26;
            this.label8.Text = "Họ tên";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 447);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1137, 278);
            this.panel4.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(68)))), ((int)(((byte)(114)))));
            this.panel6.Controls.Add(this.panel12);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1137, 155);
            this.panel6.TabIndex = 31;
            // 
            // panel12
            // 
            this.panel12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel12.Controls.Add(this.txtResult);
            this.panel12.Controls.Add(this.txtParam);
            this.panel12.Controls.Add(this.label3);
            this.panel12.Controls.Add(this.lbWaiting);
            this.panel12.Location = new System.Drawing.Point(591, 4);
            this.panel12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(543, 146);
            this.panel12.TabIndex = 1;
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.Gainsboro;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(4, 32);
            this.txtResult.Margin = new System.Windows.Forms.Padding(4);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(537, 26);
            this.txtResult.TabIndex = 23;
            this.txtResult.Text = "Kết quả xử lý .";
            // 
            // txtParam
            // 
            this.txtParam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParam.Location = new System.Drawing.Point(4, 0);
            this.txtParam.Margin = new System.Windows.Forms.Padding(4);
            this.txtParam.MaxLength = 10;
            this.txtParam.Name = "txtParam";
            this.txtParam.Size = new System.Drawing.Size(537, 26);
            this.txtParam.TabIndex = 22;
            this.txtParam.Text = "Yêu cầu xử lý ...";
            this.txtParam.Enter += new System.EventHandler(this.RemovePlaceHolder);
            this.txtParam.Leave += new System.EventHandler(this.AddPlaceHolder);
            this.txtParam.MouseEnter += new System.EventHandler(this.RemovePlaceHolder);
            this.txtParam.MouseLeave += new System.EventHandler(this.AddPlaceHolder);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(4, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(537, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "ĐANG ĐỢI TẠI QUẦY";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbWaiting
            // 
            this.lbWaiting.AutoSize = true;
            this.lbWaiting.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWaiting.ForeColor = System.Drawing.Color.Yellow;
            this.lbWaiting.Location = new System.Drawing.Point(7, 98);
            this.lbWaiting.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbWaiting.Name = "lbWaiting";
            this.lbWaiting.Size = new System.Drawing.Size(43, 46);
            this.lbWaiting.TabIndex = 7;
            this.lbWaiting.Text = "0";
            this.lbWaiting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbWaiting.TextChanged += new System.EventHandler(this.lbWaiting_TextChanged);
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.Controls.Add(this.lbCurrentTicket);
            this.panel7.Location = new System.Drawing.Point(5, 4);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(579, 146);
            this.panel7.TabIndex = 0;
            // 
            // lbCurrentTicket
            // 
            this.lbCurrentTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCurrentTicket.Font = new System.Drawing.Font("Tahoma", 67.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentTicket.ForeColor = System.Drawing.Color.Yellow;
            this.lbCurrentTicket.Location = new System.Drawing.Point(0, 0);
            this.lbCurrentTicket.Name = "lbCurrentTicket";
            this.lbCurrentTicket.Size = new System.Drawing.Size(579, 146);
            this.lbCurrentTicket.TabIndex = 0;
            this.lbCurrentTicket.Text = "9999";
            this.lbCurrentTicket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btFinish);
            this.panel5.Controls.Add(this.btTranfer);
            this.panel5.Controls.Add(this.btCancel);
            this.panel5.Controls.Add(this.btRecall);
            this.panel5.Controls.Add(this.btCallAnyTicket);
            this.panel5.Controls.Add(this.btNext);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 155);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1137, 123);
            this.panel5.TabIndex = 30;
            // 
            // btFinish
            // 
            this.btFinish.BackColor = System.Drawing.Color.Transparent;
            this.btFinish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btFinish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btFinish.FlatAppearance.BorderSize = 0;
            this.btFinish.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(178)))), ((int)(((byte)(185)))));
            this.btFinish.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.btFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btFinish.ForeColor = System.Drawing.Color.Yellow;
            this.btFinish.Image = ((System.Drawing.Image)(resources.GetObject("btFinish.Image")));
            this.btFinish.Location = new System.Drawing.Point(557, 5);
            this.btFinish.Margin = new System.Windows.Forms.Padding(4);
            this.btFinish.Name = "btFinish";
            this.btFinish.Size = new System.Drawing.Size(131, 113);
            this.btFinish.TabIndex = 30;
            this.btFinish.Text = "Hoàn tất";
            this.btFinish.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btFinish.UseVisualStyleBackColor = false;
            this.btFinish.Click += new System.EventHandler(this.btFinish_Click);
            // 
            // btTranfer
            // 
            this.btTranfer.BackColor = System.Drawing.Color.Transparent;
            this.btTranfer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btTranfer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTranfer.FlatAppearance.BorderSize = 0;
            this.btTranfer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(178)))), ((int)(((byte)(185)))));
            this.btTranfer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.btTranfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTranfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTranfer.ForeColor = System.Drawing.Color.Yellow;
            this.btTranfer.Image = ((System.Drawing.Image)(resources.GetObject("btTranfer.Image")));
            this.btTranfer.Location = new System.Drawing.Point(419, 5);
            this.btTranfer.Margin = new System.Windows.Forms.Padding(4);
            this.btTranfer.Name = "btTranfer";
            this.btTranfer.Size = new System.Drawing.Size(131, 113);
            this.btTranfer.TabIndex = 33;
            this.btTranfer.Text = "Chuyển";
            this.btTranfer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btTranfer.UseVisualStyleBackColor = false;
            this.btTranfer.Click += new System.EventHandler(this.btTranfer_Click);
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.Transparent;
            this.btCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancel.FlatAppearance.BorderSize = 0;
            this.btCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(178)))), ((int)(((byte)(185)))));
            this.btCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.ForeColor = System.Drawing.Color.Yellow;
            this.btCancel.Image = ((System.Drawing.Image)(resources.GetObject("btCancel.Image")));
            this.btCancel.Location = new System.Drawing.Point(695, 5);
            this.btCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(131, 113);
            this.btCancel.TabIndex = 31;
            this.btCancel.Text = "Hủy";
            this.btCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btRecall
            // 
            this.btRecall.BackColor = System.Drawing.Color.Transparent;
            this.btRecall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btRecall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRecall.FlatAppearance.BorderSize = 0;
            this.btRecall.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(178)))), ((int)(((byte)(185)))));
            this.btRecall.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.btRecall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRecall.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRecall.ForeColor = System.Drawing.Color.Yellow;
            this.btRecall.Image = ((System.Drawing.Image)(resources.GetObject("btRecall.Image")));
            this.btRecall.Location = new System.Drawing.Point(143, 5);
            this.btRecall.Margin = new System.Windows.Forms.Padding(4);
            this.btRecall.Name = "btRecall";
            this.btRecall.Size = new System.Drawing.Size(131, 113);
            this.btRecall.TabIndex = 29;
            this.btRecall.Text = "  Nhắc lại";
            this.btRecall.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btRecall.UseVisualStyleBackColor = false;
            this.btRecall.Click += new System.EventHandler(this.btRecall_Click);
            // 
            // btCallAnyTicket
            // 
            this.btCallAnyTicket.BackColor = System.Drawing.Color.Transparent;
            this.btCallAnyTicket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btCallAnyTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCallAnyTicket.FlatAppearance.BorderSize = 0;
            this.btCallAnyTicket.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(178)))), ((int)(((byte)(185)))));
            this.btCallAnyTicket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.btCallAnyTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCallAnyTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCallAnyTicket.ForeColor = System.Drawing.Color.Yellow;
            this.btCallAnyTicket.Image = ((System.Drawing.Image)(resources.GetObject("btCallAnyTicket.Image")));
            this.btCallAnyTicket.Location = new System.Drawing.Point(281, 5);
            this.btCallAnyTicket.Margin = new System.Windows.Forms.Padding(4);
            this.btCallAnyTicket.Name = "btCallAnyTicket";
            this.btCallAnyTicket.Size = new System.Drawing.Size(131, 113);
            this.btCallAnyTicket.TabIndex = 32;
            this.btCallAnyTicket.Text = "Gọi bất kỳ";
            this.btCallAnyTicket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btCallAnyTicket.UseVisualStyleBackColor = false;
            this.btCallAnyTicket.Click += new System.EventHandler(this.btCallAnyTicket_Click);
            // 
            // btNext
            // 
            this.btNext.BackColor = System.Drawing.Color.Transparent;
            this.btNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btNext.FlatAppearance.BorderSize = 0;
            this.btNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(178)))), ((int)(((byte)(185)))));
            this.btNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.btNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNext.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNext.ForeColor = System.Drawing.Color.Yellow;
            this.btNext.Image = ((System.Drawing.Image)(resources.GetObject("btNext.Image")));
            this.btNext.Location = new System.Drawing.Point(5, 5);
            this.btNext.Margin = new System.Windows.Forms.Padding(4);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(131, 113);
            this.btNext.TabIndex = 24;
            this.btNext.Text = "Gọi tiếp theo";
            this.btNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btNext.UseVisualStyleBackColor = false;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel9.Controls.Add(this.btActive);
            this.panel9.Controls.Add(this.circlePictureBox1);
            this.panel9.Controls.Add(this.btTemplate);
            this.panel9.Controls.Add(this.btConnectSQL);
            this.panel9.Controls.Add(this.btSetting);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(0, 38);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(109, 725);
            this.panel9.TabIndex = 2;
            // 
            // btActive
            // 
            this.btActive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btActive.FlatAppearance.BorderSize = 0;
            this.btActive.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(178)))), ((int)(((byte)(185)))));
            this.btActive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.btActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btActive.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btActive.ForeColor = System.Drawing.Color.White;
            this.btActive.Image = global::GPRO_QMS_Counter.Properties.Resources.iconfinder_stock_keyring_21472;
            this.btActive.Location = new System.Drawing.Point(0, 394);
            this.btActive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btActive.Name = "btActive";
            this.btActive.Size = new System.Drawing.Size(109, 70);
            this.btActive.TabIndex = 10;
            this.btActive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btActive.UseVisualStyleBackColor = true;
            this.btActive.Click += new System.EventHandler(this.btActive_Click);
            // 
            // circlePictureBox1
            // 
            this.circlePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("circlePictureBox1.Image")));
            this.circlePictureBox1.Location = new System.Drawing.Point(9, 25);
            this.circlePictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.circlePictureBox1.Name = "circlePictureBox1";
            this.circlePictureBox1.Size = new System.Drawing.Size(91, 90);
            this.circlePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.circlePictureBox1.TabIndex = 6;
            this.circlePictureBox1.TabStop = false;
            // 
            // btTemplate
            // 
            this.btTemplate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTemplate.Enabled = false;
            this.btTemplate.FlatAppearance.BorderSize = 0;
            this.btTemplate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(178)))), ((int)(((byte)(185)))));
            this.btTemplate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.btTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTemplate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTemplate.ForeColor = System.Drawing.Color.White;
            this.btTemplate.Image = global::GPRO_QMS_Counter.Properties.Resources.iconfinder_coupon_3387315;
            this.btTemplate.Location = new System.Drawing.Point(0, 320);
            this.btTemplate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btTemplate.Name = "btTemplate";
            this.btTemplate.Size = new System.Drawing.Size(109, 70);
            this.btTemplate.TabIndex = 9;
            this.btTemplate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btTemplate.UseVisualStyleBackColor = true;
            this.btTemplate.Click += new System.EventHandler(this.btTemplate_Click);
            // 
            // btConnectSQL
            // 
            this.btConnectSQL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btConnectSQL.Enabled = false;
            this.btConnectSQL.FlatAppearance.BorderSize = 0;
            this.btConnectSQL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(178)))), ((int)(((byte)(185)))));
            this.btConnectSQL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.btConnectSQL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConnectSQL.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConnectSQL.ForeColor = System.Drawing.Color.White;
            this.btConnectSQL.Image = global::GPRO_QMS_Counter.Properties.Resources.iconfinder_cmyk_03_906566;
            this.btConnectSQL.Location = new System.Drawing.Point(0, 238);
            this.btConnectSQL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btConnectSQL.Name = "btConnectSQL";
            this.btConnectSQL.Size = new System.Drawing.Size(109, 70);
            this.btConnectSQL.TabIndex = 7;
            this.btConnectSQL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btConnectSQL.UseVisualStyleBackColor = true;
            this.btConnectSQL.Click += new System.EventHandler(this.btConnectSQL_Click);
            // 
            // btSetting
            // 
            this.btSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSetting.Enabled = false;
            this.btSetting.FlatAppearance.BorderSize = 0;
            this.btSetting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(178)))), ((int)(((byte)(185)))));
            this.btSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.btSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSetting.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSetting.ForeColor = System.Drawing.Color.White;
            this.btSetting.Image = global::GPRO_QMS_Counter.Properties.Resources.iconfinder_Options_105206;
            this.btSetting.Location = new System.Drawing.Point(0, 162);
            this.btSetting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSetting.Name = "btSetting";
            this.btSetting.Size = new System.Drawing.Size(109, 70);
            this.btSetting.TabIndex = 8;
            this.btSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btSetting.UseVisualStyleBackColor = true;
            this.btSetting.Click += new System.EventHandler(this.btSetting_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timerDocAmThanh
            // 
            this.timerDocAmThanh.Interval = 1000;
            this.timerDocAmThanh.Tick += new System.EventHandler(this.TmerQuetComport_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 800);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNormalSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDOB)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.circlePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btDisplayStatus;
        private System.Windows.Forms.Button btPrintStatus;
        private System.Windows.Forms.Label statusTotalDone;
        private System.Windows.Forms.Label statusTotalWaiting;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lbCurrentTicket;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbWaiting;
        private System.Windows.Forms.TextBox txtParam;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnMaximize;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox btnNormalSize;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private CirclePictureBox circlePictureBox1;
        private System.Windows.Forms.Button btTemplate;
        private System.Windows.Forms.Button btSetting;
        private System.Windows.Forms.Button btConnectSQL;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.NumericUpDown txtDOB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btFinish;
        private System.Windows.Forms.Button btTranfer;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btRecall;
        private System.Windows.Forms.Button btCallAnyTicket;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Timer timerDocAmThanh;
        private System.Windows.Forms.Button btActive;
    }
}