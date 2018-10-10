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
    public partial class Qydbckd : AuthWebPage
    {
        HTGLLogic _htglLogic = new HTGLLogic();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["qydbckd"] != null)
                {
                    InitData(Session["qydbckd"]);
                }
            }
        }

        void InitData(object mk)
        {
            DataTable dt = mk as DataTable;
            bh.Text = dt.Rows[0][1].ToString();
            ckbdh.Text = dt.Rows[0][2].ToString();
            zcsj.Text = dt.Rows[0][3].ToString();
            gsmc.Text = dt.Rows[0][4].ToString();
            fmmc.Text = dt.Rows[0][5].ToString();

            ch.Text = dt.Rows[0][6].ToString();
            jsy.Text = dt.Rows[0][7].ToString();
            lxdh.Text = dt.Rows[0][8].ToString();
            wlmc.Text = dt.Rows[0][9].ToString();
            ckmz.Text = dt.Rows[0][10].ToString();

            ckpz.Text = dt.Rows[0][11].ToString();
            ckjz.Text = dt.Rows[0][12].ToString();
            dcmj.Text = dt.Rows[0][13].ToString();
            dbje.Text = dt.Rows[0][14].ToString();
            yj.Text = dt.Rows[0][15].ToString();

            yfyk.Text = dt.Rows[0][16].ToString();
            fkzh.Text = dt.Rows[0][17].ToString();
            Session.Remove("qydbckd");
        }


        protected void submit_Click(object sender, EventArgs e)
        {
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;

            dml.Add("@user_no", model.LoginUser);
            dml.Add("@bh", bh.Text.Trim());
            dml.Add("@ckbdh", ckbdh.Text.Trim());
            dml.Add("@zcsj", Convert.ToDateTime(zcsj.Text.Trim()));
            dml.Add("@gsmc", gsmc.Text.Trim());
            dml.Add("@fmmc", fmmc.Text.Trim());
            dml.Add("@ch", ch.Text.Trim());
            dml.Add("@jsy", jsy.Text.Trim());
            dml.Add("@lxdh", lxdh.Text.Trim());
            dml.Add("@wlmc", wlmc.Text.Trim());
            dml.Add("@ckmz", float.Parse(ckmz.Text.Trim()));
            dml.Add("@ckpz", float.Parse(ckpz.Text.Trim()));
            dml.Add("@ckjz", float.Parse(ckjz.Text.Trim()));
            dml.Add("@dcmj", float.Parse(dcmj.Text.Trim()));
            dml.Add("@dbje", float.Parse(dbje.Text.Trim()));
            dml.Add("@yj", float.Parse(yj.Text.Trim()));
            dml.Add("@yfyk", float.Parse(yfyk.Text.Trim()));
            dml.Add("@fkzh", fkzh.Text.Trim());
            if (_htglLogic.InsertQydbckd(dml))
            {
                AlertMessage("新增成功");
            }
        }

        protected void submit_Click2(object sender, EventArgs e)
        {
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;

            dml.Add("@user_no", model.LoginUser);
            dml.Add("@rkbdh", rkbdh.Text.Trim());
            dml.Add("@ckbdh", ckbdh.Text.Trim());
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