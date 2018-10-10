using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XSSystem.Class
{
    public class QydbckdClass : BaseClass
    {
        public string bh;
        public string ckbdh;
        public string zcsj;
        public string gsmc;
        public string fmmc;
        public string ch;
        public string jsy;
        public string lxdh;
        public string wlmc;
        public string ckmz;
        public string ckpz;
        public string ckjz;
        public string dcmj;
        
        public string dbje;
        public string yj;
        public string yfyk;
        public string fkzh;

        public QydbckdClass(string bh, string ckbdh, string zcsj,string fmmc,
            string ch, string jsy, string lxdh, string wlmc, string ckmz, string ckpz, string ckjz, string dcmj, string dbje, string yj,string yfyk, string fkzh)
        {
            this.ckbdh = ckbdh;
            this.bh = bh;
            this.zcsj = zcsj;
            this.fmmc = fmmc;
            this.ch = ch;
            this.jsy = jsy;
            this.lxdh = lxdh;

            this.wlmc = wlmc;
            this.ckmz = ckmz;
            this.ckpz = ckpz;
            this.ckjz = ckjz;
            this.dcmj = dcmj;
            this.dbje = dbje;
            this.yfyk = yfyk;

            this.yj = yj;
            this.fkzh = fkzh;
        }

    }
}