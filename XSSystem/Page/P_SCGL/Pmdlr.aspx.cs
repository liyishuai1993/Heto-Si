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
    public partial class Pmdlr : AuthWebPage
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
            dml.Add("@pmbh", pmbh.Text.Trim());
            dml.Add("@pmrq", Convert.ToDateTime(pmrq.Text.ToString()));
            dml.Add("@scmc", scmc.Text.Trim());
            dml.Add("@gsmc", gsmc.Text.Trim());
            if (_cwglLogic.InsertPmdlr(dml))
            {
                AlertMessage("新增成功");
            }
        }
    }
}