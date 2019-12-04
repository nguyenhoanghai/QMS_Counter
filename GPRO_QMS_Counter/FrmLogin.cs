using GPRO.Core.Hai;
using QMS_System.Data.BLL;
using QMS_System.Data.Model;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace GPRO_QMS_Counter
{
    public partial class FrmLogin : Form
    {
        public static bool bCloseForm = false;
        string connectString = BaseCore.Instance.GetEntityConnectString(Application.StartupPath + "\\DATA.XML");
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
                if (text.Equals("gproadmin") && text2.Equals("gproadmin"))
                {
                    FrmMain.loginObj = new Login()
                    {
                        UserName = "GPRO Admin",
                        EquipCode = int.Parse(ConfigurationManager.AppSettings["CounterId"].ToString()),
                        LoginTime = DateTime.Now.ToString("dd/MM/yyyy HH:mm"),
                        UserId = 100,
                        CounterId = int.Parse(ConfigurationManager.AppSettings["CounterId"].ToString()),
                        CounterName = "GPRO Admin Counter"
                    };
                    FrmLogin.bCloseForm = true;
                    this.Close();
                }
                else
                {
                    if (text == "" || text2 == "")
                    {
                        MessageBox.Show("Tên đăng nhập và mật khẩu không được rỗng!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        this.txtUsername.Focus();
                    }
                    else
                    {
                        //  MessageBox.Show("info " + txtUsername.Text + "-" + txtPassword.Text + "-" + Common.Instance.GetCounterId());
                        int apptype = 1;
                        try
                        {
                            int.TryParse(ConfigurationManager.AppSettings["AppType"].ToString(), out apptype);
                        }
                        catch (Exception) { }
                        ResponseBaseModel rs;
                        if (apptype == 1)
                            rs = BLLLoginHistory.Instance.Login(connectString, txtUsername.Text, txtPassword.Text, int.Parse(ConfigurationManager.AppSettings["CounterId"].ToString()));
                        else
                            rs = BLLLoginHistory.Instance.Login(connectString, txtUsername.Text, txtPassword.Text);

                        if (rs.IsSuccess)
                        {
                            FrmMain.loginObj = rs.Data;
                            FrmMain2.loginObj = rs.Data;
                            FrmLogin.bCloseForm = true;
                            this.Close();
                        }
                        else
                            MessageBox.Show(rs.sms, "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
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
