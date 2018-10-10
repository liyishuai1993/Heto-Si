using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using xs_System.Logic;
using xsFramework.Function.Thumbnail;
using xsFramework.Web.WebPage;
using System.Data;
using xsFramework.Web.Login;
using System.Globalization;
using XSSystem.Class;
using xsFramework.UserControl.Pager;

namespace XSSystem.Page.P_Order
{
    public partial class Cght : AuthWebPage
    {
        HTGLLogic _htglLogic = new HTGLLogic();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropListInit();
                if (Session["cght"]!=null)
                {
                    InitData(Session["cght"]);
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
            kpxx.SelectedItem.Text = dt.Rows[0][10].ToString();
            jhsjQ.Text = dt.Rows[0][11].ToString();
            jhsjZ.Text = dt.Rows[0][12].ToString();
            hkjsfs.SelectedItem.Text = dt.Rows[0][13].ToString();
            jhdd.SelectedItem.Text = dt.Rows[0][14].ToString();
            yffkfs.SelectedItem.Text = dt.Rows[0][15].ToString();
            mkmc.Text = dt.Rows[0][16].ToString();
            bz.Text = dt.Rows[0][17].ToString();
            Session.Remove("cght");
        }


        public void InitGridView() 
        {

            PagerParameter pagepara = new PagerParameter();
            pagepara.DbConn = GlabalString.DBString;
            QueryClass qc = new QueryClass();
            LoginModel model = Session["LoginModel"] as LoginModel;
            qc.user_no = model.LoginUser;
            qc.htbh = htbh.Text;
            qc.tableName = "xs_CghtTable_Zlbz";
            pagepara.Sql = _htglLogic.QueryCghtChildTable(qc);
            pagepara.OrderBy = "htbh";
            PageChangedEventArgs e = new PageChangedEventArgs(0);
            this.GridView_ZLBZ.DataSource = xsPageHelper.BindPager(pagepara, e);
            this.GridView_ZLBZ.DataBind();



        }


        public void InitGridView2()
        {
            PagerParameter pagepara = new PagerParameter();
            pagepara.DbConn = GlabalString.DBString;
            QueryClass qc = new QueryClass();
            LoginModel model = Session["LoginModel"] as LoginModel;
            qc.user_no = model.LoginUser;
            qc.htbh = htbh.Text;
            qc.tableName = "xs_CghtTable_Jgxx";
            pagepara.Sql = _htglLogic.QueryCghtChildTable(qc);
            pagepara.OrderBy = "htbh";

            PageChangedEventArgs e = new PageChangedEventArgs(0);
            this.GridView_JGXX.DataSource = xsPageHelper.BindPager(pagepara,e);
            this.GridView_JGXX.DataBind();



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
            dml.Add("@kpxx", kpxx.SelectedItem.Text.Trim());
            dml.Add("@jhsjQ", Convert.ToDateTime(jhsjQ.Text));
            dml.Add("@jhsjZ", Convert.ToDateTime(jhsjZ.Text));
            dml.Add("@hkjsfs", hkjsfs.SelectedItem.Text.Trim());
            if (jhdd_xz.Text.Equals(""))
                dml.Add("@jhdd", jhdd.SelectedItem.Text.Trim());
            else
                dml.Add("@jhdd", jhdd_xz.Text.Trim());
            dml.Add("@yffkfs", yffkfs.SelectedItem.Text.Trim());
            dml.Add("@mkmc", mkmc.Text.Trim());
            dml.Add("@bz", bz.Text.Trim());


            if (_htglLogic.InsertCght(dml))
            {
             //     AlertMessageAndGoTo("新增成功", "Cght.aspx");
                AlertMessage("新增成功");
              //  xsPage.RefreshPage();
            }
            //dml.Add("@dzdje", StrToFloat(dzdje.Text.Trim()));
            //dml.Add("@skje", StrToFloat(skje.Text.Trim()));
            //dml.Add("@kpje", StrToFloat(kpje.Text.Trim()));
            //dml.Add("@gsjy", StrToFloat(gsjy.Text.Trim()));
            //dml.Add("@kphsksj", Convert.ToDateTime(kphsksj.Text));
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
            dml.Add("@gfmc", gfmc.SelectedItem.Text.Trim());
            dml.Add("@xfmc", xfmc.SelectedItem.Text.Trim());
            dml.Add("@hkjsyj", hkjsyj.SelectedItem.Text.Trim());
            dml.Add("@hklhlx", hklhlx.SelectedItem.Text.Trim());
            dml.Add("@hklhbz", hklhbz.Text.Trim());
            dml.Add("@kpxx", kpxx.SelectedItem.Text.Trim());
            dml.Add("@jhsjQ", Convert.ToDateTime(jhsjQ.Text));
            dml.Add("@jhsjZ", Convert.ToDateTime(jhsjZ.Text));
            dml.Add("@hkjsfs", hkjsfs.SelectedItem.Text.Trim());
            dml.Add("@jhdd", jhdd.SelectedItem.Text.Trim());
            dml.Add("@yffkfs", yffkfs.SelectedItem.Text.Trim());
            dml.Add("@mkmc", mkmc.Text.Trim());
            dml.Add("@bz", bz.Text.Trim());
            if (_htglLogic.UpdateCght(dml))
            {
                AlertMessageAndGoTo("修改成功", "CghtGl.aspx");
            }

        }



        protected void btnShengHe_Click(object sender, EventArgs e)
        {
            DirModel dml = new DirModel();
            dml.Add("@htbh", htbh.Text.Trim());
            if (_htglLogic.ShengHeOrder(dml, "xs_CghtTable"))
            {
               // AlertMessage("审核订单成功");
                AlertMessageAndGoTo("审核成功", "CghtGl.aspx");
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
            if (_htglLogic.ZhiXingOrder(dml, "xs_CghtTable"))
            {
                // AlertMessage("审核订单成功");
                AlertMessageAndGoTo("执行成功", "CghtGl.aspx");
            }
            else
            {
                AlertMessage("执行订单失败");
            }
        }


        protected void AddJgxx(object sender, EventArgs e)
        {
            string shtbh = htbh.Text;
            Response.Write("<script>window.showModelessDialog('CghtJgxx.aspx?transmissionInfo="+ shtbh+"')</script>");
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
            if (_htglLogic.DeleteChildTable(dml, "xs_CghtTable_Jgxx"))
            {
                AlertMessage("订单删除成功");
                
            }
            else AlertMessage("订单删除失败");
        }

        protected void DelZlbz(object sender, EventArgs e)
        {
            string shtbh = htbh.Text;
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;
            dml.Add("@bh", (sender as Button).CommandArgument);
            dml.Add("@htbh", shtbh);
            dml.Add("@user_no", model.LoginUser);
            if (_htglLogic.DeleteChildTable(dml, "xs_CghtTable_Zlbz"))
            {
                AlertMessage("订单删除成功");

            }
            else AlertMessage("订单删除失败");
        }

        protected void AddZlbz(object sender, EventArgs e)
        {
            string shtbh = htbh.Text;
            Response.Write("<script>window.showModelessDialog('CghtZlbz.aspx?transmissionInfo=" + shtbh + "')</script>");
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
            arrList[2] = "jhdd";
            pagepara.Sql = ht.QueryDropList("xs_CghtTable", arrList);
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
                jhdd.DataSource = dt.DefaultView;
                jhdd.DataTextField = dt.Columns[2].ToString();
                jhdd.DataBind();
            }
            htbh.Text = "HTCG" + DateTime.Now.ToString("yyyyMMdd") + "-" + dt.Rows.Count;
        }
    }
}