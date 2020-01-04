using GPRO.Core.Hai;
using GPRO_QMS_Counter.Helper;
using GPRO_QMS_Counter.Models;
using GPRO_QMS_Counter.Properties;
using Microsoft.VisualBasic;
using Microsoft.Win32;
using Newtonsoft.Json;
using QMS_System.Data.BLL;
using QMS_System.Data.Enum;
using QMS_System.Data.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Media;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace GPRO_QMS_Counter
{
    public partial class FrmMain4 : Form
    {
        public static List<int> serviceIds;
        public static List<ModelSelectItem> serviceObjs;
        public static List<ServiceDayModel> lib_Services;
        public static string
              connectString,
              errorsms,
              SoundLockPrintTicket = "khoa.wav",
              ticketTemplate;
        public static int
            so_lien = 1,
            printType = 1,
            startNumber = 0,
            printTicketReturnCurrentNumberOrServiceCode = 1,
            UseWithThirdPattern = 0,
            CheckTimeBeforePrintTicket = 0;
        public static bool IsUseMainDisplay = false;

        public static Login loginObj;
        public static DateTime today = DateTime.Now;
        public static SerialPort
            printSerialCOM = new SerialPort(),
            displaySerialCOM = new SerialPort();

        List<ConfigModel> configs;
        List<string> dataSendToComport = new List<string>();
        int q = -1,
            equipCode = 0,
            counterId = 0,
             xPos = 0,
            yPos = 230,
            xPos1 = 0,
            yPos1 = 135;
        bool genUserTabFinish = false,
            IsReadSound = false,
            isFinishRead = true,
            bRegistered = false,
            bCheckValid = false,
            UsePrintMachine = false;
        static List<string> temp, playlist;
        SoundPlayer player;
        Thread playThread;
        string soundPath = string.Empty;


        public FrmMain4()
        {
            bCheckValid = CheckValidation();
            if (!bCheckValid)
            {
                FrmRegister frmRegister = new FrmRegister();
                frmRegister.ShowDialog();
            }

            if (bCheckValid)
            {
                FrmLogin frmLogin = new FrmLogin(connectString);
                frmLogin.ShowDialog();
                InitializeComponent();
                //  InitCOMPort();
            }
        }
        private bool CheckValidation()
        {
            RegistryKey localMachine = Registry.LocalMachine;
            RegistryKey registryKey = localMachine.OpenSubKey("Software\\GPRO\\QMS Counter Soft");
            bool result;
            if (registryKey != null)
            {
                string text = (string)registryKey.GetValue("SoftDate");
                registryKey.Close();
                if (text == null)
                {
                    MessageBox.Show("Phần mềm Điều Khiển Gọi Số chưa được đăng ký sử dụng.\nVui lòng đăng ký trước khi sử dụng.", "Thông báo Chưa đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    bRegistered = false;
                    result = false;
                }
                else
                {
                    int num = Convert.ToInt32(text, 16);
                    DateTime dateTime = new DateTime(2000 + int.Parse(num.ToString().Substring(0, 2)), int.Parse(num.ToString().Substring(2, 2)), int.Parse(num.ToString().Substring(4)));
                    if (DateTime.Compare(DateTime.Now, dateTime.AddDays(-7.0)) > 0 & DateTime.Compare(DateTime.Now, dateTime) < 0)
                    {
                        MessageBox.Show("Phần mềm Điều Khiển Gọi Số sắp hết hạn sử dụng. Bạn chỉ còn sử dụng được " + (dateTime - DateTime.Now).Days.ToString() + " ngày.\nVui lòng liên hệ Công ty TNHH Giải Pháp Công Nghệ Chuyên Nghiệp Phát Triển để gia hạn sử dụng.\nTrân trọng cảm ơn.", "Thông báo Hết hạn", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        bRegistered = false;
                        result = true;
                    }
                    else
                    {
                        if (DateTime.Compare(DateTime.Now, dateTime) > 0)
                        {
                            MessageBox.Show("Phần mềm Điều Khiển Gọi Số đã hết hạn sử dụng.\nVui lòng liên hệ Công ty TNHH Giải Pháp Công Nghệ Chuyên Nghiệp Phát Triển để gia hạn sử dụng.\nTrân trọng cảm ơn.", "Hết hạn dùng", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            bRegistered = false;
                            result = false;
                        }
                        else
                        {
                            bRegistered = true;
                            result = true;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Phần mềm Điều Khiển Gọi Số chưa được đăng ký sử dụng.\nVui lòng đăng ký trước khi sử dụng.", "Thông báo Chưa đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                bRegistered = false;
                result = false;
            }
            return result;
        }


        private void FrmMain4_Load(object sender, EventArgs e)
        {
            Rectangle screen = Screen.PrimaryScreen.WorkingArea;
            MaximumSize = new Size(screen.Width, 583);
            MinimumSize = new Size(screen.Width, 583);
            WindowState = FormWindowState.Maximized;
            StartPosition = FormStartPosition.CenterScreen;
            try
            {
                try
                {
                    connectString = BaseCore.Instance.GetEntityConnectString(Application.StartupPath + "\\DATA.XML");
                }
                catch (Exception) { }
                configs = BLLConfig.Instance.Gets(connectString, true);
                lib_Services = BLLService.Instance.GetsForMain(connectString);
                 
                int.TryParse(GetConfigByCode(eConfigCode.NumberOfLinePerTime), out so_lien);
                int.TryParse(GetConfigByCode(eConfigCode.PrintType), out printType);
                int.TryParse(GetConfigByCode(eConfigCode.CheckTimeBeforePrintTicket), out CheckTimeBeforePrintTicket);
                int.TryParse(GetConfigByCode(eConfigCode.PrintTicketReturnCurrentNumberOrServiceCode), out printTicketReturnCurrentNumberOrServiceCode);
                int.TryParse(GetConfigByCode(eConfigCode.StartNumber), out startNumber);
                int.TryParse(GetConfigByCode(eConfigCode.UseWithThirdPattern), out UseWithThirdPattern);

                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(Application.StartupPath + "\\DATA.XML");
                foreach (XmlElement element in xmlDoc.DocumentElement)
                {
                    if (element.Name.Equals("AppConfig"))
                    {
                        foreach (XmlNode node in element.ChildNodes)
                        {
                            try
                            {
                                switch (node.Name)
                                {
                                    //case "CounterId": numCounterId.Value = (!string.IsNullOrEmpty(node.InnerText) ? Convert.ToInt32(node.InnerText) : 1); break;
                                    case "Display": IsUseMainDisplay = Convert.ToBoolean(node.InnerText); break;
                                    case "COMDisplay": displaySerialCOM.PortName = node.InnerText; break;
                                    case "Print": UsePrintMachine = Convert.ToBoolean(node.InnerText); break;
                                    case "COMPrint": printSerialCOM.PortName = node.InnerText; break;
                                    //case "PrintCode": numPrinterId.Value = (!string.IsNullOrEmpty(node.InnerText) ? Convert.ToInt32(node.InnerText) : 1); ; break;
                                    case "ReadSound": IsReadSound = Convert.ToBoolean(node.InnerText); break;
                                    case "SoundPath": soundPath = node.InnerText; break;
                                    case "Template": ticketTemplate = node.InnerText; break;
                                    case "SoLien": so_lien = (!string.IsNullOrEmpty(node.InnerText) ? Convert.ToInt32(node.InnerText) : 1); ; break;
                                  }
                            }
                            catch (Exception ex)
                            {
                            }
                        }
                    }
                }
                 
                if (UsePrintMachine)
                    InitPrintComPort();
                 
                playlist = new List<string>();
                temp = new List<string>(); 

                if (IsUseMainDisplay)
                    InitDisplayCOMPort();

                serviceIds = (!string.IsNullOrEmpty(ConfigurationManager.AppSettings["ServiceIds"].ToString()) ? ConfigurationManager.AppSettings["ServiceIds"].ToString() : "1,2,3,4,5,6").Split(',').Select(x => Convert.ToInt32(x)).ToList();
                serviceObjs = BLLService.Instance.GetLookUp(connectString, false);
                serviceObjs = serviceObjs.Where(x => serviceIds.Contains(x.Id)).ToList();
                CreateServicesButton();

                if (loginObj != null)
                {
                    counterId = loginObj.CounterId;
                    equipCode = loginObj.EquipCode;
                }
                ShowResult();
            }
            catch (Exception ex)
            {
            }
        }

        #region Display COM port
        private void InitDisplayCOMPort()
        {
            try
            { 
                btDisplayStatus.Text = "Display " +  displaySerialCOM.PortName;
                displaySerialCOM.BaudRate = 9600;
                displaySerialCOM.DataBits = 8;
                displaySerialCOM.Parity =  Parity.None;
                displaySerialCOM.StopBits =  StopBits.One;
                try
                {
                    displaySerialCOM.Open();
                    btDisplayStatus.Image = global::GPRO_QMS_Counter.Properties.Resources.com_port;
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi: không thể kết nối với cổng COM Keypad, Vui lòng thử cấu hình lại kết nối", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lấy thông tin Com Keypad bị lỗi.\n" + ex.Message, "Lỗi Com Keypad");
            }
        }

        public static void SendDisplay(string sResult)
        {
            try
            {
                if (IsUseMainDisplay)
                {
                    string text = sResult;
                    if (text.Length < 4)
                        text = string.Format("{0:0000}", int.Parse(text));

                    byte[] array = new byte[3];
                    array[0] = 170;
                    byte[] array2 = array;
                    array2[1] = byte.Parse((int.Parse(text.Substring(0, 1)) * 16 + int.Parse(text.Substring(1, 1))).ToString());
                    array2[2] = byte.Parse((int.Parse(text.Substring(2, 1)) * 16 + int.Parse(text.Substring(3, 1))).ToString());
                    if (!displaySerialCOM.IsOpen)
                    {
                        try
                        {
                            displaySerialCOM.Open();
                            displaySerialCOM.DtrEnable = true;
                            displaySerialCOM.RtsEnable = true;
                        }
                        catch
                        {
                        }
                    }
                    displaySerialCOM.Write(array2, 0, array2.Length);
                }
            }
            catch (Exception)
            { }
        }

        #endregion

        #region Print COMPort
        private void InitPrintComPort()
        {
            try
            { 
                btPrintStatus.Text = "Printer " + printSerialCOM.PortName;
                printSerialCOM.BaudRate =9600;
                printSerialCOM.DataBits = 8;
                printSerialCOM.Parity =  Parity.None;
                printSerialCOM.StopBits =  StopBits.One; 
                try
                {
                    printSerialCOM.ReadTimeout = 1;
                    printSerialCOM.WriteTimeout = 1;
                    printSerialCOM.Open();
                    btPrintStatus.Image = global::GPRO_QMS_Counter.Properties.Resources.com_port; 
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi: không thể kết nối với cổng COM Keypad, Vui lòng thử cấu hình lại kết nối", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lấy thông tin Com Keypad bị lỗi.\n" + ex.Message, "Lỗi Com Keypad");
            }
        }


        #endregion

        private void CreateServicesButton()
        {
            try
            {
                if (serviceObjs.Count > 0)
                {
                    ServiceControl serviceControl;
                    ServiceControlModel model;
                    ModelSelectItem obj;
                    panel6.Controls.Clear();
                    int x = 5, y = 5;
                    for (int i = 0; i < serviceObjs.Count; i += 3)
                    {
                        obj = serviceObjs[i];
                        model = new ServiceControlModel() { Id = obj.Id, Name = obj.Name, wait = 0, Time = (!string.IsNullOrEmpty(obj.Code) ? obj.Code : "00:00:00") };
                        serviceControl = new ServiceControl(model);
                        serviceControl.Location = new System.Drawing.Point(x, y);
                        serviceControl.Name = "ctr" + i;
                        serviceControl.printTicketEvent += new EventHandler<PrintTicketEventArgs>(PrintTicket);
                        panel6.Controls.Add(serviceControl);

                        try
                        {
                            obj = serviceObjs[i + 1];
                            if (obj != null)
                            {
                                x += 280;
                                model = new ServiceControlModel() { Id = obj.Id, Name = obj.Name, wait = 0, Time = (!string.IsNullOrEmpty(obj.Code) ? obj.Code : "00:00:00") };
                                serviceControl = new ServiceControl(model);
                                serviceControl.Location = new System.Drawing.Point(x, y);
                                serviceControl.Name = "ctr" + (i + 1);
                                serviceControl.printTicketEvent += new EventHandler<PrintTicketEventArgs>(PrintTicket);
                                panel6.Controls.Add(serviceControl);
                            }

                            obj = serviceObjs[i + 2];
                            if (obj != null)
                            {
                                x += 280;
                                model = new ServiceControlModel() { Id = obj.Id, Name = obj.Name, wait = 0, Time = (!string.IsNullOrEmpty(obj.Code) ? obj.Code : "00:00:00") };
                                serviceControl = new ServiceControl(model);
                                serviceControl.Location = new System.Drawing.Point(x, y);
                                serviceControl.Name = "ctr" + (i + 2);
                                serviceControl.printTicketEvent += new EventHandler<PrintTicketEventArgs>(PrintTicket);
                                panel6.Controls.Add(serviceControl);

                                y += 75;
                                x = 5;
                            }
                        }
                        catch (Exception)
                        { }
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void PrintTicket(object sender, PrintTicketEventArgs e)
        {
            try
            {
                int lastTicket = 0,
                                newNumber = -1,
                            nghiepVu = 0;
                string printStr = string.Empty,
                    tenquay = string.Empty;
                bool err = false;
                ServiceDayModel serObj = null;
                DateTime now = DateTime.Now;
                switch (printType)
                {
                    case (int)ePrintType.TheoTungDichVu:
                        #region
                        serObj = lib_Services.FirstOrDefault(x => x.Id == e.Require.ServiceId);
                        if (serObj == null)
                            errorsms = "Dịch vụ số " + e.Require.ServiceId + " không tồn tại. Xin quý khách vui lòng chọn dịch vụ khác.";
                        else
                        {
                            if (CheckTimeBeforePrintTicket == 1 && serObj.Shifts.FirstOrDefault(x => now.TimeOfDay >= x.Start.TimeOfDay && now.TimeOfDay <= x.End.TimeOfDay) == null)
                                // temp.Add(SoundLockPrintTicket);
                                errorsms = "Dịch vụ số " + e.Require.ServiceId + " đã ngưng cấp số. Xin quý khách vui lòng đến vào buổi giao dịch sau.";
                            else
                            {
                                var rs = BLLDailyRequire.Instance.PrintNewTicket(connectString, e.Require.ServiceId, serObj.StartNumber, 0, now, printType, e.Require.ServeTime.TimeOfDay, txtname.Text, txtAdd.Text, ((int)txtDOB.Value), txtma.Text, "", "", "");
                                if (rs.IsSuccess)
                                {
                                    lastTicket = (int)rs.Data;
                                    nghiepVu = rs.Data_1;
                                    newNumber = ((int)rs.Data + 1);
                                    tenquay = rs.Data_2;
                                }
                                else
                                    errorsms = rs.Errors[0].Message;
                            }
                        }
                        #endregion
                        break;
                    case (int)ePrintType.BatDauChung:
                        #region MyRegion
                        serObj = lib_Services.FirstOrDefault(x => x.Id == e.Require.ServiceId);
                        if (serObj == null)
                            errorsms = "Dịch vụ số " + e.Require.ServiceId + " không tồn tại. Xin quý khách vui lòng chọn dịch vụ khác.";
                        else
                        {
                            if (CheckTimeBeforePrintTicket == 1 && serObj.Shifts.FirstOrDefault(x => now.TimeOfDay >= x.Start.TimeOfDay && now.TimeOfDay <= x.End.TimeOfDay) == null)
                                //temp.Add(SoundLockPrintTicket);
                                errorsms = "Dịch vụ số " + e.Require.ServiceId + " đã ngưng cấp số. Xin quý khách vui lòng đến vào buổi giao dịch sau.";
                            else
                            {
                                var rs = BLLDailyRequire.Instance.PrintNewTicket(connectString, e.Require.ServiceId, startNumber, 0, now, printType, (e.Require.ServeTime != null ? e.Require.ServeTime.TimeOfDay : serObj.TimeProcess.TimeOfDay), txtname.Text, txtAdd.Text, (int)txtDOB.Value, txtma.Text, "", "", "");
                                if (rs.IsSuccess)
                                {
                                    lastTicket = (int)rs.Data;
                                    nghiepVu = rs.Data_1;
                                    newNumber = ((int)rs.Data + 1);
                                    tenquay = rs.Data_2;
                                }
                                else
                                    errorsms = rs.Errors[0].Message;
                            }
                        }
                        #endregion
                        break;
                    case (int)ePrintType.TheoGioiHanSoPhieu:
                        #region MyRegion

                        #endregion
                        break;
                }

                if (newNumber >= 0)
                {
                    errorsms = printStr.ToString();
                    // dataSendToComport.Add(printStr);
                    Print(newNumber, lastTicket, tenquay, serObj.Name);
                }
            }
            catch (Exception)
            {
            }
        }



        #region quet thong tin
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                ShowResult();
            }
            catch (Exception)
            {
            }

        }

        private void ShowResult()
        {
            var obj = BLLLoginHistory.Instance.GetForHome(connectString, loginObj.UserId, equipCode, DateTime.Now, UseWithThirdPattern);// BLLUser.Instance.ReadResult(FrmMain.loginObj.EquipCode);
            if (obj != null)
            {
                this.lbWaiting.Text = obj.CounterWaitingTickets;
                this.lbGeneralWaiting.Text = obj.AllWaitingTickets;
                this.statusTotalWaiting.Text = "Đang đợi: " + obj.TotalWating;
                this.statusTotalDone.Text = "Đã giao dịch: " + obj.TotalDone;
                this.lbCurrentTicket.Text = obj.CurrentTicket.ToString();
                //this.lbCurrentTicket_s.Text = obj.CurrentTicket.ToString();
                // btnNext_small.Text = obj.CountWaitAtCounter.ToString(); 
            }
        }

        #endregion

        #region chu chay
        private void lbGeneralWaiting_TextChanged(object sender, EventArgs e)
        {
            if (this.lbGeneralWaiting.Text.Length > 26)
            {
                this.xPos = this.lbGeneralWaiting.Location.X;
                this.yPos = this.lbGeneralWaiting.Location.Y;
                if (!timer3.Enabled)
                    this.timer3.Start();
            }
            else
            {
                if (timer3.Enabled)
                    this.timer3.Stop();
                this.lbGeneralWaiting.Left = 4;
                this.lbGeneralWaiting.Top = 280;
            }
        }

        private void lbWaiting_TextChanged(object sender, EventArgs e)
        {
            if (this.lbWaiting.Text.Length > 26)
            {
                this.xPos1 = this.lbWaiting.Location.X;
                this.yPos1 = this.lbWaiting.Location.Y;
                if (!timer2.Enabled)
                    this.timer2.Start();
            }
            else
            {
                if (timer2.Enabled)
                    this.timer2.Stop();
                this.lbWaiting.Left = 4;
                this.lbWaiting.Top = 205;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                if (this.xPos1 <= -this.lbWaiting.Width)
                {
                    this.lbWaiting.Location = new Point(this.panel5.Width, this.yPos1);
                    this.xPos1 = this.panel5.Width;
                }
                else
                {
                    this.lbWaiting.Location = new Point(this.xPos1, this.yPos1);
                    this.xPos1 -= 3;
                }
            }
            catch (Exception)
            {
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            try
            {
                if (this.xPos <= -this.lbGeneralWaiting.Width)
                {
                    this.lbGeneralWaiting.Location = new Point(this.panel5.Width, this.yPos);
                    this.xPos = this.panel5.Width;
                }
                else
                {
                    this.lbGeneralWaiting.Location = new Point(this.xPos, this.yPos);
                    this.xPos -= 3;
                }
            }
            catch (Exception)
            {
            }
        }

        #endregion

        private void Print(int newNum, int oldNum, string tenquay, string tendichvu)
        {
            var template = ticketTemplate;
            var now = DateTime.Now;
            template = template.Replace("[canh-giua]", "\x1b\x61\x01|+|");
            template = template.Replace("[canh-trai]", "\x1b\x61\x00|+|");
            template = template.Replace("[1x1]", "\x1d\x21\x00|+|");
            template = template.Replace("[2x1]", "\x1d\x21\x01|+|");
            template = template.Replace("[3x1]", "\x1d\x21\x02|+|");
            template = template.Replace("[2x2]", "\x1d\x21\x11|+|");
            template = template.Replace("[3x3]", "\x1d\x21\x22|+|");

            template = template.Replace("[STT]", newNum.ToString());
            template = template.Replace("[ten-quay]", tenquay);
            template = template.Replace("[ten-dich-vu]", tendichvu);
            template = template.Replace("[ngay]", ("ngay: " + now.ToString("dd/MM/yyyy")));
            template = template.Replace("[gio]", (" gio: " + now.ToString("HH/mm")));
            template = template.Replace("[dang-goi]", " dang goi " + oldNum);
            template = template.Replace("[cat-giay]", "\x1b\x69|+|");

            var arr = template.Split(new string[] { "|+|" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            for (int ii = 0; ii < so_lien; ii++)
                for (int i = 0; i < arr.Length; i++)
                    printSerialCOM.Write(arr[i]);
            UpdateServiceInfo();
            ShowResult();
        }

        private void UpdateServiceInfo()
        {
            try
            {
                int i = 0;
                var serviceObjs = BLLService.Instance.GetLookUp(connectString, true);
                serviceObjs = serviceObjs.Where(x => serviceIds.Contains(x.Id)).ToList();
                foreach (Control c in panel6.Controls)
                {
                    ((IServiceControl)c).updateWaiting(serviceObjs[i].Data);
                    i++;
                }
                //Thread.Sleep(1000);
            }
            catch (Exception)
            {
            }
        }

        private void FrmMain4_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (loginObj != null && !string.IsNullOrEmpty(connectString))
                    BLLLoginHistory.Instance.CounterLoginLogOut(connectString, loginObj.UserId, equipCode, DateTime.Now);
                if (displaySerialCOM.IsOpen)
                    displaySerialCOM.Close();
                if (printSerialCOM.IsOpen)
                    printSerialCOM.Close();
            }
            catch (Exception)
            {
            }

        }

        private string GetConfigByCode(string code)
        {
            if (configs != null && configs.Count > 0)
            {
                var obj = configs.FirstOrDefault(x => x.Code.Trim().ToUpper().Equals(code.Trim().ToUpper()));
                return obj != null ? obj.Value : string.Empty;
            }
            return string.Empty;
        }

        #region menu
        private void btConnectSQL_Click(object sender, EventArgs e)
        {
            var f = new FrmSQLConnect();
            f.ShowDialog();
        }

        private void btTemplate_Click(object sender, EventArgs e)
        {
            var f = new FrmTicketTemplate();
            f.ShowDialog();
        }

        private void btSetting_Click(object sender, EventArgs e)
        {
            var f = new FrmConfig();
            f.ShowDialog();
        }
        #endregion

        #region button event
        private void btNext_Click(object sender, EventArgs e)
        {
            try
            {
                var tk = BLLDailyRequire.Instance.Next(connectString, loginObj.UserId, equipCode, today, UseWithThirdPattern);
                if (tk == 0)
                    txtResult.Text = "Hết vé";
                else
                {
                    lbCurrentTicket.Text = tk.ToString();
                    SendDisplay(tk.ToString());

                    var requireJSON = JsonConvert.SerializeObject(new RequireMainDisplay() { EquipCode = equipCode, TicketNumber = tk });
                    BLLCounterSoftRequire.Instance.Insert(connectString, requireJSON, (int)eCounterSoftRequireType.SendNextToMainDisplay, counterId);
                    var readTemplateIds = BLLUserCmdReadSound.Instance.GetReadTemplateIds(connectString, loginObj.UserId, eCodeHex.Next);
                    if (readTemplateIds.Count > 0)
                        GetSound(readTemplateIds, tk.ToString(), counterId);
                }
                ShowResult();
            }
            catch (Exception)
            { }
        }

        private void btRecall_Click(object sender, EventArgs e)
        {
            int kq = BLLDailyRequire.Instance.CurrentTicket(connectString, loginObj.UserId, equipCode, today, UseWithThirdPattern);
            if (kq == 0)
                txtResult.Text = "Hết vé";
            else
            {
                lbCurrentTicket.Text = kq.ToString();
                SendDisplay(kq.ToString());

                var requireJSON = JsonConvert.SerializeObject(new RequireMainDisplay() { EquipCode = equipCode, TicketNumber = kq });
                BLLCounterSoftRequire.Instance.Insert(connectString, requireJSON, (int)eCounterSoftRequireType.SendRecallToMainDisplay, counterId);

                var readTemplateIds = BLLUserCmdReadSound.Instance.GetReadTemplateIds(connectString, loginObj.UserId, eCodeHex.Recall);
                if (readTemplateIds.Count > 0)
                    GetSound(readTemplateIds, kq.ToString(), counterId);
            }
            ShowResult();
        }

        private void btFinish_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = "";
            string text = this.lbCurrentTicket.Text;
            if (text != "" && text != "0")
                BLLDailyRequire.Instance.DoneTicket(connectString, loginObj.UserId, equipCode, DateTime.Now);
            ShowResult();

        }

        private void btCallAnyTicket_Click(object sender, EventArgs e)
        {
            try
            {
                this.txtResult.Text = "";
                string text = this.txtParam.Text.ToString().Trim();
                if (!string.IsNullOrEmpty(text) && !Information.IsNumeric(text))
                {
                    //MessageBox.Show("Bạn phải nhập số vé bất kỳ muốn gọi.", "Thông báo gọi vé", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.txtResult.Text = "Bạn phải nhập số vé bất kỳ muốn gọi.";
                    this.txtParam.Focus();
                }
                else
                {
                    var dscho = lbWaiting.Text.Split(' ').ToList();
                    if (dscho.Contains(text))
                    {
                        var kq = BLLDailyRequire.Instance.CallAny(connectString, loginObj.UserId, equipCode, int.Parse(text), today);
                        if (kq.IsSuccess)
                        {
                            this.txtParam.Text = "";
                            this.txtResult.Text = "Yêu cầu Gọi số " + text;
                            lbCurrentTicket.Text = text;
                            SendDisplay(text);

                            var readTemplateIds = BLLUserCmdReadSound.Instance.GetReadTemplateIds(connectString, loginObj.UserId, eCodeHex.Next);
                            if (readTemplateIds.Count > 0)
                                GetSound(readTemplateIds, text, counterId);
                        }
                        else
                        {
                            this.txtParam.Text = "";
                            this.txtResult.Text = kq.sms;
                        }
                    }
                    else
                        this.txtResult.Text = "Số : " + text + " không có trong danh sách chờ của Quầy .Vui lòng nhập số nằm trong danh sách chờ của Quầy.";
                    // MessageBox.Show("Số : " + text + " không có trong danh sách chờ của Quầy .Vui lòng nhập số nằm trong danh sách chờ của Quầy.", "Thông báo gọi vé", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                ShowResult();
            }
            catch (Exception)
            {
            }

        }

        private void btTranfer_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(lbCurrentTicket.Text) && lbCurrentTicket.Text != "0") || !string.IsNullOrEmpty(txtParam.Text))
            {
                var now = DateTime.Now;
                txtResult.Text = "";
                var f = new FrmChange(!string.IsNullOrEmpty(txtParam.Text) ? int.Parse(txtParam.Text) : int.Parse(lbCurrentTicket.Text), equipCode);
                f.ShowDialog();
            }
            else
                this.txtResult.Text = "Không thể thực hiện chuyển vé chưa xác định!";
            ShowResult();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            string text = txtParam.Text.Trim();
            if (text == "")
                text = this.lbCurrentTicket.Text;
            if (!string.IsNullOrEmpty(text) && text.All(char.IsDigit))
            {
                DialogResult dialogResult = MessageBox.Show("Bạn muốn hủy vé " + text + " phải không?", "Thông báo hủy vé", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dialogResult == DialogResult.Yes)
                {
                    if (BLLDailyRequire.Instance.DeleteTicket(connectString, int.Parse(text), today) > 0)
                    {
                        this.txtParam.Text = "";
                        this.txtResult.Text = "Yêu cầu Hủy vé " + text;
                    }
                }
            }
            ShowResult();
        }
        #endregion

        #region Sound
        private void TmerQuetComport_Tick(object sender, EventArgs e)
        {
            try
            {
                if (IsReadSound && isFinishRead && temp != null && temp.Count > 0)
                {
                    player = new SoundPlayer();
                    playThread = new Thread(PlaySound);
                    playThread.Start();
                }
            }
            catch (Exception)
            {
            }
        }

        public void PlaySound()
        {
            try
            {
                while (true)
                {
                    if (temp.Count > 0)
                    {
                        if (isFinishRead)
                        {
                            isFinishRead = false;
                            ReadSound(temp);
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void ReadSound(List<string> sounds)
        {
            if (sounds.Count > 0)
            {
                while (temp.Count > 0)
                {

                    player.SoundLocation = (soundPath + temp[0]);
                    int iTime = SoundInfo.GetSoundLength(player.SoundLocation.Trim()) - 0;
                    player.Play();
                    Thread.Sleep(iTime);
                    temp.Remove(temp[0]);
                }
            }
            isFinishRead = true;
            playThread.Abort();
        }

        public static void GetSound(List<int> templateIds, string ticket, int counterId)
        {
            var readDetails = BLLReadTempDetail.Instance.Gets(connectString, templateIds);
            if (readDetails.Count > 0)
            {
                var sounds = BLLSound.Instance.Gets(connectString);
                SoundModel soundFound;
                var soundStr = string.Empty;
                if (sounds.Count > 0)
                {
                    playlist.Clear();
                    for (int y = 0; y < readDetails.Count; y++)
                    {
                        if (readDetails[y].Details.Count > 0)
                        {
                            for (int i = 0; i < readDetails[y].Details.Count; i++)
                            {
                                if (readDetails[y].Details[i].SoundId == (int)eSoundConfig.Ticket)
                                {
                                    for (int j = 0; j < ticket.Length; j++)
                                    {
                                        soundFound = sounds.FirstOrDefault(x => x.Code != null && x.Code.Equals(ticket[j] + "") && x.LanguageId == readDetails[y].LanguageId);
                                        if (soundFound != null)
                                        {
                                            playlist.Add(soundFound.Name);
                                            soundStr += soundFound.Name + "|";
                                        }
                                    }
                                }
                                else if (readDetails[y].Details[i].SoundId == (int)eSoundConfig.Counter)
                                {
                                    var name = BLLCounterSound.Instance.GetSoundName(connectString, counterId, readDetails[y].LanguageId);
                                    if (!string.IsNullOrEmpty(name))
                                    {
                                        playlist.Add(name);
                                        soundStr += name + "|";
                                    }
                                }
                                else
                                {
                                    soundFound = sounds.FirstOrDefault(x => x.Id == readDetails[y].Details[i].SoundId);
                                    if (soundFound != null)
                                    {
                                        playlist.Add(soundFound.Name);
                                        soundStr += soundFound.Name + "|";
                                    }
                                }
                            }
                        }
                    }
                    temp.AddRange(playlist);
                    if (!string.IsNullOrEmpty(soundStr))
                    {
                        soundStr = soundStr.Substring(0, soundStr.Length - 1);
                        BLLCounterSoftRequire.Instance.Insert(connectString, soundStr, (int)eCounterSoftRequireType.ReadSound, counterId);
                    }
                }
            }
        }
        #endregion  


    }
}
