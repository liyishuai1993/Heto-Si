using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XSSystem.Page.P_CWGL
{
    public partial class Yfjsd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            InitGridView();
        }

        public void InitGridView()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("jsdlx");
            dt.Columns.Add("bdh");
            dt.Columns.Add("zcrq");
            dt.Columns.Add("rkrq");
            dt.Columns.Add("ch");
            dt.Columns.Add("zcd");
            dt.Columns.Add("shd");
            dt.Columns.Add("wlmc");
            dt.Columns.Add("zcjz");
            dt.Columns.Add("rkjz");
            dt.Columns.Add("yfdj");
            dt.Columns.Add("yfyf");
            dt.Columns.Add("yfyk");
            dt.Columns.Add("kjkx");
            dt.Columns.Add("sfyf");



            dt.Rows.Add(dt.NewRow());
            this.GridView1.DataSource = dt;
            this.GridView1.DataBind();
        }
    }
}