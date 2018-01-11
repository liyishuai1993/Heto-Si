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

namespace XSSystem.Page.P_Order
{
    public partial class Zlht : AuthWebPage
    {
        HTGLLogic _htglLogic = new HTGLLogic();
        protected void Page_Load(object sender, EventArgs e)
        {
            InitGridView();
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
        Random ran = new Random();
        protected void submit_Click(object sender, EventArgs e)
        {
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;
            dml.Add("@htbh", ran.Next(0, 100000).ToString());// ??????
            dml.Add("@userid", model.LoginUser);
            dml.Add("@htlx", htlx.SelectedItem.Text.Trim());
            dml.Add("@qdrq", Convert.ToDateTime(qdrq.Text.Trim()));//????
            dml.Add("@czf", czf.Text.Trim());
            dml.Add("@czf2", czf2.Text.Trim());
            dml.Add("@czdd", czdd.Text.Trim());
            dml.Add("@zlqxQ", Convert.ToDateTime(zlqxQ.Text));
            dml.Add("@zlqxZ", Convert.ToDateTime(zlqxZ.Text));
            dml.Add("@yj", int.Parse(yj.Text.Trim()));


            if (_htglLogic.InsertZlht(dml))
            {
                AlertMessageAndGoTo("新增成功", "Cght.aspx");
            }
        }
    }
}