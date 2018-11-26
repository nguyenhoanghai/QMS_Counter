namespace GPRO_QMS_Counter
{
    partial class FrmUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.txtCM = new System.Windows.Forms.TextBox();
            this.txtCV = new System.Windows.Forms.TextBox();
            this.txtQTCT = new System.Windows.Forms.TextBox();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.btchoose = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pb_img = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_img)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(221, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Giới tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(221, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chuyên môn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(221, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Chức vụ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(221, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "QT công tác";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(221, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Địa chỉ";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(315, 11);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(268, 22);
            this.txtName.TabIndex = 8;
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rbNam.Location = new System.Drawing.Point(315, 39);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(47, 17);
            this.rbNam.TabIndex = 9;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Location = new System.Drawing.Point(379, 39);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(39, 17);
            this.rbNu.TabIndex = 10;
            this.rbNu.TabStop = true;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // txtCM
            // 
            this.txtCM.Location = new System.Drawing.Point(315, 62);
            this.txtCM.Multiline = true;
            this.txtCM.Name = "txtCM";
            this.txtCM.Size = new System.Drawing.Size(268, 43);
            this.txtCM.TabIndex = 11;
            // 
            // txtCV
            // 
            this.txtCV.Location = new System.Drawing.Point(315, 115);
            this.txtCV.Multiline = true;
            this.txtCV.Name = "txtCV";
            this.txtCV.Size = new System.Drawing.Size(268, 43);
            this.txtCV.TabIndex = 12;
            // 
            // txtQTCT
            // 
            this.txtQTCT.Location = new System.Drawing.Point(315, 164);
            this.txtQTCT.Multiline = true;
            this.txtQTCT.Name = "txtQTCT";
            this.txtQTCT.Size = new System.Drawing.Size(268, 43);
            this.txtQTCT.TabIndex = 13;
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(315, 213);
            this.txtAdd.Multiline = true;
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(268, 43);
            this.txtAdd.TabIndex = 14;
            // 
            // btchoose
            // 
            this.btchoose.Location = new System.Drawing.Point(12, 221);
            this.btchoose.Name = "btchoose";
            this.btchoose.Size = new System.Drawing.Size(193, 35);
            this.btchoose.TabIndex = 15;
            this.btchoose.Text = "Chọn hình";
            this.btchoose.UseVisualStyleBackColor = true;
            this.btchoose.Click += new System.EventHandler(this.btchoose_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(83, 274);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(193, 35);
            this.btSave.TabIndex = 16;
            this.btSave.Text = "Lưu thay đổi";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(315, 274);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(193, 35);
            this.btClose.TabIndex = 17;
            this.btClose.Text = "Đóng";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pb_img
            // 
            this.pb_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_img.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_img.ErrorImage = global::GPRO_QMS_Counter.Properties.Resources.if_connect_no_5995;
            this.pb_img.Location = new System.Drawing.Point(12, 14);
            this.pb_img.Name = "pb_img";
            this.pb_img.Size = new System.Drawing.Size(193, 201);
            this.pb_img.TabIndex = 0;
            this.pb_img.TabStop = false;
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 323);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btchoose);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.txtQTCT);
            this.Controls.Add(this.txtCV);
            this.Controls.Add(this.txtCM);
            this.Controls.Add(this.rbNu);
            this.Controls.Add(this.rbNam);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_img);
            this.Name = "FrmUser";
            this.Text = "Cập nhật thông tin";
            this.Load += new System.EventHandler(this.FrmUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_img;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.TextBox txtCM;
        private System.Windows.Forms.TextBox txtCV;
        private System.Windows.Forms.TextBox txtQTCT;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.Button btchoose;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}