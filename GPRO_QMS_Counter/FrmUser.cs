using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using QMS_System.Data;
using QMS_System.Data.BLL;

namespace GPRO_QMS_Counter
{
    public partial class FrmUser : Form
    { 
        bool changeImg = false;
        string username, pass;
        public FrmUser( )
        {
            InitializeComponent(); 
        }

        private void btchoose_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image|*.jpg;*.bmp;*.gif;*.png";
            openFileDialog1.Title = "Choose an Image File";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pb_img.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
                changeImg = true;
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                var newUser = new Q_User()
                {
                    Id = FrmMain.loginObj.UserId,
                    Name = txtName.Text,
                    Position = txtCV.Text,
                    Professional = txtCM.Text,
                    Address = txtAdd.Text,
                    WorkingHistory = txtQTCT.Text,
                    UserName = username,
                    Password=pass
                };
                if (changeImg)
                {
                    if (openFileDialog1 != null && !string.IsNullOrEmpty(openFileDialog1.FileName))
                    {
                        string f = openFileDialog1.FileName;
                        var path = Path.GetDirectoryName(Application.ExecutablePath)+"\\Images\\"+Path.GetFileName(f);
                        if (!File.Exists(path))
                            File.Copy(f, path);
                        newUser.Avatar = Path.GetFileName(f);
                    }
                }
                newUser.Sex = rbNam.Checked ? true : false;
                if (BLLUser.Instance.Update(newUser))
                {
                    MessageBox.Show("Lưu thông tin nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    GetUserInfo();
                    changeImg = false;
                    this.Close();
                }
                else
                    MessageBox.Show("Lỗi : lưu thông tin nhân viên bị lỗi ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message, "Lỗi lấy thông tin Nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            GetUserInfo();
        }

        private void GetUserInfo()
        {
            try
            {
                var user = BLLUser.Instance.Get(FrmMain.loginObj.UserId);
                if (user != null)
                {
                    txtName.Text = user.Name;
                    txtCM.Text = user.Professional;
                    txtCV.Text = user.Position;
                    txtQTCT.Text = user.WorkingHistory;
                    txtAdd.Text = user.Address;
                    username = user.UserName;
                    pass = user.Password;
                    if (user.Sex)
                        rbNam.Checked = true;
                    else
                        rbNu.Checked = true;
                    var path = Path.GetDirectoryName(Application.ExecutablePath);
                    if (string.IsNullOrEmpty(user.Avatar))
                        pb_img.BackgroundImage = Image.FromFile(path + "\\Images\\nopic.png");
                    else
                        pb_img.BackgroundImage = Image.FromFile(path+ "\\Images\\" + user.Avatar);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message, "Lỗi lấy thông tin Nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
