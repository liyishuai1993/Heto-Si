using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;
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
                DropListInit();
                if (Session["cgrkd"] != null)
                {
                    InitData(Session["cgrkd"]);
                }
            }
        }

        protected void DropListInit()
        {
            RadComboBoxItem radcbItem;
            RadComboBoxItem radcbItem2;
            DataTable dt = GlabalString.GetGongSi();
            if (dt.Rows.Count != 0)
            {

                foreach (DataRow val in dt.Rows)
                {
                    radcbItem = new RadComboBoxItem(val[0].ToString());
                    radcbItem2 = new RadComboBoxItem(val[0].ToString());
                    tk_gf.Items.Add(radcbItem);
                    tk_xf.Items.Add(radcbItem2);
                }
                tk_gf.SelectedIndex = 1;
                tk_xf.SelectedIndex = 1;
            }

            DataTable dt2 = GlabalString.GetMZMC();
            if (dt2.Rows.Count != 0)
            {

                foreach (DataRow val in dt2.Rows)
                {
                    radcbItem = new RadComboBoxItem(val[0].ToString());
                    tk_wlmc.Items.Add(radcbItem);
                }
                tk_wlmc.SelectedIndex = 1;
            }

            DataTable dt3 = GlabalString.zhDataTable;
            if (dt3.Rows.Count != 0)
            {

                foreach (DataRow val in dt3.Rows)
                {
                    radcbItem = new RadComboBoxItem(val[0].ToString());
                    radcbItem2 = new RadComboBoxItem(val[0].ToString());
                    tk_zfzh.Items.Add(radcbItem);
                    tk_fkzh.Items.Add(radcbItem2);
                }
                tk_zfzh.SelectedIndex = 1;
                tk_fkzh.SelectedIndex = 1;
            }

        }

        void InitData(object mk)
        {
            DataTable dt = mk as DataTable;
            tk_hth.SelectedItem.Text = dt.Rows[0][1].ToString();
            mkmc.Text = dt.Rows[0][2].ToString();
            tk_gf.SelectedItem.Text = dt.Rows[0][3].ToString();
            tk_xf.SelectedItem.Text = dt.Rows[0][4].ToString();
            tk_wlmc.Text = dt.Rows[0][5].ToString();

            mj.Text = dt.Rows[0][6].ToString();
            tk_yshtbh.SelectedItem.Text = dt.Rows[0][7].ToString();
            cycd.Text = dt.Rows[0][8].ToString();
            zcbdh.Text = dt.Rows[0][9].ToString();
            tmdh.Text = dt.Rows[0][10].ToString();

            zcrq.Text = dt.Rows[0][11].ToString();
            ch.Text = dt.Rows[0][12].ToString();

            zcmz.Text = dt.Rows[0][13].ToString();
            zcpz.Text = dt.Rows[0][14].ToString();
            zcjz.Text = dt.Rows[0][15].ToString();
            jsmk.Text = dt.Rows[0][16].ToString();
            rkrq.Text = dt.Rows[0][37].ToString();
            rkbdh.Text = dt.Rows[0][17].ToString();

            rkmc.Text = dt.Rows[0][18].ToString();
            rkmz.Text = dt.Rows[0][19].ToString();

            rkpz.Text = dt.Rows[0][20].ToString();
            rkjz.Text = dt.Rows[0][21].ToString();
            ksds.Text = dt.Rows[0][22].ToString();
            yyds.Text = dt.Rows[0][23].ToString();
            yslhbz.Text = dt.Rows[0][24].ToString();

            kkbz.Text = dt.Rows[0][25].ToString();
            kkds.Text = dt.Rows[0][26].ToString();

            kkje.Text = dt.Rows[0][27].ToString();
            yfjsdw.Text = dt.Rows[0][28].ToString();
            yj.Text = dt.Rows[0][29].ToString();
            yfyf.Text = dt.Rows[0][30].ToString();
            yfyk.Text = dt.Rows[0][31].ToString();

            tk_fkzh.Text = dt.Rows[0][32].ToString();
            jsyf.Text = dt.Rows[0][33].ToString();

            tk_zfzh.Text = dt.Rows[0][34].ToString();
            shzt.SelectedItem.Text = dt.Rows[0][35].ToString();
            yfjszt.SelectedItem.Text = dt.Rows[0][36].ToString();

            Session.Remove("cgrkd");
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            if (!DataChecked(1))
            {
                return;
            }
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;
            try
            {
                dml.Add("@hth", tk_hth.SelectedItem.Text.Trim());
                dml.Add("@user_no", model.LoginUser);
                dml.Add("@mkmc", mkmc.Text.Trim());
                dml.Add("@gf", tk_gf.SelectedItem.Text.Trim());
                dml.Add("@xf", tk_xf.SelectedItem.Text.Trim());
                dml.Add("@wlmc", tk_wlmc.SelectedItem.Text.Trim());
                dml.Add("@mj", float.Parse(mj.Text.Trim()));
                dml.Add("@yshtbh", tk_yshtbh.SelectedItem.Text.Trim());
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
                dml.Add("@fkzh", tk_fkzh.SelectedItem.Text.Trim());
                dml.Add("@jsyf", float.Parse(jsyf.Text.Trim()));
                dml.Add("@zfzh", tk_zfzh.SelectedItem.Text.Trim());
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
            else
            {
                AlertMessage("存在错误，新增失败");
            }
            //dml.Add("@dzdje", StrToFloat(dzdje.Text.Trim()));
            //dml.Add("@skje", StrToFloat(skje.Text.Trim()));
            //dml.Add("@kpje", StrToFloat(kpje.Text.Trim()));
            //dml.Add("@gsjy", StrToFloat(gsjy.Text.Trim()));
            //dml.Add("@kphsksj", Convert.ToDateTime(kphsksj.Text));
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!CalDataChecked(1))
            {
                return;
            }
            
            kkbz.Text = mj.Text;
            rkjz.Text = Sub(rkmz.Text, rkpz.Text);
            zcjz.Text = Sub(zcmz.Text, zcpz.Text);
            if (IsCal.Checked)
            {
                yslhbz.Text = Mul(zcjz.Text, percent.Text);
            }
            else if(string.IsNullOrEmpty(yslhbz.Text))
            {
                AlertMessage("运输路耗标准不能为空！");
                yslhbz.Focus();
                return;
            }
            jsmk.Text = Mul(zcjz.Text, mj.Text);
            ksds.Text = AbsSub(zcjz.Text, rkjz.Text);
            yyds.Text = Sub(rkjz.Text, zcjz.Text);
            kkds.Text = AbsSub(ksds.Text, yslhbz.Text);
            kkje.Text = Mul(kkbz.Text, kkds.Text);
            yfjsdw.Text = double.Parse(zcjz.Text) > double.Parse(rkjz.Text) ? rkjz.Text : zcjz.Text;
            yfyf.Text = Sub(Mul(yfjsdw.Text, yj.Text), kkje.Text);
            jsyf.Text = Sub(yfyf.Text, yfyk.Text);
            
            
            return;
        }

        protected void close_Click(object sender, EventArgs e)
        {
            JavaScript("window.location.href='CgrkdGl.aspx'");

        }

        protected void update_Click(object sender, EventArgs e)
        {
            if (!DataChecked(1))
            {
                return;
            }
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;
            try
            {
                dml.Add("@hth", tk_hth.Text.Trim());
                dml.Add("@user_no", model.LoginUser);
                dml.Add("@mkmc", mkmc.Text.Trim());
                dml.Add("@gf", tk_gf.SelectedItem.Text.Trim());
                dml.Add("@xf", tk_xf.SelectedItem.Text.Trim());
                dml.Add("@wlmc", tk_wlmc.SelectedItem.Text.Trim());
                dml.Add("@mj", float.Parse(mj.Text.Trim()));
                dml.Add("@yshtbh", tk_yshtbh.Text.Trim());
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
                dml.Add("@fkzh", tk_fkzh.SelectedItem.Text.Trim());
                dml.Add("@jsyf", float.Parse(jsyf.Text.Trim()));
                dml.Add("@zfzh", tk_zfzh.SelectedItem.Text.Trim());
                dml.Add("@shzt", shzt.Text.Trim());
                dml.Add("@yfjszt", yfjszt.Text.Trim());
            }
            catch
            {
                AlertMessage("数据存在错误，请检查");
                return;
            }



            string reply = _htglLogic.UpdateCgrkd(dml);
            if (reply == "")
            {
                //     AlertMessageAndGoTo("新增成功", "Cght.aspx");
                AlertMessage("修改成功");
                //  xsPage.RefreshPage();
            }
            else
            {
                AlertMessage(reply);
                return;
            }
        }
    }
}