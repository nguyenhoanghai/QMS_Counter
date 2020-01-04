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
            {
                string apptype = (ConfigurationManager.AppSettings["AppType"] != null &&
                    !string.IsNullOrEmpty(ConfigurationManager.AppSettings["AppType"].ToString()) ?
                    ConfigurationManager.AppSettings["AppType"].ToString() : "1");
                switch (apptype)
                {
                    case "2": Application.Run(new FrmMain2()); break;
                    case "4": Application.Run(new FrmMain4()); break;
                    default: Application.Run(new FrmMain()); break;
                }
            }
            else
                Application.Run(new FrmSQLConnect());

            Process[] processe;
            processe = Process.GetProcessesByName("GPRO_QMS_Counter");
            foreach (Process dovi in processe)
                dovi.Kill();
        }
    }
}
