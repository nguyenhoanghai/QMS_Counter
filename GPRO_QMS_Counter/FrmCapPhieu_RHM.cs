using GPRO.Core.Hai;
using QMS_System.Data.BLL;
using QMS_System.Data.BLL.RangHamMat;
using QMS_System.Data.Model;
using QMS_System.ThirdApp.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GPRO_QMS_Counter
{
    public partial class FrmCapPhieu_RHM : Form
    {
        string connect = BaseCore.Instance.GetEntityConnectString(Application.StartupPath + "\\DATA.XML");
        int _type = (int)eServiceType.CLS;
        List<ServiceDayModel> services;
        ScheduleModel schedule;
        public FrmCapPhieu_RHM()
        {
            InitializeComponent();
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbType.SelectedIndex == 0)
            {
                _type = (int)eDailyRequireType.KhamBenh;
                txtMaBN.Enabled = true;
            }
            else
            {
                _type = (int)eDailyRequireType.KetLuan;
                txtMaBN.Enabled = false;
            }
        }

        private void txtMaBN_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FindSchedule();
            }
        }

        private void FindSchedule()
        {
            try
            {
                if (!string.IsNullOrEmpty(txtMaBN.Text))
                {
                    schedule = BLLRangHamMat.Instance.findCustomerSchedule(connect, txtMaBN.Text, DateTime.Now.Month, DateTime.Now.Year, DateTime.Now.Day);
                    if (schedule != null)
                    {
                        txtThongTin.Text = "Ghế đăng ký: " + schedule.ServiceName + Environment.NewLine + 
                            "Họ tên: " + schedule.Name + Environment.NewLine +
                            "Năm sinh: " + schedule.YearOfBirth + Environment.NewLine +
                            "Địa chỉ: " + schedule.Address;
                        txtGioHen.Text = schedule.KhungGio;
                        cbGhe.Text = schedule.ServiceName;
                    }
                    else
                        MessageBox.Show("Không tìm thấy thông tin cuộc hẹn của bệnh nhân. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập mã bệnh nhân", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaBN.Focus();
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void FrmCapPhieu_RHM_Load(object sender, EventArgs e)
        {
            loadDichVu();

            var serType = new List<ModelSelectItem>();
            serType.Add(new ModelSelectItem() { Id = 1, Name = "Điều trị" });
            serType.Add(new ModelSelectItem() { Id = 2, Name = "Khám mới" });
            cbSerType.DataSource = serType;
            cbSerType.DisplayMember = "Name";
            cbSerType.ValueMember = "Id";

            var hens = new List<ModelSelectItem>();
            hens.Add(new ModelSelectItem() { Id = 1, Name = "Có hẹn" });
            hens.Add(new ModelSelectItem() { Id = 2, Name = "Không hẹn" });
            cbType.DataSource = hens;
            cbType.DisplayMember = "Name";
            cbType.ValueMember = "Id";
        }

        private void loadDichVu()
        {
            if (services == null)
                services = BLLService.Instance.GetsForMain(connect);

            List<ServiceDayModel> _ser = new List<ServiceDayModel>();
            if (cbSerType.SelectedIndex == 0)
            {
                _ser = services.Where(x => x.ServiceType == (int)eServiceType.CLS).ToList();
            }
            else
                _ser = services.Where(x => x.ServiceType == (int)eServiceType.PhongKham).ToList();

            cbGhe.DataSource = _ser;
            cbGhe.DisplayMember = "Name";
            cbGhe.ValueMember = "Id";
        }

        private void btInPhieu_Click(object sender, EventArgs e)
        {
            ServiceDayModel service = (ServiceDayModel)cbGhe.SelectedItem;
            ResponseBase response = null;
            string khunggio = "--";
            if (cbSerType.SelectedIndex == 1)
            {
                response = BLLRangHamMat.Instance.CapSoPhongKhamKhongHen(connect, service.Id, DateTime.Now);
            }
            else
            {
                if (schedule != null)
                {
                    response = BLLRangHamMat.Instance.CapSoPhongKhamCoHen(connect, service.Id, schedule.Name, schedule.Address, schedule.YearOfBirth, schedule.Code, DateTime.Now, schedule.KhungGioId);
                    khunggio = schedule.KhungGio;
                }
                else
                {
                    // ko hen dua ve sau
                    response = BLLRangHamMat.Instance.CapSoPhongKhamCoHen(connect, service.Id, "--", "--", 0, "--", DateTime.Now, 0);
                }
            }

            if (response != null && response.IsSuccess)
            {
                InPhieu(response.Data_3, response.Data, response.Data_2, service.Name, khunggio);
                schedule = null;
                txtThongTin.Text = "";
                txtMaBN.Text = "";
            }
        } 

        private void InPhieu(int newNum, int oldNum, string tenquay, string tendichvu, string khunggio)
        {
            var template = FrmMainRHM.ticketTemplate;
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
            template = template.Replace("[ngay]", ("Ngày: " + now.ToString("dd/MM/yyyy")));
            template = template.Replace("[gio]", ("Giờ: " + now.ToString("HH:mm")));
            template = template.Replace("[dang-goi]", "đang khám: " + oldNum);
            template = template.Replace("[khung-gio]", "khung giờ hẹn: " + khunggio);
            
        template = template.Replace("[cat-giay]", "\x1b\x69|+|");

            var arr = template.Split(new string[] { "|+|" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            for (int ii = 0; ii < FrmMainRHM.so_lien; ii++)
                for (int i = 0; i < arr.Length; i++)
                    BaseCore.Instance.PrintTicketTCVN3(FrmMainRHM.printSerialCOM , arr[i]); 
        }

        private void cbSerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSerType.SelectedIndex == 0)
            {
                //dieu tri
                _type = (int)eServiceType.CLS;
                cbType.Enabled = true;
                cbType_SelectedIndexChanged(sender, e);
                loadDichVu();
            }
            else
            {
                //kham moi
                _type = (int)eServiceType.PhongKham;
                cbType.Enabled = false;
                txtMaBN.Enabled = false;
                loadDichVu();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            schedule = null;
            txtThongTin.Text = "";
            txtMaBN.Text = "";
        }
    }
}
