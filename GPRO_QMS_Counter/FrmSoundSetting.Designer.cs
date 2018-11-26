using GPRO_QMS_Counter.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace GPRO_QMS_Counter
{
    partial class FrmSoundSetting
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.txtSound = new System.Windows.Forms.TextBox();
            this.btBrowse = new System.Windows.Forms.Button();
            this.btPlaySound = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btTicketSound = new System.Windows.Forms.Button();
            this.btSetDeskNumber = new System.Windows.Forms.Button();
            this.lvFiles = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ttSound = new System.Windows.Forms.ToolTip(this.components);
            this.lstSetOfSound = new System.Windows.Forms.ListBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thư mục âm thanh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Âm thanh mời giao dịch:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(438, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chèn số vé:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(438, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 39);
            this.label4.TabIndex = 8;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPath
            // 
            this.txtPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.Location = new System.Drawing.Point(155, 32);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(277, 22);
            this.txtPath.TabIndex = 1;
            // 
            // txtSound
            // 
            this.txtSound.BackColor = System.Drawing.Color.White;
            this.txtSound.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSound.ForeColor = System.Drawing.Color.Red;
            this.txtSound.Location = new System.Drawing.Point(31, 239);
            this.txtSound.Multiline = true;
            this.txtSound.Name = "txtSound";
            this.txtSound.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSound.Size = new System.Drawing.Size(401, 64);
            this.txtSound.TabIndex = 1;
            this.txtSound.TextChanged += new System.EventHandler(this.txtSound_TextChanged);
            this.txtSound.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSound_KeyPress);
            // 
            // btBrowse
            // 
            this.btBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBrowse.Location = new System.Drawing.Point(438, 32);
            this.btBrowse.Name = "btBrowse";
            this.btBrowse.Size = new System.Drawing.Size(35, 22);
            this.btBrowse.TabIndex = 2;
            this.btBrowse.Text = "...";
            this.btBrowse.UseVisualStyleBackColor = true;
            this.btBrowse.Click += new System.EventHandler(this.btBrowse_Click);
            // 
            // btPlaySound
            // 
            this.btPlaySound.BackgroundImage = global::GPRO_QMS_Counter.Properties.Resources.trySound;
            this.btPlaySound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btPlaySound.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPlaySound.Location = new System.Drawing.Point(438, 239);
            this.btPlaySound.Name = "btPlaySound";
            this.btPlaySound.Size = new System.Drawing.Size(125, 64);
            this.btPlaySound.TabIndex = 2;
            this.ttSound.SetToolTip(this.btPlaySound, "Nghe thử âm thanh mời giao dịch");
            this.btPlaySound.UseVisualStyleBackColor = true;
            this.btPlaySound.Click += new System.EventHandler(this.btPlaySound_Click);
            // 
            // btSave
            // 
            this.btSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.Location = new System.Drawing.Point(307, 321);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(125, 33);
            this.btSave.TabIndex = 2;
            this.btSave.Text = "Đồng ý";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btCancel
            // 
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.Location = new System.Drawing.Point(438, 321);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(125, 33);
            this.btCancel.TabIndex = 2;
            this.btCancel.Text = "Hủy";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btTicketSound
            // 
            this.btTicketSound.BackColor = System.Drawing.Color.White;
            this.btTicketSound.BackgroundImage = global::GPRO_QMS_Counter.Properties.Resources.ticketSound;
            this.btTicketSound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btTicketSound.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTicketSound.Location = new System.Drawing.Point(498, 135);
            this.btTicketSound.Name = "btTicketSound";
            this.btTicketSound.Size = new System.Drawing.Size(65, 62);
            this.btTicketSound.TabIndex = 2;
            this.ttSound.SetToolTip(this.btTicketSound, "Chèn thêm Âm thanh số vé");
            this.btTicketSound.UseVisualStyleBackColor = false;
            this.btTicketSound.Visible = false;
            this.btTicketSound.Click += new System.EventHandler(this.btTicketSound_Click);
            // 
            // btSetDeskNumber
            // 
            this.btSetDeskNumber.BackColor = System.Drawing.Color.LightGray;
            this.btSetDeskNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSetDeskNumber.ForeColor = System.Drawing.Color.Maroon;
            this.btSetDeskNumber.Location = new System.Drawing.Point(31, 321);
            this.btSetDeskNumber.Name = "btSetDeskNumber";
            this.btSetDeskNumber.Size = new System.Drawing.Size(153, 33);
            this.btSetDeskNumber.TabIndex = 5;
            this.btSetDeskNumber.Text = "...Âm thanh đọc số";
            this.ttSound.SetToolTip(this.btSetDeskNumber, "Thêm bộ âm thanh đọc số ngôn ngữ khác");
            this.btSetDeskNumber.UseVisualStyleBackColor = false;
            this.btSetDeskNumber.Click += new System.EventHandler(this.btSetDeskNumber_Click);
            // 
            // lvFiles
            // 
            this.lvFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvFiles.LargeImageList = this.imageList1;
            this.lvFiles.Location = new System.Drawing.Point(31, 62);
            this.lvFiles.MultiSelect = false;
            this.lvFiles.Name = "lvFiles";
            this.lvFiles.Size = new System.Drawing.Size(401, 135);
            this.lvFiles.SmallImageList = this.imageList1;
            this.lvFiles.TabIndex = 3;
            this.ttSound.SetToolTip(this.lvFiles, "Double click để chọn file âm thanh muốn phát");
            this.lvFiles.UseCompatibleStateImageBehavior = false;
            this.lvFiles.View = System.Windows.Forms.View.SmallIcon;
            this.lvFiles.DoubleClick += new System.EventHandler(this.lvFiles_DoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lstSetOfSound
            // 
            this.lstSetOfSound.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSetOfSound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lstSetOfSound.FormattingEnabled = true;
            this.lstSetOfSound.ItemHeight = 16;
            this.lstSetOfSound.Items.AddRange(new object[] {
            "Tiếng Việt",
            "Tiếng Anh",
            "Tiếng Pháp"});
            this.lstSetOfSound.Location = new System.Drawing.Point(438, 129);
            this.lstSetOfSound.Name = "lstSetOfSound";
            this.lstSetOfSound.Size = new System.Drawing.Size(125, 68);
            this.lstSetOfSound.TabIndex = 6;
            this.ttSound.SetToolTip(this.lstSetOfSound, "Double click để Chèn bộ ngôn ngữ đọc âm thanh số vé");
            this.lstSetOfSound.DoubleClick += new System.EventHandler(this.lstSetOfSound_DoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GPRO_QMS_Counter.Properties.Resources.ticketSound;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(459, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 43);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FrmSoundSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lstSetOfSound);
            this.Controls.Add(this.lvFiles);
            this.Controls.Add(this.btSetDeskNumber);
            this.Controls.Add(this.btTicketSound);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btPlaySound);
            this.Controls.Add(this.btBrowse);
            this.Controls.Add(this.txtSound);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "FrmSoundSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cài đặt âm thanh mới tại quầy";
            this.Load += new System.EventHandler(this.FrmSoundSetting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
         
        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.TextBox txtSound;
        private System.Windows.Forms.Button btBrowse;
        private System.Windows.Forms.Button btPlaySound;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btTicketSound;
        private System.Windows.Forms.Button btSetDeskNumber;
        private System.Windows.Forms.ListView lvFiles;
        private System.Windows.Forms.ToolTip ttSound;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListBox lstSetOfSound;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}