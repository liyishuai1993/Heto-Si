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
using Telerik.Web.UI;

namespace XSSystem.Page.P_Order
{
    public partial class Skd : AuthWebPage
    {
        CWGLLogic _cwglLogic = new CWGLLogic();
        static DataTable dataTable;
        static int gvIndex;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InitBh();
                if (Session["skd"] != null)
                {
                    InitData(Session["skd"]);
                }
                InitDataTable();
                InitGridView();
            }
            
        }

        private void GetBH()
        {
            PagerParameter pagepara = new PagerParameter();
            pagepara.DbConn = GlabalString.DBString;
            QueryClass2 qc = new QueryClass2();
            qc.all = 1;
            pagepara.Sql = _cwglLogic.QuerySkdOrder(qc);
            pagepara.OrderBy = "bh";
            DataTable dt = xsPageHelper.BindPager(pagepara);
            bh.Text = string.Format("SK{0}{1}", DateTime.Now.ToString("yyyyMMdd"), dt.Rows.Count);
        }

        private void InitBh()
        {
            GetBH();
            RadComboBoxItem radcbItem;
            DataTable dt2 = GlabalString.GetGongSi();
            if (dt2.Rows.Count != 0)
            {

                foreach (DataRow val in dt2.Rows)
                {
                    radcbItem = new RadComboBoxItem(val[0].ToString());
                    tk_fkdw.Items.Add(radcbItem);
                }
                tk_fkdw.SelectedIndex = 1;
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

            dt2 = GlabalString.GetHeTongHao("xs_XshtTable");
            if (dt2.Rows.Count != 0)
            {
                foreach (DataRow val in dt2.Rows)
                {
                    radcbItem = new RadComboBoxItem(val[0].ToString());
                    tk_htbh.Items.Add(radcbItem);
                }
                tk_htbh.SelectedIndex = 1;
            }

            if (GlabalString.zhDataTable.Rows.Count != 0)
            {
                foreach (DataRow val in GlabalString.zhDataTable.Rows)
                {
                    radcbItem = new RadComboBoxItem(val[0].ToString());
                    tk_skzhbh.Items.Add(radcbItem);
                }
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
            qc.tableName = "xs_SkdTable_Fb";
            pagepara.Sql = _cwglLogic.QueryChildTable(qc);
            pagepara.OrderBy = "bh";
            PageChangedEventArgs e = new PageChangedEventArgs(0);
            var temp = xsPageHelper.BindPager(pagepara, e);
            foreach (DataRow val in temp.Rows)
            {
                DataRow dr = dataTable.NewRow();
                dr[0] = val[2];
                dr[1] = val[3];
                dr[2] = val[4];
                dr[3] = val[5];
                dr[4] = val[6];
                dataTable.Rows.Add(dr);

            }
            if (dataTable.Columns.Count == 0)
            {
                InitDataTable();
            }
            gvIndex = dataTable.Rows.Count;
            this.GridView1.DataSource = dataTable;
            this.GridView1.DataBind();
        }

        public void InitData(object mk)
        {
            DataTable dt = mk as DataTable;
            bh.Text = dt.Rows[0][1].ToString();
            ldrq.Text = dt.Rows[0][2].ToString();
            tk_fkdw.Text = dt.Rows[0][3].ToString();
            tk_jsr.Text = dt.Rows[0][4].ToString();
            bm.Text = dt.Rows[0][5].ToString();
            tk_htbh.Text = dt.Rows[0][6].ToString();
            dp_zy.Text = dt.Rows[0][7].ToString();
            fjsm.Text = dt.Rows[0][8].ToString();
            jsfs.Text = dt.Rows[0][9].ToString();
            yhje.Text = dt.Rows[0][10].ToString();
            hjje.Text = dt.Rows[0][11].ToString();
            Session.Remove("skd");
        }

        private void InitDataTable()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("xh", System.Type.GetType("System.Int32"));
            dataTable.Columns.Add("skzhbh", System.Type.GetType("System.String"));
            dataTable.Columns.Add("skzhmc", System.Type.GetType("System.String"));
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
                dr[0] = gvIndex;
                dr[1] = tk_skzhbh.Text;
                dr[2] = zhm.Text;
                dr[3] = double.Parse(je.Text.Trim());
                dr[4] = bz.Text;
            }
            catch(Exception ex)
            {
                AlertMessage($"数据存在错误，请检查,{ex.Message}");
                return;
            }
            dataTable.Rows.Add(dr);
            gvIndex++;
            var sum = dataTable.Compute("sum(je)", "TRUE");
            hjje.Text = Sub(sum.ToString(), yhje.Text);
            GridView1.DataSource = dataTable;
            GridView1.DataBind();

        }

        protected void DelJgxx(object sender, EventArgs e)
        {
            string itemBh = (sender as Button).CommandArgument;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                if (dataTable.Rows[i][0].ToString().Equals(itemBh))
                {
                    dataTable.Rows.Remove(dataTable.Rows[i]);
                    break;
                }
                else
                {
                    continue;
                }
            }
            var sum = dataTable.Compute("sum(je)", "TRUE");
            if (sum.ToString() != "")
            {
                hjje.Text = Sub(sum.ToString(), yhje.Text);
            }
            else
            {
                hjje.Text = "0";
            }
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
                dml.Add("@fkdw", tk_fkdw.Text.Trim());
                dml.Add("@jsr", tk_jsr.Text.Trim());
                dml.Add("@bm", bm.Text.Trim());
                dml.Add("@htbh", tk_htbh.Text.Trim());
                dml.Add("@zy", dp_zy.SelectedItem.Text.Trim());
                dml.Add("@fjsm", fjsm.Text.Trim());
                dml.Add("@jsfs", jsfs.SelectedItem.Text);
                dml.Add("@yhje", yhje.Text.Trim());
                dml.Add("@hjje", hjje.Text.Trim());
            }
            catch
            {
                AlertMessage("数据存在错误，请检查");
                return;
            }
            List<DirModel> Child1 = new List<DirModel>();
            DirModel temp;
            foreach (DataRow val in dataTable.Rows)
            {
                temp = new DirModel();
                temp.Add("@user_no", model.LoginUser);
                temp.Add("@bh", bh.Text.Trim());
                temp.Add("@skzhbh", val[1]);
                temp.Add("@skzhmc", val[2]);
                temp.Add("@je", val[3]);
                temp.Add("@bz", val[4]);
                Child1.Add(temp);
            }
            string ret = _cwglLogic.InsertSkd(dml, Child1);
            if (ret=="")
            {
                GetBH();
                AlertMessage("新增成功");
            }
            else
            {
                AlertMessage(ret);
            }
        }

        protected void tk_skzhbh_SelectedIndexChanged(object sender, RadComboBoxSelectedIndexChangedEventArgs e)
        {
            foreach(DataRow val in GlabalString.zhDataTable.Rows)
            {
                if (val[0].ToString() == tk_skzhbh.Text)
                {
                    zhm.Text = val[1].ToString();
                    khh.Text = val[2].ToString();
                    break;
                }
            }
        }

        protected void close_Click(object sender, EventArgs e)
        {
            JavaScript("window.location.href='SkdGl.aspx'");
        }

        protected void update_Click(object sender, EventArgs e)
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
                dml.Add("@fkdw", tk_fkdw.Text.Trim());
                dml.Add("@jsr", tk_jsr.Text.Trim());
                dml.Add("@bm", bm.Text.Trim());
                dml.Add("@htbh", tk_htbh.Text.Trim());
                dml.Add("@zy", dp_zy.SelectedItem.Text.Trim());
                dml.Add("@fjsm", fjsm.Text.Trim());
                dml.Add("@jsfs", jsfs.SelectedItem.Text);
                dml.Add("@yhje", yhje.Text.Trim());
                dml.Add("@hjje", hjje.Text.Trim());
            }
            catch
            {
                AlertMessage("数据存在错误，请检查");
                return;
            }
            List<DirModel> Child1 = new List<DirModel>();
            DirModel temp;
            foreach (DataRow val in dataTable.Rows)
            {
                temp = new DirModel();
                temp.Add("@user_no", model.LoginUser);
                temp.Add("@bh", bh.Text.Trim());
                temp.Add("@skzhbh", val[1]);
                temp.Add("@skzhmc", val[2]);
                temp.Add("@je", val[3]);
                temp.Add("@bz", val[4]);
                Child1.Add(temp);
            }
            string ret = _cwglLogic.UpdateSkd(dml, Child1);
            if (ret == "")
            {
                AlertMessage("修改成功");
            }
            else
            {
                AlertMessage(ret);
            }
        }

        protected void yhje_TextChanged(object sender, EventArgs e)
        {
            if (dataTable.Rows.Count > 0)
            {
                var sum = dataTable.Compute("sum(je)", "TRUE");
                if (yhje.Text == "")
                    hjje.Text = sum.ToString();
                else
                    hjje.Text = Sub(sum.ToString(), yhje.Text);
            }
        }
    }
}