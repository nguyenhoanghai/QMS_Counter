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
            cbComPort.Items.Clear();
            cbComPort.Items.AddRange(SerialPort.GetPortNames()); 
            cbBaudRate.Text = FrmMain.iBaudRate.ToString();
            cbDataBits.Text = FrmMain.iDataBits.ToString();
            cbParity.Text = FrmMain.sParity.ToString();
            cbStopBits.Text = FrmMain.fStopBits.ToString();  

            printCOM_cb.Items.Clear();
            printCOM_cb.Items.AddRange(SerialPort.GetPortNames()); 

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
                                case "CounterId": numCounterId.Value = (!string.IsNullOrEmpty(node.InnerText) ? Convert.ToInt32(node.InnerText) : 1); break;
                                case "Display": toggleSwitch1.IsOn = Convert.ToBoolean(node.InnerText); break;
                                case "COMDisplay": cbComPort.Text = node.InnerText; break;
                                case "Print": switchPrinter.IsOn = Convert.ToBoolean(node.InnerText); break;
                                case "COMPrint": printCOM_cb.Text = node.InnerText; break;
                                case "PrintCode": numPrinterId.Value = (!string.IsNullOrEmpty(node.InnerText) ? Convert.ToInt32(node.InnerText) : 1); ; break;
                                case "ReadSound": switchReadSound.IsOn = Convert.ToBoolean(node.InnerText); break;
                                case "SoundPath": txtSoundPath.Text = node.InnerText; break;
                            }
                        }
                        catch (Exception ex)
                        {
                        }
                    }
                }
            }
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
                                    case "CounterId": node.InnerText = numCounterId.Value.ToString(); break;
                                    case "Display": node.InnerText = toggleSwitch1.IsOn.ToString(); break;
                                    case "COMDisplay": node.InnerText = cbComPort.Text.ToString(); break;
                                    case "Print": node.InnerText = switchPrinter.IsOn.ToString(); break;
                                    case "COMPrint": node.InnerText = printCOM_cb.Text.ToString(); break;
                                    case "PrintCode": node.InnerText = numPrinterId.Value.ToString(); break;
                                    case "ReadSound": node.InnerText = switchReadSound.IsOn.ToString(); break;
                                    case "SoundPath": node.InnerText = txtSoundPath.Text.ToString(); break;
                                }
                            }
                            catch (Exception ex)
                            {
                            }
                        }
                    }
                }
                xmlDoc.Save(Application.StartupPath + "\\DATA.XML");
                ConfigurationManager.RefreshSection("appSettings");
                Application.Restart();
                Environment.Exit(0);
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
            if (hasChange)
                FrmMain.isRestart = true;
        }

        private void cbComPort_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
