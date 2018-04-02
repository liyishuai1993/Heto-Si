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
    public partial class Tyht : AuthWebPage
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
            dt.Columns.Add("gsmc");
            dt.Columns.Add("dfhth");
            dt.Columns.Add("kplx");
            dt.Columns.Add("zbxsf");
            dt.Columns.Add("dlf");
            dt.Columns.Add("zxf");
            dt.Columns.Add("sfzdd");
            dt.Columns.Add("tlyf");
            dt.Columns.Add("dzzxf");
            dt.Columns.Add("dzmcddf");
            dt.Columns.Add("dzdlf");



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
            dml.Add("@fmmc", fmmc.SelectedItem.Text.Trim());
            dml.Add("@wlmc", wlmc.SelectedItem.Text.Trim());
            dml.Add("@zxqxQ", Convert.ToDateTime(zxqxQ.Text));
            dml.Add("@zxqxZ", Convert.ToDateTime(zxqxZ.Text));
            dml.Add("@zcz", zcz.SelectedItem.Text.Trim());
            dml.Add("@zdz", zdz.SelectedItem.Text.Trim());
            dml.Add("@xlx", xlx.SelectedItem.Text.Trim());
            dml.Add("@sl", int.Parse(sl.Text.Trim()));


            if (_htglLogic.InsertTyht(dml))
            {
                AlertMessageAndGoTo("新增成功", "Tyht.aspx");
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
            dml.Add("@fmmc", fmmc.SelectedItem.Text.Trim());
            dml.Add("@wlmc", wlmc.SelectedItem.Text.Trim());
            dml.Add("@zxqxQ", Convert.ToDateTime(zxqxQ.Text));
            dml.Add("@zxqxZ", Convert.ToDateTime(zxqxZ.Text));
            dml.Add("@zcz", zcz.SelectedItem.Text.Trim());
            dml.Add("@zdz", zdz.SelectedItem.Text.Trim());
            dml.Add("@xlx", xlx.SelectedItem.Text.Trim());
            dml.Add("@sl", int.Parse(sl.Text.Trim()));
            if (_htglLogic.UpdateTyht(dml))
            {
                AlertMessageAndGoTo("修改成功", "TyhtGl.aspx");
            }
        }

        protected void AddJgxx(object sender, EventArgs e)
        {
            string shtbh = htbh.Text;
            Response.Write("<script>window.showModelessDialog('TyhtJgxx.aspx?transmissionInfo=" + shtbh + "')</script>");
        }


        protected void DropListInit()
        {
            PagerParameter pagepara = new PagerParameter();
            QueryClass qc = new QueryClass();
            pagepara.DbConn = GlabalString.DBString;
            //pagepara.XsPager=
            HTGLLogic ht = new HTGLLogic();
            string[] arrList = new string[6];
            arrList[0] = "wtf";
            arrList[1] = "stf";
            arrList[2] = "fmmc";
            arrList[3] = "wlmc";
            arrList[4] = "zcz";
            arrList[5] = "zdz";
            pagepara.Sql = ht.QueryDropList("xs_TyhtTable", arrList);
            pagepara.OrderBy = "wtf";
            PageChangedEventArgs e = new PageChangedEventArgs(1);
            DataTable dt = xsPageHelper.BindPager(pagepara, e);
            wtf.DataSource = dt.DefaultView;
            wtf.DataTextField = dt.Columns[0].ToString();
            wtf.DataBind();
            stf.DataSource = dt.DefaultView;
            stf.DataTextField = dt.Columns[1].ToString();
            stf.DataBind();
            fmmc.DataSource = dt.DefaultView;
            fmmc.DataTextField = dt.Columns[2].ToString();
            fmmc.DataBind();
            wlmc.DataSource = dt.DefaultView;
            wlmc.DataTextField = dt.Columns[3].ToString();
            wlmc.DataBind();
            zcz.DataSource = dt.DefaultView;
            zcz.DataTextField = dt.Columns[4].ToString();
            zcz.DataBind();
            zdz.DataSource = dt.DefaultView;
            zdz.DataTextField = dt.Columns[5].ToString();
            zdz.DataBind();

            htbh.Text = "HTTY" + DateTime.Now.ToString("yyyyMMdd") + "-" + dt.Rows.Count;
        }
    }
}