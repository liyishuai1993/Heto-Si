using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using xs_System.Logic;
using xsFramework.Web.Login;
using xsFramework.Web.WebPage;

namespace XSSystem.Page.P_Order
{
    public partial class Xsht : AuthWebPage
    {
        HTGLLogic _htglLogic = new HTGLLogic();

        protected void Page_Load(object sender, EventArgs e)
        {
            InitGridView();
            InitGridView2();
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
        Random ran = new Random();
        protected void submit_Click(object sender, EventArgs e)
        {
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;
            dml.Add("@htbh", ran.Next(0, 100000).ToString());// ??????
            dml.Add("@userid", model.LoginUser);
            dml.Add("@htlx", htlx.SelectedItem.Text.Trim());
            dml.Add("@qdrq", Convert.ToDateTime(qdrq.Text.Trim()));//????
            dml.Add("@dfhth", dfhth.Text.Trim());
            dml.Add("@gfmc", gfmc.Text.Trim());
            dml.Add("@xfmc", xfmc.Text.Trim());
            dml.Add("@hkjsyj", hkjsyj.SelectedItem.Text.Trim());
            dml.Add("@hklhlx", hklhlx.SelectedItem.Text.Trim());
            dml.Add("@hklhbz", hklhbz.Text.Trim());
            dml.Add("@kpxx", kpxx.SelectedItem.Text.Trim());
            dml.Add("@jhsjQ", Convert.ToDateTime(jhsjQ.Text));
            dml.Add("@jhsjZ", Convert.ToDateTime(jhsjZ.Text));
            dml.Add("@hkjsfs", hkjsfs.SelectedItem.Text.Trim());
            dml.Add("@fhdd", fhdd.Text.Trim());
            dml.Add("@yffkfs", yffkfs.SelectedItem.Text.Trim());
            dml.Add("@mkmc", mkmc.Text.Trim());
            dml.Add("@kzbz", kzbz.SelectedItem.Text.Trim());
            dml.Add("@lxdh", lxdh.Text.Trim());
            dml.Add("@bz", bz.Text.Trim());


            if (_htglLogic.InsertXsht(dml))
            {
                AlertMessageAndGoTo("新增成功", "Cght.aspx");
            }
        }
    }
}