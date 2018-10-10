using System;
using System.Collections.Generic;
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
    }
}