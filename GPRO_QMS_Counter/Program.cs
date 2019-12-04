using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace GPRO_QMS_Counter
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (File.Exists(Application.StartupPath + "\\DATA.XML"))
                if (ConfigurationManager.AppSettings["AppType"] != null &&
                    ConfigurationManager.AppSettings["AppType"].ToString() == "2")
                    Application.Run(new FrmMain2());
                else
                    Application.Run(new FrmMain());
            else
                Application.Run(new FrmSQLConnect());

            Process[] processe;
            processe = Process.GetProcessesByName("GPRO_QMS_Counter");
            foreach (Process dovi in processe)
                dovi.Kill();
        }
    }
}
