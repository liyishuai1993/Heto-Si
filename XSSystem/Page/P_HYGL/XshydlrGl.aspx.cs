using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using xs_System.Logic;
using xsFramework.UserControl.Pager;
using xsFramework.Web.Login;
using xsFramework.Web.WebPage;
using XSSystem.Class;
using XSSystem.Logic;

namespace XSSystem.Page.P_SCGL
{
    public partial class XshydlrGl : AuthWebPage
    {
        CWGLLogic _cwglLogic = new CWGLLogic();
        HTGLLogic _htglLogic = new HTGLLogic();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
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
                qc.tableName = "XshydlrTbale";
                qc.selectedKey = sxtj.SelectedValue;
                qc.selectedItem = tjz.Text.Trim();
                qc.selectedTimeKey = "hyrq";

                GridOrder.DataSource = SelectSQL(qc, e);
                GridOrder.DataBind();
            }
            
        }

        DataTable SelectSQL(QueryClass qc, PageChangedEventArgs e)
        {
            PagerParameter pagepara = new PagerParameter();
            LoginModel model = Session["LoginModel"] as LoginModel;
            qc.user_no = model.LoginUser;

            pagepara.DbConn = GlabalString.DBString;
            pagepara.XsPager = xsPage;

            pagepara.Sql = _htglLogic.QueryHt2Order(qc);
            pagepara.OrderBy = "hydbh";
            return xsPageHelper.BindPager(pagepara, e);
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            QueryClass qc = new QueryClass();
            qc.selectedItem = (sender as Button).CommandArgument;
            qc.tableName = "XshydlrTbale";
            qc.selectedKey = "hydbh";
            qc.selectedTimeKey = "hyrq";
            qc.selectedCon = "or";
            PageChangedEventArgs ex = new PageChangedEventArgs(1);
            DataTable dt = SelectSQL(qc, ex);
            Session["xshyd"] = dt;
            JavaScript("window.location.href='Xshydlr.aspx'");
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            JavaScript("window.location.href='Xshydlr.aspx'");
            // Response.Redirect("'Cght.aspx");
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
            if (_htglLogic.DeleteData(dml, "XshydlrTbale", "hydbh"))
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
            qc.tableName = "XshydlrTbale";
            qc.selectedKey = "hydbh";
            qc.selectedTimeKey = "hyrq";
            qc.IsAll = 1;
            GridOrder.DataSource = SelectSQL(qc, ex);

            GridOrder.DataBind();
        }
    }
}