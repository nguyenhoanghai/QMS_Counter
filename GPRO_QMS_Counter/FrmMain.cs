using DevExpress.XtraEditors.Controls;
using GPRO.Core.Hai;
using GPRO_QMS_Counter.Helper;
using GPRO_QMS_Counter.Properties;
using Microsoft.VisualBasic;
using Microsoft.Win32;
using Newtonsoft.Json;
using QMS_System.Data.BLL;
using QMS_System.Data.Enum;
using QMS_System.Data.Model;
using Quobject.EngineIoClientDotNet.Client;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Media;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace GPRO_QMS_Counter
{
    public partial class FrmMain : Form
    {
        SoundPlayer player;
        DateTime today = DateTime.Now;
        Thread playThread;
        List<string> temp, playlist;
        bool isFinishRead = true;
        public static string soundPath = string.Empty;
        public static bool isRestart = false;
        public static Login loginObj = null;
        public static bool IsUseMainDisplay = false,
            bRegistered = false,
            bCheckValid = false;
        public static string sComPort = "COM1", nodeServerIP="";
        public static int iBaudRate = 9600;
        public static int iDataBits = 8, printerId = 10;
        public static Parity sParity = Parity.None;
        public static StopBits fStopBits = StopBits.One;
        SerialPort serialPort1;
        List<ConfigModel> configs;

        bool bCallNext = true,
            bRecall = true,
            bFinish = true,
            bCancel = true,
            bCallAny = true,
            bTranfer = true,
            bSave = true,
            bView = true,
            bHelp = true,
            bLogout = true,
            bPrintTicket = false,
            bUpdateInfo = false,
            IsReadSound = false;

        int xPos = 0,
            yPos = 0,
            xPos1 = 0,
            yPos1 = 0,
            UseWithThirdPattern = 0;

        List<ModelSelectItem> serviceObjs = null;
        string connectString = BaseCore.Instance.GetEntityConnectString(Application.StartupPath + "\\DATA.XML");
        public FrmMain()
        {
            bCheckValid = CheckValidation();
            if (!bCheckValid)
            {
                FrmRegister frmRegister = new FrmRegister();
                frmRegister.ShowDialog();
            }
            if (bCheckValid)
            {
                FrmLogin frmLogin = new FrmLogin( );
                frmLogin.ShowDialog();
                InitializeComponent();
                InitCOMPort();
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

        #region SOCKET IO
        //Socket socket;
        //private void ConnectSocketIO()
        //{
        //    if (!string.IsNullOrEmpty(nodeServerIP))
        //    {
        //        string _nodeIP = @"http://" + nodeServerIP;
        //        socket = IO.Socket(_nodeIP);
        //        socket.Connect();
        //        socket.On(Socket.EVENT_CONNECT, () =>
        //        {
        //            btnSocketStatus.Text = ("Node Connected");
        //            btnSocketStatus.ForeColor = Color.Blue;

        //            socket.On(Socket.EVENT_DISCONNECT, () =>
        //            {
        //                // errorsms =("Disconnect");
        //                btnSocketStatus.Text = "Node Disconnect";
        //                btnSocketStatus.ForeColor = Color.Red;
        //            });
        //        });
        //    }
        //}
        #endregion

        private void FrmMain_Load(object sender, EventArgs e)
        {
            lbPrintStatus.Text = "";
            txtGuide.Text = "Phím tắt chức năng: \r\nF1: Gọi vé tiếp theo.\r\nF2: Nhắc lại vé đang giao dịch.\r\nF3: Hoàn tất vé đang giao dịch.\r\nF4: Hủy vé.\r\nF5: Lưu vé.\r\nF6: Xem danh sách khách đợi ở các quầy.\r\nF7: Giúp đỡ.\r\nF8: Đăng xuất.";
            if (loginObj != null)
            {
                statusStaffName.Text = loginObj.UserName;
                statusLoginTime.Text = loginObj.LoginTime;
                statusDesk.Text = loginObj.CounterName;
                GetSetting();
                SetButtonForAction();
                lbCurrentTicket.Text = "0";
                lbCurrentTicket_s.Text = "0";
                lbWaiting.Text = "0";
                lbGeneralWaiting.Text = "0";
               // if (!bRegistered)
                    đăngKýSửDụngToolStripMenuItem.Enabled = true;
               // else
              //      đăngKýSửDụngToolStripMenuItem.Enabled = false;


                playlist = new List<string>();
                temp = new List<string>();

                if (FrmMain.IsUseMainDisplay)
                    InitCOMPort();

                chbkService.Items.Clear();
                serviceObjs = BLLService.Instance.GetLookUp(connectString, false);
                if (serviceObjs.Count > 0)
                    for (int i = 0; i < serviceObjs.Count; i++)
                        chbkService.Items.Add(new CheckedListBoxItem(serviceObjs[i].Id, serviceObjs[i].Name));


                if (Settings.Default.actSmallScreen)
                    thuGọnGiaoDiệnToolStripMenuItem1_Click(sender, e);
                else
                {
                    if (Settings.Default.actPrintTicket)
                        this.Size = new Size(1130, 604);
                    else
                        this.Size = new Size(912, 604);
                    if (FrmMain.loginObj.UserName.Equals("GPRO Admin"))
                        âmThanhToolStripMenuItem.Enabled = true;
                }
            }
        }

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

        private void GetSound(List<int> templateIds, string ticket, int counterId)
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
                        BLLCounterSoftRequire.Instance.Insert(connectString, soundStr, (int)eCounterSoftRequireType.ReadSound, FrmMain.loginObj.CounterId);
                    }
                }
            }
        }
        #endregion

        #region Comport
        private void InitCOMPort()
        {
            serialPort1 = new SerialPort();
            iBaudRate = 9600;
            iDataBits = 8;
            sParity = Parity.None;
            fStopBits = StopBits.One;
            this.serialPort1.PortName = sComPort;
            this.serialPort1.BaudRate = iBaudRate;
            this.serialPort1.DataBits = iDataBits;
            this.serialPort1.Parity = sParity;
            this.serialPort1.StopBits = fStopBits;
        }

        private void SendDisplay(string sResult)
        {
            try
            {
                if (FrmMain.IsUseMainDisplay)
                {
                    string text = sResult;
                    if (text.Length < 4)
                        text = string.Format("{0:0000}", int.Parse(text));

                    byte[] array = new byte[3];
                    array[0] = 170;
                    byte[] array2 = array;
                    array2[1] = byte.Parse((int.Parse(text.Substring(0, 1)) * 16 + int.Parse(text.Substring(1, 1))).ToString());
                    array2[2] = byte.Parse((int.Parse(text.Substring(2, 1)) * 16 + int.Parse(text.Substring(3, 1))).ToString());
                    if (!this.serialPort1.IsOpen)
                    {
                        try
                        {
                            this.serialPort1.Open();
                            this.serialPort1.DtrEnable = true;
                            this.serialPort1.RtsEnable = true;
                        }
                        catch
                        {
                        }
                    }
                    this.serialPort1.Write(array2, 0, array2.Length);
                }
            }
            catch (Exception)
            { }
        }

        #endregion

        #region btn Event
        private void btNext_Click(object sender, EventArgs e)
        {
            try
            {
                var tk = BLLDailyRequire.Instance.Next(connectString, loginObj.UserId, loginObj.EquipCode, today, UseWithThirdPattern);
                if (tk == 0)
                    txtResult.Text = "Hết vé";
                else
                {
                    lbCurrentTicket.Text = tk.ToString();
                    lbCurrentTicket_s.Text = tk.ToString();
                    SendDisplay(tk.ToString());

                    var requireJSON = JsonConvert.SerializeObject(new RequireMainDisplay() { EquipCode = loginObj.EquipCode, TicketNumber = tk });
                    BLLCounterSoftRequire.Instance.Insert(connectString, requireJSON, (int)eCounterSoftRequireType.SendNextToMainDisplay, FrmMain.loginObj.CounterId);
                    var readTemplateIds = BLLUserCmdReadSound.Instance.GetReadTemplateIds(connectString, loginObj.UserId, eCodeHex.Next);
                    if (readTemplateIds.Count > 0)
                        GetSound(readTemplateIds, tk.ToString(), loginObj.CounterId);
                }
            }
            catch (Exception)
            { }
        }
        private void btRecall_Click(object sender, EventArgs e)
        {
            int kq = BLLDailyRequire.Instance.CurrentTicket(connectString, loginObj.UserId, loginObj.EquipCode, today, UseWithThirdPattern);
            if (kq == 0)
                txtResult.Text = "Hết vé";
            else
            {
                lbCurrentTicket.Text = kq.ToString();
                lbCurrentTicket_s.Text = kq.ToString();
                SendDisplay(kq.ToString());

                var requireJSON = JsonConvert.SerializeObject(new RequireMainDisplay() { EquipCode = loginObj.EquipCode, TicketNumber = kq });
                BLLCounterSoftRequire.Instance.Insert(connectString, requireJSON, (int)eCounterSoftRequireType.SendRecallToMainDisplay, FrmMain.loginObj.CounterId);

                var readTemplateIds = BLLUserCmdReadSound.Instance.GetReadTemplateIds(connectString, loginObj.UserId, eCodeHex.Recall);
                if (readTemplateIds.Count > 0)
                    GetSound(readTemplateIds, kq.ToString(), loginObj.CounterId);
            }
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
        }
        private void btCallAnyTicket_Click(object sender, EventArgs e)
        {
            try
            {
                this.txtResult.Text = "";
                string text = this.txtParam.Text.ToString().Trim();
                if (!string.IsNullOrEmpty(text) && !Information.IsNumeric(text))
                {
                    MessageBox.Show("Bạn phải nhập số vé bất kỳ muốn gọi.", "Thông báo gọi vé", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.txtParam.Focus();
                }
                else
                {
                    var dscho = lbWaiting.Text.Split(' ').ToList();
                    if (dscho.Contains(text))
                    {
                        var kq = BLLDailyRequire.Instance.CallAny(connectString, loginObj.UserId, loginObj.EquipCode, int.Parse(text), today);
                        if (kq.IsSuccess)
                        {
                            this.txtParam.Text = "";
                            this.txtResult.Text = "Yêu cầu Gọi số " + text;
                            lbCurrentTicket.Text = text;
                            SendDisplay(text);

                            var readTemplateIds = BLLUserCmdReadSound.Instance.GetReadTemplateIds(connectString, loginObj.UserId, eCodeHex.Next);
                            if (readTemplateIds.Count > 0)
                                GetSound(readTemplateIds, text, loginObj.CounterId);
                        }
                        else
                        {
                            this.txtParam.Text = "";
                            this.txtResult.Text = kq.sms;
                        }
                    }
                    else
                        MessageBox.Show("Số : " + text + " không có trong danh sách chờ của Quầy .Vui lòng nhập số nằm trong danh sách chờ của Quầy.", "Thông báo gọi vé", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
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
                var f = new FrmChange(!string.IsNullOrEmpty(txtParam.Text) ? int.Parse(txtParam.Text) : int.Parse(lbCurrentTicket.Text), FrmMain.loginObj.EquipCode);
                f.ShowDialog();
            }
            else
                this.txtResult.Text = "Không thể thực hiện chuyển vé chưa xác định!";
        }
        private void btLogout_Click(object sender, EventArgs e)
        {
            đăngXuấtToolStripMenuItem_Click(sender, e);
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn đăng xuất khỏi hệ thống?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.WriteSetting();
                BLLLoginHistory.Instance.Logout(connectString, FrmMain.loginObj.UserId, FrmMain.loginObj.EquipCode, DateTime.Now);
                this.Hide();
                dialogResult = MessageBox.Show("Bạn đã đăng xuất thành công! \nBạn có muốn tiếp tục chương trình không?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (dialogResult == DialogResult.Yes)
                    Process.Start("GPRO_QMS_Counter.exe");
                else
                    Application.Exit();
            }
        }
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WriteSetting();
            Application.Exit();
        }
        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn đăng nhập bằng tài khoản khác? \nBạn sẽ đăng xuất tài khoản hiện tại.", "Đăng nhập mới", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (BLLLoginHistory.Instance.CounterLoginLogOut(connectString, FrmMain.loginObj.UserId, FrmMain.loginObj.EquipCode, DateTime.Now) == 8888)
                {
                    this.Hide();
                    Process.Start("GPRO_QMS_Counter.exe");
                }
            }
        }
        #region tooltip event 
        private void cấpPhiếuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!cấpPhiếuToolStripMenuItem.Checked)
            {
                this.bPrintTicket = true;
                cấpPhiếuToolStripMenuItem.Checked = true;
            }
            else
            {
                this.bPrintTicket = false;
                cấpPhiếuToolStripMenuItem.Checked = false;
            }
        }
        private void cấpPhiếuToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (this.bPrintTicket)
                this.Size = new Size(1130, 604);
            else
                this.Size = new Size(912, 604);
        }
        private void lưuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!lưuToolStripMenuItem.Checked)
            {
                this.bSave = true;
                lưuToolStripMenuItem.Checked = true;
                btSave.Enabled = true;
            }
            else
            {
                this.bSave = false;
                lưuToolStripMenuItem.Checked = false;
                btSave.Enabled = false;
            }
        }
        private void xemKháchĐợiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!xemKháchĐợiToolStripMenuItem.Checked)
            {
                this.bView = true;
                xemKháchĐợiToolStripMenuItem.Checked = true;
                btViewList.Enabled = true;
            }
            else
            {
                this.bView = false;
                xemKháchĐợiToolStripMenuItem.Checked = false;
                btViewList.Enabled = false;
            }
        }
        private void giúpĐỡToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!giúpĐỡToolStripMenuItem.Checked)
            {
                this.bHelp = true;
                giúpĐỡToolStripMenuItem.Checked = true;
                btHelp.Enabled = true;
            }
            else
            {
                this.bHelp = false;
                giúpĐỡToolStripMenuItem.Checked = false;
                btHelp.Enabled = false;
            }
        }
        private void gọiKháchTiếpTheoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!gọiKháchTiếpTheoToolStripMenuItem.Checked)
            {
                this.bCallNext = true;
                gọiKháchTiếpTheoToolStripMenuItem.Checked = true;
                btNext.Enabled = true;
            }
            else
            {
                this.bCallNext = false;
                gọiKháchTiếpTheoToolStripMenuItem.Checked = false;
                btNext.Enabled = false;
            }
        }
        private void nhắcLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!nhắcLạiToolStripMenuItem.Checked)
            {
                this.bRecall = true;
                nhắcLạiToolStripMenuItem.Checked = true;
                btRecall.Enabled = true;
            }
            else
            {
                this.bRecall = false;
                nhắcLạiToolStripMenuItem.Checked = false;
                btRecall.Enabled = false;
            }
        }
        private void hủyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!nhắcLạiToolStripMenuItem.Checked)
            {
                this.bCancel = true;
                hủyToolStripMenuItem.Checked = true;
                btCancel.Enabled = true;
            }
            else
            {
                this.bCancel = false;
                hủyToolStripMenuItem.Checked = false;
                btCancel.Enabled = false;
            }
        }
        private void gọiSốBấtKỳToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!gọiSốBấtKỳToolStripMenuItem.Checked)
            {
                this.bCallAny = true;
                gọiSốBấtKỳToolStripMenuItem.Checked = true;
                btCallAnyTicket.Enabled = true;
            }
            else
            {
                this.bCallAny = false;
                gọiSốBấtKỳToolStripMenuItem.Checked = false;
                btCallAnyTicket.Enabled = false;
            }
        }
        private void chuyểnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!chuyểnToolStripMenuItem.Checked)
            {
                this.bTranfer = true;
                chuyểnToolStripMenuItem.Checked = true;
                btTranfer.Enabled = true;
            }
            else
            {
                this.bTranfer = false;
                chuyểnToolStripMenuItem.Checked = false;
                btTranfer.Enabled = false;
            }
        }
        private void ẩnMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.menuStrip1.Visible = false;
            this.splitContainer1.Left = 0;
            this.splitContainer1.Top = 0;
            this.splitContainer1.Height = this.splitContainer1.Height + 24;
        }
        private void thuGọnGiaoDiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.splitContainer1_DoubleClick(sender, e);
            base.Size = new Size(466, 606);
            this.thuGọnGiaoDiệnToolStripMenuItem.Visible = false;
            this.giaoDiệnĐầyĐủToolStripMenuItem.Visible = true;
        }
        private void giaoDiệnĐầyĐủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            base.Size = new Size(913, 600);
            this.giaoDiệnĐầyĐủToolStripMenuItem.Visible = false;
            this.thuGọnGiaoDiệnToolStripMenuItem.Visible = true;
            if (Settings.Default.actPrintTicket)
                this.Size = new Size(1130, 604);
            else
                this.Size = new Size(912, 604);
        }
        private void vềPhầnMềmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FrmAbout();
            f.ShowDialog();
        }
        private void hướngDẫnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FrmGuide();
            f.ShowDialog();
        }
        #endregion

        private void splitContainer1_DoubleClick(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = 468;
        }
        private void lbWaiting_MouseHover(object sender, EventArgs e)
        {
            txtGuide.Text = "Danh sách khách đang đợi riêng tại quầy hiện hành.";
        }
        private void lbGeneralWaiting_Click(object sender, EventArgs e)
        {
            txtGuide.Text = "Danh sách khách đang đợi chung trong hệ thống (không thuộc riêng quầy nào).";
        }
        private void btNext_MouseHover(object sender, EventArgs e)
        {
            txtGuide.Text = "Nhấn nút 'Gọi tiếp theo' để gọi số giao dịch tiếp theo.";
        }
        private void btRecall_MouseHover(object sender, EventArgs e)
        {
            txtGuide.Text = "Nhấn nút 'Nhắc lại' để gọi lại số giao dịch hiện hành.";
        }
        private void btFinish_MouseHover(object sender, EventArgs e)
        {
            txtGuide.Text = "Nhấn nút 'Hoàn tất' để hoàn tất giao dịch hiện hành.";
        }
        private void lbWaiting_MouseLeave(object sender, EventArgs e)
        {
            txtGuide.Text = "Phím tắt chức năng: \r\nF1: Gọi vé tiếp theo.\r\nF2: Nhắc lại vé đang giao dịch.\r\nF3: Hoàn tất vé đang giao dịch.\r\nF4: Hủy vé.\r\nF5: Lưu vé.\r\nF6: Xem danh sách khách đợi ở các quầy.\r\nF7: Giúp đỡ.\r\nF8: Đăng xuất.";
        }
        private void lbGeneralWaiting_MouseLeave(object sender, EventArgs e)
        {
            lbWaiting_MouseLeave(sender, e);
        }
        private void btNext_MouseLeave(object sender, EventArgs e)
        {
            lbWaiting_MouseLeave(sender, e);
        }
        private void btRecall_MouseLeave(object sender, EventArgs e)
        {
            lbWaiting_MouseLeave(sender, e);
        }
        private void btFinish_MouseLeave(object sender, EventArgs e)
        {
            lbWaiting_MouseLeave(sender, e);
        }
        private void txtParam_TextChanged(object sender, EventArgs e)
        {
            txtGuide.Text = "Nhập yêu cầu để thực hiện chức năng.";
        }
        private void txtResult_TextChanged(object sender, EventArgs e)
        {
            txtGuide.Text = "Kết quả yêu cầu thực hiện chức năng.";
        }
        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1: btNext_Click(sender, e); break;
                case Keys.F2: btRecall_Click(sender, e); break;
                case Keys.F3: btFinish_Click(sender, e); break;
                case Keys.F4: btCancel_Click(sender, e); break;
                case Keys.F5: btSave_Click(sender, e); break;
                case Keys.F6: btViewList_Click(sender, e); break;
                case Keys.F7: btHelp_Click(sender, e); break;
                case Keys.F8: btLogout_Click(sender, e); break;
            }
        }
        private void txtParam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 'D' && e.KeyChar != 'd' && (e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b' && e.KeyChar != '.')
                e.Handled = true;
        }
        private void lbGeneralWaiting_TextChanged(object sender, EventArgs e)
        {
            if (this.lbGeneralWaiting.Text.Length > 26)
            {
                this.xPos = this.lbGeneralWaiting.Location.X;
                this.yPos = this.lbGeneralWaiting.Location.Y;
                this.timer2.Start();
            }
            else
            {
                this.timer2.Stop();
                this.lbGeneralWaiting.Left = 6;
                this.lbGeneralWaiting.Top = 135;
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (this.xPos <= -this.lbGeneralWaiting.Width)
            {
                this.lbGeneralWaiting.Location = new Point(this.splitContainer2.Panel2.Width, this.yPos);
                this.xPos = this.splitContainer2.Panel2.Width;
            }
            else
            {
                this.lbGeneralWaiting.Location = new Point(this.xPos, this.yPos);
                this.xPos -= 3;
            }
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (this.xPos1 <= -this.lbWaiting.Width)
            {
                this.lbWaiting.Location = new Point(this.splitContainer2.Panel2.Width, this.yPos1);
                this.xPos1 = this.splitContainer2.Panel2.Width;
            }
            else
            {
                this.lbWaiting.Location = new Point(this.xPos1, this.yPos1);
                this.xPos1 -= 3;
            }
        }
        private void lbWaiting_TextChanged(object sender, EventArgs e)
        {
            if (this.lbWaiting.Text.Length > 26)
            {
                this.xPos1 = this.lbWaiting.Location.X;
                this.yPos1 = this.lbWaiting.Location.Y;
                this.timer3.Start();
            }
            else
            {
                this.timer3.Stop();
                this.lbWaiting.Left = 6;
                this.lbWaiting.Top = 40;
            }
        }
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.WriteSetting();
            BLLLoginHistory.Instance.CounterLoginLogOut(connectString, FrmMain.loginObj.UserId, FrmMain.loginObj.EquipCode, DateTime.Now);
            if (this.serialPort1.IsOpen)
                this.serialPort1.Close();

        }
        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            if (this.splitContainer1.SplitterDistance > 463)
            {
                this.label1.Width = this.splitContainer1.SplitterDistance;
                this.label2.Width = this.splitContainer1.SplitterDistance;
                this.label3.Width = this.splitContainer1.SplitterDistance;
                this.lbCurrentTicket.Width = this.splitContainer1.SplitterDistance;
                this.lbWaiting.Width = this.splitContainer1.SplitterDistance;
                this.lbGeneralWaiting.Width = this.splitContainer1.SplitterDistance;
            }
            else
            {
                this.label1.Width = 463;
                this.label2.Width = 463;
                this.label3.Width = 463;
                this.lbCurrentTicket.Width = 452;
                this.lbWaiting.Width = 452;
                this.lbGeneralWaiting.Width = 452;
            }
        }
        private void splitContainer2_DoubleClick(object sender, EventArgs e)
        {
            splitContainer2.SplitterDistance = this.splitContainer2.Height / 2;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (FrmMain.isRestart)
                {
                    this.Hide();
                    Process.Start("GPRO_QMS_Counter.exe");
                    FrmMain.isRestart = false;
                }
                else
                    ShowResult();
            }
            catch (Exception)
            {
            }
        }
        private void đăngKýSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmRegister = new FrmRegister();
            frmRegister.ShowDialog();
            if (bRegistered)
                đăngKýSửDụngToolStripMenuItem.Enabled = false;
        }
        private void thốngKêĐánhGiáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FrmReportEvaluate();
            f.ShowDialog();
        }
        private void qLLịchHẹnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FrmBookService();
            f.ShowDialog();
        }

        private void btnEditInfo_Click(object sender, EventArgs e)
        {
            try
            {
                this.txtResult.Text = "";
                string text = this.txtParam.Text.ToString().Trim();
                if (!string.IsNullOrEmpty(text) && !Information.IsNumeric(text))
                {
                    MessageBox.Show("Bạn phải nhập số vé bất kỳ muốn cập nhật thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtParam.Focus();
                }
                else
                {
                    var f = new FrmEditTicketInfo(int.Parse(txtParam.Text));
                    f.ShowDialog();
                }
            }
            catch (Exception)
            {
            }
        }

        private void chbkService_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedService = (CheckedListBoxItem)chbkService.SelectedItem;
            if (selectedService != null)
            {
                var found = serviceObjs.FirstOrDefault(x => x.Id == (int)selectedService.Value);
                if (found != null && !string.IsNullOrEmpty(found.Code))
                {
                    TimeSpan time = TimeSpan.Parse(found.Code);
                    var date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, time.Hours, time.Minutes, time.Seconds);
                    date.AddSeconds(time.TotalSeconds);
                    timeServeAllow.Value = date;
                }
            }
        }



        private void btnNext_small_Click(object sender, EventArgs e)
        {
            btNext_Click(sender, e);
        }

        private void btnRecall_small_Click(object sender, EventArgs e)
        {
            btRecall_Click(sender, e);
        }

        private void cậpNhậtThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FrmUser();
            f.ShowDialog();
        }
        private void btFinish_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = "";
            string text = this.lbCurrentTicket.Text;
            if (text != "" && text != "0")
                BLLDailyRequire.Instance.DoneTicket(connectString, loginObj.UserId, loginObj.EquipCode, DateTime.Now);
        }

        private void kếtNốiCSDLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FrmSQLConnect();
            f.ShowDialog();
        }

        private void btnGoiUuTien_Click(object sender, EventArgs e)
        {
            try
            {
                var tk = BLLDailyRequire.Instance.Next_KetLuan(connectString, loginObj.UserId, loginObj.EquipCode, today, UseWithThirdPattern);
                if (tk == 0)
                    txtResult.Text = "Hết vé";
                else
                {
                    lbCurrentTicket.Text = tk.ToString();
                    lbCurrentTicket_s.Text = tk.ToString();
                    SendDisplay(tk.ToString());

                    var requireJSON = JsonConvert.SerializeObject(new RequireMainDisplay() { EquipCode = loginObj.EquipCode, TicketNumber = tk });
                    BLLCounterSoftRequire.Instance.Insert(connectString, requireJSON, (int)eCounterSoftRequireType.SendNextToMainDisplay, FrmMain.loginObj.CounterId);
                    var readTemplateIds = BLLUserCmdReadSound.Instance.GetReadTemplateIds(connectString, loginObj.UserId, eCodeHex.Next);
                    if (readTemplateIds.Count > 0)
                        GetSound(readTemplateIds, tk.ToString(), loginObj.CounterId);
                }
            }
            catch (Exception)
            { }
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmCustomer();
            f.ShowDialog();
        }

        private void cuộcHẹnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmSchedule();
            f.ShowDialog();
        }

        private void kếtThúcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!kếtThúcToolStripMenuItem.Checked)
            {
                this.bFinish = true;
                kếtThúcToolStripMenuItem.Checked = true;
                btFinish.Enabled = true;
            }
            else
            {
                this.bFinish = false;
                kếtThúcToolStripMenuItem.Checked = false;
                btFinish.Enabled = false;
            }
        }



        #endregion

        private void GetSetting()
        {
            this.bCallNext = Settings.Default.actCallNext;
            this.bRecall = Settings.Default.actRecall;
            this.bFinish = Settings.Default.actFinish;
            this.bCancel = Settings.Default.actCancel;
            this.bCallAny = Settings.Default.actCallTicket;
            this.bTranfer = Settings.Default.actPass;
            this.bSave = Settings.Default.actSave;
            this.bView = Settings.Default.actView;
            this.bHelp = Settings.Default.actHelp;
            this.bLogout = Settings.Default.actLogout;
            this.bUpdateInfo = Settings.Default.actUpdateInfo;

            this.bPrintTicket = Settings.Default.actPrintTicket;
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
                                case "Display": IsUseMainDisplay = Convert.ToBoolean(node.InnerText); break;
                                case "COMDisplay": sComPort = node.InnerText; break;
                                case "PrintCode": printerId = (!string.IsNullOrEmpty(node.InnerText) ? Convert.ToInt32(node.InnerText) : 1); ; break;
                                case "ReadSound": IsReadSound = Convert.ToBoolean(node.InnerText); break;
                                case "SoundPath": soundPath = node.InnerText; break;
                            }
                        }
                        catch (Exception ex)
                        {
                        }
                    }
                }
            }

            configs = BLLConfig.Instance.Gets(connectString, true);
            int.TryParse(GetConfigByCode(eConfigCode.UseWithThirdPattern), out UseWithThirdPattern);
        }

        public string GetConfigByCode(string code)
        {
            if (configs != null && configs.Count > 0)
            {
                var obj = configs.FirstOrDefault(x => x.Code.Trim().ToUpper().Equals(code.Trim().ToUpper()));
                return obj != null ? obj.Value : string.Empty;
            }
            return string.Empty;
        }

        private void SetButtonForAction()
        {
            this.btNext.Enabled = this.bCallNext;
            gọiKháchTiếpTheoToolStripMenuItem.Checked = this.bCallNext;

            this.btRecall.Enabled = this.bRecall;
            this.nhắcLạiToolStripMenuItem.Checked = this.bRecall;

            this.btFinish.Enabled = this.bFinish;
            this.kếtThúcToolStripMenuItem.Checked = this.bFinish;

            this.btCancel.Enabled = this.bCancel;
            this.hủyToolStripMenuItem.Checked = this.bCancel;

            this.btCallAnyTicket.Enabled = this.bCallAny;
            this.gọiSốBấtKỳToolStripMenuItem.Checked = this.bCallAny;

            this.btTranfer.Enabled = this.bTranfer;
            this.chuyểnToolStripMenuItem.Checked = this.bTranfer;

            this.btSave.Enabled = this.bSave;
            this.lưuToolStripMenuItem.Checked = this.bSave;

            this.btViewList.Enabled = this.bView;
            this.xemKháchĐợiToolStripMenuItem.Checked = this.bView;

            this.btHelp.Enabled = this.bHelp;
            this.giúpĐỡToolStripMenuItem.Checked = this.bHelp;

            this.btLogout.Enabled = this.bLogout;
            this.đăngXuấtToolStripMenuItem.Checked = this.bLogout;

            this.cấpPhiếuToolStripMenuItem.Checked = this.bPrintTicket;

            this.btnEditInfo.Enabled = this.bUpdateInfo;
            cậpNhậtThôngTinToolStripMenuItem.Checked = Settings.Default.actUpdateInfo;

            btnDanhGia.Enabled = Settings.Default.actEvaluate;
            đánhGiáToolStripMenuItem.Checked = Settings.Default.actEvaluate;

            this.thuGọnGiaoDiệnToolStripMenuItem1.Enabled = Settings.Default.actSmallScreen;

            this.giúpĐỡToolStripMenuItem.Checked = this.bHelp;
        }
        #region Event



        private void btHelp_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            //    GPRO_QMS_Counter.BLL.BLLUser.Instance.WriteRequired(loginObj.EquipCode, eAction.Help, txtParam.Text.Trim(), DateTime.Now);
            txtResult.Text = "Yêu cầu Giúp đỡ";
        }




        private void btSave_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            string text = txtParam.Text.Trim();
            string text2 = lbCurrentTicket.Text.Trim();

            if (string.IsNullOrEmpty(text2))
            {
                MessageBox.Show("Bạn phải gọi vé vào quầy trước khi lưu.", "Thông báo lưu vé", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtResult.Text = "Không thể thực hiện lưu vé chưa xác định!";
            }
            else
            {
                var now = DateTime.Now;
                if (string.IsNullOrEmpty(text))
                {
                    BLLDailyRequire.Instance.StoreTicket(connectString, int.Parse(text2), loginObj.UserId, loginObj.EquipCode, today);
                    txtParam.Text = "";
                    txtResult.Text = "Yêu cầu Lưu vé hiện tại";
                }
                else
                {
                    //   GPRO_QMS_Counter.BLL.BLLUser.Instance.WriteRequired(FrmMain.loginObj.EquipCode, eAction.Save, text2 + " " + text, now);
                    txtParam.Text = "";
                    txtResult.Text = "Yêu cầu Lưu vé hiện tại sau " + text + " khách";
                }
            }
        }

        private void btViewList_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = "";
            //  GPRO_QMS_Counter.BLL.BLLUser.Instance.WriteRequired(FrmMain.loginObj.EquipCode, eAction.View, txtParam.Text.Trim(), DateTime.Now);
            FrmViewWaitingList.bHaveCommbobox = false;
            this.txtResult.Text = "Yêu cầu Xem danh sách đợi";
        }
















        private void cổngCOMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FrmComSetting();
            while (true)
            {
                f.ShowDialog();
                if (FrmComSetting.bChangeCOMPort)
                {
                    this.serialPort1.Close();
                    this.serialPort1.PortName = FrmMain.sComPort;
                    this.serialPort1.BaudRate = FrmMain.iBaudRate;
                    this.serialPort1.DataBits = (int)FrmMain.iDataBits;
                    this.serialPort1.Parity = FrmMain.sParity;
                    try
                    {
                        this.serialPort1.Open();
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi khi mở cổng " + FrmMain.sComPort + "! Vui lòng kiểm tra lại.", "Lỗi mở COM Port", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        continue;
                    }
                    break;
                }
                break;
            }
        }




        private void âmThanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConfig f = new FrmConfig();
            f.ShowDialog();
        }

        #endregion

        private void ShowResult()
        {
            var obj = BLLLoginHistory.Instance.GetForHome(connectString, loginObj.UserId, loginObj.EquipCode, DateTime.Now, UseWithThirdPattern);// BLLUser.Instance.ReadResult(FrmMain.loginObj.EquipCode);
            if (obj != null)
            {
                //if (obj.IsLogout)
                //{
                //    tmerGetResult.Enabled = false;
                //    MessageBox.Show("Tài khoản hiện tại đã được đăng nhập vào chương trình ở thiết bị khác. Bạn cần đăng nhập lại vào chương trình.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    this.WriteSetting();
                //    BLLLoginHistory.Instance.Logout(FrmMain.loginObj.UserId, FrmMain.loginObj.EquipCode, DateTime.Now);
                //    this.Hide();
                //    DialogResult dialogResult = MessageBox.Show("Bạn đã đăng xuất thành công! \nBạn có muốn tiếp tục chương trình không?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                //    if (dialogResult == DialogResult.Yes)
                //        Process.Start("GPRO_QMS_Counter.exe");
                //    else
                //        Application.Exit();
                //}
                //else
                //{
                this.lbWaiting.Text = obj.CounterWaitingTickets;
                this.lbGeneralWaiting.Text = obj.AllWaitingTickets;
                this.statusTotalWaiting.Text = "Đang đợi: " + obj.TotalWating;
                this.statusTotalDone.Text = "Đã giao dịch: " + obj.TotalDone;
                this.lbCurrentTicket.Text = obj.CurrentTicket.ToString();
                this.lbCurrentTicket_s.Text = obj.CurrentTicket.ToString();
                btnNext_small.Text = obj.CountWaitAtCounter.ToString();
                //  }
            }
        }





        private void btnDanhGia_Click(object sender, EventArgs e)
        {
            //  if (!BLLData.Instance.ChangeStatusToDG(loginObj))
            //    MessageBox.Show("Không gọi đánh giá được.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void timerFindbtnClick_Tick(object sender, EventArgs e)
        {
            // if (BLLData.Instance.FindButtonClick(loginObj) != null)
            //      btFinish_Click(sender, e);
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

        private void timerResetInfo_Tick(object sender, EventArgs e)
        {
            try
            {
                //  stt = BLLData.Instance.CheckInfo(loginObj, stt, Convert.ToInt32(lbCurrentTicket.Text));
            }
            catch (Exception)
            {
            }

        }

        private void chbkService_ItemCheck(object sender, System.Windows.Forms.ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < chbkService.Items.Count; ++ix)
                if (ix != e.Index)
                    chbkService.SetItemChecked(ix, false);
        }

        private void btnPrintTicket_Click(object sender, EventArgs e)
        {
            var selectedService = (CheckedListBoxItem)chbkService.SelectedItem;
            if (selectedService == null)
                MessageBox.Show("Vui lòng chọn dịch vụ cần cấp phiếu.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                var require = new PrinterRequireModel()
                {
                    PrinterId = printerId,
                    Address = txtAdd.Text,
                    DOB = (int)txtDOB.Value,
                    Name = txtname.Text,
                    ServeTime = timeServeAllow.Value,
                    ServiceId = (int)selectedService.Value
                };
                if (BLLCounterSoftRequire.Instance.Insert(connectString, JsonConvert.SerializeObject(require), (int)eCounterSoftRequireType.PrintTicket))
                {
                    lbPrintStatus.Text = "Gửi yêu cầu cấp phiếu thành công.";
                    lbPrintStatus.ForeColor = Color.Blue;
                }
                else
                {
                    lbPrintStatus.Text = "Gửi yêu cầu cấp phiếu thất bại";
                    lbPrintStatus.ForeColor = Color.DarkRed;
                }
            }
        }


        private void WriteSetting()
        {
            Settings.Default.actCallNext = this.bCallNext;
            Settings.Default.actRecall = this.bRecall;
            Settings.Default.actFinish = this.bFinish;
            Settings.Default.actCancel = this.bCancel;
            Settings.Default.actCallTicket = this.bCallAny;
            Settings.Default.actPass = this.bTranfer;
            Settings.Default.actSave = this.bSave;
            Settings.Default.actView = this.bView;
            Settings.Default.actHelp = this.bHelp;
            Settings.Default.actLogout = this.bLogout;
            Settings.Default.actPrintTicket = this.bPrintTicket;
            Settings.Default.Save();
        }

        private void đánhGiáToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thuGọnGiaoDiệnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Size = new Size(207, 168);
            this.menuStrip1.Visible = false;
            this.splitContainer1.Visible = false;
            this.panel4.Visible = true;
        }

        private void FrmMain_SizeChanged(object sender, EventArgs e)
        {
            if (this.Height == this.MinimumSize.Height)
            {
                this.Size = new Size(207, 168);
                this.menuStrip1.Visible = false;
                this.splitContainer1.Visible = false;
                this.panel4.Visible = true;
            }
            else
            {
                this.panel4.Visible = false;
                this.menuStrip1.Visible = true;
                this.splitContainer1.Visible = true;
                this.StartPosition = FormStartPosition.CenterScreen;
            }
        }

        private void btnFullscreen_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1130, 604);
            this.panel4.Visible = false;
            this.menuStrip1.Visible = true;
            this.splitContainer1.Visible = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            if (this.bPrintTicket)
                this.Size = new Size(1130, 604);
            else
                this.Size = new Size(912, 604);
        }
    }
}
