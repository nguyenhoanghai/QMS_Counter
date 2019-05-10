using GPRO_QMS_Counter.Properties;
using System;
using System.Configuration;
using System.IO.Ports;
using System.Windows.Forms;
using System.Xml;

namespace GPRO_QMS_Counter
{
    public partial class FrmConfig : Form
    {
        bool hasChange = false;
        public FrmConfig()
        {
            InitializeComponent();
        }

        private void FrmConfig_Load(object sender, EventArgs e)
        {
            toggleSwitch1_Toggled(sender, e);
            toggleSwitch1.IsOn = Settings.Default.IsUseMainDisplay;
            cbComPort.Items.Clear();
            cbComPort.Items.AddRange(SerialPort.GetPortNames());
            cbComPort.Text = FrmMain.sComPort;
            cbBaudRate.Text = FrmMain.iBaudRate.ToString();
            cbDataBits.Text = FrmMain.iDataBits.ToString();
            cbParity.Text = FrmMain.sParity.ToString();
            cbStopBits.Text = FrmMain.fStopBits.ToString();
            txtSoundPath.Text = FrmMain.soundPath;
            switchReadSound.IsOn = Settings.Default.IsReadSound;
            numPrinterId.Value = FrmMain.printerId;
            numCounterId.Value = int.Parse(ConfigurationManager.AppSettings["CounterId"].ToString());


            swNext.IsOn = Settings.Default.actCallNext;
            swRecall.IsOn = Settings.Default.actRecall;
            swFinish.IsOn = Settings.Default.actFinish;
            swCancel.IsOn = Settings.Default.actCancel;
            swCallAny.IsOn = Settings.Default.actCallTicket;
            swStranfer.IsOn = Settings.Default.actPass;
            swSave.IsOn = Settings.Default.actSave;
            swView.IsOn = Settings.Default.actView;
            swPrint.IsOn = Settings.Default.actPrintTicket;
            swUpdateInfo.IsOn = Settings.Default.actUpdateInfo;
            swEvaluate.IsOn = Settings.Default.actEvaluate;
            swSmallScreen.IsOn = Settings.Default.actSmallScreen;
        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch1.IsOn)
                pnCOMSetting.Enabled = true;
            else
                pnCOMSetting.Enabled = false;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                txtSoundPath.Text = folderBrowserDialog1.SelectedPath;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Thông tin cấu hình sẽ được lưu lại và Chương trình sẽ khởi động lại. Bạn có chắc muốn lưu lại thông tin cấu hình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Settings.Default.IsUseMainDisplay = toggleSwitch1.IsOn;
                Settings.Default.IsReadSound = switchReadSound.IsOn;
                Settings.Default.COMPort = cbComPort.Text;
                Settings.Default.BaudRate = Convert.ToInt32(cbBaudRate.Text);
                Settings.Default.DataBits = Convert.ToInt32(cbDataBits.Text);
                switch (cbParity.Text)
                {
                    case "None": Settings.Default.Parity = Parity.None; break;
                    case "Even": Settings.Default.Parity = Parity.Even; break;
                    case "Mark": Settings.Default.Parity = Parity.Mark; break;
                    case "Odd": Settings.Default.Parity = Parity.Odd; break;
                    case "Space": Settings.Default.Parity = Parity.Space; break;
                }

                switch (cbStopBits.Text)
                {
                    case "None": Settings.Default.StopBits = StopBits.None; break;
                    case "One": Settings.Default.StopBits = StopBits.One; break;
                    case "OnePointFive": Settings.Default.StopBits = StopBits.OnePointFive; break;
                    case "Two": Settings.Default.StopBits = StopBits.Two; break;
                }
                Settings.Default.soundFolder = txtSoundPath.Text;
                Settings.Default.PrinterId = (int)numPrinterId.Value;
                //  Settings.Default.CounterId = (int)numCounterId.Value;
                Settings.Default.Save();
                hasChange= true;

                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
                foreach (XmlElement element in xmlDoc.DocumentElement)
                {
                    if (element.Name.Equals("appSettings"))
                    {
                        foreach (XmlNode node in element.ChildNodes)
                        {
                            if (node.Attributes[0].Value.Equals("CounterId"))
                            {
                                node.Attributes[1].Value = numCounterId.Value.ToString();
                            }
                        }
                    }
                }

                xmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
                ConfigurationManager.RefreshSection("appSettings");

                this.Close();
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSavePer_Click(object sender, EventArgs e)
        {
            Settings.Default.actCallNext = swNext.IsOn;
            Settings.Default.actRecall = swRecall.IsOn;
            Settings.Default.actFinish = swFinish.IsOn;
            Settings.Default.actCancel = swCancel.IsOn;
            Settings.Default.actCallTicket = swCallAny.IsOn;
            Settings.Default.actPass = swStranfer.IsOn;
            Settings.Default.actSave = swSave.IsOn;
            Settings.Default.actView = swView.IsOn;
            Settings.Default.actPrintTicket = swPrint.IsOn;
            Settings.Default.actUpdateInfo = swUpdateInfo.IsOn;
            Settings.Default.actEvaluate = swEvaluate.IsOn;
            Settings.Default.actSmallScreen = swSmallScreen.IsOn;
            Settings.Default.Save();
            hasChange = true;
            this.Close();
        }

        private void FrmConfig_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(hasChange)
                FrmMain.isRestart = true;
        }
    }
}
