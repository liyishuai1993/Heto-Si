using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;
using xs_System.Logic;
using xsFramework.UserControl.Pager;
using xsFramework.Web.Login;
using xsFramework.Web.WebPage;
using XSSystem.Class;

namespace XSSystem.Page.P_Order
{
    public partial class Tyht : AuthWebPage
    {

        HTGLLogic _htglLogic = new HTGLLogic();
        static DataTable dataTable;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                DropListInit();
                if (Session["tyht"] != null)
                {
                    InitData(Session["tyht"]);
                }
                InitDataTable();
                InitGridView();
            }
            
        }

        public void InitData(object mk)
        {
            DataTable dt = mk as DataTable;
            htbh.Text = dt.Rows[0][1].ToString();
            htlx.SelectedItem.Text = dt.Rows[0][2].ToString();
            qdrq.Text = dt.Rows[0][3].ToString();
            tk_wtf.SelectedItem.Text = dt.Rows[0][4].ToString();
            tk_stf.SelectedItem.Text = dt.Rows[0][5].ToString();
            tk_fmmc.SelectedItem.Text = dt.Rows[0][6].ToString();
            tk_wlmc.SelectedItem.Text = dt.Rows[0][7].ToString();
            zxqxQ.Text = dt.Rows[0][8].ToString();
            zxqxZ.Text = dt.Rows[0][9].ToString();
            tk_zcz.SelectedItem.Text = dt.Rows[0][10].ToString();
            tk_zdz.SelectedItem.Text = dt.Rows[0][11].ToString();
            xlx.SelectedItem.Text = dt.Rows[0][12].ToString();
            sl.Text = dt.Rows[0][13].ToString();
            Session.Remove("tyht");
        }

        private void InitDataTable()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("bh", System.Type.GetType("System.Int32"));
            dataTable.Columns.Add("gsmc", System.Type.GetType("System.String"));
            dataTable.Columns.Add("dfhth", System.Type.GetType("System.String"));
            dataTable.Columns.Add("kplx", System.Type.GetType("System.String"));
            dataTable.Columns.Add("zbxsf", System.Type.GetType("System.Double"));

            dataTable.Columns.Add("dlf", System.Type.GetType("System.Double"));
            dataTable.Columns.Add("zxf", System.Type.GetType("System.Double"));
            dataTable.Columns.Add("sfzdd", System.Type.GetType("System.Double"));
            dataTable.Columns.Add("tlyf", System.Type.GetType("System.Double"));
            dataTable.Columns.Add("dzzxf", System.Type.GetType("System.Double"));

            dataTable.Columns.Add("dzmcddf", System.Type.GetType("System.Double"));
            dataTable.Columns.Add("dzdlf", System.Type.GetType("System.Double"));

        }

        public void InitGridView()
        {
            PagerParameter pagepara = new PagerParameter();
            pagepara.DbConn = GlabalString.DBString;
            QueryClass qc = new QueryClass();
            LoginModel model = Session["LoginModel"] as LoginModel;
            qc.user_no = model.LoginUser;
            qc.htbh = htbh.Text;
            qc.tableName = "xs_TyhtTable_Jgxx";
            pagepara.Sql = _htglLogic.QueryCghtChildTable(qc);
            pagepara.OrderBy = "htbh";

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
                dr[5] = val[7];
                dr[6] = val[8];
                dr[7] = val[9];
                dr[8] = val[10];
                dr[9] = val[11];
                dr[10] = val[12];
                dr[11] = val[13];
                dataTable.Rows.Add(dr);

            }
            if (dataTable.Columns.Count == 0)
            {
                InitDataTable();
            }
            this.GridView1.DataSource = dataTable;
            this.GridView1.DataBind();
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            if (!DataChecked(1))
            {
                return;
            }
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;
            try
            {
                dml.Add("@htbh", htbh.Text.Trim());// ??????
                dml.Add("@userid", model.LoginUser);
                dml.Add("@htlx", htlx.SelectedItem.Text.Trim());
                dml.Add("@qdrq", Convert.ToDateTime(qdrq.Text.Trim()));
                dml.Add("@wtf", tk_wtf.SelectedItem.Text.Trim());
                dml.Add("@stf", tk_stf.SelectedItem.Text.Trim());
                dml.Add("@fmmc", tk_fmmc.SelectedItem.Text.Trim());
                dml.Add("@wlmc", tk_wlmc.SelectedItem.Text.Trim());
                dml.Add("@zxqxQ", Convert.ToDateTime(zxqxQ.Text));
                dml.Add("@zxqxZ", Convert.ToDateTime(zxqxZ.Text));
                dml.Add("@zcz", tk_zcz.SelectedItem.Text.Trim());
                dml.Add("@zdz", tk_zdz.SelectedItem.Text.Trim());
                dml.Add("@xlx", xlx.SelectedItem.Text.Trim());
                dml.Add("@sl", int.Parse(sl.Text.Trim()));
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
                    temp.Add("@htbh", htbh.Text.Trim());
                    temp.Add("@user_no", model.LoginUser);
                    temp.Add("@gsmc", val[1]);
                    temp.Add("@dfhth", val[2]);
                    temp.Add("@kplx", val[3]);
                    temp.Add("@zbxsf", val[4]);
                    temp.Add("@dlf", val[5]);
                    temp.Add("@zxf", val[6]);
                    temp.Add("@sfzdd", val[7]);
                    temp.Add("@tlyf", val[8]);
                    temp.Add("@dzzxf", val[9]);
                    temp.Add("@dzmcddf", val[10]);
                    temp.Add("@dzdlf", val[11]);
                    Child1.Add(temp);
            }
            string reply = _htglLogic.InsertTyht(dml, Child1);
            if (reply == "")
            {
                AlertMessage("新增成功");
            }
            else
            {
                AlertMessage(reply);
            }
        }

        protected void btnShengHe_Click(object sender, EventArgs e)
        {
            DirModel dml = new DirModel();
            dml.Add("@htbh", htbh.Text.Trim());
            if (_htglLogic.ShengHeOrder(dml, "xs_TyhtTable"))
            {
                // AlertMessage("审核订单成功");
                AlertMessageAndGoTo("审核成功", "TyhtGl.aspx");
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
            if (_htglLogic.ZhiXingOrder(dml, "xs_TyhtTable"))
            {
                // AlertMessage("审核订单成功");
                AlertMessageAndGoTo("执行成功", "TyhtGl.aspx");
            }
            else
            {
                AlertMessage("执行订单失败");
            }
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
                dml.Add("@htbh", htbh.Text.Trim());// ??????
                dml.Add("@userid", model.LoginUser);
                dml.Add("@htlx", htlx.SelectedItem.Text.Trim());
                dml.Add("@qdrq", Convert.ToDateTime(qdrq.Text.Trim()));//????
                dml.Add("@wtf", tk_wtf.SelectedItem.Text.Trim());
                dml.Add("@stf", tk_stf.SelectedItem.Text.Trim());
                dml.Add("@fmmc", tk_fmmc.SelectedItem.Text.Trim());
                dml.Add("@wlmc", tk_wlmc.SelectedItem.Text.Trim());
                dml.Add("@zxqxQ", Convert.ToDateTime(zxqxQ.Text));
                dml.Add("@zxqxZ", Convert.ToDateTime(zxqxZ.Text));
                dml.Add("@zcz", tk_zcz.SelectedItem.Text.Trim());
                dml.Add("@zdz", tk_zdz.SelectedItem.Text.Trim());
                dml.Add("@xlx", xlx.SelectedItem.Text.Trim());
                dml.Add("@sl", int.Parse(sl.Text.Trim()));
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
                    temp.Add("@htbh", htbh.Text.Trim());
                    temp.Add("@user_no", model.LoginUser);
                    temp.Add("@gsmc", val[1]);
                    temp.Add("@dfhth", val[2]);
                    temp.Add("@kplx", val[3]);
                    temp.Add("@zbxsf", val[4]);
                    temp.Add("@dlf", val[5]);
                    temp.Add("@zxf", val[6]);
                    temp.Add("@sfzdd", val[7]);
                    temp.Add("@tlyf", val[8]);
                    temp.Add("@dzzxf", val[9]);
                    temp.Add("@dzmcddf", val[10]);
                    temp.Add("@dzdlf", val[11]);
                    Child1.Add(temp);
            }

            string reply = _htglLogic.UpdateTyht(dml, Child1);
            if (reply == "")
            {
                //     AlertMessageAndGoTo("新增成功", "Cght.aspx");
                AlertMessage("修改成功");
                //  xsPage.RefreshPage();
            }
            else
            {
                AlertMessage(reply);
            }
        }

        protected void AddJgxx(object sender, EventArgs e)
        {
            if (!DataChecked(2))
            {
                return;
            }
            DataRow dr = dataTable.NewRow();
            try
            {
                dr[0] = dataTable.Rows.Count + 1;
                dr[1] = tk_gsmc.SelectedItem.Text;
                dr[2] = dfhth.Text;
                dr[3] = kplx.Text;
                dr[4] = double.Parse(zbxsf.Text.Trim());
                dr[5] = double.Parse(dlf.Text.Trim());
                dr[6] = double.Parse(zxf.Text.Trim());
                dr[7] = double.Parse(sfzdd.Text.Trim());
                dr[8] = double.Parse(tlyf.Text.Trim());
                dr[9] = double.Parse(dzzxf.Text.Trim());
                dr[10] = double.Parse(dzmcddf.Text.Trim());
                dr[11] = double.Parse(dzdlf.Text.Trim());
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
            GridView1.DataSource = dataTable;
            GridView1.DataBind();
        }


        protected void DropListInit()
        {
            PagerParameter pagepara = new PagerParameter();
            QueryClass qc = new QueryClass();
            pagepara.DbConn = GlabalString.DBString;
            //pagepara.XsPager=
            HTGLLogic ht = new HTGLLogic();
            string[] arrList = new string[6];
            arrList[0] = "wtf";
            arrList[1] = "stf";
            arrList[2] = "fmmc";
            arrList[3] = "wlmc";
            arrList[4] = "zcz";
            arrList[5] = "zdz";
            pagepara.Sql = ht.QueryDropList("xs_TyhtTable", arrList);
            pagepara.OrderBy = "wtf";
            DataTable dt1 = xsPageHelper.BindPager(pagepara);
            htbh.Text = "HTTY" + DateTime.Now.ToString("yyyyMMdd") + "-" + dt1.Rows.Count;

            RadComboBoxItem radcbItem;
            RadComboBoxItem radcbItem2;
            RadComboBoxItem radcbItem3;
            DataTable dt = GlabalString.GetGongSi();
            if (dt.Rows.Count != 0)
            {

                foreach (DataRow val in dt.Rows)
                {
                    radcbItem = new RadComboBoxItem(val[0].ToString());
                    radcbItem2 = new RadComboBoxItem(val[0].ToString());
                    radcbItem3 = new RadComboBoxItem(val[0].ToString());
                    tk_wtf.Items.Add(radcbItem);
                    tk_stf.Items.Add(radcbItem2);
                    tk_gsmc.Items.Add(radcbItem3);
                }
                tk_wtf.SelectedIndex = 1;
                tk_stf.SelectedIndex = 1;
            }
            dt = GlabalString.GetCangKu();
            if (dt.Rows.Count != 0)
            {
                foreach (DataRow val in dt.Rows)
                {
                    radcbItem = new RadComboBoxItem(val[0].ToString());
                    radcbItem2 = new RadComboBoxItem(val[0].ToString());
                    tk_zcz.Items.Add(radcbItem);
                    tk_zdz.Items.Add(radcbItem2);
                }
                tk_zcz.SelectedIndex = 1;
                tk_zdz.SelectedIndex = 1;
            }

            dt = GlabalString.GetMeiCang();
            if (dt.Rows.Count != 0)
            {
                foreach (DataRow val in dt.Rows)
                {
                    radcbItem = new RadComboBoxItem(val[0].ToString());
                    tk_fmmc.Items.Add(radcbItem);
                }
                tk_fmmc.SelectedIndex = 1;
            }

            dt = GlabalString.GetMZMC();
            if (dt.Rows.Count != 0)
            {
                foreach (DataRow val in dt.Rows)
                {
                    radcbItem = new RadComboBoxItem(val[0].ToString());
                    tk_wlmc.Items.Add(radcbItem);
                }
                tk_wlmc.SelectedIndex = 1;
            }
        }

        protected void close_Click(object sender, EventArgs e)
        {
            JavaScript("window.location.href='TyhtGl.aspx'");
        }
    }
}