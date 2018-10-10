using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XSSystem.Class
{
    public class ZlhtClass :BaseClass
    {
        public string htbh;
        public string htlx;
        public string qdrq;
        public string czf;
        public string czf2;
        public string czdd;
        public string zlqxQ;
        public string zlqxZ;
        public string yj;

        public ZlhtClass(string htbh, string htlx, string qdrq,string czf,string czf2,
            string czdd,string zlqxQ,string zlqxZ,string yj)
        {
            this.htbh = htbh;
            this.htlx = htlx;
            this.qdrq = qdrq;
            this.czf = czf;
            this.czf2 = czf2;
            this.czdd = czdd;
            this.zlqxQ = zlqxQ;
            this.zlqxZ = zlqxZ;
            this.yj = yj;
        }

    }
}