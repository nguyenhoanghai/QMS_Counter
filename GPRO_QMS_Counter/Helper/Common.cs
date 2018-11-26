using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPRO_QMS_Counter.Helper
{
    public class Common
    {
        #region constructor
        static Object key = new object();
        private static volatile Common _Instance;
        public static Common Instance
        {
            get
            {
                if (_Instance == null)
                    lock (key)
                        _Instance = new Common();

                return _Instance;
            }
        }

        private Common() { }
        #endregion
        public int GetCounterId() { return int.Parse(ConfigurationManager.AppSettings["CounterId"].ToString()); }
        public bool GetactCallNext() { return bool.Parse(ConfigurationManager.AppSettings["actCallNext"].ToString()); }
        public bool GetactRecall() { return bool.Parse(ConfigurationManager.AppSettings["actRecall"].ToString()); }
        public bool GetactFinish() { return bool.Parse(ConfigurationManager.AppSettings["actFinish"].ToString()); }
        public bool GetactCancel() { return bool.Parse(ConfigurationManager.AppSettings["actCancel"].ToString()); }
        public bool GetactCallTicket() { return bool.Parse(ConfigurationManager.AppSettings["actCallTicket"].ToString()); }
        public bool GetactPass() { return bool.Parse(ConfigurationManager.AppSettings["actPass"].ToString()); }
        public bool GetactSave() { return bool.Parse(ConfigurationManager.AppSettings["actSave"].ToString()); }
        public bool GetactView() { return bool.Parse(ConfigurationManager.AppSettings["actView"].ToString()); }
        public bool GetactHelp() { return bool.Parse(ConfigurationManager.AppSettings["actHelp"].ToString()); }
        public bool GetactLogout() { return bool.Parse(ConfigurationManager.AppSettings["actLogout"].ToString()); }
        public string GetsoundString() { return ConfigurationManager.AppSettings["soundString"].ToString(); }
        public string GetsoundFolder() { return (ConfigurationManager.AppSettings["soundFolder"].ToString() + "\\"); }
        public string GetsoundNumber() { return ConfigurationManager.AppSettings["soundNumber"].ToString(); }
        public string GetsoundNumberName() { return ConfigurationManager.AppSettings["soundNumberName"].ToString(); }
        public string GetimageFolder() { return ConfigurationManager.AppSettings["imageFolder"].ToString(); }
        public string GetexcelFolder() { return ConfigurationManager.AppSettings["excelFolder"].ToString(); }
        public bool IsUseMainDisplay() { return bool.Parse(ConfigurationManager.AppSettings["IsUseMainDisplay"].ToString()); }
        public bool IsReadSound() { return bool.Parse(ConfigurationManager.AppSettings["IsReadSound"].ToString()); }
        public bool GetactPrintTicket() { return bool.Parse(ConfigurationManager.AppSettings["actPrintTicket"].ToString()); }
        public string ComName() { return ConfigurationManager.AppSettings["COMPort"].ToString(); }
        public int BaudRate() { return int.Parse(ConfigurationManager.AppSettings["BaudRate"].ToString()); }
        public int PrinterId() { return int.Parse(ConfigurationManager.AppSettings["PrinterId"].ToString()); }
        public int DataBits() { return int.Parse(ConfigurationManager.AppSettings["DataBits"].ToString()); }
        public Parity Parity() { return (Parity)Enum.Parse(typeof(Parity), ConfigurationManager.AppSettings["Parity"].ToString()); }
        public StopBits StopBits() { return (StopBits)Enum.Parse(typeof(StopBits), ConfigurationManager.AppSettings["StopBits"].ToString()); }
    }
}
