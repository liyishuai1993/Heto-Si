﻿using System;
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
    public partial class Cgrkd : AuthWebPage
    {
        HTGLLogic _htglLogic = new HTGLLogic();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["cgrkd"] != null)
                {
                    InitData(Session["cgrkd"]);
                }
            }
        }

        void InitData(object mk)
        {
            DataTable dt = mk as DataTable;
            hth.Text = dt.Rows[0][1].ToString();
            mkmc.Text = dt.Rows[0][2].ToString();
            gf.Text = dt.Rows[0][3].ToString();
            xf.Text = dt.Rows[0][4].ToString();
            wlmc.Text = dt.Rows[0][5].ToString();

            mj.Text = dt.Rows[0][6].ToString();
            yshtbh.Text = dt.Rows[0][7].ToString();
            cycd.Text = dt.Rows[0][8].ToString();
            zcbdh.Text = dt.Rows[0][9].ToString();
            tmdh.Text = dt.Rows[0][10].ToString();

            zcrq.Text = dt.Rows[0][11].ToString();
            ch.Text = dt.Rows[0][12].ToString();

            zcmz.Text = dt.Rows[0][13].ToString();
            zcpz.Text = dt.Rows[0][14].ToString();
            zcjz.Text = dt.Rows[0][15].ToString();
            jsmk.Text = dt.Rows[0][16].ToString();
            rkrq.Text = dt.Rows[0][17].ToString();
            rkbdh.Text = dt.Rows[0][18].ToString();

            rkmc.Text = dt.Rows[0][19].ToString();
            rkmz.Text = dt.Rows[0][20].ToString();

            rkpz.Text = dt.Rows[0][21].ToString();
            rkjz.Text = dt.Rows[0][22].ToString();
            ksds.Text = dt.Rows[0][23].ToString();
            yyds.Text = dt.Rows[0][24].ToString();
            yslhbz.Text = dt.Rows[0][25].ToString();

            kkbz.Text = dt.Rows[0][26].ToString();
            kkds.Text = dt.Rows[0][27].ToString();

            kkje.Text = dt.Rows[0][28].ToString();
            yfjsdw.Text = dt.Rows[0][29].ToString();
            yj.Text = dt.Rows[0][30].ToString();
            yfyf.Text = dt.Rows[0][31].ToString();
            yfyk.Text = dt.Rows[0][32].ToString();

            fkzh.Text = dt.Rows[0][33].ToString();
            jsyf.Text = dt.Rows[0][34].ToString();

            zfzh.Text = dt.Rows[0][35].ToString();
            shzt.Text = dt.Rows[0][36].ToString();
            yfjszt.Text = dt.Rows[0][37].ToString();

            Session.Remove("cgrkd");
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;
            try
            {
                dml.Add("@hth", hth.Text.Trim());
                dml.Add("@user_no", model.LoginUser);
                dml.Add("@mkmc", mkmc.Text.Trim());
                dml.Add("@gf", gf.Text.Trim());
                dml.Add("@xf", xf.Text.Trim());
                dml.Add("@wlmc", wlmc.Text.Trim());
                dml.Add("@mj", float.Parse(mj.Text.Trim()));
                dml.Add("@yshtbh", yshtbh.Text.Trim());
                dml.Add("@cycd", cycd.Text.Trim());
                dml.Add("@zcbdh", zcbdh.Text.Trim());
                dml.Add("@tmdh", tmdh.Text.Trim());
                dml.Add("@zcrq", Convert.ToDateTime(zcrq.Text.Trim()));
                dml.Add("@ch", ch.Text.Trim());
                dml.Add("@zcmz", float.Parse(zcmz.Text.Trim()));
                dml.Add("@zcpz", float.Parse(zcpz.Text.Trim()));
                dml.Add("@zcjz", float.Parse(zcjz.Text.Trim()));
                dml.Add("@jsmk", float.Parse(jsmk.Text.Trim()));
                dml.Add("@rkrq", Convert.ToDateTime(rkrq.Text.Trim()));
                dml.Add("@rkbdh", rkbdh.Text.Trim());
                dml.Add("@rkmc", rkmc.Text.Trim());
                dml.Add("@rkmz", float.Parse(rkmz.Text.Trim()));
                dml.Add("@rkpz", float.Parse(rkpz.Text.Trim()));
                dml.Add("@rkjz", float.Parse(rkjz.Text.Trim()));
                dml.Add("@ksds", float.Parse(ksds.Text.Trim()));
                dml.Add("@yyds", float.Parse(yyds.Text.Trim()));
                dml.Add("@yslhbz", float.Parse(yslhbz.Text.Trim()));
                dml.Add("@kkbz", float.Parse(kkbz.Text.Trim()));
                dml.Add("@kkds", float.Parse(kkds.Text.Trim()));
                dml.Add("@kkje", float.Parse(kkje.Text.Trim()));
                dml.Add("@yfjsdw", float.Parse(yfjsdw.Text.Trim()));
                dml.Add("@yj", float.Parse(yj.Text.Trim()));
                dml.Add("@yfyf", float.Parse(yfyf.Text.Trim()));
                dml.Add("@yfyk", float.Parse(yfyk.Text.Trim()));
                dml.Add("@fkzh", float.Parse(fkzh.Text.Trim()));
                dml.Add("@jsyf", float.Parse(jsyf.Text.Trim()));
                dml.Add("@zfzh", zfzh.Text.Trim());
                dml.Add("@shzt", shzt.Text.Trim());
                dml.Add("@yfjszt", yfjszt.Text.Trim());
            }
            catch
            {
                AlertMessage("数据存在错误，请检查");
                return;
            }




            if (_htglLogic.InsertCgrkd(dml))
            {
                //     AlertMessageAndGoTo("新增成功", "Cght.aspx");
                AlertMessage("新增成功");
                //  xsPage.RefreshPage();
            }
            //dml.Add("@dzdje", StrToFloat(dzdje.Text.Trim()));
            //dml.Add("@skje", StrToFloat(skje.Text.Trim()));
            //dml.Add("@kpje", StrToFloat(kpje.Text.Trim()));
            //dml.Add("@gsjy", StrToFloat(gsjy.Text.Trim()));
            //dml.Add("@kphsksj", Convert.ToDateTime(kphsksj.Text));
        }
    }
}