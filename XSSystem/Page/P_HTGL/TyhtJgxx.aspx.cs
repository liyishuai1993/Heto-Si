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
    public partial class TyhtJgxx : AuthWebPage
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
            dml.Add("@gsmc", gsmc.Text.Trim());
            dml.Add("@dfhth", dfhth.Text.Trim());
            dml.Add("@kplx", kplx.Text.Trim());
            dml.Add("@zbxsf", float.Parse(zbxsf.Text.Trim()));
            dml.Add("@dlf", float.Parse(dlf.Text.Trim()));
            dml.Add("@zxf", float.Parse(zxf.Text.Trim()));
            dml.Add("@sfzdd", float.Parse(sfzdd.Text.Trim()));
            dml.Add("@tlyf", float.Parse(tlyf.Text.Trim()));
            dml.Add("@dzzxf", float.Parse(dzzxf.Text.Trim()));
            dml.Add("@dzmcddf", float.Parse(dzmcddf.Text.Trim()));
            dml.Add("@dzdlf", float.Parse(dzdlf.Text.Trim()));

            if (_htglLogic.InsertTyhtJgxx(dml))
            {
                     Response.Write("<script>alert('新增成功')</script>");
               // AlertMessageAndGoTo("新增成功", "TyhtGl.aspx");
                //AlertMessage("新增成功");
                //  xsPage.RefreshPage();
            }

        }
    }
}