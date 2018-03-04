using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XSSystem.Class
{
    public class QueryClass
    {
        public string tableName;
        public string htlx;
        public string shzt;
        public string cxrqQ;
        public string cxrqZ;

        public QueryClass(string tableName,string htlx,string shzt,string cxrqQ,string cxrqZ)
        {
            this.tableName = tableName;
            this.htlx = htlx;
            this.shzt = shzt;
            this.cxrqQ = cxrqQ;
            this.cxrqZ = cxrqZ;
        }
    }
}