using GPRO_QMS_Counter.Helper;
using GPRO_QMS_Counter.Properties;
using QMS_System.Data.BLL;
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
    public partial class FrmLogin : Form
    {
        public static bool bCloseForm = false;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!FrmLogin.bCloseForm)
                Application.Exit();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                btLogin_Click(sender, e);
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string text = this.txtUsername.Text;
                string text2 = this.txtPassword.Text;
                if (text == "" || text2 == "")
                {
                    MessageBox.Show("Tên đăng nhập và mật khẩu không được rỗng!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    this.txtUsername.Focus();
                }
                else
                {
                  //  MessageBox.Show("info " + txtUsername.Text + "-" + txtPassword.Text + "-" + Common.Instance.GetCounterId());
                    var rs = BLLLoginHistory.Instance.Login(txtUsername.Text, txtPassword.Text, Settings.Default.CounterId);
                  //  MessageBox.Show("after");
                    if (rs.IsSuccess)
                    {
                        FrmMain.loginObj = rs.Data;
                        FrmLogin.bCloseForm = true;
                        this.Close();
                    }
                    else
                        MessageBox.Show(rs.sms, "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
                }
            }
            catch (Exception ex)
            {
                throw ex;
                // MessageBox.Show("Lỗi: trong quá trình kiểm tra đăng nhập"+ex.Message, "Lỗi truy vấn", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            FrmLogin.bCloseForm = true;
            Application.Exit();
        }
    }
}
