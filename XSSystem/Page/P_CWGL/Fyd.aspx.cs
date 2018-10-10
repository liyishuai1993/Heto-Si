using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using xsFramework.Web.WebPage;
using XSSystem.Logic;
using xsFramework.Web.Login;

namespace XSSystem.Page.P_Order
{
    public partial class Fyd : AuthWebPage
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
            dt.Columns.Add("fyxmbh");
            dt.Columns.Add("fyxmmc");
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
            dml.Add("@sfdw", sfdw.Text.Trim());
            dml.Add("@jsr", jsr.Text.Trim());
            dml.Add("@bm", bm.Text.Trim());
            dml.Add("@zy", zy.Text.Trim());
            dml.Add("@fjsm", fjsm.Text.Trim());
            if (_cwglLogic.InsertFyd(dml))
            {
                AlertMessage("新增成功");
            }
            else
                AlertMessage("新增失败，请检查表单");
        }
    }
}