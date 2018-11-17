using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using xsFramework.Web.WebPage;
using XSSystem.Logic;
using xsFramework.Web.Login;

namespace XSSystem.Page.P_Order
{
    public partial class Fyd : AuthWebPage
    {

        CWGLLogic _cwglLogic = new CWGLLogic();
        static DataTable dataTable;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InitDataTable();
            }
            
        }

        private void InitDataTable()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("xh", System.Type.GetType("System.Int32"));
            dataTable.Columns.Add("fyxmbh", System.Type.GetType("System.String"));
            dataTable.Columns.Add("fyxmmc", System.Type.GetType("System.String"));
            dataTable.Columns.Add("je", System.Type.GetType("System.Double"));
            dataTable.Columns.Add("bz", System.Type.GetType("System.String"));

        }

        protected void InsertBtn_Click(object sender, EventArgs e)
        {
            DataRow dr = dataTable.NewRow();
            try
            {
                dr[0] = dataTable.Rows.Count;
                dr[1] = fyxmbh.Text;
                dr[2] = fyxmmc.Text;
                dr[3] = double.Parse(je.Text.Trim());
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

        protected void save_Click(object sender, EventArgs e)
        {
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;
            try
            {
                dml.Add("@user_no", model.LoginUser);
                dml.Add("@bh", bh.Text.Trim());
                dml.Add("@ldrq", Convert.ToDateTime(ldrq.Text.ToString()));
                dml.Add("@sfdw", sfdw.Text.Trim());
                dml.Add("@jsr", jsr.Text.Trim());
                dml.Add("@bm", bm.Text.Trim());
                dml.Add("@zy", zy.Text.Trim());
                dml.Add("@fjsm", fjsm.Text.Trim());
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
                temp.Add("@user_no", model.LoginUser);
                temp.Add("@bh", bh.Text.Trim());
                temp.Add("@fyxmbh", val[1]);
                temp.Add("@fyxmmc", val[2]);
                temp.Add("@je", val[3]);
                temp.Add("@bz", val[4]);
                Child1.Add(temp);
            }
            string ret = _cwglLogic.InsertFyd(dml, Child1);
            if (ret=="")
            {
                AlertMessage("新增成功");
            }
            else
                AlertMessage(ret);
        }
    }
}