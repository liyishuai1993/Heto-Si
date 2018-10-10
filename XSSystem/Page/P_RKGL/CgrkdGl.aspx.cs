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

namespace XSSystem.Page.P_RKGL
{
    public partial class CgrkdGl : AuthWebPage
    {
        HTGLLogic _htglLogic = new HTGLLogic();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                xsPage.StartShowPage();
                qdfwQ.Text = DateTime.Now.AddDays(-30.00).ToShortDateString();
                qdfwZ.Text = DateTime.Now.ToShortDateString();
            }
        }

        protected void xsPage_PageChanged(object sender, PageChangedEventArgs e)
        {
            QueryClass qc = new QueryClass();
            qc.tableName = "xs_CgrkdTable";
            qc.rkbdh = tbrkbdh.Text.Trim();
            if (qdfwQ.Text != "")
                qc.qdrqQ = Convert.ToDateTime(qdfwQ.Text.Trim());
            if (qdfwZ.Text != "")
                qc.qdrqZ = Convert.ToDateTime(qdfwZ.Text.Trim());
            qc.gfmc = tbgfmc.Text.Trim();
            if (tbmj.Text.Trim() != "")
                qc.mj = float.Parse(tbmj.Text.Trim());
            if (tbzcjz.Text.Trim() != "")
                qc.zcjz = float.Parse(tbzcjz.Text.Trim());
            if (tbrkjz.Text.Trim() != "")
                qc.rkjz = float.Parse(tbrkjz.Text.Trim());
            qc.wlmc = tbwlmc.Text.Trim();
            qc.ch = tbch.Text.Trim();
            qc.rkmc = tbrkmc.Text.Trim();


            //if (!"G001".Equals(LoginUser.LoginUserGroup))
            //{
            //    gvUser.Columns[2].Visible = false;
            //}
            GridOrder.DataSource = SelectSQL(qc, e);

            GridOrder.DataBind();


        }

        DataTable SelectSQL(QueryClass qc, PageChangedEventArgs e)
        {
            PagerParameter pagepara = new PagerParameter();


            pagepara.DbConn = GlabalString.DBString;
            pagepara.XsPager = xsPage;
            pagepara.Sql = _htglLogic.QueryCgrkd(qc);
            pagepara.OrderBy = "hth";
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
            if (_htglLogic.DeleteData(dml, "xs_CgrkdTable","hth"))
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
            JavaScript("window.location.href='Cgrkd.aspx'");
            // Response.Redirect("'Cght.aspx");
        }
       // CgrkdClass cgrkdClass;
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            QueryClass qc = new QueryClass();
            qc.hth = (sender as Button).CommandArgument;

            PageChangedEventArgs ex = new PageChangedEventArgs(1);
            DataTable dt = SelectSQL(qc, ex);
            Session["cgrkd"] = dt;
            JavaScript("window.location.href='Cgrkd.aspx'");
        }


        protected void btnQuery_Click(object sender, EventArgs e)
        {
            xsPage.RefreshPage();
        }
    }
}