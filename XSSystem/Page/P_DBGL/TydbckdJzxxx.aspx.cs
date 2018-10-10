using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using xs_System.Logic;
using xsFramework.Web.Login;
using xsFramework.Web.WebPage;

namespace XSSystem.Page.P_DBGL
{
    public partial class TydbckdJzxxx : AuthWebPage
    {

        HTGLLogic _htglLogic = new HTGLLogic();

        protected void Page_Load(object sender, EventArgs e)
        {
            //  TextBox1.Text=window
            //  Response.Write("<script>var s = window.dialogArguments;alert(s);document.getElementById('<%=TextBox1.ClientID%>‘).value=s</script>");
            if (!IsPostBack)
            {
                string s = Request.QueryString["transmissionInfo"].ToString();
                bh.Text = s;
            }
        }



        protected void submit_Click(object sender, EventArgs e)
        {
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;
            dml.Add("@bh", bh.Text.Trim());
            dml.Add("@user_no", model.LoginUser);
            dml.Add("@xh", xh.Text.Trim());
            dml.Add("@sxds", float.Parse(sxds.Text.Trim()));
            dml.Add("@zxrq", Convert.ToDateTime(zxrq.Text.Trim()));
            dml.Add("@fcrq", Convert.ToDateTime(fcrq.Text.Trim()));
            dml.Add("@dcmj", float.Parse(dcmj.Text.Trim()));
            dml.Add("@xhds", float.Parse(xhds.Text.Trim()));
            dml.Add("@dzrq", Convert.ToDateTime(dzrq.Text.Trim()));
            dml.Add("@xhck", xhck.Text.Trim());
            dml.Add("@zbxsf", float.Parse(zbxsf.Text.Trim()));
            dml.Add("@fzdlf", float.Parse(fzdlf.Text.Trim()));

            dml.Add("@fzzxf", float.Parse(fzzxf.Text.Trim()));
            dml.Add("@fzddf", float.Parse(fzddf.Text.Trim()));
            dml.Add("@tlyf", float.Parse(tlyf.Text.Trim()));

            dml.Add("@dzzxf", float.Parse(dzzxf.Text.Trim()));
            dml.Add("@dzmcddf", float.Parse(dzmcddf.Text.Trim()));
            dml.Add("@dzdlf", float.Parse(dzdlf.Text.Trim()));

            dml.Add("@drmj", float.Parse(drmj.Text.Trim()));


            if (_htglLogic.InsertTydbckdJzxxx(dml))
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