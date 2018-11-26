using System.Drawing;
using System.Windows.Forms;
namespace GPRO_QMS_Counter
{
    partial class FrmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegister));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSetupID = new System.Windows.Forms.TextBox();
            this.txtLicenseKey = new System.Windows.Forms.TextBox();
            this.btExit = new System.Windows.Forms.Button();
            this.btRegister = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(73, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "CHÀO MỪNG BẠN ĐẾN VỚI PHẦN MỀM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(126, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã cài đặt của bạn là:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(26, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(362, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "ĐIỀU KHIỂN GỌI SỐ - GPRO QMS COUNTER SOFT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Cyan;
            this.label4.Location = new System.Drawing.Point(126, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(278, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Vui lòng nhập mã kích hoạt để đăng ký:";
            // 
            // txtSetupID
            // 
            this.txtSetupID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSetupID.Location = new System.Drawing.Point(129, 152);
            this.txtSetupID.Name = "txtSetupID";
            this.txtSetupID.Size = new System.Drawing.Size(275, 22);
            this.txtSetupID.TabIndex = 2;
            // 
            // txtLicenseKey
            // 
            this.txtLicenseKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLicenseKey.Location = new System.Drawing.Point(130, 202);
            this.txtLicenseKey.Name = "txtLicenseKey";
            this.txtLicenseKey.Size = new System.Drawing.Size(275, 22);
            this.txtLicenseKey.TabIndex = 2;
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.AliceBlue;
            this.btExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.Color.Navy;
            this.btExit.Location = new System.Drawing.Point(316, 235);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(90, 32);
            this.btExit.TabIndex = 18;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btRegister
            // 
            this.btRegister.BackColor = System.Drawing.Color.AliceBlue;
            this.btRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegister.ForeColor = System.Drawing.Color.Navy;
            this.btRegister.Location = new System.Drawing.Point(218, 235);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(90, 32);
            this.btRegister.TabIndex = 17;
            this.btRegister.Text = "Đăng ký";
            this.btRegister.UseVisualStyleBackColor = true;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = global::GPRO_QMS_Counter.Properties.Resources.checklist__1_;
            this.pictureBox2.Location = new System.Drawing.Point(6, 95);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(118, 129);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::GPRO_QMS_Counter.Properties.Resources.Register_now_PNG_Overlay;
            this.pictureBox1.Location = new System.Drawing.Point(118, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(429, 282);
            this.Controls.Add(this.btRegister);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.txtLicenseKey);
            this.Controls.Add(this.txtSetupID);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đăng ký sử dụng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmRegister_FormClosing);
            this.Load += new System.EventHandler(this.FrmRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtSetupID;
        private System.Windows.Forms.TextBox txtLicenseKey;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btRegister;
    }
}