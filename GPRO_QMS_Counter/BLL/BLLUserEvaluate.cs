using GPRO_QMS_Counter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPRO_QMS_Counter.BLL
{
    public class BLLUserEvaluate
    {
        static QMSEntities db = null;

        #region constructor
        static Object key = new object();
        private static volatile BLLUserEvaluate _Instance;
        public static BLLUserEvaluate Instance
        {
            get
            {
                if (_Instance == null)
                    lock (key)
                        _Instance = new BLLUserEvaluate();

                return _Instance;
            }
        }

        private BLLUserEvaluate() { }
        #endregion

        public List<UserEvaluateModel> Get(int userId, DateTime from, DateTime to)
        {
            db = new QMSEntities();
            List<UserEvaluateModel> objs;
            if (userId == 0)
                objs = db.Q_UserEvaluate.Where(x => x.GGIAODICH >= from && x.GGIAODICH <= to).Select(x => new UserEvaluateModel()
                {
                    Id = x.Id,
                    MAPHIEU = x.TicketNumber,
                    TENNV = x.NHANVIEN.TENNV,
                    DANHGIA = x.Score,
                    GLAYPHIEU = x.GLAYPHIEU,
                    GDENQUAY = x.GDENQUAY,
                    GGIAODICH = x.GGIAODICH,
                    GKETTHUC = x.GKETTHUC,
                }).ToList();
            else
                objs = db.Q_UserEvaluate.Where(x => x.UserId == userId && x.GGIAODICH >= from && x.GGIAODICH <= to).Select(x => new UserEvaluateModel()
                {
                    Id = x.Id,
                    MAPHIEU = x.TicketNumber,
                    TENNV = x.NHANVIEN.TENNV,
                    DANHGIA = x.Score,
                    GLAYPHIEU = x.GLAYPHIEU,
                    GDENQUAY = x.GDENQUAY,
                    GGIAODICH = x.GGIAODICH,
                    GKETTHUC = x.GKETTHUC,
                }).ToList();

            if (objs != null && objs.Count > 0)
            {
                var evaluateObjs = db.Q_EvaluateDetail.ToList();
                foreach (var item in objs)
                { 
                    if (item.DANHGIA == "0")
                        item.DANHGIA = "không đánh giá";
                    else
                    {
                        var arr = item.DANHGIA.Split('_').Select(x => Convert.ToInt32(x)).ToList();
                        var dt = evaluateObjs.FirstOrDefault(x => x.EvaluateId == arr[0] && x.Id == arr[1]);
                        item.DANHGIA = dt.Name;
                    }
                }
            }
            return objs;
        }
    }

    public class UserEvaluateModel
    {
        public int Id { get; set; }
        public string TENNV { get; set; }
        public int MAPHIEU { get; set; }
        public string DANHGIA { get; set; }
        public DateTime? GLAYPHIEU { get; set; }
        public DateTime? GDENQUAY { get; set; }
        public DateTime? GGIAODICH { get; set; }
        public DateTime? GKETTHUC { get; set; }
    }
}
