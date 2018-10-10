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
    public partial class XshtJgxx : AuthWebPage
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
            dml.Add("@mkmc", mkmc.Text.Trim());
            dml.Add("@mzmc", mzmc.Text.Trim());
            dml.Add("@frl", float.Parse(frl.Text.Trim()));
            dml.Add("@lf", float.Parse(lf.Text.Trim()));
            dml.Add("@kpmj", float.Parse(kpmj.Text.Trim()));
            dml.Add("@htmj", float.Parse(htmj.Text.Trim()));
            dml.Add("@ksl", float.Parse(ksl.Text.Trim()));
            dml.Add("@qdds", float.Parse(qdds.Text.Trim()));
            dml.Add("@qdje", float.Parse(qdje.Text.Trim()));

            if (_htglLogic.InsertXshtJgxx(dml))
            {
                     Response.Write("<script>alert('新增成功')</script>");
                //AlertMessageAndGoTo("新增成功", "XshtGl.aspx");
                //    AlertMessage("新增成功");
                //  xsPage.RefreshPage();
            }

        }
    }
}