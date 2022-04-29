﻿using GPRO.Core.Hai;
using GPRO_QMS_Counter.Helper;
using Microsoft.VisualBasic;
using Microsoft.Win32;
using Newtonsoft.Json;
using QMS_System.Data.BLL;
using QMS_System.Data.Enum;
using QMS_System.Data.Model;
using Quobject.SocketIoClientDotNet.Client;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace GPRO_QMS_Counter
{
    public partial class FrmMainPK_Socket : Form
    {
        public static string
             connectString,
             errorsms,
             SoundLockPrintTicket = "khoa.wav",
             ticketTemplate,
            nodeServerIP = "192.168.1.10:3000",
            TVReadsound = "0",
            socketId;
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
            displaySerialCOM = new SerialPort();

        List<ConfigModel> configs;
        List<string> dataSendToComport = new List<string>();
        int q = -1,
            equipCode = 0,
            counterId = 0,
             xPos = 0,
            yPos = 230,
            xPos1 = 0,
            yPos1 = 135,
            soNutDV1dong = 3;
        bool genUserTabFinish = false,
            IsReadSound = false,
            isFinishRead = true,
            bRegistered = false,
            bCheckValid = false,
            UsePrintMachine = false,
            FirstLoad = true;

        public SqlConnection sqlCon = new SqlConnection();
        static List<string> temp, playlist;
        SoundPlayer player;
        Thread playThread ;


        string soundPath = string.Empty;
        public FrmMainPK_Socket()
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

        private void FrmMainPK_Socket_Load(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    connectString = BaseCore.Instance.GetEntityConnectString(Application.StartupPath + "\\DATA.XML");
                    ConnectDatabase();
                }
                catch (Exception) { }
                configs = BLLConfig.Instance.Gets(connectString, true);

                int.TryParse(GetConfigByCode(eConfigCode.NumberOfLinePerTime), out so_lien);
                int.TryParse(GetConfigByCode(eConfigCode.PrintType), out printType);
                int.TryParse(GetConfigByCode(eConfigCode.CheckTimeBeforePrintTicket), out CheckTimeBeforePrintTicket);
                int.TryParse(GetConfigByCode(eConfigCode.PrintTicketReturnCurrentNumberOrServiceCode), out printTicketReturnCurrentNumberOrServiceCode);
                int.TryParse(GetConfigByCode(eConfigCode.StartNumber), out startNumber);
                int.TryParse(GetConfigByCode(eConfigCode.UseWithThirdPattern), out UseWithThirdPattern);
                TVReadsound = BLLConfig.Instance.GetConfigByCode(connectString, eConfigCode.TVReadSound);
                nodeServerIP = GetConfigByCode(eConfigCode.NodeServerIP);

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
                                    //case "Print": UsePrintMachine = Convert.ToBoolean(node.InnerText); break;
                                    // case "COMPrint": printSerialCOM.PortName = node.InnerText; break;
                                    //case "PrintCode": numPrinterId.Value = (!string.IsNullOrEmpty(node.InnerText) ? Convert.ToInt32(node.InnerText) : 1); ; break;
                                    case "ReadSound": IsReadSound = Convert.ToBoolean(node.InnerText); break;
                                    case "SoundPath": soundPath = node.InnerText; break;
                                    case "Template": ticketTemplate = node.InnerText; break;
                                    case "SoLien": so_lien = (!string.IsNullOrEmpty(node.InnerText) ? Convert.ToInt32(node.InnerText) : 1); ; break;
                                    case "NumberOfButton": soNutDV1dong = (!string.IsNullOrEmpty(node.InnerText) ? Convert.ToInt32(node.InnerText) : 3); ; break;
                                }
                            }
                            catch (Exception ex)
                            {
                            }
                        }
                    }
                }

                ConnectSocketIO();
                playlist = new List<string>();
                temp = new List<string>();

                if (IsReadSound)
                    timerDocAmThanh.Enabled = true;

                if (IsUseMainDisplay)
                    InitDisplayCOMPort();

                if (loginObj != null)
                {
                    counterId = loginObj.CounterId;
                    equipCode = loginObj.EquipCode;
                    lbUserName.Text = loginObj.UserName + " " + loginObj.LoginTime + " | IP Address: " + BaseCore.Instance.GetLocalIPAddress();
                }

                if (loginObj.UserName.ToLower().Equals("gpro admin"))
                {
                    btConnectSQL.Enabled = true;
                    btSetting.Enabled = true;
                    btTemplate.Enabled = true;
                }


                //refreshThread = new Thread(refreshData);
                //refreshThread.IsBackground = true;
                //refreshThread.Start();
                ShowResult();
            }
            catch (Exception ex)
            {
            }
        }

        bool CheckValidation()
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

        #region Form event
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đóng ứng dụng gọi số tự động?", "Đóng ứng dụng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (socket != null)
                        socket.Disconnect();
                }
                catch (Exception ex)
                { }

                Application.Exit();
            }
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btnMaximize.Visible = false;
            btnNormalSize.Visible = true;
            btnNormalSize.Location = new Point(btnMaximize.Location.X, btnMaximize.Location.Y);
        }
        private void btnNormalSize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btnMaximize.Visible = true;
            btnNormalSize.Visible = false;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region kéo form 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void ConnectDatabase()
        {
            string strConnectionString = DatabaseConnection.Instance.GetConnectionString(Application.StartupPath + "\\DATA.XML");
            try
            {
                sqlCon = new SqlConnection(strConnectionString);
                sqlCon.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi ConnectDatabase: Không thể kết nối với CSDL, Vui lòng thử cấu hình lại kết nối", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FrmSQLConnect form = new FrmSQLConnect();
                form.Show();
            }
        }

        private void FrmMainPK_Socket_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (socket != null)
                socket.Disconnect();
        }

        private void FrmMainPK_Socket_FormClosing(object sender, FormClosingEventArgs e)
        {

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

        #region Display COM port
        private void InitDisplayCOMPort()
        {
            try
            {
                btDisplayStatus.Text = "Display " + displaySerialCOM.PortName;
                displaySerialCOM.BaudRate = 9600;
                displaySerialCOM.DataBits = 8;
                displaySerialCOM.Parity = Parity.None;
                displaySerialCOM.StopBits = StopBits.One;
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

        public void SendDisplay(string sResult)
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
                    try
                    {
                        player.SoundLocation = (soundPath + temp[0]);
                        int iTime = SoundInfo.GetSoundLength(player.SoundLocation.Trim()) - 0;
                        player.Play();
                        Thread.Sleep(iTime);
                    }
                    catch (Exception)
                    {
                    }

                    temp.Remove(temp[0]);
                }
            }
            isFinishRead = true;
            playThread.Abort();
        }

        public static void GetSound(List<int> templateIds, string ticket, int counterId, string tvReadSound)
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

                        if (!string.IsNullOrEmpty(soundStr) && !string.IsNullOrEmpty(tvReadSound) && tvReadSound == "1")
                        {
                            BLLCounterSoftRequire.Instance.Insert(connectString, soundStr, (int)eCounterSoftRequireType.TVReadSound, counterId);
                        }
                    }
                }
            }
        }
        #endregion

        #region button event

        private void btnGoiUuTien_Click(object sender, EventArgs e)
        {
            try
            {
                //var tk = BLLDailyRequire.Instance.Next_KetLuan(connectString, loginObj.UserId, equipCode, today, UseWithThirdPattern);
                //if (tk == 0)
                //    txtResult.Text = "Hết vé";
                //else
                //{
                //    lbCurrentTicket.Text = tk.ToString();
                //    SendDisplay(tk.ToString());

                //    var requireJSON = JsonConvert.SerializeObject(new RequireMainDisplay() { EquipCode = equipCode, TicketNumber = tk });
                //    BLLCounterSoftRequire.Instance.Insert(connectString, requireJSON, (int)eCounterSoftRequireType.SendNextToMainDisplay, counterId);
                //    var readTemplateIds = BLLUserCmdReadSound.Instance.GetReadTemplateIds(connectString, loginObj.UserId, eCodeHex.Next);
                //    if (readTemplateIds.Count > 0)
                //        GetSound(readTemplateIds, tk.ToString(), counterId, TVReadsound);
                //}
                // ShowResult();
            }
            catch (Exception)
            { }
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            try
            {
                ResponseBaseModel rs = BLLServiceApi.Instance.Next(connectString, loginObj.UserId, equipCode, today, UseWithThirdPattern);
                if (rs.IsSuccess)
                {
                    TicketInfo tk = (TicketInfo)rs.Data_3;

                    if (tk.TicketNumber == 0)
                        txtResult.Text = "Hết vé";
                    else
                    {
                        lbCurrentTicket.Text = tk.TicketNumber.ToString();
                        SendDisplay(tk.TicketNumber.ToString());

                        var requireJSON = JsonConvert.SerializeObject(new RequireMainDisplay() { EquipCode = equipCode, TicketNumber = tk.TicketNumber });
                        BLLCounterSoftRequire.Instance.Insert(connectString, requireJSON, (int)eCounterSoftRequireType.SendNextToMainDisplay, counterId);
                        var readTemplateIds = BLLUserCmdReadSound.Instance.GetReadTemplateIds(connectString, loginObj.UserId, eCodeHex.Next);
                        if (readTemplateIds.Count > 0)
                            GetSound(readTemplateIds, tk.TicketNumber.ToString(), counterId, TVReadsound);
                    }

                    try
                    {
                        if (socket != null)
                        {
                            String _counterIds = (string)rs.Data_4;
                            socket.Emit("qms-system-counter-next", _counterIds);
                        }
                    }
                    catch (Exception ex)
                    {
                    }

                }
                else
                    txtResult.Text = "---";

                // ShowResult();
            }
            catch (Exception)
            { }
        }

        private void btRecall_Click(object sender, EventArgs e)
        {
            var rs = BLLDailyRequire.Instance.GetCurrentTicket(connectString, loginObj.UserId, equipCode, today, 1);
            if (rs.IsSuccess)
            {
                TicketInfo tk = (TicketInfo)rs.Data_3;
                if (tk.TicketNumber == 0)
                    txtResult.Text = "Hết vé";
                else
                {
                    lbCurrentTicket.Text = tk.TicketNumber.ToString();
                    SendDisplay(tk.TicketNumber.ToString());

                    var requireJSON = JsonConvert.SerializeObject(new RequireMainDisplay() { EquipCode = equipCode, TicketNumber = tk.TicketNumber });
                    BLLCounterSoftRequire.Instance.Insert(connectString, requireJSON, (int)eCounterSoftRequireType.SendRecallToMainDisplay, counterId);

                    var readTemplateIds = BLLUserCmdReadSound.Instance.GetReadTemplateIds(connectString, loginObj.UserId, eCodeHex.Recall);
                    if (readTemplateIds.Count > 0)
                        GetSound(readTemplateIds, tk.TicketNumber.ToString(), counterId, TVReadsound);
                }

                try
                {
                    if (socket != null)
                    {
                        // socket.Emit("qms-system-counter-next", loginObj.EquipCode.ToString());
                        String _counterIds = (string)rs.Data_4;
                        socket.Emit("qms-system-counter-next", _counterIds);
                    }
                }
                catch (Exception ex)
                {
                }
            }
            else
                txtResult.Text = "---";
        }

        private void btFinish_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = "";
            string text = this.lbCurrentTicket.Text;
            if (text != "" && text != "0")
            {
                var tk = BLLDailyRequire.Instance.DoneTicket(connectString, loginObj.UserId, equipCode, DateTime.Now);
                if (tk.IsSuccess)
                {
                    try
                    {
                        if (socket != null)
                        {
                            String _counterIds = (string)tk.Data_4;
                            socket.Emit("qms-system-counter-next", _counterIds);
                        }
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }

            // ShowResult();

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
                    //var dscho = lbWaiting.Text.Split(' ').ToList();
                    //if (dscho.Contains(text))
                    //{
                    var kq = BLLDailyRequire.Instance.CallAny(connectString, loginObj.UserId, equipCode, int.Parse(text), today);
                    if (kq.IsSuccess)
                    {
                        this.txtParam.Text = "";
                        this.txtResult.Text = "Yêu cầu Gọi số " + text;
                        lbCurrentTicket.Text = text;
                        SendDisplay(text);

                        var readTemplateIds = BLLUserCmdReadSound.Instance.GetReadTemplateIds(connectString, loginObj.UserId, eCodeHex.Next);
                        if (readTemplateIds.Count > 0)
                            GetSound(readTemplateIds, text, counterId, TVReadsound);
                        try
                        {
                            if (socket != null)
                            {
                                String _counterIds = (string)kq.Data_4;
                                socket.Emit("qms-system-counter-next", _counterIds);
                            }
                        }
                        catch (Exception ex)
                        {
                        }

                    }
                    else
                    {
                        this.txtParam.Text = "";
                        this.txtResult.Text = kq.sms;
                    }


                    //}
                    //else
                    //    this.txtResult.Text = "Số : " + text + " không có trong danh sách chờ của Quầy .Vui lòng nhập số nằm trong danh sách chờ của Quầy.";
                    // MessageBox.Show("Số : " + text + " không có trong danh sách chờ của Quầy .Vui lòng nhập số nằm trong danh sách chờ của Quầy.", "Thông báo gọi vé", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                //  ShowResult();
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
            // ShowResult();
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
                    var tk = BLLDailyRequire.Instance.DeleteTicket(connectString, loginObj.UserId, int.Parse(text), today);
                    if (!tk.IsSuccess)
                    {
                        this.txtParam.Text = "";
                        this.txtResult.Text = "Yêu cầu Hủy vé " + text;
                    }
                    else
                    {
                        if (tk.IsSuccess)
                        {
                            try
                            {
                                if (socket != null)
                                {
                                    String _counterIds = (string)tk.Data_4;
                                    socket.Emit("qms-system-counter-next", _counterIds);
                                }
                            }
                            catch (Exception ex)
                            {
                            }
                        }
                    }
                }
            }
            // ShowResult();
        }
        #endregion

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
            var f = new FrmConfig(connectString);
            f.ShowDialog();
        }

        private void btActive_Click(object sender, EventArgs e)
        {
            var f = new FrmRegister();
            f.ShowDialog();
        }
        #endregion

        private void ShowResult()
        {
            // var obj = BLLLoginHistory.Instance.GetForHome(connectString, loginObj.UserId, equipCode, DateTime.Now, UseWithThirdPattern);// BLLUser.Instance.ReadResult(FrmMain.loginObj.EquipCode);
            var obj = BLLLoginHistory.Instance.GetForHome(sqlCon, loginObj.UserId, equipCode, DateTime.Now, UseWithThirdPattern);// BLLUser.Instance.ReadResult(FrmMain.loginObj.EquipCode);
            if (obj != null)
            {
                if (FirstLoad)
                {
                    lbWaiting.Invoke(new MethodInvoker(() => { lbWaiting.Text = obj.CounterWaitingTickets; }));
                    statusTotalWaiting.Invoke(new MethodInvoker(() => { statusTotalWaiting.Text = "Đang đợi: " + obj.TotalWating; }));
                    statusTotalDone.Invoke(new MethodInvoker(() => { statusTotalDone.Text = "Đã giao dịch: " + obj.TotalDone; }));
                    lbCurrentTicket.Invoke(new MethodInvoker(() => { lbCurrentTicket.Text = obj.CurrentTicket.ToString(); }));
                    FirstLoad = false;
                }
                else
                {
                    try
                    {
                        this.lbWaiting.Text = obj.CounterWaitingTickets;
                        this.statusTotalWaiting.Text = "Đang đợi: " + obj.TotalWating;
                        this.statusTotalDone.Text = "Đã giao dịch: " + obj.TotalDone;
                        this.lbCurrentTicket.Text = obj.CurrentTicket.ToString();
                    }
                    catch (Exception ex)
                    { }
                }
            }
        }

        #region SocketIO
        Socket socket;
        private void ConnectSocketIO()
        {
            if (!string.IsNullOrEmpty(nodeServerIP))
            {
                try
                {
                    string _nodeIP = @"http://" + nodeServerIP;
                    // MessageBox.Show(_nodeIP);
                    socket = IO.Socket(_nodeIP);
                    socket.Connect();
                    socket.On(Socket.EVENT_CONNECT, () =>
                    {
                        SetText("Connected");

                        socket.On(Socket.EVENT_DISCONNECT, () =>
                        {
                            SetText("Disconnected");
                        });


                    });
                    socket.On("server-send-socket-counter-soft", (socketId) =>
                    {
                        SetText(socketId.ToString());
                        socket.Emit("android-send-device-info", socketId + "|" + loginObj.CounterId + "||" + loginObj.UserId);
                    });
                    // socket.Emit("client-send-id", id);

                    socket.On("node-counter-next", ShowResult);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        delegate void SetTextCallback(string text);
        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.lbSocketStatus.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                lbSocketStatus.Text = text;
                if (text != "Disconnected")
                    lbSocketStatus.ForeColor = Color.YellowGreen;
                else
                    lbSocketStatus.ForeColor = Color.Red;
            }
        }

        #endregion

        #region chu chay
        private void RemovePlaceHolder(Object sender, EventArgs e)
        {
            if (txtParam.Text == "Yêu cầu xử lý ...") txtParam.Text = "";
        }
        private void AddPlaceHolder(Object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtParam.Text)) txtParam.Text = "Yêu cầu xử lý ...";
        }

        private void lbWaiting_TextChanged(object sender, EventArgs e)
        {
            if (this.lbWaiting.Text.Length > 24)
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
                // this.lbWaiting.Top = 205;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                if (this.xPos1 <= -this.lbWaiting.Width)
                {
                    this.lbWaiting.Location = new Point(this.panel12.Width, this.yPos1);
                    this.xPos1 = this.panel12.Width;
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

        #endregion
    }
}
