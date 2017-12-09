using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace XSSystem.Page.P_Order
{
    public partial class cghydlr : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            InitGridView();
        }

        public void InitGridView()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("xh");
            dt.Columns.Add("mz");
            dt.Columns.Add("sf");
            dt.Columns.Add("hf");
            dt.Columns.Add("hff");
            dt.Columns.Add("gdt");
            dt.Columns.Add("njzs");
            dt.Columns.Add("ld");
            dt.Columns.Add("liu");
            dt.Columns.Add("tie");
            dt.Columns.Add("lv");
            dt.Columns.Add("gai");
            dt.Columns.Add("lin");
            dt.Columns.Add("tai");
            dt.Columns.Add("dwfrl");
            dt.Columns.Add("gwfrl");
            dt.Columns.Add("jztz");
            dt.Columns.Add("bz");
            dt.Columns.Add("cz");





            dt.Rows.Add(dt.NewRow());
            this.GridView1.DataSource = dt;
            this.GridView1.DataBind();



        }
    }
}