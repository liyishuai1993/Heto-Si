using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace XSSystem.Page.P_Order
{
    public partial class Tydbckd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            InitGridView();
        }


        public void InitGridView()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("xh");
            dt.Columns.Add("xiangh");
            dt.Columns.Add("sxds");
            dt.Columns.Add("zxrq");
            dt.Columns.Add("fcrq");
            dt.Columns.Add("dcmj");
            dt.Columns.Add("xhds");
            dt.Columns.Add("dzrq");
            dt.Columns.Add("jshk");
            dt.Columns.Add("zbxsf");
            dt.Columns.Add("fzdlf");
            dt.Columns.Add("fzzxf");
            dt.Columns.Add("fzddf");
            dt.Columns.Add("tlyf");
            dt.Columns.Add("dzzxf");
            dt.Columns.Add("dzmcddf");
            dt.Columns.Add("dzdlf");
            dt.Columns.Add("drmj");



            dt.Rows.Add(dt.NewRow());
            this.GridView1.DataSource = dt;
            this.GridView1.DataBind();
        }
    }
}