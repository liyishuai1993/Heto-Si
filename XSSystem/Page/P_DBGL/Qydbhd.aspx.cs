using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using xs_System.Logic;
using xsFramework.Web.Login;
using xsFramework.Web.WebPage;

namespace XSSystem.Page.P_Order
{
    public partial class Qydbhd : AuthWebPage
    {
        HTGLLogic _htglLogic = new HTGLLogic();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["qydbhd"] != null)
                {
                    InitData(Session["qydbhd"]);
                }
            }
        }

        void InitData(object mk)
        {
            DataTable dt = mk as DataTable;
            rkbdh.Text = dt.Rows[0][1].ToString();
            rksj.Text = dt.Rows[0][2].ToString();
            smmc.Text = dt.Rows[0][3].ToString();
            rkmz.Text = dt.Rows[0][4].ToString();
            rkpz.Text = dt.Rows[0][5].ToString();

            rkjz.Text = dt.Rows[0][6].ToString();
            ksds.Text = dt.Rows[0][7].ToString();
            yyds.Text = dt.Rows[0][8].ToString();
            yslhbz.Text = dt.Rows[0][9].ToString();
            yfkkbz.Text = dt.Rows[0][10].ToString();

            yfkkds.Text = dt.Rows[0][11].ToString();
            yfkkje.Text = dt.Rows[0][12].ToString();
            yfjsdw.Text = dt.Rows[0][13].ToString();
            yfyf.Text = dt.Rows[0][14].ToString();
            fykk.Text = dt.Rows[0][15].ToString();

            jsyf.Text = dt.Rows[0][16].ToString();
            drje.Text = dt.Rows[0][17].ToString();

            drmj.Text = dt.Rows[0][18].ToString();
            shzt.Text = dt.Rows[0][19].ToString();
            yfjszt.Text = dt.Rows[0][20].ToString();
            Session.Remove("qydbhd");
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;

            dml.Add("@user_no", model.LoginUser);
            dml.Add("@rkbdh", rkbdh.Text.Trim());
            dml.Add("@rksj", Convert.ToDateTime(rksj.Text.Trim()));
            dml.Add("@smmc", smmc.Text.Trim());
            dml.Add("@rkmz", float.Parse(rkmz.Text.Trim()));
            dml.Add("@rkpz", float.Parse(rkpz.Text.Trim()));
            dml.Add("@rkjz", float.Parse(rkjz.Text.Trim()));
            dml.Add("@ksds", float.Parse(ksds.Text.Trim()));
            dml.Add("@yyds", float.Parse(yyds.Text.Trim()));
            dml.Add("@yslhbz", float.Parse(yslhbz.Text.Trim()));
            dml.Add("@yfkkbz", float.Parse(yfkkbz.Text.Trim()));
            dml.Add("@yfkkds", float.Parse(yfkkds.Text.Trim()));
            dml.Add("@yfkkje", float.Parse(yfkkje.Text.Trim()));
            dml.Add("@yfjsdw", float.Parse(yfjsdw.Text.Trim()));
            dml.Add("@yfyf", float.Parse(yfyf.Text.Trim()));
            dml.Add("@fykk", float.Parse(fykk.Text.Trim()));
            dml.Add("@jsyf", float.Parse(jsyf.Text.Trim()));
            dml.Add("@drje", float.Parse(drje.Text.Trim()));
            dml.Add("@drmj", float.Parse(drmj.Text.Trim()));
            dml.Add("@shzt", shzt.Text.Trim());
            dml.Add("@yfjszt", yfjszt.Text.Trim());
            if (_htglLogic.InsertQydbhd(dml))
            {
                AlertMessage("新增成功");
            }
        }
    }
}