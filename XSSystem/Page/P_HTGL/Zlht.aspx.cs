﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using xsFramework.Web.WebPage;
using xsFramework.Web.Login;
using xs_System.Logic;
using xsFramework.UserControl.Pager;
using XSSystem.Class;

namespace XSSystem.Page.P_Order
{
    public partial class Zlht : AuthWebPage
    {
        HTGLLogic _htglLogic = new HTGLLogic();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                DropListInit();
                if (Session["zlht"] != null)
                {
                    InitData(Session["zlht"]);
                }
                InitGridView();
            }

        }

        public void InitData(object mk)
        {
            DataTable dt = mk as DataTable;
            htbh.Text = dt.Rows[0][1].ToString();
            htlx.SelectedItem.Text = dt.Rows[0][2].ToString();
            qdrq.Text = dt.Rows[0][3].ToString();
            czf.SelectedItem.Text = dt.Rows[0][4].ToString();
            czf2.SelectedItem.Text = dt.Rows[0][5].ToString();
            czdd.SelectedItem.Text = dt.Rows[0][6].ToString();
            zlqxQ.Text = dt.Rows[0][7].ToString();
            zlqxZ.Text = dt.Rows[0][8].ToString();
            yj.Text = dt.Rows[0][9].ToString();
            Session.Remove("zlht");
        }

        public void InitGridView()
        {
            PagerParameter pagepara = new PagerParameter();
            pagepara.DbConn = GlabalString.DBString;
            QueryClass qc = new QueryClass();
            LoginModel model = Session["LoginModel"] as LoginModel;
            qc.user_no = model.LoginUser;
            qc.htbh = htbh.Text;
            qc.tableName = "xs_ZlhtTable_Zjxx";
            pagepara.Sql = _htglLogic.QueryCghtChildTable(qc);
            pagepara.OrderBy = "htbh";

            PageChangedEventArgs e = new PageChangedEventArgs(0);
            this.GridView1.DataSource = xsPageHelper.BindPager(pagepara, e);
            this.GridView1.DataBind();
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;
            dml.Add("@htbh", htbh.Text.Trim());// ??????
            dml.Add("@userid", model.LoginUser);
            dml.Add("@htlx", htlx.SelectedItem.Text.Trim());
            dml.Add("@qdrq", Convert.ToDateTime(qdrq.Text.Trim()));//????
            if (czf_xz.Text.Equals(""))
                dml.Add("@czf", czf.SelectedItem.Text.Trim());
            else
                dml.Add("@czf", czf_xz.Text.Trim());
            if (czf2_xz.Text.Equals(""))
                dml.Add("@czf2", czf2.SelectedItem.Text.Trim());
            else
                dml.Add("@czf2", czf2_xz.Text.Trim());
            if (czdd_xz.Text.Equals(""))
                dml.Add("@czdd", czdd.SelectedItem.Text.Trim());
            else
                dml.Add("@czdd", czdd_xz.Text.Trim());
           
            dml.Add("@zlqxQ", Convert.ToDateTime(zlqxQ.Text));
            dml.Add("@zlqxZ", Convert.ToDateTime(zlqxZ.Text));
            dml.Add("@yj", int.Parse(yj.Text.Trim()));


            if (_htglLogic.InsertZlht(dml))
            {
                AlertMessageAndGoTo("新增成功", "Zlht.aspx");
            }
        }

        protected void update_Click(object sender, EventArgs e)
        {
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;
            dml.Add("@htbh", htbh.Text.Trim());
            dml.Add("@userid", model.LoginUser);
            dml.Add("@htlx", htlx.SelectedItem.Text.Trim());
            dml.Add("@qdrq", Convert.ToDateTime(qdrq.Text.Trim()));
            dml.Add("@czf", czf.SelectedItem.Text.Trim());
            dml.Add("@czf2", czf2.SelectedItem.Text.Trim());
            dml.Add("@czdd", czdd.SelectedItem.Text.Trim());
            dml.Add("@zlqxQ", Convert.ToDateTime(zlqxQ.Text));
            dml.Add("@zlqxZ", Convert.ToDateTime(zlqxZ.Text));
            dml.Add("@yj", float.Parse(yj.Text.Trim()));


            if (_htglLogic.UpdateZlht(dml))
            {
                AlertMessageAndGoTo("修改成功", "ZlhtGl.aspx");
            }

        }

        protected void btnShengHe_Click(object sender, EventArgs e)
        {
            DirModel dml = new DirModel();
            dml.Add("@htbh", htbh.Text.Trim());
            if (_htglLogic.ShengHeOrder(dml, "xs_ZlhtTable"))
            {
                // AlertMessage("审核订单成功");
                AlertMessageAndGoTo("审核成功", "ZlhtGl.aspx");
            }
            else
            {
                AlertMessage("审核订单失败");
            }
        }

        protected void btnZhiXing_Click(object sender, EventArgs e)
        {
            DirModel dml = new DirModel();
            dml.Add("@htbh", htbh.Text.Trim());
            if (_htglLogic.ZhiXingOrder(dml, "xs_ZlhtTable"))
            {
                // AlertMessage("审核订单成功");
                AlertMessageAndGoTo("执行成功", "ZlhtGl.aspx");
            }
            else
            {
                AlertMessage("执行订单失败");
            }
        }

        protected void AddZjxx(object sender, EventArgs e)
        {
            string shtbh = htbh.Text;
            Response.Write("<script>window.showModelessDialog('ZlhtZjxx.aspx?transmissionInfo=" + shtbh + "')</script>");
        }

        protected void DelJgxx(object sender, EventArgs e)
        {
            string shtbh = htbh.Text;
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;
            dml.Add("@bh", (sender as Button).CommandArgument);
            dml.Add("@htbh", shtbh);
            dml.Add("@user_no", model.LoginUser);
            if (_htglLogic.DeleteChildTable(dml, "xs_ZlhtTable_Zjxx"))
            {
                AlertMessage("订单删除成功");

            }
            else AlertMessage("订单删除失败");
        }


        protected void DropListInit()
        {
            PagerParameter pagepara = new PagerParameter();
            QueryClass qc = new QueryClass();
            pagepara.DbConn = GlabalString.DBString;
            //pagepara.XsPager=
            HTGLLogic ht = new HTGLLogic();
            string[] arrList = new string[3];
            arrList[0] = "czf";
            arrList[1] = "czf2";
            arrList[2] = "czdd";
            pagepara.Sql = ht.QueryDropList("xs_ZlhtTable", arrList);
            pagepara.OrderBy = "czf";
            PageChangedEventArgs e = new PageChangedEventArgs(1);
            DataTable dt = xsPageHelper.BindPager(pagepara, e);
            if (dt.Rows.Count != 0)
            {
                czf.DataSource = dt.DefaultView;
                czf.DataTextField = dt.Columns[0].ToString();
                czf.DataBind();
                czf2.DataSource = dt.DefaultView;
                czf2.DataTextField = dt.Columns[1].ToString();
                czf2.DataBind();
                czdd.DataSource = dt.DefaultView;
                czdd.DataTextField = dt.Columns[0].ToString();
                czdd.DataBind();
            }
            htbh.Text = "HTZL" + DateTime.Now.ToString("yyyyMMdd") + "-" + dt.Rows.Count;
        }
    }
}