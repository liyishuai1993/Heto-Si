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

namespace XSSystem.Page.P_CKGL
{
    public partial class QyxsckdGl : AuthWebPage
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
            qc.tableName = "xs_QyxsckdTable";
            qc.ckbdh = tbckbdh.Text.Trim();
            if(qdfwQ.Text!="")
                qc.qdrqQ = Convert.ToDateTime(qdfwQ.Text.Trim());
            if(qdfwZ.Text!="")
                qc.qdrqZ = Convert.ToDateTime(qdfwZ.Text.Trim());
            qc.xfmc = tbxf.Text.Trim();
            qc.ch = tbch.Text.Trim();
            //qc.mkmc = tbmkmc.Text.Trim();
            if (tbckjz2.Text.Trim()!="")
                qc.ckjz2 = float.Parse(tbckjz2.Text.Trim());
            if (tbmj.Text.Trim() != "")
                qc.mj = float.Parse(tbmj.Text.Trim());
            qc.fmmc = tbfmmc.Text.Trim();




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
                pagepara.Sql = _htglLogic.QueryQyxsckdOrder(qc);
                pagepara.OrderBy = "ckbdh";
            }
            else
            {
                pagepara.Sql = _htglLogic.QueryQykhhdlrOrder(qc);
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
            if (_htglLogic.DeleteData(dml, "xs_QyxsckdTable","ckbdh"))
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
             JavaScript("window.location.href='Qyxsckd.aspx'");
           // Response.Redirect("'Cght.aspx");
        }
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            QueryClass qc = new QueryClass();
            qc.ckbdh = (sender as Button).CommandArgument;
            PageChangedEventArgs ex = new PageChangedEventArgs(1);
            DataTable dt = SelectSQL(qc, ex,1);
            Session["qyxsckd"] = dt;
            JavaScript("window.location.href='Qyxsckd.aspx'");
        }

        protected void btnViewHD_Click(object sender, EventArgs e)
        {
            QueryClass qc = new QueryClass();
            qc.rkbdh= (sender as Button).CommandArgument;
            
            PageChangedEventArgs ex = new PageChangedEventArgs(1);
            DataTable dt = SelectSQL(qc, ex,2);
            if (dt.Rows.Count == 0)
            {
                AlertMessage("无对应客户回单");
            }
            else
            {
                Session["qykhhdlr"] = dt;
                JavaScript("window.location.href='Qykhhdlr.aspx'");
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