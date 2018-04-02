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
    public partial class Wtjght : AuthWebPage
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
            dt.Columns.Add("wlmc");
            dt.Columns.Add("jgf");
            dt.Columns.Add("cmzb");
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
            dml.Add("@wtf", wtf.SelectedItem.Text.Trim());
            dml.Add("@stf", stf.SelectedItem.Text.Trim());
            dml.Add("@kplx", kpxx.SelectedItem.Text.Trim());
            dml.Add("@zxqxQ", Convert.ToDateTime(zxqxQ.Text));
            dml.Add("@zxqxZ", Convert.ToDateTime(zxqxZ.Text));


            if (_htglLogic.InsertWtjght(dml))
            {
                AlertMessageAndGoTo("新增成功", "Wthght.aspx");
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
            dml.Add("@wtf", wtf.SelectedItem.Text.Trim());
            dml.Add("@stf", stf.SelectedItem.Text.Trim());
            dml.Add("@kplx", kpxx.SelectedItem.Text.Trim());
            dml.Add("@zxqxQ", Convert.ToDateTime(zxqxQ.Text));
            dml.Add("@zxqxZ", Convert.ToDateTime(zxqxZ.Text));


            if (_htglLogic.UpdateWtjghtht(dml))
            {
                AlertMessageAndGoTo("修改成功", "WthghtGl.aspx");
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
            pagepara.Sql = ht.QueryDropList("xs_WtjgTable", arrList);
            pagepara.OrderBy = "wtf";
            PageChangedEventArgs e = new PageChangedEventArgs(1);
            DataTable dt = xsPageHelper.BindPager(pagepara, e);
            wtf.DataSource = dt.DefaultView;
            wtf.DataTextField = dt.Columns[0].ToString();
            wtf.DataBind();
            stf.DataSource = dt.DefaultView;
            stf.DataTextField = dt.Columns[1].ToString();
            stf.DataBind();

            htbh.Text = "HTJG" + DateTime.Now.ToString("yyyyMMdd") + "-" + dt.Rows.Count;
        }
    }
}