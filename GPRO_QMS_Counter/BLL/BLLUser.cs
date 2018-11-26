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
    public class BLLUser
    {
        static QMSEntities db = null;

        #region constructor
        static Object key = new object();
        private static volatile BLLUser _Instance;
        public static BLLUser Instance
        {
            get
            {
                if (_Instance == null)
                    lock (key)
                        _Instance = new BLLUser();

                return _Instance;
            }
        }

        private BLLUser() { }
        #endregion

        #region method
        public Login FindUser(string sUsername, string sPassword)
        {
            db = new QMSEntities();
            Login login = null;
            var obj = db.NHANVIENs.FirstOrDefault(x => x.USERNAME.Equals(sUsername) && x.PASSWORD.Equals(sPassword));
            if (obj != null)
            {
                login = new Login();
                login.strUsername = sUsername;
                login.strPassword = sPassword;
                login.iStaffId = int.Parse(obj.MANV.ToString());
                login.strStaffName = obj.TENNV.ToString();
            }
            return login;
        }

        public NHANVIEN FindUser(int userId)
        {
            db = new QMSEntities();
            return db.NHANVIENs.FirstOrDefault(x => x.MANV == userId);
        }

        public bool SaveUser(NHANVIEN obj, bool changImg)
        {
            db = new QMSEntities();
            var old = db.NHANVIENs.FirstOrDefault(x => x.MANV == obj.MANV);
            if (old != null)
            {
                old.TENNV = obj.TENNV;
                old.ChuyenMon = obj.ChuyenMon;
                old.ChucVu = obj.ChucVu;
                old.GIOITINH = obj.GIOITINH;
                old.DIACHI = obj.DIACHI;
                old.QTCongTac = obj.QTCongTac;
                if (changImg)
                    old.Hinh = obj.Hinh;
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public int GetCurrentDesk(int iCounterId)
        {
            db = new QMSEntities();
            var obj = db.THIETBIs.FirstOrDefault(x => x.MATB == iCounterId && x.MALTB == 6);
            if (obj != null)
                return int.Parse(obj.MAQUAY.ToString());
            return 0;
        }

        public void WriteLogin(int iCounterId, int iStaffId, DateTime dLoginTime)
        {
            db = new QMSEntities();
            var obj = new LOGON();
            obj.MATB = (Int16)iCounterId;
            obj.MANV = (Int16)iStaffId;
            obj.NGAY = dLoginTime;
            obj.GIO = dLoginTime;
            obj.MATT = eStatus.Login;
            db.LOGONs.Add(obj);
            db.SaveChanges();
            WriteRequired(iCounterId, "LOGIN", "0", DateTime.Now);
        }

        public void WriteRequired(int iCounterId, string sRequired, string sRequiredParam, DateTime dUpdateTime)
        {
            db = new QMSEntities();
            CounterSoft counter = db.CounterSofts.FirstOrDefault(x => x.CounterSoftId == iCounterId);
            if (counter != null)
            {
                counter.Required = sRequired;
                counter.RequiredParam = sRequiredParam;
                counter.Status = 1;
                counter.UpdateTime = dUpdateTime;
            }
            else
            {
                counter = new CounterSoft();
                counter.Required = sRequired;
                counter.RequiredParam = sRequiredParam;
                counter.Status = 1;
                counter.UpdateTime = dUpdateTime;
                counter.CounterSoftId = (Int16)iCounterId;
                db.CounterSofts.Add(counter);
            }
            db.SaveChanges();
        }

        public void CheckRequiredDayPass()
        {
            db = new QMSEntities();
            var now = DateTime.Now;
            var objs = db.CounterSofts.Where(x => x.Status != 0 && x.UpdateTime.Value.Year != now.Year && x.UpdateTime.Value.Month != now.Month && x.UpdateTime.Value.Day != now.Day);
            if (objs != null && objs.Count() > 0)
            {
                foreach (var item in objs)
                {
                    item.Status = 0;
                }
                db.SaveChanges();
            }
        }

        public bool WriteLogout(int iCounterId, int iStaffId, DateTime dLoginTime)
        {
            try
            {
                db = new QMSEntities();
                var obj = db.LOGONs.FirstOrDefault(x => x.MATB == iCounterId && x.MANV == iStaffId && x.MATT == eStatus.Login);
                if (obj != null)
                {
                    obj.MATT = eStatus.LogOut;
                    obj.LOGOUTTIME = dLoginTime;
                    db.SaveChanges();
                    WriteRequired(iCounterId, "LOGOU", "0", dLoginTime);
                    return true;
                }
            }
            catch (Exception)
            { }
            return false;
        }

        public CounterSoft ReadResult(int iCounterId)
        {
            db = new QMSEntities();
            return db.CounterSofts.FirstOrDefault(x => x.CounterSoftId == iCounterId  );
        }

        public void WriteFinishStatus(int iCounterId, bool isViewList)
        {
            db = new QMSEntities();
            var obj = db.CounterSofts.FirstOrDefault(x => x.CounterSoftId == iCounterId);
            if (obj != null)
            {
                obj.Status = 0;
                if (isViewList)
                    obj.Required = "";
                db.SaveChanges();
            }
        }

        public List<NHANVIEN> Get()
        {
            var list = new List<NHANVIEN>();
            var objs = db.NHANVIENs.ToList();
            if (objs != null && objs.Count > 0)
            {
                list.Add(new NHANVIEN() { MANV = 0, TENNV = "chọn tất cả" });
                list.AddRange(objs);
            }
            else
                list.Add(new NHANVIEN() { MANV = -1, TENNV = "Không có dữ liệu" });
            return list;
        }

        public void CheckLogin(int iCounterId, int iStaffId)
        {
            try
            {
                db = new QMSEntities();
                var objs = db.LOGONs.Where(x => x.MANV == iStaffId && x.MATT == eStatus.Login);
                if (objs.Count() > 0)
                {
                    foreach (var item in objs)
                    {
                        item.MATT = eStatus.LogOut;
                        item.LOGOUTTIME = DateTime.Now;
                      
                       // WriteRequired(item.MATB ?? 0, "LOGOU", "0", DateTime.Now);
                    } 
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
            }
            
        }

        #endregion
    }
}
