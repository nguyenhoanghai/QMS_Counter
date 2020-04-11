using DevExpress.XtraBars;
using GPRO.Core.Hai;
using GPRO_QMS_Counter.Helper;
using Microsoft.Win32;
using QMS_System.Data.BLL;
using QMS_System.Data.Enum;
using QMS_System.Data.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO.Ports;
using System.Linq;
using System.Media;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace GPRO_QMS_Counter
{
    public partial class FrmMain2 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        List<ConfigModel> configs;
        public static Login loginObj;
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
        public static DateTime today = DateTime.Now;
        public static SerialPort
            printSerialCOM = new SerialPort(),
            displaySerialCOM = new SerialPort();
        public static bool IsUseMainDisplay = false;
        public static List<ServiceDayModel> lib_Services;
        public static List<ModelSelectItem> serviceObjs;
        List<string> dataSendToComport = new List<string>();
        int q = -1;
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
        public static List<int> serviceIds;


        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (printSerialCOM.IsOpen)
            {
                printSerialCOM.Write("\x1b\x61\x01"); //canh giua
                printSerialCOM.Write("\x1d\x21\x01"); // font 2x1

                printSerialCOM.Write("Cong ty tnhh cn cn phat trien\n");
                printSerialCOM.Write("============================================\n");
                printSerialCOM.Write("\x1d\x21\x00"); // font normal
                printSerialCOM.Write("Dia chi: 36/1c nguyen khuyen p.6 quan binh thanh tp ho chi minh\n");
                printSerialCOM.Write("\x1d\x21\x22"); // font 3x3
                printSerialCOM.Write("1001");
                printSerialCOM.Write("\n");
                printSerialCOM.Write("\x1d\x21\x01"); // font 2x1
                printSerialCOM.Write("Quay 1");
                printSerialCOM.Write("\n");
                printSerialCOM.Write("\x1b\x61\x00"); //canh trai
                printSerialCOM.Write("\x1d\x21\x00"); // font normal
                printSerialCOM.Write("Cau huong dan\n");
                printSerialCOM.Write("\x1b\x61\x01"); //canh giua
                printSerialCOM.Write("-------------------------");
                printSerialCOM.Write("\n");
                printSerialCOM.Write("\x1b\x61\x00"); //canh trai
                printSerialCOM.Write("Ngay: 1/1/2019 Gio: 10:10 Dang goi: 4001\n");
                printSerialCOM.Write("\n\n\n\x1b\x69");
            }
        }

        private void FrmMain2_MdiChildActivate(object sender, EventArgs e)
        {
            try
            {
                if (genUserTabFinish)
                    if (MdiChildren.Any())
                    {
                        if (this.ActiveMdiChild is IChildMethods)
                            ((IChildMethods)this.ActiveMdiChild).enableTimer();

                        var control = ((System.Windows.Forms.ContainerControl)sender).ActiveControl;
                        foreach (Form f in this.MdiChildren)
                        {
                            if (f.GetType() == typeof(FrmMain3))
                            {
                                if (f.Text != control.Text)
                                    ((IChildMethods)f).disableTimer();

                            }
                        }
                    }
            }
            catch (Exception)
            {
            }
        }

        private void btnCauHinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = IsActive(typeof(FrmConfig));
            if (frm == null)
            {
                var forms = new FrmConfig();
                forms.MdiParent = this;
                forms.Show();
            }
            else
                frm.Activate();
        }

        private void btnTicketTemplate_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = IsActive(typeof(FrmTicketTemplate));
            if (frm == null)
            {
                var forms = new FrmTicketTemplate();
                forms.MdiParent = this;
                forms.Show();
            }
            else
                frm.Activate();
        }

        private void btconnectsql_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = IsActive(typeof(FrmSQLConnect));
            if (frm == null)
            {
                var forms = new FrmSQLConnect();
                forms.MdiParent = this;
                forms.Show();
            }
            else
                frm.Activate();
        }

        bool isSendDataKeyPad = false;
        public FrmMain2()
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

        private void btActive_ItemClick(object sender, ItemClickEventArgs e)
        {
            var forms = new FrmRegister();
            forms.Show();
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void FrmMain2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (printSerialCOM.IsOpen)
                printSerialCOM.Close();

            if (displaySerialCOM.IsOpen)
                displaySerialCOM.Close();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            MdiChildren.Any();
            var currentItems = new List<string>();
            foreach (var item in MdiChildren)
            {
                currentItems.Add(item.Text);
            }

            var genCounter = loginObj.Counters.Where(x => !currentItems.Contains(x.CounterName)).ToList();
            if (genCounter.Count > 0)
            {
                for (int i = 0; i < genCounter.Count; i++)
                {
                    var f = new FrmMain3(genCounter[i]);
                    f.Text = genCounter[i].CounterName;
                    f.MdiParent = this;
                    f.Show();
                }
            }
            genUserTabFinish = true;

            //check call active
            if (MdiChildren.Any())
                if (this.ActiveMdiChild is IChildMethods)
                    ((IChildMethods)this.ActiveMdiChild).enableTimer();
        }

        private void FrmMain2_Load(object sender, EventArgs e)
        {
            try
            {
                // mo chuc nang cau hinh cho admin
                if (loginObj == null)
                    ribbonPage2.Visible = true;

                try
                {
                    connectString = BaseCore.Instance.GetEntityConnectString(Application.StartupPath + "\\DATA.XML");
                }
                catch (Exception)
                { }
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
                if (loginObj != null && loginObj.Counters != null && loginObj.Counters.Count > 0)
                {
                    // var logins = BLLLoginHistory.Instance.GetsForMain(connectString);
                    // for (int i = 1; i < logins.Count; i++) 
                    for (int i = 0; i < loginObj.Counters.Count; i++)
                    {
                        var f = new FrmMain3(loginObj.Counters[i]);
                        f.Text = loginObj.Counters[i].CounterName;
                        f.MdiParent = this;
                        f.Show();
                    }
                }
                genUserTabFinish = true;

                //check call active
                if (MdiChildren.Any())
                    if (this.ActiveMdiChild is IChildMethods)
                        ((IChildMethods)this.ActiveMdiChild).enableTimer();
                playlist = new List<string>();
                temp = new List<string>();

                if (IsUseMainDisplay)
                    InitDisplayCOMPort();

                serviceIds = (!string.IsNullOrEmpty(ConfigurationManager.AppSettings["ServiceIds"].ToString()) ? ConfigurationManager.AppSettings["ServiceIds"].ToString() : "1,2,3,4,5,6").Split(',').Select(x => Convert.ToInt32(x)).ToList();
                serviceObjs = BLLService.Instance.GetLookUp(connectString, false);
                serviceObjs = serviceObjs.Where(x => serviceIds.Contains(x.Id)).ToList();
            }
            catch (Exception)
            {
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


        private string GetConfigByCode(string code)
        {
            if (configs != null && configs.Count > 0)
            {
                var obj = configs.FirstOrDefault(x => x.Code.Trim().ToUpper().Equals(code.Trim().ToUpper()));
                return obj != null ? obj.Value : string.Empty;
            }
            return string.Empty;
        }

        private void barBTPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = IsActive(typeof(FrmPrintTicket));
            if (frm == null)
            {
                var forms = new FrmPrintTicket(connectString);
                forms.MdiParent = this;
                forms.Show();
            }
            else
                frm.Activate();
        }

        private Form IsActive(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }

        #region Print COMPort
        private void InitPrintComPort()
        {
            try
            {
                barBtPrintComStatus.Caption = "Printer " + printSerialCOM.PortName;
                printSerialCOM.BaudRate = 9600;
                printSerialCOM.DataBits = 8;
                printSerialCOM.Parity = Parity.None;
                printSerialCOM.StopBits = StopBits.One;
                try
                {
                    printSerialCOM.Open();
                    barBtPrintComStatus.Glyph = global::GPRO_QMS_Counter.Properties.Resources.com_port;
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

        #region Display COM port
        private void InitDisplayCOMPort()
        {
            try
            {
                barBtDisplayComStatus.Caption = "Display " + displaySerialCOM.PortName;
                displaySerialCOM.BaudRate = 9600;
                displaySerialCOM.DataBits = 8;
                displaySerialCOM.Parity = Parity.None;
                displaySerialCOM.StopBits = StopBits.One;
                try
                {
                    displaySerialCOM.Open();
                    barBtDisplayComStatus.Glyph = global::GPRO_QMS_Counter.Properties.Resources.com_port;
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

    }
}