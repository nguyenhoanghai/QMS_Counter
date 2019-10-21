using GPRO.Core.Hai;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
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
            if( BaseCore.Instance.CONNECT_STATUS(Application.StartupPath + "\\DATA.XML"))
            Application.Run(new FrmMain());
            else
            {
                Application.Run(new FrmSQLConnect());
            }
            Process[] processe;
            processe = Process.GetProcessesByName("GPRO_QMS_Counter");
            foreach (Process dovi in processe)
                dovi.Kill();
        }
    }
}
