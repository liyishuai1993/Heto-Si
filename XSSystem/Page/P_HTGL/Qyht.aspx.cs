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
    public partial class Qyht : AuthWebPage
    {
        HTGLLogic _htglLogic = new HTGLLogic();
        static DataTable dataTable;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                DropListInit();
                if (Session["qyht"] != null)
                {
                    InitData(Session["qyht"]);
                }
                // 
                InitDataTable();
                InitGridView();
            }
            
        }

        private void InitDataTable()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("bh", System.Type.GetType("System.Int32"));
            dataTable.Columns.Add("wlmc", System.Type.GetType("System.String"));
            dataTable.Columns.Add("qyd", System.Type.GetType("System.String"));
            dataTable.Columns.Add("mdd", System.Type.GetType("System.String"));
            dataTable.Columns.Add("yj", System.Type.GetType("System.Double"));
            dataTable.Columns.Add("yflhbz", System.Type.GetType("System.Double"));
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
            dfhth.Text = dt.Rows[0][4].ToString();
            tk_wtf.SelectedItem.Text = dt.Rows[0][5].ToString();
            tk_stf.SelectedItem.Text = dt.Rows[0][6].ToString();
            kplx.SelectedItem.Text = dt.Rows[0][7].ToString();
            zxqxQ.Text = dt.Rows[0][8].ToString();
            zxqxZ.Text = dt.Rows[0][9].ToString();

            Session.Remove("qyht");
        }



        public void InitGridView()
        {
            PagerParameter pagepara = new PagerParameter();
            pagepara.DbConn = GlabalString.DBString;
            QueryClass qc = new QueryClass();
            LoginModel model = Session["LoginModel"] as LoginModel;
            qc.user_no = model.LoginUser;
            qc.htbh = htbh.Text;
            qc.tableName = "xs_QyhtTable_Jgxx";
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
                dml.Add("@htbh", htbh.Text.Trim());
                dml.Add("@userid", model.LoginUser);
                dml.Add("@htlx", htlx.SelectedItem.Text.Trim());
                dml.Add("@qdrq", Convert.ToDateTime(qdrq.Text.Trim()));//????
                dml.Add("@dfhth", dfhth.Text.Trim());
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
                if ((bool)val[8])
                {
                    temp = new DirModel();
                    temp.Add("@htbh", htbh.Text.Trim());
                    temp.Add("@user_no", model.LoginUser);
                    temp.Add("@wlmc", val[1]);
                    temp.Add("@qyd", val[2]);
                    temp.Add("@mdd", val[3]);
                    temp.Add("@yj", val[4]);
                    temp.Add("@yflhbz", val[5]);
                    temp.Add("@zxzt", val[6]);
                    temp.Add("@bz", val[7]);
                    Child1.Add(temp);
                }
            }

            if (_htglLogic.InsertQyht(dml,Child1))
            {
                AlertMessageAndGoTo("新增成功", "Qyht.aspx");
            }
        }

        protected void update_Click(object sender, EventArgs e)
        {
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;
            dml.Add("@htbh", htbh.Text.Trim());
            dml.Add("@userid", model.LoginUser);
            dml.Add("@htlx", htlx.SelectedItem.Text.Trim());
            dml.Add("@qdrq", Convert.ToDateTime(qdrq.Text.Trim()));//????
            dml.Add("@dfhth", dfhth.Text.Trim());
            dml.Add("@wtf", tk_wtf.SelectedItem.Text.Trim());
            dml.Add("@stf", tk_stf.SelectedItem.Text.Trim());
            dml.Add("@kplx", kplx.SelectedItem.Text.Trim());
            dml.Add("@zxqxQ", Convert.ToDateTime(zxqxQ.Text));
            dml.Add("@zxqxZ", Convert.ToDateTime(zxqxZ.Text));
            if (_htglLogic.UpdateQyht(dml))
            {
                AlertMessageAndGoTo("修改成功", "QyhtGl.aspx");
            }
        }

        protected void AddJgxx(object sender, EventArgs e)
        {
            if (!DataChecked(2))
            {
                return;
            }
            //string shtbh = htbh.Text;
            //Response.Write("<script>window.showModelessDialog('QyhtJgxx.aspx?transmissionInfo=" + shtbh + "')</script>");
            DataRow dr = dataTable.NewRow();
            try
            {
                dr[0] = dataTable.Rows.Count + 1;
                dr[1] = wlmc.Text;
                dr[2] = tk_qyd.SelectedItem.Text;
                dr[3] = tk_mdd.SelectedItem.Text;
                dr[4] = double.Parse(yj.Text.Trim());
                dr[5] = double.Parse(yflhbz.Text.Trim());
                dr[6] = zxzt.Text;
                dr[7] = bz.Text;
                dr[8] = true;
            }
            catch(Exception ex)
            {
                AlertMessage("数据存在错误，请检查,"+ex.Message);
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

        protected void btnShengHe_Click(object sender, EventArgs e)
        {
            DirModel dml = new DirModel();
            dml.Add("@htbh", htbh.Text.Trim());
            if (_htglLogic.ShengHeOrder(dml, "xs_QyhtTable"))
            {
                // AlertMessage("审核订单成功");
                AlertMessageAndGoTo("审核成功", "QyhtGl.aspx");
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
            if (_htglLogic.ZhiXingOrder(dml, "xs_QyhtTable"))
            {
                // AlertMessage("审核订单成功");
                AlertMessageAndGoTo("执行成功", "QyhtGl.aspx");
            }
            else
            {
                AlertMessage("执行订单失败");
            }
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
            pagepara.Sql = ht.QueryDropList("xs_QyhtTable", arrList);
            pagepara.OrderBy = "wtf";
            PageChangedEventArgs e = new PageChangedEventArgs(1);
            DataTable dt1 = xsPageHelper.BindPager(pagepara, e);
            htbh.Text = "HTQY" + DateTime.Now.ToString("yyyyMMdd") + "-"+dt1.Rows.Count;

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
            dt = GlabalString.GetCangKu();
            if (dt.Rows.Count != 0)
            {
                foreach (DataRow val in dt.Rows)
                {
                    radcbItem = new RadComboBoxItem(val[0].ToString());
                    radcbItem2 = new RadComboBoxItem(val[0].ToString());
                    tk_qyd.Items.Add(radcbItem);
                    tk_mdd.Items.Add(radcbItem2);
                }
                tk_qyd.SelectedIndex = 1;
                tk_mdd.SelectedIndex = 1;
            }
        }

    }
}