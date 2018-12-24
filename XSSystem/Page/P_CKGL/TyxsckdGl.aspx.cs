﻿using System;
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
    public partial class TyxsckdGl : AuthWebPage
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
            qc.tableName = "xs_TyxsckdTable";
            if(qdfwQ.Text!="")
                qc.qdrqQ = Convert.ToDateTime(qdfwQ.Text.Trim());
            if(qdfwZ.Text!="")
                qc.qdrqZ = Convert.ToDateTime(qdfwZ.Text.Trim());
            qc.stf = tbstf.Text.Trim();
            qc.zcz = tbzcz.Text.Trim();
            qc.zdz = tbzdz.Text.Trim();
            qc.xh = tbxh.Text.Trim();
            


            //if (!"G001".Equals(LoginUser.LoginUserGroup))
            //{
            //    gvUser.Columns[2].Visible = false;
            //}
            GridOrder.DataSource = SelectSQL(qc,e);

            GridOrder.DataBind();
            

        }

        DataTable SelectSQL(QueryClass qc, PageChangedEventArgs e)
        {
            PagerParameter pagepara = new PagerParameter();


            pagepara.DbConn = GlabalString.DBString;
            pagepara.XsPager = xsPage;

            pagepara.Sql = _htglLogic.QueryTyxsckdOrder(qc);
            pagepara.OrderBy = "bh";
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
            if (_htglLogic.DeleteData(dml, "xs_TyxsckdTable","bh"))
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
             JavaScript("window.location.href='Tyxsckd.aspx'");
           // Response.Redirect("'Cght.aspx");
        }
        //TyxsckdClass tyxsckdClass;
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            QueryClass qc = new QueryClass();
            qc.htbh = (sender as Button).CommandArgument;
            PageChangedEventArgs ex = new PageChangedEventArgs(1);
            DataTable dt = SelectSQL(qc, ex);
            Session["tyxsckd"] = dt;
            JavaScript("window.location.href='Tyxsckd.aspx'");
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