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
    public partial class Xsht : AuthWebPage
    {
        HTGLLogic _htglLogic = new HTGLLogic();
        static DataTable Jgxx_dataTable;
        static DataTable Zlbz_dataTable;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropListInit();
                if (Session["xsht"] != null)
                {
                    InitData(Session["xsht"]);
                }
                
                InitDataTable();
                InitGridView();
                InitGridView2();
            }

        }

        public void InitData(object mk)
        {
            DataTable dt = mk as DataTable;
            htbh.Text = dt.Rows[0][1].ToString();
            htlx.SelectedItem.Text = dt.Rows[0][2].ToString();
            qdrq.Text = dt.Rows[0][3].ToString();
            dfhth.Text = dt.Rows[0][4].ToString();
            gfmc.SelectedItem.Text = dt.Rows[0][5].ToString();
            xfmc.SelectedItem.Text = dt.Rows[0][6].ToString();
            hkjsyj.SelectedItem.Text = dt.Rows[0][7].ToString();
            hklhlx.SelectedItem.Text = dt.Rows[0][8].ToString();
            hklhbz.Text = dt.Rows[0][9].ToString();
            kplx.SelectedItem.Text = dt.Rows[0][10].ToString();
            jhsjQ.Text = dt.Rows[0][11].ToString();
            jhsjZ.Text = dt.Rows[0][12].ToString();
            hkjsfs.SelectedItem.Text = dt.Rows[0][13].ToString();
            fhdd.SelectedItem.Text = dt.Rows[0][14].ToString();
            yffkfs.SelectedItem.Text = dt.Rows[0][15].ToString();
            mkmc.Text = dt.Rows[0][16].ToString();
            kzbz.SelectedItem.Text = dt.Rows[0][17].ToString();
            lxdh.Text = dt.Rows[0][18].ToString();
            bz.Text = dt.Rows[0][19].ToString();
            Session.Remove("xsht");
        }

        private void InitDataTable()
        {
            Jgxx_dataTable = new DataTable();
            Zlbz_dataTable = new DataTable();
            Jgxx_dataTable.Columns.Add("bh", Type.GetType("System.Int32"));
            Jgxx_dataTable.Columns.Add("mkmc", Type.GetType("System.String"));
            Jgxx_dataTable.Columns.Add("mzmc", Type.GetType("System.String"));
            Jgxx_dataTable.Columns.Add("frl", Type.GetType("System.Double"));
            Jgxx_dataTable.Columns.Add("lf", Type.GetType("System.Double"));
            Jgxx_dataTable.Columns.Add("kpmj", Type.GetType("System.Double"));
            Jgxx_dataTable.Columns.Add("htmj", Type.GetType("System.Double"));
            Jgxx_dataTable.Columns.Add("ksl", Type.GetType("System.Double"));
            Jgxx_dataTable.Columns.Add("qdds", Type.GetType("System.Double"));
            Jgxx_dataTable.Columns.Add("qdje", Type.GetType("System.Double"));
            Jgxx_dataTable.Columns.Add("zt", Type.GetType("System.String"));
            Jgxx_dataTable.Columns.Add("isadd", Type.GetType("System.Boolean"));

            Zlbz_dataTable.Columns.Add("bh", Type.GetType("System.Int32"));
            Zlbz_dataTable.Columns.Add("mz", Type.GetType("System.String"));
            Zlbz_dataTable.Columns.Add("ld", Type.GetType("System.Double"));
            Zlbz_dataTable.Columns.Add("hf", Type.GetType("System.Double"));
            Zlbz_dataTable.Columns.Add("hff", Type.GetType("System.Double"));
            Zlbz_dataTable.Columns.Add("gdt", Type.GetType("System.Double"));
            Zlbz_dataTable.Columns.Add("njzs", Type.GetType("System.Double"));
            Zlbz_dataTable.Columns.Add("sf", Type.GetType("System.Double"));
            Zlbz_dataTable.Columns.Add("tie", Type.GetType("System.Double"));
            Zlbz_dataTable.Columns.Add("lv", Type.GetType("System.Double"));
            Zlbz_dataTable.Columns.Add("gai", Type.GetType("System.String"));
            Zlbz_dataTable.Columns.Add("lin", Type.GetType("System.Double"));
            Zlbz_dataTable.Columns.Add("tai", Type.GetType("System.Double"));
            Zlbz_dataTable.Columns.Add("liu", Type.GetType("System.String"));
            Zlbz_dataTable.Columns.Add("isadd", Type.GetType("System.Boolean"));


        }

        public void InitGridView()
        {
            PagerParameter pagepara = new PagerParameter();
            pagepara.DbConn = GlabalString.DBString;
            QueryClass qc = new QueryClass();
            LoginModel model = Session["LoginModel"] as LoginModel;
            qc.user_no = model.LoginUser;
            qc.htbh = htbh.Text;
            qc.tableName = "xs_XshtTable_Zlbz";
            pagepara.Sql = _htglLogic.QueryCghtChildTable(qc);
            pagepara.OrderBy = "htbh";
            PageChangedEventArgs e = new PageChangedEventArgs(0);
            Zlbz_dataTable= xsPageHelper.BindPager(pagepara, e);
            this.GridView1.DataSource = Zlbz_dataTable;
            this.GridView1.DataBind();
        }


        public void InitGridView2()
        {
            PagerParameter pagepara = new PagerParameter();
            pagepara.DbConn = GlabalString.DBString;
            QueryClass qc = new QueryClass();
            LoginModel model = Session["LoginModel"] as LoginModel;
            qc.user_no = model.LoginUser;
            qc.htbh = htbh.Text;
            qc.tableName = "xs_XshtTable_Jgxx";
            pagepara.Sql = _htglLogic.QueryCghtChildTable(qc);
            pagepara.OrderBy = "htbh";

            PageChangedEventArgs e = new PageChangedEventArgs(0);
            Jgxx_dataTable= xsPageHelper.BindPager(pagepara, e);
            this.GridView2.DataSource = Jgxx_dataTable;
            this.GridView2.DataBind();



        }
        protected void submit_Click(object sender, EventArgs e)
        {
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;
            try
            {
                dml.Add("@htbh", htbh.Text.Trim());// ??????
                dml.Add("@userid", model.LoginUser);
                dml.Add("@htlx", htlx.SelectedItem.Text.Trim());
                dml.Add("@qdrq", Convert.ToDateTime(qdrq.Text.Trim()));//????
                dml.Add("@dfhth", dfhth.Text.Trim());
                dml.Add("@gfmc", gfmc.SelectedItem.Text.Trim());
                dml.Add("@xfmc", xfmc.SelectedItem.Text.Trim());
                dml.Add("@hkjsyj", hkjsyj.SelectedItem.Text.Trim());
                dml.Add("@hklhlx", hklhlx.SelectedItem.Text.Trim());
                dml.Add("@hklhbz", hklhbz.Text.Trim());
                dml.Add("@kpxx", kplx.SelectedItem.Text.Trim());
                dml.Add("@jhsjQ", Convert.ToDateTime(jhsjQ.Text));
                dml.Add("@jhsjZ", Convert.ToDateTime(jhsjZ.Text));
                dml.Add("@hkjsfs", hkjsfs.SelectedItem.Text.Trim());
                dml.Add("@fhdd", fhdd.SelectedItem.Text.Trim());
                dml.Add("@yffkfs", yffkfs.SelectedItem.Text.Trim());
                dml.Add("@mkmc", mkmc.Text.Trim());
                dml.Add("@kzbz", kzbz.SelectedItem.Text.Trim());
                dml.Add("@lxdh", lxdh.Text.Trim());
                dml.Add("@bz", bz.Text.Trim());
            }
            catch
            {
                AlertMessage("数据存在错误，请检查");
                return;
            }
            //封装子表数据
            List<DirModel> Child1 = new List<DirModel>();
            DirModel temp;
            foreach (DataRow val in Jgxx_dataTable.Rows)
            {
                if ((bool)val[11] == true)
                {
                    temp = new DirModel();
                    temp.Add("@htbh", htbh.Text.Trim());
                    temp.Add("@user_no", model.LoginUser);
                    temp.Add("@mkmc", val[1]);
                    temp.Add("@mzmc", val[2]);
                    temp.Add("@frl", val[3]);
                    temp.Add("@lf", val[4]);
                    temp.Add("@kpmj", val[5]);
                    temp.Add("@htmj", val[6]);
                    temp.Add("@ksl", val[7]);
                    temp.Add("@qdds", val[8]);
                    temp.Add("@qdje", val[9]);
                    temp.Add("@zt", val[10]);
                    Child1.Add(temp);
                }

            }

            List<DirModel> Child2 = new List<DirModel>();
            foreach (DataRow val in Zlbz_dataTable.Rows)
            {
                if ((bool)val[14] == true)
                {
                    temp = new DirModel();
                    temp.Add("@htbh", htbh.Text.Trim());
                    temp.Add("@user_no", model.LoginUser);
                    temp.Add("@mz", val[1]);
                    temp.Add("@ld", val[2]);
                    temp.Add("@hf", val[3]);
                    temp.Add("@hff", val[4]);
                    temp.Add("@gdt", val[5]);
                    temp.Add("@njzs", val[6]);
                    temp.Add("@sf", val[7]);
                    temp.Add("@tie", val[8]);
                    temp.Add("@lv", val[9]);
                    temp.Add("@gai", val[10]);
                    temp.Add("@lin", val[11]);
                    temp.Add("@tai", val[12]);
                    temp.Add("@liu", val[13]);
                    Child2.Add(temp);
                }

            }

            if (_htglLogic.InsertXsht(dml,Child1,Child2))
            {
                AlertMessage("新增成功");
            }
        }

        protected void update_Click(object sender, EventArgs e)
        {
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;
            dml.Add("@htbh", htbh.Text.Trim());// ??????
            dml.Add("@userid", model.LoginUser);
            dml.Add("@htlx", htlx.SelectedItem.Text.Trim());
            dml.Add("@qdrq", Convert.ToDateTime(qdrq.Text.Trim()));//????
            dml.Add("@dfhth", dfhth.Text.Trim());
            dml.Add("@gfmc", gfmc.SelectedItem.Text.Trim());
            dml.Add("@xfmc", xfmc.SelectedItem.Text.Trim());
            dml.Add("@hkjsyj", hkjsyj.SelectedItem.Text.Trim());
            dml.Add("@hklhlx", hklhlx.SelectedItem.Text.Trim());
            dml.Add("@hklhbz", hklhbz.Text.Trim());
            dml.Add("@kpxx", kplx.SelectedItem.Text.Trim());
            dml.Add("@jhsjQ", Convert.ToDateTime(jhsjQ.Text));
            dml.Add("@jhsjZ", Convert.ToDateTime(jhsjZ.Text));
            dml.Add("@hkjsfs", hkjsfs.SelectedItem.Text.Trim());
            dml.Add("@fhdd", fhdd.SelectedItem.Text.Trim());
            dml.Add("@yffkfs", yffkfs.SelectedItem.Text.Trim());
            dml.Add("@mkmc", mkmc.Text.Trim());
            dml.Add("@kzbz", kzbz.SelectedItem.Text.Trim());
            dml.Add("@lxdh", lxdh.Text.Trim());
            dml.Add("@bz", bz.Text.Trim());

            if (_htglLogic.UpdateXsht(dml))
            {
                AlertMessageAndGoTo("修改成功", "XshtGl.aspx");
            }

        }

        protected void btnShengHe_Click(object sender, EventArgs e)
        {
            DirModel dml = new DirModel();
            dml.Add("@htbh", htbh.Text.Trim());
            if (_htglLogic.ShengHeOrder(dml, "xs_XshtTable"))
            {
                // AlertMessage("审核订单成功");
                AlertMessageAndGoTo("审核成功", "XshtGl.aspx");
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
            if (_htglLogic.ZhiXingOrder(dml, "xs_XshtTable"))
            {
                // AlertMessage("审核订单成功");
                AlertMessageAndGoTo("执行成功", "XshtGl.aspx");
            }
            else
            {
                AlertMessage("执行订单失败");
            }
        }

        protected void AddJgxx(object sender, EventArgs e)
        {
            //string shtbh = htbh.Text;
            //Response.Write("<script>window.showModelessDialog('XshtJgxx.aspx?transmissionInfo=" + shtbh + "')</script>");
            // Response.Write("<script>window.location.reload();</script>");

            DataRow dr = Jgxx_dataTable.NewRow();
            try
            {
                dr[0] = Jgxx_dataTable.Rows.Count + 1;
                dr[1] = mkmcgv.Text;
                dr[2] = mzmc.Text;
                dr[3] = double.Parse(frl.Text.Trim());
                dr[4] = double.Parse(lf.Text.Trim());
                dr[5] = double.Parse(kpmj.Text.Trim());
                dr[6] = double.Parse(htmj.Text.Trim());
                dr[7] = double.Parse(ksl.Text.Trim());
                dr[8] = double.Parse(qdds.Text.Trim());
                dr[9] = double.Parse(qdje.Text.Trim());
                dr[10] = zt.Text;
                dr[11] = true;
            }
            catch
            {
                AlertMessage("数据存在错误，请检查");
                return;
            }
            Jgxx_dataTable.Rows.Add(dr);
            GridView2.DataSource = Jgxx_dataTable;
            GridView2.DataBind();
        }

        protected void DelJgxx(object sender, EventArgs e)
        {
            string shtbh = htbh.Text;
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;
            dml.Add("@bh", (sender as Button).CommandArgument);
            dml.Add("@htbh", shtbh);
            dml.Add("@user_no", model.LoginUser);
            if (_htglLogic.DeleteChildTable(dml, "xs_XshtTable_Jgxx"))
            {
                AlertMessage("订单删除成功");

            }
            else AlertMessage("订单删除失败");
        }

        protected void AddZlbz(object sender, EventArgs e)
        {
            // string shtbh = htbh.Text;
            //Response.Write("<script>window.showModelessDialog('XshtZlbz.aspx?transmissionInfo=" + shtbh + "')</script>");
            DataRow dr = Zlbz_dataTable.NewRow();
            try
            {
                dr[0] = Zlbz_dataTable.Rows.Count + 1;
                dr[1] = mz.Text;
                dr[2] = double.Parse(ld.Text.Trim());
                dr[3] = double.Parse(hf.Text.Trim());
                dr[4] = double.Parse(hff.Text.Trim());
                dr[5] = double.Parse(gdt.Text.Trim());
                dr[6] = double.Parse(njzs.Text.Trim());
                dr[7] = double.Parse(sf.Text.Trim());
                dr[8] = double.Parse(tie.Text.Trim());
                dr[9] = double.Parse(lv.Text.Trim());
                dr[10] = double.Parse(gai.Text.Trim());
                dr[11] = double.Parse(lin.Text.Trim());
                dr[12] = double.Parse(tai.Text.Trim());
                dr[13] = double.Parse(liu.Text.Trim());
                dr[14] = true;
            }
            catch
            {
                AlertMessage("数据存在错误，请检查");
                return;
            }
            Zlbz_dataTable.Rows.Add(dr);
            GridView1.DataSource = Zlbz_dataTable;
            GridView1.DataBind();
        }

        protected void DelZlbz(object sender, EventArgs e)
        {
            string shtbh = htbh.Text;
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;
            dml.Add("@bh", (sender as Button).CommandArgument);
            dml.Add("@htbh", shtbh);
            dml.Add("@user_no", model.LoginUser);
            if (_htglLogic.DeleteChildTable(dml, "xs_XshtTable_Zlbz"))
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
            arrList[0] = "gfmc";
            arrList[1] = "xfmc";
            arrList[2] = "fhdd";
            pagepara.Sql = ht.QueryDropList("xs_XshtTable", arrList);
            pagepara.OrderBy = "gfmc";
            PageChangedEventArgs e = new PageChangedEventArgs(1);
            DataTable dt = xsPageHelper.BindPager(pagepara, e);
            if (dt.Rows.Count != 0)
            {
                gfmc.DataSource = dt.DefaultView;
                gfmc.DataTextField = dt.Columns[0].ToString();
                gfmc.DataBind();
                xfmc.DataSource = dt.DefaultView;
                xfmc.DataTextField = dt.Columns[1].ToString();
                xfmc.DataBind();
                fhdd.DataSource = dt.DefaultView;
                fhdd.DataTextField = dt.Columns[2].ToString();
                fhdd.DataBind();
            }
            htbh.Text = "HTXS" + DateTime.Now.ToString("yyyyMMdd") + "-" + dt.Rows.Count;
        }

    }
}