using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XSSystem.Class
{
    public class QydbhdClass : BaseClass
    {
        public string rkbdh;
        public string rksj;
        public string smmc;
        public string rkmz;
        public string rkpz;
        public string rkjz;
        public string ksds;
        public string yyds;
        public string yslhbz;
        public string yfkkbz;
        public string yfkkds;
        public string yfkkje;
        public string yfjsdw;
        public string yfyf;
        public string fykk;
        public string jsyf;
        public string drje;
        public string drmj;
        public string yfjszt;

        public QydbhdClass(string rkbdh, string rksj, string smmc, string rkmz,
            string rkpz, string rkjz, string ksds, string yyds, string yslhbz, string yfkkbz, string yfkkds, string yfkkje, string yfjsdw, string yfyf, string fykk, string jsyf,string drje,string drmj,string yfjszt)
        {
            this.rkbdh = rkbdh;
            this.rksj = rksj;
            this.smmc = smmc;
            this.rkmz = rkmz;
            this.rkpz = rkpz;
            this.rkjz = rkjz;
            this.ksds = ksds;

            this.yyds = yyds;
            this.yslhbz = yslhbz;
            this.yfkkbz = yfkkbz;
            this.yfkkds = yfkkds;
            this.yfkkje = yfkkje;
            this.yfjsdw = yfjsdw;
            this.yfyf = yfyf;

            this.fykk = fykk;
            this.jsyf = jsyf;

            this.drje = drje;
            this.drmj = drmj;
            this.yfjszt = yfjszt;
        }

    }
}