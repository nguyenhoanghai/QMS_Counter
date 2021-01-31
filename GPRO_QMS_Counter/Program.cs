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
            try
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
                        case "4": // goi so + in phieu 
                                  //Application.Run(new FrmMain4());
                            Application.Run(new Form1());
                            break;
                        case "5": //goi so co uu tien
                            Application.Run(new FrmMainPhongKham()); break;
                        case "6": //BV Hữu nghị
                            Application.Run(new FrmPhongKhamHuuNghi()); break;
                        case "7": //BV RHM
                            Application.Run(new FrmMainRHM()); break;
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
            catch (Exception ex)
            {
            }

        }
    }
}
