namespace GPRO_QMS_Counter
{
    partial class FrmMain3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain3));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbCounterName = new System.Windows.Forms.Label();
            this.lbGeneralWaiting = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbWaiting = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCurrentTicket = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btTranfer = new System.Windows.Forms.Button();
            this.btCallAnyTicket = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btFinish = new System.Windows.Forms.Button();
            this.btRecall = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.txtParam = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusStaffName = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLoginTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusTotalWaiting = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusTotalDone = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Navy;
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
            this.splitContainer1.Panel2.Controls.Add(this.btTranfer);
            this.splitContainer1.Panel2.Controls.Add(this.btCallAnyTicket);
            this.splitContainer1.Panel2.Controls.Add(this.btCancel);
            this.splitContainer1.Panel2.Controls.Add(this.btFinish);
            this.splitContainer1.Panel2.Controls.Add(this.btRecall);
            this.splitContainer1.Panel2.Controls.Add(this.btNext);
            this.splitContainer1.Panel2.Controls.Add(this.txtParam);
            this.splitContainer1.Panel2.Controls.Add(this.txtResult);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Size = new System.Drawing.Size(1167, 516);
            this.splitContainer1.SplitterDistance = 665;
            this.splitContainer1.TabIndex = 0;
            // 
            // lbCounterName
            // 
            this.lbCounterName.AutoSize = true;
            this.lbCounterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCounterName.ForeColor = System.Drawing.Color.Lime;
            this.lbCounterName.Location = new System.Drawing.Point(4, 9);
            this.lbCounterName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCounterName.Name = "lbCounterName";
            this.lbCounterName.Size = new System.Drawing.Size(198, 46);
            this.lbCounterName.TabIndex = 8;
            this.lbCounterName.Text = "Bàn 0000";
            this.lbCounterName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbGeneralWaiting
            // 
            this.lbGeneralWaiting.AutoSize = true;
            this.lbGeneralWaiting.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGeneralWaiting.ForeColor = System.Drawing.Color.White;
            this.lbGeneralWaiting.Location = new System.Drawing.Point(4, 456);
            this.lbGeneralWaiting.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGeneralWaiting.Name = "lbGeneralWaiting";
            this.lbGeneralWaiting.Size = new System.Drawing.Size(43, 46);
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
            this.label3.Location = new System.Drawing.Point(3, 408);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(661, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "ĐANG ĐỢI CHUNG";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbWaiting
            // 
            this.lbWaiting.AutoSize = true;
            this.lbWaiting.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWaiting.ForeColor = System.Drawing.Color.White;
            this.lbWaiting.Location = new System.Drawing.Point(4, 350);
            this.lbWaiting.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbWaiting.Name = "lbWaiting";
            this.lbWaiting.Size = new System.Drawing.Size(43, 46);
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
            this.label2.Location = new System.Drawing.Point(3, 311);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(663, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "ĐANG ĐỢI TẠI QUẦY";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCurrentTicket
            // 
            this.lbCurrentTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentTicket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbCurrentTicket.Location = new System.Drawing.Point(0, 105);
            this.lbCurrentTicket.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCurrentTicket.Name = "lbCurrentTicket";
            this.lbCurrentTicket.Size = new System.Drawing.Size(666, 206);
            this.lbCurrentTicket.TabIndex = 2;
            this.lbCurrentTicket.Text = "0000";
            this.lbCurrentTicket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(663, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "ĐANG GIAO DỊCH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btTranfer
            // 
            this.btTranfer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btTranfer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTranfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTranfer.ForeColor = System.Drawing.Color.Navy;
            this.btTranfer.Image = ((System.Drawing.Image)(resources.GetObject("btTranfer.Image")));
            this.btTranfer.Location = new System.Drawing.Point(172, 384);
            this.btTranfer.Margin = new System.Windows.Forms.Padding(4);
            this.btTranfer.Name = "btTranfer";
            this.btTranfer.Size = new System.Drawing.Size(156, 121);
            this.btTranfer.TabIndex = 24;
            this.btTranfer.Text = "Chuyển";
            this.btTranfer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btTranfer.UseVisualStyleBackColor = true;
            this.btTranfer.Click += new System.EventHandler(this.btTranfer_Click);
            // 
            // btCallAnyTicket
            // 
            this.btCallAnyTicket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btCallAnyTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCallAnyTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCallAnyTicket.ForeColor = System.Drawing.Color.Navy;
            this.btCallAnyTicket.Image = ((System.Drawing.Image)(resources.GetObject("btCallAnyTicket.Image")));
            this.btCallAnyTicket.Location = new System.Drawing.Point(339, 255);
            this.btCallAnyTicket.Margin = new System.Windows.Forms.Padding(4);
            this.btCallAnyTicket.Name = "btCallAnyTicket";
            this.btCallAnyTicket.Size = new System.Drawing.Size(155, 121);
            this.btCallAnyTicket.TabIndex = 23;
            this.btCallAnyTicket.Text = "Gọi bất kỳ";
            this.btCallAnyTicket.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCallAnyTicket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btCallAnyTicket.UseVisualStyleBackColor = true;
            this.btCallAnyTicket.Click += new System.EventHandler(this.btCallAnyTicket_Click);
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.ForeColor = System.Drawing.Color.Navy;
            this.btCancel.Image = ((System.Drawing.Image)(resources.GetObject("btCancel.Image")));
            this.btCancel.Location = new System.Drawing.Point(338, 384);
            this.btCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(156, 121);
            this.btCancel.TabIndex = 22;
            this.btCancel.Text = "Hủy";
            this.btCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btFinish
            // 
            this.btFinish.BackColor = System.Drawing.SystemColors.Control;
            this.btFinish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btFinish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btFinish.ForeColor = System.Drawing.Color.Navy;
            this.btFinish.Image = ((System.Drawing.Image)(resources.GetObject("btFinish.Image")));
            this.btFinish.Location = new System.Drawing.Point(9, 384);
            this.btFinish.Margin = new System.Windows.Forms.Padding(4);
            this.btFinish.Name = "btFinish";
            this.btFinish.Size = new System.Drawing.Size(155, 121);
            this.btFinish.TabIndex = 21;
            this.btFinish.Text = "Hoàn tất";
            this.btFinish.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btFinish.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btFinish.UseVisualStyleBackColor = false;
            this.btFinish.Click += new System.EventHandler(this.btFinish_Click);
            // 
            // btRecall
            // 
            this.btRecall.BackColor = System.Drawing.SystemColors.Control;
            this.btRecall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btRecall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRecall.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRecall.ForeColor = System.Drawing.Color.Navy;
            this.btRecall.Image = ((System.Drawing.Image)(resources.GetObject("btRecall.Image")));
            this.btRecall.Location = new System.Drawing.Point(172, 255);
            this.btRecall.Margin = new System.Windows.Forms.Padding(4);
            this.btRecall.Name = "btRecall";
            this.btRecall.Size = new System.Drawing.Size(156, 121);
            this.btRecall.TabIndex = 20;
            this.btRecall.Text = "  Nhắc lại";
            this.btRecall.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btRecall.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btRecall.UseVisualStyleBackColor = false;
            this.btRecall.Click += new System.EventHandler(this.btRecall_Click);
            // 
            // btNext
            // 
            this.btNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNext.ForeColor = System.Drawing.Color.Navy;
            this.btNext.Image = ((System.Drawing.Image)(resources.GetObject("btNext.Image")));
            this.btNext.Location = new System.Drawing.Point(7, 255);
            this.btNext.Margin = new System.Windows.Forms.Padding(4);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(156, 121);
            this.btNext.TabIndex = 19;
            this.btNext.Text = "Gọi tiếp theo";
            this.btNext.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // txtParam
            // 
            this.txtParam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtParam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParam.Location = new System.Drawing.Point(5, 32);
            this.txtParam.Margin = new System.Windows.Forms.Padding(4);
            this.txtParam.MaxLength = 10;
            this.txtParam.Name = "txtParam";
            this.txtParam.Size = new System.Drawing.Size(489, 26);
            this.txtParam.TabIndex = 17;
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.BackColor = System.Drawing.Color.White;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(7, 96);
            this.txtResult.Margin = new System.Windows.Forms.Padding(4);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(488, 151);
            this.txtResult.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 69);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Kết quả";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Nhập  yêu cầu";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStaffName,
            this.statusLoginTime,
            this.statusTotalWaiting,
            this.statusTotalDone});
            this.statusStrip1.Location = new System.Drawing.Point(0, 518);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1167, 24);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusStaffName
            // 
            this.statusStaffName.AutoSize = false;
            this.statusStaffName.Name = "statusStaffName";
            this.statusStaffName.Size = new System.Drawing.Size(250, 19);
            this.statusStaffName.Text = "Nhân viên: Trần Văn Anh";
            this.statusStaffName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusLoginTime
            // 
            this.statusLoginTime.AutoSize = false;
            this.statusLoginTime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statusLoginTime.Name = "statusLoginTime";
            this.statusLoginTime.Size = new System.Drawing.Size(240, 19);
            this.statusLoginTime.Text = "Đăng nhập lúc: 08:00:00 ngày 01/01/2012";
            // 
            // statusTotalWaiting
            // 
            this.statusTotalWaiting.AutoSize = false;
            this.statusTotalWaiting.Name = "statusTotalWaiting";
            this.statusTotalWaiting.Size = new System.Drawing.Size(100, 19);
            this.statusTotalWaiting.Text = "Đang đợi: 5";
            this.statusTotalWaiting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusTotalDone
            // 
            this.statusTotalDone.AutoSize = false;
            this.statusTotalDone.Name = "statusTotalDone";
            this.statusTotalDone.Size = new System.Drawing.Size(100, 19);
            this.statusTotalDone.Text = "Đã giao dịch: 20";
            this.statusTotalDone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmMain3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1167, 542);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmMain3";
            this.Text = "Quầy gọi số";
            this.Load += new System.EventHandler(this.FrmMain3_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCurrentTicket;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbWaiting;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbCounterName;
        private System.Windows.Forms.Label lbGeneralWaiting;
        private System.Windows.Forms.TextBox txtParam;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btRecall;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btFinish;
        private System.Windows.Forms.Button btTranfer;
        private System.Windows.Forms.Button btCallAnyTicket;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusStaffName;
        private System.Windows.Forms.ToolStripStatusLabel statusLoginTime;
        private System.Windows.Forms.ToolStripStatusLabel statusTotalWaiting;
        private System.Windows.Forms.ToolStripStatusLabel statusTotalDone;
    }
}