using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XSSystem.Page.P_Order
{
    public partial class Cght : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            InitGridView();
            InitGridView2();
        }


        public void InitGridView() 
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("xh");
            dt.Columns.Add("mz");
            dt.Columns.Add("ld");
            dt.Columns.Add("hf");
            dt.Columns.Add("hff");
            dt.Columns.Add("gdt");
            dt.Columns.Add("njzs");
            dt.Columns.Add("sf");
            dt.Columns.Add("tie");
            dt.Columns.Add("lv");
            dt.Columns.Add("gai");
            dt.Columns.Add("lin");
            dt.Columns.Add("tai");
            dt.Columns.Add("liu");



            dt.Rows.Add(dt.NewRow());
            this.GridView1.DataSource = dt;
            this.GridView1.DataBind();



        }


        public void InitGridView2()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("xh");
            dt.Columns.Add("mkmc");
            dt.Columns.Add("mzmc");
            dt.Columns.Add("frl");
            dt.Columns.Add("lf");
            dt.Columns.Add("kpmj");
            dt.Columns.Add("htmj");
            dt.Columns.Add("ksl");
            dt.Columns.Add("qdds");
            dt.Columns.Add("qdje");
            dt.Columns.Add("zt");
            dt.Columns.Add("cz");



            dt.Rows.Add(dt.NewRow());
            this.GridView2.DataSource = dt;
            this.GridView2.DataBind();



        }
    }
}