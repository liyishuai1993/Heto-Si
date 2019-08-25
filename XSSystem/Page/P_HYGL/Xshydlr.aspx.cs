using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using xsFramework.Web.Login;
using xsFramework.Web.WebPage;
using XSSystem.Logic;

namespace XSSystem.Page.P_Order
{
    public partial class Xshydlr : AuthWebPage
    {
        CWGLLogic _cwglLogic = new CWGLLogic();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["xshyd"] != null)
                {
                    InitData(Session["xshyd"]);
                }
            }
        }

        public void InitData(object mk)
        {
            DataTable dt = mk as DataTable;
            hydbh.Text = dt.Rows[0][1].ToString();
            hyrq.Text = dt.Rows[0][2].ToString();
            kh.Text = dt.Rows[0][3].ToString();
            mcmc.Text = dt.Rows[0][4].ToString();
            wlmc.Text = dt.Rows[0][5].ToString();
            cyr.Text = dt.Rows[0][6].ToString();
            hyr.Text = dt.Rows[0][7].ToString();
            // ysye.Text = dt.Rows[0][9].ToString();
            // yfye.Text = dt.Rows[0][10].ToString();
            Session.Remove("xshyd");
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;

            dml.Add("@user_no", model.LoginUser);
            dml.Add("@hydbh", hydbh.Text.Trim());
            dml.Add("@hyrq", Convert.ToDateTime(hyrq.Text.ToString()));
            dml.Add("@kh", kh.Text.Trim());
            dml.Add("@mcmc", mcmc.Text.Trim());
            dml.Add("@wlmc", wlmc.Text.Trim());
            dml.Add("@cyr", cyr.Text.Trim());
            dml.Add("@hyr", hyr.Text.Trim());
            if (_cwglLogic.InsertXshydlr(dml))
            {
                AlertMessage("新增成功");
            }
        }

        protected void close_Click(object sender, EventArgs e)
        {
            JavaScript("window.location.href='XshydlrGl.aspx'");

        }
    }
}