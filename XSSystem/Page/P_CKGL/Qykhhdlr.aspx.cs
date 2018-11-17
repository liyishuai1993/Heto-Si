using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using xs_System.Logic;
using xsFramework.Web.Login;
using xsFramework.Web.WebPage;

namespace XSSystem.Page.P_Order
{
    public partial class Qykhhdlr : AuthWebPage
    {
        HTGLLogic _htglLogic = new HTGLLogic();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["qykhhdlr"] != null)
                {
                    InitData(Session["qykhhdlr"]);
                }
            }
        }

        void InitData(object mk)
        {
            DataTable dt = mk as DataTable;
            rkbdh.Text = dt.Rows[0][1].ToString();
            rksj.Text = dt.Rows[0][2].ToString();
            rkmz.Text = dt.Rows[0][3].ToString();
            rkpz.Text = dt.Rows[0][4].ToString();
            rkjz.Text = dt.Rows[0][5].ToString();

            ksds.Text = dt.Rows[0][6].ToString();
            yyds.Text = dt.Rows[0][7].ToString();
            kd.Text = dt.Rows[0][8].ToString();
            yfhllh.Text = dt.Rows[0][9].ToString();
            yflhbz.Text = dt.Rows[0][10].ToString();

            yfkkds.Text = dt.Rows[0][11].ToString();
            yfkkje.Text = dt.Rows[0][12].ToString();
            yfjsdw.Text = dt.Rows[0][13].ToString();
            yfyf.Text = dt.Rows[0][14].ToString();
            fykk.Text = dt.Rows[0][15].ToString();

            jsyf.Text = dt.Rows[0][16].ToString();
            hkjsdw.Text = dt.Rows[0][17].ToString();
            jshk.Text = dt.Rows[0][18].ToString();
            tcbz.Text = dt.Rows[0][19].ToString();
            tcje.Text = dt.Rows[0][20].ToString();

            ywy.Text = dt.Rows[0][21].ToString();
            yfjszt.Text = dt.Rows[0][22].ToString();
            shzt.Text = dt.Rows[0][23].ToString();
            Session.Remove("qykhhdlr");
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;
            try
            {
                dml.Add("@user_no", model.LoginUser);
                dml.Add("@rkbdh", rkbdh.Text.Trim());
                dml.Add("@rksj", Convert.ToDateTime(rksj.Text.Trim()));
                dml.Add("@rkmz", float.Parse(rkmz.Text.Trim()));
                dml.Add("@rkpz", float.Parse(rkpz.Text.Trim()));
                dml.Add("@rkjz", float.Parse(rkjz.Text.Trim()));
                dml.Add("@ksds", float.Parse(ksds.Text.Trim()));
                dml.Add("@yyds", float.Parse(yyds.Text.Trim()));
                dml.Add("@kd", float.Parse(kd.Text.Trim()));
                dml.Add("@yfhllh", float.Parse(yfhllh.Text.Trim()));
                dml.Add("@yflhbz", float.Parse(yflhbz.Text.Trim()));
                dml.Add("@yfkkds", float.Parse(yfkkds.Text.Trim()));
                dml.Add("@yfkkje", float.Parse(yfkkje.Text.Trim()));
                dml.Add("@yfjsdw", float.Parse(yfjsdw.Text.Trim()));
                dml.Add("@yfyf", float.Parse(yfyf.Text.Trim()));
                dml.Add("@fykk", float.Parse(fykk.Text.Trim()));
                dml.Add("@jsyf", float.Parse(jsyf.Text.Trim()));
                dml.Add("@hkjsdw", float.Parse(hkjsdw.Text.Trim()));
                dml.Add("@jshk", float.Parse(jshk.Text.Trim()));
                dml.Add("@tcbz", tcbz.Text.Trim());
                dml.Add("@tcje", float.Parse(tcje.Text.Trim()));
                dml.Add("@ywy", ywy.Text.Trim());
                dml.Add("@yfjszt", yfyf.Text.Trim());
                dml.Add("@shzt", shzt.Text.Trim());
            }
            catch
            {
                AlertMessage("数据存在错误，请检查");
                return;
            }
            if (_htglLogic.InsertQykhhdlr(dml))
            {
                AlertMessage("新增成功");
            }
        }
    }
}