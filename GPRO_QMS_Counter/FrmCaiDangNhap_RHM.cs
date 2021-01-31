using GPRO.Core.Hai;
using QMS_System.Data.BLL;
using QMS_System.Data.BLL.RangHamMat;
using System;
using System.Windows.Forms;

namespace GPRO_QMS_Counter
{
    public partial class FrmCaiDangNhap_RHM : Form
    {
        string connect = BaseCore.Instance.GetEntityConnectString(Application.StartupPath + "\\DATA.XML");
        public FrmCaiDangNhap_RHM()
        {
            InitializeComponent();
        }

        private void FrmCaiDangNhap_RHM_Load(object sender, EventArgs e)
        {
            loadGrid();
            loadCounters();
            loadUsers();           
        }

        private void loadGrid()
        {
            gridCustomer.DataSource = BLLRangHamMat.Instance.getDSDangNhap(connect);
        }

        private void loadUsers()
        {
            repLKUser.DataSource = null;
            repLKUser.DataSource = BLLUser.Instance.GetLookUp(connect);
            repLKUser.DisplayMember = "Name";
            repLKUser.ValueMember = "Id";
            repLKUser.PopulateViewColumns(); 
            for (int i = 0; i < 10; i++)
            {
                if (i != 1)
                    repLKUser.View.Columns[i].Visible = false;
            }
            repLKUser.View.Columns[1].Caption = "Bác sĩ";
        }

        private void loadCounters()
        {
            repLKCounter.DataSource = null;
            repLKCounter.DataSource = BLLCounter.Instance.GetLookUp(connect);
            repLKCounter.DisplayMember = "Name";
            repLKCounter.ValueMember = "Id";
            repLKCounter.PopulateViewColumns();
            repLKCounter.View.Columns[0].Visible = false;
            for (int i = 0; i < 10; i++)
            {
                if (i != 1)
                    repLKCounter.View.Columns[i].Visible = false;
            }
            repLKCounter.View.Columns[1].Caption = "Ghế";
        }

        private void gridViewCust_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                int counterId = 0, userId = 0;
                int.TryParse(gridViewCust.GetRowCellValue(gridViewCust.FocusedRowHandle, "Id").ToString(), out counterId);
                int.TryParse(gridViewCust.GetRowCellValue(gridViewCust.FocusedRowHandle, "Record").ToString(), out userId);
                if (counterId == 0 && userId != 0)
                    goto End;               
                else
                {
                    var result = BLLRangHamMat.Instance.changeLogin(connect,  userId, counterId); 
                    if (result.IsSuccess == false)
                    {
                        MessageBox.Show("Lưu thông tin thất bại", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        goto End;
                    } 
                    loadGrid(); 
                }
            }
            catch (Exception ex) { }
            End: { }
        }

        private void btrefreshBS_Click(object sender, EventArgs e)
        {
            loadUsers();
        }

        private void btrefreshGhe_Click(object sender, EventArgs e)
        {
            loadCounters();
        }
    }
}
