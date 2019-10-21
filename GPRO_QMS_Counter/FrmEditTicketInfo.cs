using GPRO.Core.Hai;
using QMS_System.Data.BLL;
using System;
using System.Windows.Forms;

namespace GPRO_QMS_Counter
{
    public partial class FrmEditTicketInfo : Form
    {
        int ticket = 0;
        string connectString = BaseCore.Instance.GetEntityConnectString(Application.StartupPath + "\\DATA.XML");
        public FrmEditTicketInfo(int _ticket)
        {
            ticket = _ticket;
            InitializeComponent();
        }

        private void FrmEditTicketInfo_Load(object sender, EventArgs e)
        {
            var obj = BLLDailyRequire.Instance.GetTicket(connectString, ticket);
            if (obj != null)
            {
                lbTicket.Text = obj.TicketNumber.ToString();
                txtName.Text = obj.CustomerName;
                txtAddress.Text = obj.CustomerAddress;
                if (obj.CustomerDOB.HasValue)
                    txtDOB.Value = obj.CustomerDOB.Value;

                var date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
                if (obj.ServeTimeAllow != null)
                    date = date.Add(obj.ServeTimeAllow);
                dtTime.Value = date;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var rs = BLLDailyRequire.Instance.UpdateTicketInfo(connectString, Convert.ToInt32(lbTicket.Text), dtTime.Value.TimeOfDay, txtName.Text, (int)txtDOB.Value, txtAddress.Text);
            if (rs == 0)
                MessageBox.Show("Cập nhật thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                this.Close();
        }
    }
}
