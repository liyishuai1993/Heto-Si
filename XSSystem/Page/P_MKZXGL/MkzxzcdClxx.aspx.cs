using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using xs_System.Logic;
using xsFramework.Web.Login;
using xsFramework.Web.WebPage;

namespace XSSystem.Page.P_MKZXGL
{
    public partial class MkzxzcdClxx : AuthWebPage
    {

        HTGLLogic _htglLogic = new HTGLLogic();

        protected void Page_Load(object sender, EventArgs e)
        {
            //  TextBox1.Text=window
            //  Response.Write("<script>var s = window.dialogArguments;alert(s);document.getElementById('<%=TextBox1.ClientID%>‘).value=s</script>");
            if (!IsPostBack)
            {
                string s = Request.QueryString["transmissionInfo"].ToString();
                djbh.Text = s;
            }
        }



        protected void submit_Click(object sender, EventArgs e)
        {
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;
            dml.Add("@djbh", djbh.Text.Trim());
            dml.Add("@bdh", bdh.Text);
            dml.Add("@user_no", model.LoginUser);
            dml.Add("@thdh", thdh.Text.Trim());
            dml.Add("@ch", float.Parse(ch.Text.Trim()));
            dml.Add("@zcmz", float.Parse(zcmz.Text.Trim()));
            dml.Add("@zcpz", float.Parse(zcpz.Text.Trim()));
            dml.Add("@zcjz", float.Parse(zcjz.Text.Trim()));
            dml.Add("@yfyf", float.Parse(yfyf.Text.Trim()));
            dml.Add("@cgjsje", float.Parse(cgjsje.Text.Trim()));
            dml.Add("@xsjsje", float.Parse(xsjsje.Text.Trim()));
            dml.Add("@bz", bz.Text.Trim());
            dml.Add("@zt", zt.Text.Trim());


            if (_htglLogic.InsertMkzxzcdClxx(dml))
            {
                Response.Write("<script>alert('新增成功')</script>");
              //  JavaScript("window.location.href='CghtGl.aspx'");
              //  AlertMessageAndGoTo("新增成功", "CghtGl.aspx");
                // AlertMessage("新增成功");
                //  xsPage.RefreshPage();
            }

        }
    }
}