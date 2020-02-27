using System;
using System.Data;
using Telerik.Web.UI;
using xs_System.Logic;
using xsFramework.Web.Login;
using xsFramework.Web.WebPage;

namespace XSSystem.Page.P_Order
{
    public partial class Qyxsckd : AuthWebPage
    {
        HTGLLogic _htglLogic = new HTGLLogic();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropListInit();
                if (Session["qyxsckd"] != null)
                {
                    InitData(Session["qyxsckd"]);
                }
                if (Session["qykhhdlr"] != null)
                {
                    InitData2(Session["qykhhdlr"]);
                }

            }
        }

        void InitData2(object mk)
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
            yfjszt_droplist.Text = dt.Rows[0][22].ToString();
            shzt_droplist.Text = dt.Rows[0][23].ToString();
            Session.Remove("qykhhdlr");
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

            dt = GlabalString.GetCangKu();
            if (dt.Rows.Count != 0)
            {
                foreach (DataRow val in dt.Rows)
                {
                    radcbItem = new RadComboBoxItem(val[0].ToString());
                    tk_fmmc.Items.Add(radcbItem);
                }
                tk_fmmc.SelectedIndex = 1;
            }

            dt = GlabalString.GetMZMC();
            if (dt.Rows.Count != 0)
            {
                foreach (DataRow val in dt.Rows)
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
                    radcbItem2 = new RadComboBoxItem(val[0].ToString());
                    tk_fkzh.Items.Add(radcbItem2);
                }
                tk_fkzh.SelectedIndex = 1;
            }
        }

        void InitData(object mk)
        {
            DataTable dt = mk as DataTable;
            ckbdh.Text = dt.Rows[0][1].ToString();
            htbh.Text = dt.Rows[0][2].ToString();
            zcsj.Text = dt.Rows[0][3].ToString();
            tk_fmmc.Text = dt.Rows[0][4].ToString();
            tk_gf.Text = dt.Rows[0][5].ToString();

            tk_xf.Text = dt.Rows[0][6].ToString();
            ch.Text = dt.Rows[0][7].ToString();
            jsy.Text = dt.Rows[0][8].ToString();
            lxdh.Text = dt.Rows[0][9].ToString();
            tk_wlmc.Text = dt.Rows[0][10].ToString();

            ckmz.Text = dt.Rows[0][11].ToString();
            ckpz.Text = dt.Rows[0][12].ToString();
            jbds.Text = dt.Rows[0][13].ToString();
            ckjz1.Text = dt.Rows[0][14].ToString();
            ckjz2.Text = dt.Rows[0][15].ToString();

            mj.Text = dt.Rows[0][16].ToString();
            hkgsje.Text = dt.Rows[0][17].ToString();
            yfyk.Text = dt.Rows[0][18].ToString();
            yj.Text = dt.Rows[0][19].ToString();
            tk_fkzh.Text = dt.Rows[0][20].ToString();
            Session.Remove("qyxsckd");
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
                dml.Add("@user_no", model.LoginUser);
                dml.Add("@ckbdh", ckbdh.Text.Trim());
                dml.Add("@htbh", htbh.Text.Trim());
                dml.Add("@zcsj", Convert.ToDateTime(zcsj.Text.Trim()));
                dml.Add("@fmmc", tk_fmmc.Text.Trim());
                dml.Add("@gf", tk_gf.Text.Trim());
                dml.Add("@xf", tk_xf.Text.Trim());
                dml.Add("@ch", ch.Text.Trim());
                dml.Add("@jsy", jsy.Text.Trim());
                dml.Add("@lxdh", lxdh.Text.Trim());
                dml.Add("@wlmc", tk_wlmc.Text.Trim());
                dml.Add("@ckmz", float.Parse(ckmz.Text.Trim()));
                dml.Add("@ckpz", float.Parse(ckpz.Text.Trim()));
                dml.Add("@jbds", float.Parse(jbds.Text.Trim()));
                dml.Add("@ckjz1", float.Parse(ckjz1.Text.Trim()));
                dml.Add("@ckjz2", float.Parse(ckjz2.Text.Trim()));
                dml.Add("@mj", float.Parse(mj.Text.Trim()));
                dml.Add("@hkgsje", float.Parse(hkgsje.Text.Trim()));
                dml.Add("@yj", float.Parse(yj.Text.Trim()));
                dml.Add("@yfyk", float.Parse(yfyk.Text.Trim()));
                dml.Add("@fkzh", tk_fkzh.Text.Trim());
            }
            catch
            {
                AlertMessage("数据存在错误，请检查");
                return;
            }
            if (_htglLogic.InsertQyxsckd(dml))
            {
                //     AlertMessageAndGoTo("新增成功", "Cght.aspx");
                AlertMessage("新增成功");
                //  xsPage.RefreshPage();
            }
            else
            {
                AlertMessage("数据已存在，新增失败");
            }
        }

        protected void submit2_Click(object sender, EventArgs e)
        {
            if (!DataChecked(2))
            {
                return;
            }
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;

            dml.Add("@user_no", model.LoginUser);
            dml.Add("@rkbdh", rkbdh.Text.Trim());
            dml.Add("@ckbdh", ckbdh.Text.Trim());
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
            dml.Add("@yfjszt", yfjszt_droplist.Text.Trim());
            dml.Add("@shzt", shzt_droplist.Text);
            if (_htglLogic.InsertQykhhdlr(dml))
            {
                AlertMessage("新增成功");
            }
            else
            {
                AlertMessage("记录有误，新增失败");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!CalDataChecked(1))
            {
                return;
            }
            ckjz1.Text = Sub(ckmz.Text, ckpz.Text);
            ckjz2.Text = Sub(ckjz1.Text, jbds.Text);
            hkgsje.Text = Mul(ckjz2.Text, mj.Text);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (!CalDataChecked(1))
            {
                return;
            }
            if (!CalDataChecked(2))
            {
                return;
            }
            rkjz.Text = Sub(rkmz.Text, rkpz.Text);
            if (IsCal.Checked)
            {
                yfhllh.Text = Mul(ckjz2.Text, percent.Text);
            }
            else if (string.IsNullOrEmpty(yfhllh.Text))
            {
                AlertMessage("运输合理路耗不能为空！");
                yfhllh.Focus();
                return;
            }
            //yflhbz.Text = mj.Text;
            ksds.Text = AbsSub(ckjz2.Text, rkjz.Text);
            yyds.Text = Sub(rkjz.Text, ckjz2.Text);
            yfkkds.Text = Sub(ksds.Text, yfhllh.Text);
            yfkkje.Text = Mul(yflhbz.Text, yfkkds.Text);
            yfjsdw.Text = double.Parse(ckjz2.Text) >= double.Parse(rkjz.Text) ? rkjz.Text : ckjz2.Text;
            yfyf.Text = Sub(Mul(yfjsdw.Text, yj.Text), yfkkje.Text);

            jsyf.Text = Sub(Sub(yfyf.Text, yfyk.Text), fykk.Text);

            hkjsdw.Text = Sub(rkjz.Text, kd.Text);
            jshk.Text = Mul(hkjsdw.Text, mj.Text);
            tcje.Text = Mul(hkjsdw.Text, tcbz.Text);
            return;
        }

        protected void close_Click(object sender, EventArgs e)
        {
            JavaScript("window.location.href='QyxsckdGl.aspx'");
        }

        protected void updateCkd_Click(object sender, EventArgs e)
        {
            if (!DataChecked(1))
            {
                return;
            }
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;
            try
            {
                dml.Add("@user_no", model.LoginUser);
                dml.Add("@ckbdh", ckbdh.Text.Trim());
                dml.Add("@htbh", htbh.Text.Trim());
                dml.Add("@zcsj", Convert.ToDateTime(zcsj.Text.Trim()));
                dml.Add("@fmmc", tk_fmmc.Text.Trim());
                dml.Add("@gf", tk_gf.Text.Trim());
                dml.Add("@xf", tk_xf.Text.Trim());
                dml.Add("@ch", ch.Text.Trim());
                dml.Add("@jsy", jsy.Text.Trim());
                dml.Add("@lxdh", lxdh.Text.Trim());
                dml.Add("@wlmc", tk_wlmc.Text.Trim());
                dml.Add("@ckmz", float.Parse(ckmz.Text.Trim()));
                dml.Add("@ckpz", float.Parse(ckpz.Text.Trim()));
                dml.Add("@jbds", float.Parse(jbds.Text.Trim()));
                dml.Add("@ckjz1", float.Parse(ckjz1.Text.Trim()));
                dml.Add("@ckjz2", float.Parse(ckjz2.Text.Trim()));
                dml.Add("@mj", float.Parse(mj.Text.Trim()));
                dml.Add("@hkgsje", float.Parse(hkgsje.Text.Trim()));
                dml.Add("@yj", float.Parse(yj.Text.Trim()));
                dml.Add("@yfyk", float.Parse(yfyk.Text.Trim()));
                dml.Add("@fkzh", tk_fkzh.Text.Trim());
                dml.Add("@rkbdh", rkbdh.Text.Trim());
            }
            catch
            {
                AlertMessage("数据存在错误，请检查");
                return;
            }
            var mess = _htglLogic.UpdateQyxsckd(dml);
            if (mess=="")
            {
                //     AlertMessageAndGoTo("新增成功", "Cght.aspx");
                AlertMessage("修改成功");
                //  xsPage.RefreshPage();
            }
            else
            {
                AlertMessage(mess);
            }
        }

        protected void updateHd_Click(object sender, EventArgs e)
        {
            if(!DataChecked(2))
            {
                return;
            }
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;

            dml.Add("@user_no", model.LoginUser);
            dml.Add("@rkbdh", rkbdh.Text.Trim());
            dml.Add("@ckbdh", ckbdh.Text.Trim());
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
            dml.Add("@yfjszt", yfjszt_droplist.Text);
            dml.Add("@shzt", shzt_droplist.Text);
            var mess = _htglLogic.UpdateQykhhdlr(dml);
            if (mess == "")
            {
                AlertMessage("修改成功");
            }
            else
            {
                AlertMessage(mess);
            }
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_hd.Checked)
            {
                rkbdh.Text = ckbdh.Text;
                rksj.Text = DateTime.Now.ToString("yyyy-MM-dd");
                rkmz.Text = ckmz.Text;
                rkpz.Text = ckpz.Text;
                kd.Text = "0";
                yfhllh.Text = "0";
                yflhbz.Text = "0";
                fykk.Text = "0";
                tcbz.Text = "0";
                jshk.Text = hkgsje.Text;
                tcje.Focus();
            }
        }
    }
}