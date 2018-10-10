using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using xsFramework.Web.WebPage;
using xs_System.Logic;
using xsFramework.Web.Login;
using xsFramework.UserControl.Pager;
using XSSystem.Class;

namespace XSSystem.Page.P_Order
{
    public partial class Tydbckd : AuthWebPage
    {
        HTGLLogic _htglLogic = new HTGLLogic();

        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                if (Session["tydbckd"] != null)
                {
                    InitData(Session["tydbckd"]);
                }
                InitGridView();
            }
        }

        void InitData(object mk)
        {
            DataTable dt = mk as DataTable;
            bh.Text = dt.Rows[0][1].ToString();
            htbh.Text = dt.Rows[0][2].ToString();
            gsmc.Text = dt.Rows[0][3].ToString();
            gsmc.Text = dt.Rows[0][4].ToString();
            fmmc.Text = dt.Rows[0][5].ToString();

            wlmc.Text = dt.Rows[0][6].ToString();
            zcz.Text = dt.Rows[0][7].ToString();
            zdz.Text = dt.Rows[0][8].ToString();
            xlx.Text = dt.Rows[0][9].ToString();
            Session.Remove("tydbckd");
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;

            dml.Add("@user_no", model.LoginUser);
            dml.Add("@bh", bh.Text.Trim());
            dml.Add("@htbh", htbh.Text.Trim());
            dml.Add("@gsmc", gsmc.Text.Trim());
            dml.Add("@fmmc", fmmc.Text.Trim());
            dml.Add("@wlmc", wlmc.Text.Trim());
            dml.Add("@zcz", zcz.Text.Trim());
            dml.Add("@zdz", zdz.Text.Trim());
            dml.Add("@xlx", xlx.Text.Trim());
            if (_htglLogic.InsertTydbckd(dml))
            {
                AlertMessage("新增成功");
            }
        }


        public void InitGridView()
        {
            PagerParameter pagepara = new PagerParameter();
            pagepara.DbConn = GlabalString.DBString;
            QueryClass qc = new QueryClass();
            LoginModel model = Session["LoginModel"] as LoginModel;
            qc.user_no = model.LoginUser;
            qc.bh = bh.Text;
            qc.tableName = "xs_Tydbckd_Jzxxx";
            pagepara.Sql = _htglLogic.QueryThdbckdChildTable(qc);
            pagepara.OrderBy = "bh";
            PageChangedEventArgs e = new PageChangedEventArgs(0);
            this.GridView1.DataSource = xsPageHelper.BindPager(pagepara, e);
            this.GridView1.DataBind();
        }

        protected void AddJgxx(object sender, EventArgs e)
        {
            string shtbh = htbh.Text;
            Response.Write("<script>window.showModelessDialog('TydbckdJzxxx.aspx?transmissionInfo=" + bh.Text + "')</script>");
            // Response.Write("<script>window.location.reload();</script>");
        }
    }
}