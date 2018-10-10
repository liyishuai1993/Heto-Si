using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using xs_System.Logic;
using xsFramework.Web.Login;
using xsFramework.Web.WebPage;

namespace XSSystem.Page.P_HTGL
{
    public partial class QyhtJgxx : AuthWebPage
    {
        HTGLLogic _htglLogic = new HTGLLogic();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string s = Request.QueryString["transmissionInfo"].ToString();
                htbh.Text = s;
            }
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;
            dml.Add("@htbh", htbh.Text.Trim());
            dml.Add("@user_no", model.LoginUser);
            dml.Add("@wlmc", wlmc.Text.Trim());
            dml.Add("@qyd", qyd.Text.Trim());
            dml.Add("@mdd", mdd.Text.Trim());
            dml.Add("@yj", float.Parse(yj.Text.Trim()));
            dml.Add("@yflhbz", yflhbz.Text.Trim());
            dml.Add("@bz", bz.Text.Trim());

            if (_htglLogic.InsertQyhtJgxx(dml))
            {
                //      Response.Write("<script>alert('新增成功')</script>");
                Response.Write("<script>alert('新增成功')</script>");
              //  AlertMessageAndGoTo("新增成功", "QyhtGl.aspx");
                //AlertMessage("新增成功");
                //  xsPage.RefreshPage();
            }

        }
    }
}