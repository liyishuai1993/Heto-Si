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
    public partial class Qyht : AuthWebPage
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
            dt.Columns.Add("wlmc");
            dt.Columns.Add("qyd");
            dt.Columns.Add("mdd");
            dt.Columns.Add("yj");
            dt.Columns.Add("yflhbz");
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
            dml.Add("@dfhth", dfhth.Text.Trim());
            dml.Add("@wtf", wtf.Text.Trim());
            dml.Add("@stf", stf.Text.Trim());
            dml.Add("@kplx", kplx.SelectedItem.Text.Trim());
            dml.Add("@zxqxQ", Convert.ToDateTime(zxqxQ.Text));
            dml.Add("@zxqxZ", Convert.ToDateTime(zxqxZ.Text));


            if (_htglLogic.InsertQyht(dml))
            {
                AlertMessageAndGoTo("新增成功", "Cght.aspx");
            }
        }
    }
}