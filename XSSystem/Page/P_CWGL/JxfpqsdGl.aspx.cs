using System;
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

namespace XSSystem.Page.P_Order
{
    public partial class JxfpqsdGl : AuthWebPage
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

            GridOrder.DataSource = SelectSQL(qc, e);
            GridOrder.DataBind();
        }

        DataTable SelectSQL(QueryClass2 qc, PageChangedEventArgs e)
        {
            PagerParameter pagepara = new PagerParameter();


            pagepara.DbConn = GlabalString.DBString;
            pagepara.XsPager = xsPage;

            pagepara.Sql = _cwglLogic.QueryJxfpqsdOrder(qc);
            pagepara.OrderBy = "dh";
            return xsPageHelper.BindPager(pagepara, e);
        }
    }
}