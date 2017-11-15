using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XSSystem.Page.P_Order
{
    public partial class Tyht : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            InitGridView();
        }

        public void InitGridView()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("xh");
            dt.Columns.Add("gsmc");
            dt.Columns.Add("dfhth");
            dt.Columns.Add("zbxsf");
            dt.Columns.Add("dlf");
            dt.Columns.Add("gdt");
            dt.Columns.Add("zxf");
            dt.Columns.Add("sfzdd");
            dt.Columns.Add("tlyf");
            dt.Columns.Add("dzzxf");
            dt.Columns.Add("dzmcddf");
            dt.Columns.Add("dddlf");



            dt.Rows.Add(dt.NewRow());
            this.GridView1.DataSource = dt;
            this.GridView1.DataBind();
        }
    }
}