using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XSSystem.Class
{
    public class MkzxzcdClass : BaseClass
    {
        public string djbh;
        public string zcsj;
        public string cghth;
        public string ghf;
        public string shf;
        public string mkmc;
        public string wlmc;
        public string cydw;
        public string yj;
        public string cgmj;
        public string xsmj;

        public MkzxzcdClass(string djbh,string zcsj, string cghth, string ghf, string shf,
            string mkmc, string wlmc, string cydw,  string yj, string cgmj, string xsmj)
        {
            this.djbh = djbh;
            this.cghth = cghth;
            this.zcsj = zcsj;
            this.ghf = ghf;
            this.shf = shf;
            this.mkmc = mkmc;
            this.wlmc = wlmc;
            this.cydw = cydw;
            this.yj = yj;
            this.cgmj = cgmj;
            this.xsmj = xsmj;
        }

    }
}