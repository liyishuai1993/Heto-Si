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
                InitGridView();
                InitGridView2();
                DropListInit();
                if (Session["cght"]!=null)
                {
                    InitData(Session["cght"]);
                }
                
            }

            
        }

        public void InitData(object cght)
        {
            CghtClass cc = cght as CghtClass;
            htbh.Text = cc.htbh;
            htlx.SelectedItem.Text = cc.htlx;
            qdrq.Text = cc.qdrq;
            dfhth.Text = cc.dfhth;
            gfmc.SelectedItem.Text = cc.gfmc;
            xfmc.SelectedItem.Text = cc.xfmc;
            hkjsfs.SelectedItem.Text = cc.hkjsfs;
            hklhlx.SelectedItem.Text = cc.hklhlx;
            hklhbz.Text = cc.hklhbz;
            kpxx.SelectedItem.Text = cc.kpxx;
            jhsjQ.Text = cc.jhsjQ;
            jhsjZ.Text = cc.jhsjZ;
            hkjsfs.SelectedItem.Text = cc.hkjsfs;
            jhdd.SelectedItem.Text = cc.jhdd;
            yffkfs.SelectedItem.Text = cc.yffkfs;
            mkmc.Text = cc.mkmc;
            bz.Text = cc.bz;
            Session.Remove("cght");
        }


        static DataTable dtzlbz = new DataTable();
        public void InitGridView() 
        {

            if (dtzlbz.Columns.Count == 0)
            {
                dtzlbz.Columns.Add("xh");
                dtzlbz.Columns.Add("mz");
                dtzlbz.Columns.Add("ld");
                dtzlbz.Columns.Add("hf");
                dtzlbz.Columns.Add("hff");
                dtzlbz.Columns.Add("gdt");
                dtzlbz.Columns.Add("njzs");
                dtzlbz.Columns.Add("sf");
                dtzlbz.Columns.Add("tie");
                dtzlbz.Columns.Add("lv");
                dtzlbz.Columns.Add("gai");
                dtzlbz.Columns.Add("lin");
                dtzlbz.Columns.Add("tai");
                dtzlbz.Columns.Add("liu");
            }


            dtzlbz.Rows.Add(dtzlbz.NewRow());
            this.GridView_ZLBZ.DataSource = dtzlbz;
            this.GridView_ZLBZ.DataBind();



        }

        static DataTable dtjgxx = new DataTable();
        public void InitGridView2()
        {
            if (dtjgxx.Columns.Count == 0)
            {

                dtjgxx.Columns.Add("xh");
                dtjgxx.Columns.Add("mkmc");
                dtjgxx.Columns.Add("mzmc");
                dtjgxx.Columns.Add("frl");
                dtjgxx.Columns.Add("lf");
                dtjgxx.Columns.Add("kpmj");
                dtjgxx.Columns.Add("htmj");
                dtjgxx.Columns.Add("ksl");
                dtjgxx.Columns.Add("qdds");
                dtjgxx.Columns.Add("qdje");
                dtjgxx.Columns.Add("zt");
                dtjgxx.Columns.Add("cz");
            }


            dtjgxx.Rows.Add(dtjgxx.NewRow());
            this.GridView_JGXX.DataSource = dtjgxx;
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
            dml.Add("@gfmc",gfmc.SelectedItem.Text.Trim());
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
        protected void AddJgxx(object sender, EventArgs e)
        {
            string shtbh = htbh.Text;
            Response.Write("<script>window.showModelessDialog('CghtJgxx.aspx?transmissionInfo="+ shtbh+"')</script>");
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
            gfmc.DataSource = dt.DefaultView;
            gfmc.DataTextField = dt.Columns[0].ToString();
            gfmc.DataBind();
            xfmc.DataSource = dt.DefaultView;
            xfmc.DataTextField = dt.Columns[1].ToString();
            xfmc.DataBind();
            jhdd.DataSource = dt.DefaultView;
            jhdd.DataTextField = dt.Columns[2].ToString();
            jhdd.DataBind();
            htbh.Text = "HTCG" + DateTime.Now.ToString("yyyyMMdd") + "-" + dt.Rows.Count;
        }
    }
}