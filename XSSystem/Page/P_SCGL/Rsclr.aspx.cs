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
    public partial class Rsclr : AuthWebPage
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
            dml.Add("@ssmc", ssmc.Text.Trim());
            dml.Add("@rq", Convert.ToDateTime(rq.Text.ToString()));
            dml.Add("@kjsj", Convert.ToDateTime(kjsj.Text.ToString()));
            dml.Add("@gjsj", Convert.ToDateTime(gjsj.Text.ToString()));
            dml.Add("@bc", bc.Text.Trim());
            dml.Add("@ydzs",float.Parse(ydzs.Text.Trim()));
            dml.Add("@yddh",float.Parse(yddh.Text.Trim()));
            dml.Add("@ymzs", float.Parse(ymzs.Text.Trim()));
            dml.Add("@gsmc", gsmc.Text.Trim());
            if (_cwglLogic.InsertRsclr(dml))
            {
                AlertMessage("新增成功");
            }
        }
    }
}