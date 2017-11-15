using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace XSSystem.Page.P_Order
{
    public partial class Zlht : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            InitGridView();
        }

        public void InitGridView()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("xh");
            dt.Columns.Add("qsrq");
            dt.Columns.Add("zzrq");
            dt.Columns.Add("zj");
            dt.Columns.Add("fktk");
            dt.Columns.Add("zxzt");
            dt.Columns.Add("bz");



            dt.Rows.Add(dt.NewRow());
            this.GridView1.DataSource = dt;
            this.GridView1.DataBind();
        }
    }
}