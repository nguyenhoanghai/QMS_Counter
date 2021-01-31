using GPRO.Core.Hai;
using QMS_System.Data;
using QMS_System.Data.BLL;
using System;
using System.Windows.Forms;

namespace GPRO_QMS_Counter
{
    public partial class frmCustomer : Form
    {
        string connect = BaseCore.Instance.GetEntityConnectString(Application.StartupPath + "\\DATA.XML");
        int _Id = 0;
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            loadKhachHang();
        }

        private void loadKhachHang()
        {
            var obj = BLLCustomer.Instance.Gets(connect);
            gridCustomer.DataSource = obj;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            Q_Customer cust = new Q_Customer();
            cust.Id = _Id;
            cust.Code = txtcode.Text;
            cust.Name = txtname.Text;
            cust.Phone = txtphone.Text;
            cust.Address = txtaddress.Text;
            cust.Gender = cbgender.SelectedText == "Nam" ? true : false;
            var rs = BLLCustomer.Instance.CreateOrUpdate(connect, cust);
            if (rs.IsSuccess)
            {
                loadKhachHang();
                resetform();
            }
            else
                MessageBox.Show(rs.Errors[0].Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void resetform()
        {
            _Id = 0;
            txtcode.Text = "";
            txtname.Text = "";
            txtphone.Text = "";
            txtaddress.Text = "";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadKhachHang();
        }

        private void repbtn_deleteUser_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(gridViewCust.GetRowCellValue(gridViewCust.FocusedRowHandle, "Id").ToString());
            if (Id != 0)
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BLLCustomer.Instance.Delete(connect, Id);
                    loadKhachHang();
                }
            }
        }

        private void repbtnEdit_Click(object sender, EventArgs e)
        {
            _Id = int.Parse(gridViewCust.GetRowCellValue(gridViewCust.FocusedRowHandle, "Id").ToString());
            txtcode.Text = gridViewCust.GetRowCellValue(gridViewCust.FocusedRowHandle, "Code").ToString();
            txtname.Text = gridViewCust.GetRowCellValue(gridViewCust.FocusedRowHandle, "Name").ToString();
            txtphone.Text = gridViewCust.GetRowCellValue(gridViewCust.FocusedRowHandle, "Phone").ToString();
            txtaddress.Text = gridViewCust.GetRowCellValue(gridViewCust.FocusedRowHandle, "Address").ToString();
            cbgender.Text = gridViewCust.GetRowCellValue(gridViewCust.FocusedRowHandle, "strGender").ToString();
        }
    }
}
