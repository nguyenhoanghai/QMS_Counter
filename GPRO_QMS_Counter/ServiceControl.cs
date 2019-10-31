using GPRO_QMS_Counter.Models;
using QMS_System.Data.Model;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GPRO_QMS_Counter
{
    internal interface IServiceControl
    {
       void updateWaiting(int wait);
    }
    public partial class ServiceControl : UserControl,IServiceControl
    {
        ServiceControlModel serviceControlModel;
        public event EventHandler<PrintTicketEventArgs> printTicketEvent;
        public ServiceControl(ServiceControlModel _serviceControlModel)
        {
            serviceControlModel = _serviceControlModel;
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (printTicketEvent != null)
            {
                printTicketEvent(sender, new PrintTicketEventArgs(new PrinterRequireModel()
                {
                    ServiceId = serviceControlModel.Id,
                    ServeTime = dpkTime.Value
                }));
            }
            // MessageBox.Show("print ticket " + Id);
        }

        private void ServiceControl_Load(object sender, EventArgs e)
        {
            var timeArr = serviceControlModel.Time.Split(':').Select(x => Convert.ToInt32(x)).ToArray();
            if (timeArr.Length == 3)
            {
                var now = DateTime.Now;
                var date = new DateTime(now.Year, now.Month, now.Day, timeArr[0], timeArr[1], timeArr[2]);
                dpkTime.Value = date;
            }
            lbName.Text = serviceControlModel.Name;
            lbcho.Text = serviceControlModel.wait.ToString();
        }

        public void updateWaiting(int wait)
        {
            lbcho.Text = wait.ToString();
        }
    }

    public class PrintTicketEventArgs : EventArgs
    {
        private PrinterRequireModel _require;
        public PrinterRequireModel Require { get { return _require; } }
        public PrintTicketEventArgs(PrinterRequireModel require) : base()
        {
            _require = require;
        }
    }
}
