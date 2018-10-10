using System;
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

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropListInit();
                if (Session["xsht"] != null)
                {
                    InitData(Session["xsht"]);
                }
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
            this.GridView1.DataSource = xsPageHelper.BindPager(pagepara, e);
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
            this.GridView2.DataSource = xsPageHelper.BindPager(pagepara, e);
            this.GridView2.DataBind();



        }
        protected void submit_Click(object sender, EventArgs e)
        {
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;
            dml.Add("@htbh", htbh.Text.Trim());// ??????
            dml.Add("@userid", model.LoginUser);
            dml.Add("@htlx", htlx.SelectedItem.Text.Trim());
            dml.Add("@qdrq", Convert.ToDateTime(qdrq.Text.Trim()));//????
            dml.Add("@dfhth", dfhth.Text.Trim());
            if (gfmc_xz.Text.Equals(""))
                dml.Add("@gfmc", gfmc.SelectedItem.Text.Trim());
            else
                dml.Add("@gfmc", gfmc_xz.Text.Trim());
            if (xfmc_xz.Text.Equals(""))
                dml.Add("@xfmc", xfmc.SelectedItem.Text.Trim());
            else
                dml.Add("@xfmc", xfmc_xz.Text.Trim());
            dml.Add("@hkjsyj", hkjsyj.SelectedItem.Text.Trim());
            dml.Add("@hklhlx", hklhlx.SelectedItem.Text.Trim());
            dml.Add("@hklhbz", hklhbz.Text.Trim());
            dml.Add("@kpxx", kplx.SelectedItem.Text.Trim());
            dml.Add("@jhsjQ", Convert.ToDateTime(jhsjQ.Text));
            dml.Add("@jhsjZ", Convert.ToDateTime(jhsjZ.Text));
            dml.Add("@hkjsfs", hkjsfs.SelectedItem.Text.Trim());
            if (fhdd_xz.Text.Equals(""))
                dml.Add("@fhdd", fhdd.SelectedItem.Text.Trim());
            else
                dml.Add("@fhdd", fhdd_xz.Text.Trim());
            dml.Add("@yffkfs", yffkfs.SelectedItem.Text.Trim());
            dml.Add("@mkmc", mkmc.Text.Trim());
            dml.Add("@kzbz", kzbz.SelectedItem.Text.Trim());
            dml.Add("@lxdh", lxdh.Text.Trim());
            dml.Add("@bz", bz.Text.Trim());


            if (_htglLogic.InsertXsht(dml))
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
            string shtbh = htbh.Text;
            Response.Write("<script>window.showModelessDialog('XshtJgxx.aspx?transmissionInfo=" + shtbh + "')</script>");
            // Response.Write("<script>window.location.reload();</script>");
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
            string shtbh = htbh.Text;
            Response.Write("<script>window.showModelessDialog('XshtZlbz.aspx?transmissionInfo=" + shtbh + "')</script>");
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