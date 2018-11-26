namespace GPRO_QMS_Counter
{
    partial class FrmConfig
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
            this.toggleSwitch1 = new DevExpress.XtraEditors.ToggleSwitch();
            this.label1 = new System.Windows.Forms.Label();
            this.pnCOMSetting = new System.Windows.Forms.Panel();
            this.cbStopBits = new System.Windows.Forms.ComboBox();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.cbDataBits = new System.Windows.Forms.ComboBox();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.cbComPort = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtSoundPath = new DevExpress.XtraEditors.MemoEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.switchReadSound = new DevExpress.XtraEditors.ToggleSwitch();
            this.label9 = new System.Windows.Forms.Label();
            this.numPrinterId = new System.Windows.Forms.NumericUpDown();
            this.numCounterId = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).BeginInit();
            this.pnCOMSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoundPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.switchReadSound.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrinterId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCounterId)).BeginInit();
            this.SuspendLayout();
            // 
            // toggleSwitch1
            // 
            this.toggleSwitch1.Location = new System.Drawing.Point(164, 14);
            this.toggleSwitch1.Name = "toggleSwitch1";
            this.toggleSwitch1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleSwitch1.Properties.Appearance.ForeColor = System.Drawing.Color.Brown;
            this.toggleSwitch1.Properties.Appearance.Options.UseFont = true;
            this.toggleSwitch1.Properties.Appearance.Options.UseForeColor = true;
            this.toggleSwitch1.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.toggleSwitch1.Properties.OffText = "Không";
            this.toggleSwitch1.Properties.OnText = "Có";
            this.toggleSwitch1.Size = new System.Drawing.Size(127, 24);
            this.toggleSwitch1.TabIndex = 0;
            this.toggleSwitch1.Toggled += new System.EventHandler(this.toggleSwitch1_Toggled);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sử dụng hiển thị quầy";
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
            this.pnCOMSetting.Controls.Add(this.label2);
            this.pnCOMSetting.Controls.Add(this.label6);
            this.pnCOMSetting.Location = new System.Drawing.Point(15, 42);
            this.pnCOMSetting.Name = "pnCOMSetting";
            this.pnCOMSetting.Size = new System.Drawing.Size(495, 112);
            this.pnCOMSetting.TabIndex = 15;
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
            this.cbStopBits.Location = new System.Drawing.Point(357, 45);
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
            this.cbParity.Location = new System.Drawing.Point(357, 15);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(270, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Stop Bits";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(270, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Parity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Data Bits";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Baud Rate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(6, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "COM Port";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(12, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Đường dẫn thư mục âm thanh";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(478, 249);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(32, 23);
            this.simpleButton1.TabIndex = 18;
            this.simpleButton1.Text = "...";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Image = global::GPRO_QMS_Counter.Properties.Resources.if_cancel_13487;
            this.btnclose.Location = new System.Drawing.Point(381, 278);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(129, 32);
            this.btnclose.TabIndex = 20;
            this.btnclose.Text = "  Hủy bỏ";
            this.btnclose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Image = global::GPRO_QMS_Counter.Properties.Resources.if_save_173091;
            this.btnsave.Location = new System.Drawing.Point(246, 278);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(129, 32);
            this.btnsave.TabIndex = 19;
            this.btnsave.Text = " Lưu cấu hình";
            this.btnsave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtSoundPath
            // 
            this.txtSoundPath.Location = new System.Drawing.Point(15, 222);
            this.txtSoundPath.Name = "txtSoundPath";
            this.txtSoundPath.Size = new System.Drawing.Size(457, 50);
            this.txtSoundPath.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(12, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Đọc âm thanh báo";
            // 
            // switchReadSound
            // 
            this.switchReadSound.Location = new System.Drawing.Point(146, 166);
            this.switchReadSound.Name = "switchReadSound";
            this.switchReadSound.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switchReadSound.Properties.Appearance.ForeColor = System.Drawing.Color.Brown;
            this.switchReadSound.Properties.Appearance.Options.UseFont = true;
            this.switchReadSound.Properties.Appearance.Options.UseForeColor = true;
            this.switchReadSound.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.switchReadSound.Properties.OffText = "Không";
            this.switchReadSound.Properties.OnText = "Có";
            this.switchReadSound.Size = new System.Drawing.Size(127, 24);
            this.switchReadSound.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(285, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Mã máy in";
            // 
            // numPrinterId
            // 
            this.numPrinterId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPrinterId.Location = new System.Drawing.Point(372, 169);
            this.numPrinterId.Name = "numPrinterId";
            this.numPrinterId.Size = new System.Drawing.Size(70, 22);
            this.numPrinterId.TabIndex = 24;
            this.numPrinterId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numCounterId
            // 
            this.numCounterId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCounterId.Location = new System.Drawing.Point(372, 16);
            this.numCounterId.Name = "numCounterId";
            this.numCounterId.Size = new System.Drawing.Size(70, 22);
            this.numCounterId.TabIndex = 26;
            this.numCounterId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(285, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "Mã Counter";
            // 
            // FrmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 317);
            this.Controls.Add(this.numCounterId);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numPrinterId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.switchReadSound);
            this.Controls.Add(this.txtSoundPath);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pnCOMSetting);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toggleSwitch1);
            this.MaximumSize = new System.Drawing.Size(538, 356);
            this.MinimumSize = new System.Drawing.Size(538, 356);
            this.Name = "FrmConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cấu hình hệ thống";
            this.Load += new System.EventHandler(this.FrmConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).EndInit();
            this.pnCOMSetting.ResumeLayout(false);
            this.pnCOMSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoundPath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.switchReadSound.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrinterId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCounterId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnCOMSetting;
        private System.Windows.Forms.ComboBox cbStopBits;
        private System.Windows.Forms.ComboBox cbParity;
        private System.Windows.Forms.ComboBox cbDataBits;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.ComboBox cbComPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnclose;
        private DevExpress.XtraEditors.MemoEdit txtSoundPath;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.ToggleSwitch switchReadSound;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numPrinterId;
        private System.Windows.Forms.NumericUpDown numCounterId;
        private System.Windows.Forms.Label label10;
    }
}