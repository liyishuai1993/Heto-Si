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
    public partial class Tyht : AuthWebPage
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
        Random ran = new Random();
        protected void submit_Click(object sender, EventArgs e)
        {
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;
            dml.Add("@htbh", ran.Next(0, 100000).ToString());// ??????
            dml.Add("@userid", model.LoginUser);
            dml.Add("@htlx", htlx.SelectedItem.Text.Trim());
            dml.Add("@qdrq", Convert.ToDateTime(qdrq.Text.Trim()));//????
            dml.Add("@wtf", wtf.Text.Trim());
            dml.Add("@stf", stf.Text.Trim());
            dml.Add("@fmmc", fmmc.Text.Trim());
            dml.Add("@wlmc", wlmc.Text.Trim());
            dml.Add("@zxqxQ", Convert.ToDateTime(zxqxQ.Text));
            dml.Add("@zxqxZ", Convert.ToDateTime(zxqxZ.Text));
            dml.Add("@zcz", zcz.Text.Trim());
            dml.Add("@zdz", zdz.Text.Trim());
            dml.Add("@xlx", xlx.SelectedItem.Text.Trim());
            dml.Add("@sl", int.Parse(sl.Text.Trim()));


            if (_htglLogic.InsertTyht(dml))
            {
                AlertMessageAndGoTo("新增成功", "Cght.aspx");
            }
        }
    }
}