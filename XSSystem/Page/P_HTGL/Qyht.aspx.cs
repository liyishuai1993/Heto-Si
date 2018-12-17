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

namespace XSSystem.Page.P_Order
{
    public partial class Qyht : AuthWebPage
    {
        HTGLLogic _htglLogic = new HTGLLogic();
        static DataTable dataTable;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                DropListInit();
                if (Session["qyht"] != null)
                {
                    InitData(Session["qyht"]);
                }
                // 
                InitDataTable();
                InitGridView();
            }
            
        }

        private void InitDataTable()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("bh", System.Type.GetType("System.Int32"));
            dataTable.Columns.Add("wlmc", System.Type.GetType("System.String"));
            dataTable.Columns.Add("qyd", System.Type.GetType("System.String"));
            dataTable.Columns.Add("mdd", System.Type.GetType("System.String"));
            dataTable.Columns.Add("yj", System.Type.GetType("System.Double"));
            dataTable.Columns.Add("yflhbz", System.Type.GetType("System.Double"));
            dataTable.Columns.Add("zxzt", System.Type.GetType("System.String"));
            dataTable.Columns.Add("bz", System.Type.GetType("System.String"));
            dataTable.Columns.Add("isadd", System.Type.GetType("System.Boolean"));
        }

        public void InitData(object mk)
        {
            DataTable dt = mk as DataTable;
            htbh.Text = dt.Rows[0][1].ToString();
            htlx.SelectedItem.Text = dt.Rows[0][2].ToString();
            qdrq.Text = dt.Rows[0][3].ToString();
            dfhth.Text = dt.Rows[0][4].ToString();
            wtf.SelectedItem.Text = dt.Rows[0][5].ToString();
            stf.SelectedItem.Text = dt.Rows[0][6].ToString();
            kplx.SelectedItem.Text = dt.Rows[0][7].ToString();
            zxqxQ.Text = dt.Rows[0][8].ToString();
            zxqxZ.Text = dt.Rows[0][9].ToString();

            Session.Remove("qyht");
        }



        public void InitGridView()
        {
            PagerParameter pagepara = new PagerParameter();
            pagepara.DbConn = GlabalString.DBString;
            QueryClass qc = new QueryClass();
            LoginModel model = Session["LoginModel"] as LoginModel;
            qc.user_no = model.LoginUser;
            qc.htbh = htbh.Text;
            qc.tableName = "xs_QyhtTable_Jgxx";
            pagepara.Sql = _htglLogic.QueryCghtChildTable(qc);
            pagepara.OrderBy = "htbh";
            PageChangedEventArgs e = new PageChangedEventArgs(0);
            dataTable= xsPageHelper.BindPager(pagepara, e);
            this.GridView1.DataSource = dataTable;
            this.GridView1.DataBind();
        }



        protected void submit_Click(object sender, EventArgs e)
        {
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;
            try
            {
                dml.Add("@htbh", htbh.Text.Trim());
                dml.Add("@userid", model.LoginUser);
                dml.Add("@htlx", htlx.SelectedItem.Text.Trim());
                dml.Add("@qdrq", Convert.ToDateTime(qdrq.Text.Trim()));//????
                dml.Add("@dfhth", dfhth.Text.Trim());
                dml.Add("@wtf", wtf.SelectedItem.Text.Trim());
                dml.Add("@stf", stf.SelectedItem.Text.Trim());
                dml.Add("@kplx", kplx.SelectedItem.Text.Trim());
                dml.Add("@zxqxQ", Convert.ToDateTime(zxqxQ.Text));
                dml.Add("@zxqxZ", Convert.ToDateTime(zxqxZ.Text));
            }
            catch
            {
                AlertMessage("数据存在错误，请检查");
                return;
            }
            

            List<DirModel> Child1 = new List<DirModel>();
            DirModel temp;
            foreach(DataRow val in dataTable.Rows)
            {
                if ((bool)val[8])
                {
                    temp = new DirModel();
                    temp.Add("@htbh", htbh.Text.Trim());
                    temp.Add("@user_no", model.LoginUser);
                    temp.Add("@wlmc", val[1]);
                    temp.Add("@qyd", val[2]);
                    temp.Add("@mdd", val[3]);
                    temp.Add("@yj", val[4]);
                    temp.Add("@yflhbz", val[5]);
                    temp.Add("@zxzt", val[6]);
                    temp.Add("@bz", val[7]);
                    Child1.Add(temp);
                }
            }

            if (_htglLogic.InsertQyht(dml,Child1))
            {
                AlertMessageAndGoTo("新增成功", "Qyht.aspx");
            }
        }

        protected void update_Click(object sender, EventArgs e)
        {
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;
            dml.Add("@htbh", htbh.Text.Trim());
            dml.Add("@userid", model.LoginUser);
            dml.Add("@htlx", htlx.SelectedItem.Text.Trim());
            dml.Add("@qdrq", Convert.ToDateTime(qdrq.Text.Trim()));//????
            dml.Add("@dfhth", dfhth.Text.Trim());
            dml.Add("@wtf", wtf.SelectedItem.Text.Trim());
            dml.Add("@stf", stf.SelectedItem.Text.Trim());
            dml.Add("@kplx", kplx.SelectedItem.Text.Trim());
            dml.Add("@zxqxQ", Convert.ToDateTime(zxqxQ.Text));
            dml.Add("@zxqxZ", Convert.ToDateTime(zxqxZ.Text));
            if (_htglLogic.UpdateQyht(dml))
            {
                AlertMessageAndGoTo("修改成功", "QyhtGl.aspx");
            }
        }

        protected void AddJgxx(object sender, EventArgs e)
        {
            //string shtbh = htbh.Text;
            //Response.Write("<script>window.showModelessDialog('QyhtJgxx.aspx?transmissionInfo=" + shtbh + "')</script>");
            DataRow dr = dataTable.NewRow();
            try
            {
                dr[0] = dataTable.Rows.Count + 1;
                dr[1] = wlmc.Text;
                dr[2] = qyd.Text;
                dr[3] = mdd.Text;
                dr[4] = double.Parse(yj.Text.Trim());
                dr[5] = double.Parse(yflhbz.Text.Trim());
                dr[6] = zxzt.Text;
                dr[7] = bz.Text;
                dr[8] = true;
            }
            catch
            {
                AlertMessage("数据存在错误，请检查");
                return;
            }
            
            dataTable.Rows.Add(dr);
            GridView1.DataSource = dataTable;
            GridView1.DataBind();
        }

        protected void DelJgxx(object sender, EventArgs e)
        {
            string shtbh = htbh.Text;
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;
            dml.Add("@bh", (sender as Button).CommandArgument);
            dml.Add("@htbh", shtbh);
            dml.Add("@user_no", model.LoginUser);
            if (_htglLogic.DeleteChildTable(dml, "xs_QyhtTable_Jgxx"))
            {
                AlertMessage("订单删除成功");

            }
            else AlertMessage("订单删除失败");
        }

        protected void btnShengHe_Click(object sender, EventArgs e)
        {
            DirModel dml = new DirModel();
            dml.Add("@htbh", htbh.Text.Trim());
            if (_htglLogic.ShengHeOrder(dml, "xs_QyhtTable"))
            {
                // AlertMessage("审核订单成功");
                AlertMessageAndGoTo("审核成功", "QyhtGl.aspx");
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
            if (_htglLogic.ZhiXingOrder(dml, "xs_QyhtTable"))
            {
                // AlertMessage("审核订单成功");
                AlertMessageAndGoTo("执行成功", "QyhtGl.aspx");
            }
            else
            {
                AlertMessage("执行订单失败");
            }
        }



        protected void DropListInit()
        {
            PagerParameter pagepara = new PagerParameter();
            QueryClass qc = new QueryClass();
            pagepara.DbConn = GlabalString.DBString;
            //pagepara.XsPager=
            HTGLLogic ht = new HTGLLogic();
            string[] arrList = new string[2];
            arrList[0] = "wtf";
            arrList[1] = "stf";
            pagepara.Sql = ht.QueryDropList("xs_QyhtTable", arrList);
            pagepara.OrderBy = "wtf";
            PageChangedEventArgs e = new PageChangedEventArgs(1);
            DataTable dt = xsPageHelper.BindPager(pagepara, e);
            if (dt.Rows.Count != 0)
            {
                wtf.DataSource = dt.DefaultView;
                wtf.DataTextField = dt.Columns[0].ToString();
                wtf.DataBind();
                stf.DataSource = dt.DefaultView;
                stf.DataTextField = dt.Columns[1].ToString();
                stf.DataBind();
            }
            htbh.Text = "HTQY" + DateTime.Now.ToString("yyyyMMdd") + "-"+dt.Rows.Count;
        }

    }
}