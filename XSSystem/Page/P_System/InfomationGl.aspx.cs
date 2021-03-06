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

namespace XSSystem.Page.P_System
{
    public partial class InfomationGl : AuthWebPage
    {
        HTGLLogic _htglLogic = new HTGLLogic();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Session["selectedItem"]= tjz.Text.Trim();
                // xsPage.StartShowPage();  
                //tjz.Text = Session["selectedItemCght"]?.ToString();
                //qdfwQ.Text = DateTime.Now.AddDays(-30.00).ToShortDateString();
                //qdfwZ.Text = DateTime.Now.ToShortDateString();
                SelectedAll(1);
            }
        }

        protected void xsPage_PageChanged(object sender, PageChangedEventArgs e)
        {
            //QueryClass qc = new QueryClass();
            //if (IsAll)
            //{
                SelectedAll(e.CurrentPage);
            //}
            //else
            //{
            //    qc.tableName = "xs_CghtTable";
            //    if (qdfwQ.Text != "")
            //        qc.qdrqQ = Convert.ToDateTime(qdfwQ.Text.Trim());
            //    if (qdfwZ.Text != "")
            //        qc.qdrqZ = Convert.ToDateTime(qdfwZ.Text.Trim());
            //    qc.selectedKey = sxtj.SelectedValue;
            //    qc.selectedItem = tjz.Text.Trim();
            //    qc.selectedCon = con.SelectedValue;



            //    //if (!"G001".Equals(LoginUser.LoginUserGroup))
            //    //{
            //    //    gvUser.Columns[2].Visible = false;
            //    //}
            //    GridOrder.DataSource = SelectSQL(qc, e);
            //    GridOrder.DataBind();
            //}
        }

        DataTable SelectSQL(QueryClass qc, PageChangedEventArgs e)
        {
            PagerParameter pagepara = new PagerParameter();
            pagepara.DbConn = GlabalString.DBString;
            pagepara.XsPager = xsPage;
            pagepara.Sql = _htglLogic.QueryInfomation(qc);
            pagepara.OrderBy = "nr";
            
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
            if (_htglLogic.DeleteData(dml, "xs_CghtTable", "htbh"))
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

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string str = "";
            DirModel dml = new DirModel();
            string[] ckb = null;

            str = Request.Form.Get("checkboxname");
            if (str == null)
            {
                AlertMessage("当前未选中对象");
                return;
            }
            ckb = str.Split(new char[] { ',' });



            dml.Add("@htbhArr", ckb);
            if (_htglLogic.DeleteData(dml, sxtj.SelectedItem.Value, "id"))
            {
                AlertMessage("删除成功");
            }
            else
            {
                AlertMessage("删除失败");
            }
            xsPage.RefreshPage();
        }


        protected void btnAdd_Click(object sender, EventArgs e)
        {
            JavaScript("window.location.href='InfomationInput.aspx'");
            // Response.Redirect("'Cght.aspx");
        }
        // CghtClass cghtClass;


        protected void btnQuery_Click(object sender, EventArgs e)
        {
            xsPage.RefreshPage();
        }


        protected void ddlnewtype_selectedindexchanged(object sender, EventArgs e)
        {
            xsPage.StartShowPage();
        }

        protected void allQuery_Click(object sender, EventArgs e)
        {
            SelectedAll(1);
        }

        private void SelectedAll(int page)
        {
            PageChangedEventArgs ex = new PageChangedEventArgs(page);
            QueryClass qc = new QueryClass();
            qc.tableName = sxtj.SelectedItem.Value;
            qc.IsAll = 1;
            GridOrder.DataSource = SelectSQL(qc, ex);
            GridOrder.DataBind();
        }
    }
}