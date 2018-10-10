using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XSSystem.Class
{
    public class QueryClass:BaseClass
    {
        public string user_no { get; set; }
        public string tableName { get; set; }
        public string htbh { get; set; }
        DateTime _qdrqQ = Convert.ToDateTime("2118-01-01");
        DateTime _qdrqZ = Convert.ToDateTime("2118-12-31");
        public DateTime qdrqQ { get { return _qdrqQ; } set { _qdrqQ = value; } }
        public DateTime qdrqZ { get { return _qdrqZ; } set { _qdrqZ = value; } }
        public string gfmc { get; set; }
        public string xfmc { get; set; }
        public string mkmc { get; set; }
        public float kpmj { get; set; }
        public string wtf { get; set; }
        public string stf { get; set; }
        public string qyd { get; set; }
        public string mdd { get; set; }
        public float yj { get; set; }
        public string zxzt { get; set; }
        public string zcz { get; set; }
        public string zdz { get; set; }
        public string xlx { get; set; }
        public float tlyf { get; set; }
        public float jgf { get; set; }
        public string czf { get; set; }
        public string czdd{ get; set; }
        public float zj { get; set; }
        DateTime _zzrq = Convert.ToDateTime("2118-12-31");
        internal string ch;

        public string rkbdh { get; set; }
        public float rkjz { get; set; }
        public float jsyf { get; set; }

        public DateTime zzrq { get { return _zzrq; } set { _zzrq = value; } }
        public string zt { get; set; }
        public string cghth { get; set; }
        public string ghf { get; set; }
        public string shf { get; set; }
        public string wlmc { get; set; }
        public float cgmj { get; set; }
        public float xsmj { get; set; }
        public float zcjz { get; internal set; }
        public string fmmc { get; internal set; }
        public string xh { get; internal set; }
        public string xhck { get; internal set; }
        public object smmc { get; internal set; }
        public string ckbdh { get; internal set; }
        public float ckjz { get; internal set; }
        public float ckjz2 { get; internal set; }
        public float mj { get; internal set; }
        public string rkmc { get; internal set; }
        public string bh { get; internal set; }
        public string djbh { get; internal set; }
        public string hth { get; internal set; }

        public QueryClass()
        {

        }
    }
}