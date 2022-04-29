using GPRO.Core.Hai;
using Microsoft.Win32;
using QMS_System.Data;
using QMS_System.Data.BLL;
using QMS_System.Data.Enum;
using QMS_System.Data.Model;
using Quobject.SocketIoClientDotNet.Client;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GPRO_QMS_Counter
{
    public partial class FrmTraKetQua_Socket : Form
    {
        public static string
              connectString,
            nodeServerIP = "";
        bool
           bRegistered = false,
           bCheckValid = false,
           FirstLoad = true;
        List<ConfigModel> configs;
        int _Id = 0;

        public FrmTraKetQua_Socket()
        {
            bCheckValid = CheckValidation();
            if (!bCheckValid)
            {
                FrmRegister frmRegister = new FrmRegister();
                frmRegister.ShowDialog();
            }

            if (bCheckValid)
            {
                InitializeComponent();
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

        private void FrmTraKetQua_Socket_Load(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    connectString = BaseCore.Instance.GetEntityConnectString(Application.StartupPath + "\\DATA.XML");
                }
                catch (Exception) { }
                configs = BLLConfig.Instance.Gets(connectString, true);

                nodeServerIP = GetConfigByCode(eConfigCode.NodeServerIP);
                ConnectSocketIO();

                refreshData();
            }
            catch (Exception ex)
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
                            SetText("Server Disconnected");
                        });


                    });
                    socket.On("server-send-socket-counter-soft", (socketId) =>
                    {
                        //MessageBox.Show(socketId.ToString());
                        SetText(socketId.ToString() + " | IP Address: " + BaseCore.Instance.GetLocalIPAddress());
                        socket.Emit("android-send-device-info", socketId + "|0|0|0");
                    });
                    // socket.Emit("client-send-id", id);

                    socket.On("node-counter-next", refreshData);
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
            if (this.lbSocketStatus.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                lbSocketStatus.Text = text;
                if (text != "Server Disconnected")
                    lbSocketStatus.BackColor = Color.Blue;
                else
                    lbSocketStatus.BackColor = Color.Red;
            }
        }

        #endregion

        private void refreshData()
        {
            gridDetail.DataSource = null;
            gridDetail.DataSource = BLLShowTV.Instance.Gets(connectString);
        }


        private void btnsave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumber.Text))
            {
                MessageBox.Show("Vui lòng nhập số phiếu", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumber.Focus();
            }
            else if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Vui lòng nhập ho va ten", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
            }
            else
            {
                var obj = new ShowTVModel();
                obj.Id = _Id;
                obj.TicketNumber = (int)txtNumber.Value;
                obj.Name = txtName.Text;
                obj.Note = txtContent.Text;
                obj.CreatedDate = DateTime.Now;
                BLLShowTV.Instance.InsertOrUpdate(connectString, obj);
                btClear.PerformClick();
                refreshData();
                try
                {
                    if (socket != null)
                        socket.Emit("qms-system-counter-show-tv-refresh", "1");
                }
                catch (Exception ex)
                { }

            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            txtNumber.Value = 0;
            txtName.Text = "";
            txtContent.Text = "";
            _Id = 0;
            btClear.Enabled = false;
            btSave.Enabled = false;
            btAddNew.Enabled = true;
            txtNumber.Enabled = false;
            txtName.Enabled = false;
            txtContent.Enabled = false;
        }

        private void btAddNew_Click(object sender, EventArgs e)
        {
            btClear.PerformClick();
            btClear.Enabled = true;
            btSave.Enabled = true;
            btAddNew.Enabled = false;
            txtNumber.Enabled = true;
            txtName.Enabled = true;
            txtContent.Enabled = true;
        }

        private void repbtn_deleteSound_Click(object sender, EventArgs e)
        {
            
            int Id = int.Parse(gridViewSound.GetRowCellValue(gridViewSound.FocusedRowHandle, "Id").ToString());
            if (Id != 0)
            {
                BLLShowTV.Instance.Delete(connectString, Id);
                refreshData();
                try
                {
                    if (socket != null)
                        socket.Emit("qms-system-counter-show-tv-refresh", "1");
                }
                catch (Exception ex)
                { }
            }
        }

        private void repBtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int.TryParse(gridViewSound.GetRowCellValue(gridViewSound.FocusedRowHandle, "Id").ToString(), out _Id);
                txtName.Text = gridViewSound.GetRowCellValue(gridViewSound.FocusedRowHandle, "Name").ToString();
                txtContent.Text = gridViewSound.GetRowCellValue(gridViewSound.FocusedRowHandle, "Note").ToString();
                txtNumber.Value = decimal.Parse(gridViewSound.GetRowCellValue(gridViewSound.FocusedRowHandle, "TicketNumber").ToString());
                txtNumber.Enabled = true;
                txtName.Enabled = true;
                txtContent.Enabled = true;
                btSave.Enabled = true;
                btClear.Enabled = true;
                btAddNew.Enabled = false;
            }
            catch (Exception ex)
            {
            }
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            refreshData();
        }

    }
}
