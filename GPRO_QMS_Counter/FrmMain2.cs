using DevExpress.XtraBars;
using GPRO.Core.Hai;
using GPRO_QMS_Counter.Helper;
using GPRO_QMS_Counter.Properties;
using Microsoft.Win32;
using QMS_System.Data.BLL;
using QMS_System.Data.Enum;
using QMS_System.Data.Model;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace GPRO_QMS_Counter
{
    public partial class FrmMain2 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        List<ConfigModel> configs;
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
        public static SerialPort comPort = new SerialPort();
        public static List<ServiceDayModel> lib_Services;
        List<string> dataSendToComport = new List<string>();
        int q = -1;
        bool genUserTabFinish = false,
            IsReadSound = false,
            isFinishRead = true,
            bRegistered = false, 
            bCheckValid = false;
        static List<string> temp, playlist;
        SoundPlayer player;
        Thread playThread;
        string soundPath = string.Empty;

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (comPort.IsOpen)
            {
                comPort.Write("\x1b\x61\x01"); //canh giua
                comPort.Write("\x1d\x21\x01"); // font 2x1

                comPort.Write("Cong ty tnhh cn cn phat trien\n");
                comPort.Write("============================================\n");
                comPort.Write("\x1d\x21\x00"); // font normal
                comPort.Write("Dia chi: 36/1c nguyen khuyen p.6 quan binh thanh tp ho chi minh\n");
                comPort.Write("\x1d\x21\x22"); // font 3x3
                comPort.Write("1001");
                comPort.Write("\n");
                comPort.Write("\x1d\x21\x01"); // font 2x1
                comPort.Write("Quay 1");
                comPort.Write("\n");
                comPort.Write("\x1b\x61\x00"); //canh trai
                comPort.Write("\x1d\x21\x00"); // font normal
                comPort.Write("Cau huong dan\n");
                comPort.Write("\x1b\x61\x01"); //canh giua
                comPort.Write("-------------------------");
                comPort.Write("\n");
                comPort.Write("\x1b\x61\x00"); //canh trai
                comPort.Write("Ngay: 1/1/2019 Gio: 10:10 Dang goi: 4001\n");
                comPort.Write("\n\n\n\x1b\x69");
            }
        }

        private void FrmMain2_MdiChildActivate(object sender, EventArgs e)
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
                FrmLogin frmLogin = new FrmLogin();
                frmLogin.ShowDialog();
                InitializeComponent();
              //  InitCOMPort();
            }
        }

        private void FrmMain2_Load(object sender, EventArgs e)
        {
            try
            {
                connectString = BaseCore.Instance.GetEntityConnectString(Application.StartupPath + "\\DATA.XML");
            }
            catch (Exception)
            { }
            configs = BLLConfig.Instance.Gets(connectString, true);
            lib_Services = BLLService.Instance.GetsForMain(connectString);
            ticketTemplate = Settings.Default.ticketTemplate; // GetConfigByCode(eConfigCode.TicketTemplate);
            int.TryParse(GetConfigByCode(eConfigCode.NumberOfLinePerTime), out so_lien);
            int.TryParse(GetConfigByCode(eConfigCode.PrintType), out printType);
            int.TryParse(GetConfigByCode(eConfigCode.CheckTimeBeforePrintTicket), out CheckTimeBeforePrintTicket);
            int.TryParse(GetConfigByCode(eConfigCode.PrintTicketReturnCurrentNumberOrServiceCode), out printTicketReturnCurrentNumberOrServiceCode);
            int.TryParse(GetConfigByCode(eConfigCode.StartNumber), out startNumber);
            int.TryParse(GetConfigByCode(eConfigCode.UseWithThirdPattern), out UseWithThirdPattern);
            soundPath = Settings.Default.soundFolder;
            InitComPort();

            FrmMain.loginObj.

            var logins = BLLLoginHistory.Instance.GetsForMain(connectString);
            for (int i = 1; i < logins.Count; i++)
            {
                var f = new FrmMain3(logins[i]);
                f.Text = logins[i].CounterName;
                f.MdiParent = this;
                f.Show();
            }
            genUserTabFinish = true;

            //check call active
            if (MdiChildren.Any())
                if (this.ActiveMdiChild is IChildMethods)
                    ((IChildMethods)this.ActiveMdiChild).enableTimer();
            IsReadSound = Settings.Default.IsReadSound;
            playlist = new List<string>();
            temp = new List<string>();
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

        #region Keypad COMPort
        private void InitComPort()
        {
            try
            {
                comPort.PortName = Settings.Default.COMPort;
                comPort.BaudRate = Settings.Default.BaudRate;
                comPort.DataBits = Settings.Default.DataBits;
                comPort.Parity = Settings.Default.Parity;
                comPort.StopBits = Settings.Default.StopBits;
                comPort.Encoding = Encoding.GetEncoding("iso-8859-1");
                try
                {
                    FrmMain2.comPort.ReadTimeout = 1;
                    FrmMain2.comPort.WriteTimeout = 1;
                    FrmMain2.comPort.Open();
                    barBtComStatus.Glyph = global::GPRO_QMS_Counter.Properties.Resources.com_port;
                    // FrmMain2.comPort.DataReceived += new SerialDataReceivedEventHandler(comPort_DataReceived);
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

        //private void comPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        //{
        //    this.Invoke(new EventHandler(RecieverData));
        //}

        public void PrintNewTicket(int printerId,
            int serviceId,
            int businessId,
            bool isTouchScreen,
            bool isProgrammer,
            TimeSpan? timeServeAllow,
            string Name,
            string Address,
            int? DOB,
             string MaBenhNhan,
            string MaPhongKham,
            string SttPhongKham,
            string SoXe
            )
        {

        }


        private void TmerQuetComport_Tick(object sender, EventArgs e)
        {
            try
            {
                if (comPort.IsOpen)
                {
                    q++;
                    if (dataSendToComport.Count > 0)
                    {
                        if (!isSendDataKeyPad)
                        {
                            q = 0;
                            isSendDataKeyPad = true;
                        }
                        if (q < dataSendToComport.Count())
                        {
                            SendRequest(dataSendToComport[q]);
                            // lbSendData = dataSendToComport[q];
                            // lbQuet.Caption = dataSendToComport[q].ToString().Replace(' ', ',');
                        }
                        else
                        {
                            q = -1;
                            dataSendToComport.Clear();
                            isSendDataKeyPad = false;
                        }
                    }
                    //else
                    //{
                    //    if (q < equipmentIds.Count())
                    //    {
                    //        lbSendrequest = equipmentIds[q];
                    //        SendRequest(("AA " + equipmentIds[q]));
                    //        lbQuet.Caption = lbSendrequest;
                    //        if (q == (equipmentIds.Count() - 1))
                    //            q = -1;
                    //    }
                    //    else
                    //        q = -1;
                    //}
                }

                lbErrorsms.Caption = errorsms;
            }
            catch (Exception ex)
            {
            }

            if (IsReadSound && isFinishRead && temp != null && temp.Count > 0)
            {
                player = new SoundPlayer();
                playThread = new Thread(PlaySound);
                playThread.Start();
            }
        }

        private void SendRequest(string value)
        {
            try
            {
                byte[] newMsg = BaseCore.Instance.HexStringToByteArray(value);
                comPort.Write(newMsg, 0, newMsg.Length);
                Thread.Sleep(20);
            }
            catch
            { }
        }

        private void CounterProcess(string[] hexStr)
        {
        }


        #endregion

        #region Sound
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
                        BLLCounterSoftRequire.Instance.Insert(connectString, soundStr, (int)eCounterSoftRequireType.ReadSound);
                    }
                }
            }
        }
        #endregion
    }
}