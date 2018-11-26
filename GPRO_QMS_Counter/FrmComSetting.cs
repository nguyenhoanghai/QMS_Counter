using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPRO_QMS_Counter
{
    public partial class FrmComSetting : Form
    {
        public static bool bChangeCOMPort = false;
        public FrmComSetting()
        {
            InitializeComponent();
        }

        private void ckUseCounterDisplay_CheckedChanged(object sender, EventArgs e)
        {
            pnCOMSetting.Enabled = this.ckUseCounterDisplay.Checked;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            FrmMain.IsUseMainDisplay = this.ckUseCounterDisplay.Checked;
            FrmMain.sComPort = this.cbComPort.Text.ToString();
            FrmMain.iBaudRate = int.Parse(this.cbBaudRate.Text.ToString());
            FrmMain.iDataBits = byte.Parse(this.cbDataBits.Text.ToString());
            FrmMain.sParity = (Parity)Enum.Parse(typeof(Parity), this.cbParity.Text.ToString());
            FrmMain.fStopBits = (StopBits)Enum.Parse(typeof(StopBits), this.cbStopBits.Text.ToString());
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings["UseCounterDisplay"].Value = FrmMain.IsUseMainDisplay.ToString();
            configuration.AppSettings.Settings["COMPort"].Value = FrmMain.sComPort;
            configuration.AppSettings.Settings["BaudRate"].Value = FrmMain.iBaudRate.ToString();
            configuration.AppSettings.Settings["DataBits"].Value = FrmMain.iDataBits.ToString();
            configuration.AppSettings.Settings["Parity"].Value = FrmMain.sParity.ToString();
            configuration.AppSettings.Settings["StopBits"].Value = FrmMain.fStopBits.ToString();
            configuration.Save(ConfigurationSaveMode.Modified);
            FrmComSetting.bChangeCOMPort = true;
            Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {

        }

        private void FrmComSetting_Load(object sender, EventArgs e)
        {
            this.cbComPort.Items.Clear();
            this.cbComPort.Items.AddRange(SerialPort.GetPortNames());
            this.ckUseCounterDisplay.Checked = (this.pnCOMSetting.Enabled = FrmMain.IsUseMainDisplay);
            this.cbComPort.Text = FrmMain.sComPort;
            this.cbBaudRate.Text = FrmMain.iBaudRate.ToString();
            this.cbDataBits.Text = FrmMain.iDataBits.ToString();
            this.cbParity.Text = FrmMain.sParity.ToString();
            this.cbStopBits.Text = FrmMain.fStopBits.ToString();
            FrmComSetting.bChangeCOMPort = false;
        }
    }
}
