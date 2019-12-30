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
    public partial class Mkzxzcd : AuthWebPage
    {
        HTGLLogic _htglLogic = new HTGLLogic();
        static DataTable dataTable;
        protected void Page_Load(object sender, EventArgs e)
        {         
            if (!IsPostBack)
            {
                DropListInit();
                if (Session["mkzxzcd"] != null)
                {
                    InitData(Session["mkzxzcd"]);
                }
                InitDataTable();
                InitGridView();
            }
        }

        protected void DropListInit()
        {
            RadComboBoxItem radcbItem;
            RadComboBoxItem radcbItem2;
            DataTable dt = GlabalString.GetGongSi();
            if (dt.Rows.Count != 0)
            {

                foreach (DataRow val in dt.Rows)
                {
                    radcbItem = new RadComboBoxItem(val[0].ToString());
                    radcbItem2 = new RadComboBoxItem(val[0].ToString());
                    tk_ghf.Items.Add(radcbItem);
                    tk_shf.Items.Add(radcbItem2);
                }
                tk_ghf.SelectedIndex = 1;
                tk_shf.SelectedIndex = 1;
            }

        }

        private void InitDataTable()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("djbh", System.Type.GetType("System.String"));
            dataTable.Columns.Add("bh", System.Type.GetType("System.String"));
            dataTable.Columns.Add("bdh", System.Type.GetType("System.String"));
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
            cghth.Text = dt.Rows[0][3].ToString();
            tk_ghf.Text = dt.Rows[0][4].ToString();

            tk_shf.Text = dt.Rows[0][5].ToString();
            mkmc.Text = dt.Rows[0][6].ToString();
            wlmc.Text = dt.Rows[0][7].ToString();
            cydw.Text = dt.Rows[0][8].ToString();
            yj.Text = dt.Rows[0][9].ToString();

            cgmj.Text = dt.Rows[0][10].ToString();
            xsmj.Text = dt.Rows[0][11].ToString();
            Session.Remove("mkzxzcd");
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
                dml.Add("@user_no", model.LoginUser);
                dml.Add("@djbh", djbh.Text.Trim());
                dml.Add("@zcsj", Convert.ToDateTime(zcsj.Text.Trim()));
                dml.Add("@cghth", cghth.Text.Trim());
                dml.Add("@ghf", tk_ghf.SelectedItem.Text.Trim());
                dml.Add("@shf", tk_shf.SelectedItem.Text.Trim());
                dml.Add("@mkmc", mkmc.Text.Trim());
                dml.Add("@wlmc", wlmc.Text.Trim());
                dml.Add("@cydw", cydw.Text.Trim());
                dml.Add("@yj", float.Parse(yj.Text.Trim()));
                dml.Add("@cgmj", float.Parse(cgmj.Text.Trim()));
                dml.Add("@xsmj", float.Parse(xsmj.Text.Trim()));
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
                    temp.Add("@djbh", djbh.Text.Trim());
                    temp.Add("@user_no", model.LoginUser);
                    temp.Add("@bdh", val[2]);                   
                    temp.Add("@thdh", val[3]);
                    temp.Add("@ch", val[4]);
                    temp.Add("@zcmz", val[5]);
                    temp.Add("@zcpz", val[6]);
                    temp.Add("@zcjz", val[7]);
                    temp.Add("@yfyf", val[8]);
                    temp.Add("@cgjsje", val[9]);
                    temp.Add("@xsjsje", val[10]);
                    temp.Add("@bz", val[11]);
                    temp.Add("@zt", val[12]);
                    Child1.Add(temp);
            }
            string reply = _htglLogic.InsertMkzxzcd(dml, Child1);
            if (reply == "")
            {
                //     AlertMessageAndGoTo("新增成功", "Cght.aspx");
                AlertMessage("新增成功");
                //  xsPage.RefreshPage();
            }
            else
            {
                AlertMessage(reply);
            }
        }

        protected void AddClxx(object sender,EventArgs e)
        {
            if (!DataChecked(2))
            {
                return;
            }
            foreach(DataRow val in dataTable.Rows)
            {
                if (val[3].ToString() == bdh.Text)
                {
                    AlertMessage("磅单号已存在");
                    return;
                }
                else
                    continue;
            }
            DataRow dr = dataTable.NewRow();
            try
            {
                dr[2] = bdh.Text;
                dr[3] = thdh.Text;
                dr[4] = ch.Text;
                dr[5] = double.Parse(zcmz.Text);
                dr[6] = double.Parse(zcpz.Text);
                dr[7] = double.Parse(zcjz.Text);
                dr[8] = double.Parse(yfyf.Text);
                dr[9] = double.Parse(cgjsje.Text);
                dr[10] = double.Parse(xsjsje.Text);
                dr[11] = bz.Text;
                dr[12] = zt.Text;
            }
            catch(Exception ex)
            {
                AlertMessage(string.Format("数据存在错误,错误信息{0}",ex.Message));
                return;
            }
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
            var temp = xsPageHelper.BindPager(pagepara, e);
            foreach (DataRow val in temp.Rows)
            {
                DataRow dr = dataTable.NewRow();
                dr[0] = val[1];
                dr[1] = val[2];
                dr[2] = val[3];
                dr[3] = val[4];
                dr[4] = val[5];
                dr[5] = val[6];
                dr[6] = val[7];
                dr[7] = val[8];
                dr[8] = val[9];
                dr[9] = val[10];
                dr[10] = val[11];
                dr[11] = val[12];
                dr[12] = val[13];
                dataTable.Rows.Add(dr);

            }
            this.GridView1.DataSource = dataTable;
            this.GridView1.DataBind();
        }

        protected void refresh_Click(object sender, EventArgs e)
        {
            if (!CalDataChecked(1))
            {
                return;
            }
            zcjz.Text = Sub(zcmz.Text, zcpz.Text);
            yfyf.Text = Mul(zcjz.Text, yj.Text);
            cgjsje.Text = Mul(zcjz.Text, cgmj.Text);
            xsjsje.Text = Mul(Add(yj.Text, xsmj.Text), zcjz.Text);
            return;
        }

        protected void close_Click(object sender, EventArgs e)
        {
            JavaScript("window.location.href='MkzxzcdGl.aspx'");

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
                dml.Add("@djbh", djbh.Text.Trim());
                dml.Add("@zcsj", Convert.ToDateTime(zcsj.Text.Trim()));
                dml.Add("@cghth", cghth.Text.Trim());
                dml.Add("@ghf", tk_ghf.SelectedItem.Text.Trim());
                dml.Add("@shf", tk_shf.SelectedItem.Text.Trim());
                dml.Add("@mkmc", mkmc.Text.Trim());
                dml.Add("@wlmc", wlmc.Text.Trim());
                dml.Add("@cydw", cydw.Text.Trim());
                dml.Add("@yj", float.Parse(yj.Text.Trim()));
                dml.Add("@cgmj", float.Parse(cgmj.Text.Trim()));
                dml.Add("@xsmj", float.Parse(xsmj.Text.Trim()));
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
                    temp.Add("@djbh", djbh.Text.Trim());
                    temp.Add("@user_no", model.LoginUser);
                    temp.Add("@bdh", val[2]);
                    temp.Add("@thdh", val[3]);
                    temp.Add("@ch", val[4]);
                    temp.Add("@zcmz", val[5]);
                    temp.Add("@zcpz", val[6]);
                    temp.Add("@zcjz", val[7]);
                    temp.Add("@yfyf", val[8]);
                    temp.Add("@cgjsje", val[9]);
                    temp.Add("@xsjsje", val[10]);
                    temp.Add("@bz", val[11]);
                    temp.Add("@zt", val[12]);
                    Child1.Add(temp);
            }
            string reply = _htglLogic.UpdateMkzxzcd(dml, Child1);
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

        protected void DelJgxx(object sender, EventArgs e)
        {
            int index = int.Parse((sender as Button).CommandArgument);
            dataTable.Rows.Remove(dataTable.Rows[index]);

            //for (int i = 0; i < dataTable.Rows.Count; i++)
            //{
            //    if (dataTable.Rows[i][0].ToString().Equals(id))
            //    {
            //        dataTable.Rows.Remove(dataTable.Rows[i]);
            //        break;
            //    }
            //    else
            //    {
            //        continue;
            //    }
            //}
            GridView1.DataSource = dataTable;
            GridView1.DataBind();
        }
    }
}