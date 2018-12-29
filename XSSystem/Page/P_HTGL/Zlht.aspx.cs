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
        static DataTable dataTable;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                DropListInit();
                if (Session["zlht"] != null)
                {
                    InitData(Session["zlht"]);
                }
                InitDataTable();
                InitGridView();
            }

        }

        private void InitDataTable()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("bh", System.Type.GetType("System.Int32"));
            dataTable.Columns.Add("qsrq", System.Type.GetType("System.String"));
            dataTable.Columns.Add("zzrq", System.Type.GetType("System.String"));
            dataTable.Columns.Add("zj", System.Type.GetType("System.Double"));
            dataTable.Columns.Add("fktk", System.Type.GetType("System.String"));
            dataTable.Columns.Add("zxzt", System.Type.GetType("System.String"));
            dataTable.Columns.Add("bz", System.Type.GetType("System.String"));
            dataTable.Columns.Add("isadd", System.Type.GetType("System.Boolean"));

        }

        public void InitData(object mk)
        {
            DataTable dt = mk as DataTable;
            htbh.Text = dt.Rows[0][1].ToString();
            htlx.SelectedItem.Text = dt.Rows[0][2].ToString();
            qdrq.Text = dt.Rows[0][3].ToString();
            czf.SelectedItem.Text = dt.Rows[0][4].ToString();
            czf2.SelectedItem.Text = dt.Rows[0][5].ToString();
            czdd.SelectedItem.Text = dt.Rows[0][6].ToString();
            zlqxQ.Text = dt.Rows[0][7].ToString();
            zlqxZ.Text = dt.Rows[0][8].ToString();
            yj.Text = dt.Rows[0][9].ToString();
            Session.Remove("zlht");
        }

        public void InitGridView()
        {
            PagerParameter pagepara = new PagerParameter();
            pagepara.DbConn = GlabalString.DBString;
            QueryClass qc = new QueryClass();
            LoginModel model = Session["LoginModel"] as LoginModel;
            qc.user_no = model.LoginUser;
            qc.htbh = htbh.Text;
            qc.tableName = "xs_ZlhtTable_Zjxx";
            pagepara.Sql = _htglLogic.QueryCghtChildTable(qc);
            pagepara.OrderBy = "htbh";

            PageChangedEventArgs e = new PageChangedEventArgs(0);
            dataTable= xsPageHelper.BindPager(pagepara, e);
            if (dataTable.Columns.Count == 0)
            {
                InitDataTable();
            }
            this.GridView1.DataSource = dataTable;
            this.GridView1.DataBind();
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;
            try
            {
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
            }
            catch
            {
                AlertMessage("数据存在错误，请检查");
                return;
            }
            List<DirModel> Child1 = new List<DirModel>();
            DirModel temp;
            foreach(DataRow val in dataTable.Rows)
            {
                if ((bool)val[7])
                {
                    temp = new DirModel();
                    temp.Add("@htbh", htbh.Text.Trim());
                    temp.Add("@user_no", model.LoginUser);
                    temp.Add("@qsrq", val[1]);
                    temp.Add("@zzrq", val[2]);
                    temp.Add("@zj", val[3]);
                    temp.Add("@fktk", val[4]);
                    temp.Add("@zxzt", val[5]);
                    temp.Add("@bz", val[6]);
                    Child1.Add(temp);
                }
                
            }

            if (_htglLogic.InsertZlht(dml,Child1))
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
            dml.Add("@yj", float.Parse(yj.Text.Trim()));


            if (_htglLogic.UpdateZlht(dml))
            {
                AlertMessageAndGoTo("修改成功", "ZlhtGl.aspx");
            }

        }

        protected void btnShengHe_Click(object sender, EventArgs e)
        {
            DirModel dml = new DirModel();
            dml.Add("@htbh", htbh.Text.Trim());
            if (_htglLogic.ShengHeOrder(dml, "xs_ZlhtTable"))
            {
                // AlertMessage("审核订单成功");
                AlertMessageAndGoTo("审核成功", "ZlhtGl.aspx");
            }
            else
            {
                AlertMessage("审核订单失败");
            }
        }

        protected void btnZhiXing_Click(object sender, EventArgs e)
        {
            DirModel dml = new DirModel();
            dml.Add("@htbh", htbh.Text.Trim());
            if (_htglLogic.ZhiXingOrder(dml, "xs_ZlhtTable"))
            {
                // AlertMessage("审核订单成功");
                AlertMessageAndGoTo("执行成功", "ZlhtGl.aspx");
            }
            else
            {
                AlertMessage("执行订单失败");
            }
        }

        protected void AddZjxx(object sender, EventArgs e)
        {
            //string shtbh = htbh.Text;
            //Response.Write("<script>window.showModelessDialog('ZlhtZjxx.aspx?transmissionInfo=" + shtbh + "')</script>");
            DataRow dr = dataTable.NewRow();
            try
            {
                dr[0] = dataTable.Rows.Count;
                dr[1] = qsrq.Text;
                dr[2] = zzrq.Text;
                dr[3] = double.Parse(zj.Text.Trim());
                dr[4] = fktk.Text;
                dr[5] = zxzt.Text;
                dr[6] = bz.Text;
                dr[7] = true;
            }
            catch
            {
                AlertMessage("数据存在错误，请检查");
                return;
            }
            dataTable.Rows.Add(dr);
            GridView1.DataSource = dataTable;
            GridView1.DataBind();
        }

        protected void DelJgxx(object sender, EventArgs e)
        {
            string shtbh = htbh.Text;
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;
            dml.Add("@bh", (sender as Button).CommandArgument);
            dml.Add("@htbh", shtbh);
            dml.Add("@user_no", model.LoginUser);
            if (_htglLogic.DeleteChildTable(dml, "xs_ZlhtTable_Zjxx"))
            {
                AlertMessage("订单删除成功");

            }
            else AlertMessage("订单删除失败");
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
            if (dt.Rows.Count != 0)
            {
                czf.DataSource = dt.DefaultView;
                czf.DataTextField = dt.Columns[0].ToString();
                czf.DataBind();
                czf2.DataSource = dt.DefaultView;
                czf2.DataTextField = dt.Columns[1].ToString();
                czf2.DataBind();
                czdd.DataSource = dt.DefaultView;
                czdd.DataTextField = dt.Columns[0].ToString();
                czdd.DataBind();
            }
            htbh.Text = "HTZL" + DateTime.Now.ToString("yyyyMMdd") + "-" + dt.Rows.Count;
        }
    }
}