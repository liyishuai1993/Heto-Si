﻿using System;
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

namespace XSSystem.Page.P_CKGL
{
    public partial class TyxsckdGl : AuthWebPage
    {
        HTGLLogic _htglLogic = new HTGLLogic();
        static bool IsAll = true;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //xsPage.StartShowPage();
                //qdfwQ.Text = DateTime.Now.AddDays(-30.00).ToShortDateString();
                tjz.Text = Session["selectedItemTyxsckd"]?.ToString();
                //qdfwZ.Text = DateTime.Now.ToShortDateString();
                SelectedAll(1);
            }


        }

        protected void xsPage_PageChanged(object sender, PageChangedEventArgs e)
        {
            QueryClass qc = new QueryClass();
            if (IsAll)
            {
                SelectedAll(e.CurrentPage);
            }
            else
            {
                qc.tableName = "xs_TyxsckdTable";
                //if (qdfwQ.Text != "")
                //    qc.qdrqQ = Convert.ToDateTime(qdfwQ.Text.Trim());
                //if (qdfwZ.Text != "")
                //    qc.qdrqZ = Convert.ToDateTime(qdfwZ.Text.Trim());
                qc.selectedKey = sxtj.SelectedValue;
                qc.selectedItem = tjz.Text.Trim();


                //if (!"G001".Equals(LoginUser.LoginUserGroup))
                //{
                //    gvUser.Columns[2].Visible = false;
                //}
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

            pagepara.Sql = _htglLogic.QueryHt3Order(qc);
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
            qc.selectedItem = (sender as Button).CommandArgument;
            qc.selectedKey = "bh";
            qc.tableName = "xs_TyxsckdTable";
            PageChangedEventArgs ex = new PageChangedEventArgs(1);
            DataTable dt = SelectSQL(qc, ex);
            Session["tyxsckd"] = dt;
            JavaScript("window.location.href='Tyxsckd.aspx'");
        }


        protected void btnQuery_Click(object sender, EventArgs e)
        {
            Session["selectedItemTyxsckd"] = tjz.Text.Trim();
            IsAll = false;
            xsPage.RefreshPage();
        }


        protected void ddlnewtype_selectedindexchanged(object sender, EventArgs e)
        {
            xsPage.StartShowPage();
        }

        protected void allQuery_Click(object sender, EventArgs e)
        {
            IsAll = true;
            SelectedAll(1);
        }

        private void SelectedAll(int page)
        {
            PageChangedEventArgs ex = new PageChangedEventArgs(page);
            QueryClass qc = new QueryClass();
            qc.tableName = "xs_TyxsckdTable";
            qc.selectedKey = "bh";
            qc.IsAll = 1;
            GridOrder.DataSource = SelectSQL(qc, ex);

            GridOrder.DataBind();
        }

        protected void Tj_Btn_Click(object sender, EventArgs e)
        {
            List<DirModel> list = new List<DirModel>();
            LoginModel model = Session["LoginModel"] as LoginModel;
            DirModel temp;
            string str = "";
            string[] ckb = null;


            str = Request.Form.Get("checkboxname");
            if (str == null)
            {
                AlertMessage("当前未选中订单");
                return;
            }
            ckb = str.Split(new char[] { ',' });

            foreach (var val in ckb)
            {
                temp = new DirModel();
                temp.Add("@user_no", model.LoginUser);
                temp.Add("@key", val);
                temp.Add("@zxj", tj.Text.Trim());
                list.Add(temp);
            }
            var reply = _htglLogic.UpdatePrice("xs_TyxsckdTable", "bh", "mj", list);
            if (reply == "")
            {
                xsPage.RefreshPage();
                AlertMessage("改价成功！");
            }
            else
            {
                AlertMessage(reply);
            }
        }
    }
}