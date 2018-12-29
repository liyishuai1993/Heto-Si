using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XSSystem.Class
{
    public class QueryClass2:BaseClass
    {
        public string bh { get; set; }
        public string user_no { get; internal set; }
        public string tableName { get; internal set; }
        public int all { get; internal set; }
    }
}