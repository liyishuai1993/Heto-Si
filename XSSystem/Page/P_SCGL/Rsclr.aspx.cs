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
    public partial class Rsclr : AuthWebPage
    {
        DataTable dataTable = new DataTable();

        CWGLLogic _cwglLogic = new CWGLLogic();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;

            dml.Add("@user_no", model.LoginUser);
            dml.Add("@ssmc", ssmc.Text.Trim());
            dml.Add("@rq", Convert.ToDateTime(rq.Text.ToString()));
            dml.Add("@kjsj", Convert.ToDateTime(kjsj.Text.ToString()));
            dml.Add("@gjsj", Convert.ToDateTime(gjsj.Text.ToString()));
            dml.Add("@bc", bc.Text.Trim());
            dml.Add("@ydzs",float.Parse(ydzs.Text.Trim()));
            dml.Add("@yddh",float.Parse(yddh.Text.Trim()));
            dml.Add("@ymzs", float.Parse(ymzs.Text.Trim()));
            dml.Add("@gsmc", gsmc.Text.Trim());
            if (_cwglLogic.InsertRsclr(dml))
            {
                AlertMessage("新增成功");
            }
        }

        protected void scxx_tjmz_Click(object sender, EventArgs e)
        {
            dataTable.NewRow();
            DataRow dr = dataTable.NewRow();
            dr[0] = MZDropDownList.SelectedValue;
            dr[1] = scxx_je.Text;
            dr[2] = scxx_sl.Text;
            dr[3] = klcl.Text;
            dr[4] = hhmcl.Text;
            dr[5] = mmcl.Text;
            dr[6] = zmcl.Text;
            dr[7] = nmcl.Text;
            dr[8] = gscl.Text;
            dr[9] = zsl.Text;
            dataTable.Rows.Add(dr);
            GridView_SCXX.DataSource = dataTable;
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
            arrList[0] = "MeiZhong";
            pagepara.Sql = ht.QueryDropList("xs_CghtTable", arrList);
           // pagepara.OrderBy = "gfmc";
            PageChangedEventArgs e = new PageChangedEventArgs(1);
            DataTable dt = xsPageHelper.BindPager(pagepara, e);
            if (dt.Rows.Count != 0)
            {
                MZDropDownList.DataSource = dt.DefaultView;
                MZDropDownList.DataTextField = dt.Columns[0].ToString();
                MZDropDownList.DataBind();
                MZDropDownList2.DataSource = dt.DefaultView;
                MZDropDownList2.DataTextField = dt.Columns[0].ToString();
                MZDropDownList.DataBind();
            }
        }

        protected void ccxx_tjmz_Click(object sender, EventArgs e)
        {

        }
    }
}