using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using xs_System.Logic;
using xsFramework.UserControl.Pager;
using xsFramework.Web.WebPage;
using XSSystem.Class;

namespace XSSystem.Page.P_MKZXGL
{
    public partial class MkzxzcdGl : AuthWebPage
    {
        HTGLLogic _htglLogic = new HTGLLogic();
        static bool IsAll = true;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               // xsPage.StartShowPage();
                SelectedAll(1);
                //  qdfwQ.Text = DateTime.Now.AddDays(-30.00).ToShortDateString();
                //  qdfwZ.Text = DateTime.Now.ToShortDateString();
            }
        }

        protected void xsPage_PageChanged(object sender, PageChangedEventArgs e)
        {
            QueryClass qc = new QueryClass();
            if (IsAll)
            {
                SelectedAll(e.CurrentPage);
            }
            else
            {
                qc.tableName = "xs_MkzxzcdTable";
                // qc.cghth = tbcghth.Text.Trim();
                if (zcrqfwQ.Text != "")
                    qc.qdrqQ = Convert.ToDateTime(zcrqfwQ.Text.Trim());
                if (zcrqfwZ.Text != "")
                    qc.qdrqZ = Convert.ToDateTime(zcrqfwZ.Text.Trim());
                qc.selectedKey = sxtj.SelectedValue;
                qc.selectedTimeKey = "zcsj";
                qc.selectedItem = tjz.Text.Trim();
                qc.selectedCon = con.SelectedValue;



                //if (!"G001".Equals(LoginUser.LoginUserGroup))
                //{
                //    gvUser.Columns[2].Visible = false;
                //}
                GridOrder.DataSource = SelectSQL(qc, e);

                GridOrder.DataBind();
            }
        }

        DataTable SelectSQL(QueryClass qc, PageChangedEventArgs e)
        {
            PagerParameter pagepara = new PagerParameter();


            pagepara.DbConn = GlabalString.DBString;
            pagepara.XsPager = xsPage;
            pagepara.Sql = _htglLogic.QueryHt2Order(qc);
            pagepara.OrderBy = "djbh";
            return xsPageHelper.BindPager(pagepara, e);
        }


        protected void btnDel_Click(object sender, EventArgs e)
        {
            string str = "";
            DirModel dml = new DirModel();
            string[] ckb = null;

            str = Request.Form.Get("checkboxname");
            if (str == null)
            {
                AlertMessage("当前未选中订单");
                return;
            }
            ckb = str.Split(new char[] { ',' });



            dml.Add("@htbhArr", ckb);
            if (_htglLogic.DeleteData(dml, "xs_MkzxzcdTable", "djbh"))
            {
                AlertMessage("订单删除成功");
            }
            else
            {
                AlertMessage("订单删除失败");
            }
            xsPage.RefreshPage();
            //    Response.Write("直接在页面中得到的值为：" + str + "<br>");

            // Response.Write("处理后存放在数组中，如下：<br>");
            //for (int i = 0; i < ckb.Length; i++)
            //{
            //    sql += ckb[i];
            //}
        }

   //     MkzxzcdClass mkzxzcdClass;
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            QueryClass qc = new QueryClass();
            qc.selectedItem = (sender as Button).CommandArgument;
            qc.tableName = "xs_MkzxzcdTable";
            qc.selectedKey = "djbh";
            qc.selectedTimeKey = "zcsj";
            qc.selectedCon = "or";
            PageChangedEventArgs ex = new PageChangedEventArgs(1);
            DataTable dt = SelectSQL(qc, ex);
            Session["mkzxzcd"] = dt;
            JavaScript("window.location.href='Mkzxzcd.aspx'");
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            JavaScript("window.location.href='Mkzxzcd.aspx'");
            // Response.Redirect("'Cght.aspx");
        }

        protected void btnQuery_Click(object sender, EventArgs e)
        {
            IsAll = false;
            xsPage.RefreshPage();
        }

        protected void allQuery_Click(object sender, EventArgs e)
        {
            IsAll = true;
            SelectedAll(1);
        }

        private void SelectedAll(int page)
        {
            PageChangedEventArgs ex = new PageChangedEventArgs(page);
            QueryClass qc = new QueryClass();
            qc.tableName = "xs_MkzxzcdTable";
            qc.selectedKey = "djbh";
            qc.selectedTimeKey = "zcsj";
            qc.IsAll = 1;
            GridOrder.DataSource = SelectSQL(qc, ex);

            GridOrder.DataBind();
        }

    }
}