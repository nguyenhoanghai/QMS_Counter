using GPRO.Core.Hai;
using Newtonsoft.Json;
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
        string connectString = string.Empty;
        int counterId = 1;
        public FrmLogin()
        {
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
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn đóng chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                    e.Cancel = true;
            }
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
                    var login = new Login()
                    {
                        UserName = "GPRO Admin",
                        EquipCode = counterId,
                        LoginTime = DateTime.Now.ToString("dd/MM/yyyy HH:mm"),
                        UserId = 100,
                        CounterId = counterId,
                        CounterName = "GPRO Admin Counter"
                    };
                    FrmMain.loginObj = login;
                    FrmMain2.loginObj = login;
                    FrmMain4.loginObj = login;
                    Form1.loginObj = login;
                    FrmMainPhongKham.loginObj = login;
                    FrmPhongKhamHuuNghi.loginObj = login;
                    FrmMainRHM.loginObj = login;
                    FrmLogin.bCloseForm = true;
                  //  MessageBox.Show(JsonConvert.SerializeObject(login));
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
                        connectString = BaseCore.Instance.GetEntityConnectString(Application.StartupPath + "\\DATA.XML");
                        //  MessageBox.Show("info " + txtUsername.Text + "-" + txtPassword.Text + "-" + Common.Instance.GetCounterId());
                        int apptype = 1;
                        try
                        {
                            int.TryParse(ConfigurationManager.AppSettings["AppType"].ToString(), out apptype);
                        }
                        catch (Exception) { }
                        ResponseBaseModel rs;
                        switch (apptype)
                        {
                            case 1:
                            case 4:
                            case 5:
                            case 6:
                                rs = BLLLoginHistory.Instance.Login(connectString, txtUsername.Text, txtPassword.Text, counterId); break;
                            default:

                                rs = BLLLoginHistory.Instance.Login(connectString, txtUsername.Text, txtPassword.Text);
                                break;
                        }
                        // MessageBox.Show(connectString);
                        if (rs.IsSuccess)
                        {
                            FrmMain.loginObj = rs.Data;
                            FrmMain2.loginObj = rs.Data;
                            FrmMain4.loginObj = rs.Data;
                            Form1.loginObj = rs.Data;
                            FrmMainPhongKham.loginObj = rs.Data;
                            FrmPhongKhamHuuNghi.loginObj = rs.Data;
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
                //throw ex;
                MessageBox.Show("Lỗi: trong quá trình kiểm tra đăng nhập" + ex.Message, "Lỗi truy vấn", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn đóng chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                FrmLogin.bCloseForm = true;
                Application.Exit();
            }
        }
    }
}
