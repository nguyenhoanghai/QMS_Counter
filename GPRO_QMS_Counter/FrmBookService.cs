 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPRO_QMS_Counter
{
    public partial class FrmBookService : Form
    {
        int Id = 0;
        public FrmBookService()
        {
            InitializeComponent();
        //    cbUser.DataSource = BLLUser.Instance.Get();
            cbUser.DisplayMember = "TENNV";
        }

        private void FrmBookService_Load(object sender, EventArgs e)
        {
       //     gridControl1.DataSource = BLLBookService.Instance.Get();

            btCancel_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btAdd.Enabled = false;
            btUpdate.Enabled = false;
            btDelete.Enabled = false;
            btSave.Enabled = true;
            Id = 0;
            txtDienThoai.Text = "";
            txtKH.Text = "";
            txtSoXe.Text = "";
            cbUser.SelectedIndex = 0;
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            btSave_Click(sender, e);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
          //  BLLBookService.Instance.Delete(Id);
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            btAdd.Enabled = true;
            btUpdate.Enabled = false;
            btDelete.Enabled = false;
            btSave.Enabled = false;
            Id = 0;
            txtDienThoai.Text = "";
            txtKH.Text = "";
            txtSoXe.Text = "";
            cbUser.SelectedIndex = 0;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
          //  var user = (NHANVIEN)cbUser.SelectedItem;
            //if (user == null || user.MANV == 0)
            //{
            //    MessageBox.Show("Vui lòng chọn nhân viên.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    cbUser.Focus();
            //}
            //else if (string.IsNullOrEmpty(txtKH.Text))
            //{
            //    MessageBox.Show("Vui lòng nhập tên khách hàng.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtKH.Focus();
            //}
            //else if (string.IsNullOrEmpty(txtSoXe.Text))
            //{
            //    MessageBox.Show("Vui lòng nhập số xe.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtSoXe.Focus();
            //}
            //else if (string.IsNullOrEmpty(txtDienThoai.Text))
            //{
            //    MessageBox.Show("Vui lòng nhập số điện thoại.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtDienThoai.Focus();
            //}
            //else
            //{
            //    var obj = new Q_BookService();
            //    obj.Id = Id;
            //    obj.MaNV = user.MANV;
            //    obj.KhachHang = txtKH.Text;
            //    obj.SoXe = txtSoXe.Text;
            //    obj.SoDienThoai = txtDienThoai.Text;
            //    obj.NgayHen = dateNgayHen.Value;
            //    obj.GioHen = timeGioHen.Value.TimeOfDay;
            //    if (!BLLBookService.Instance.InsertOrUpdate(obj))
            //        MessageBox.Show("Xử lý không thành công", "Lỗi");
            //    else
            //        FrmBookService_Load(sender, e);
            //}
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                cbUser.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "User") != null ? gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "User").ToString() : string.Empty;
                txtKH.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "KhachHang") != null ? gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "KhachHang").ToString() : string.Empty;
                txtSoXe.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SoXe") != null ? gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SoXe").ToString() : string.Empty;
                txtDienThoai.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SoDienThoai") != null ? gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SoDienThoai").ToString() : string.Empty;
                dateNgayHen.Value = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NgayHen") != null ? DateTime.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NgayHen").ToString()) : DateTime.Now;
                timeGioHen.Value = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "GioHen") != null ? DateTime.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "GioHen").ToString()) : DateTime.Now;
                int.TryParse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Id").ToString(), out Id);

                btAdd.Enabled = false;
                btSave.Enabled = false;
                btUpdate.Enabled = true;
                btDelete.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
