using GPRO.Core.Hai;
using QMS_System.Data.BLL;
using QMS_System.Data.Model;
using System;
using System.Configuration;
using System.Windows.Forms;
using System.Xml;

namespace GPRO_QMS_Counter
{
    public partial class FrmLogin : Form
    {
        public static bool bCloseForm = false;
        string connectString = BaseCore.Instance.GetEntityConnectString(Application.StartupPath + "\\DATA.XML");
        int counterId = 1;
        public FrmLogin(string _connectString)
        {
            if (string.IsNullOrEmpty(connectString))
                connectString = _connectString;
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        { 
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(Application.StartupPath + "\\DATA.XML");
            foreach (XmlElement element in xmlDoc.DocumentElement)
            {
                if (element.Name.Equals("AppConfig"))
                {
                    foreach (XmlNode node in element.ChildNodes)
                    {
                        try
                        {
                            switch (node.Name)
                            {
                                case "CounterId": counterId = (!string.IsNullOrEmpty(node.InnerText) ? Convert.ToInt32(node.InnerText) : 1); break;
                               }
                        }
                        catch (Exception ex)
                        {
                        }
                    }
                }
            }
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
                        EquipCode = counterId,
                        LoginTime = DateTime.Now.ToString("dd/MM/yyyy HH:mm"),
                        UserId = 100,
                        CounterId = counterId,
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
                        if (apptype == 1 || apptype==4)
                            rs = BLLLoginHistory.Instance.Login(connectString, txtUsername.Text, txtPassword.Text, counterId);
                        else
                            rs = BLLLoginHistory.Instance.Login(connectString, txtUsername.Text, txtPassword.Text);

                        if (rs.IsSuccess)
                        {
                            FrmMain.loginObj = rs.Data;
                            FrmMain2.loginObj = rs.Data;
                            FrmMain4.loginObj = rs.Data;
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
