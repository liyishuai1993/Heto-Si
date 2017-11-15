using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XSSystem.Page.P_Order
{
    public partial class Mkzxzcd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            InitGridView();
        }

        public void InitGridView()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("xh");
            dt.Columns.Add("bdh");
            dt.Columns.Add("thdh");
            dt.Columns.Add("ch");
            dt.Columns.Add("zcmz");
            dt.Columns.Add("zcpz");
            dt.Columns.Add("zcjz");
            dt.Columns.Add("yfyf");
            dt.Columns.Add("cgjsje");
            dt.Columns.Add("xsjsje");
            dt.Columns.Add("bz");
            dt.Columns.Add("zt");



            dt.Rows.Add(dt.NewRow());
            this.GridView1.DataSource = dt;
            this.GridView1.DataBind();
        }
    }
}