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
    public partial class Qydbckd : AuthWebPage
    {
        HTGLLogic _htglLogic = new HTGLLogic();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropListInit();
                if (Session["qydbckd"] != null)
                {
                    InitData(Session["qydbckd"]);
                }
                if (Session["qydbhd"] != null)
                {
                    InitData2(Session["qydbhd"]);
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
                    tk_gsmc.Items.Add(radcbItem);
                }
                tk_gsmc.SelectedIndex = 1;
            }

            dt = GlabalString.GetCangKu();
            if (dt.Rows.Count != 0)
            {
                foreach (DataRow val in dt.Rows)
                {
                    radcbItem = new RadComboBoxItem(val[0].ToString());
                    radcbItem2 = new RadComboBoxItem(val[0].ToString());
                    tk_fmmc.Items.Add(radcbItem);
                    tk_smmc.Items.Add(radcbItem2);
                }
                tk_fmmc.SelectedIndex = 1;
                tk_smmc.SelectedIndex = 1;
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


        }

        void InitData2(object mk)
        {
            DataTable dt = mk as DataTable;
            rkbdh.Text = dt.Rows[0][1].ToString();
            rksj.Text = dt.Rows[0][2].ToString();
            tk_smmc.Text = dt.Rows[0][3].ToString();
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

        void InitData(object mk)
        {
            DataTable dt = mk as DataTable;
            bh.Text = dt.Rows[0][1].ToString();
            ckbdh.Text = dt.Rows[0][2].ToString();
            zcsj.Text = dt.Rows[0][3].ToString();
            tk_gsmc.SelectedItem.Text = dt.Rows[0][4].ToString();
            tk_fmmc.SelectedItem.Text = dt.Rows[0][5].ToString();

            ch.Text = dt.Rows[0][6].ToString();
            jsy.Text = dt.Rows[0][7].ToString();
            lxdh.Text = dt.Rows[0][8].ToString();
            tk_wlmc.Text = dt.Rows[0][9].ToString();
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
            if (!DataChecked(1))
            {
                return;
            }
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;
            try
            {
                dml.Add("@user_no", model.LoginUser);
                dml.Add("@bh", bh.Text.Trim());
                dml.Add("@ckbdh", ckbdh.Text.Trim());
                dml.Add("@zcsj", Convert.ToDateTime(zcsj.Text.Trim()));
                dml.Add("@gsmc", tk_gsmc.SelectedItem.Text.Trim());
                dml.Add("@fmmc", tk_fmmc.SelectedItem.Text.Trim());
                dml.Add("@ch", ch.Text.Trim());
                dml.Add("@jsy", jsy.Text.Trim());
                dml.Add("@lxdh", lxdh.Text.Trim());
                dml.Add("@wlmc", tk_wlmc.Text.Trim());
                dml.Add("@ckmz", float.Parse(ckmz.Text.Trim()));
                dml.Add("@ckpz", float.Parse(ckpz.Text.Trim()));
                dml.Add("@ckjz", float.Parse(ckjz.Text.Trim()));
                dml.Add("@dcmj", float.Parse(dcmj.Text.Trim()));
                dml.Add("@dbje", float.Parse(dbje.Text.Trim()));
                dml.Add("@yj", float.Parse(yj.Text.Trim()));
                dml.Add("@yfyk", float.Parse(yfyk.Text.Trim()));
                dml.Add("@fkzh", fkzh.Text.Trim());
            }
            catch
            {
                AlertMessage("数据存在错误，请检查");
                return;
            }
            if (_htglLogic.InsertQydbckd(dml))
            {
                AlertMessage("新增成功");
            }
        }

        protected void submit_Click2(object sender, EventArgs e)
        {
            if (!DataChecked(2))
            {
                return;
            }
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;
            try
            {
                dml.Add("@user_no", model.LoginUser);
                dml.Add("@rkbdh", rkbdh.Text.Trim());
                dml.Add("@ckbdh", ckbdh.Text.Trim());
                dml.Add("@rksj", Convert.ToDateTime(rksj.Text.Trim()));
                dml.Add("@smmc", tk_smmc.SelectedItem.Text.Trim());
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
            }
            catch
            {
                AlertMessage("数据存在错误，请检查");
                return;
            }
            if (_htglLogic.InsertQydbhd(dml))
            {
                AlertMessage("新增成功");
            }
            else
            {
                AlertMessage("新增失败");
            }
        }

        /// <summary>
        /// 计算回单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!CalDataChecked(1))
            {
                return;
            }
            yfkkbz.Text = dcmj.Text;
            rkjz.Text = Sub(rkmz.Text, rkpz.Text);
            if (IsCal.Checked)
            {
                yslhbz.Text = Mul(ckjz.Text, percent.Text);
            }
            else if (string.IsNullOrEmpty(yslhbz.Text))
            {
                AlertMessage("运输路耗标准不能为空！");
                yslhbz.Focus();
                return;
            }
            ksds.Text = AbsSub(ckjz.Text, rkjz.Text);
            yyds.Text = AbsSub(rkjz.Text, ckjz.Text);
            yfkkds.Text = Sub(ksds.Text, yslhbz.Text);
            yfkkje.Text = Mul(yfkkbz.Text, yfkkds.Text);
            yfjsdw.Text = double.Parse(ckjz.Text) >= double.Parse(rkjz.Text) ? rkjz.Text : ckjz.Text;
            yfyf.Text = Sub(Mul(yfjsdw.Text, yj.Text), yfkkje.Text);
            jsyf.Text = Sub(Sub(yfyf.Text, yfyk.Text),fykk.Text);
            drje.Text = Add(Mul(ckjz.Text, dcmj.Text), yfyf.Text);
            drmj.Text = Div(drje.Text, rkjz.Text);
            return;
        }

        /// <summary>
        /// 计算出库单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button2_Click(object sender, EventArgs e)
        {
            if (!CalDataChecked(2))
            {
                return;
            }
            
            ckjz.Text = Sub(ckmz.Text, ckpz.Text);
            dbje.Text = Mul(ckjz.Text, dcmj.Text);

            return;
        }

        protected void close_Click(object sender, EventArgs e)
        {
            JavaScript("window.location.href='QydbckdGl.aspx'");

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
                dml.Add("@bh", bh.Text.Trim());
                dml.Add("@ckbdh", ckbdh.Text.Trim());
                dml.Add("@zcsj", Convert.ToDateTime(zcsj.Text.Trim()));
                dml.Add("@gsmc", tk_gsmc.SelectedItem.Text.Trim());
                dml.Add("@fmmc", tk_fmmc.SelectedItem.Text.Trim());
                dml.Add("@ch", ch.Text.Trim());
                dml.Add("@jsy", jsy.Text.Trim());
                dml.Add("@lxdh", lxdh.Text.Trim());
                dml.Add("@wlmc", tk_wlmc.Text.Trim());
                dml.Add("@ckmz", float.Parse(ckmz.Text.Trim()));
                dml.Add("@ckpz", float.Parse(ckpz.Text.Trim()));
                dml.Add("@ckjz", float.Parse(ckjz.Text.Trim()));
                dml.Add("@dcmj", float.Parse(dcmj.Text.Trim()));
                dml.Add("@dbje", float.Parse(dbje.Text.Trim()));
                dml.Add("@yj", float.Parse(yj.Text.Trim()));
                dml.Add("@yfyk", float.Parse(yfyk.Text.Trim()));
                dml.Add("@fkzh", fkzh.Text.Trim());
                dml.Add("@rkbdh", rkbdh.Text.Trim());
            }
            catch
            {
                AlertMessage("数据存在错误，请检查");
                return;
            }
            var mess = _htglLogic.UpdateQydbckd(dml);
            if (mess == "")
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
            if (!DataChecked(2))
            {
                return;
            }
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;
            try
            {
                dml.Add("@user_no", model.LoginUser);
                dml.Add("@rkbdh", rkbdh.Text.Trim());
                dml.Add("@ckbdh", ckbdh.Text.Trim());
                dml.Add("@rksj", Convert.ToDateTime(rksj.Text.Trim()));
                dml.Add("@smmc", tk_smmc.SelectedItem.Text.Trim());
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
            }
            catch
            {
                AlertMessage("数据存在错误，请检查");
                return;
            }
            var mess = _htglLogic.UpdateQydbhd(dml);
            if (mess == "")
            {
                //     AlertMessageAndGoTo("新增成功", "Cght.aspx");
                AlertMessage("修改成功");
                //  xsPage.RefreshPage();
            }
            else
            {
                AlertMessage("修改失败");
            }
        }
    }
}