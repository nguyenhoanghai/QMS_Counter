using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPRO_QMS_Counter.Models
{
   public class Login
    {
        public string strUsername { get; set; }
        public string strPassword { get; set; }
        public int iDeskId { get; set; }
        public int iCounterId { get; set; }
        public int iStaffId { get; set; }
        public string strStaffName { get; set; }
        public string LoginTime { get; set; } 
    }
}
