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
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btTranfer = new System.Windows.Forms.Button();
            this.btRecall = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbBNinfo = new System.Windows.Forms.Label();
            this.lbCurrentTicket = new System.Windows.Forms.Label();
            this.btCallAnyTicket = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerDocAmThanh = new System.Windows.Forms.Timer(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnGoiUuTien = new System.Windows.Forms.Button();
            this.btActive = new System.Windows.Forms.Button();
            this.circlePictureBox1 = new GPRO_QMS_Counter.CirclePictureBox();
            this.btTemplate = new System.Windows.Forms.Button();
            this.btConnectSQL = new System.Windows.Forms.Button();
            this.btSetting = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btDisplayStatus = new System.Windows.Forms.Button();
            this.timerLBQualuot = new System.Windows.Forms.Timer(this.components);
          //  this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circlePictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
          //  ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(34, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "GPRO Gọi số - Hệ thống xếp hàng tự động - Hữu Nghị";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label2_MouseDown);
            // 
            // statusTotalDone
            // 
            this.statusTotalDone.AutoSize = true;
            this.statusTotalDone.Font = new System.Drawing.Font("Arial", 10.2F);
            this.statusTotalDone.ForeColor = System.Drawing.Color.Yellow;
            this.statusTotalDone.Location = new System.Drawing.Point(237, 7);
            this.statusTotalDone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statusTotalDone.Name = "statusTotalDone";
            this.statusTotalDone.Size = new System.Drawing.Size(107, 16);
            this.statusTotalDone.TabIndex = 33;
            this.statusTotalDone.Text = "Đã giao dịch : 0";
            // 
            // statusTotalWaiting
            // 
            this.statusTotalWaiting.AutoSize = true;
            this.statusTotalWaiting.Font = new System.Drawing.Font("Arial", 10.2F);
            this.statusTotalWaiting.ForeColor = System.Drawing.Color.Yellow;
            this.statusTotalWaiting.Location = new System.Drawing.Point(137, 7);
            this.statusTotalWaiting.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statusTotalWaiting.Name = "statusTotalWaiting";
            this.statusTotalWaiting.Size = new System.Drawing.Size(86, 16);
            this.statusTotalWaiting.TabIndex = 32;
            this.statusTotalWaiting.Text = "Đang đợi : 0";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(82, 31);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(378, 534);
            this.panel5.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(68)))), ((int)(((byte)(114)))));
            this.panel6.Controls.Add(this.panel12);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(378, 534);
            this.panel6.TabIndex = 32;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.panel9);
            this.panel12.Controls.Add(this.panel8);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(0, 176);
            this.panel12.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(378, 358);
            this.panel12.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.dataGridView1);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(378, 259);
            this.panel9.TabIndex = 40;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(378, 259);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btTranfer);
            this.panel8.Controls.Add(this.btRecall);
            this.panel8.Controls.Add(this.btNext);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 259);
            this.panel8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(378, 99);
            this.panel8.TabIndex = 2;
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
            this.btTranfer.Location = new System.Drawing.Point(265, 8);
            this.btTranfer.Name = "btTranfer";
            this.btTranfer.Size = new System.Drawing.Size(105, 89);
            this.btTranfer.TabIndex = 39;
            this.btTranfer.Text = "Qua lượt";
            this.btTranfer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btTranfer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btTranfer.UseVisualStyleBackColor = false;
            this.btTranfer.Click += new System.EventHandler(this.btTranfer_Click);
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
            this.btRecall.Location = new System.Drawing.Point(136, 8);
            this.btRecall.Name = "btRecall";
            this.btRecall.Size = new System.Drawing.Size(105, 89);
            this.btRecall.TabIndex = 35;
            this.btRecall.Text = "  Nhắc lại";
            this.btRecall.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btRecall.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btRecall.UseVisualStyleBackColor = false;
            this.btRecall.Click += new System.EventHandler(this.btRecall_Click);
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
            this.btNext.Location = new System.Drawing.Point(9, 9);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(105, 89);
            this.btNext.TabIndex = 34;
            this.btNext.Text = "Gọi BN";
            this.btNext.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btNext.UseVisualStyleBackColor = false;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lbBNinfo);
            this.panel7.Controls.Add(this.lbCurrentTicket);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(378, 176);
            this.panel7.TabIndex = 0;
            // 
            // lbBNinfo
            // 
            this.lbBNinfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbBNinfo.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBNinfo.ForeColor = System.Drawing.Color.GreenYellow;
            this.lbBNinfo.Location = new System.Drawing.Point(0, 117);
            this.lbBNinfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBNinfo.Name = "lbBNinfo";
            this.lbBNinfo.Size = new System.Drawing.Size(378, 59);
            this.lbBNinfo.TabIndex = 1;
            this.lbBNinfo.Text = "---";
            this.lbBNinfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCurrentTicket
            // 
            this.lbCurrentTicket.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbCurrentTicket.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentTicket.ForeColor = System.Drawing.Color.Yellow;
            this.lbCurrentTicket.Location = new System.Drawing.Point(0, 0);
            this.lbCurrentTicket.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCurrentTicket.Name = "lbCurrentTicket";
            this.lbCurrentTicket.Size = new System.Drawing.Size(378, 117);
            this.lbCurrentTicket.TabIndex = 0;
            this.lbCurrentTicket.Text = "0";
            this.lbCurrentTicket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btCallAnyTicket.Location = new System.Drawing.Point(17, 369);
            this.btCallAnyTicket.Name = "btCallAnyTicket";
            this.btCallAnyTicket.Size = new System.Drawing.Size(75, 92);
            this.btCallAnyTicket.TabIndex = 38;
            this.btCallAnyTicket.Text = "Gọi bất kỳ";
            this.btCallAnyTicket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btCallAnyTicket.UseVisualStyleBackColor = false;
            this.btCallAnyTicket.Visible = false;
            this.btCallAnyTicket.Click += new System.EventHandler(this.btCallAnyTicket_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 15000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerDocAmThanh
            // 
            this.timerDocAmThanh.Interval = 1000;
            this.timerDocAmThanh.Tick += new System.EventHandler(this.timerDocAmThanh_Tick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnGoiUuTien);
            this.panel4.Controls.Add(this.btActive);
            this.panel4.Controls.Add(this.circlePictureBox1);
            this.panel4.Controls.Add(this.btTemplate);
            this.panel4.Controls.Add(this.btCallAnyTicket);
            this.panel4.Controls.Add(this.btConnectSQL);
            this.panel4.Controls.Add(this.btSetting);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 31);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(82, 534);
            this.panel4.TabIndex = 1;
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
            this.btnGoiUuTien.Location = new System.Drawing.Point(17, 422);
            this.btnGoiUuTien.Name = "btnGoiUuTien";
            this.btnGoiUuTien.Size = new System.Drawing.Size(75, 92);
            this.btnGoiUuTien.TabIndex = 40;
            this.btnGoiUuTien.Text = "Gọi kết luận";
            this.btnGoiUuTien.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGoiUuTien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGoiUuTien.UseVisualStyleBackColor = false;
            this.btnGoiUuTien.Visible = false;
            this.btnGoiUuTien.Click += new System.EventHandler(this.btnGoiUuTien_Click);
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
            this.btActive.Location = new System.Drawing.Point(0, 307);
            this.btActive.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btActive.Name = "btActive";
            this.btActive.Size = new System.Drawing.Size(82, 57);
            this.btActive.TabIndex = 14;
            this.btActive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btActive.UseVisualStyleBackColor = true;
            this.btActive.Click += new System.EventHandler(this.btActive_Click);
            // 
            // circlePictureBox1
            // 
            this.circlePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("circlePictureBox1.Image")));
            this.circlePictureBox1.Location = new System.Drawing.Point(8, 7);
            this.circlePictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.circlePictureBox1.Name = "circlePictureBox1";
            this.circlePictureBox1.Size = new System.Drawing.Size(68, 73);
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
            this.btTemplate.Location = new System.Drawing.Point(1, 247);
            this.btTemplate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btTemplate.Name = "btTemplate";
            this.btTemplate.Size = new System.Drawing.Size(82, 57);
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
            this.btConnectSQL.Location = new System.Drawing.Point(1, 180);
            this.btConnectSQL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btConnectSQL.Name = "btConnectSQL";
            this.btConnectSQL.Size = new System.Drawing.Size(82, 57);
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
            this.btSetting.Location = new System.Drawing.Point(1, 119);
            this.btSetting.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btSetting.Name = "btSetting";
            this.btSetting.Size = new System.Drawing.Size(82, 57);
            this.btSetting.TabIndex = 12;
            this.btSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btSetting.UseVisualStyleBackColor = true;
            this.btSetting.Click += new System.EventHandler(this.btSetting_Click);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 597);
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
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(460, 31);
            this.panel3.TabIndex = 0;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = global::GPRO_QMS_Counter.Properties.Resources.minimazar;
            this.btnMinimize.Location = new System.Drawing.Point(411, 6);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(16, 18);
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
            this.btnClose.Location = new System.Drawing.Point(434, 6);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(16, 18);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 8;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GPRO_QMS_Counter.Properties.Resources._1499069963_headphone;
            this.pictureBox1.Location = new System.Drawing.Point(4, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.statusTotalDone);
            this.panel2.Controls.Add(this.statusTotalWaiting);
            this.panel2.Controls.Add(this.btDisplayStatus);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 565);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(460, 32);
            this.panel2.TabIndex = 0;
            this.panel2.Visible = false;
            // 
            // btDisplayStatus
            // 
            this.btDisplayStatus.FlatAppearance.BorderSize = 0;
            this.btDisplayStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDisplayStatus.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDisplayStatus.ForeColor = System.Drawing.Color.Yellow;
            this.btDisplayStatus.Image = global::GPRO_QMS_Counter.Properties.Resources.com_port_dis;
            this.btDisplayStatus.Location = new System.Drawing.Point(2, 2);
            this.btDisplayStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btDisplayStatus.Name = "btDisplayStatus";
            this.btDisplayStatus.Size = new System.Drawing.Size(130, 27);
            this.btDisplayStatus.TabIndex = 30;
            this.btDisplayStatus.Text = "Display COM";
            this.btDisplayStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btDisplayStatus.UseVisualStyleBackColor = true;
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 53;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "MaBN";
            this.Column1.HeaderText = "Mã y tế";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 67;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenBN";
            this.Column2.HeaderText = "Tên BN";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column3.DataPropertyName = "NamSinh";
            this.Column3.HeaderText = "Năm sinh";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 76;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column4.DataPropertyName = "TrangThai";
            this.Column4.HeaderText = "Trạng thái";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 80;
            // 
            // FrmPhongKhamHuuNghi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 597);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmPhongKhamHuuNghi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPhongKhamHuuNghi";
            this.Load += new System.EventHandler(this.FrmPhongKhamHuuNghi_Load);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.circlePictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
          //  ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
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
        private System.Windows.Forms.Button btTranfer;
        private System.Windows.Forms.Button btRecall;
        private System.Windows.Forms.Button btCallAnyTicket;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lbCurrentTicket;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btActive;
        private System.Windows.Forms.Timer timerDocAmThanh;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timerLBQualuot;
       // private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.Button btnGoiUuTien;
        private System.Windows.Forms.Label lbBNinfo;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}