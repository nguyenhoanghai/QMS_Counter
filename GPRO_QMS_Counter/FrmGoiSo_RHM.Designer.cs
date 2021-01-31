namespace GPRO_QMS_Counter
{
    partial class FrmGoiSo_RHM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGoiSo_RHM));
            this.btCallAnyTicket = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.cbGhe = new System.Windows.Forms.ComboBox();
            this.statusTotalDone = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusTotalWaiting = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLoginTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStaffName = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btRecall = new System.Windows.Forms.Button();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.txtParam = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbCounterName = new System.Windows.Forms.Label();
            this.lbGeneralWaiting = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbWaiting = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCurrentTicket = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btCallany_KM = new System.Windows.Forms.Button();
            this.btnRecall_KM = new System.Windows.Forms.Button();
            this.btnNext_KM = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCallAnyTicket
            // 
            this.btCallAnyTicket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btCallAnyTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCallAnyTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCallAnyTicket.ForeColor = System.Drawing.Color.Navy;
            this.btCallAnyTicket.Image = ((System.Drawing.Image)(resources.GetObject("btCallAnyTicket.Image")));
            this.btCallAnyTicket.Location = new System.Drawing.Point(254, 177);
            this.btCallAnyTicket.Name = "btCallAnyTicket";
            this.btCallAnyTicket.Size = new System.Drawing.Size(116, 98);
            this.btCallAnyTicket.TabIndex = 23;
            this.btCallAnyTicket.Text = "Gọi bất kỳ";
            this.btCallAnyTicket.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCallAnyTicket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btCallAnyTicket.UseVisualStyleBackColor = true;
            this.btCallAnyTicket.Click += new System.EventHandler(this.btCallAnyTicket_Click);
            // 
            // btNext
            // 
            this.btNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNext.ForeColor = System.Drawing.Color.Navy;
            this.btNext.Image = ((System.Drawing.Image)(resources.GetObject("btNext.Image")));
            this.btNext.Location = new System.Drawing.Point(5, 177);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(117, 98);
            this.btNext.TabIndex = 19;
            this.btNext.Text = "Gọi tiếp theo";
            this.btNext.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // cbGhe
            // 
            this.cbGhe.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGhe.FormattingEnabled = true;
            this.cbGhe.Location = new System.Drawing.Point(179, 7);
            this.cbGhe.Name = "cbGhe";
            this.cbGhe.Size = new System.Drawing.Size(316, 39);
            this.cbGhe.TabIndex = 9;
            this.cbGhe.SelectedIndexChanged += new System.EventHandler(this.cbGhe_SelectedIndexChanged);
            // 
            // statusTotalDone
            // 
            this.statusTotalDone.AutoSize = false;
            this.statusTotalDone.Name = "statusTotalDone";
            this.statusTotalDone.Size = new System.Drawing.Size(150, 19);
            this.statusTotalDone.Text = "Đã giao dịch: 20";
            this.statusTotalDone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusTotalWaiting
            // 
            this.statusTotalWaiting.AutoSize = false;
            this.statusTotalWaiting.Name = "statusTotalWaiting";
            this.statusTotalWaiting.Size = new System.Drawing.Size(150, 19);
            this.statusTotalWaiting.Text = "Đang đợi: 5";
            this.statusTotalWaiting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusLoginTime
            // 
            this.statusLoginTime.AutoSize = false;
            this.statusLoginTime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statusLoginTime.Name = "statusLoginTime";
            this.statusLoginTime.Size = new System.Drawing.Size(240, 19);
            this.statusLoginTime.Text = "Đăng nhập lúc: 08:00:00 ngày 01/01/2012";
            this.statusLoginTime.Visible = false;
            // 
            // statusStaffName
            // 
            this.statusStaffName.AutoSize = false;
            this.statusStaffName.Name = "statusStaffName";
            this.statusStaffName.Size = new System.Drawing.Size(150, 19);
            this.statusStaffName.Text = "Nhân viên: Trần Văn Anh";
            this.statusStaffName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStaffName,
            this.statusLoginTime,
            this.statusTotalWaiting,
            this.statusTotalDone});
            this.statusStrip1.Location = new System.Drawing.Point(0, 416);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(875, 24);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btRecall
            // 
            this.btRecall.BackColor = System.Drawing.SystemColors.Control;
            this.btRecall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btRecall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRecall.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRecall.ForeColor = System.Drawing.Color.Navy;
            this.btRecall.Image = ((System.Drawing.Image)(resources.GetObject("btRecall.Image")));
            this.btRecall.Location = new System.Drawing.Point(129, 177);
            this.btRecall.Name = "btRecall";
            this.btRecall.Size = new System.Drawing.Size(117, 98);
            this.btRecall.TabIndex = 20;
            this.btRecall.Text = "  Nhắc lại";
            this.btRecall.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btRecall.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btRecall.UseVisualStyleBackColor = false;
            this.btRecall.Click += new System.EventHandler(this.btRecall_Click);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // txtParam
            // 
            this.txtParam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtParam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParam.Location = new System.Drawing.Point(4, 26);
            this.txtParam.MaxLength = 10;
            this.txtParam.Name = "txtParam";
            this.txtParam.Size = new System.Drawing.Size(373, 22);
            this.txtParam.TabIndex = 17;
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.BackColor = System.Drawing.Color.White;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(5, 78);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(372, 77);
            this.txtResult.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(2, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Kết quả";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(2, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Nhập  yêu cầu";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbCounterName
            // 
            this.lbCounterName.AutoSize = true;
            this.lbCounterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCounterName.ForeColor = System.Drawing.Color.Lime;
            this.lbCounterName.Location = new System.Drawing.Point(3, 7);
            this.lbCounterName.Name = "lbCounterName";
            this.lbCounterName.Size = new System.Drawing.Size(184, 37);
            this.lbCounterName.TabIndex = 8;
            this.lbCounterName.Text = "Chọn ghế: ";
            this.lbCounterName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbGeneralWaiting
            // 
            this.lbGeneralWaiting.AutoSize = true;
            this.lbGeneralWaiting.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGeneralWaiting.ForeColor = System.Drawing.Color.White;
            this.lbGeneralWaiting.Location = new System.Drawing.Point(3, 370);
            this.lbGeneralWaiting.Name = "lbGeneralWaiting";
            this.lbGeneralWaiting.Size = new System.Drawing.Size(36, 37);
            this.lbGeneralWaiting.TabIndex = 6;
            this.lbGeneralWaiting.Text = "0";
            this.lbGeneralWaiting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbGeneralWaiting.TextChanged += new System.EventHandler(this.lbGeneralWaiting_TextChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(2, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(496, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "ĐANG ĐỢI KHÁM MỚI";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbWaiting
            // 
            this.lbWaiting.AutoSize = true;
            this.lbWaiting.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWaiting.ForeColor = System.Drawing.Color.White;
            this.lbWaiting.Location = new System.Drawing.Point(3, 284);
            this.lbWaiting.Name = "lbWaiting";
            this.lbWaiting.Size = new System.Drawing.Size(36, 37);
            this.lbWaiting.TabIndex = 4;
            this.lbWaiting.Text = "0";
            this.lbWaiting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbWaiting.TextChanged += new System.EventHandler(this.lbWaiting_TextChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(2, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(497, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "ĐANG ĐỢI ĐIỀU TRỊ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCurrentTicket
            // 
            this.lbCurrentTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentTicket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbCurrentTicket.Location = new System.Drawing.Point(0, 85);
            this.lbCurrentTicket.Name = "lbCurrentTicket";
            this.lbCurrentTicket.Size = new System.Drawing.Size(500, 167);
            this.lbCurrentTicket.TabIndex = 2;
            this.lbCurrentTicket.Text = "0000";
            this.lbCurrentTicket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "ĐANG GIAO DỊCH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Navy;
            this.splitContainer1.Panel1.Controls.Add(this.cbGhe);
            this.splitContainer1.Panel1.Controls.Add(this.lbCounterName);
            this.splitContainer1.Panel1.Controls.Add(this.lbGeneralWaiting);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.lbWaiting);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.lbCurrentTicket);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Navy;
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.btCallany_KM);
            this.splitContainer1.Panel2.Controls.Add(this.btnRecall_KM);
            this.splitContainer1.Panel2.Controls.Add(this.btnNext_KM);
            this.splitContainer1.Panel2.Controls.Add(this.btCallAnyTicket);
            this.splitContainer1.Panel2.Controls.Add(this.btRecall);
            this.splitContainer1.Panel2.Controls.Add(this.btNext);
            this.splitContainer1.Panel2.Controls.Add(this.txtParam);
            this.splitContainer1.Panel2.Controls.Add(this.txtResult);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Size = new System.Drawing.Size(875, 419);
            this.splitContainer1.SplitterDistance = 498;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(5, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "Nút nhấn gọi bệnh nhân khám mới";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(5, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Nút nhấn gọi bệnh nhân điều trị";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btCallany_KM
            // 
            this.btCallany_KM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btCallany_KM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCallany_KM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCallany_KM.ForeColor = System.Drawing.Color.Red;
            this.btCallany_KM.Image = ((System.Drawing.Image)(resources.GetObject("btCallany_KM.Image")));
            this.btCallany_KM.Location = new System.Drawing.Point(254, 315);
            this.btCallany_KM.Name = "btCallany_KM";
            this.btCallany_KM.Size = new System.Drawing.Size(116, 98);
            this.btCallany_KM.TabIndex = 27;
            this.btCallany_KM.Text = "Gọi bất kỳ";
            this.btCallany_KM.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCallany_KM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btCallany_KM.UseVisualStyleBackColor = true;
            this.btCallany_KM.Click += new System.EventHandler(this.btCallany_KM_Click);
            // 
            // btnRecall_KM
            // 
            this.btnRecall_KM.BackColor = System.Drawing.SystemColors.Control;
            this.btnRecall_KM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRecall_KM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecall_KM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecall_KM.ForeColor = System.Drawing.Color.Red;
            this.btnRecall_KM.Image = ((System.Drawing.Image)(resources.GetObject("btnRecall_KM.Image")));
            this.btnRecall_KM.Location = new System.Drawing.Point(129, 315);
            this.btnRecall_KM.Name = "btnRecall_KM";
            this.btnRecall_KM.Size = new System.Drawing.Size(117, 98);
            this.btnRecall_KM.TabIndex = 26;
            this.btnRecall_KM.Text = "  Nhắc lại";
            this.btnRecall_KM.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRecall_KM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRecall_KM.UseVisualStyleBackColor = false;
            this.btnRecall_KM.Click += new System.EventHandler(this.btnRecall_KM_Click);
            // 
            // btnNext_KM
            // 
            this.btnNext_KM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNext_KM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext_KM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext_KM.ForeColor = System.Drawing.Color.Red;
            this.btnNext_KM.Image = ((System.Drawing.Image)(resources.GetObject("btnNext_KM.Image")));
            this.btnNext_KM.Location = new System.Drawing.Point(5, 315);
            this.btnNext_KM.Name = "btnNext_KM";
            this.btnNext_KM.Size = new System.Drawing.Size(117, 98);
            this.btnNext_KM.TabIndex = 25;
            this.btnNext_KM.Text = "Gọi tiếp theo ";
            this.btnNext_KM.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNext_KM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNext_KM.UseVisualStyleBackColor = true;
            this.btnNext_KM.Click += new System.EventHandler(this.btnNext_KM_Click);
            // 
            // FrmGoiSo_RHM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 440);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FrmGoiSo_RHM";
            this.Text = "Gọi số";
            this.Load += new System.EventHandler(this.FrmGoiSo_RHM_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btCallAnyTicket;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.ComboBox cbGhe;
        private System.Windows.Forms.ToolStripStatusLabel statusTotalDone;
        private System.Windows.Forms.ToolStripStatusLabel statusTotalWaiting;
        private System.Windows.Forms.ToolStripStatusLabel statusLoginTime;
        private System.Windows.Forms.ToolStripStatusLabel statusStaffName;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btRecall;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.TextBox txtParam;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbCounterName;
        private System.Windows.Forms.Label lbGeneralWaiting;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbWaiting;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCurrentTicket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btCallany_KM;
        private System.Windows.Forms.Button btnRecall_KM;
        private System.Windows.Forms.Button btnNext_KM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}