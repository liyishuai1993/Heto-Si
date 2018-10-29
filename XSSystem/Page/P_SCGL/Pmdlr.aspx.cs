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
using XSSystem.Logic;

namespace XSSystem.Page.P_Order
{
    public partial class Pmdlr : AuthWebPage
    {
        CWGLLogic _cwglLogic = new CWGLLogic();
        static DataTable YLdataTable;
        static DataTable CPdataTable;
        protected void Page_Load(object sender, EventArgs e)
        {
            

            if (!IsPostBack)
            {
         //       bh.Text = DateTime.Now.ToString("yyyyMMddHHmmss");
                InitDataTable();
                DropListInit();
            }
        }

        private void InitDataTable()
        {
            YLdataTable = new DataTable();
            YLdataTable.Columns.Add("yl", System.Type.GetType("System.String"));
            YLdataTable.Columns.Add("ylds", System.Type.GetType("System.Double"));
            YLdataTable.Columns.Add("cbdj", System.Type.GetType("System.Double"));
            YLdataTable.Columns.Add("pmf", System.Type.GetType("System.Double"));
            YLdataTable.Columns.Add("je", System.Type.GetType("System.Double"));

            CPdataTable = new DataTable();
            CPdataTable.Columns.Add("cp", System.Type.GetType("System.String"));
            CPdataTable.Columns.Add("cpds", System.Type.GetType("System.Double"));
            CPdataTable.Columns.Add("je", System.Type.GetType("System.Double"));
            CPdataTable.Columns.Add("cbdj", System.Type.GetType("System.Double"));
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;

            dml.Add("@user_no", model.LoginUser);
            dml.Add("@bh", bh.Text.Trim());
            dml.Add("@pmrq", Convert.ToDateTime(pmrq.Text.ToString()));
            dml.Add("@scmc", scmc.Text.Trim());
            dml.Add("@gsmc", gsmc.Text.Trim());
            if (_cwglLogic.InsertPmdlr(dml))
            {
                AlertMessage("新增成功");
            }
            foreach(DataRow val in YLdataTable.Rows)
            {
                if (InsertTjje(val))
                {
                    AlertMessage("新增成功");
                }
                else
                {
                    AlertMessage("新增失败");
                }
            }

            foreach(DataRow val in CPdataTable.Rows)
            {
                if (InsertCcmz(val))
                {
                    AlertMessage("新增成功");
                }
                else
                {
                    AlertMessage("新增失败");
                }
            }
        }

        protected void DropListInit()
        {
            PagerParameter pagepara = new PagerParameter();
            QueryClass qc = new QueryClass();
            pagepara.DbConn = GlabalString.DBString;
            //pagepara.XsPager=
            HTGLLogic ht = new HTGLLogic();
            string[] arrList = new string[1];
            arrList[0] = "yl";
            pagepara.Sql = ht.QueryDropList("xs_YuanLiaoTable", arrList);
            pagepara.OrderBy = "yl";
            PageChangedEventArgs e = new PageChangedEventArgs(1);
            DataTable dt = xsPageHelper.BindPager(pagepara, e);
            if (dt.Rows.Count != 0)
            {
                YLDropDownList.DataSource = dt.DefaultView;
                YLDropDownList.DataTextField = dt.Columns[0].ToString();
                YLDropDownList.DataBind();
            }

            arrList[0] = "cp";
            pagepara.Sql = ht.QueryDropList("xs_ChanPingTable", arrList);
            pagepara.OrderBy = "cp";
            dt = xsPageHelper.BindPager(pagepara, e);
            if (dt.Rows.Count != 0)
            {
                CPDropDownList.DataSource = dt.DefaultView;
                CPDropDownList.DataTextField = dt.Columns[0].ToString();
                CPDropDownList.DataBind();
            }
        }

        private bool InsertTjje(DataRow dr)
        {
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;
            dml.Add("@user_no", model.LoginUser);
            dml.Add("@bh", bh.Text);
            dml.Add("@yl", dr[0]);
            dml.Add("@ylds", dr[1]);
            dml.Add("@cbdj", dr[2]);
            dml.Add("@pmf", dr[3]);
            dml.Add("@je", dr[4]);
            return _cwglLogic.InsertPmdlr_Ylmz(dml);

        }

        protected void ylmz_tjje_Click(object sender, EventArgs e)
        {
            DataRow dr = YLdataTable.NewRow();
            dr[0] = YLDropDownList.SelectedValue;
            dr[1] = double.Parse(ylds.Text.Trim());
            dr[2] = double.Parse(cbdj.Text.Trim());
            dr[3] = double.Parse(pmf.Text.Trim());
            dr[4] = double.Parse(je.Text.Trim());
            YLdataTable.Rows.Add(dr);
            GridView_YLMZ.DataSource = YLdataTable;
            GridView_YLMZ.DataBind();
        }

        private bool InsertCcmz(DataRow dr)
        {
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;
            dml.Add("@user_no", model.LoginUser);
            dml.Add("@bh", bh.Text);
            dml.Add("@cp", dr[0]);
            dml.Add("@ccds", dr[1]);
            dml.Add("@je", dr[2]);
            dml.Add("@cbdj2", dr[3]);
            return _cwglLogic.InsertPmdlr_Ccmz(dml);
        }

        protected void ccmz_tjje_Click(object sender, EventArgs e)
        {          
            DataRow dr = CPdataTable.NewRow();
            dr[0] = CPDropDownList.SelectedValue;
            dr[1] = double.Parse(ccds.Text.Trim());
            dr[2] = double.Parse(je2.Text.Trim());
            dr[3] = double.Parse(cbdj2.Text.Trim());
            CPdataTable.Rows.Add(dr);
            CPGridView.DataSource = CPdataTable;
            CPGridView.DataBind();
        }
    }
}