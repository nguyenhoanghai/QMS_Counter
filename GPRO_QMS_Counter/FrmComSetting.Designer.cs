using GPRO_QMS_Counter.Properties;
using System.Drawing;
using System.Windows.Forms;
namespace GPRO_QMS_Counter
{
    partial class FrmComSetting
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.ckUseCounterDisplay = new System.Windows.Forms.CheckBox();
            this.pnCOMSetting = new System.Windows.Forms.Panel();
            this.cbStopBits = new System.Windows.Forms.ComboBox();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.cbDataBits = new System.Windows.Forms.ComboBox();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.cbComPort = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnCOMSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Baud Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "COM Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Data Bits";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Parity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Stop Bits";
            // 
            // btCancel
            // 
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.Location = new System.Drawing.Point(270, 236);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(125, 33);
            this.btCancel.TabIndex = 7;
            this.btCancel.Text = "Hủy";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btSave
            // 
            this.btSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.Location = new System.Drawing.Point(139, 236);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(125, 33);
            this.btSave.TabIndex = 6;
            this.btSave.Text = "Đồng ý";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // ckUseCounterDisplay
            // 
            this.ckUseCounterDisplay.AutoSize = true;
            this.ckUseCounterDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckUseCounterDisplay.Location = new System.Drawing.Point(186, 25);
            this.ckUseCounterDisplay.Name = "ckUseCounterDisplay";
            this.ckUseCounterDisplay.Size = new System.Drawing.Size(174, 20);
            this.ckUseCounterDisplay.TabIndex = 12;
            this.ckUseCounterDisplay.Text = "Có sử dụng Hiển thị quầy";
            this.ckUseCounterDisplay.UseVisualStyleBackColor = true;
            this.ckUseCounterDisplay.CheckedChanged += new System.EventHandler(this.ckUseCounterDisplay_CheckedChanged);
            // 
            // pnCOMSetting
            // 
            this.pnCOMSetting.Controls.Add(this.cbStopBits);
            this.pnCOMSetting.Controls.Add(this.cbParity);
            this.pnCOMSetting.Controls.Add(this.cbDataBits);
            this.pnCOMSetting.Controls.Add(this.cbBaudRate);
            this.pnCOMSetting.Controls.Add(this.cbComPort);
            this.pnCOMSetting.Controls.Add(this.label5);
            this.pnCOMSetting.Controls.Add(this.label4);
            this.pnCOMSetting.Controls.Add(this.label3);
            this.pnCOMSetting.Controls.Add(this.label1);
            this.pnCOMSetting.Controls.Add(this.label2);
            this.pnCOMSetting.Location = new System.Drawing.Point(175, 45);
            this.pnCOMSetting.Name = "pnCOMSetting";
            this.pnCOMSetting.Size = new System.Drawing.Size(230, 175);
            this.pnCOMSetting.TabIndex = 14;
            // 
            // cbStopBits
            // 
            this.cbStopBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStopBits.FormattingEnabled = true;
            this.cbStopBits.Items.AddRange(new object[] {
            "None",
            "One",
            "OnePointFive",
            "Two"});
            this.cbStopBits.Location = new System.Drawing.Point(93, 135);
            this.cbStopBits.Name = "cbStopBits";
            this.cbStopBits.Size = new System.Drawing.Size(125, 24);
            this.cbStopBits.TabIndex = 13;
            // 
            // cbParity
            // 
            this.cbParity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.cbParity.Location = new System.Drawing.Point(93, 105);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(125, 24);
            this.cbParity.TabIndex = 12;
            // 
            // cbDataBits
            // 
            this.cbDataBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDataBits.FormattingEnabled = true;
            this.cbDataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cbDataBits.Location = new System.Drawing.Point(93, 75);
            this.cbDataBits.Name = "cbDataBits";
            this.cbDataBits.Size = new System.Drawing.Size(125, 24);
            this.cbDataBits.TabIndex = 11;
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Items.AddRange(new object[] {
            "110",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200",
            "128000",
            "256000"});
            this.cbBaudRate.Location = new System.Drawing.Point(93, 45);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(125, 24);
            this.cbBaudRate.TabIndex = 10;
            // 
            // cbComPort
            // 
            this.cbComPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbComPort.FormattingEnabled = true;
            this.cbComPort.Location = new System.Drawing.Point(93, 15);
            this.cbComPort.Name = "cbComPort";
            this.cbComPort.Size = new System.Drawing.Size(125, 24);
            this.cbComPort.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GPRO_QMS_Counter.Properties.Resources.vspk_icon_256;
            this.pictureBox1.Location = new System.Drawing.Point(28, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // FrmComSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(433, 281);
            this.Controls.Add(this.pnCOMSetting);
            this.Controls.Add(this.ckUseCounterDisplay);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btCancel);
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmComSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cài đặt COM Port truyền dữ liệu lên hiển thị quầy";
            this.Load += new System.EventHandler(this.FrmComSetting_Load);
            this.pnCOMSetting.ResumeLayout(false);
            this.pnCOMSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox ckUseCounterDisplay;
        private System.Windows.Forms.Panel pnCOMSetting;
        private System.Windows.Forms.ComboBox cbComPort;
        private System.Windows.Forms.ComboBox cbStopBits;
        private System.Windows.Forms.ComboBox cbParity;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.ComboBox cbDataBits;
    }
}