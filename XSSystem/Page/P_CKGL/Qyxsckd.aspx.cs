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
        }

        void InitData(object mk)
        {
            DataTable dt = mk as DataTable;
            ckbdh.Text = dt.Rows[0][1].ToString();
            htbh.Text = dt.Rows[0][2].ToString();
            zcsj.Text = dt.Rows[0][3].ToString();
            tk_fmmc.SelectedItem.Text = dt.Rows[0][4].ToString();
            tk_gf.SelectedItem.Text = dt.Rows[0][5].ToString();

            tk_xf.SelectedItem.Text = dt.Rows[0][6].ToString();
            ch.Text = dt.Rows[0][7].ToString();
            jsy.Text = dt.Rows[0][8].ToString();
            lxdh.Text = dt.Rows[0][9].ToString();
            wlmc.Text = dt.Rows[0][10].ToString();

            ckmz.Text = dt.Rows[0][11].ToString();
            ckpz.Text = dt.Rows[0][12].ToString();
            jbds.Text = dt.Rows[0][13].ToString();
            ckjz1.Text = dt.Rows[0][14].ToString();
            ckjz2.Text = dt.Rows[0][15].ToString();

            mj.Text = dt.Rows[0][16].ToString();
            hkgsje.Text = dt.Rows[0][17].ToString();
            yfyk.Text = dt.Rows[0][18].ToString();
            yj.Text = dt.Rows[0][19].ToString();
            fkzh.Text = dt.Rows[0][20].ToString();
            Session.Remove("qyxsckd");
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;
            try
            {
                dml.Add("@user_no", model.LoginUser);
                dml.Add("@ckbdh", ckbdh.Text.Trim());
                dml.Add("@htbh", htbh.Text.Trim());
                dml.Add("@zcsj", Convert.ToDateTime(zcsj.Text.Trim()));
                dml.Add("@fmmc", tk_fmmc.SelectedItem.Text.Trim());
                dml.Add("@gf", tk_gf.SelectedItem.Text.Trim());
                dml.Add("@xf", tk_xf.SelectedItem.Text.Trim());
                dml.Add("@ch", ch.Text.Trim());
                dml.Add("@jsy", jsy.Text.Trim());
                dml.Add("@lxdh", lxdh.Text.Trim());
                dml.Add("@wlmc", wlmc.Text.Trim());
                dml.Add("@ckmz", float.Parse(ckmz.Text.Trim()));
                dml.Add("@ckpz", float.Parse(ckpz.Text.Trim()));
                dml.Add("@jbds", float.Parse(jbds.Text.Trim()));
                dml.Add("@ckjz1", float.Parse(ckjz1.Text.Trim()));
                dml.Add("@ckjz2", float.Parse(ckjz2.Text.Trim()));
                dml.Add("@mj", float.Parse(mj.Text.Trim()));
                dml.Add("@hkgsje", float.Parse(hkgsje.Text.Trim()));
                dml.Add("@yj", float.Parse(yj.Text.Trim()));
                dml.Add("@yfyk", float.Parse(yfyk.Text.Trim()));
                dml.Add("@fkzh", float.Parse(fkzh.Text.Trim()));
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
        }

        protected void submit2_Click(object sender, EventArgs e)
        {
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
            dml.Add("@yfjszt", yfyf.Text.Trim());
            dml.Add("@shzt", shzt.Text.Trim());
            if (_htglLogic.InsertQykhhdlr(dml))
            {
                AlertMessage("新增成功");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ckjz1.Text = Sub(ckmz.Text, ckpz.Text);
            ckjz2.Text = Sub(ckjz1.Text, jbds.Text);
            hkgsje.Text = Mul(ckjz2.Text, mj.Text);
            return;
        }
    }
}