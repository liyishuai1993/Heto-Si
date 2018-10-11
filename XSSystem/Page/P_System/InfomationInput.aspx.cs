using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using xs_System.Logic;
using System.Web.UI.WebControls;
using xsFramework.Web.WebPage;
using xsFramework.Web.Login;

namespace XSSystem.Page.P_System
{
    public partial class InfomationInput : System.Web.UI.Page
    {
        HTGLLogic _htglLogic = new HTGLLogic();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit1_Click(object sender, EventArgs e)
        {
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;
            dml.Add("@user_no", model.LoginUser);
            dml.Add("@MeiZhong", MZ.Text.Trim());
            _htglLogic.InsertInfomation(dml);
        }

        protected void submit2_Click(object sender, EventArgs e)
        {
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;
            dml.Add("@user_no", model.LoginUser);
            dml.Add("@YL", YL.Text.Trim());
            _htglLogic.InsertInfomation(dml);
        }

        protected void submit3_Click(object sender, EventArgs e)
        {
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;
            dml.Add("@user_no", model.LoginUser);
            dml.Add("@CP", CP.Text.Trim());
            _htglLogic.InsertInfomation(dml);
        }
    }
}