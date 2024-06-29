using Microsoft.VisualBasic;
using Newtonsoft.Json;
using QMS_System.Data.BLL;
using QMS_System.Data.BLL.RangHamMat;
using QMS_System.Data.Enum;
using QMS_System.Data.Model;
using QMS_System.ThirdApp.Enum;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GPRO_QMS_Counter
{
    public partial class FrmGoiSo_RHM : Form
    {
        int equipCode = 0,
            counterId = 0,
            userId = 0,
            xPos = 0,
            yPos = 370,
            xPos1 = 0,
            yPos1 = 290;
        string _counterName = "", _userName = "";
        public FrmGoiSo_RHM()
        {
            equipCode = 0;
            counterId = 0;
            InitializeComponent();
        }

        private void FrmGoiSo_RHM_Load(object sender, EventArgs e)
        {
            var users = BLLRangHamMat.Instance.getDSDangNhap(FrmMainRHM.connectString);
            cbGhe.DataSource = users;
            cbGhe.DisplayMember = "Code";
        }

        private void cbGhe_SelectedIndexChanged(object sender, EventArgs e)
        {
            ModelSelectItem modelSelect = (ModelSelectItem)cbGhe.SelectedItem;
            if (modelSelect != null)
            {
                userId = modelSelect.Record;
                equipCode = modelSelect.Id;
                _userName = modelSelect.Name;
                _counterName = modelSelect.Code;
                counterId = (int)modelSelect.Data1;

               // lbCounterName.Text = _counterName;
                statusStaffName.Text = _userName;
                // statusLoginTime.Text = loginObj.Date.Value.ToString("dd/MM/yyyy HH:mm");
            }
        }
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
                var tk = BLLRangHamMat.Instance.Next(FrmMainRHM.connectString, userId, equipCode, FrmMainRHM.today, FrmMainRHM.UseWithThirdPattern, (int)eServiceType.CLS);
                if (tk == 0)
                    txtResult.Text = "Hết vé";
                else
                {
                    lbCurrentTicket.Text = tk.ToString();
                    // FrmMainRHM.SendDisplay(tk.ToString());

                    var requireJSON = JsonConvert.SerializeObject(new RequireMainDisplay() { EquipCode = equipCode, TicketNumber = tk });
                    BLLCounterSoftRequire.Instance.Insert(FrmMainRHM.connectString, requireJSON, (int)eCounterSoftRequireType.SendNextToMainDisplay, counterId, equipCode);
                    var readTemplateIds = BLLUserCmdReadSound.Instance.GetReadTemplateIds(FrmMainRHM.connectString, userId, eCodeHex.Next);
                    if (readTemplateIds.Count > 0)
                        FrmMainRHM.GetSound(readTemplateIds, tk.ToString(), counterId);
                }
            }
            catch (Exception)
            { }
        }

        private void btRecall_Click(object sender, EventArgs e)
        {
            int kq = BLLRangHamMat.Instance.CurrentTicket(FrmMainRHM.connectString, userId, equipCode, FrmMainRHM.today, FrmMainRHM.UseWithThirdPattern, (int)eServiceType.CLS);
            if (kq == 0)
                txtResult.Text = "Hết vé";
            else
            {
                lbCurrentTicket.Text = kq.ToString();
                //  FrmMainRHM.SendDisplay(kq.ToString());

                var requireJSON = JsonConvert.SerializeObject(new RequireMainDisplay() { EquipCode = equipCode, TicketNumber = kq });
                BLLCounterSoftRequire.Instance.Insert(FrmMainRHM.connectString, requireJSON, (int)eCounterSoftRequireType.SendRecallToMainDisplay, counterId, equipCode);

                var readTemplateIds = BLLUserCmdReadSound.Instance.GetReadTemplateIds(FrmMainRHM.connectString, userId, eCodeHex.Recall);
                if (readTemplateIds.Count > 0)
                    FrmMainRHM.GetSound(readTemplateIds, kq.ToString(), counterId);
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
                        var kq = BLLRangHamMat.Instance.CallAny(FrmMainRHM.connectString, userId, equipCode, int.Parse(text), FrmMainRHM.today, (int)eServiceType.CLS);
                        if (kq.IsSuccess)
                        {
                            this.txtParam.Text = "";
                            this.txtResult.Text = "Yêu cầu Gọi số " + text;
                            lbCurrentTicket.Text = text;
                            // FrmMainRHM.SendDisplay(text);

                            var readTemplateIds = BLLUserCmdReadSound.Instance.GetReadTemplateIds(FrmMainRHM.connectString, userId, eCodeHex.Next);
                            if (readTemplateIds.Count > 0)
                                FrmMainRHM.GetSound(readTemplateIds, text, counterId);
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
                BLLDailyRequire.Instance.DoneTicket(FrmMainRHM.connectString, userId, equipCode, DateTime.Now);
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
                    if (!BLLDailyRequire.Instance.DeleteTicket(FrmMainRHM.connectString,userId, int.Parse(text), FrmMainRHM.today).IsSuccess)
                    {
                        this.txtParam.Text = "";
                        this.txtResult.Text = "Yêu cầu Hủy vé " + text;
                    }
                }
            }
        }


        private void btnNext_KM_Click(object sender, EventArgs e)
        {
            try
            {
                var tk = BLLRangHamMat.Instance.Next(FrmMainRHM.connectString, userId, equipCode, FrmMainRHM.today, FrmMainRHM.UseWithThirdPattern, (int)eServiceType.PhongKham);
                if (tk == 0)
                    txtResult.Text = "Hết vé";
                else
                {
                    lbCurrentTicket.Text = tk.ToString();
                    // FrmMainRHM.SendDisplay(tk.ToString());

                    var requireJSON = JsonConvert.SerializeObject(new RequireMainDisplay() { EquipCode = equipCode, TicketNumber = tk });
                    BLLCounterSoftRequire.Instance.Insert(FrmMainRHM.connectString, requireJSON, (int)eCounterSoftRequireType.SendNextToMainDisplay, counterId, equipCode);
                    var readTemplateIds = BLLUserCmdReadSound.Instance.GetReadTemplateIds(FrmMainRHM.connectString, userId, eCodeHex.Next);
                    if (readTemplateIds.Count > 0)
                        FrmMainRHM.GetSound(readTemplateIds, tk.ToString(), counterId);
                }
            }
            catch (Exception)
            { }
        }

        private void btnRecall_KM_Click(object sender, EventArgs e)
        {
            int kq = BLLRangHamMat.Instance.CurrentTicket(FrmMainRHM.connectString, userId, equipCode, FrmMainRHM.today, FrmMainRHM.UseWithThirdPattern, (int)eServiceType.PhongKham);
            if (kq == 0)
                txtResult.Text = "Hết vé";
            else
            {
                lbCurrentTicket.Text = kq.ToString();
                //  FrmMainRHM.SendDisplay(kq.ToString());

                var requireJSON = JsonConvert.SerializeObject(new RequireMainDisplay() { EquipCode = equipCode, TicketNumber = kq });
                BLLCounterSoftRequire.Instance.Insert(FrmMainRHM.connectString, requireJSON, (int)eCounterSoftRequireType.SendRecallToMainDisplay, counterId, equipCode);

                var readTemplateIds = BLLUserCmdReadSound.Instance.GetReadTemplateIds(FrmMainRHM.connectString, userId, eCodeHex.Recall);
                if (readTemplateIds.Count > 0)
                    FrmMainRHM.GetSound(readTemplateIds, kq.ToString(), counterId);
            }
        }

        private void btCallany_KM_Click(object sender, EventArgs e)
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
                    var dscho = lbGeneralWaiting.Text.Split(' ').ToList();
                    if (dscho.Contains(text))
                    {
                        var kq = BLLRangHamMat.Instance.CallAny(FrmMainRHM.connectString, userId, equipCode, int.Parse(text), FrmMainRHM.today, (int)eServiceType.PhongKham);
                        if (kq.IsSuccess)
                        {
                            this.txtParam.Text = "";
                            this.txtResult.Text = "Yêu cầu Gọi số " + text;
                            lbCurrentTicket.Text = text;
                            // FrmMainRHM.SendDisplay(text);

                            var readTemplateIds = BLLUserCmdReadSound.Instance.GetReadTemplateIds(FrmMainRHM.connectString, userId, eCodeHex.Next);
                            if (readTemplateIds.Count > 0)
                                FrmMainRHM.GetSound(readTemplateIds, text, counterId);
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
        #endregion

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
            var obj = BLLRangHamMat.Instance.GetForHome(FrmMainRHM.connectString, userId, equipCode, DateTime.Now, FrmMainRHM.UseWithThirdPattern);
            if (obj != null)
            {
                this.lbWaiting.Text = obj.CounterWaitingTickets;
                this.lbGeneralWaiting.Text = obj.AllWaitingTickets;
                this.statusTotalWaiting.Text = "Đang đợi điều trị: " + obj.TotalWating;
                this.statusTotalDone.Text = "Đã gọi điều trị: " + obj.TotalDone;
                this.lbCurrentTicket.Text = obj.CurrentTicket.ToString();
                //this.lbCurrentTicket_s.Text = obj.CurrentTicket.ToString();
                // btnNext_small.Text = obj.CountWaitAtCounter.ToString(); 
            }
        }

        #endregion
    }
}
