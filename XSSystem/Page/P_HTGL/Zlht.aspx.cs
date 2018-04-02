using System;
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
                InitGridView();
                DropListInit();
            }
           
        }

        public void InitGridView()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("xh");
            dt.Columns.Add("qsrq");
            dt.Columns.Add("zzrq");
            dt.Columns.Add("zj");
            dt.Columns.Add("fktk");
            dt.Columns.Add("zxzt");
            dt.Columns.Add("bz");



            dt.Rows.Add(dt.NewRow());
            this.GridView1.DataSource = dt;
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
            dml.Add("@czf", czf.SelectedItem.Text.Trim());
            dml.Add("@czf2", czf2.SelectedItem.Text.Trim());
            dml.Add("@czdd", czdd.SelectedItem.Text.Trim());
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
            dml.Add("@yj", int.Parse(yj.Text.Trim()));


            if (_htglLogic.UpdateZlht(dml))
            {
                AlertMessageAndGoTo("修改成功", "ZlhtGl.aspx");
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
            arrList[0] = "czf";
            arrList[1] = "czf2";
            arrList[2] = "czdd";
            pagepara.Sql = ht.QueryDropList("xs_ZlhtTable", arrList);
            pagepara.OrderBy = "czf";
            PageChangedEventArgs e = new PageChangedEventArgs(1);
            DataTable dt = xsPageHelper.BindPager(pagepara, e);
            czf.DataSource = dt.DefaultView;
            czf.DataTextField = dt.Columns[0].ToString();
            czf.DataBind();
            czf2.DataSource = dt.DefaultView;
            czf2.DataTextField = dt.Columns[1].ToString();
            czf2.DataBind();
            czdd.DataSource = dt.DefaultView;
            czdd.DataTextField = dt.Columns[0].ToString();
            czdd.DataBind();

            htbh.Text = "HTZL" + DateTime.Now.ToString("yyyyMMdd") + "-" + dt.Rows.Count;
        }
    }
}