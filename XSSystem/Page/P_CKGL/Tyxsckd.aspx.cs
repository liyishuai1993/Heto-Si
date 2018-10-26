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
    public partial class Tyxsckd : AuthWebPage
    {
        HTGLLogic _htglLogic = new HTGLLogic();

        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                if (Session["tyxsckd"] != null)
                {
                    InitData(Session["tyxsckd"]);
                }
                InitGridView();
            }
            
        }

        void InitData(object mk)
        {
            DataTable dt = mk as DataTable;
            bh.Text = dt.Rows[0][1].ToString();
            htbh.Text = dt.Rows[0][2].ToString();
            wtf.Text = dt.Rows[0][3].ToString();
            stf.Text = dt.Rows[0][4].ToString();
            fmmc.Text = dt.Rows[0][5].ToString();

            wlmc.Text = dt.Rows[0][6].ToString();
            mj.Text = dt.Rows[0][7].ToString();
            zcz.Text = dt.Rows[0][8].ToString();
            zdz.Text = dt.Rows[0][9].ToString();
            xlx.Text = dt.Rows[0][10].ToString();

            tcbz.Text = dt.Rows[0][11].ToString();
            tcje.Text = dt.Rows[0][12].ToString();
            ywy.Text = dt.Rows[0][13].ToString();
            xhdw.Text = dt.Rows[0][14].ToString();
            Session.Remove("tyxsckd");
        }


        public void InitGridView()
        {
            PagerParameter pagepara = new PagerParameter();
            pagepara.DbConn = GlabalString.DBString;
            QueryClass qc = new QueryClass();
            LoginModel model = Session["LoginModel"] as LoginModel;
            qc.user_no = model.LoginUser;
            qc.htbh = htbh.Text;
            qc.tableName = "xs_Tyxsckd_Jzxxx";
            pagepara.Sql = _htglLogic.QueryCghtChildTable(qc);
            pagepara.OrderBy = "htbh";
            PageChangedEventArgs e = new PageChangedEventArgs(0);
            this.GridView1.DataSource = xsPageHelper.BindPager(pagepara, e);
            this.GridView1.DataBind();
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;

            dml.Add("@user_no", model.LoginUser);
            dml.Add("@bh", bh.Text.Trim());
            dml.Add("@htbh", htbh.Text.Trim());
            dml.Add("@wtf", wtf.Text.Trim());
            dml.Add("@stf", stf.Text.Trim());
            dml.Add("@fmmc", fmmc.Text.Trim());
            dml.Add("@wlmc", wlmc.Text.Trim());
            dml.Add("@mj", float.Parse(mj.Text.Trim()));
            dml.Add("@zcz", zcz.Text.Trim());
            dml.Add("@zdz", zdz.Text.Trim());
            dml.Add("@xlx", xlx.Text.Trim());
            dml.Add("@tcbz", tcbz.Text.Trim());
            dml.Add("@tcje", float.Parse(tcje.Text.Trim()));
            dml.Add("@ywy", ywy.Text.Trim());
            dml.Add("@xhdw", float.Parse(xhdw.Text.Trim()));
            if (_htglLogic.InsertTyxsckd(dml))
            {
                AlertMessage("新增成功");
            }
        }
        protected void AddJgxx(object sender, EventArgs e)
        {
            string shtbh = htbh.Text;
            Response.Write("<script>window.showModelessDialog('TyxsckdJzxxx.aspx?transmissionInfo=" + htbh.Text + "+&bh="+bh.Text+"')</script>");
            // Response.Write("<script>window.location.reload();</script>");
        }
    }
}