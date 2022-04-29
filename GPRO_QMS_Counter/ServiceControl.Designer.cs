namespace GPRO_QMS_Counter
{
    partial class ServiceControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbName = new System.Windows.Forms.Label();
            this.dpkTime = new System.Windows.Forms.DateTimePicker();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbcho = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.BackColor = System.Drawing.Color.White;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.Blue;
            this.lbName.Location = new System.Drawing.Point(8, 4);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(235, 52);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Dịch vụ 1";
            // 
            // dpkTime
            // 
            this.dpkTime.CustomFormat = "HH:mm:ss";
            this.dpkTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpkTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpkTime.Location = new System.Drawing.Point(5, 59);
            this.dpkTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dpkTime.Name = "dpkTime";
            this.dpkTime.ShowUpDown = true;
            this.dpkTime.Size = new System.Drawing.Size(107, 24);
            this.dpkTime.TabIndex = 1;
            // 
            // btnPrint
            // 
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Image = global::GPRO_QMS_Counter.Properties.Resources.if_Payment_3387295;
            this.btnPrint.Location = new System.Drawing.Point(248, 5);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(113, 79);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "In Phiếu";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(120, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Đang đợi";
            // 
            // lbcho
            // 
            this.lbcho.AutoSize = true;
            this.lbcho.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcho.ForeColor = System.Drawing.Color.Red;
            this.lbcho.Location = new System.Drawing.Point(200, 59);
            this.lbcho.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbcho.Name = "lbcho";
            this.lbcho.Size = new System.Drawing.Size(32, 24);
            this.lbcho.TabIndex = 4;
            this.lbcho.Text = "20";
            // 
            // ServiceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbcho);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dpkTime);
            this.Controls.Add(this.lbName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ServiceControl";
            this.Size = new System.Drawing.Size(368, 90);
            this.Load += new System.EventHandler(this.ServiceControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.DateTimePicker dpkTime;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbcho;
    }
}
