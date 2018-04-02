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
    public partial class CghtZlbz : System.Web.UI.Page
    {
        HTGLLogic _htglLogic = new HTGLLogic();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                htbh.Text = Request.QueryString["transmissionInfo"].ToString();
            }
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;
            dml.Add("@htbh", htbh.Text.Trim());
            dml.Add("@user_no", model.LoginUser);
            dml.Add("@mz", mz.Text.Trim());
            dml.Add("@ld", float.Parse(ld.Text.Trim()));
            dml.Add("@hf", float.Parse(hf.Text.Trim()));
            dml.Add("@hff", float.Parse(hff.Text.Trim()));
            dml.Add("@gdt", float.Parse(gdt.Text.Trim()));
            dml.Add("@njzs", float.Parse(njzs.Text.Trim()));
            dml.Add("@sf", float.Parse(sf.Text.Trim()));
            dml.Add("@tie", float.Parse(tie.Text.Trim()));
            dml.Add("@lv", float.Parse(lv.Text.Trim()));
            dml.Add("@gai", float.Parse(gai.Text.Trim()));
            dml.Add("@lin", float.Parse(lin.Text.Trim()));
            dml.Add("@tai", float.Parse(tai.Text.Trim()));
            dml.Add("@liu", float.Parse(liu.Text.Trim()));

            if (_htglLogic.InsertCghtZlbz(dml))
            {
                //      Response.Write("<script>alert('新增成功')</script>");
              //  AlertMessage("新增成功");
                //  xsPage.RefreshPage();
            }

        }
    }
}