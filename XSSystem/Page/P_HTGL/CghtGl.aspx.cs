using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using xs_System.Logic;
using xsFramework.UserControl.Pager;
using xsFramework.Web.WebPage;
using XSSystem.Class;

namespace XSSystem.Page.P_HTGL
{
    public partial class CghtGl : AuthWebPage
    {
        HTGLLogic _htglLogic = new HTGLLogic();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                xsPage.StartShowPage();
            }


        }

        protected void xsPage_PageChanged(object sender, PageChangedEventArgs e)
        {
            PagerParameter pagepara = new PagerParameter();
            QueryClass qc = new QueryClass("xs_CghtTable", ddhtlx.SelectedValue, ddshzt.SelectedValue, qdfwQ.Text.Trim(), qdfwZ.Text.Trim());
            pagepara.DbConn = GlabalString.DBString;
            pagepara.XsPager = xsPage;
            pagepara.Sql = _htglLogic.QueryOrder(qc);
            pagepara.OrderBy = "htbh";

            //if (!"G001".Equals(LoginUser.LoginUserGroup))
            //{
            //    gvUser.Columns[2].Visible = false;
            //}
            GridOrder.DataSource = xsPageHelper.BindPager(pagepara, e);

            GridOrder.DataBind();

        }


        protected void btnDelete_Click(object sender, EventArgs e)
        {
            DirModel dml = new DirModel();
            dml.Add("@htbh", (sender as Button).CommandArgument);
            if (_htglLogic.DeleteUser(dml, "xs_CghtTable"))
            {
                AlertMessage("订单删除成功");
            }
            else
            {
                AlertMessage("订单删除失败");
            }
            xsPage.RefreshPage();
        }

        protected void btnShengHe_Click(object sender, EventArgs e)
        {
            DirModel dml = new DirModel();
            dml.Add("@htbh", (sender as Button).CommandArgument);
            if (_htglLogic.ShengHeOrder(dml, "xs_CghtTable")) 
            {
                AlertMessage("审核订单成功");
            }
            else 
            {
                AlertMessage("审核订单失败");
            }
            xsPage.RefreshPage();


        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
             JavaScript("window.location.href='Cght.aspx'");
           // Response.Redirect("'Cght.aspx");
        }


        protected void btnQuery_Click(object sender, EventArgs e)
        {
            xsPage.RefreshPage();
        }


        protected void ddlnewtype_selectedindexchanged(object sender, EventArgs e)
        {
            xsPage.StartShowPage();
        }
    }
}