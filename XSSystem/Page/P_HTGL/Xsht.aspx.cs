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
                InitGridView();
                InitGridView2();
                DropListInit();
            }
            
        }
        public void InitGridView()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("xh");
            dt.Columns.Add("mz");
            dt.Columns.Add("ld");
            dt.Columns.Add("hf");
            dt.Columns.Add("hff");
            dt.Columns.Add("gdt");
            dt.Columns.Add("njzs");
            dt.Columns.Add("sf");
            dt.Columns.Add("tie");
            dt.Columns.Add("lv");
            dt.Columns.Add("gai");
            dt.Columns.Add("lin");
            dt.Columns.Add("tai");
            dt.Columns.Add("liu");



            dt.Rows.Add(dt.NewRow());
            this.GridView1.DataSource = dt;
            this.GridView1.DataBind();
        }


        public void InitGridView2()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("xh");
            dt.Columns.Add("mkmc");
            dt.Columns.Add("mzmc");
            dt.Columns.Add("frl");
            dt.Columns.Add("lf");
            dt.Columns.Add("kpmj");
            dt.Columns.Add("htmj");
            dt.Columns.Add("ksl");
            dt.Columns.Add("qdds");
            dt.Columns.Add("qdje");
            dt.Columns.Add("zt");
            dt.Columns.Add("cz");



            dt.Rows.Add(dt.NewRow());
            this.GridView2.DataSource = dt;
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
            dml.Add("@gfmc", gfmc.SelectedItem.Text.Trim());
            dml.Add("@xfmc", xfmc.SelectedItem.Text.Trim());
            dml.Add("@hkjsyj", hkjsyj.SelectedItem.Text.Trim());
            dml.Add("@hklhlx", hklhlx.SelectedItem.Text.Trim());
            dml.Add("@hklhbz", hklhbz.Text.Trim());
            dml.Add("@kpxx", kpxx.SelectedItem.Text.Trim());
            dml.Add("@jhsjQ", Convert.ToDateTime(jhsjQ.Text));
            dml.Add("@jhsjZ", Convert.ToDateTime(jhsjZ.Text));
            dml.Add("@hkjsfs", hkjsfs.SelectedItem.Text.Trim());
            dml.Add("@fhdd", fhdd.SelectedItem.Text.Trim());
            dml.Add("@yffkfs", yffkfs.SelectedItem.Text.Trim());
            dml.Add("@mkmc", mkmc.Text.Trim());
            dml.Add("@kzbz", kzbz.SelectedItem.Text.Trim());
            dml.Add("@lxdh", lxdh.Text.Trim());
            dml.Add("@bz", bz.Text.Trim());


            if (_htglLogic.InsertXsht(dml))
            {
                AlertMessageAndGoTo("新增成功", "Xsht.aspx");
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
            dml.Add("@kpxx", kpxx.SelectedItem.Text.Trim());
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
            gfmc.DataSource = dt.DefaultView;
            gfmc.DataTextField = dt.Columns[0].ToString();
            gfmc.DataBind();
            xfmc.DataSource = dt.DefaultView;
            xfmc.DataTextField = dt.Columns[1].ToString();
            xfmc.DataBind();
            fhdd.DataSource = dt.DefaultView;
            fhdd.DataTextField = dt.Columns[2].ToString();
            fhdd.DataBind();

            htbh.Text = "HTXS" + DateTime.Now.ToString("yyyyMMdd") + "-" + dt.Rows.Count;
        }

    }
}