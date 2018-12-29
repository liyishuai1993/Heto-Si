using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using xsFramework.Web.WebPage;
using xsFramework.Web.Login;
using XSSystem.Logic;
using xsFramework.UserControl.Pager;
using XSSystem.Class;

namespace XSSystem.Page.P_Order
{
    public partial class Fkd : AuthWebPage
    {
        CWGLLogic _cwglLogic = new CWGLLogic();
        static DataTable dataTable;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //InitGridView1();
                if (Session["fkd"] != null)
                {
                    InitData(Session["fkd"]);
                }
                InitDataTable();
                InitGridView();
            }
            
        }

        public void InitGridView()
        {
            PagerParameter pagepara = new PagerParameter();
            pagepara.DbConn = GlabalString.DBString;
            QueryClass2 qc = new QueryClass2();
            LoginModel model = Session["LoginModel"] as LoginModel;
            qc.user_no = model.LoginUser;
            qc.bh = bh.Text;
            qc.tableName = "xs_FkdTable_Fb";
            pagepara.Sql = _cwglLogic.QueryChildTable(qc);
            pagepara.OrderBy = "bh";
            PageChangedEventArgs e = new PageChangedEventArgs(0);
            dataTable = xsPageHelper.BindPager(pagepara, e);
            if (dataTable.Columns.Count == 0)
            {
                InitDataTable();
            }
            this.GridView1.DataSource = dataTable;
            this.GridView1.DataBind();
        }

        public void InitData(object mk)
        {
            DataTable dt = mk as DataTable;
            bh.Text = dt.Rows[0][1].ToString();
            ldrq.Text = dt.Rows[0][2].ToString();
            skdw.Text = dt.Rows[0][3].ToString();
            jsr.Text = dt.Rows[0][4].ToString();
            bm.Text = dt.Rows[0][5].ToString();
            htbh.Text = dt.Rows[0][6].ToString();
            zy.Text = dt.Rows[0][7].ToString();
            fjsm.Text = dt.Rows[0][8].ToString();
            //ysye.Text = dt.Rows[0][9].ToString();
            yfye.Text = dt.Rows[0][9].ToString();
            Session.Remove("skd");
        }


        protected void save_Click(object sender, EventArgs e)
        {
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;
            try
            {
                dml.Add("@user_no", model.LoginUser);
                dml.Add("@bh", bh.Text.Trim());
                dml.Add("@ldrq", Convert.ToDateTime(ldrq.Text.ToString()));
                dml.Add("@skdw", skdw.Text.Trim());
                dml.Add("@jsr", jsr.Text.Trim());
                dml.Add("@bm", bm.Text.Trim());
                dml.Add("@htbh", htbh.Text.Trim());
                dml.Add("@zy", zy.Text.Trim());
                dml.Add("@fjsm", fjsm.Text.Trim());
                dml.Add("@yfye", yfye.Text.Trim());
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
                temp = new DirModel();
                temp.Add("@user_no", model.LoginUser);
                temp.Add("@bh", bh.Text.Trim());
                temp.Add("@fkzhbh", val[1]);
                temp.Add("@fkzhmc", val[2]);
                temp.Add("@je", val[3]);
                temp.Add("@bz", val[4]);
                Child1.Add(temp);
            }
            string ret = _cwglLogic.InsertFkd(dml, Child1);
            if (ret=="")
            {
                AlertMessage("新增成功");
            }
            else
            {
                AlertMessage("新增失败");
            }
        }

        private void InitDataTable()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("xh", System.Type.GetType("System.Int32"));
            dataTable.Columns.Add("fkzhbh", System.Type.GetType("System.String"));
            dataTable.Columns.Add("fkzhmc", System.Type.GetType("System.String"));
            dataTable.Columns.Add("je", System.Type.GetType("System.Double"));
            dataTable.Columns.Add("bz", System.Type.GetType("System.String"));

        }

        protected void InsertBtn_Click(object sender, EventArgs e)
        {
            DataRow dr = dataTable.NewRow();
            try
            {
                dr[0] = dataTable.Rows.Count;
                dr[1] = fkzhbh.Text;
                dr[2] = fkzhmc.Text;
                dr[3] = double.Parse(je.Text.Trim());
                dr[4] = bz.Text;
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
    }
}