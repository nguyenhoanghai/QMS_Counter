namespace GPRO_QMS_Counter
{
    partial class FrmPrintTicket
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.txtDOB = new System.Windows.Forms.NumericUpDown();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gServices = new DevExpress.XtraEditors.GroupControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDOB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gServices)).BeginInit();
            this.gServices.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1148, 401);
            this.panel1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtma);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.txtAdd);
            this.groupControl1.Controls.Add(this.txtDOB);
            this.groupControl1.Controls.Add(this.txtname);
            this.groupControl1.Controls.Add(this.label10);
            this.groupControl1.Controls.Add(this.label9);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Location = new System.Drawing.Point(5, 5);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1152, 100);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin chung";
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(91, 30);
            this.txtma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(209, 23);
            this.txtma.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(8, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Mã KH";
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(411, 57);
            this.txtAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAdd.Multiline = true;
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(736, 38);
            this.txtAdd.TabIndex = 23;
            // 
            // txtDOB
            // 
            this.txtDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDOB.Location = new System.Drawing.Point(411, 30);
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
            this.txtDOB.Size = new System.Drawing.Size(88, 24);
            this.txtDOB.TabIndex = 22;
            this.txtDOB.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(91, 57);
            this.txtname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(209, 23);
            this.txtname.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label10.Location = new System.Drawing.Point(328, 66);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Địa chỉ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(328, 32);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Năm sinh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(8, 63);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Họ tên";
            // 
            // gServices
            // 
            this.gServices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gServices.Controls.Add(this.panel1);
            this.gServices.Location = new System.Drawing.Point(5, 109);
            this.gServices.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gServices.Name = "gServices";
            this.gServices.Size = new System.Drawing.Size(1152, 428);
            this.gServices.TabIndex = 1;
            this.gServices.Text = "Dịch vụ";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmPrintTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 542);
            this.Controls.Add(this.gServices);
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmPrintTicket";
            this.Text = "Cấp phiếu";
            this.Load += new System.EventHandler(this.FrmPrintTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDOB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gServices)).EndInit();
            this.gServices.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.GroupControl gServices;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.NumericUpDown txtDOB;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
    }
}