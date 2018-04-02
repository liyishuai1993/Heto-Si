using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XSSystem.Class
{
    public class QyhtClass :BaseClass
    {
        public string htbh;
        public string htlx;
        public string qdrq;
        public string dfhth;
        public string wtf;
        public string stf;
        public string kplx;
        public string zxqxQ;
        public string zxqxZ;

        public QyhtClass(string htbh, string htlx, string qdrq, string dfhth,string wtf,string stf,
            string kplx,string zxqxQ,string zxqxZ)
        {
            this.htbh = htbh;
            this.htlx = htlx;
            this.qdrq = qdrq;
            this.dfhth = dfhth;
            this.wtf = wtf;
            this.stf = stf;
            this.kplx = kplx;
            this.zxqxQ = zxqxQ;
            this.zxqxZ = zxqxZ;

        }

    }
}