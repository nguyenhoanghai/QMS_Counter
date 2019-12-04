using Microsoft.VisualBasic;
using Newtonsoft.Json;
using QMS_System.Data.BLL;
using QMS_System.Data.Enum;
using QMS_System.Data.Model;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GPRO_QMS_Counter
{
    internal interface IChildMethods
    {
        void enableTimer();
        void disableTimer();
    }
    public partial class FrmMain3 : Form, IChildMethods
    {
        LoginHistoryModel loginObj = null;
        int equipCode = 0,
            counterId = 0,
            xPos = 0,
            yPos = 315,
            xPos1 = 0,
            yPos1 = 235;

        public FrmMain3(LoginHistoryModel _model)
        {
            loginObj = _model;
            equipCode = loginObj.EquipCode;
            counterId = loginObj.CounterCode;
            InitializeComponent();
        }

        private void FrmMain3_Load(object sender, EventArgs e)
        {
            lbCounterName.Text = loginObj.CounterName;
            statusStaffName.Text = loginObj.UserName;
            statusLoginTime.Text = loginObj.Date.Value.ToString("dd/MM/yyyy HH:mm");
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

        public void enableTimer()
        {
            timer1.Enabled = true;
            lbWaiting.Text = "";
            lbGeneralWaiting.Text = "";
        }

        public void disableTimer()
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            txtResult.Text = "";
        }
        private void ShowResult()
        {
            var obj = BLLLoginHistory.Instance.GetForHome(FrmMain2.connectString, loginObj.UserId, loginObj.EquipCode, DateTime.Now, FrmMain2.UseWithThirdPattern);// BLLUser.Instance.ReadResult(FrmMain.loginObj.EquipCode);
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
                this.timer3.Start();
            }
            else
            {
                this.timer3.Stop();
                this.lbGeneralWaiting.Left = 4;
                this.lbGeneralWaiting.Top = 370;
            }
        }

        private void lbWaiting_TextChanged(object sender, EventArgs e)
        {
            if (this.lbWaiting.Text.Length > 26)
            {
                this.xPos1 = this.lbWaiting.Location.X;
                this.yPos1 = this.lbWaiting.Location.Y;
                this.timer2.Start();
            }
            else
            {
                this.timer2.Stop();
                this.lbWaiting.Left = 4;
                this.lbWaiting.Top = 288;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                if (this.xPos1 <= -this.lbWaiting.Width)
                {
                    this.lbWaiting.Location = new Point(this.splitContainer1.Panel1.Width, this.yPos1);
                    this.xPos1 = this.splitContainer1.Panel1.Width;
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
                    this.lbGeneralWaiting.Location = new Point(this.splitContainer1.Panel1.Width, this.yPos);
                    this.xPos = this.splitContainer1.Panel1.Width;
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

        #region event
        private void btNext_Click(object sender, EventArgs e)
        {
            try
            {
                var tk = BLLDailyRequire.Instance.Next(FrmMain2.connectString, loginObj.UserId, loginObj.EquipCode, FrmMain2.today, FrmMain2.UseWithThirdPattern);
                if (tk == 0)
                    txtResult.Text = "Hết vé";
                else
                {
                    lbCurrentTicket.Text = tk.ToString();
                    FrmMain2.SendDisplay(tk.ToString());

                    var requireJSON = JsonConvert.SerializeObject(new RequireMainDisplay() { EquipCode = loginObj.EquipCode, TicketNumber = tk });
                    BLLCounterSoftRequire.Instance.Insert(FrmMain2.connectString, requireJSON, (int)eCounterSoftRequireType.SendNextToMainDisplay, counterId);
                    var readTemplateIds = BLLUserCmdReadSound.Instance.GetReadTemplateIds(FrmMain2.connectString, loginObj.UserId, eCodeHex.Next);
                    if (readTemplateIds.Count > 0)
                        FrmMain2.GetSound(readTemplateIds, tk.ToString(), loginObj.CounterCode);
                }
            }
            catch (Exception)
            { }
        }

        private void btRecall_Click(object sender, EventArgs e)
        {
            int kq = BLLDailyRequire.Instance.CurrentTicket(FrmMain2.connectString, loginObj.UserId, loginObj.EquipCode, FrmMain2.today, FrmMain2.UseWithThirdPattern);
            if (kq == 0)
                txtResult.Text = "Hết vé";
            else
            {
                lbCurrentTicket.Text = kq.ToString();
                FrmMain2.SendDisplay(kq.ToString()); 

                var requireJSON = JsonConvert.SerializeObject(new RequireMainDisplay() { EquipCode = loginObj.EquipCode, TicketNumber = kq });
                BLLCounterSoftRequire.Instance.Insert(FrmMain2.connectString, requireJSON, (int)eCounterSoftRequireType.SendRecallToMainDisplay, counterId);

                var readTemplateIds = BLLUserCmdReadSound.Instance.GetReadTemplateIds(FrmMain2.connectString, loginObj.UserId, eCodeHex.Recall);
                if (readTemplateIds.Count > 0)
                    FrmMain2.GetSound(readTemplateIds, kq.ToString(), loginObj.CounterCode);
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
                    //MessageBox.Show("Bạn phải nhập số vé bất kỳ muốn gọi.", "Thông báo gọi vé", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.txtResult.Text = "Bạn phải nhập số vé bất kỳ muốn gọi.";
                    this.txtParam.Focus();
                }
                else
                {
                    var dscho = lbWaiting.Text.Split(' ').ToList();
                    if (dscho.Contains(text))
                    {
                        var kq = BLLDailyRequire.Instance.CallAny(FrmMain2.connectString, loginObj.UserId, loginObj.EquipCode, int.Parse(text), FrmMain2.today);
                        if (kq.IsSuccess)
                        {
                            this.txtParam.Text = "";
                            this.txtResult.Text = "Yêu cầu Gọi số " + text;
                            lbCurrentTicket.Text = text;
                            FrmMain2.SendDisplay(text);

                            var readTemplateIds = BLLUserCmdReadSound.Instance.GetReadTemplateIds(FrmMain2.connectString, loginObj.UserId, eCodeHex.Next);
                            if (readTemplateIds.Count > 0)
                                FrmMain2.GetSound(readTemplateIds, text, loginObj.CounterCode);
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
            }
            catch (Exception)
            {
            }
        }


        private void btFinish_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = "";
            string text = this.lbCurrentTicket.Text;
            if (text != "" && text != "0")
                BLLDailyRequire.Instance.DoneTicket(FrmMain2.connectString, loginObj.UserId, loginObj.EquipCode, DateTime.Now);
        }

        private void btTranfer_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(lbCurrentTicket.Text) && lbCurrentTicket.Text != "0") || !string.IsNullOrEmpty(txtParam.Text))
            {
                var now = DateTime.Now;
                txtResult.Text = "";
                var f = new FrmChange(!string.IsNullOrEmpty(txtParam.Text) ? int.Parse(txtParam.Text) : int.Parse(lbCurrentTicket.Text), loginObj.EquipCode);
                f.ShowDialog();
            }
            else
                this.txtResult.Text = "Không thể thực hiện chuyển vé chưa xác định!";
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
                    if (BLLDailyRequire.Instance.DeleteTicket(FrmMain2.connectString, int.Parse(text), FrmMain2.today) > 0)
                    {
                        this.txtParam.Text = "";
                        this.txtResult.Text = "Yêu cầu Hủy vé " + text;
                    }
                }
            }
        }
        #endregion
    }
}
