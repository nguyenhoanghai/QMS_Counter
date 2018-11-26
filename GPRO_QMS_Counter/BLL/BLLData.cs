using GPRO_QMS_Counter.Enums;
using GPRO_QMS_Counter.Models;
using QMS_System.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPRO_QMS_Counter.BLL
{
    public class BLLData
    {
        static QMSEntities db = null;

        #region constructor
        static Object key = new object();
        private static volatile BLLData _Instance;
        public static BLLData Instance
        {
            get
            {
                if (_Instance == null)
                    lock (key)
                        _Instance = new BLLData();

                return _Instance;
            }
        }

        private BLLData() { }
        #endregion

        public List<WaitingModel> GetViewAllWaitingList()
        {
            db = new QMSEntities();
            return db.ViewAllWaitingLists.Select(x => new WaitingModel() { StaffId = x.StaffId, DeskId = x.DeskId, WaitingList = x.WaitingList }).ToList();
        }

        public List<WaitingModel_N> GetViewAllWaitingList_N(int maquay)
        {
            db = new QMSEntities();
            if (maquay == 0)
                return db.XULYYCs.Select(x => new WaitingModel_N()
                {
                    MAPHIEU = x.MAPHIEU,
                    User = x.NHANVIEN.TENNV,
                    Quay = x.THIETBI.QUAY.TENQUAY,
                    GLAYPHIEU = x.GLAYPHIEU,
                    GDENQUAY = x.GDENQUAY
                }).ToList();
            else if (maquay > 0)
                return db.XULYYCs.Where(x => x.THIETBI.MAQUAY == maquay).Select(x => new WaitingModel_N()
                {
                    MAPHIEU = x.MAPHIEU,
                    User = x.NHANVIEN.TENNV,
                    Quay = x.THIETBI.QUAY.TENQUAY,
                    GLAYPHIEU = x.GLAYPHIEU,
                    GDENQUAY = x.GDENQUAY
                }).ToList();
            return null;
        }

        public List<QUAY> GetQuay(bool showall)
        {
            db = new QMSEntities();
            var list = new List<QUAY>();
            var objs = db.QUAYs.ToList();
            if (objs.Count > 0)
            {
                if (showall)
                    list.Add(new QUAY() { MAQUAY = 0, TENQUAY = "Chọn tất cả" });
                list.AddRange(objs);
            }
            else
                list.Add(new QUAY() { MAQUAY = -1, TENQUAY = "không có dữ liệu" });
            return list;
        }

        public bool ChangeStatusToDG(Login obj)
        {
            db = new QMSEntities();
            var xlYC = db.XULYYCs.FirstOrDefault(x => x.MANV == obj.iStaffId && x.MATB == obj.iCounterId && x.MATT == eStatus.Procesing);
            if (xlYC != null)
            {
                xlYC.MATT = eStatus.Rating;
                var yc = db.YEUCAUs.FirstOrDefault(x => x.MAPHIEU == xlYC.MAPHIEU);
                if (yc != null)
                    yc.MATT = eStatus.Rating;
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public Q_CallButtonNext FindButtonClick(Login obj)
        {
            db = new QMSEntities();
            var data = db.Q_CallButtonNext.FirstOrDefault(x => x.CounterId == obj.iCounterId && x.UserId == obj.iStaffId && x.IsClick);
            if (data != null)
            {
                data.IsClick = false;
                db.SaveChanges();
                return data;
            }
            else
                return null;
        }

        public bool CallNext(int num, Login login)
        {
            //db = new QMSEntities();
            //// var xlyc = db.XULYYCs.Where(x => x.MAPHIEU.Value.ToString() == num.ToString() && x.MATB == login.iCounterId && x.MATB == login.iStaffId).FirstOrDefault();
            //var xlyc = db.XULYYCs.Where(x => x.MAPHIEU.Value == num && x.MATB == login.iCounterId && x.MANV == login.iStaffId).FirstOrDefault();
            //if (xlyc != null)
            //{
            //    xlyc.GKETTHUC = DateTime.Now;
            //    xlyc.MATT = eStatus.Done;

            //    //var yc = db.YEUCAUs.FirstOrDefault(x => x.MAPHIEU == num);
            //    //yc.MATT = eStatus.Done;
            //    db.SaveChanges();
            //    return true;
            //}
            //return false;

            try
            {
                db = new QMSEntities();
                var xlycs = db.XULYYCs.Where(x => x.MATB == login.iCounterId && x.MANV == login.iStaffId && x.MAPHIEU == num).ToList();
                if (xlycs != null)
                {
                    bool done = false;
                    foreach (var item in xlycs)
                    {
                        item.GKETTHUC = DateTime.Now;
                        item.MATT = eStatus.Done;

                        if (!done)
                        {
                            var newObj = new Q_UserEvaluate();
                            newObj.UserId = item.MANV ?? 0;
                            newObj.TicketNumber = num;
                            newObj.Score = "0";
                            newObj.GLAYPHIEU = item.GLAYPHIEU;
                            newObj.GDENQUAY = item.GDENQUAY;
                            newObj.GGIAODICH = item.GGIAODICH;
                            newObj.GKETTHUC = item.GKETTHUC;
                            db.Q_UserEvaluate.Add(newObj);
                            done = true;
                        }
                    }
                    var yc = db.YEUCAUs.FirstOrDefault(x => x.MAPHIEU == num);
                    yc.MATT = eStatus.Done;
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
            } 
            return false;
        }

        public int CheckInfo(Login obj, int stt, int current)
        {
            db = new QMSEntities();
            int retun = 0;
            var now = DateTime.Now;
            var last = db.XULYYCs.OrderByDescending(x => x.STT).FirstOrDefault();
            if (last != null)
            {
                var counterSof = db.CounterSofts.FirstOrDefault(x => x.CounterSoftId == obj.iCounterId);
                if (counterSof != null)
                {
                    var currentXLYC = db.XULYYCs.FirstOrDefault(x => x.MANV == obj.iStaffId && x.MATB == obj.iCounterId && x.MATT == eStatus.Procesing && x.GLAYPHIEU.Value.Day == now.Day && x.GLAYPHIEU.Value.Month == now.Month && x.GLAYPHIEU.Value.Year == now.Year);
                    counterSof.Result = currentXLYC != null ? currentXLYC.MAPHIEU.Value.ToString() : "0";

                    //if ((last.STT > stt || current != Convert.ToInt32(counterSof.Result) || (currentXLYC != null && currentXLYC.MAPHIEU != current)))
                    //{
                    //    var NghiepVuIds = db.NV_NGHIEPVU.Where(x => x.MANV == obj.iStaffId).ToList().Select(x => Convert.ToInt32(x.MANVU)).ToList();
                    //    if (NghiepVuIds != null)
                    //    {
                    //        if (currentXLYC != null)


                    //        //var XLYCs = db.XULYYCs.Where(x => x.MANVU != null && NghiepVuIds.Contains(x.MANVU.Value) && x.MATT == eStatus.Waiting).ToList();

                    //        //counterSof.WaitingList = "";
                    //        //counterSof.GeneralWaitingList = "";
                    //        //if (XLYCs.Count > 0)
                    //        //    for (int i = 0; i < XLYCs.Count; i++)
                    //        //    {
                    //        //        counterSof.WaitingList += XLYCs[i].MAPHIEU.Value.ToString();
                    //        //        counterSof.GeneralWaitingList += XLYCs[i].MAPHIEU.Value.ToString();
                    //        //        if (i < (XLYCs.Count - 1))
                    //        //        {
                    //        //            counterSof.WaitingList += " ";
                    //        //            counterSof.GeneralWaitingList += " ";
                    //        //        }
                    //        //    }

                    //    }


                    //}
                    //else
                    //    counterSof.Result = "0";

                    var generals = db.XULYYCs.Where(x => x.MATT == eStatus.Waiting && x.GLAYPHIEU.Value.Day == now.Day && x.GLAYPHIEU.Value.Month == now.Month && x.GLAYPHIEU.Value.Year == now.Year).ToList();
                    if (generals.Count() > 0)
                    {
                        string gen = "", only = "";
                        XULYYC temp;
                        var NghiepVuIds = db.NV_NGHIEPVU.Where(x => x.MANV == obj.iStaffId).ToList().Select(x => Convert.ToInt32(x.MANVU)).ToList();

                        for (int i = 0; i < generals.Count; i++)
                        {
                            if (!gen.Contains(generals[i].MAPHIEU.ToString()))
                                gen += generals[i].MAPHIEU;

                            if (NghiepVuIds.Contains(generals[i].MANVU.Value) && !only.Contains(generals[i].MAPHIEU.ToString()))
                                only += generals[i].MAPHIEU;

                            if (i < generals.Count - 1)
                            {
                                gen += " ";
                                only += " ";
                            }
                        }
                        counterSof.GeneralWaitingList = gen;
                        counterSof.WaitingList = only;

                    }
                    else
                    {
                        counterSof.GeneralWaitingList = "0";
                        counterSof.WaitingList = "0";
                    }

                    counterSof.TotalDone = db.XULYYCs.Where(x => x.MATB != null && x.MANV != null && x.MATB.Value == obj.iCounterId && x.MANV.Value == obj.iStaffId && x.MATT == eStatus.Done && x.GLAYPHIEU.Value.Day == now.Day && x.GLAYPHIEU.Value.Month == now.Month && x.GLAYPHIEU.Value.Year == now.Year).Count();
                    counterSof.UpdateTime = DateTime.Now;
                    db.SaveChanges();
                }
                retun = (int)last.STT;
            }

            return retun;
        }

        public bool ChuyenQuay(QuayModel toQuay, int number, int matb, int manv)
        {
            try
            {
                db = new QMSEntities();
                var xlyc = db.XULYYCs.Where(x => x.MAPHIEU == number && (x.MATT == eStatus.Procesing || x.MATT == eStatus.Waiting));
                //if (xlyc != null)
                //{
                //    xlyc.MATT = eStatus.Done;
                //    xlyc.GKETTHUC = DateTime.Now;
                //}

                var nghiepvu = db.NV_NGHIEPVU.OrderBy(x => x.UUTIEN).FirstOrDefault(x => x.MANV == toQuay.MaNV);
                var newObj = new XULYYC();
                newObj.MAPHIEU = number;
                newObj.MANVU = nghiepvu.MANVU;
                newObj.MANVUT = nghiepvu.MANVU;
                //   newObj.GLAYPHIEU = xlyc.GLAYPHIEU;
                // newObj.GDENQUAY = xlyc.GDENQUAY;
                newObj.MATT = eStatus.Waiting;
                newObj.NB = 0;
                newObj.STT = (db.XULYYCs.Count() + 1);
                db.XULYYCs.Add(newObj);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
            }
            return false;
        }


        public List<QuayModel> GetQuayInfo()
        {
            db = new QMSEntities();
            var returnObjs = new List<QuayModel>();
            try
            {
                var objs = db.LOGONs.Where(x => x.MATT == eStatus.Login).Distinct().Select(x => new QuayModel()
                 {
                     MaQuay = x.THIETBI.MAQUAY ?? 0,
                     MaTB = x.MATB ?? 0,
                     MaNV = x.MANV ?? 0,
                     TenQuay = x.THIETBI.QUAY.TENQUAY
                 }).ToList();
                if (objs != null && objs.Count > 0)
                {
                    foreach (var item in objs)
                    {
                        if (returnObjs.FirstOrDefault(x => x.MaQuay == item.MaQuay) == null && !string.IsNullOrEmpty(item.TenQuay))
                            returnObjs.Add(item);
                    }
                }
            }
            catch (Exception)
            {
            }
            return returnObjs.OrderBy(x => x.MaQuay).ToList();
        }
    }


    public class QuayModel
    {
        public int MaQuay { get; set; }
        public int MaTB { get; set; }
        public int MaNV { get; set; }
        public string TenQuay { get; set; }
    }
}
