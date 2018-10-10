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
    public partial class Fkd : AuthWebPage
    {
        CWGLLogic _cwglLogic = new CWGLLogic();
        protected void Page_Load(object sender, EventArgs e)
        {
            InitGridView1();
        }

        public void InitGridView1()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("xh");
            dt.Columns.Add("fkzhbh");
            dt.Columns.Add("fkzhmc");
            dt.Columns.Add("je");
            dt.Columns.Add("bz");



            dt.Rows.Add(dt.NewRow());
            this.GridView1.DataSource = dt;
            this.GridView1.DataBind();



        }

        protected void save_Click(object sender, EventArgs e)
        {
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;

            dml.Add("@user_no", model.LoginUser);
            dml.Add("@bh", bh.Text.Trim());
            dml.Add("@ldrq", Convert.ToDateTime(ldrq.Text.ToString()));
            dml.Add("@skdw", skdw.Text.Trim());
            dml.Add("@jsr", jsr.Text.Trim());
            dml.Add("@bm", bm.Text.Trim());
            dml.Add("@htbh", htbh.Text.Trim());
            dml.Add("@zy", zy.Text.Trim());
            dml.Add("@fjsm", fjsm.Text.Trim());
            dml.Add("@yfye", yfye.Text.Trim());
            if (_cwglLogic.InsertFkd(dml))
            {
                AlertMessage("新增成功");
            }
        }
    }
}