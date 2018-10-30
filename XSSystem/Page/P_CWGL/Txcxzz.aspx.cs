using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace XSSystem.Page.P_CWGL
{
    public partial class Txcxzz : System.Web.UI.Page
    {
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
            dataTable.Columns.Add("skzhbh", System.Type.GetType("System.String"));
            dataTable.Columns.Add("skzhmc", System.Type.GetType("System.String"));
            dataTable.Columns.Add("je", System.Type.GetType("System.Double"));
            dataTable.Columns.Add("bz", System.Type.GetType("System.String"));

        }

        protected void InsertBtn_Click(object sender, EventArgs e)
        {
            DataRow dr = dataTable.NewRow();
            dr[0] = dataTable.Rows.Count;
            dr[1] = skzhbh.Text;
            dr[2] = skzhmc.Text;
            dr[3] = double.Parse(je.Text.Trim());
            dr[4] = bz.Text;
            dataTable.Rows.Add(dr);
            GridView1.DataSource = dataTable;
            GridView1.DataBind();

        }
    }
}