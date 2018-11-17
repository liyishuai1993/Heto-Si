using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using xsFramework.Web.WebPage;
using xs_System.Logic;
using xsFramework.Web.Login;
using xsFramework.UserControl.Pager;
using XSSystem.Class;

namespace XSSystem.Page.P_Order
{
    public partial class Tydbckd : AuthWebPage
    {
        HTGLLogic _htglLogic = new HTGLLogic();
        static DataTable dataTable;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                if (Session["tydbckd"] != null)
                {
                    InitData(Session["tydbckd"]);
                }
                InitDataTable();
            }
        }

        private void InitDataTable()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("bh", System.Type.GetType("System.Int32"));
            dataTable.Columns.Add("xh", System.Type.GetType("System.String"));
            dataTable.Columns.Add("sxds", System.Type.GetType("System.Double"));
            dataTable.Columns.Add("zxrq", System.Type.GetType("System.String"));
            dataTable.Columns.Add("fcrq", System.Type.GetType("System.String"));
            dataTable.Columns.Add("dcmj", System.Type.GetType("System.Double"));
            dataTable.Columns.Add("xhds", System.Type.GetType("System.Double"));

            dataTable.Columns.Add("dzrq", System.Type.GetType("System.String"));
            dataTable.Columns.Add("xhck", System.Type.GetType("System.String"));
            dataTable.Columns.Add("zbxsf", System.Type.GetType("System.Double"));
            dataTable.Columns.Add("fzdlf", System.Type.GetType("System.Double"));
            dataTable.Columns.Add("fzzxf", System.Type.GetType("System.Double"));

            dataTable.Columns.Add("fzddf", System.Type.GetType("System.Double"));
            dataTable.Columns.Add("tlyf", System.Type.GetType("System.Double"));
            dataTable.Columns.Add("dzzxf", System.Type.GetType("System.Double"));
            dataTable.Columns.Add("dzmcddf", System.Type.GetType("System.Double"));
            dataTable.Columns.Add("dzdlf", System.Type.GetType("System.Double"));
            dataTable.Columns.Add("drmj", System.Type.GetType("System.Double"));
            dataTable.Columns.Add("isadd", System.Type.GetType("System.Boolean"));

        }

        void InitData(object mk)
        {
            DataTable dt = mk as DataTable;
            bh.Text = dt.Rows[0][1].ToString();
            htbh.Text = dt.Rows[0][2].ToString();
            gsmc.Text = dt.Rows[0][3].ToString();
            gsmc.Text = dt.Rows[0][4].ToString();
            fmmc.Text = dt.Rows[0][5].ToString();

            wlmc.Text = dt.Rows[0][6].ToString();
            zcz.Text = dt.Rows[0][7].ToString();
            zdz.Text = dt.Rows[0][8].ToString();
            xlx.Text = dt.Rows[0][9].ToString();
            xhdw.Text = dt.Rows[0][10].ToString();
            Session.Remove("tydbckd");
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;
            try
            {
                dml.Add("@user_no", model.LoginUser);
                dml.Add("@bh", bh.Text.Trim());
                dml.Add("@htbh", htbh.Text.Trim());
                dml.Add("@gsmc", gsmc.Text.Trim());
                dml.Add("@fmmc", fmmc.Text.Trim());
                dml.Add("@wlmc", wlmc.Text.Trim());
                dml.Add("@zcz", zcz.Text.Trim());
                dml.Add("@zdz", zdz.Text.Trim());
                dml.Add("@xlx", xlx.Text.Trim());
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
                if ((bool)val[18])
                {
                    temp = new DirModel();
                    temp.Add("@bh", bh.Text.Trim());
                    temp.Add("@user_no", model.LoginUser);
                    temp.Add("@xh", val[1]);
                    temp.Add("@sxds", val[2]);
                    temp.Add("@zxrq", val[3]);
                    temp.Add("@fcrq", val[4]);
                    temp.Add("@dcmj", val[5]);
                    temp.Add("@xhds", val[6]);
                    temp.Add("@dzrq", val[7]);
                    temp.Add("@xhck", val[8]);
                    temp.Add("@zbxsf", val[9]);
                    temp.Add("@fzdlf", val[10]);
                    temp.Add("@fzzxf", val[11]);
                    temp.Add("@fzddf", val[12]);
                    temp.Add("@tlyf", val[13]);
                    temp.Add("@dzzxf", val[14]);
                    temp.Add("@dzmcddf", val[15]);
                    temp.Add("@dzdlf", val[16]);
                    temp.Add("@drmj", val[17]);
                    Child1.Add(temp);
                }
            }
            if (_htglLogic.InsertTydbckd(dml,Child1))
            {
                AlertMessage("新增成功");
            }
        }


        public void InitGridView()
        {
            PagerParameter pagepara = new PagerParameter();
            pagepara.DbConn = GlabalString.DBString;
            QueryClass qc = new QueryClass();
            LoginModel model = Session["LoginModel"] as LoginModel;
            qc.user_no = model.LoginUser;
            qc.bh = bh.Text;
            qc.tableName = "xs_Tydbckd_Jzxxx";
            pagepara.Sql = _htglLogic.QueryThdbckdChildTable(qc);
            pagepara.OrderBy = "bh";
            PageChangedEventArgs e = new PageChangedEventArgs(0);
            this.GridView1.DataSource = xsPageHelper.BindPager(pagepara, e);
            this.GridView1.DataBind();
        }

        protected void AddJgxx(object sender, EventArgs e)
        {
            DataRow dr = dataTable.NewRow();
            try
            {
                dr[0] = dataTable.Rows.Count + 1;
                dr[1] = xh.Text;
                dr[2] = double.Parse(sxds.Text);
                dr[3] = zxrq.Text;
                dr[4] = fcrq.Text;
                dr[5] = double.Parse(dcmj.Text.Trim());
                dr[6] = double.Parse(xhds.Text.Trim());
                dr[7] = dzrq.Text;
                dr[8] = xhck.Text;
                dr[9] = double.Parse(zbxsf.Text.Trim());
                dr[10] = double.Parse(fzdlf.Text.Trim());
                dr[11] = double.Parse(fzzxf.Text.Trim());
                dr[12] = double.Parse(fzddf.Text.Trim());
                dr[13] = double.Parse(tlyf.Text.Trim());
                dr[14] = double.Parse(dzzxf.Text.Trim());
                dr[15] = double.Parse(dzmcddf.Text.Trim());
                dr[16] = double.Parse(dzdlf.Text.Trim());
                dr[17] = double.Parse(drmj.Text.Trim());
                dr[18] = true;
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