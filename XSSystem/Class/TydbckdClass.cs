using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XSSystem.Class
{
    public class TydbckdClass : BaseClass
    {
        public string bh;
        public string htbh;
        public string gsmc;
        public string fmmc;
        public string wlmc;
        public string zcz;
        public string zdz;
        public string xlx;

        public TydbckdClass(string bh, string htbh, string gsmc,string fmmc,
            string wlmc, string zcz,string zdz,string xlx)
        {
            this.bh = bh;
            this.htbh = htbh;
            this.fmmc = fmmc;
            this.gsmc = gsmc;

            this.wlmc = wlmc;

            this.zcz = zcz;

            this.zdz = zdz;
            this.xlx = xlx;
        }

    }
}