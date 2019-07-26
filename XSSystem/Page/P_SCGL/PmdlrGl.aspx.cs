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
using XSSystem.Logic;

namespace XSSystem.Page.P_SCGL
{
    public partial class PmdlrGl : AuthWebPage
    {
        CWGLLogic _cwglLogic = new CWGLLogic();
        HTGLLogic _htglLogic = new HTGLLogic();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // xsPage.StartShowPage();
                qdfwQ.Text = DateTime.Now.AddDays(-30.00).ToShortDateString();
                qdfwZ.Text = DateTime.Now.ToShortDateString();
                SelectedAll(1);
            }
        }

        protected void xsPage_PageChanged(object sender, PageChangedEventArgs e)
        {


            //if (!"G001".Equals(LoginUser.LoginUserGroup))
            //{
            //    gvUser.Columns[2].Visible = false;
            //}
            QueryClass qc = new QueryClass();
            if (string.IsNullOrEmpty(tjz.Text.Trim()))
            {
                SelectedAll(e.CurrentPage);
            }
            else
            {
                if (qdfwQ.Text != "")
                    qc.qdrqQ = Convert.ToDateTime(qdfwQ.Text.Trim());
                if (qdfwZ.Text != "")
                    qc.qdrqZ = Convert.ToDateTime(qdfwZ.Text.Trim());
                qc.tableName = "xs_PmdlrTable";
                qc.selectedKey = sxtj.SelectedValue;
                qc.selectedItem = tjz.Text.Trim();
                qc.selectedTimeKey = "pmrq";
                // qc.gfmc = tbgfmc.Text.Trim();
                //qc.xfmc = tbxfmc.Text.Trim();
                //qc.mkmc = tbmkmc.Text.Trim();
                GridOrder.DataSource = SelectSQL(qc, e);
                GridOrder.DataBind();
            }
        }

        protected DataTable ddlbind(object bh)
        {
            PagerParameter pagepara = new PagerParameter();
            pagepara.DbConn = GlabalString.DBString;
            pagepara.XsPager = xsPage;

            pagepara.Sql = _cwglLogic.QueryPmdlrScxxOrder(bh.ToString());
            pagepara.OrderBy = "mzsl";
            PageChangedEventArgs e = new PageChangedEventArgs(1);
            return xsPageHelper.BindPager(pagepara, e);
        }

        protected DataTable ddl2bind(object bh)
        {
            PagerParameter pagepara = new PagerParameter();
            pagepara.DbConn = GlabalString.DBString;
            pagepara.XsPager = xsPage;

            pagepara.Sql = _cwglLogic.QueryPmdlrCcxxOrder(bh.ToString());
            pagepara.OrderBy = "ccsl";
            PageChangedEventArgs e = new PageChangedEventArgs(1);
            return xsPageHelper.BindPager(pagepara, e);
        }

        DataTable SelectSQL(QueryClass qc, PageChangedEventArgs e)
        {
            PagerParameter pagepara = new PagerParameter();


            pagepara.DbConn = GlabalString.DBString;
            pagepara.XsPager = xsPage;

            pagepara.Sql = _htglLogic.QueryHt2Order(qc);
            pagepara.OrderBy = "bh";
            return xsPageHelper.BindPager(pagepara, e);
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            QueryClass qc = new QueryClass();
            qc.selectedItem = (sender as Button).CommandArgument;
            qc.tableName = "xs_PmdlrTable";
            qc.selectedKey = "bh";
            qc.selectedTimeKey = "pmrq";
            qc.selectedCon = "or";
            PageChangedEventArgs ex = new PageChangedEventArgs(1);
            DataTable dt = SelectSQL(qc, ex);
            Session["pmdlr"] = dt;
            JavaScript("window.location.href='Pmdlr.aspx'");
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
            if (_htglLogic.DeleteData(dml, "xs_PmdlrTable", "bh"))
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

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            JavaScript("window.location.href='Pmdlr.aspx'");
            // Response.Redirect("'Cght.aspx");
        }

        protected void btnQuery_Click(object sender, EventArgs e)
        {
            xsPage.RefreshPage();
        }


        protected void allQuery_Click(object sender, EventArgs e)
        {
            SelectedAll(1);
        }

        private void SelectedAll(int page)
        {
            PageChangedEventArgs ex = new PageChangedEventArgs(page);
            QueryClass qc = new QueryClass();
            qc.tableName = "xs_PmdlrTable";
            qc.selectedKey = "bh";
            qc.selectedTimeKey = "pmrq";
            qc.IsAll = 1;
            GridOrder.DataSource = SelectSQL(qc, ex);

            GridOrder.DataBind();
        }
    }
}