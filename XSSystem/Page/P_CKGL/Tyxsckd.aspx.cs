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
    public partial class Tyxsckd : AuthWebPage
    {
        HTGLLogic _htglLogic = new HTGLLogic();
        static DataTable dataTable;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                DropListInit();
                if (Session["tyxsckd"] != null)
                {
                    InitData(Session["tyxsckd"]);
                }
                InitDataTable();
                //InitDataTable2();
                InitGridView();
                //InitGridView2();
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
                    tk_zcz.Items.Add(radcbItem);
                    tk_zdz.Items.Add(radcbItem2);
                }
                tk_zcz.SelectedIndex = 1;
                tk_zdz.SelectedIndex = 1;
            }

            dt = GlabalString.GetCangKu();
            if (dt.Rows.Count != 0)
            {
                foreach (DataRow val in dt.Rows)
                {
                    radcbItem = new RadComboBoxItem(val[0].ToString());
                    tk_fmmc.Items.Add(radcbItem);
                }
                tk_fmmc.SelectedIndex = 1;
            }

            

            jshk_qkr.DataSource = GlabalString.GetGongSi(1);
            jshk_qkr.DataTextField = "wldw";
            jshk_qkr.DataValueField = "wldw";
            jshk_qkr.DataBind();

            dt = GlabalString.GetGongSi(2);
            zbxsf_qkr.DataSource = dt;
            zbxsf_qkr.DataTextField = "wldw";
            zbxsf_qkr.DataValueField = "wldw";
            zbxsf_qkr.DataBind();

            fzdlf_qkr.DataSource = dt;
            fzdlf_qkr.DataTextField = "wldw";
            fzdlf_qkr.DataValueField = "wldw";
            fzdlf_qkr.DataBind();

            fzzxf_qkr.DataSource = dt;
            fzzxf_qkr.DataTextField = "wldw";
            fzzxf_qkr.DataValueField = "wldw";
            fzzxf_qkr.DataBind();

            fzddf_qkr.DataSource = dt;
            fzddf_qkr.DataTextField = "wldw";
            fzddf_qkr.DataValueField = "wldw";
            fzddf_qkr.DataBind();

            tlyf_qkr.DataSource = dt;
            tlyf_qkr.DataTextField = "wldw";
            tlyf_qkr.DataValueField = "wldw";
            tlyf_qkr.DataBind();

            dzzxf_qkr.DataSource = dt;
            dzzxf_qkr.DataTextField = "wldw";
            dzzxf_qkr.DataValueField = "wldw";
            dzzxf_qkr.DataBind();

            dzmcddf_qkr.DataSource = dt;
            dzmcddf_qkr.DataTextField = "wldw";
            dzmcddf_qkr.DataValueField = "wldw";
            dzmcddf_qkr.DataBind();

            dzdlf_qkr.DataSource = dt;
            dzdlf_qkr.DataTextField = "wldw";
            dzdlf_qkr.DataValueField = "wldw";
            dzdlf_qkr.DataBind();
        }

        private void InitDataTable()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("bh", System.Type.GetType("System.Int32"));
            dataTable.Columns.Add("xh", System.Type.GetType("System.String"));
            dataTable.Columns.Add("sxds", System.Type.GetType("System.Double"));
            dataTable.Columns.Add("zxrq", System.Type.GetType("System.String"));
            dataTable.Columns.Add("fcrq", System.Type.GetType("System.String"));
            dataTable.Columns.Add("xhds", System.Type.GetType("System.Double"));

            dataTable.Columns.Add("dzrq", System.Type.GetType("System.String"));
            dataTable.Columns.Add("jshk", System.Type.GetType("System.Double"));
            dataTable.Columns.Add("zbxsf", System.Type.GetType("System.Double"));
            dataTable.Columns.Add("fzdlf", System.Type.GetType("System.Double"));
            dataTable.Columns.Add("fzzxf", System.Type.GetType("System.Double"));
            dataTable.Columns.Add("fzddf", System.Type.GetType("System.Double"));
            dataTable.Columns.Add("tlyf", System.Type.GetType("System.Double"));
            dataTable.Columns.Add("dzzxf", System.Type.GetType("System.Double"));
            dataTable.Columns.Add("dzmcddf", System.Type.GetType("System.Double"));
            dataTable.Columns.Add("dzdlf", System.Type.GetType("System.Double"));
            dataTable.Columns.Add("tlyfxj", System.Type.GetType("System.Double"));

            dataTable.Columns.Add("jshk_qkr", System.Type.GetType("System.String"));
            dataTable.Columns.Add("zbxsf_qkr", System.Type.GetType("System.String"));
            dataTable.Columns.Add("fzdlf_qkr", System.Type.GetType("System.String"));
            dataTable.Columns.Add("fzzxf_qkr", System.Type.GetType("System.String"));
            dataTable.Columns.Add("fzddf_qkr", System.Type.GetType("System.String"));
            dataTable.Columns.Add("tlyf_qkr", System.Type.GetType("System.String"));
            dataTable.Columns.Add("dzzxf_qkr", System.Type.GetType("System.String"));
            dataTable.Columns.Add("dzmcddf_qkr", System.Type.GetType("System.String"));
            dataTable.Columns.Add("dzdlf_qkr", System.Type.GetType("System.String"));

        }

        void InitData(object mk)
        {
            DataTable dt = mk as DataTable;
            bh.Text = dt.Rows[0][1].ToString();
            htbh.Text = dt.Rows[0][2].ToString();
            tk_wtf.SelectedItem.Text = dt.Rows[0][3].ToString();
            tk_stf.SelectedItem.Text = dt.Rows[0][4].ToString();
            tk_fmmc.SelectedItem.Text = dt.Rows[0][5].ToString();

            wlmc.Text = dt.Rows[0][6].ToString();
            mj.Text = dt.Rows[0][7].ToString();
            tk_zcz.SelectedItem.Text = dt.Rows[0][8].ToString();
            tk_zdz.SelectedItem.Text = dt.Rows[0][9].ToString();
            xlx.Text = dt.Rows[0][10].ToString();

            tcbz.Text = dt.Rows[0][11].ToString();
            tcje.Text = dt.Rows[0][12].ToString();
            ywy.Text = dt.Rows[0][13].ToString();
            xhdw.Text = dt.Rows[0][14].ToString();
            Session.Remove("tyxsckd");
        }


        public void InitGridView()
        {
            PagerParameter pagepara = new PagerParameter();
            pagepara.DbConn = GlabalString.DBString;
            QueryClass qc = new QueryClass();
            LoginModel model = Session["LoginModel"] as LoginModel;
            qc.user_no = model.LoginUser;
            qc.htbh = htbh.Text;
            qc.tableName = "xs_Tyxsckd_Jzxxx";
            pagepara.Sql = _htglLogic.QueryCghtChildTable(qc);
            pagepara.OrderBy = "htbh";
            PageChangedEventArgs e = new PageChangedEventArgs(0);
            var temp = xsPageHelper.BindPager(pagepara, e);
            foreach (DataRow val in temp.Rows)
            {
                DataRow dr = dataTable.NewRow();
                dr[0] = val[2];
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
                dr[12] = val[15];
                dr[13] = val[16];
                dr[14] = val[17];
                dr[15] = val[18];
                dr[16] = val[19];
                dr[17] = val[20];
                dr[18] = val[21];
                dr[19] = val[22];
                dr[20] = val[23];
                dr[21] = val[24];
                dr[22] = val[25];
                dr[23] = val[26];
                dr[24] = val[27];
                dr[25] = val[28];
                dataTable.Rows.Add(dr);

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
                dml.Add("@user_no", model.LoginUser);
                dml.Add("@bh", bh.Text.Trim());
                dml.Add("@htbh", htbh.Text.Trim());
                dml.Add("@wtf", tk_wtf.SelectedItem.Text.Trim());
                dml.Add("@stf", tk_stf.SelectedItem.Text.Trim());
                dml.Add("@fmmc", tk_fmmc.SelectedItem.Text.Trim());
                dml.Add("@wlmc", wlmc.Text.Trim());
                dml.Add("@mj", float.Parse(mj.Text.Trim()));
                dml.Add("@zcz", tk_zcz.SelectedItem.Text.Trim());
                dml.Add("@zdz", tk_zdz.SelectedItem.Text.Trim());
                dml.Add("@xlx", xlx.Text.Trim());
                dml.Add("@tcbz", tcbz.Text.Trim());
                dml.Add("@tcje", float.Parse(tcje.Text.Trim()));
                dml.Add("@ywy", ywy.Text.Trim());
                dml.Add("@xhdw", float.Parse(xhdw.Text.Trim()));
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
                    temp.Add("@bh", bh.Text);
                    temp.Add("@user_no", model.LoginUser);
                    temp.Add("@xh", val[1]);
                    temp.Add("@sxds", val[2]);
                    temp.Add("@zxrq", val[3]);
                    temp.Add("@fcrq", val[4]);
                    temp.Add("@xhds", val[5]);
                    temp.Add("@dzrq", val[6]);
                    temp.Add("@jshk", val[7]);
                    temp.Add("@zbxsf", val[8]);
                    temp.Add("@fzdlf", val[9]);
                    temp.Add("@fzzxf", val[10]);
                    temp.Add("@fzddf", val[11]);
                    temp.Add("@tlyf", val[12]);
                    temp.Add("@dzzxf", val[13]);
                    temp.Add("@dzmcddf", val[14]);
                    temp.Add("@dzdlf", val[15]);
                    temp.Add("@tlyfxj", val[16]);
                    temp.Add("@jshk_qkr", val[17]);
                    temp.Add("@zbxsf_qkr", val[18]);
                    temp.Add("@fzdlf_qkr", val[19]);
                    temp.Add("@fzzxf_qkr", val[20]);
                    temp.Add("@fzddf_qkr", val[21]);
                    temp.Add("@tlyf_qkr", val[22]);
                    temp.Add("@dzzxf_qkr", val[23]);
                    temp.Add("@dzmcddf_qkr", val[24]);
                    temp.Add("@dzdlf_qkr", val[25]);
                    Child1.Add(temp);
            }

            //List<DirModel> Child2 = new List<DirModel>();
            //foreach (DataRow val in dataTable2.Rows)
            //{
            //    if ((bool)val[8])
            //    {
            //        temp = new DirModel();
            //        temp.Add("@user_no", model.LoginUser);
            //        temp.Add("@name", val[1]);
            //        temp.Add("@zqkje", val[2]);
            //        temp.Add("@yhkje", val[3]);
            //        temp.Add("@syqkje", val[4]);
            //        temp.Add("@qkxm", val[5]);
            //        temp.Add("@phone", val[6]);
            //        temp.Add("@bz", val[7]);
            //        Child2.Add(temp);
            //    }
            //}
            string reply = _htglLogic.InsertTyxsckd(dml, Child1);
            if (reply == "")
            {
                AlertMessage("新增成功");
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
                dr[1] = xh.Text;
                dr[2] = double.Parse(sxds.Text);
                dr[3] = zxrq.Text;
                dr[4] = fcrq.Text;
                dr[5] = double.Parse(xhds.Text.Trim());
                dr[6] = dzrq.Text;
                dr[7] = double.Parse(jshk.Text.Trim());
                dr[8] = double.Parse(zbxsf.Text.Trim());
                dr[9] = double.Parse(fzdlf.Text.Trim());
                dr[10] = double.Parse(fzzxf.Text.Trim());
                dr[11] = double.Parse(fzddf.Text.Trim());
                dr[12] = double.Parse(tlyf.Text.Trim());
                dr[13] = double.Parse(dzzxf.Text.Trim());
                dr[14] = double.Parse(dzmcddf.Text.Trim());
                dr[15] = double.Parse(dzdlf.Text.Trim());
                dr[16] = double.Parse(tlyfxj.Text.Trim());
                dr[17] = jshk_qkr.Text.Trim();
                dr[18] = zbxsf_qkr.Text.Trim();
                dr[19] = fzdlf_qkr.Text.Trim();
                dr[20] = fzzxf_qkr.Text.Trim();
                dr[21] = fzddf_qkr.Text.Trim();
                dr[22] = tlyf_qkr.Text.Trim();
                dr[23] = dzzxf_qkr.Text.Trim();
                dr[24] = dzmcddf_qkr.Text.Trim();
                dr[25] = dzdlf_qkr.Text.Trim();
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!CalDataChecked(1))
            {
                return;
            }
            if (dataTable.Rows.Count > 0)
            {
                double ds = (double)dataTable.Compute("sum(xhds)", "TRUE");
                tcje.Text = Mul(tcbz.Text, ds.ToString());
            }
            
            jshk.Text = Mul(mj.Text, xhds.Text);
            tlyfxj.Text = (Num(zbxsf.Text) / 2.0f + Num(fzdlf.Text) / 2.0f + Num(fzzxf.Text) * Num(sxds.Text) + Num(fzddf.Text) *
                Num(sxds.Text) + Num(tlyf.Text) / 2.0f + Num(dzzxf.Text) / 2.0f + Num(dzmcddf.Text) / 2.0f + Num(dzdlf.Text) * Num(xhds.Text)).ToString();
        }

        protected void close_Click(object sender, EventArgs e)
        {
            JavaScript("window.location.href='TyxsckdGl.aspx'");
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
                dml.Add("@htbh", htbh.Text.Trim());
                dml.Add("@wtf", tk_wtf.SelectedItem.Text.Trim());
                dml.Add("@stf", tk_stf.SelectedItem.Text.Trim());
                dml.Add("@fmmc", tk_fmmc.SelectedItem.Text.Trim());
                dml.Add("@wlmc", wlmc.Text.Trim());
                dml.Add("@mj", float.Parse(mj.Text.Trim()));
                dml.Add("@zcz", tk_zcz.SelectedItem.Text.Trim());
                dml.Add("@zdz", tk_zdz.SelectedItem.Text.Trim());
                dml.Add("@xlx", xlx.Text.Trim());
                dml.Add("@tcbz", tcbz.Text.Trim());
                dml.Add("@tcje", float.Parse(tcje.Text.Trim()));
                dml.Add("@ywy", ywy.Text.Trim());
                dml.Add("@xhdw", float.Parse(xhdw.Text.Trim()));
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
                    temp.Add("@bh", bh.Text);
                    temp.Add("@user_no", model.LoginUser);
                    temp.Add("@xh", val[1]);
                    temp.Add("@sxds", val[2]);
                    temp.Add("@zxrq", val[3]);
                    temp.Add("@fcrq", val[4]);
                    temp.Add("@xhds", val[5]);
                    temp.Add("@dzrq", val[6]);
                    temp.Add("@jshk", val[7]);
                    temp.Add("@zbxsf", val[8]);
                    temp.Add("@fzdlf", val[9]);
                    temp.Add("@fzzxf", val[10]);
                    temp.Add("@fzddf", val[11]);
                    temp.Add("@tlyf", val[12]);
                    temp.Add("@dzzxf", val[13]);
                    temp.Add("@dzmcddf", val[14]);
                    temp.Add("@dzdlf", val[15]);
                    temp.Add("@tlyfxj", val[16]);
                    temp.Add("@jshk_qkr", val[17]);
                    temp.Add("@zbxsf_qkr", val[18]);
                    temp.Add("@fzdlf_qkr", val[19]);
                    temp.Add("@fzzxf_qkr", val[20]);
                    temp.Add("@fzddf_qkr", val[21]);
                    temp.Add("@tlyf_qkr", val[22]);
                    temp.Add("@dzzxf_qkr", val[23]);
                    temp.Add("@dzmcddf_qkr", val[24]);
                    temp.Add("@dzdlf_qkr", val[25]);
                    Child1.Add(temp);
            }
            string reply = _htglLogic.UpdateTyxsckd(dml, Child1);
            if (reply == "")
            {
                AlertMessage("新增成功");
            }
            else
            {
                AlertMessage(reply);
            }
        }
    }
}