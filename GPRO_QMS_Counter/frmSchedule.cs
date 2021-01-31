using GPRO.Core.Hai;
using Lib_KetNoi;
using QMS_System.Data;
using QMS_System.Data.BLL;
using QMS_System.Data.BLL.RangHamMat;
using QMS_System.Data.Model;
using QMS_System.ThirdApp.Enum;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GPRO_QMS_Counter
{
    public partial class frmSchedule : Form
    {
        string connect = BaseCore.Instance.GetEntityConnectString(Application.StartupPath + "\\DATA.XML");
        int _Id = 0;
        int _custId = 0;

        AccessData lib;
        Q_Customer benhnhan;

        public frmSchedule()
        {
            InitializeComponent();
        }

        private void frmSchedule_Load(object sender, EventArgs e)
        {
            try
            {
                lib = new AccessData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối DLL Bệnh viện RHM bị lỗi. \n" + ex, "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            loadGrid();


            List<ModelSelectItem> khungGio = BLLRangHamMat.Instance.GetKhungGioLookUp(connect);
            cbKhungGio.DataSource = khungGio;
            cbKhungGio.DisplayMember = "Name";
            cbKhungGio.ValueMember = "Id";


            var fake = new List<ModelSelectItem>();
            fake.AddRange(khungGio);
            cbKhungFilter.DataSource = fake;
            cbKhungFilter.DisplayMember = "Name";
            cbKhungFilter.ValueMember = "Id";

            var services = BLLService.Instance.GetsForMain(connect);
            services = services.Where(x => x.ServiceType == (int)eServiceType.CLS).ToList();

            var fakeSers = new List<ServiceDayModel>();
            fakeSers.AddRange(services);

            cbService.DataSource = services;
            cbService.DisplayMember = "Name";
            cbService.ValueMember = "Id";

            cbServiceFilter.DataSource = fakeSers;
            cbServiceFilter.DisplayMember = "Name";
            cbServiceFilter.ValueMember = "Id";
        }

        private void txtcode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                searchCustomer();
        }

        private void searchCustomer()
        {
            try
            {
                // var cust =  BLLCustomer.Instance.Get(connect, txtcode.Text);
                if (lib != null)
                {
                    DataSet ds = lib.ds_benhnhan(txtcode.Text);
                    DataTable table = ds.Tables[0];
                    if (ds != null && ds.Tables != null && ds.Tables.Count > 0 && ds.Tables[0] != null)
                    {
                        benhnhan = new Q_Customer();
                        benhnhan.Code = txtcode.Text;
                        benhnhan.Name = ds.Tables[0].Rows[0]["hoten"].ToString();
                        benhnhan.Gender = (ds.Tables[0].Rows[0]["Phai"].ToString() == "1" ? true : false);
                        benhnhan.YearOfBirth = int.Parse(ds.Tables[0].Rows[0]["namsinh"].ToString());
                        benhnhan.Phone = "";// ds.Tables[0].Rows[0]["socmnd"].ToString();
                        benhnhan.Address = ds.Tables[0].Rows[0]["diachi"].ToString();

                        //benhnhan.Code = txtcode.Text;
                        //benhnhan.Name = "Test";
                        //benhnhan.Gender = ("1" == "1" ? true : false);
                        //benhnhan.YearOfBirth = int.Parse("1987");
                        //benhnhan.Phone = "";// ds.Tables[0].Rows[0]["socmnd"].ToString();
                        //benhnhan.Address = "HCM";

                        txtinfo.Text = "Họ tên: " + benhnhan.Name + Environment.NewLine +
                               "Năm sinh : " + benhnhan.YearOfBirth + Environment.NewLine +
                               "Địa chỉ: " + benhnhan.Address;
                    }
                    else
                        MessageBox.Show("Không tìm thấy thông tin khách hàng với mã:'" + txtcode.Text + "'. Vui lòng thử lại mã khác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                    MessageBox.Show("Phần mềm gọi số chưa thể kết nối được với DLL Bệnh viện RHM. \nVui lòng khởi động lại phần mềm gọi số hoặc liên hệ bộ phận kỹ thuật.\n Xin cảm ơn.!", "Lỗi kết nối DLL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Phần mềm gọi số chưa thể kết nối được với DLL Bệnh viện RHM. \nVui lòng khởi động lại phần mềm gọi số hoặc liên hệ bộ phận kỹ thuật.\n Xin cảm ơn.!", "Lỗi kết nối DLL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ModelSelectItem kg = (ModelSelectItem)cbKhungGio.SelectedItem;
            ServiceDayModel ghe = (ServiceDayModel)cbService.SelectedItem;
            if (benhnhan == null)
            {
                MessageBox.Show("Bạn chưa chọn bệnh nhân.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcode.Focus();
            }
            else if (kg == null)
            {
                MessageBox.Show("Khung giờ hẹn không được để trống.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbKhungGio.Focus();
            }
            else
            {
                Q_Schedule_Detail obj = new Q_Schedule_Detail();
                obj.Id = _Id;
                obj.CustomerId = _custId;
                obj.Note = txtnote.Text;
                obj.ScheduleDate = dtpDateSchedule.Value;
                obj.KhungGioId = kg.Id;
                obj.ServiceId = ghe.Id;
                var rs = BLLTimeSchedule.Instance.CreateOrUpdate(connect, obj, benhnhan);
                if (rs.IsSuccess)
                {
                    refreshForm();
                    loadGrid();
                }
                else
                {
                    MessageBox.Show(rs.Errors[0].Message, "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void refreshForm()
        {
            _Id = 0;
            _custId = 0;
            txtcode.Text = "";
            txtinfo.Text = "";
            txtnote.Text = "";
        }

        private void repbtn_deleteUser_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(gridViewSchedule.GetRowCellValue(gridViewSchedule.FocusedRowHandle, "Id").ToString());
            if (Id != 0)
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BLLCustomer.Instance.Delete(connect, Id);
                    loadGrid();
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadGrid();
        }

        private void loadGrid()
        {
            ModelSelectItem kg = (ModelSelectItem)cbKhungFilter.SelectedItem;
            ServiceDayModel ghe = (ServiceDayModel)cbServiceFilter.SelectedItem;
            var objs = BLLTimeSchedule.Instance.Gets(connect, dtpDateFilter.Value.Day, dtpDateFilter.Value.Month, dtpDateFilter.Value.Year, (kg != null ? kg.Id : 0), (ghe != null ? ghe.Id : 0));
            gridSchedule.DataSource = objs;
        }

        private void dtpDateFilter_ValueChanged(object sender, EventArgs e)
        {
            loadGrid();
        }

        private void cbKhungFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadGrid();
        }

        private void repButEdit_Click(object sender, EventArgs e)
        {
            _Id = int.Parse(gridViewSchedule.GetRowCellValue(gridViewSchedule.FocusedRowHandle, "Id").ToString());
            _custId = int.Parse(gridViewSchedule.GetRowCellValue(gridViewSchedule.FocusedRowHandle, "CustId").ToString());
            txtcode.Text = gridViewSchedule.GetRowCellValue(gridViewSchedule.FocusedRowHandle, "CustCode").ToString();
            txtinfo.Text = gridViewSchedule.GetRowCellValue(gridViewSchedule.FocusedRowHandle, "CustName").ToString();
            txtnote.Text = gridViewSchedule.GetRowCellValue(gridViewSchedule.FocusedRowHandle, "Note").ToString();
            cbKhungGio.Text = gridViewSchedule.GetRowCellValue(gridViewSchedule.FocusedRowHandle, "KhungGio").ToString();
            dtpDateSchedule.Value = DateTime.Parse(gridViewSchedule.GetRowCellValue(gridViewSchedule.FocusedRowHandle, "Time").ToString());
            txtcode.Enabled = false;
            benhnhan = new Q_Customer();
            benhnhan.Id = _custId;
            benhnhan.Code = txtcode.Text;
        }

        private void cbServiceFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadGrid();
        }
    }
}
