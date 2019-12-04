using GPRO_QMS_Counter.Models;
using QMS_System.Data.BLL;
using QMS_System.Data.Enum;
using QMS_System.Data.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace GPRO_QMS_Counter
{
    public partial class FrmPrintTicket : Form
    {
        string connectString;
        List<int> serviceIds;
        public FrmPrintTicket(string _connectString)
        {
            connectString = _connectString;
            InitializeComponent();
        }

        private void FrmPrintTicket_Load(object sender, EventArgs e)
        {
            try
            {
                  serviceIds = (!string.IsNullOrEmpty(ConfigurationManager.AppSettings["ServiceIds"].ToString()) ? ConfigurationManager.AppSettings["ServiceIds"].ToString() : "1,2,3,4,5,6").Split(',').Select(x => Convert.ToInt32(x)).ToList();  
                var serviceObjs = BLLService.Instance.GetLookUp(connectString, false);
                serviceObjs = serviceObjs.Where(x => serviceIds.Contains(x.Id)).ToList();
                if (serviceObjs.Count > 0)
                {
                    ServiceControl serviceControl;
                    ServiceControlModel model;
                    ModelSelectItem obj;
                    int x = 5, y = 5;
                    for (int i = 0; i < serviceObjs.Count; i += 3)
                    {
                        obj = serviceObjs[i];
                        model = new ServiceControlModel() { Id = obj.Id, Name = obj.Name, wait = 0, Time = (!string.IsNullOrEmpty(obj.Code) ? obj.Code : "00:00:00") };
                        serviceControl = new ServiceControl(model);
                        serviceControl.Location = new System.Drawing.Point(x, y);
                        serviceControl.Name = "ctr" + i;
                        serviceControl.printTicketEvent += new EventHandler<PrintTicketEventArgs>(PrintTicket);
                        panel1.Controls.Add(serviceControl);

                        try
                        {
                            obj = serviceObjs[i + 1];
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

                            obj = serviceObjs[i + 2];
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
                                var rs = BLLDailyRequire.Instance.PrintNewTicket(FrmMain2.connectString, e.Require.ServiceId, serObj.StartNumber, 0, now, FrmMain2.printType, e.Require.ServeTime.TimeOfDay, txtname.Text, txtAdd.Text, ((int)txtDOB.Value), txtma.Text, "", "", "");
                                if (rs.IsSuccess)
                                {
                                    lastTicket = (int)rs.Data;
                                    nghiepVu = rs.Data_1;
                                    newNumber = ((int)rs.Data + 1);
                                    tenquay = rs.Data_2;
                                }
                                else
                                    FrmMain2.errorsms = rs.Errors[0].Message;
                                //   MessageBox.Show(rs.Errors[0].Message, rs.Errors[0].MemberName, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                                var rs = BLLDailyRequire.Instance.PrintNewTicket(connectString, e.Require.ServiceId, FrmMain2.startNumber, 0, now, FrmMain2.printType, (e.Require.ServeTime != null ? e.Require.ServeTime.TimeOfDay : serObj.TimeProcess.TimeOfDay), txtname.Text, txtAdd.Text, (int)txtDOB.Value, txtma.Text, "", "", "");
                                if (rs.IsSuccess)
                                {
                                    lastTicket = (int)rs.Data;
                                    nghiepVu = rs.Data_1;
                                    newNumber = ((int)rs.Data + 1);
                                    tenquay = rs.Data_2;
                                }
                                else
                                    FrmMain2.errorsms = rs.Errors[0].Message;
                                //  MessageBox.Show(rs.Errors[0].Message, rs.Errors[0].MemberName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        #endregion
                        break;
                    case (int)ePrintType.TheoGioiHanSoPhieu:
                        #region MyRegion
                        //int slCP = BLLBusiness.Instance.GetTicketAllow(entityConnectString, businessId);
                        //int slDacap = BLLDailyRequire.Instance.CountTicket(entityConnectString, businessId);
                        //if (slDacap != null && slDacap == slCP)
                        //    FrmMain2.errorsms = ("Doanh nghiệp của bạn đã được cấp đủ số lượng phiếu giới hạn trong ngày. Xin quý khách vui lòng quay lại sau.");
                        ////  MessageBox.Show("Doanh nghiệp của bạn đã được cấp đủ số lượng phiếu giới hạn trong ngày. Xin quý khách vui lòng quay lại sau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //else
                        //{
                        //    lastTicket = BLLDailyRequire.Instance.GetLastTicketNumber(connectString, e.Require.ServiceId, today);
                        //    serObj = lib_Services.FirstOrDefault(x => x.Id == e.Require.ServiceId);
                        //    if (lastTicket == 0)
                        //    {
                        //        if (serObj != null)
                        //        {
                        //            err = true;
                        //            FrmMain2.errorsms = ("Dịch vụ không tồn tại. Xin quý khách vui lòng chọn dịch vụ khác.");
                        //            //  MessageBox.Show("Dịch vụ không tồn tại. Xin quý khách vui lòng chọn dịch vụ khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //        }
                        //        else
                        //            lastTicket = serObj.StartNumber;
                        //    }
                        //    else
                        //    {
                        //        lastTicket++;
                        //        if (serObj.EndNumber < lastTicket)
                        //        {
                        //            err = true;
                        //            FrmMain2.errorsms = ("Dịch vụ này đã cấp hết phiếu trong ngày. Xin quý khách vui lòng chọn dịch vụ khác.");
                        //            //  MessageBox.Show("Dịch vụ này đã cấp hết phiếu trong ngày. Xin quý khách vui lòng chọn dịch vụ khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //        }
                        //    }
                        //    if (!err)
                        //    {
                        //        var rs = BLLDailyRequire.Instance.Insert(connectString, lastTicket, e.Require.ServiceId, businessId, now);
                        //        if (rs.IsSuccess)
                        //        {
                        //            newNumber = rs.Data;
                        //            if (newNumber != 0 && !isProgrammer)
                        //            {
                        //                var soArr = BaseCore.Instance.ChangeNumber(lastTicket);
                        //                printStr = (soArr[0] + " " + soArr[1] + " ");
                        //                if (printTicketReturnCurrentNumberOrServiceCode == 1)
                        //                {
                        //                    soArr = BaseCore.Instance.ChangeNumber(BLLDailyRequire.Instance.GetCurrentNumber(connectString, serviceId));
                        //                }
                        //                else
                        //                {
                        //                    soArr = BaseCore.Instance.ChangeNumber(e.Require.ServiceId);
                        //                }

                        //                printStr += (soArr[0] + " " + soArr[1] + " " + now.ToString("dd") + " " + now.ToString("MM") + " " + now.ToString("yy") + " " + now.ToString("HH") + " " + now.ToString("mm"));
                        //            }
                        //            else if (newNumber != 0 && isProgrammer)
                        //                lbRecieve.Caption = e.Require.ServiceId + "," + "1," + lastTicket;
                        //            nghiepVu = rs.Data_1;
                        //        }
                        //    }
                        //}
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
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    FrmMain2.printSerialCOM.Write(arr[i]);
                }
            }
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
                serviceObjs = serviceObjs.Where(x => serviceIds.Contains(x.Id)).ToList();
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
