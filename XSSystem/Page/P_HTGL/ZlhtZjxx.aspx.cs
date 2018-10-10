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
    public partial class ZlhtZjxx : AuthWebPage
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
            dml.Add("@qsrq", Convert.ToDateTime(qsrq.Text.Trim()));
            dml.Add("@zzrq", Convert.ToDateTime(zzrq.Text.Trim()));
            dml.Add("@zj", float.Parse(zj.Text.Trim()));
            dml.Add("@fktk", fktk.Text.Trim());
            dml.Add("@zxzt", zxzt.Text.Trim());
            dml.Add("@bz", bz.Text.Trim());
            if (_htglLogic.InsertZlhtZjxx(dml))
            {
                      Response.Write("<script>alert('新增成功')</script>");
                //AlertMessageAndGoTo("新增成功", "ZlhtGl.aspx");
                //    AlertMessage("新增成功");
                //  xsPage.RefreshPage();
            }

        }
    }
}