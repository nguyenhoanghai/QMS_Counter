using GPRO_QMS_Counter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPRO_QMS_Counter.BLL
{
    public class BLLBookService
    {
        static QMSEntities db = null;

        #region constructor
        static Object key = new object();
        private static volatile BLLBookService _Instance;
        public static BLLBookService Instance
        {
            get
            {
                if (_Instance == null)
                    lock (key)
                        _Instance = new BLLBookService();

                return _Instance;
            }
        }

        private BLLBookService() { }
        #endregion

        public List<BooKServiceModel> Get()
        {
            db = new QMSEntities();
            return db.Q_BookService.Select(x => new BooKServiceModel() { Id = x.Id, User = x.NHANVIEN.TENNV, KhachHang = x.KhachHang, SoDienThoai = x.SoDienThoai, SoXe = x.SoXe, MaNV = x.MaNV, GioHen = x.GioHen, NgayHen = x.NgayHen }).ToList();
        }

        public bool Delete(int Id)
        { 
            try
            {
                db = new QMSEntities();
                var obj = db.Q_BookService.FirstOrDefault(x=>x.Id == Id);
                if (obj != null)
                {
                    obj.IsDeleted = true;
                    db.SaveChanges();
                    return true;
                }
                else
                   return false;
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool InsertOrUpdate(Q_BookService obj)
        {
            var rs = false;
            try
            {
                if (obj.Id == 0)
                {
                    db.Q_BookService.Add(obj);
                    rs = false;
                }
                else
                {
                    var oldObj = db.Q_BookService.FirstOrDefault(x => x.Id == obj.Id);
                    if (oldObj != null)
                    {
                        oldObj.MaNV = obj.MaNV;
                        oldObj.KhachHang = obj.KhachHang;
                        oldObj.SoXe = obj.SoXe;
                        oldObj.SoDienThoai = obj.SoDienThoai;
                        oldObj.GioHen = obj.GioHen;
                        oldObj.NgayHen = obj.NgayHen; 
                    }
                }
                db.SaveChanges();
                rs = true;
            }
            catch { }
            return rs;
        }

    }

    public class BooKServiceModel : Q_BookService
    {
        public string User { get; set; }
    }
}
