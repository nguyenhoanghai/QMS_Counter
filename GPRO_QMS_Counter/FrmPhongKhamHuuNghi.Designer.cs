namespace GPRO_QMS_Counter
{
    partial class FrmPhongKhamHuuNghi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPhongKhamHuuNghi));
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.statusTotalDone = new System.Windows.Forms.Label();
            this.statusTotalWaiting = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbWaiting = new System.Windows.Forms.Label();
            this.txtParam = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbCurrentTicket = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerDocAmThanh = new System.Windows.Forms.Timer(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGoiUuTien = new System.Windows.Forms.Button();
            this.btFinish = new System.Windows.Forms.Button();
            this.btTranfer = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btRecall = new System.Windows.Forms.Button();
            this.btCallAnyTicket = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.btActive = new System.Windows.Forms.Button();
            this.circlePictureBox1 = new GPRO_QMS_Counter.CirclePictureBox();
            this.btTemplate = new System.Windows.Forms.Button();
            this.btConnectSQL = new System.Windows.Forms.Button();
            this.btSetting = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btDisplayStatus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbQualuot = new System.Windows.Forms.Label();
            this.timerLBQualuot = new System.Windows.Forms.Timer(this.components);
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circlePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(45, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(396, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "GPRO Gọi số - Hệ thống xếp hàng tự động - Hữu Nghị";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label2_MouseDown);
            // 
            // statusTotalDone
            // 
            this.statusTotalDone.AutoSize = true;
            this.statusTotalDone.Font = new System.Drawing.Font("Arial", 10.2F);
            this.statusTotalDone.ForeColor = System.Drawing.Color.Yellow;
            this.statusTotalDone.Location = new System.Drawing.Point(316, 9);
            this.statusTotalDone.Name = "statusTotalDone";
            this.statusTotalDone.Size = new System.Drawing.Size(126, 19);
            this.statusTotalDone.TabIndex = 33;
            this.statusTotalDone.Text = "Đã giao dịch : 0";
            // 
            // statusTotalWaiting
            // 
            this.statusTotalWaiting.AutoSize = true;
            this.statusTotalWaiting.Font = new System.Drawing.Font("Arial", 10.2F);
            this.statusTotalWaiting.ForeColor = System.Drawing.Color.Yellow;
            this.statusTotalWaiting.Location = new System.Drawing.Point(183, 9);
            this.statusTotalWaiting.Name = "statusTotalWaiting";
            this.statusTotalWaiting.Size = new System.Drawing.Size(102, 19);
            this.statusTotalWaiting.TabIndex = 32;
            this.statusTotalWaiting.Text = "Đang đợi : 0";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(109, 38);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(504, 658);
            this.panel5.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnGoiUuTien);
            this.panel8.Controls.Add(this.btFinish);
            this.panel8.Controls.Add(this.btTranfer);
            this.panel8.Controls.Add(this.btCancel);
            this.panel8.Controls.Add(this.btRecall);
            this.panel8.Controls.Add(this.btCallAnyTicket);
            this.panel8.Controls.Add(this.btNext);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 401);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(504, 257);
            this.panel8.TabIndex = 2;
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
            this.panel6.Size = new System.Drawing.Size(504, 658);
            this.panel6.TabIndex = 32;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.label1);
            this.panel12.Controls.Add(this.lbQualuot);
            this.panel12.Controls.Add(this.txtResult);
            this.panel12.Controls.Add(this.label3);
            this.panel12.Controls.Add(this.lbWaiting);
            this.panel12.Controls.Add(this.txtParam);
            this.panel12.Location = new System.Drawing.Point(0, 172);
            this.panel12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(521, 227);
            this.panel12.TabIndex = 1;
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.Gainsboro;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(4, 196);
            this.txtResult.Margin = new System.Windows.Forms.Padding(4);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(500, 26);
            this.txtResult.TabIndex = 23;
            this.txtResult.Text = "Kết quả xử lý .";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(504, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "ĐANG ĐỢI TẠI QUẦY";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbWaiting
            // 
            this.lbWaiting.AutoSize = true;
            this.lbWaiting.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWaiting.ForeColor = System.Drawing.Color.Yellow;
            this.lbWaiting.Location = new System.Drawing.Point(4, 34);
            this.lbWaiting.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbWaiting.Name = "lbWaiting";
            this.lbWaiting.Size = new System.Drawing.Size(43, 46);
            this.lbWaiting.TabIndex = 7;
            this.lbWaiting.Text = "0";
            this.lbWaiting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbWaiting.TextChanged += new System.EventHandler(this.lbWaiting_TextChanged);
            // 
            // txtParam
            // 
            this.txtParam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParam.Location = new System.Drawing.Point(4, 164);
            this.txtParam.Margin = new System.Windows.Forms.Padding(4);
            this.txtParam.MaxLength = 10;
            this.txtParam.Name = "txtParam";
            this.txtParam.Size = new System.Drawing.Size(500, 26);
            this.txtParam.TabIndex = 22;
            this.txtParam.Text = "Yêu cầu xử lý ...";
            this.txtParam.MouseEnter += new System.EventHandler(this.RemovePlaceHolder);
            this.txtParam.MouseLeave += new System.EventHandler(this.AddPlaceHolder);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lbCurrentTicket);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(504, 166);
            this.panel7.TabIndex = 0;
            // 
            // lbCurrentTicket
            // 
            this.lbCurrentTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCurrentTicket.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentTicket.ForeColor = System.Drawing.Color.Yellow;
            this.lbCurrentTicket.Location = new System.Drawing.Point(0, 0);
            this.lbCurrentTicket.Name = "lbCurrentTicket";
            this.lbCurrentTicket.Size = new System.Drawing.Size(504, 166);
            this.lbCurrentTicket.TabIndex = 0;
            this.lbCurrentTicket.Text = "9999";
            this.lbCurrentTicket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerDocAmThanh
            // 
            this.timerDocAmThanh.Interval = 1000;
            this.timerDocAmThanh.Tick += new System.EventHandler(this.timerDocAmThanh_Tick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btActive);
            this.panel4.Controls.Add(this.circlePictureBox1);
            this.panel4.Controls.Add(this.btTemplate);
            this.panel4.Controls.Add(this.btConnectSQL);
            this.panel4.Controls.Add(this.btSetting);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 38);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(109, 658);
            this.panel4.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 735);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel3.Controls.Add(this.btnMinimize);
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(613, 38);
            this.panel3.TabIndex = 0;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.statusTotalDone);
            this.panel2.Controls.Add(this.statusTotalWaiting);
            this.panel2.Controls.Add(this.btDisplayStatus);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 696);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(613, 39);
            this.panel2.TabIndex = 0;
            // 
            // btnGoiUuTien
            // 
            this.btnGoiUuTien.BackColor = System.Drawing.Color.Red;
            this.btnGoiUuTien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGoiUuTien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoiUuTien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoiUuTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoiUuTien.ForeColor = System.Drawing.Color.White;
            this.btnGoiUuTien.Image = ((System.Drawing.Image)(resources.GetObject("btnGoiUuTien.Image")));
            this.btnGoiUuTien.Location = new System.Drawing.Point(142, 9);
            this.btnGoiUuTien.Margin = new System.Windows.Forms.Padding(4);
            this.btnGoiUuTien.Name = "btnGoiUuTien";
            this.btnGoiUuTien.Size = new System.Drawing.Size(100, 113);
            this.btnGoiUuTien.TabIndex = 40;
            this.btnGoiUuTien.Text = "Gọi kết luận";
            this.btnGoiUuTien.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGoiUuTien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGoiUuTien.UseVisualStyleBackColor = false;
            this.btnGoiUuTien.Click += new System.EventHandler(this.btnGoiUuTien_Click);
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
            this.btFinish.Location = new System.Drawing.Point(142, 130);
            this.btFinish.Margin = new System.Windows.Forms.Padding(4);
            this.btFinish.Name = "btFinish";
            this.btFinish.Size = new System.Drawing.Size(100, 113);
            this.btFinish.TabIndex = 36;
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
            this.btTranfer.Location = new System.Drawing.Point(263, 8);
            this.btTranfer.Margin = new System.Windows.Forms.Padding(4);
            this.btTranfer.Name = "btTranfer";
            this.btTranfer.Size = new System.Drawing.Size(100, 113);
            this.btTranfer.TabIndex = 39;
            this.btTranfer.Text = "Chuyển qua lượt";
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
            this.btCancel.Location = new System.Drawing.Point(263, 130);
            this.btCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(100, 113);
            this.btCancel.TabIndex = 37;
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
            this.btRecall.Location = new System.Drawing.Point(22, 130);
            this.btRecall.Margin = new System.Windows.Forms.Padding(4);
            this.btRecall.Name = "btRecall";
            this.btRecall.Size = new System.Drawing.Size(100, 113);
            this.btRecall.TabIndex = 35;
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
            this.btCallAnyTicket.Location = new System.Drawing.Point(381, 8);
            this.btCallAnyTicket.Margin = new System.Windows.Forms.Padding(4);
            this.btCallAnyTicket.Name = "btCallAnyTicket";
            this.btCallAnyTicket.Size = new System.Drawing.Size(100, 113);
            this.btCallAnyTicket.TabIndex = 38;
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
            this.btNext.Location = new System.Drawing.Point(22, 9);
            this.btNext.Margin = new System.Windows.Forms.Padding(4);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(100, 113);
            this.btNext.TabIndex = 34;
            this.btNext.Text = "Gọi tiếp theo";
            this.btNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btNext.UseVisualStyleBackColor = false;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
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
            this.btActive.Location = new System.Drawing.Point(0, 378);
            this.btActive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btActive.Name = "btActive";
            this.btActive.Size = new System.Drawing.Size(109, 70);
            this.btActive.TabIndex = 14;
            this.btActive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btActive.UseVisualStyleBackColor = true;
            this.btActive.Click += new System.EventHandler(this.btActive_Click);
            // 
            // circlePictureBox1
            // 
            this.circlePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("circlePictureBox1.Image")));
            this.circlePictureBox1.Location = new System.Drawing.Point(11, 9);
            this.circlePictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.circlePictureBox1.Name = "circlePictureBox1";
            this.circlePictureBox1.Size = new System.Drawing.Size(91, 90);
            this.circlePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.circlePictureBox1.TabIndex = 10;
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
            this.btTemplate.Location = new System.Drawing.Point(1, 304);
            this.btTemplate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btTemplate.Name = "btTemplate";
            this.btTemplate.Size = new System.Drawing.Size(109, 70);
            this.btTemplate.TabIndex = 13;
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
            this.btConnectSQL.Location = new System.Drawing.Point(1, 222);
            this.btConnectSQL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btConnectSQL.Name = "btConnectSQL";
            this.btConnectSQL.Size = new System.Drawing.Size(109, 70);
            this.btConnectSQL.TabIndex = 11;
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
            this.btSetting.Location = new System.Drawing.Point(1, 146);
            this.btSetting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSetting.Name = "btSetting";
            this.btSetting.Size = new System.Drawing.Size(109, 70);
            this.btSetting.TabIndex = 12;
            this.btSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btSetting.UseVisualStyleBackColor = true;
            this.btSetting.Click += new System.EventHandler(this.btSetting_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = global::GPRO_QMS_Counter.Properties.Resources.minimazar;
            this.btnMinimize.Location = new System.Drawing.Point(548, 7);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(21, 22);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 10;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::GPRO_QMS_Counter.Properties.Resources.cerrar;
            this.btnClose.Location = new System.Drawing.Point(579, 7);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(21, 22);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 8;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GPRO_QMS_Counter.Properties.Resources._1499069963_headphone;
            this.pictureBox1.Location = new System.Drawing.Point(5, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btDisplayStatus
            // 
            this.btDisplayStatus.FlatAppearance.BorderSize = 0;
            this.btDisplayStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDisplayStatus.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDisplayStatus.ForeColor = System.Drawing.Color.Yellow;
            this.btDisplayStatus.Image = global::GPRO_QMS_Counter.Properties.Resources.com_port_dis;
            this.btDisplayStatus.Location = new System.Drawing.Point(3, 2);
            this.btDisplayStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btDisplayStatus.Name = "btDisplayStatus";
            this.btDisplayStatus.Size = new System.Drawing.Size(173, 33);
            this.btDisplayStatus.TabIndex = 30;
            this.btDisplayStatus.Text = "Display COM";
            this.btDisplayStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btDisplayStatus.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(0, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(504, 30);
            this.label1.TabIndex = 24;
            this.label1.Text = "DANH SÁCH QUA LƯỢT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbQualuot
            // 
            this.lbQualuot.AutoSize = true;
            this.lbQualuot.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQualuot.ForeColor = System.Drawing.Color.Yellow;
            this.lbQualuot.Location = new System.Drawing.Point(4, 114);
            this.lbQualuot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbQualuot.Name = "lbQualuot";
            this.lbQualuot.Size = new System.Drawing.Size(43, 46);
            this.lbQualuot.TabIndex = 25;
            this.lbQualuot.Text = "0";
            this.lbQualuot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbQualuot.TextChanged += new System.EventHandler(this.lbQualuot_TextChanged);
            // 
            // timerLBQualuot
            // 
            this.timerLBQualuot.Tick += new System.EventHandler(this.timerLBQualuot_Tick);
            // 
            // FrmPhongKhamHuuNghi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 735);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPhongKhamHuuNghi";
            this.Text = "FrmPhongKhamHuuNghi";
            this.Load += new System.EventHandler(this.FrmPhongKhamHuuNghi_Load);
            this.panel5.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circlePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer2;
        private CirclePictureBox circlePictureBox1;
        private System.Windows.Forms.Button btTemplate;
        private System.Windows.Forms.Button btConnectSQL;
        private System.Windows.Forms.Button btSetting;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label statusTotalDone;
        private System.Windows.Forms.Label statusTotalWaiting;
        private System.Windows.Forms.Button btDisplayStatus;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnGoiUuTien;
        private System.Windows.Forms.Button btFinish;
        private System.Windows.Forms.Button btTranfer;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btRecall;
        private System.Windows.Forms.Button btCallAnyTicket;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbWaiting;
        private System.Windows.Forms.TextBox txtParam;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lbCurrentTicket;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btActive;
        private System.Windows.Forms.Timer timerDocAmThanh;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbQualuot;
        private System.Windows.Forms.Timer timerLBQualuot;
    }
}