using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using xsFramework.Web.WebPage;
using XSSystem.Logic;
using xsFramework.Web.Login;
using xsFramework.UserControl.Pager;
using XSSystem.Class;
using Telerik.Web.UI;

namespace XSSystem.Page.P_Order
{
    public partial class Fyd : AuthWebPage
    {

        CWGLLogic _cwglLogic = new CWGLLogic();
        static DataTable dataTable;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InitBh();
                if (Session["fyd"] != null)
                {
                    InitData(Session["fyd"]);
                }
                InitDataTable();
                InitGridView();
            }
            
        }

        private void InitBh()
        {
            PagerParameter pagepara = new PagerParameter();
            pagepara.DbConn = GlabalString.DBString;
            QueryClass2 qc = new QueryClass2();
            qc.all = 1;
            pagepara.Sql = _cwglLogic.QueryFydOrder(qc);
            pagepara.OrderBy = "bh";
            PageChangedEventArgs ex = new PageChangedEventArgs(1);
            DataTable dt = xsPageHelper.BindPager(pagepara, ex);
            bh.Text = string.Format("FY{0}{1}", DateTime.Now.ToString("yyyyMMdd"), dt.Rows.Count);
            RadComboBoxItem radcbItem;
            DataTable dt2 = GlabalString.GetGongSi();
            if (dt2.Rows.Count != 0)
            {

                foreach (DataRow val in dt2.Rows)
                {
                    radcbItem = new RadComboBoxItem(val[0].ToString());
                    tk_sfdw.Items.Add(radcbItem);
                }
                tk_sfdw.SelectedIndex = 1;
            }
            dt2 = GlabalString.GetYuanGong();
            if (dt2.Rows.Count != 0)
            {

                foreach (DataRow val in dt2.Rows)
                {
                    radcbItem = new RadComboBoxItem(val[0].ToString());
                    tk_jsr.Items.Add(radcbItem);
                }
                tk_jsr.SelectedIndex = 1;
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
            qc.tableName = "xs_FydTable_Fb";
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
            tk_sfdw.Text = dt.Rows[0][3].ToString();
            tk_jsr.Text = dt.Rows[0][4].ToString();
            bm.Text = dt.Rows[0][5].ToString();
            dp_zy.Text = dt.Rows[0][7].ToString();
            fjsm.Text = dt.Rows[0][8].ToString();
            jsfs.Text= dt.Rows[0][9].ToString();
            Session.Remove("fyd");
        }

        private void InitDataTable()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("xh", System.Type.GetType("System.Int32"));
            dataTable.Columns.Add("fyxmbh", System.Type.GetType("System.String"));
            dataTable.Columns.Add("fyxmmc", System.Type.GetType("System.String"));
            dataTable.Columns.Add("je", System.Type.GetType("System.Double"));
            dataTable.Columns.Add("bz", System.Type.GetType("System.String"));

        }

        protected void InsertBtn_Click(object sender, EventArgs e)
        {
            if (!DataChecked(2))
            {
                return;
            }
            DataRow dr = dataTable.NewRow();
            try
            {
                dr[0] = dataTable.Rows.Count;
                dr[1] = fyxmbh.Text;
                dr[2] = fyxmmc.Text;
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

        protected void save_Click(object sender, EventArgs e)
        {
            if (!DataChecked(1))
            {
                return;
            }
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;
            try
            {
                dml.Add("@user_no", model.LoginUser);
                dml.Add("@bh", bh.Text.Trim());
                dml.Add("@ldrq", Convert.ToDateTime(ldrq.Text.ToString()));
                dml.Add("@sfdw", tk_sfdw.Text.Trim());
                dml.Add("@jsr", tk_jsr.Text.Trim());
                dml.Add("@bm", bm.Text.Trim());
                dml.Add("@zy", dp_zy.SelectedItem.Text.Trim());
                dml.Add("@fjsm", fjsm.Text.Trim());
                dml.Add("@jsfs", jsfs.SelectedItem.Text);
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
                temp.Add("@fyxmbh", val[1]);
                temp.Add("@fyxmmc", val[2]);
                temp.Add("@je", val[3]);
                temp.Add("@bz", val[4]);
                Child1.Add(temp);
            }
            string ret = _cwglLogic.InsertFyd(dml, Child1);
            if (ret=="")
            {
                AlertMessage("新增成功");
            }
            else
                AlertMessage("新增失败");
        }
    }
}