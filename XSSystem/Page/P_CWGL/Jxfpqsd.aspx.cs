using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using xsFramework.Web.Login;
using xsFramework.Web.WebPage;
using XSSystem.Logic;

namespace XSSystem.Page.P_CWGL
{
    public partial class Jxfpqsd : AuthWebPage
    {
        CWGLLogic _cwglLogic = new CWGLLogic();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["jxfp"] != null)
            {
                InitData(Session["jxfp"]);
            }
        }

        public void InitData(object mk)
        {
            DataTable dt = mk as DataTable;
            dh.Text = dt.Rows[0][1].ToString();
            ldrq.Text = dt.Rows[0][2].ToString();
            hth.Text = dt.Rows[0][3].ToString();
            gfmc.Text = dt.Rows[0][4].ToString();
            xfmc.Text = dt.Rows[0][5].ToString();
            kprq.Text = dt.Rows[0][6].ToString();
            ph.Text = dt.Rows[0][7].ToString();
            pm.Text = dt.Rows[0][8].ToString();
            shuliang.Text = dt.Rows[0][9].ToString();
            dj_hs.Text = dt.Rows[0][10].ToString();

            je.Text = dt.Rows[0][11].ToString();
            sl.Text = dt.Rows[0][12].ToString();
            se.Text = dt.Rows[0][13].ToString();
            sjhj.Text = dt.Rows[0][14].ToString();
            yhs.Text = dt.Rows[0][15].ToString();
            hyhshj.Text = dt.Rows[0][16].ToString();
            bz.Text = dt.Rows[0][17].ToString();
            Session.Remove("jxfp");
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
            dml.Add("@shuliang", float.Parse(shuliang.Text.Trim()));
            dml.Add("@dj_hs", float.Parse(dj_hs.Text.Trim()));
            dml.Add("@je", float.Parse(je.Text.Trim()));
            dml.Add("@sl", float.Parse(sl.Text.Trim()));
            dml.Add("@se", float.Parse(se.Text.Trim()));
            dml.Add("@sjhj", float.Parse(sjhj.Text.Trim()));
            dml.Add("@yhs", float.Parse(yhs.Text.Trim()));
            dml.Add("@hyhshj",float.Parse(hyhshj.Text.Trim()));
            dml.Add("@bz", bz.Text.Trim());
            if (_cwglLogic.InsertJxfpqsd(dml))
            {
                AlertMessage("新增成功");
            }
        }
    }
}