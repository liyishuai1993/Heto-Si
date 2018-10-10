using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using xsFramework.Web.Login;
using xsFramework.Web.WebPage;
using XSSystem.Logic;

namespace XSSystem.Page.P_CWGL
{
    public partial class Xxfpyjd : AuthWebPage
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
            dml.Add("@dh", dh.Text.Trim());
            dml.Add("@ldrq", Convert.ToDateTime(ldrq.Text.ToString()));
            dml.Add("@hth", hth.Text.Trim());
            dml.Add("@gfmc", gfmc.Text.Trim());
            dml.Add("@xfmc", xfmc.Text.Trim());
            dml.Add("@kprq", kprq.Text.Trim());
            dml.Add("@ph", ph.Text.Trim());
            dml.Add("@pm", pm.Text.Trim());
            dml.Add("@shuliang",float.Parse(shuliang.Text.Trim()));
            dml.Add("@dj_hs", float.Parse(dj_hs.Text.Trim()));
            dml.Add("@je", float.Parse(je.Text.Trim()));
            dml.Add("@sl", float.Parse(sl.Text.Trim()));
            dml.Add("@se", float.Parse(se.Text.Trim()));
            dml.Add("@sjhj", float.Parse(sjhj.Text.Trim()));
            dml.Add("@yhs", float.Parse(yhs.Text.Trim()));
            dml.Add("@kddh", kddh.Text.Trim());
            dml.Add("@bz", bz.Text.Trim());
            dml.Add("@sqzt", sqzt.Checked?"已收取":"未收取");
            if (_cwglLogic.InsertXsfpyjd(dml))
            {
                AlertMessage("新增成功");
            }
        }
    }
}