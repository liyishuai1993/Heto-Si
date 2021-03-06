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
        static DataTable dataTable;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                DropListInit();
                if (Session["zlht"] != null)
                {
                    InitData(Session["zlht"]);
                }
                InitDataTable();
                InitGridView();
            }

        }

        private void InitDataTable()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("bh", System.Type.GetType("System.Int32"));
            dataTable.Columns.Add("qsrq", System.Type.GetType("System.String"));
            dataTable.Columns.Add("zzrq", System.Type.GetType("System.String"));
            dataTable.Columns.Add("zj", System.Type.GetType("System.Double"));
            dataTable.Columns.Add("fktk", System.Type.GetType("System.String"));
            dataTable.Columns.Add("zxzt", System.Type.GetType("System.String"));
            dataTable.Columns.Add("bz", System.Type.GetType("System.String"));

        }

        public void InitData(object mk)
        {
            DataTable dt = mk as DataTable;
            htbh.Text = dt.Rows[0][1].ToString();
            htlx.SelectedItem.Text = dt.Rows[0][2].ToString();
            qdrq.Text = dt.Rows[0][3].ToString();
            czf.Text = dt.Rows[0][4].ToString();
            czf2.Text = dt.Rows[0][5].ToString();
            czdd.Text = dt.Rows[0][6].ToString();
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
            var temp= xsPageHelper.BindPager(pagepara, e);
            foreach (DataRow val in temp.Rows)
            {
                DataRow dr = dataTable.NewRow();
                dr[0] = val[2];
                dr[1] = val[3];
                dr[2] = val[4];
                dr[3] = val[5];
                dr[4] = val[6];
                dr[5] = val[7];
                dr[6] = val[8];
                dataTable.Rows.Add(dr);

            }
            this.GridView1.DataSource = dataTable;
            this.GridView1.DataBind();
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            if (!DataChecked(1))
            {
                return;
            }
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;
            try
            {
                dml.Add("@htbh", htbh.Text.Trim());// ??????
                dml.Add("@userid", model.LoginUser);
                dml.Add("@htlx", htlx.SelectedItem.Text.Trim());
                dml.Add("@qdrq", Convert.ToDateTime(qdrq.Text.Trim()));//????
                dml.Add("@czf", czf.SelectedItem.Text.Trim());
                dml.Add("@czf2", czf2.SelectedItem.Text.Trim());
                dml.Add("@czdd", czdd.SelectedItem.Text.Trim());
                dml.Add("@zlqxQ", Convert.ToDateTime(zlqxQ.Text));
                dml.Add("@zlqxZ", Convert.ToDateTime(zlqxZ.Text));
                dml.Add("@yj", int.Parse(yj.Text.Trim()));
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
                
                    temp = new DirModel();
                    temp.Add("@htbh", htbh.Text.Trim());
                    temp.Add("@user_no", model.LoginUser);
                    temp.Add("@qsrq", val[1]);
                    temp.Add("@zzrq", val[2]);
                    temp.Add("@zj", val[3]);
                    temp.Add("@fktk", val[4]);
                    temp.Add("@zxzt", val[5]);
                    temp.Add("@bz", val[6]);
                    Child1.Add(temp);
                
            }
            string reply = _htglLogic.InsertZlht(dml, Child1);
            if (reply == "")
            {
                GetBh();
                AlertMessage("新增成功");
            }
            else
            {
                AlertMessage(reply);
            }
        }

        protected void update_Click(object sender, EventArgs e)
        {
            if (!DataChecked(1))
            {
                return;
            }
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;
            try
            {
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
            }
            catch
            {
                AlertMessage("数据存在错误，请检查");
                return;
            }


            List<DirModel> Child1 = new List<DirModel>();
            DirModel temp;
            foreach (DataRow val in dataTable.Rows)
            {
                
                    temp = new DirModel();
                    temp.Add("@htbh", htbh.Text.Trim());
                    temp.Add("@user_no", model.LoginUser);
                    temp.Add("@qsrq", val[1]);
                    temp.Add("@zzrq", val[2]);
                    temp.Add("@zj", val[3]);
                    temp.Add("@fktk", val[4]);
                    temp.Add("@zxzt", val[5]);
                    temp.Add("@bz", val[6]);
                    Child1.Add(temp);

            }
            string reply = _htglLogic.UpdateZlht(dml, Child1);
            if (reply == "")
            {
                AlertMessage("修改成功");
            }
            else
            {
                AlertMessage(reply);
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
            //string shtbh = htbh.Text;
            //Response.Write("<script>window.showModelessDialog('ZlhtZjxx.aspx?transmissionInfo=" + shtbh + "')</script>");
            if (!DataChecked(2))
            {
                return;
            }
            DataRow dr = dataTable.NewRow();
            try
            {
                dr[0] = dataTable.Rows.Count;
                dr[1] = qsrq.Text;
                dr[2] = zzrq.Text;
                dr[3] = double.Parse(zj.Text.Trim());
                dr[4] = fktk.Text;
                dr[5] = zxzt.Text;
                dr[6] = bz.Text;
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
            string itemBh = (sender as Button).CommandArgument;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                if (dataTable.Rows[i][0].ToString().Equals(itemBh))
                {
                    dataTable.Rows.Remove(dataTable.Rows[i]);
                    break;
                }
                else
                {
                    continue;
                }
            }
            GridView1.DataSource = dataTable;
            GridView1.DataBind();
        }


        private void GetBh()
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
            DataTable dt = xsPageHelper.BindPager(pagepara);
            htbh.Text = "HTZL" + DateTime.Now.ToString("yyyyMMdd") + "-" + dt.Rows.Count;
        }

        protected void DropListInit()
        {

            GetBh();
            czf.DataSource = GlabalString.GetGongSi(1);
            czf.DataTextField = "wldw";
            czf.DataBind();

            czf2.DataSource = GlabalString.GetGongSi(2);
            czf2.DataTextField = "wldw";
            czf2.DataBind();

            czdd.DataSource = GlabalString.GetCangKu();
            czdd.DataTextField = "yl";
            czdd.DataBind();

            
        }

        protected void close_Click(object sender, EventArgs e)
        {
            JavaScript("window.location.href='ZlhtGl.aspx'");

        }
    }
}