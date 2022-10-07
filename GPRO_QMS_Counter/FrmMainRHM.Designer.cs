﻿namespace GPRO_QMS_Counter
{
    partial class FrmMainRHM
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
            this.TmerQuetComport = new System.Windows.Forms.Timer(this.components);
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.barBtDisplayComStatus = new DevExpress.XtraBars.BarButtonItem();
            this.barBtPrintComStatus = new DevExpress.XtraBars.BarButtonItem();
            this.lbErrorsms = new DevExpress.XtraBars.BarStaticItem();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBTPrint = new DevExpress.XtraBars.BarButtonItem();
            this.btnCauHinh = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnTicketTemplate = new DevExpress.XtraBars.BarButtonItem();
            this.btconnectsql = new DevExpress.XtraBars.BarButtonItem();
            this.btOpenGoiSO = new DevExpress.XtraBars.BarButtonItem();
            this.btActive = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // TmerQuetComport
            // 
            this.TmerQuetComport.Enabled = true;
            this.TmerQuetComport.Tick += new System.EventHandler(this.TmerQuetComport_Tick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Id = 2;
              this.barButtonItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem2.LargeGlyph = global::GPRO_QMS_Counter.Properties.Resources.com_port_dis;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = null;
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ForeColor = System.Drawing.Color.Transparent;
            this.ribbonStatusBar.ItemLinks.Add(this.barBtDisplayComStatus);
            this.ribbonStatusBar.ItemLinks.Add(this.barBtPrintComStatus, true);
            this.ribbonStatusBar.ItemLinks.Add(this.lbErrorsms, true);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 419);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(800, 31);
            // 
            // barBtDisplayComStatus
            // 
            this.barBtDisplayComStatus.Caption = "Display ";
            this.barBtDisplayComStatus.Id = 9;
            //this.barBtDisplayComStatus.ImageOptions.Image = global::GPRO_QMS_Counter.Properties.Resources.com_port_dis;
            this.barBtDisplayComStatus.Name = "barBtDisplayComStatus";
            // 
            // barBtPrintComStatus
            // 
            this.barBtPrintComStatus.Caption = "Printer";
            this.barBtPrintComStatus.Id = 2;
            //this.barBtPrintComStatus.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            //this.barBtPrintComStatus.ImageOptions.Image = global::GPRO_QMS_Counter.Properties.Resources.com_port_dis;
            this.barBtPrintComStatus.Name = "barBtPrintComStatus";
            // 
            // lbErrorsms
            // 
            this.lbErrorsms.Caption = "b";
            this.lbErrorsms.Id = 4;
            this.lbErrorsms.Name = "lbErrorsms";
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barBTPrint,
            this.barBtPrintComStatus,
            this.btnCauHinh,
            this.lbErrorsms,
            this.barButtonItem1,
            this.btnTicketTemplate,
            this.btconnectsql,
            this.btOpenGoiSO,
            this.barBtDisplayComStatus,
            this.btActive,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbon.MaxItemId = 14;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbon.Size = new System.Drawing.Size(800, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barBTPrint
            // 
            this.barBTPrint.Caption = "Cấp phiếu";
            this.barBTPrint.Id = 1;
            //this.barBTPrint.ImageOptions.Image = global::GPRO_QMS_Counter.Properties.Resources.if_Payment_3387295;
            //this.barBTPrint.ImageOptions.LargeImage = global::GPRO_QMS_Counter.Properties.Resources.if_Payment_3387295;
            this.barBTPrint.Name = "barBTPrint";
            this.barBTPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBTPrint_ItemClick);
            // 
            // btnCauHinh
            // 
            this.btnCauHinh.Caption = "Cấu hình";
            this.btnCauHinh.Id = 3;
           // this.btnCauHinh.ImageOptions.LargeImage = global::GPRO_QMS_Counter.Properties.Resources.if_our_process_2_45123;
            this.btnCauHinh.Name = "btnCauHinh";
            this.btnCauHinh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCauHinh_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Kiểm thử";
            this.barButtonItem1.Id = 5;
            //this.barButtonItem1.ImageOptions.LargeImage = global::GPRO_QMS_Counter.Properties.Resources.user_guide;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnTicketTemplate
            // 
            this.btnTicketTemplate.Caption = "Mẫu phiếu";
            this.btnTicketTemplate.Id = 6;
           // this.btnTicketTemplate.ImageOptions.LargeImage = global::GPRO_QMS_Counter.Properties.Resources.tk;
            this.btnTicketTemplate.Name = "btnTicketTemplate";
            this.btnTicketTemplate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTicketTemplate_ItemClick);
            // 
            // btconnectsql
            // 
            this.btconnectsql.Caption = "Kết nối CSDL";
            this.btconnectsql.Id = 7;
            //this.btconnectsql.ImageOptions.LargeImage = global::GPRO_QMS_Counter.Properties.Resources.server_connect;
            this.btconnectsql.Name = "btconnectsql";
            this.btconnectsql.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btconnectsql_ItemClick);
            // 
            // btOpenGoiSO
            // 
            this.btOpenGoiSO.Caption = "Màn hình Gọi số";
            this.btOpenGoiSO.Id = 8;
         //   this.btOpenGoiSO.ImageOptions.LargeImage = global::GPRO_QMS_Counter.Properties.Resources.deskSound;
            this.btOpenGoiSO.Name = "btOpenGoiSO";
            this.btOpenGoiSO.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btOpenGoiSO_ItemClick);
            // 
            // btActive
            // 
            this.btActive.Caption = "Đăng ký";
            this.btActive.Id = 10;
         //   this.btActive.ImageOptions.LargeImage = global::GPRO_QMS_Counter.Properties.Resources.iconfinder_stock_keyring_21472;
            this.btActive.Name = "btActive";
            this.btActive.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btActive_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Đăng nhập ghế";
            this.barButtonItem3.Id = 11;
           // this.barButtonItem3.ImageOptions.Image = global::GPRO_QMS_Counter.Properties.Resources.login;
          //  this.barButtonItem3.ImageOptions.LargeImage = global::GPRO_QMS_Counter.Properties.Resources.login;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Bệnh nhân";
            this.barButtonItem4.Id = 12;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Lịch hẹn";
            this.barButtonItem5.Id = 13;
           // this.barButtonItem5.ImageOptions.LargeImage = global::GPRO_QMS_Counter.Properties.Resources.checklist__1_;
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btOpenGoiSO, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBTPrint, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem5);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = " ";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Cấu hình";
            this.ribbonPage2.Visible = false;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnCauHinh);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnTicketTemplate, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.btconnectsql, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem1, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.btActive);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // FrmMainRHM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "FrmMainRHM";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Phần mềm gọi số tự động";
            this.Load += new System.EventHandler(this.FrmMainRHM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer TmerQuetComport;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barBtDisplayComStatus;
        private DevExpress.XtraBars.BarButtonItem barBtPrintComStatus;
        private DevExpress.XtraBars.BarStaticItem lbErrorsms;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.BarButtonItem barBTPrint;
        private DevExpress.XtraBars.BarButtonItem btnCauHinh;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnTicketTemplate;
        private DevExpress.XtraBars.BarButtonItem btconnectsql;
        private DevExpress.XtraBars.BarButtonItem btOpenGoiSO;
        private DevExpress.XtraBars.BarButtonItem btActive;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
    }
}