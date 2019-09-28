using System;
using System.Collections.Generic;
using System.Data;
using System.Web.UI.WebControls;
using Telerik.Web.UI;
using xs_System.Logic;
using xsFramework.UserControl.Pager;
using xsFramework.Web.Login;
using xsFramework.Web.WebPage;
using XSSystem.Class;

namespace XSSystem.Page.P_Order
{
    public partial class Wtjght : AuthWebPage
    {
        HTGLLogic _htglLogic = new HTGLLogic();
        static DataTable dataTable;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropListInit();
                if (Session["wtjght"] != null)
                {
                    InitData(Session["wtjght"]);
                }
                InitDataTable();
                InitGridView();
            }
            
        }

        private void InitDataTable()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("bh", Type.GetType("System.Int32"));
            dataTable.Columns.Add("wlmc", Type.GetType("System.String"));
            dataTable.Columns.Add("jgf", Type.GetType("System.Double"));
            dataTable.Columns.Add("cmzb", Type.GetType("System.String"));
            dataTable.Columns.Add("bz", Type.GetType("System.String"));


        }


        public void InitData(object mk)
        {
            DataTable dt = mk as DataTable;
            htbh.Text = dt.Rows[0][1].ToString();
            htlx.SelectedItem.Text = dt.Rows[0][2].ToString();
            qdrq.Text = dt.Rows[0][3].ToString();
            tk_wtf.SelectedItem.Text = dt.Rows[0][4].ToString();
            tk_stf.SelectedItem.Text = dt.Rows[0][5].ToString();
            kplx.SelectedItem.Text = dt.Rows[0][6].ToString();
            zxqxQ.Text = dt.Rows[0][7].ToString();
            zxqxZ.Text = dt.Rows[0][8].ToString();
            Session.Remove("wtjght");
        }

        public void InitGridView()
        {
            PagerParameter pagepara = new PagerParameter();
            pagepara.DbConn = GlabalString.DBString;
            QueryClass qc = new QueryClass();
            LoginModel model = Session["LoginModel"] as LoginModel;
            qc.user_no = model.LoginUser;
            qc.htbh = htbh.Text;
            qc.tableName = "xs_WtjghtTable_Jgxx";
            pagepara.Sql = _htglLogic.QueryCghtChildTable(qc);
            pagepara.OrderBy = "htbh";

            PageChangedEventArgs e = new PageChangedEventArgs(0);
            var temp= xsPageHelper.BindPager(pagepara, e);
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
                dml.Add("@qdrq", Convert.ToDateTime(qdrq.Text.Trim()));//????
                dml.Add("@wtf", tk_wtf.SelectedItem.Text.Trim());
                dml.Add("@stf", tk_stf.SelectedItem.Text.Trim());
                dml.Add("@kplx", kplx.SelectedItem.Text.Trim());
                dml.Add("@zxqxQ", Convert.ToDateTime(zxqxQ.Text));
                dml.Add("@zxqxZ", Convert.ToDateTime(zxqxZ.Text));
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
                    temp.Add("@wlmc", val[1]);
                    temp.Add("@jgf", val[2]);
                    temp.Add("@cmzb", val[3]);
                    temp.Add("@bz", val[4]);
                    Child1.Add(temp);
            }
            string reply = _htglLogic.InsertWtjght(dml, Child1);
            if (reply == "")
            {
                AlertMessage("新增成功");
            }
            else
            {
                AlertMessage(reply);
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
                dml.Add("@kplx", kplx.SelectedItem.Text.Trim());
                dml.Add("@zxqxQ", Convert.ToDateTime(zxqxQ.Text));
                dml.Add("@zxqxZ", Convert.ToDateTime(zxqxZ.Text));
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
                    temp.Add("@wlmc", val[1]);
                    temp.Add("@jgf", val[2]);
                    temp.Add("@cmzb", val[3]);
                    temp.Add("@bz", val[4]);
                    Child1.Add(temp);
            }
            string reply = _htglLogic.UpdateWtjghtht(dml, Child1);
            if (reply == "")
            {
                AlertMessage("修改成功");
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
            if (_htglLogic.ShengHeOrder(dml, "xs_WtjgTable"))
            {
                // AlertMessage("审核订单成功");
                AlertMessageAndGoTo("审核成功", "WtjghtGl.aspx");
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
            if (_htglLogic.ZhiXingOrder(dml, "xs_WtjgTable"))
            {
                // AlertMessage("审核订单成功");
                AlertMessageAndGoTo("执行成功", "WtjghtGl.aspx");
            }
            else
            {
                AlertMessage("执行订单失败");
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
                dr[1] = wlmc.Text;
                dr[2] = double.Parse(jgf.Text.Trim());
                dr[3] = cmzb.Text;
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
            string[] arrList = new string[2];
            arrList[0] = "wtf";
            arrList[1] = "stf";
            pagepara.Sql = ht.QueryDropList("xs_WtjgTable", arrList);
            pagepara.OrderBy = "wtf";
            DataTable dt1 = xsPageHelper.BindPager(pagepara);
            htbh.Text = "HTJG" + DateTime.Now.ToString("yyyyMMdd") + "-" + dt1.Rows.Count;

            RadComboBoxItem radcbItem;
            RadComboBoxItem radcbItem2;
            DataTable dt = GlabalString.GetGongSi();
            if (dt.Rows.Count != 0)
            {

                foreach (DataRow val in dt.Rows)
                {
                    radcbItem = new RadComboBoxItem(val[0].ToString());
                    radcbItem2 = new RadComboBoxItem(val[0].ToString());
                    tk_stf.Items.Add(radcbItem);
                    tk_wtf.Items.Add(radcbItem2);
                }
                tk_stf.SelectedIndex = 1;
                tk_wtf.SelectedIndex = 1;
            }
        }

        protected void close_Click(object sender, EventArgs e)
        {
            JavaScript("window.location.href='WtjghtGl.aspx'");
        }
    }
}