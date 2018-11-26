namespace GPRO_QMS_Counter
{
    partial class FrmChange
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
            this.btnChuyen = new System.Windows.Forms.Button();
            this.cbQuay = new DevExpress.XtraEditors.LookUpEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.cbQuay.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nghiệp vụ";
            // 
            // btnChuyen
            // 
            this.btnChuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnChuyen.Location = new System.Drawing.Point(167, 67);
            this.btnChuyen.Name = "btnChuyen";
            this.btnChuyen.Size = new System.Drawing.Size(99, 30);
            this.btnChuyen.TabIndex = 2;
            this.btnChuyen.Text = "Chuyển";
            this.btnChuyen.UseVisualStyleBackColor = true;
            this.btnChuyen.Click += new System.EventHandler(this.btnChuyen_Click);
            // 
            // cbQuay
            // 
            this.cbQuay.Location = new System.Drawing.Point(12, 34);
            this.cbQuay.Name = "cbQuay";
            this.cbQuay.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cbQuay.Properties.Appearance.Options.UseFont = true;
            this.cbQuay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbQuay.Size = new System.Drawing.Size(223, 24);
            this.cbQuay.TabIndex = 4;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = global::GPRO_QMS_Counter.Properties.Resources.if_view_refresh_118801;
            this.simpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton1.Location = new System.Drawing.Point(241, 35);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(25, 25);
            this.simpleButton1.TabIndex = 5;
            // 
            // FrmChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 103);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.cbQuay);
            this.Controls.Add(this.btnChuyen);
            this.Controls.Add(this.label1);
            this.Name = "FrmChange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chuyển nghiệp vụ";
            this.Load += new System.EventHandler(this.FrmChange_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbQuay.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChuyen;
        private DevExpress.XtraEditors.LookUpEdit cbQuay;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}