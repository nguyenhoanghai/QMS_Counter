using GPRO_QMS_Counter.Properties;
using System.Drawing;
using System.Windows.Forms;
namespace GPRO_QMS_Counter
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThồngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hoạtĐộngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gọiKháchTiếpTheoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhắcLạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kếtThúcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hủyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gọiSốBấtKỳToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chuyểnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemKháchĐợiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giúpĐỡToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đánhGiáToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cấpPhiếuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.càiĐặtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.âmThanhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cổngCOMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ẩnMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thuGọnGiaoDiệnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giaoDiệnĐầyĐủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêĐánhGiáToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khácToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qLLịchHẹnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vềPhầnMềmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnSửDụngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngKýSửDụngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusStaffName = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLoginTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusDesk = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusTotalWaiting = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusTotalDone = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbPrintStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDanhGia = new System.Windows.Forms.Button();
            this.btLogout = new System.Windows.Forms.Button();
            this.btHelp = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btFinish = new System.Windows.Forms.Button();
            this.btRecall = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btViewList = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btTranfer = new System.Windows.Forms.Button();
            this.btCallAnyTicket = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lbCurrentTicket = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbGeneralWaiting = new System.Windows.Forms.Label();
            this.lbWaiting = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbGuide = new System.Windows.Forms.GroupBox();
            this.txtGuide = new System.Windows.Forms.TextBox();
            this.txtParam = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tmerGetResult = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timerFindbtnClick = new System.Windows.Forms.Timer(this.components);
            this.timerResetInfo = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.chbkService = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPrintTicket = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.timeServeAllow = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.gbGuide.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThồngToolStripMenuItem,
            this.hoạtĐộngToolStripMenuItem,
            this.càiĐặtToolStripMenuItem,
            this.thốngKêToolStripMenuItem,
            this.khácToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1153, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThồngToolStripMenuItem
            // 
            this.hệThồngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngNhậpToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.hệThồngToolStripMenuItem.Name = "hệThồngToolStripMenuItem";
            this.hệThồngToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.hệThồngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // đăngNhậpToolStripMenuItem
            // 
            this.đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            this.đăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.đăngNhậpToolStripMenuItem.Text = "Đăng nhập";
            this.đăngNhậpToolStripMenuItem.Click += new System.EventHandler(this.đăngNhậpToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // hoạtĐộngToolStripMenuItem
            // 
            this.hoạtĐộngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gọiKháchTiếpTheoToolStripMenuItem,
            this.nhắcLạiToolStripMenuItem,
            this.kếtThúcToolStripMenuItem,
            this.hủyToolStripMenuItem,
            this.gọiSốBấtKỳToolStripMenuItem,
            this.chuyểnToolStripMenuItem,
            this.lưuToolStripMenuItem,
            this.xemKháchĐợiToolStripMenuItem,
            this.giúpĐỡToolStripMenuItem,
            this.cậpNhậtThôngTinToolStripMenuItem,
            this.đánhGiáToolStripMenuItem,
            this.cấpPhiếuToolStripMenuItem});
            this.hoạtĐộngToolStripMenuItem.Name = "hoạtĐộngToolStripMenuItem";
            this.hoạtĐộngToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.hoạtĐộngToolStripMenuItem.Text = "Hoạt Động";
            // 
            // gọiKháchTiếpTheoToolStripMenuItem
            // 
            this.gọiKháchTiếpTheoToolStripMenuItem.Checked = true;
            this.gọiKháchTiếpTheoToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.gọiKháchTiếpTheoToolStripMenuItem.Name = "gọiKháchTiếpTheoToolStripMenuItem";
            this.gọiKháchTiếpTheoToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.gọiKháchTiếpTheoToolStripMenuItem.Text = "Gọi khách tiếp theo";
            this.gọiKháchTiếpTheoToolStripMenuItem.Click += new System.EventHandler(this.gọiKháchTiếpTheoToolStripMenuItem_Click);
            // 
            // nhắcLạiToolStripMenuItem
            // 
            this.nhắcLạiToolStripMenuItem.Name = "nhắcLạiToolStripMenuItem";
            this.nhắcLạiToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.nhắcLạiToolStripMenuItem.Text = "Nhắc lại";
            this.nhắcLạiToolStripMenuItem.Click += new System.EventHandler(this.nhắcLạiToolStripMenuItem_Click);
            // 
            // kếtThúcToolStripMenuItem
            // 
            this.kếtThúcToolStripMenuItem.Name = "kếtThúcToolStripMenuItem";
            this.kếtThúcToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.kếtThúcToolStripMenuItem.Text = "Kết thúc";
            this.kếtThúcToolStripMenuItem.Click += new System.EventHandler(this.kếtThúcToolStripMenuItem_Click);
            // 
            // hủyToolStripMenuItem
            // 
            this.hủyToolStripMenuItem.Name = "hủyToolStripMenuItem";
            this.hủyToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.hủyToolStripMenuItem.Text = "Hủy";
            this.hủyToolStripMenuItem.Click += new System.EventHandler(this.hủyToolStripMenuItem_Click);
            // 
            // gọiSốBấtKỳToolStripMenuItem
            // 
            this.gọiSốBấtKỳToolStripMenuItem.Name = "gọiSốBấtKỳToolStripMenuItem";
            this.gọiSốBấtKỳToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.gọiSốBấtKỳToolStripMenuItem.Text = "Gọi số bất kỳ";
            this.gọiSốBấtKỳToolStripMenuItem.Click += new System.EventHandler(this.gọiSốBấtKỳToolStripMenuItem_Click);
            // 
            // chuyểnToolStripMenuItem
            // 
            this.chuyểnToolStripMenuItem.Name = "chuyểnToolStripMenuItem";
            this.chuyểnToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.chuyểnToolStripMenuItem.Text = "Chuyển";
            this.chuyểnToolStripMenuItem.Click += new System.EventHandler(this.chuyểnToolStripMenuItem_Click);
            // 
            // lưuToolStripMenuItem
            // 
            this.lưuToolStripMenuItem.Name = "lưuToolStripMenuItem";
            this.lưuToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.lưuToolStripMenuItem.Text = "Lưu";
            this.lưuToolStripMenuItem.Click += new System.EventHandler(this.lưuToolStripMenuItem_Click);
            // 
            // xemKháchĐợiToolStripMenuItem
            // 
            this.xemKháchĐợiToolStripMenuItem.Name = "xemKháchĐợiToolStripMenuItem";
            this.xemKháchĐợiToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.xemKháchĐợiToolStripMenuItem.Text = "Xem khách đợi";
            this.xemKháchĐợiToolStripMenuItem.Click += new System.EventHandler(this.xemKháchĐợiToolStripMenuItem_Click);
            // 
            // giúpĐỡToolStripMenuItem
            // 
            this.giúpĐỡToolStripMenuItem.Name = "giúpĐỡToolStripMenuItem";
            this.giúpĐỡToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.giúpĐỡToolStripMenuItem.Text = "Giúp đỡ";
            this.giúpĐỡToolStripMenuItem.Click += new System.EventHandler(this.giúpĐỡToolStripMenuItem_Click);
            // 
            // cậpNhậtThôngTinToolStripMenuItem
            // 
            this.cậpNhậtThôngTinToolStripMenuItem.Name = "cậpNhậtThôngTinToolStripMenuItem";
            this.cậpNhậtThôngTinToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.cậpNhậtThôngTinToolStripMenuItem.Text = "Cập nhật thông tin";
            this.cậpNhậtThôngTinToolStripMenuItem.Click += new System.EventHandler(this.cậpNhậtThôngTinToolStripMenuItem_Click);
            // 
            // đánhGiáToolStripMenuItem
            // 
            this.đánhGiáToolStripMenuItem.Name = "đánhGiáToolStripMenuItem";
            this.đánhGiáToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.đánhGiáToolStripMenuItem.Text = "Đánh giá";
            this.đánhGiáToolStripMenuItem.Click += new System.EventHandler(this.đánhGiáToolStripMenuItem_Click);
            // 
            // cấpPhiếuToolStripMenuItem
            // 
            this.cấpPhiếuToolStripMenuItem.Name = "cấpPhiếuToolStripMenuItem";
            this.cấpPhiếuToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.cấpPhiếuToolStripMenuItem.Text = "Cấp phiếu";
            this.cấpPhiếuToolStripMenuItem.CheckedChanged += new System.EventHandler(this.cấpPhiếuToolStripMenuItem_CheckedChanged);
            this.cấpPhiếuToolStripMenuItem.Click += new System.EventHandler(this.cấpPhiếuToolStripMenuItem_Click);
            // 
            // càiĐặtToolStripMenuItem
            // 
            this.càiĐặtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.âmThanhToolStripMenuItem,
            this.cổngCOMToolStripMenuItem,
            this.ẩnMenuToolStripMenuItem,
            this.thuGọnGiaoDiệnToolStripMenuItem,
            this.giaoDiệnĐầyĐủToolStripMenuItem});
            this.càiĐặtToolStripMenuItem.Name = "càiĐặtToolStripMenuItem";
            this.càiĐặtToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.càiĐặtToolStripMenuItem.Text = "Cài Đặt";
            // 
            // âmThanhToolStripMenuItem
            // 
            this.âmThanhToolStripMenuItem.Name = "âmThanhToolStripMenuItem";
            this.âmThanhToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.âmThanhToolStripMenuItem.Text = "Hệ thống";
            this.âmThanhToolStripMenuItem.Click += new System.EventHandler(this.âmThanhToolStripMenuItem_Click);
            // 
            // cổngCOMToolStripMenuItem
            // 
            this.cổngCOMToolStripMenuItem.Name = "cổngCOMToolStripMenuItem";
            this.cổngCOMToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.cổngCOMToolStripMenuItem.Text = "Cổng COM";
            this.cổngCOMToolStripMenuItem.Click += new System.EventHandler(this.cổngCOMToolStripMenuItem_Click);
            // 
            // ẩnMenuToolStripMenuItem
            // 
            this.ẩnMenuToolStripMenuItem.Name = "ẩnMenuToolStripMenuItem";
            this.ẩnMenuToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.ẩnMenuToolStripMenuItem.Text = "Ẩn Menu";
            this.ẩnMenuToolStripMenuItem.Click += new System.EventHandler(this.ẩnMenuToolStripMenuItem_Click);
            // 
            // thuGọnGiaoDiệnToolStripMenuItem
            // 
            this.thuGọnGiaoDiệnToolStripMenuItem.Name = "thuGọnGiaoDiệnToolStripMenuItem";
            this.thuGọnGiaoDiệnToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.thuGọnGiaoDiệnToolStripMenuItem.Text = "Thu gọn giao diện";
            this.thuGọnGiaoDiệnToolStripMenuItem.Click += new System.EventHandler(this.thuGọnGiaoDiệnToolStripMenuItem_Click);
            // 
            // giaoDiệnĐầyĐủToolStripMenuItem
            // 
            this.giaoDiệnĐầyĐủToolStripMenuItem.Name = "giaoDiệnĐầyĐủToolStripMenuItem";
            this.giaoDiệnĐầyĐủToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.giaoDiệnĐầyĐủToolStripMenuItem.Text = "Giao diện đầy đủ";
            this.giaoDiệnĐầyĐủToolStripMenuItem.Visible = false;
            this.giaoDiệnĐầyĐủToolStripMenuItem.Click += new System.EventHandler(this.giaoDiệnĐầyĐủToolStripMenuItem_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thốngKêĐánhGiáToolStripMenuItem});
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.thốngKêToolStripMenuItem.Text = "Báo cáo";
            // 
            // thốngKêĐánhGiáToolStripMenuItem
            // 
            this.thốngKêĐánhGiáToolStripMenuItem.Name = "thốngKêĐánhGiáToolStripMenuItem";
            this.thốngKêĐánhGiáToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.thốngKêĐánhGiáToolStripMenuItem.Text = "Báo cáo đánh giá";
            this.thốngKêĐánhGiáToolStripMenuItem.Click += new System.EventHandler(this.thốngKêĐánhGiáToolStripMenuItem_Click);
            // 
            // khácToolStripMenuItem
            // 
            this.khácToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qLLịchHẹnToolStripMenuItem});
            this.khácToolStripMenuItem.Name = "khácToolStripMenuItem";
            this.khácToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.khácToolStripMenuItem.Text = "Lịch hẹn";
            // 
            // qLLịchHẹnToolStripMenuItem
            // 
            this.qLLịchHẹnToolStripMenuItem.Name = "qLLịchHẹnToolStripMenuItem";
            this.qLLịchHẹnToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.qLLịchHẹnToolStripMenuItem.Text = "QL Lịch hẹn";
            this.qLLịchHẹnToolStripMenuItem.Click += new System.EventHandler(this.qLLịchHẹnToolStripMenuItem_Click);
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vềPhầnMềmToolStripMenuItem,
            this.hướngDẫnSửDụngToolStripMenuItem,
            this.đăngKýSửDụngToolStripMenuItem});
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.trợGiúpToolStripMenuItem.Text = "Trợ Giúp";
            // 
            // vềPhầnMềmToolStripMenuItem
            // 
            this.vềPhầnMềmToolStripMenuItem.Name = "vềPhầnMềmToolStripMenuItem";
            this.vềPhầnMềmToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.vềPhầnMềmToolStripMenuItem.Text = "Thông tin phần mềm";
            this.vềPhầnMềmToolStripMenuItem.Click += new System.EventHandler(this.vềPhầnMềmToolStripMenuItem_Click);
            // 
            // hướngDẫnSửDụngToolStripMenuItem
            // 
            this.hướngDẫnSửDụngToolStripMenuItem.Name = "hướngDẫnSửDụngToolStripMenuItem";
            this.hướngDẫnSửDụngToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.hướngDẫnSửDụngToolStripMenuItem.Text = "Hướng dẫn sử dụng";
            this.hướngDẫnSửDụngToolStripMenuItem.Click += new System.EventHandler(this.hướngDẫnSửDụngToolStripMenuItem_Click);
            // 
            // đăngKýSửDụngToolStripMenuItem
            // 
            this.đăngKýSửDụngToolStripMenuItem.Name = "đăngKýSửDụngToolStripMenuItem";
            this.đăngKýSửDụngToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.đăngKýSửDụngToolStripMenuItem.Text = "Đăng ký sử dụng";
            this.đăngKýSửDụngToolStripMenuItem.Click += new System.EventHandler(this.đăngKýSửDụngToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStaffName,
            this.statusLoginTime,
            this.statusDesk,
            this.statusTotalWaiting,
            this.statusTotalDone,
            this.lbPrintStatus,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1153, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusStaffName
            // 
            this.statusStaffName.AutoSize = false;
            this.statusStaffName.Name = "statusStaffName";
            this.statusStaffName.Size = new System.Drawing.Size(250, 17);
            this.statusStaffName.Text = "Nhân viên: Trần Văn Anh";
            this.statusStaffName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusLoginTime
            // 
            this.statusLoginTime.AutoSize = false;
            this.statusLoginTime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statusLoginTime.Name = "statusLoginTime";
            this.statusLoginTime.Size = new System.Drawing.Size(240, 17);
            this.statusLoginTime.Text = "Đăng nhập lúc: 08:00:00 ngày 01/01/2012";
            // 
            // statusDesk
            // 
            this.statusDesk.AutoSize = false;
            this.statusDesk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.statusDesk.Name = "statusDesk";
            this.statusDesk.Size = new System.Drawing.Size(220, 17);
            this.statusDesk.Text = "Quầy 01";
            this.statusDesk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusTotalWaiting
            // 
            this.statusTotalWaiting.AutoSize = false;
            this.statusTotalWaiting.Name = "statusTotalWaiting";
            this.statusTotalWaiting.Size = new System.Drawing.Size(100, 17);
            this.statusTotalWaiting.Text = "Đang đợi: 5";
            this.statusTotalWaiting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusTotalDone
            // 
            this.statusTotalDone.AutoSize = false;
            this.statusTotalDone.Name = "statusTotalDone";
            this.statusTotalDone.Size = new System.Drawing.Size(100, 17);
            this.statusTotalDone.Text = "Đã giao dịch: 20";
            this.statusTotalDone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbPrintStatus
            // 
            this.lbPrintStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbPrintStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbPrintStatus.Name = "lbPrintStatus";
            this.lbPrintStatus.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lbPrintStatus.Size = new System.Drawing.Size(159, 17);
            this.lbPrintStatus.Text = "Cấp phiếu thành công.";
            this.lbPrintStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnDanhGia);
            this.panel1.Controls.Add(this.btLogout);
            this.panel1.Controls.Add(this.btHelp);
            this.panel1.Controls.Add(this.btCancel);
            this.panel1.Controls.Add(this.btFinish);
            this.panel1.Controls.Add(this.btRecall);
            this.panel1.Controls.Add(this.btNext);
            this.panel1.Location = new System.Drawing.Point(0, 432);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 106);
            this.panel1.TabIndex = 3;
            // 
            // btnDanhGia
            // 
            this.btnDanhGia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDanhGia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDanhGia.Enabled = false;
            this.btnDanhGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhGia.ForeColor = System.Drawing.Color.Navy;
            this.btnDanhGia.Image = global::GPRO_QMS_Counter.Properties.Resources.if___03_1720778;
            this.btnDanhGia.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDanhGia.Location = new System.Drawing.Point(385, 6);
            this.btnDanhGia.Name = "btnDanhGia";
            this.btnDanhGia.Size = new System.Drawing.Size(150, 95);
            this.btnDanhGia.TabIndex = 9;
            this.btnDanhGia.Text = "Đánh giá";
            this.btnDanhGia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDanhGia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDanhGia.UseVisualStyleBackColor = true;
            this.btnDanhGia.Visible = false;
            this.btnDanhGia.Click += new System.EventHandler(this.btnDanhGia_Click);
            // 
            // btLogout
            // 
            this.btLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogout.ForeColor = System.Drawing.Color.Navy;
            this.btLogout.Image = ((System.Drawing.Image)(resources.GetObject("btLogout.Image")));
            this.btLogout.Location = new System.Drawing.Point(782, 6);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(150, 95);
            this.btLogout.TabIndex = 8;
            this.btLogout.Text = "Đăng xuất";
            this.btLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btLogout.UseVisualStyleBackColor = true;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // btHelp
            // 
            this.btHelp.BackColor = System.Drawing.SystemColors.Control;
            this.btHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHelp.ForeColor = System.Drawing.Color.Navy;
            this.btHelp.Image = ((System.Drawing.Image)(resources.GetObject("btHelp.Image")));
            this.btHelp.Location = new System.Drawing.Point(626, 6);
            this.btHelp.Name = "btHelp";
            this.btHelp.Size = new System.Drawing.Size(150, 95);
            this.btHelp.TabIndex = 7;
            this.btHelp.Text = "Giúp đỡ";
            this.btHelp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btHelp.UseVisualStyleBackColor = false;
            this.btHelp.Click += new System.EventHandler(this.btHelp_Click);
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.ForeColor = System.Drawing.Color.Navy;
            this.btCancel.Image = ((System.Drawing.Image)(resources.GetObject("btCancel.Image")));
            this.btCancel.Location = new System.Drawing.Point(470, 6);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(150, 95);
            this.btCancel.TabIndex = 6;
            this.btCancel.Text = "Hủy";
            this.btCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btFinish
            // 
            this.btFinish.BackColor = System.Drawing.SystemColors.Control;
            this.btFinish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btFinish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btFinish.ForeColor = System.Drawing.Color.Navy;
            this.btFinish.Image = ((System.Drawing.Image)(resources.GetObject("btFinish.Image")));
            this.btFinish.Location = new System.Drawing.Point(314, 6);
            this.btFinish.Name = "btFinish";
            this.btFinish.Size = new System.Drawing.Size(150, 95);
            this.btFinish.TabIndex = 5;
            this.btFinish.Text = "Hoàn tất";
            this.btFinish.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btFinish.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btFinish.UseVisualStyleBackColor = false;
            this.btFinish.Click += new System.EventHandler(this.btFinish_Click);
            this.btFinish.MouseLeave += new System.EventHandler(this.btFinish_MouseLeave);
            this.btFinish.MouseHover += new System.EventHandler(this.btFinish_MouseHover);
            // 
            // btRecall
            // 
            this.btRecall.BackColor = System.Drawing.SystemColors.Control;
            this.btRecall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btRecall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRecall.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRecall.ForeColor = System.Drawing.Color.Navy;
            this.btRecall.Image = ((System.Drawing.Image)(resources.GetObject("btRecall.Image")));
            this.btRecall.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btRecall.Location = new System.Drawing.Point(158, 6);
            this.btRecall.Name = "btRecall";
            this.btRecall.Size = new System.Drawing.Size(150, 95);
            this.btRecall.TabIndex = 4;
            this.btRecall.Text = "  Nhắc lại";
            this.btRecall.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btRecall.UseVisualStyleBackColor = false;
            this.btRecall.Click += new System.EventHandler(this.btRecall_Click);
            this.btRecall.MouseLeave += new System.EventHandler(this.btRecall_MouseLeave);
            this.btRecall.MouseHover += new System.EventHandler(this.btRecall_MouseHover);
            // 
            // btNext
            // 
            this.btNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNext.ForeColor = System.Drawing.Color.Navy;
            this.btNext.Image = ((System.Drawing.Image)(resources.GetObject("btNext.Image")));
            this.btNext.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btNext.Location = new System.Drawing.Point(2, 6);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(150, 95);
            this.btNext.TabIndex = 3;
            this.btNext.Text = "Gọi tiếp theo";
            this.btNext.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            this.btNext.MouseLeave += new System.EventHandler(this.btNext_MouseLeave);
            this.btNext.MouseHover += new System.EventHandler(this.btNext_MouseHover);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.btViewList);
            this.panel2.Controls.Add(this.btSave);
            this.panel2.Controls.Add(this.btTranfer);
            this.panel2.Controls.Add(this.btCallAnyTicket);
            this.panel2.Location = new System.Drawing.Point(777, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(157, 410);
            this.panel2.TabIndex = 4;
            // 
            // btViewList
            // 
            this.btViewList.BackColor = System.Drawing.SystemColors.Control;
            this.btViewList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btViewList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btViewList.Enabled = false;
            this.btViewList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btViewList.ForeColor = System.Drawing.Color.Navy;
            this.btViewList.Image = ((System.Drawing.Image)(resources.GetObject("btViewList.Image")));
            this.btViewList.Location = new System.Drawing.Point(5, 309);
            this.btViewList.Name = "btViewList";
            this.btViewList.Size = new System.Drawing.Size(150, 95);
            this.btViewList.TabIndex = 12;
            this.btViewList.Text = "Xem khách đợi";
            this.btViewList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btViewList.UseVisualStyleBackColor = false;
            this.btViewList.Click += new System.EventHandler(this.btViewList_Click);
            // 
            // btSave
            // 
            this.btSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.ForeColor = System.Drawing.Color.Navy;
            this.btSave.Image = ((System.Drawing.Image)(resources.GetObject("btSave.Image")));
            this.btSave.Location = new System.Drawing.Point(5, 208);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(150, 95);
            this.btSave.TabIndex = 11;
            this.btSave.Text = "Lưu";
            this.btSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btTranfer
            // 
            this.btTranfer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btTranfer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTranfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTranfer.ForeColor = System.Drawing.Color.Navy;
            this.btTranfer.Image = ((System.Drawing.Image)(resources.GetObject("btTranfer.Image")));
            this.btTranfer.Location = new System.Drawing.Point(5, 107);
            this.btTranfer.Name = "btTranfer";
            this.btTranfer.Size = new System.Drawing.Size(150, 95);
            this.btTranfer.TabIndex = 10;
            this.btTranfer.Text = "Chuyển";
            this.btTranfer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btTranfer.UseVisualStyleBackColor = true;
            this.btTranfer.Click += new System.EventHandler(this.btTranfer_Click);
            // 
            // btCallAnyTicket
            // 
            this.btCallAnyTicket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btCallAnyTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCallAnyTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCallAnyTicket.ForeColor = System.Drawing.Color.Navy;
            this.btCallAnyTicket.Image = ((System.Drawing.Image)(resources.GetObject("btCallAnyTicket.Image")));
            this.btCallAnyTicket.Location = new System.Drawing.Point(5, 6);
            this.btCallAnyTicket.Name = "btCallAnyTicket";
            this.btCallAnyTicket.Size = new System.Drawing.Size(150, 95);
            this.btCallAnyTicket.TabIndex = 9;
            this.btCallAnyTicket.Text = "Gọi bất kỳ";
            this.btCallAnyTicket.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCallAnyTicket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btCallAnyTicket.UseVisualStyleBackColor = true;
            this.btCallAnyTicket.Click += new System.EventHandler(this.btCallAnyTicket_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Navy;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Navy;
            this.splitContainer1.Panel2.Controls.Add(this.gbGuide);
            this.splitContainer1.Panel2.Controls.Add(this.txtParam);
            this.splitContainer1.Panel2.Controls.Add(this.txtResult);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Size = new System.Drawing.Size(779, 408);
            this.splitContainer1.SplitterDistance = 469;
            this.splitContainer1.TabIndex = 6;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            this.splitContainer1.DoubleClick += new System.EventHandler(this.splitContainer1_DoubleClick);
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lbCurrentTicket);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.lbGeneralWaiting);
            this.splitContainer2.Panel2.Controls.Add(this.lbWaiting);
            this.splitContainer2.Panel2.Controls.Add(this.label3);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Size = new System.Drawing.Size(469, 408);
            this.splitContainer2.SplitterDistance = 211;
            this.splitContainer2.TabIndex = 0;
            this.splitContainer2.DoubleClick += new System.EventHandler(this.splitContainer2_DoubleClick);
            // 
            // lbCurrentTicket
            // 
            this.lbCurrentTicket.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbCurrentTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 63.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentTicket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbCurrentTicket.Location = new System.Drawing.Point(6, 57);
            this.lbCurrentTicket.Name = "lbCurrentTicket";
            this.lbCurrentTicket.Size = new System.Drawing.Size(452, 125);
            this.lbCurrentTicket.TabIndex = 1;
            this.lbCurrentTicket.Text = "0";
            this.lbCurrentTicket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐANG GIAO DỊCH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbGeneralWaiting
            // 
            this.lbGeneralWaiting.AutoSize = true;
            this.lbGeneralWaiting.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGeneralWaiting.ForeColor = System.Drawing.Color.White;
            this.lbGeneralWaiting.Location = new System.Drawing.Point(3, 135);
            this.lbGeneralWaiting.Name = "lbGeneralWaiting";
            this.lbGeneralWaiting.Size = new System.Drawing.Size(36, 37);
            this.lbGeneralWaiting.TabIndex = 4;
            this.lbGeneralWaiting.Text = "0";
            this.lbGeneralWaiting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbGeneralWaiting.TextChanged += new System.EventHandler(this.lbGeneralWaiting_TextChanged);
            this.lbGeneralWaiting.MouseLeave += new System.EventHandler(this.lbGeneralWaiting_MouseLeave);
            this.lbGeneralWaiting.MouseHover += new System.EventHandler(this.lbGeneralWaiting_Click);
            // 
            // lbWaiting
            // 
            this.lbWaiting.AutoSize = true;
            this.lbWaiting.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWaiting.ForeColor = System.Drawing.Color.White;
            this.lbWaiting.Location = new System.Drawing.Point(3, 40);
            this.lbWaiting.Name = "lbWaiting";
            this.lbWaiting.Size = new System.Drawing.Size(36, 37);
            this.lbWaiting.TabIndex = 3;
            this.lbWaiting.Text = "0";
            this.lbWaiting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbWaiting.TextChanged += new System.EventHandler(this.lbWaiting_TextChanged);
            this.lbWaiting.MouseLeave += new System.EventHandler(this.lbWaiting_MouseLeave);
            this.lbWaiting.MouseHover += new System.EventHandler(this.lbWaiting_MouseHover);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(1, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(463, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "ĐANG ĐỢI CHUNG";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(1, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(463, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "ĐANG ĐỢI TẠI QUẦY";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbGuide
            // 
            this.gbGuide.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbGuide.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.gbGuide.Controls.Add(this.txtGuide);
            this.gbGuide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGuide.ForeColor = System.Drawing.Color.Navy;
            this.gbGuide.Location = new System.Drawing.Point(4, 210);
            this.gbGuide.Name = "gbGuide";
            this.gbGuide.Size = new System.Drawing.Size(295, 190);
            this.gbGuide.TabIndex = 8;
            this.gbGuide.TabStop = false;
            this.gbGuide.Text = "Hướng dẫn";
            // 
            // txtGuide
            // 
            this.txtGuide.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGuide.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtGuide.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGuide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtGuide.Location = new System.Drawing.Point(15, 21);
            this.txtGuide.Multiline = true;
            this.txtGuide.Name = "txtGuide";
            this.txtGuide.ReadOnly = true;
            this.txtGuide.Size = new System.Drawing.Size(274, 161);
            this.txtGuide.TabIndex = 15;
            // 
            // txtParam
            // 
            this.txtParam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtParam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParam.Location = new System.Drawing.Point(18, 57);
            this.txtParam.MaxLength = 10;
            this.txtParam.Name = "txtParam";
            this.txtParam.Size = new System.Drawing.Size(265, 22);
            this.txtParam.TabIndex = 13;
            this.txtParam.TextChanged += new System.EventHandler(this.txtParam_TextChanged);
            this.txtParam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParam_KeyPress);
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.BackColor = System.Drawing.Color.White;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(19, 109);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(265, 73);
            this.txtResult.TabIndex = 14;
            this.txtResult.TextChanged += new System.EventHandler(this.txtResult_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Kết quả";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nhập  yêu cầu";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tmerGetResult
            // 
            this.tmerGetResult.Enabled = true;
            this.tmerGetResult.Interval = 1000;
            this.tmerGetResult.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timerFindbtnClick
            // 
            this.timerFindbtnClick.Enabled = true;
            this.timerFindbtnClick.Interval = 1000;
            this.timerFindbtnClick.Tick += new System.EventHandler(this.timerFindbtnClick_Tick);
            // 
            // timerResetInfo
            // 
            this.timerResetInfo.Enabled = true;
            this.timerResetInfo.Interval = 1000;
            this.timerResetInfo.Tick += new System.EventHandler(this.timerResetInfo_Tick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chbkService);
            this.panel3.Location = new System.Drawing.Point(940, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(205, 343);
            this.panel3.TabIndex = 7;
            // 
            // chbkService
            // 
            this.chbkService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chbkService.FormattingEnabled = true;
            this.chbkService.Location = new System.Drawing.Point(0, 0);
            this.chbkService.Name = "chbkService";
            this.chbkService.Size = new System.Drawing.Size(205, 343);
            this.chbkService.TabIndex = 0;
            this.chbkService.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chbkService_ItemCheck);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(940, 396);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Thời gian phục vụ dự kiến";
            // 
            // btnPrintTicket
            // 
            this.btnPrintTicket.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnPrintTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintTicket.Image = global::GPRO_QMS_Counter.Properties.Resources.if_Payment_3387295;
            this.btnPrintTicket.Location = new System.Drawing.Point(943, 441);
            this.btnPrintTicket.Name = "btnPrintTicket";
            this.btnPrintTicket.Size = new System.Drawing.Size(200, 94);
            this.btnPrintTicket.TabIndex = 9;
            this.btnPrintTicket.Text = "In phiếu";
            this.btnPrintTicket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPrintTicket.UseVisualStyleBackColor = false;
            this.btnPrintTicket.Click += new System.EventHandler(this.btnPrintTicket_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(940, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Dịch vụ";
            // 
            // timeServeAllow
            // 
            this.timeServeAllow.CustomFormat = "HH:mm:ss";
            this.timeServeAllow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeServeAllow.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeServeAllow.Location = new System.Drawing.Point(943, 415);
            this.timeServeAllow.Name = "timeServeAllow";
            this.timeServeAllow.ShowUpDown = true;
            this.timeServeAllow.Size = new System.Drawing.Size(200, 20);
            this.timeServeAllow.TabIndex = 8;
            this.timeServeAllow.Value = new System.DateTime(2018, 9, 8, 0, 0, 0, 0);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 561);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnPrintTicket);
            this.Controls.Add(this.timeServeAllow);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(481, 600);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm gọi số - GPRO QMS Counter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.gbGuide.ResumeLayout(false);
            this.gbGuide.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThồngToolStripMenuItem;
        private ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private ToolStripMenuItem hoạtĐộngToolStripMenuItem;
        private ToolStripMenuItem gọiKháchTiếpTheoToolStripMenuItem;
        private ToolStripMenuItem nhắcLạiToolStripMenuItem;
        private ToolStripMenuItem kếtThúcToolStripMenuItem;
        private ToolStripMenuItem hủyToolStripMenuItem;
        private ToolStripMenuItem gọiSốBấtKỳToolStripMenuItem;
        private ToolStripMenuItem chuyểnToolStripMenuItem;
        private ToolStripMenuItem lưuToolStripMenuItem;
        private ToolStripMenuItem xemKháchĐợiToolStripMenuItem;
        private ToolStripMenuItem giúpĐỡToolStripMenuItem;
        private ToolStripMenuItem càiĐặtToolStripMenuItem;
        private ToolStripMenuItem âmThanhToolStripMenuItem;
        private ToolStripMenuItem cổngCOMToolStripMenuItem;
        private ToolStripMenuItem ẩnMenuToolStripMenuItem;
        private ToolStripMenuItem thuGọnGiaoDiệnToolStripMenuItem;
        private ToolStripMenuItem trợGiúpToolStripMenuItem;
        private ToolStripMenuItem vềPhầnMềmToolStripMenuItem;
        private ToolStripMenuItem hướngDẫnSửDụngToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusStaffName;
        private ToolStripStatusLabel statusDesk;
        private ToolStripStatusLabel statusTotalWaiting;
        private ToolStripStatusLabel statusTotalDone;
        private ToolStripStatusLabel statusLoginTime;
        private Panel panel1;
        private Button btNext;
        private Button btLogout;
        private Button btHelp;
        private Button btCancel;
        private Button btFinish;
        private Button btRecall;
        private Panel panel2;
        private Button btViewList;
        private Button btSave;
        private Button btTranfer;
        private Button btCallAnyTicket;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private Label label1;
        private Label lbCurrentTicket;
        private Label label2;
        private Label label3;
        private Label lbWaiting;
        private Label lbGeneralWaiting;
        private Label label5;
        private Label label4;
        private TextBox txtResult;
        private TextBox txtParam;
        private GroupBox gbGuide;
        private TextBox txtGuide;
        private ToolStripMenuItem giaoDiệnĐầyĐủToolStripMenuItem;
        private ToolStripMenuItem cậpNhậtThôngTinToolStripMenuItem;
        private Timer tmerGetResult;
        private Timer timer2;
        private Timer timer3;
        private ToolStripMenuItem đăngKýSửDụngToolStripMenuItem;
        private ToolStripMenuItem thốngKêToolStripMenuItem;
        private ToolStripMenuItem thốngKêĐánhGiáToolStripMenuItem;
        private ToolStripMenuItem khácToolStripMenuItem;
        private ToolStripMenuItem qLLịchHẹnToolStripMenuItem;
        private ToolStripMenuItem đánhGiáToolStripMenuItem;
        private Button btnDanhGia;
        private Timer timerFindbtnClick;
        private Timer timerResetInfo;
        private Panel panel3;
        private Label label6;
        private Button btnPrintTicket;
        private CheckedListBox chbkService;
        private Label label8;
        private DateTimePicker timeServeAllow;
        private ToolStripStatusLabel lbPrintStatus;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripMenuItem cấpPhiếuToolStripMenuItem;
        

    }
}