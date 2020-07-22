using GPRO_QMS_Counter.Models;
using QMS_System.Data.BLL;
using QMS_System.Data.Enum;
using QMS_System.Data.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GPRO_QMS_Counter
{
    public partial class FrmPrintTicket : Form
    {
        string connectString;

        public FrmPrintTicket(string _connectString)
        {
            connectString = _connectString;
            InitializeComponent();
        }

        private void FrmPrintTicket_Load(object sender, EventArgs e)
        {
            try
            {
                if (FrmMain2.serviceObjs.Count > 0)
                {
                    ServiceControl serviceControl;
                    ServiceControlModel model;
                    ModelSelectItem obj;
                    int x = 5, y = 5;
                    for (int i = 0; i < FrmMain2.serviceObjs.Count; i += 3)
                    {
                        obj = FrmMain2.serviceObjs[i];
                        model = new ServiceControlModel() { Id = obj.Id, Name = obj.Name, wait = 0, Time = (!string.IsNullOrEmpty(obj.Code) ? obj.Code : "00:00:00") };
                        serviceControl = new ServiceControl(model);
                        serviceControl.Location = new System.Drawing.Point(x, y);
                        serviceControl.Name = "ctr" + i;
                        serviceControl.printTicketEvent += new EventHandler<PrintTicketEventArgs>(PrintTicket);
                        panel1.Controls.Add(serviceControl);

                        try
                        {
                            obj = FrmMain2.serviceObjs[i + 1];
                            if (obj != null)
                            {
                                x += 280;
                                model = new ServiceControlModel() { Id = obj.Id, Name = obj.Name, wait = 0, Time = (!string.IsNullOrEmpty(obj.Code) ? obj.Code : "00:00:00") };
                                serviceControl = new ServiceControl(model);
                                serviceControl.Location = new System.Drawing.Point(x, y);
                                serviceControl.Name = "ctr" + (i + 1);
                                serviceControl.printTicketEvent += new EventHandler<PrintTicketEventArgs>(PrintTicket);
                                panel1.Controls.Add(serviceControl);
                            }

                            obj = FrmMain2.serviceObjs[i + 2];
                            if (obj != null)
                            {
                                x += 280;
                                model = new ServiceControlModel() { Id = obj.Id, Name = obj.Name, wait = 0, Time = (!string.IsNullOrEmpty(obj.Code) ? obj.Code : "00:00:00") };
                                serviceControl = new ServiceControl(model);
                                serviceControl.Location = new System.Drawing.Point(x, y);
                                serviceControl.Name = "ctr" + (i + 2);
                                serviceControl.printTicketEvent += new EventHandler<PrintTicketEventArgs>(PrintTicket);
                                panel1.Controls.Add(serviceControl);

                                y += 75;
                                x = 5;
                            }
                        }
                        catch (Exception)
                        { }
                    }
                }
            }
            catch (Exception)
            {
            }

        }

        private void PrintTicket(object sender, PrintTicketEventArgs e)
        {
            try
            {
                int lastTicket = 0,
                                newNumber = -1,
                            nghiepVu = 0;
                string printStr = string.Empty,
                    tenquay = string.Empty;
                bool err = false;
                ServiceDayModel serObj = null;
                DateTime now = DateTime.Now;
                switch (FrmMain2.printType)
                {
                    case (int)ePrintType.TheoTungDichVu:
                        #region
                        serObj = FrmMain2.lib_Services.FirstOrDefault(x => x.Id == e.Require.ServiceId);
                        if (serObj == null)
                            FrmMain2.errorsms = "Dịch vụ số " + e.Require.ServiceId + " không tồn tại. Xin quý khách vui lòng chọn dịch vụ khác.";
                        else
                        {
                            if (FrmMain2.CheckTimeBeforePrintTicket == 1 && serObj.Shifts.FirstOrDefault(x => now.TimeOfDay >= x.Start.TimeOfDay && now.TimeOfDay <= x.End.TimeOfDay) == null)
                                // temp.Add(SoundLockPrintTicket);
                                FrmMain2.errorsms = "Dịch vụ số " + e.Require.ServiceId + " đã ngưng cấp số. Xin quý khách vui lòng đến vào buổi giao dịch sau.";
                            else
                            {
                                var rs = BLLDailyRequire.Instance.PrintNewTicket(FrmMain2.connectString, e.Require.ServiceId, serObj.StartNumber, 0, now, FrmMain2.printType, e.Require.ServeTime.TimeOfDay, txtname.Text, txtAdd.Text, ((int)txtDOB.Value), txtma.Text, "", "", "", "", "");
                                if (rs.IsSuccess)
                                {
                                    lastTicket = (int)rs.Data;
                                    nghiepVu = rs.Data_1;
                                    newNumber = ((int)rs.Data + 1);
                                    tenquay = rs.Data_2;
                                }
                                else
                                    FrmMain2.errorsms = rs.Errors[0].Message;
                            }
                        }
                        #endregion
                        break;
                    case (int)ePrintType.BatDauChung:
                        #region MyRegion
                        serObj = FrmMain2.lib_Services.FirstOrDefault(x => x.Id == e.Require.ServiceId);
                        if (serObj == null)
                            FrmMain2.errorsms = "Dịch vụ số " + e.Require.ServiceId + " không tồn tại. Xin quý khách vui lòng chọn dịch vụ khác.";
                        else
                        {
                            if (FrmMain2.CheckTimeBeforePrintTicket == 1 && serObj.Shifts.FirstOrDefault(x => now.TimeOfDay >= x.Start.TimeOfDay && now.TimeOfDay <= x.End.TimeOfDay) == null)
                                //temp.Add(FrmMain2.SoundLockPrintTicket);
                                FrmMain2.errorsms = "Dịch vụ số " + e.Require.ServiceId + " đã ngưng cấp số. Xin quý khách vui lòng đến vào buổi giao dịch sau.";
                            else
                            {
                                var rs = BLLDailyRequire.Instance.PrintNewTicket(connectString, e.Require.ServiceId, FrmMain2.startNumber, 0, now, FrmMain2.printType, (e.Require.ServeTime != null ? e.Require.ServeTime.TimeOfDay : serObj.TimeProcess.TimeOfDay), txtname.Text, txtAdd.Text, (int)txtDOB.Value, txtma.Text, "", "", "", "", "");
                                if (rs.IsSuccess)
                                {
                                    lastTicket = (int)rs.Data;
                                    nghiepVu = rs.Data_1;
                                    newNumber = ((int)rs.Data + 1);
                                    tenquay = rs.Data_2;
                                }
                                else
                                    FrmMain2.errorsms = rs.Errors[0].Message;
                            }
                        }
                        #endregion
                        break;
                    case (int)ePrintType.TheoGioiHanSoPhieu:
                        #region MyRegion

                        #endregion
                        break;
                }

                if (newNumber >= 0)
                {
                    FrmMain2.errorsms = printStr.ToString();
                    // dataSendToComport.Add(printStr);
                    Print(newNumber, lastTicket, tenquay, serObj.Name);
                }
            }
            catch (Exception)
            {
            }
        }

        private void Print(int newNum, int oldNum, string tenquay, string tendichvu)
        {
            var template = FrmMain2.ticketTemplate;
            var now = DateTime.Now;
            template = template.Replace("[canh-giua]", "\x1b\x61\x01|+|");
            template = template.Replace("[canh-trai]", "\x1b\x61\x00|+|");
            template = template.Replace("[1x1]", "\x1d\x21\x00|+|");
            template = template.Replace("[2x1]", "\x1d\x21\x01|+|");
            template = template.Replace("[3x1]", "\x1d\x21\x02|+|");
            template = template.Replace("[2x2]", "\x1d\x21\x11|+|");
            template = template.Replace("[3x3]", "\x1d\x21\x22|+|");

            template = template.Replace("[STT]", newNum.ToString());
            template = template.Replace("[ten-quay]", tenquay);
            template = template.Replace("[ten-dich-vu]", tendichvu);
            template = template.Replace("[ngay]", ("ngay: " + now.ToString("dd/MM/yyyy")));
            template = template.Replace("[gio]", (" gio: " + now.ToString("HH/mm")));
            template = template.Replace("[dang-goi]", " dang goi " + oldNum);
            template = template.Replace("[cat-giay]", "\x1b\x69|+|");

            var arr = template.Split(new string[] { "|+|" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            for (int ii = 0; ii < FrmMain2.so_lien; ii++)
                for (int i = 0; i < arr.Length; i++)
                    FrmMain2.printSerialCOM.Write(arr[i]);

            UpdateServiceInfo();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateServiceInfo();
        }

        private void UpdateServiceInfo()
        {
            try
            {
                int i = 0;
                var serviceObjs = BLLService.Instance.GetLookUp(connectString, true);
                serviceObjs = serviceObjs.Where(x => FrmMain2.serviceIds.Contains(x.Id)).ToList();
                foreach (Control c in panel1.Controls)
                {
                    ((IServiceControl)c).updateWaiting(serviceObjs[i].Data);
                    i++;
                }
                //Thread.Sleep(1000);
            }
            catch (Exception)
            {
            }
        }
    }
}
