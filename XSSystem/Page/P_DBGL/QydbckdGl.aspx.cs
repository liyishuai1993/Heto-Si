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

namespace XSSystem.Page.P_DBGL
{
    public partial class QydbckdGl : AuthWebPage
    {
        HTGLLogic _htglLogic = new HTGLLogic();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                qdfwQ.Text = DateTime.Now.AddMonths(-6).ToShortDateString();
                qdfwZ.Text = DateTime.Now.AddMonths(6).ToShortDateString();
                xsPage.StartShowPage();
            }


        }

        protected void xsPage_PageChanged(object sender, PageChangedEventArgs e)
        {

            QueryClass qc = new QueryClass();
            qc.tableName = "xs_QydbckdTable";
            qc.ckbdh = tbckbdh.Text.Trim();
            if(qdfwQ.Text!="")
                qc.qdrqQ = Convert.ToDateTime(qdfwQ.Text.Trim());
            if(qdfwZ.Text!="")
                qc.qdrqZ = Convert.ToDateTime(qdfwZ.Text.Trim());
           // qc.gfmc = tbgfmc.Text.Trim();
            qc.wlmc = tbwlmc.Text.Trim();
            qc.fmmc = tbfmmc.Text.Trim();
            qc.ch = tbch.Text.Trim();
            if (tbckjz.Text.Trim() != "")
                qc.ckjz = float.Parse(tbckjz.Text.Trim());

            //if (!"G001".Equals(LoginUser.LoginUserGroup))
            //{
            //    gvUser.Columns[2].Visible = false;
            //}
            GridOrder.DataSource = SelectSQL(qc, e,1);

            GridOrder.DataBind();
            

        }

        DataTable SelectSQL(QueryClass qc, PageChangedEventArgs e,int flag)
        {
            PagerParameter pagepara = new PagerParameter();


            pagepara.DbConn = GlabalString.DBString;
            pagepara.XsPager = xsPage;

            if (flag == 1)
            {
                pagepara.Sql = _htglLogic.QueryQydbckdOrder(qc);
                pagepara.OrderBy = "ckbdh";
            }
            else
            {
                pagepara.Sql = _htglLogic.QueryQydbhdOrder(qc);
                pagepara.OrderBy = "rkbdh";
            }

           
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
            if (_htglLogic.DeleteData(dml, "xs_QyxsckdTable","bh"))
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
             JavaScript("window.location.href='Qydbckd.aspx'");
           // Response.Redirect("'Cght.aspx");
        }
       // QydbckdClass qydbckdClass;
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            QueryClass qc = new QueryClass();
            string[] estr = (sender as Button).CommandArgument.ToString().Split(',');
            qc.ckbdh = estr[0];
            qc.rkbdh = estr[1];

            PageChangedEventArgs ex = new PageChangedEventArgs(1);
            DataTable dt = SelectSQL(qc, ex,1);
            DataTable dt2 = SelectSQL(qc, ex, 2);
            Session["qydbckd"] = dt;
            if (dt2.Rows.Count > 0)
            {
                Session["qydbhd"] = dt2;
            }
            JavaScript("window.location.href='Qydbckd.aspx'");
        }

        protected void btnViewHD_Click(object sender, EventArgs e)
        {
            QueryClass qc = new QueryClass();
            qc.rkbdh = (sender as Button).CommandArgument;

            PageChangedEventArgs ex = new PageChangedEventArgs(1);
            DataTable dt = SelectSQL(qc, ex, 2);
            if (dt.Rows.Count == 0)
            {
                AlertMessage("无对应客户回单");
            }
            else
            {
                Session["qydbhd"] = dt;
                JavaScript("window.location.href='Qydbhd.aspx'");
            }

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