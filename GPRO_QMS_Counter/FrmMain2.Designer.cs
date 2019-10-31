namespace GPRO_QMS_Counter
{
	partial class FrmMain2
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
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBTPrint = new DevExpress.XtraBars.BarButtonItem();
            this.barBtComStatus = new DevExpress.XtraBars.BarButtonItem();
            this.btnCauHinh = new DevExpress.XtraBars.BarButtonItem();
            this.lbErrorsms = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnTicketTemplate = new DevExpress.XtraBars.BarButtonItem();
            this.btconnectsql = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.TmerQuetComport = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barBTPrint,
            this.barBtComStatus,
            this.btnCauHinh,
            this.lbErrorsms,
            this.barButtonItem1,
            this.btnTicketTemplate,
            this.btconnectsql});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbon.MaxItemId = 8;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbon.Size = new System.Drawing.Size(880, 178);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barBTPrint
            // 
            this.barBTPrint.Caption = "Cấp phiếu";
            this.barBTPrint.Id = 1;
            this.barBTPrint.ImageOptions.Image = global::GPRO_QMS_Counter.Properties.Resources.if_Payment_3387295;
            this.barBTPrint.ImageOptions.LargeImage = global::GPRO_QMS_Counter.Properties.Resources.if_Payment_3387295;
            this.barBTPrint.Name = "barBTPrint";
            this.barBTPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBTPrint_ItemClick);
            // 
            // barBtComStatus
            // 
            this.barBtComStatus.Id = 2;
            this.barBtComStatus.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.barBtComStatus.ImageOptions.Image = global::GPRO_QMS_Counter.Properties.Resources.com_port_dis;
            this.barBtComStatus.Name = "barBtComStatus";
            // 
            // btnCauHinh
            // 
            this.btnCauHinh.Caption = "Cấu hình";
            this.btnCauHinh.Id = 3;
            this.btnCauHinh.ImageOptions.LargeImage = global::GPRO_QMS_Counter.Properties.Resources.if_our_process_2_45123;
            this.btnCauHinh.Name = "btnCauHinh";
            this.btnCauHinh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCauHinh_ItemClick);
            // 
            // lbErrorsms
            // 
            this.lbErrorsms.Caption = "barStaticItem1";
            this.lbErrorsms.Id = 4;
            this.lbErrorsms.Name = "lbErrorsms";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Kiểm thử";
            this.barButtonItem1.Id = 5;
            this.barButtonItem1.ImageOptions.LargeImage = global::GPRO_QMS_Counter.Properties.Resources.user_guide;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnTicketTemplate
            // 
            this.btnTicketTemplate.Caption = "Mẫu phiếu";
            this.btnTicketTemplate.Id = 6;
            this.btnTicketTemplate.ImageOptions.LargeImage = global::GPRO_QMS_Counter.Properties.Resources.tk;
            this.btnTicketTemplate.Name = "btnTicketTemplate";
            this.btnTicketTemplate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTicketTemplate_ItemClick);
            // 
            // btconnectsql
            // 
            this.btconnectsql.Caption = "Kết nối CSDL";
            this.btconnectsql.Id = 7;
            this.btconnectsql.ImageOptions.LargeImage = global::GPRO_QMS_Counter.Properties.Resources.server_connect;
            this.btconnectsql.Name = "btconnectsql";
            this.btconnectsql.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btconnectsql_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barBTPrint);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Cấu hình";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnCauHinh);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnTicketTemplate);
            this.ribbonPageGroup2.ItemLinks.Add(this.btconnectsql);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ForeColor = System.Drawing.Color.Transparent;
            this.ribbonStatusBar.ItemLinks.Add(this.barBtComStatus);
            this.ribbonStatusBar.ItemLinks.Add(this.lbErrorsms);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 459);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(880, 37);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // TmerQuetComport
            // 
            this.TmerQuetComport.Enabled = true;
            this.TmerQuetComport.Tick += new System.EventHandler(this.TmerQuetComport_Tick);
            // 
            // FrmMain2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 496);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmMain2";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Gọi số tự động GPRO";
            this.Load += new System.EventHandler(this.FrmMain2_Load);
            this.MdiChildActivate += new System.EventHandler(this.FrmMain2_MdiChildActivate);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
		private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem barBTPrint;
        private DevExpress.XtraBars.BarButtonItem barBtComStatus;
        private DevExpress.XtraBars.BarButtonItem btnCauHinh;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarStaticItem lbErrorsms;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private System.Windows.Forms.Timer TmerQuetComport;
        private DevExpress.XtraBars.BarButtonItem btnTicketTemplate;
        private DevExpress.XtraBars.BarButtonItem btconnectsql;
    }
}