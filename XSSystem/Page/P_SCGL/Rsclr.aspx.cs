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
                bh.Text = DateTime.Now.ToString("yyyyMMddHHmmss");
                InitDataTable();
                DropListInit();
            }
        }

        protected void submit_Click(object sender, EventArgs e)
        {
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
                dml.Add("@gsmc", gsmc.Text.Trim());
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
                temp = new DirModel();
                temp.Add("@user_no", model.LoginUser);
                temp.Add("@bh", bh.Text);
                temp.Add("@mz", dr[0]);
                temp.Add("@sl", dr[1]);
                temp.Add("@je", dr[2]);
                temp.Add("@klcl", dr[3]);
                temp.Add("@hhmcl", dr[4]);
                temp.Add("@mmcl", dr[5]);
                temp.Add("@zmcl", dr[6]);
                temp.Add("@nmcl", dr[7]);
                temp.Add("@gscl", dr[8]);
                temp.Add("@shl", dr[9]);
                Child1.Add(temp);
            }

            List<DirModel> Child2 = new List<DirModel>();
            foreach (DataRow dr in Ccxx_dataTable.Rows)
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
            Scxx_dataTable.Columns.Add("je", System.Type.GetType("System.Double"));
            Scxx_dataTable.Columns.Add("sl", System.Type.GetType("System.Double"));
            Scxx_dataTable.Columns.Add("klcl", System.Type.GetType("System.Double"));
            Scxx_dataTable.Columns.Add("hhmcl", System.Type.GetType("System.Double"));
            Scxx_dataTable.Columns.Add("mmcl", System.Type.GetType("System.Double"));
            Scxx_dataTable.Columns.Add("zmcl", System.Type.GetType("System.Double"));
            Scxx_dataTable.Columns.Add("nmcl", System.Type.GetType("System.Double"));
            Scxx_dataTable.Columns.Add("gscl", System.Type.GetType("System.Double"));
            Scxx_dataTable.Columns.Add("shl", System.Type.GetType("System.Double"));

            Ccxx_dataTable = new DataTable();
            Ccxx_dataTable.Columns.Add("mz", System.Type.GetType("System.String"));
            Ccxx_dataTable.Columns.Add("sl", System.Type.GetType("System.Double"));
            Ccxx_dataTable.Columns.Add("je", System.Type.GetType("System.Double"));
            Ccxx_dataTable.Columns.Add("cl", System.Type.GetType("System.Double"));



        }

        private bool InsertScxx(DataRow dr)
        {
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;
            dml.Add("@user_no", model.LoginUser);
            dml.Add("@bh", bh.Text);
            dml.Add("@mz", dr[0]);
            dml.Add("@sl", dr[1]);
            dml.Add("@je", dr[2]);
            dml.Add("@klcl", dr[3]);
            dml.Add("@hhmcl", dr[4]);
            dml.Add("@mmcl", dr[5]);
            dml.Add("@zmcl", dr[6]);
            dml.Add("@nmcl", dr[7]);
            dml.Add("@gscl", dr[8]);
            dml.Add("@shl", dr[9]);
            return _cwglLogic.InsertRsclr_Scxx(dml);

        }

        protected void scxx_tjmz_Click(object sender, EventArgs e)
        {
            


            DataRow dr = Scxx_dataTable.NewRow();
            try
            {
                dr[0] = MZDropDownList.SelectedValue;
                dr[1] = double.Parse(scxx_je.Text.Trim());
                dr[2] = double.Parse(scxx_sl.Text.Trim());
                dr[3] = double.Parse(klcl.Text.Trim());
                dr[4] = double.Parse(hhmcl.Text.Trim());
                dr[5] = double.Parse(mmcl.Text.Trim());
                dr[6] = double.Parse(zmcl.Text.Trim());
                dr[7] = double.Parse(nmcl.Text.Trim());
                dr[8] = double.Parse(gscl.Text.Trim());
                dr[9] = double.Parse(shl.Text.Trim());
            }
            catch
            {
                AlertMessage("数据存在错误，请检查");
                return;
            }
            Scxx_dataTable.Rows.Add(dr);
            GridView_SCXX.DataSource = Scxx_dataTable;
            GridView_SCXX.DataBind();

            

        }

        protected void DropListInit()
        {
            PagerParameter pagepara = new PagerParameter();
            QueryClass qc = new QueryClass();
            pagepara.DbConn = GlabalString.DBString;
            //pagepara.XsPager=
            HTGLLogic ht = new HTGLLogic();
            string[] arrList = new string[1];
            arrList[0] = "mzmc";
            pagepara.Sql = ht.QueryDropList("xs_MeiZhongTable", arrList);
            pagepara.OrderBy = "mzmc";
            DataTable dt = xsPageHelper.BindPager(pagepara);
            if (dt.Rows.Count != 0)
            {
                MZDropDownList.DataSource = dt.DefaultView;
                MZDropDownList.DataTextField = dt.Columns[0].ToString();
                MZDropDownList.DataBind();
                MZDropDownList2.DataSource = dt.DefaultView;
                MZDropDownList2.DataTextField = dt.Columns[0].ToString();
                MZDropDownList2.DataBind();

                //DropDownList1.DataSource = dt.DefaultView;
                //DropDownList1.DataValueField = dt.Columns[0].ToString(); ;
                //DropDownList1.DataBind();
                //DropDownList1.Items.FindItemByValue("").Selected = true;
                RadComboBoxItem radcbItem;
                foreach (DataRow val in dt.Rows)
                {
                    radcbItem = new RadComboBoxItem(val[0].ToString());
                    DropDownList1.Items.Add(radcbItem);
                }
               // DropDownList1.FindItemByText
            }
        }

        private bool InsertCcxx(DataRow dr)
        {
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;

                dml.Add("@user_no", model.LoginUser);
                dml.Add("@bh", bh.Text);
                dml.Add("@mz", dr[0]);
                dml.Add("@sl", dr[1]);
                dml.Add("@je", dr[2]);
                dml.Add("@cl", dr[3]);


            return _cwglLogic.InsertRsclr_Ccxx(dml);
        }

        protected void ccxx_tjmz_Click(object sender, EventArgs e)
        {
            

            DataRow dr = Ccxx_dataTable.NewRow();
            try
            {
                dr[0] = MZDropDownList2.SelectedValue;
                dr[1] = double.Parse(ccxx_je.Text.Trim());
                dr[2] = double.Parse(ccxx_sl.Text.Trim());
                dr[3] = double.Parse(ccxx_cl.Text.Trim());
            }
            catch
            {
                AlertMessage("数据存在错误，请检查");
                return;
            }
            Ccxx_dataTable.Rows.Add(dr);
            GridView_CCXX.DataSource = Ccxx_dataTable;
            GridView_CCXX.DataBind();
            


        }
    }
}