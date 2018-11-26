using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPRO_QMS_Counter
{
    public partial class FrmRegister : Form
    {
        string sSetupID = "", sLicenseKey = "";
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            if (this.txtLicenseKey.Text.Trim() == "" || this.txtLicenseKey.Text.Trim().Length != 23)
            {
                MessageBox.Show("Bạn phải nhập đúng Mã kích hoạt để đăng ký bản quyền!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Question);
                this.txtLicenseKey.Focus();
            }
            else
            {
                this.sLicenseKey = "";
                string text = GETEncrypt(this.GetEncrypt(this.txtSetupID.Text, "HAIDANGQMSADLAND"), "504E544451992014").ToUpper();
                for (int i = 0; i < 15; i++)
                {
                    this.sLicenseKey += text[i].ToString();
                    if ((i + 1) % 5 == 0)
                    {
                        this.sLicenseKey += "-";
                    }
                }
                this.sLicenseKey = this.sLicenseKey.Substring(0, this.sLicenseKey.Length - 1);
                text = this.txtLicenseKey.Text.Trim();
                string value = text.Substring(text.Length - 5);
                text = text.Substring(0, text.Length - 6);
                if (text == this.sLicenseKey)
                {
                    RegistryKey localMachine = Registry.LocalMachine;
                    RegistryKey registryKey = localMachine.OpenSubKey("Software", true);
                    RegistryKey registryKey2 = registryKey.CreateSubKey("GPRO");
                    RegistryKey registryKey3 = registryKey2.CreateSubKey("QMS Counter Soft");
                    registryKey3.SetValue("SoftDate", value);
                    registryKey3.Close();
                    //   frmRegisterOk frmRegisterOk = new frmRegisterOk();
                    //  frmRegisterOk.ShowDialog();
                    FrmMain.bRegistered = true;
                    FrmMain.bCheckValid = true;
                    base.Close();
                }
                else
                {
                    MessageBox.Show("Mã kích hoạt này không phù hợp.\nVui lòng liên hệ Công ty TNHH Giải Pháp Công Nghệ Chuyên Nghiệp Phát Triển để đăng ký bản quyền!", "Đăng ký thất bại", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    this.txtLicenseKey.Focus();
                    FrmMain.bRegistered = false;
                }
            }
        }


        public void Encrypt(byte[] ip_secret_buffer, byte[] ip_key_buffer)
        {
            for (int i = 0; i < ip_secret_buffer.Length; i++)
            {
                int expr_0D_cp_1 = i;
                ip_secret_buffer[expr_0D_cp_1] ^= ip_key_buffer[i];
            }
        }
        public void Decrypt(byte[] ip_secret_buffer, byte[] ip_key_buffer)
        {
            this.Encrypt(ip_secret_buffer, ip_key_buffer);
        }
        public string Encrypt(string ip_str_plaintext, string ip_str_key)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(ip_str_plaintext);
            byte[] bytes2 = Encoding.UTF8.GetBytes(ip_str_key);
            this.Encrypt(bytes, bytes2);
            return Encoding.UTF8.GetString(bytes);
        }
        private string GetEncrypt(string sNum1, string sNum2)
        {
            int[] array = new int[16];
            int[] array2 = array;
            string text = "";
            for (int i = 0; i < sNum2.Length; i++)
            {
                array2[i] = (int)((sNum1[i] ^ sNum2[i]) >> 4);
                text += array2[i].ToString("x");
            }
            return text;
        }
        private string GETEncrypt(string sNum1, string sNum2)
        {
            int[] array = new int[16];
            int[] array2 = array;
            string text = "";
            for (int i = 0; i < sNum2.Length; i++)
            {
                array2[i] = (int)(sNum1[i] ^ sNum2[i]);
                text += array2[i].ToString("x");
            }
            return text;
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            string text = string.Empty;
            ManagementClass managementClass = new ManagementClass("win32_processor");
            ManagementObjectCollection instances = managementClass.GetInstances();
            using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = instances.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    ManagementObject managementObject = (ManagementObject)enumerator.Current;
                    if (text == "")
                    {
                        text = managementObject.Properties["processorID"].Value.ToString();
                        break;
                    }
                }
            }
            this.sSetupID = this.GetEncrypt(this.GetEncrypt(text, "QMSCOUNTERSOFT01"), "10TFOSRETNUOCSMQ").ToUpper();
            this.txtSetupID.Text = this.sSetupID;
        }

        private void FrmRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!FrmMain.bCheckValid)
                Application.Exit();
        }

    }
}
