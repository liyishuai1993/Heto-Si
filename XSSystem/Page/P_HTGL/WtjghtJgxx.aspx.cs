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
    public partial class WtjghtJgxx : AuthWebPage
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
            dml.Add("@jgf", float.Parse(jgf.Text.Trim()));
            dml.Add("@cmzb", cmzb.Text.Trim());
            dml.Add("@bz", bz.Text.Trim());

            if (_htglLogic.InsertWtjghtJgxx(dml))
            {
                
                Response.Write("<script>alert('新增成功')</script>");
            //    AlertMessageAndGoTo("新增成功", "WtjghtGl.aspx");
                //AlertMessage("新增成功");
                //  xsPage.RefreshPage();
            }

        }
    }
}