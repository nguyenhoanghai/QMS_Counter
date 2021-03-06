﻿using GPRO.Core.Hai;
using GPRO_QMS_Counter.Helper;
using Microsoft.Win32;
using Newtonsoft.Json;
using QMS_System.Data.BLL;
using QMS_System.Data.BLL.HuuNghi;
using QMS_System.Data.Enum;
using QMS_System.Data.Model;
using QMS_System.ThirdApp.Enum;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO.Ports;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace GPRO_QMS_Counter
{
    public partial class FrmPhongKhamHuuNghi : Form
    {
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
        Thread playThread, refreshThread;
        string soundPath = string.Empty;
        string maPK = string.Empty, maBN = string.Empty;
        int sttDangGoi = 0;

        public FrmPhongKhamHuuNghi()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void FrmPhongKhamHuuNghi_Load(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show(loginObj.UserName.ToLower());
                if (loginObj.UserName.Equals("GPRO Admin"))
                {
                    btConnectSQL.Enabled = true;
                    btSetting.Enabled = true;
                    btTemplate.Enabled = true;
                }
                else
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
                    }
                    dataGridView1.AutoGenerateColumns = false; 
                    ShowResult();
                    getLastTicket();                    
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void refreshData()
        {
            try
            {
                // ShowResult();
              // gridControl1.DataSource = null;
              //  gridControl1.DataSource = BLLHuuNghi.Instance.DSBNCho(sqlCon, loginObj.CounterCode, (int)eDailyRequireType.KhamBenh);

            }
            catch (Exception ex)
            {
            }
            Thread.Sleep(15000);
            refreshData();
        }

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

        private string GetConfigByCode(string code)
        {
            if (configs != null && configs.Count > 0)
            {
                var obj = configs.FirstOrDefault(x => x.Code.Trim().ToUpper().Equals(code.Trim().ToUpper()));
                return obj != null ? obj.Value : string.Empty;
            }
            return string.Empty;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                ShowResult();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowResult()
        {
            // var obj = BLLLoginHistory.Instance.GetForHome(connectString, loginObj.UserId, equipCode, DateTime.Now, UseWithThirdPattern);// BLLUser.Instance.ReadResult(FrmMain.loginObj.EquipCode);
            //var obj = BLLLoginHistory.Instance.GetForHome(sqlCon, loginObj.UserId, equipCode, DateTime.Now, UseWithThirdPattern);// BLLUser.Instance.ReadResult(FrmMain.loginObj.EquipCode);
            //if (obj != null)
            //{
            //    if (FirstLoad)
            //    {
            //        lbWaiting.Invoke(new MethodInvoker(() => { lbWaiting.Text = obj.CounterWaitingTickets; }));
            //        statusTotalWaiting.Invoke(new MethodInvoker(() => { statusTotalWaiting.Text = "Đang đợi: " + obj.TotalWating; }));
            //        statusTotalDone.Invoke(new MethodInvoker(() => { statusTotalDone.Text = "Đã giao dịch: " + obj.TotalDone; }));
            //        lbCurrentTicket.Invoke(new MethodInvoker(() => { lbCurrentTicket.Text = obj.CurrentTicket.ToString(); }));
            //        FirstLoad = false;
            //    }
            //    else
            //    {

            //        this.statusTotalWaiting.Text = "Đang đợi: " + obj.TotalWating;
            //        this.statusTotalDone.Text = "Đã giao dịch: " + obj.TotalDone;
            //        this.lbCurrentTicket.Text = obj.CurrentTicket.ToString();
            //    }
            //}

            try
            {
                //MessageBox.Show(loginObj.CounterCode);
                  var objs = BLLHuuNghi.Instance.DSBNCho(sqlCon, loginObj.CounterCode, (int)eDailyRequireType.KhamBenh);
                //MessageBox.Show(objs.Count.ToString());
                dataGridView1.DataSource = objs; 
            }
            catch (Exception)
            {
            }
        }

        private void getLastTicket()
        {
            try
            {
                var lastTicket = BLLHuuNghi.Instance.GetCurrentTicket(connectString, loginObj.UserId, loginObj.EquipCode);
                if (lastTicket.IsSuccess)
                {
                    sttDangGoi = lastTicket.Data_3.TicketNumber;
                    lbCurrentTicket.Text = sttDangGoi.ToString();
                    SendDisplay(lastTicket.Data_3.TicketNumber.ToString());
                    var infoArr = (lastTicket.Data_3.Note as string).Split(',').ToArray();
                    if (infoArr != null && infoArr.Length == 4)
                    {
                        maBN = infoArr[1];
                        maPK = infoArr[0];
                        lbBNinfo.Text = maBN + " - " + infoArr[2] + " - " + infoArr[3];
                    }
                }
                else
                {
                    sttDangGoi = 0;
                    lbCurrentTicket.Text = sttDangGoi.ToString();
                    SendDisplay(sttDangGoi.ToString());
                    maBN = "";
                    maPK = "";
                    lbBNinfo.Text = "---";
                }
            }
            catch (Exception)
            { 
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn đóng chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        #region kéo form 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion         

        #region button event
        private void btNext_Click(object sender, EventArgs e)
        {
            try
            { 
                DataGridViewSelectedRowCollection rows = dataGridView1.SelectedRows;
                if (rows.Count > 0)
                {
                    int stt = 0;
                    int.TryParse(rows[0].Cells[0].Value.ToString(), out stt);
                    //MessageBox.Show(rows[0].Cells[1].Value.ToString());

                    var tk = BLLHuuNghi.Instance.CallAny(connectString, loginObj.UserId, equipCode, stt, today, (int)eDailyRequireType.KhamBenh);
                    if (tk.IsSuccess)
                    {
                        sttDangGoi = tk.Data_3.TicketNumber;
                        lbCurrentTicket.Text = sttDangGoi.ToString();
                        SendDisplay(tk.Data_3.TicketNumber.ToString());

                        var requireJSON = JsonConvert.SerializeObject(new RequireMainDisplay() { EquipCode = equipCode, TicketNumber = tk.Data_3.TicketNumber });
                        BLLCounterSoftRequire.Instance.Insert(connectString, requireJSON, (int)eCounterSoftRequireType.SendNextToMainDisplay, counterId);
                        var readTemplateIds = BLLUserCmdReadSound.Instance.GetReadTemplateIds(connectString, loginObj.UserId, eCodeHex.Next);
                        if (readTemplateIds.Count > 0)
                            GetSound(readTemplateIds, tk.Data_3.TicketNumber.ToString(), counterId);

                        var infoArr = (tk.Data_3.Note as string).Split(',').ToArray();
                        if (infoArr != null && infoArr.Length == 4)
                        {
                            maBN = infoArr[1];
                            maPK = infoArr[0];
                            lbBNinfo.Text = maBN + " - " + infoArr[2] + " - " + infoArr[3];
                        }
                        ShowResult();
                    }                    
                }
                else
                    MessageBox.Show("Xin vui lòng chọn bệnh nhân cần gọi.", "Lỗi thao tác", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            { }
        }

        private void btnGoiUuTien_Click(object sender, EventArgs e)
        {
            try
            {
                var tk = BLLDailyRequire.Instance.Next_KetLuan(connectString, loginObj.UserId, equipCode, today, UseWithThirdPattern);
                if (tk != 0)
                {
                    lbCurrentTicket.Text = tk.ToString();
                    SendDisplay(tk.ToString());

                    var requireJSON = JsonConvert.SerializeObject(new RequireMainDisplay() { EquipCode = equipCode, TicketNumber = tk });
                    BLLCounterSoftRequire.Instance.Insert(connectString, requireJSON, (int)eCounterSoftRequireType.SendNextToMainDisplay, counterId);
                    var readTemplateIds = BLLUserCmdReadSound.Instance.GetReadTemplateIds(connectString, loginObj.UserId, eCodeHex.Next);
                    if (readTemplateIds.Count > 0)
                        GetSound(readTemplateIds, tk.ToString(), counterId);
                    //   ShowResult();
                }
            }
            catch (Exception)
            { }
        }

        private void btTranfer_Click(object sender, EventArgs e)
        { 
            if (  sttDangGoi > 0 &&
                !string.IsNullOrEmpty(loginObj.CounterCode) &&
                !string.IsNullOrEmpty(maBN))
            {
                DialogResult dialogResult = MessageBox.Show("Bạn muốn phiếu " + sttDangGoi + " qua lượt phải không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dialogResult == DialogResult.Yes)
                {
                    if (BLLHuuNghi.Instance.QuaLuot(connectString, sttDangGoi, loginObj.CounterCode, maBN, (int)eDailyRequireType.KhamBenh) > 0)
                    {
                        ShowResult();
                        getLastTicket();
                    }
                }
            }
        }

        private void btCallAnyTicket_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.txtResult.Text = "";
            //    string text = this.txtParam.Text.ToString().Trim();
            //    if (!string.IsNullOrEmpty(text) && !Information.IsNumeric(text))
            //    {
            //        //MessageBox.Show("Bạn phải nhập số vé bất kỳ muốn gọi.", "Thông báo gọi vé", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //        this.txtResult.Text = "Bạn phải nhập số vé bất kỳ muốn gọi.";
            //        this.txtParam.Focus();
            //    }
            //    else
            //    {
            //        var dscho = lbWaiting.Text.Split(' ').ToList();
            //        var dsqualuot = lbQualuot.Text.Split(' ').ToList();
            //        if (dscho.Contains(text) || dsqualuot.Contains(text))
            //        {
            //            var kq = BLLDailyRequire.Instance.CallAny(connectString, loginObj.UserId, equipCode, int.Parse(text), today);
            //            if (kq.IsSuccess)
            //            {
            //                this.txtParam.Text = "";
            //                this.txtResult.Text = "Yêu cầu Gọi số " + text;
            //                lbCurrentTicket.Text = text;
            //                SendDisplay(text);

            //                var readTemplateIds = BLLUserCmdReadSound.Instance.GetReadTemplateIds(connectString, loginObj.UserId, eCodeHex.Next);
            //                if (readTemplateIds.Count > 0)
            //                    GetSound(readTemplateIds, text, counterId);
            //                ShowResult();
            //            }
            //            else
            //            {
            //                this.txtParam.Text = "";
            //                this.txtResult.Text = kq.sms;
            //            }
            //        }
            //        else
            //            this.txtResult.Text = "Số : " + text + " không có trong danh sách chờ của Quầy .Vui lòng nhập số nằm trong danh sách chờ của Quầy.";
            //        // MessageBox.Show("Số : " + text + " không có trong danh sách chờ của Quầy .Vui lòng nhập số nằm trong danh sách chờ của Quầy.", "Thông báo gọi vé", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    }
            //    // 
            //}
            //catch (Exception)
            //{
            //}
        }

        private void btRecall_Click(object sender, EventArgs e)
        {
            try
            {
                var tk = BLLHuuNghi.Instance.CallAny(connectString, loginObj.UserId, equipCode, sttDangGoi, today, (int)eDailyRequireType.KhamBenh);
                if (tk.IsSuccess)
                {
                    sttDangGoi = tk.Data_3.TicketNumber;
                    lbCurrentTicket.Text = sttDangGoi.ToString();
                    SendDisplay(tk.Data_3.TicketNumber.ToString());

                    var requireJSON = JsonConvert.SerializeObject(new RequireMainDisplay() { EquipCode = equipCode, TicketNumber = tk.Data_3.TicketNumber });
                    BLLCounterSoftRequire.Instance.Insert(connectString, requireJSON, (int)eCounterSoftRequireType.SendNextToMainDisplay, counterId);
                    var readTemplateIds = BLLUserCmdReadSound.Instance.GetReadTemplateIds(connectString, loginObj.UserId, eCodeHex.Next);
                    if (readTemplateIds.Count > 0)
                        GetSound(readTemplateIds, tk.Data_3.TicketNumber.ToString(), counterId);

                    var infoArr = (tk.Data_3.Note as string).Split(',').ToArray();
                    if (infoArr != null && infoArr.Length == 4)
                    {
                        maBN = infoArr[1];
                        maPK = infoArr[0];
                        lbBNinfo.Text = maBN + " - " + infoArr[2] + " - " + infoArr[3];
                    }
                    ShowResult();
                }
            }
            catch (Exception ex) { }
        }

        private void btFinish_Click(object sender, EventArgs e)
        {
            //this.txtResult.Text = "";
            //string text = this.lbCurrentTicket.Text;
            //if (text != "" && text != "0")
            //{
            //    BLLDailyRequire.Instance.DoneTicket(connectString, loginObj.UserId, equipCode, DateTime.Now);
            //    ShowResult();
            //}
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            //txtResult.Text = "";
            //string text = txtParam.Text.Trim();
            //if (text == "")
            //    text = this.lbCurrentTicket.Text;
            //if (!string.IsNullOrEmpty(text) && text.All(char.IsDigit))
            //{
            //    DialogResult dialogResult = MessageBox.Show("Bạn muốn hủy vé " + text + " phải không?", "Thông báo hủy vé", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            //    if (dialogResult == DialogResult.Yes)
            //    {
            //        if (BLLDailyRequire.Instance.DeleteTicket(connectString, int.Parse(text), today) > 0)
            //        {
            //            this.txtParam.Text = "";
            //            this.txtResult.Text = "Yêu cầu Hủy vé " + text;
            //            ShowResult();
            //        }
            //    }
            //}
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
            var f = new FrmConfig();
            f.ShowDialog();
        }

        private void btActive_Click(object sender, EventArgs e)
        {
            var f = new FrmRegister();
            f.ShowDialog();
        }

        #endregion

        #region Sound
        private void timerDocAmThanh_Tick(object sender, EventArgs e)
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
    }
}
