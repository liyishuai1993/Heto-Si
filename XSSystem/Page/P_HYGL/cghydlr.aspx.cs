using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using xsFramework.Web.WebPage;
using xsFramework.Web.Login;
using XSSystem.Logic;

namespace XSSystem.Page.P_Order
{
    public partial class cghydlr : AuthWebPage
    {
        CWGLLogic _cwglLogic = new CWGLLogic();
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

        protected void submit_Click(object sender, EventArgs e)
        {
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;

            dml.Add("@user_no", model.LoginUser);
            dml.Add("@hydbh", hydbh.Text.Trim());
            dml.Add("@hyrq", Convert.ToDateTime(hyrq.Text.ToString()));
            dml.Add("@gys", gys.Text.Trim());
            dml.Add("@mcmc", mcmc.Text.Trim());
            dml.Add("@wlmc", wlmc.Text.Trim());
            dml.Add("@cyr", cyr.Text.Trim());
            dml.Add("@hyr", hyr.Text.Trim());
            if (_cwglLogic.InsertCghydlr(dml))
            {
                AlertMessage("新增成功");
            }
        }
    }
}