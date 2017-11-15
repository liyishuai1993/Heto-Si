using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using xsFramework.UserControl.Pager;

namespace XSSystem.Page.P_Order
{
    public partial class CdxxSearch : System.Web.UI.Page
    {
        //LeaveLogic pageLogic = new LeaveLogic();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void xsPage_PageChanged(object sender, xsFramework.UserControl.Pager.PageChangedEventArgs e)
        {
            PagerParameter pagepara = new PagerParameter();
            pagepara.DbConn = GlabalString.DBString;
            pagepara.XsPager = xsPage;
            //pagepara.Sql = pageLogic.QueryLeave();
            //pagepara.OrderBy = "leave_time";
            //DataTable dt = xsPageHelper.BindPager(pagepara, e);
            //NoData.Visible = false;
            //if (dt.Rows.Count == 0)
            //{
            //    NoData.Visible = true;
            //}
            //else
            //{
            //    rptLeave.DataSource = dt;
            //    rptLeave.DataBind();
            //}

        }
    }
}