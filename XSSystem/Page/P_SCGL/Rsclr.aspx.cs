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
using XSSystem.Logic;

namespace XSSystem.Page.P_Order
{
    public partial class Rsclr : AuthWebPage
    {
        static DataTable Scxx_dataTable;

        static DataTable Ccxx_dataTable;

        CWGLLogic _cwglLogic = new CWGLLogic();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropListInit();
                if (Session["rsclr"] != null)
                {
                    InitData(Session["rsclr"]);
                }
                else
                {
                    bh.Text = DateTime.Now.ToString("yyyyMMddHHmmss");
                }
                
                InitDataTable();
                InitDataTable2();
                InitGridView();
                InitGridView2();
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
            qc.tableName = "xs_RsclrTable_Scxx";
            pagepara.Sql = _cwglLogic.QueryChildTable(qc);
            pagepara.OrderBy = "bh";
            PageChangedEventArgs e = new PageChangedEventArgs(0);
            var temp  = xsPageHelper.BindPager(pagepara, e);
            foreach (DataRow val in temp.Rows)
            {
                DataRow dr = Scxx_dataTable.NewRow();
                dr[0] = val[3];
                dr[1] = val[4];
                dr[2] = val[5];
                dr[3] = val[6];
                dr[4] = val[7];
                dr[5] = val[8];
                dr[6] = val[9];
                dr[7] = val[10];
                dr[8] = val[11];
                dr[9] = val[12];
                dr[10] = val[13];
                dr[11] = val[14];
                dr[12] = false;
                Scxx_dataTable.Rows.Add(dr);

            }
            this.GridView_SCXX.DataSource = Scxx_dataTable;
            this.GridView_SCXX.DataBind();
        }

        public void InitGridView2()
        {
            PagerParameter pagepara = new PagerParameter();
            pagepara.DbConn = GlabalString.DBString;
            QueryClass2 qc = new QueryClass2();
            LoginModel model = Session["LoginModel"] as LoginModel;
            qc.user_no = model.LoginUser;
            qc.bh = bh.Text;
            qc.tableName = "xs_RsclrTable_Ccxx";
            pagepara.Sql = _cwglLogic.QueryChildTable(qc);
            pagepara.OrderBy = "bh";
            PageChangedEventArgs e = new PageChangedEventArgs(0);
            var temp = xsPageHelper.BindPager(pagepara, e);
            foreach (DataRow val in temp.Rows)
            {
                DataRow dr = Scxx_dataTable.NewRow();
                dr[0] = val[3];
                dr[1] = val[4];
                dr[2] = val[5];
                dr[3] = val[6];
                dr[4] = val[7];
                dr[5] = false;
                Scxx_dataTable.Rows.Add(dr);

            }
            this.GridView_CCXX.DataSource = Ccxx_dataTable;
            this.GridView_CCXX.DataBind();
        }

        public void InitData(object mk)
        {
            DataTable dt = mk as DataTable;
            bh.Text = dt.Rows[0][1].ToString();
            ssmc.Text = dt.Rows[0][2].ToString();
            rq.Text = dt.Rows[0][3].ToString();
            kjsj.Text = dt.Rows[0][4].ToString();
            gjsj.Text = dt.Rows[0][5].ToString();
            bc.SelectedItem.Text = dt.Rows[0][6].ToString();
            ydzs.Text = dt.Rows[0][7].ToString();
            yddh.Text = dt.Rows[0][8].ToString();
            ymzs.Text = dt.Rows[0][9].ToString();
            DropDownList_gsmc.SelectedItem.Text = dt.Rows[0][10].ToString();
            Session.Remove("rsclr");
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
                dml.Add("@bh", bh.Text);
                dml.Add("@ssmc", ssmc.Text.Trim());
                dml.Add("@rq", Convert.ToDateTime(rq.Text.ToString()));
                dml.Add("@kjsj", Convert.ToDateTime(kjsj.Text.ToString()));
                dml.Add("@gjsj", Convert.ToDateTime(gjsj.Text.ToString()));
                dml.Add("@bc", bc.Text.Trim());
                dml.Add("@ydzs", float.Parse(ydzs.Text.Trim()));
                dml.Add("@yddh", float.Parse(yddh.Text.Trim()));
                dml.Add("@ymzs", float.Parse(ymzs.Text.Trim()));
                dml.Add("@gsmc", DropDownList_gsmc.SelectedItem.Text.Trim());
            }
            catch
            {
                AlertMessage("数据存在错误，请检查");
                return;
            }

            List<DirModel> Child1 = new List<DirModel>();
            DirModel temp;
            foreach (DataRow dr in Scxx_dataTable.Rows)
            {
                if (!(bool)dr[12])
                {
                    continue;
                }
                temp = new DirModel();
                temp.Add("@user_no", model.LoginUser);
                temp.Add("@bh", bh.Text);
                temp.Add("@mz", dr[0]);
                temp.Add("@dj", dr[1]);
                temp.Add("@sl", dr[2]);
                temp.Add("@je", dr[3]);
                temp.Add("@klcl", dr[4]);
                temp.Add("@hhmcl", dr[5]);
                temp.Add("@mmcl", dr[6]);
                temp.Add("@zmcl", dr[7]);
                temp.Add("@nmcl", dr[8]);
                temp.Add("@gscl", dr[9]);
                temp.Add("@shl", dr[10]);
                Child1.Add(temp);
            }

            List<DirModel> Child2 = new List<DirModel>();
            foreach (DataRow dr in Ccxx_dataTable.Rows)
            {
                if ((bool)dr[5])
                {
                    temp = new DirModel();
                    temp.Add("@user_no", model.LoginUser);
                    temp.Add("@bh", bh.Text);
                    temp.Add("@mz", dr[0]);
                    temp.Add("@sl", dr[1]);
                    temp.Add("@je", dr[2]);
                    temp.Add("@cl", dr[3]);
                    Child2.Add(temp);
                }
            }
            string reply = _cwglLogic.InsertRsclr(dml, Child1, Child2);
            if (reply == "")
            {
                AlertMessage("新增成功");
            }
            else
            {
                AlertMessage(reply);
            }
        }
        

        private void InitDataTable()
        {
            Scxx_dataTable = new DataTable();
            Scxx_dataTable.Columns.Add("mz", System.Type.GetType("System.String"));
            Scxx_dataTable.Columns.Add("dj", Type.GetType("System.Double"));
            Scxx_dataTable.Columns.Add("je", Type.GetType("System.Double"));
           
            Scxx_dataTable.Columns.Add("sl", System.Type.GetType("System.Double"));
            Scxx_dataTable.Columns.Add("klcl", System.Type.GetType("System.Double"));
            Scxx_dataTable.Columns.Add("hhmcl", System.Type.GetType("System.Double"));
            Scxx_dataTable.Columns.Add("mmcl", System.Type.GetType("System.Double"));
            Scxx_dataTable.Columns.Add("zmcl", System.Type.GetType("System.Double"));
            Scxx_dataTable.Columns.Add("nmcl", System.Type.GetType("System.Double"));
            Scxx_dataTable.Columns.Add("gscl", System.Type.GetType("System.Double"));
            Scxx_dataTable.Columns.Add("shl", System.Type.GetType("System.Double"));
            Scxx_dataTable.Columns.Add("bh", Type.GetType("System.Int32"));
            Scxx_dataTable.Columns.Add("isadd", System.Type.GetType("System.Boolean"));


        }

        private void InitDataTable2()
        {
            Ccxx_dataTable = new DataTable();
            Ccxx_dataTable.Columns.Add("mz", System.Type.GetType("System.String"));
            Ccxx_dataTable.Columns.Add("je", System.Type.GetType("System.Double"));
            Ccxx_dataTable.Columns.Add("sl", System.Type.GetType("System.Double"));
            Ccxx_dataTable.Columns.Add("cl", System.Type.GetType("System.Double"));
            Ccxx_dataTable.Columns.Add("bh", Type.GetType("System.Int32"));
            Ccxx_dataTable.Columns.Add("isadd", System.Type.GetType("System.Boolean"));

        }

        //private bool InsertScxx(DataRow dr)
        //{
        //    DirModel dml = new DirModel();
        //    LoginModel model = Session["LoginModel"] as LoginModel;
        //    dml.Add("@user_no", model.LoginUser);
        //    dml.Add("@bh", bh.Text);
        //    dml.Add("@mz", dr[0]);
        //    dml.Add("@sl", dr[1]);
        //    dml.Add("@je", dr[2]);
        //    dml.Add("@klcl", dr[3]);
        //    dml.Add("@hhmcl", dr[4]);
        //    dml.Add("@mmcl", dr[5]);
        //    dml.Add("@zmcl", dr[6]);
        //    dml.Add("@nmcl", dr[7]);
        //    dml.Add("@gscl", dr[8]);
        //    dml.Add("@shl", dr[9]);
        //    return _cwglLogic.InsertRsclr_Scxx(dml);

        //}

        protected void scxx_tjmz_Click(object sender, EventArgs e)
        {

            if (!DataChecked(2))
                return;
            if(Scxx_dataTable.Rows.Count>0)
                Scxx_dataTable.Rows.RemoveAt(Scxx_dataTable.Rows.Count - 1);
            DataRow dr = Scxx_dataTable.NewRow();
            try
            {
                dr[0] = DropDownListMZ.SelectedItem.Text;
                dr[1] = double.Parse(sxcc_dj.Text.Trim());
                dr[2] = double.Parse(scxx_je.Text.Trim());
                dr[3] = double.Parse(scxx_sl.Text.Trim());
                dr[4] = double.Parse(klcl.Text.Trim());
                dr[5] = double.Parse(hhmcl.Text.Trim());
                dr[6] = double.Parse(mmcl.Text.Trim());
                dr[7] = double.Parse(zmcl.Text.Trim());
                dr[8] = double.Parse(nmcl.Text.Trim());
                dr[9] = double.Parse(gscl.Text.Trim());
                dr[10] = double.Parse(shl.Text.Trim());
                dr[11] = Scxx_dataTable.Rows.Count+1;
                dr[12] = true;
            }
            catch
            {
                AlertMessage("数据存在错误，请检查");
                return;
            }
            Scxx_dataTable.Rows.Add(dr);
            DataRow ldr = Scxx_dataTable.NewRow();
            ldr[0] = "合计";
            ldr[2] = Scxx_dataTable.Compute("sum(je)", "TRUE");
            ldr[3] = Scxx_dataTable.Compute("sum(sl)", "TRUE");
            Scxx_dataTable.Rows.Add(ldr);
            GridView_SCXX.DataSource = Scxx_dataTable;
            GridView_SCXX.DataBind();

            

        }

        protected void DropListInit()
        {
            RadComboBoxItem radcbItem;
            RadComboBoxItem radcbItem2;
            DataTable dt = GlabalString.GetMZMC();
            if (dt.Rows.Count != 0)
            {
                
                foreach (DataRow val in dt.Rows)
                {
                    radcbItem = new RadComboBoxItem(val[0].ToString());
                    radcbItem2=new RadComboBoxItem(val[0].ToString());
                    DropDownListMZ.Items.Add(radcbItem);
                    DropDownListMZ2.Items.Add(radcbItem2);
                }
                DropDownListMZ.SelectedIndex = 1;
                DropDownListMZ2.SelectedIndex = 1;
            }

            dt = GlabalString.GetGongSi();
            if (dt.Rows.Count != 0)
            {
                foreach (DataRow val in dt.Rows)
                {
                    radcbItem = new RadComboBoxItem(val[0].ToString());
                    DropDownList_gsmc.Items.Add(radcbItem);
                }
                DropDownList_gsmc.SelectedIndex = 1;
            }
            

            

        }

        protected void ccxx_tjmz_Click(object sender, EventArgs e)
        {
            if (!DataChecked(3) || string.IsNullOrEmpty(shl.Text.Trim()))
            {
                AlertMessage("数据和损耗率不能为空！");
                return;
            }
                
            
            if (Ccxx_dataTable.Rows.Count > 0)
                Ccxx_dataTable.Rows.RemoveAt(Ccxx_dataTable.Rows.Count - 1);
            DataRow dr = Ccxx_dataTable.NewRow();
            try
            {
                dr[0] = DropDownListMZ2.SelectedItem.Text;
                dr[1] = double.Parse(ccxx_je.Text.Trim());
                dr[2] = double.Parse(ccxx_sl.Text.Trim());
                dr[3] = double.Parse(ccxx_cl.Text.Trim());
                dr[4] = Ccxx_dataTable.Rows.Count + 1;
                dr[5] = true;
            }
            catch
            {
                AlertMessage("数据存在错误，请检查");
                return;
            }
            Ccxx_dataTable.Rows.Add(dr);
            DataRow ldr = Ccxx_dataTable.NewRow();
            ldr[0] = "合计";
            ldr[1] = Ccxx_dataTable.Compute("sum(je)", "TRUE");
            ldr[2] = (double)Ccxx_dataTable.Compute("sum(sl)", "TRUE")*(double.Parse(shl.Text.Trim())/100);
            Ccxx_dataTable.Rows.Add(ldr);
            GridView_CCXX.DataSource = Ccxx_dataTable;
            GridView_CCXX.DataBind();
            


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (!CalDataChecked(1))
                return;
            scxx_je.Text = Mul(sxcc_dj.Text, scxx_sl.Text);
            return;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            shl.Text = (100.0 - double.Parse(klcl.Text) - double.Parse(hhmcl.Text) - double.Parse(mmcl.Text) - double.Parse(zmcl.Text) - double.Parse(nmcl.Text) - double.Parse(gscl.Text)).ToString("f3");
            return;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            double a =(double) Ccxx_dataTable.Rows[Ccxx_dataTable.Rows.Count - 1][1];
            double b = (double)Scxx_dataTable.Rows[Scxx_dataTable.Rows.Count - 1][2];
            if (a != (b + double.Parse(jgfje.Text.Trim())))
            {
                AlertMessage("产出金额与生产金额+加工费不等，请检查");
                return;
            }
        }

        protected void DelScxx(object sender, EventArgs e)
        {
            string itemBh = (sender as Button).CommandArgument;
            for (int i = 0; i < Scxx_dataTable.Rows.Count; i++)
            {
                if (Scxx_dataTable.Rows[i][11].ToString().Equals(itemBh))
                {
                    Scxx_dataTable.Rows.Remove(Scxx_dataTable.Rows[i]);
                    break;
                }
                else
                {
                    continue;
                }
            }
            Scxx_dataTable.Rows.RemoveAt(Scxx_dataTable.Rows.Count - 1);
            DataRow ldr = Scxx_dataTable.NewRow();
            ldr[0] = "合计";
            ldr[2] = Scxx_dataTable.Compute("sum(je)", "TRUE");
            ldr[3] = Scxx_dataTable.Compute("sum(sl)", "TRUE");
            Scxx_dataTable.Rows.Add(ldr);
            SortDt(Scxx_dataTable, 11);
            GridView_SCXX.DataSource = Scxx_dataTable;
            GridView_SCXX.DataBind();
        }

        protected void DelCcxx(object sender, EventArgs e)
        {
            string itemBh = (sender as Button).CommandArgument;
            for (int i = 0; i < Ccxx_dataTable.Rows.Count; i++)
            {
                if (Ccxx_dataTable.Rows[i][4].ToString().Equals(itemBh))
                {
                    Ccxx_dataTable.Rows.Remove(Ccxx_dataTable.Rows[i]);
                    break;
                }
                else
                {
                    continue;
                }
            }
            Ccxx_dataTable.Rows.RemoveAt(Ccxx_dataTable.Rows.Count - 1);
            DataRow ldr = Ccxx_dataTable.NewRow();
            ldr[0] = "合计";
            ldr[1] = Ccxx_dataTable.Compute("sum(je)", "TRUE");
            ldr[2] = (double)Ccxx_dataTable.Compute("sum(sl)", "TRUE") * (1-double.Parse(shl.Text.Trim()) / 100);
            Ccxx_dataTable.Rows.Add(ldr);
            SortDt(Ccxx_dataTable, 4);
            GridView_CCXX.DataSource = Ccxx_dataTable;
            GridView_CCXX.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            JavaScript("window.location.href='RsclrGl.aspx'");

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
                dml.Add("@bh", bh.Text);
                dml.Add("@ssmc", ssmc.Text.Trim());
                dml.Add("@rq", Convert.ToDateTime(rq.Text.ToString()));
                dml.Add("@kjsj", Convert.ToDateTime(kjsj.Text.ToString()));
                dml.Add("@gjsj", Convert.ToDateTime(gjsj.Text.ToString()));
                dml.Add("@bc", bc.Text.Trim());
                dml.Add("@ydzs", float.Parse(ydzs.Text.Trim()));
                dml.Add("@yddh", float.Parse(yddh.Text.Trim()));
                dml.Add("@ymzs", float.Parse(ymzs.Text.Trim()));
                dml.Add("@gsmc", DropDownList_gsmc.SelectedItem.Text.Trim());
            }
            catch
            {
                AlertMessage("数据存在错误，请检查");
                return;
            }

            List<DirModel> Child1 = new List<DirModel>();
            DirModel temp;
            foreach (DataRow dr in Scxx_dataTable.Rows)
            {
                if (!(bool)dr[12])
                {
                    continue;
                }
                temp = new DirModel();
                temp.Add("@user_no", model.LoginUser);
                temp.Add("@bh", bh.Text);
                temp.Add("@mz", dr[0]);
                temp.Add("@dj", dr[1]);
                temp.Add("@sl", dr[2]);
                temp.Add("@je", dr[3]);
                temp.Add("@klcl", dr[4]);
                temp.Add("@hhmcl", dr[5]);
                temp.Add("@mmcl", dr[6]);
                temp.Add("@zmcl", dr[7]);
                temp.Add("@nmcl", dr[8]);
                temp.Add("@gscl", dr[9]);
                temp.Add("@shl", dr[10]);
                Child1.Add(temp);
            }

            List<DirModel> Child2 = new List<DirModel>();
            foreach (DataRow dr in Ccxx_dataTable.Rows)
            {
                if ((bool)dr[5])
                {
                    temp = new DirModel();
                    temp.Add("@user_no", model.LoginUser);
                    temp.Add("@bh", bh.Text);
                    temp.Add("@mz", dr[0]);
                    temp.Add("@sl", dr[1]);
                    temp.Add("@je", dr[2]);
                    temp.Add("@cl", dr[3]);
                    Child2.Add(temp);
                }
            }
            string reply = _cwglLogic.UpdateRsclr(dml, Child1, Child2);
            if (reply == "")
            {
                AlertMessage("修改成功");
            }
            else
            {
                AlertMessage(reply);
            }
        }
    }
}