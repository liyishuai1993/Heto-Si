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
    public partial class Mkzxzcd : AuthWebPage
    {
        HTGLLogic _htglLogic = new HTGLLogic();
        static DataTable dataTable;
        protected void Page_Load(object sender, EventArgs e)
        {         
            if (!IsPostBack)
            {
                if (Session["mkzxzcd"] != null)
                {
                    InitData(Session["mkzxzcd"]);
                }
                InitDataTable();
            }
        }

        private void InitDataTable()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("bdh", System.Type.GetType("System.Int32"));
            dataTable.Columns.Add("thdh", System.Type.GetType("System.String"));
            dataTable.Columns.Add("ch", System.Type.GetType("System.String"));
            dataTable.Columns.Add("zcmz", System.Type.GetType("System.Double"));
            dataTable.Columns.Add("zcpz", System.Type.GetType("System.Double"));
            dataTable.Columns.Add("zcjz", System.Type.GetType("System.Double"));

            dataTable.Columns.Add("yfyf", System.Type.GetType("System.Double"));
            dataTable.Columns.Add("cgjsje", System.Type.GetType("System.Double"));
            dataTable.Columns.Add("xsjsje", System.Type.GetType("System.Double"));
            dataTable.Columns.Add("bz", System.Type.GetType("System.String"));
            dataTable.Columns.Add("zt", System.Type.GetType("System.String"));

            
        }

        void InitData(object mk)
        {
            DataTable dt = mk as DataTable;
            djbh.Text = dt.Rows[0][1].ToString();
            zcsj.Text = dt.Rows[0][2].ToString();
            zcsj.Text = dt.Rows[0][3].ToString();
            cghth.Text = dt.Rows[0][4].ToString();
            ghf.Text = dt.Rows[0][5].ToString();

            shf.Text = dt.Rows[0][6].ToString();
            mkmc.Text = dt.Rows[0][7].ToString();
            wlmc.Text = dt.Rows[0][8].ToString();
            cydw.Text = dt.Rows[0][9].ToString();
            yj.Text = dt.Rows[0][10].ToString();

            cgmj.Text = dt.Rows[0][11].ToString();
            xsmj.Text = dt.Rows[0][12].ToString();
            Session.Remove("mkzxzcd");
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;

            dml.Add("@user_no", model.LoginUser);
            dml.Add("@djbh", djbh.Text.Trim());
            dml.Add("@zcsj", Convert.ToDateTime(zcsj.Text.Trim()));
            dml.Add("@cghth", cghth.Text.Trim());
            dml.Add("@ghf", ghf.Text.Trim());
            dml.Add("@shf", shf.Text.Trim());
            dml.Add("@mkmc", mkmc.Text.Trim());
            dml.Add("@wlmc", wlmc.Text.Trim());
            dml.Add("@cydw", cydw.Text.Trim());
            dml.Add("@yj", float.Parse(yj.Text.Trim()));
            dml.Add("@cgmj", float.Parse(cgmj.Text.Trim()));
            dml.Add("@xsmj", float.Parse(xsmj.Text.Trim()));
            if (_htglLogic.InsertMkzxzcd(dml))
            {
                AlertMessage("新增成功");
            }
        }

        protected void AddClxx(object sender,EventArgs e)
        {
            DataRow dr = dataTable.NewRow();
            dr[0] = bdh.Text;
            dr[1] = thdh.Text;
            dr[2] = ch.Text;
            dr[3] = double.Parse(zcmz.Text);
            dr[4] = double.Parse(zcpz.Text);
            dr[5] = double.Parse(zcjz.Text);
            dr[6] = double.Parse(yfyf.Text);
            dr[7] = double.Parse(cgjsje.Text);
            dr[8] = double.Parse(xsjsje.Text);
            dr[9] = bz.Text;
            dr[10] = zt.Text;
            dataTable.Rows.Add(dr);
            GridView1.DataSource = dataTable;
            GridView1.DataBind();
        }

        public void InitGridView()
        {
            PagerParameter pagepara = new PagerParameter();
            pagepara.DbConn = GlabalString.DBString;
            QueryClass qc = new QueryClass();
            LoginModel model = Session["LoginModel"] as LoginModel;
            qc.user_no = model.LoginUser;
            qc.djbh = djbh.Text;
            qc.tableName = "xs_MkzxzcdTable_Clxx";
            pagepara.Sql = _htglLogic.QueryMkzxzcdChildTable(qc);
            pagepara.OrderBy = "djbh";
            PageChangedEventArgs e = new PageChangedEventArgs(0);
            this.GridView1.DataSource = xsPageHelper.BindPager(pagepara, e);
            this.GridView1.DataBind();
        }

        
    }
}