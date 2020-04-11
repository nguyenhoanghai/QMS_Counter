namespace GPRO_QMS_Counter
{
    partial class FrmMain4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain4));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statusTotalDone = new System.Windows.Forms.Label();
            this.statusTotalWaiting = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtParam = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbGeneralWaiting = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbWaiting = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCurrentTicket = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtma = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.txtDOB = new System.Windows.Forms.NumericUpDown();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.btRecall = new System.Windows.Forms.Button();
            this.btTranfer = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.btCallAnyTicket = new System.Windows.Forms.Button();
            this.btFinish = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btPrintStatus = new System.Windows.Forms.Button();
            this.btDisplayStatus = new System.Windows.Forms.Button();
            this.btTemplate = new System.Windows.Forms.Button();
            this.btSetting = new System.Windows.Forms.Button();
            this.btConnectSQL = new System.Windows.Forms.Button();
            this.btActive = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDOB)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.panel1.Controls.Add(this.btActive);
            this.panel1.Controls.Add(this.btTemplate);
            this.panel1.Controls.Add(this.btSetting);
            this.panel1.Controls.Add(this.btConnectSQL);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(63, 669);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(63, 71);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "G";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.panel2.Controls.Add(this.statusTotalDone);
            this.panel2.Controls.Add(this.statusTotalWaiting);
            this.panel2.Controls.Add(this.btPrintStatus);
            this.panel2.Controls.Add(this.btDisplayStatus);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(63, 635);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1112, 34);
            this.panel2.TabIndex = 1;
            // 
            // statusTotalDone
            // 
            this.statusTotalDone.AutoSize = true;
            this.statusTotalDone.Font = new System.Drawing.Font("Arial", 10.2F);
            this.statusTotalDone.ForeColor = System.Drawing.Color.White;
            this.statusTotalDone.Location = new System.Drawing.Point(530, 8);
            this.statusTotalDone.Name = "statusTotalDone";
            this.statusTotalDone.Size = new System.Drawing.Size(126, 19);
            this.statusTotalDone.TabIndex = 27;
            this.statusTotalDone.Text = "Đã giao dịch : 0";
            // 
            // statusTotalWaiting
            // 
            this.statusTotalWaiting.AutoSize = true;
            this.statusTotalWaiting.Font = new System.Drawing.Font("Arial", 10.2F);
            this.statusTotalWaiting.ForeColor = System.Drawing.Color.White;
            this.statusTotalWaiting.Location = new System.Drawing.Point(394, 7);
            this.statusTotalWaiting.Name = "statusTotalWaiting";
            this.statusTotalWaiting.Size = new System.Drawing.Size(102, 19);
            this.statusTotalWaiting.TabIndex = 26;
            this.statusTotalWaiting.Text = "Đang đợi : 0";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(63, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(684, 628);
            this.panel4.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.lbGeneralWaiting);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.lbWaiting);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.lbCurrentTicket);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(684, 628);
            this.panel5.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(108)))));
            this.panel8.Controls.Add(this.btRecall);
            this.panel8.Controls.Add(this.label7);
            this.panel8.Controls.Add(this.btTranfer);
            this.panel8.Controls.Add(this.btNext);
            this.panel8.Controls.Add(this.txtParam);
            this.panel8.Controls.Add(this.btCallAnyTicket);
            this.panel8.Controls.Add(this.btFinish);
            this.panel8.Controls.Add(this.label6);
            this.panel8.Controls.Add(this.txtResult);
            this.panel8.Controls.Add(this.btCancel);
            this.panel8.Location = new System.Drawing.Point(0, 393);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(684, 242);
            this.panel8.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(515, 6);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Nhập  yêu cầu";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtParam
            // 
            this.txtParam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParam.Location = new System.Drawing.Point(517, 30);
            this.txtParam.Margin = new System.Windows.Forms.Padding(4);
            this.txtParam.MaxLength = 10;
            this.txtParam.Name = "txtParam";
            this.txtParam.Size = new System.Drawing.Size(159, 26);
            this.txtParam.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(515, 61);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Kết quả";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.White;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(517, 85);
            this.txtResult.Margin = new System.Windows.Forms.Padding(4);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(159, 157);
            this.txtResult.TabIndex = 22;
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(682, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(575, 100);
            this.panel7.TabIndex = 2;
            // 
            // lbGeneralWaiting
            // 
            this.lbGeneralWaiting.AutoSize = true;
            this.lbGeneralWaiting.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGeneralWaiting.ForeColor = System.Drawing.Color.White;
            this.lbGeneralWaiting.Location = new System.Drawing.Point(7, 344);
            this.lbGeneralWaiting.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGeneralWaiting.Name = "lbGeneralWaiting";
            this.lbGeneralWaiting.Size = new System.Drawing.Size(43, 46);
            this.lbGeneralWaiting.TabIndex = 8;
            this.lbGeneralWaiting.Text = "0";
            this.lbGeneralWaiting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbGeneralWaiting.TextChanged += new System.EventHandler(this.lbGeneralWaiting_TextChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(1, 304);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(683, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "ĐANG ĐỢI CHUNG";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbWaiting
            // 
            this.lbWaiting.AutoSize = true;
            this.lbWaiting.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWaiting.ForeColor = System.Drawing.Color.White;
            this.lbWaiting.Location = new System.Drawing.Point(7, 254);
            this.lbWaiting.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbWaiting.Name = "lbWaiting";
            this.lbWaiting.Size = new System.Drawing.Size(43, 46);
            this.lbWaiting.TabIndex = 6;
            this.lbWaiting.Text = "0";
            this.lbWaiting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbWaiting.TextChanged += new System.EventHandler(this.lbWaiting_TextChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(1, 214);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(683, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "ĐANG ĐỢI TẠI QUẦY";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCurrentTicket
            // 
            this.lbCurrentTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentTicket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(12)))), ((int)(((byte)(40)))));
            this.lbCurrentTicket.Location = new System.Drawing.Point(2, 44);
            this.lbCurrentTicket.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCurrentTicket.Name = "lbCurrentTicket";
            this.lbCurrentTicket.Size = new System.Drawing.Size(682, 170);
            this.lbCurrentTicket.TabIndex = 4;
            this.lbCurrentTicket.Text = "0000";
            this.lbCurrentTicket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.AliceBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(684, 44);
            this.label2.TabIndex = 3;
            this.label2.Text = "ĐANG GIAO DỊCH";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.AutoScroll = true;
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.panel6.Location = new System.Drawing.Point(746, 106);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(429, 529);
            this.panel6.TabIndex = 3;
            // 
            // txtma
            // 
            this.txtma.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtma.Location = new System.Drawing.Point(832, 13);
            this.txtma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(209, 34);
            this.txtma.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(750, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 26);
            this.label5.TabIndex = 24;
            this.label5.Text = "Mã KH";
            // 
            // txtAdd
            // 
            this.txtAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAdd.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdd.Location = new System.Drawing.Point(1151, 53);
            this.txtAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAdd.Multiline = true;
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(114, 38);
            this.txtAdd.TabIndex = 23;
            // 
            // txtDOB
            // 
            this.txtDOB.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDOB.Location = new System.Drawing.Point(1151, 15);
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
            this.txtDOB.Size = new System.Drawing.Size(88, 34);
            this.txtDOB.TabIndex = 22;
            this.txtDOB.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(832, 53);
            this.txtname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(209, 34);
            this.txtname.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label10.Location = new System.Drawing.Point(1045, 55);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 26);
            this.label10.TabIndex = 20;
            this.label10.Text = "Địa chỉ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(1045, 17);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 26);
            this.label9.TabIndex = 19;
            this.label9.Text = "Năm sinh";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(750, 58);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 26);
            this.label8.TabIndex = 18;
            this.label8.Text = "Họ tên";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 70;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 70;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // btRecall
            // 
            this.btRecall.BackColor = System.Drawing.Color.Transparent;
            this.btRecall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btRecall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRecall.FlatAppearance.BorderSize = 0;
            this.btRecall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRecall.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRecall.ForeColor = System.Drawing.Color.White;
            this.btRecall.Image = ((System.Drawing.Image)(resources.GetObject("btRecall.Image")));
            this.btRecall.Location = new System.Drawing.Point(176, 6);
            this.btRecall.Margin = new System.Windows.Forms.Padding(4);
            this.btRecall.Name = "btRecall";
            this.btRecall.Size = new System.Drawing.Size(166, 113);
            this.btRecall.TabIndex = 24;
            this.btRecall.Text = "  Nhắc lại";
            this.btRecall.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btRecall.UseVisualStyleBackColor = false;
            this.btRecall.Click += new System.EventHandler(this.btRecall_Click);
            // 
            // btTranfer
            // 
            this.btTranfer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btTranfer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTranfer.FlatAppearance.BorderSize = 0;
            this.btTranfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTranfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTranfer.ForeColor = System.Drawing.Color.White;
            this.btTranfer.Image = ((System.Drawing.Image)(resources.GetObject("btTranfer.Image")));
            this.btTranfer.Location = new System.Drawing.Point(175, 126);
            this.btTranfer.Margin = new System.Windows.Forms.Padding(4);
            this.btTranfer.Name = "btTranfer";
            this.btTranfer.Size = new System.Drawing.Size(166, 111);
            this.btTranfer.TabIndex = 28;
            this.btTranfer.Text = "Chuyển";
            this.btTranfer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btTranfer.UseVisualStyleBackColor = true;
            this.btTranfer.Click += new System.EventHandler(this.btTranfer_Click);
            // 
            // btNext
            // 
            this.btNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btNext.FlatAppearance.BorderSize = 0;
            this.btNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNext.ForeColor = System.Drawing.Color.White;
            this.btNext.Image = ((System.Drawing.Image)(resources.GetObject("btNext.Image")));
            this.btNext.Location = new System.Drawing.Point(6, 6);
            this.btNext.Margin = new System.Windows.Forms.Padding(4);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(166, 113);
            this.btNext.TabIndex = 23;
            this.btNext.Text = "Gọi tiếp theo";
            this.btNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // btCallAnyTicket
            // 
            this.btCallAnyTicket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btCallAnyTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCallAnyTicket.FlatAppearance.BorderSize = 0;
            this.btCallAnyTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCallAnyTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCallAnyTicket.ForeColor = System.Drawing.Color.White;
            this.btCallAnyTicket.Image = ((System.Drawing.Image)(resources.GetObject("btCallAnyTicket.Image")));
            this.btCallAnyTicket.Location = new System.Drawing.Point(6, 127);
            this.btCallAnyTicket.Margin = new System.Windows.Forms.Padding(4);
            this.btCallAnyTicket.Name = "btCallAnyTicket";
            this.btCallAnyTicket.Size = new System.Drawing.Size(166, 109);
            this.btCallAnyTicket.TabIndex = 27;
            this.btCallAnyTicket.Text = "Gọi bất kỳ";
            this.btCallAnyTicket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btCallAnyTicket.UseVisualStyleBackColor = true;
            this.btCallAnyTicket.Click += new System.EventHandler(this.btCallAnyTicket_Click);
            // 
            // btFinish
            // 
            this.btFinish.BackColor = System.Drawing.Color.Transparent;
            this.btFinish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btFinish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btFinish.FlatAppearance.BorderSize = 0;
            this.btFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btFinish.ForeColor = System.Drawing.Color.White;
            this.btFinish.Image = ((System.Drawing.Image)(resources.GetObject("btFinish.Image")));
            this.btFinish.Location = new System.Drawing.Point(345, 6);
            this.btFinish.Margin = new System.Windows.Forms.Padding(4);
            this.btFinish.Name = "btFinish";
            this.btFinish.Size = new System.Drawing.Size(166, 113);
            this.btFinish.TabIndex = 25;
            this.btFinish.Text = "Hoàn tất";
            this.btFinish.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btFinish.UseVisualStyleBackColor = false;
            this.btFinish.Click += new System.EventHandler(this.btFinish_Click);
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.Transparent;
            this.btCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancel.FlatAppearance.BorderSize = 0;
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.ForeColor = System.Drawing.Color.White;
            this.btCancel.Image = ((System.Drawing.Image)(resources.GetObject("btCancel.Image")));
            this.btCancel.Location = new System.Drawing.Point(344, 126);
            this.btCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(166, 111);
            this.btCancel.TabIndex = 26;
            this.btCancel.Text = "Hủy";
            this.btCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btPrintStatus
            // 
            this.btPrintStatus.FlatAppearance.BorderSize = 0;
            this.btPrintStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPrintStatus.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPrintStatus.ForeColor = System.Drawing.Color.White;
            this.btPrintStatus.Image = global::GPRO_QMS_Counter.Properties.Resources.com_port_dis;
            this.btPrintStatus.Location = new System.Drawing.Point(187, 0);
            this.btPrintStatus.Name = "btPrintStatus";
            this.btPrintStatus.Size = new System.Drawing.Size(181, 34);
            this.btPrintStatus.TabIndex = 1;
            this.btPrintStatus.Text = "Printer COM";
            this.btPrintStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btPrintStatus.UseVisualStyleBackColor = true;
            // 
            // btDisplayStatus
            // 
            this.btDisplayStatus.FlatAppearance.BorderSize = 0;
            this.btDisplayStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDisplayStatus.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDisplayStatus.ForeColor = System.Drawing.Color.White;
            this.btDisplayStatus.Image = global::GPRO_QMS_Counter.Properties.Resources.com_port_dis;
            this.btDisplayStatus.Location = new System.Drawing.Point(0, 0);
            this.btDisplayStatus.Name = "btDisplayStatus";
            this.btDisplayStatus.Size = new System.Drawing.Size(181, 34);
            this.btDisplayStatus.TabIndex = 0;
            this.btDisplayStatus.Text = "Display COM";
            this.btDisplayStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btDisplayStatus.UseVisualStyleBackColor = true;
            // 
            // btTemplate
            // 
            this.btTemplate.FlatAppearance.BorderSize = 0;
            this.btTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTemplate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTemplate.ForeColor = System.Drawing.Color.White;
            this.btTemplate.Image = global::GPRO_QMS_Counter.Properties.Resources.iconfinder_receipt_3339034;
            this.btTemplate.Location = new System.Drawing.Point(0, 214);
            this.btTemplate.Name = "btTemplate";
            this.btTemplate.Size = new System.Drawing.Size(60, 53);
            this.btTemplate.TabIndex = 3;
            this.btTemplate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btTemplate.UseVisualStyleBackColor = true;
            this.btTemplate.Click += new System.EventHandler(this.btTemplate_Click);
            // 
            // btSetting
            // 
            this.btSetting.FlatAppearance.BorderSize = 0;
            this.btSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSetting.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSetting.ForeColor = System.Drawing.Color.White;
            this.btSetting.Image = global::GPRO_QMS_Counter.Properties.Resources.if_our_process_2_45123;
            this.btSetting.Location = new System.Drawing.Point(0, 75);
            this.btSetting.Name = "btSetting";
            this.btSetting.Size = new System.Drawing.Size(60, 61);
            this.btSetting.TabIndex = 2;
            this.btSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btSetting.UseVisualStyleBackColor = true;
            this.btSetting.Click += new System.EventHandler(this.btSetting_Click);
            // 
            // btConnectSQL
            // 
            this.btConnectSQL.FlatAppearance.BorderSize = 0;
            this.btConnectSQL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConnectSQL.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConnectSQL.ForeColor = System.Drawing.Color.White;
            this.btConnectSQL.Image = global::GPRO_QMS_Counter.Properties.Resources.server_connect;
            this.btConnectSQL.Location = new System.Drawing.Point(0, 142);
            this.btConnectSQL.Name = "btConnectSQL";
            this.btConnectSQL.Size = new System.Drawing.Size(60, 53);
            this.btConnectSQL.TabIndex = 1;
            this.btConnectSQL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btConnectSQL.UseVisualStyleBackColor = true;
            this.btConnectSQL.Click += new System.EventHandler(this.btConnectSQL_Click);
            // 
            // btActive
            // 
            this.btActive.FlatAppearance.BorderSize = 0;
            this.btActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btActive.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btActive.ForeColor = System.Drawing.Color.White;
            this.btActive.Image = global::GPRO_QMS_Counter.Properties.Resources.iconfinder_stock_keyring_21472;
            this.btActive.Location = new System.Drawing.Point(0, 289);
            this.btActive.Name = "btActive";
            this.btActive.Size = new System.Drawing.Size(60, 53);
            this.btActive.TabIndex = 4;
            this.btActive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btActive.UseVisualStyleBackColor = true;
            this.btActive.Click += new System.EventHandler(this.btActive_Click);
            // 
            // FrmMain4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1175, 669);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.txtma);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Name = "FrmMain4";
            this.Text = "Phần mềm Gọi số tự động";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain4_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain4_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDOB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbCurrentTicket;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbWaiting;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbGeneralWaiting;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtParam;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btRecall;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btFinish;
        private System.Windows.Forms.Button btTranfer;
        private System.Windows.Forms.Button btCallAnyTicket;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btConnectSQL;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.NumericUpDown txtDOB;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btPrintStatus;
        private System.Windows.Forms.Button btDisplayStatus;
        private System.Windows.Forms.Button btTemplate;
        private System.Windows.Forms.Button btSetting;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label statusTotalDone;
        private System.Windows.Forms.Label statusTotalWaiting;
        private System.Windows.Forms.Button btActive;
    }
}