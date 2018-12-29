using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using xsFramework.UserControl.Pager;
using xsFramework.Web.WebPage;
using XSSystem.Class;
using XSSystem.Logic;

namespace XSSystem.Page.P_SCGL
{
    public partial class RsclrGl : AuthWebPage
    {
        CWGLLogic _cwglLogic = new CWGLLogic();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                xsPage.StartShowPage();
               // qdfwQ.Text = DateTime.Now.AddDays(-30.00).ToShortDateString();
               // qdfwZ.Text = DateTime.Now.ToShortDateString();
            }
        }

        protected void xsPage_PageChanged(object sender, PageChangedEventArgs e)
        {


            //if (!"G001".Equals(LoginUser.LoginUserGroup))
            //{
            //    gvUser.Columns[2].Visible = false;
            //}
            QueryClass2 qc = new QueryClass2();
            // qc.gfmc = tbgfmc.Text.Trim();
            //qc.xfmc = tbxfmc.Text.Trim();
            //qc.mkmc = tbmkmc.Text.Trim();
            qc.all = 1;
            GridOrder.DataSource = SelectSQL(qc, e);
            GridOrder.DataBind();
        }

        protected DataTable ddlbind(object bh)
        {
            PagerParameter pagepara = new PagerParameter();
            pagepara.DbConn = GlabalString.DBString;
            pagepara.XsPager = xsPage;

            pagepara.Sql = _cwglLogic.QueryRsclrScxxOrder(bh.ToString());
            pagepara.OrderBy = "mzsl";
            PageChangedEventArgs e = new PageChangedEventArgs(1);
            return xsPageHelper.BindPager(pagepara, e);
        }

        protected DataTable ddl2bind(object bh)
        {
            PagerParameter pagepara = new PagerParameter();
            pagepara.DbConn = GlabalString.DBString;
            pagepara.XsPager = xsPage;

            pagepara.Sql = _cwglLogic.QueryRsclrCcxxOrder(bh.ToString());
            pagepara.OrderBy = "ccsl";
            PageChangedEventArgs e = new PageChangedEventArgs(1);
            return xsPageHelper.BindPager(pagepara, e);
        }


        DataTable SelectSQL(QueryClass2 qc, PageChangedEventArgs e)
        {
            PagerParameter pagepara = new PagerParameter();


            pagepara.DbConn = GlabalString.DBString;
            pagepara.XsPager = xsPage;         
            pagepara.Sql = _cwglLogic.QueryRsclrOrder(qc);
            pagepara.OrderBy = "bh";
            return xsPageHelper.BindPager(pagepara, e);
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            QueryClass2 qc = new QueryClass2();
            qc.all = 0;
            qc.bh = (sender as Button).CommandArgument;
            PageChangedEventArgs ex = new PageChangedEventArgs(1);
            DataTable dt = SelectSQL(qc, ex);
            Session["rsclr"] = dt;
            JavaScript("window.location.href='Rsclr.aspx'");
        }
    }
}