using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using xs_System.Logic;
using xsFramework.UserControl.Pager;
using xsFramework.Web.Login;
using xsFramework.Web.WebPage;
using XSSystem.Class;

namespace XSSystem.Page.P_CWGL
{
    public partial class Yfmx : AuthWebPage
    {
        HTGLLogic _htglLogic = new HTGLLogic();
        static DataTable CkdDT;
        static DataTable RkdDT;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //InitDataTableJgxx();

            }
        }

        protected void xsPage_PageChanged(object sender, PageChangedEventArgs e)
        {


            //if (!"G001".Equals(LoginUser.LoginUserGroup))
            //{
            //    gvUser.Columns[2].Visible = false;
            //}
            QueryClass qc = new QueryClass();
            //if (qdfwQ.Text != "")
            //    qc.qdrqQ = Convert.ToDateTime(qdfwQ.Text.Trim());
            //if (qdfwZ.Text != "")
            //    qc.qdrqZ = Convert.ToDateTime(qdfwZ.Text.Trim());
            //qc.tableName = "cghydlrTbale";
            //qc.selectedKey = sxtj.SelectedValue;
            //qc.selectedItem = tjz.Text.Trim();
            //qc.selectedTimeKey = "hyrq"

            GridView1.DataSource = SelectSQL(qc, e);
            GridView1.DataBind();
        }


        private void InitDataTableJgxx()
        {
            CkdDT = new DataTable();
            CkdDT.Columns.Add("dwmc", Type.GetType("System.String"));
            CkdDT.Columns.Add("rq", Type.GetType("System.String"));
            CkdDT.Columns.Add("zy", Type.GetType("System.String"));
            CkdDT.Columns.Add("skje", Type.GetType("System.Double"));
            CkdDT.Columns.Add("skfs", Type.GetType("System.Double"));
            CkdDT.Columns.Add("skzh", Type.GetType("System.String"));
            GridView1.DataSource = CkdDT;
            GridView1.DataBind();
        }



        protected void Unnamed_Click(object sender, EventArgs e)
        {
            if (CkdDT.Columns.Contains("PID"))
            {
                CkdDT.Columns.Remove("PID");
            }
            if (droplist_table.SelectedItem.Value == "1")
            {
                CkdDT.Columns[0].ColumnName = "车号";
                CkdDT.Columns[1].ColumnName = "装车时间";
                CkdDT.Columns[2].ColumnName = "发煤煤场";
                CkdDT.Columns[3].ColumnName = "物料名称";
                CkdDT.Columns[4].ColumnName = "出库净重";
                CkdDT.Columns[5].ColumnName = "入库时间";
                CkdDT.Columns[6].ColumnName = "收货单位";
                CkdDT.Columns[7].ColumnName = "入库净重";
                CkdDT.Columns[8].ColumnName = "运价";
                CkdDT.Columns[9].ColumnName = "运费结算吨位";
                CkdDT.Columns[10].ColumnName = "运费";
                CkdDT.Columns[11].ColumnName = "磅差";
                CkdDT.Columns[12].ColumnName = "路损";
                CkdDT.Columns[13].ColumnName = "运费扣款标准";
                CkdDT.Columns[14].ColumnName = "运费扣款金额";
                CkdDT.Columns[15].ColumnName = "已付油卡";
                CkdDT.Columns[16].ColumnName = "应付运费";
                CkdDT.Columns[17].ColumnName = "费用扣款";
                CkdDT.Columns[18].ColumnName = "结算运费";
                CkdDT.Columns[19].ColumnName = "运费结算状态";
            }
            else
            {
                CkdDT.Columns[0].ColumnName = "车号";
                CkdDT.Columns[1].ColumnName = "装车日期";
                CkdDT.Columns[2].ColumnName = "供方";
                CkdDT.Columns[3].ColumnName = "物料名称";
                CkdDT.Columns[4].ColumnName = "装车净重";
                CkdDT.Columns[5].ColumnName = "入库时间";
                CkdDT.Columns[6].ColumnName = "入库煤场";
                CkdDT.Columns[7].ColumnName = "入库净重";
                CkdDT.Columns[8].ColumnName = "运价";
                CkdDT.Columns[9].ColumnName = "运费结算吨位";
                CkdDT.Columns[10].ColumnName = "运费";
                CkdDT.Columns[11].ColumnName = "磅差";
                CkdDT.Columns[12].ColumnName = "路损";
                CkdDT.Columns[13].ColumnName = "扣款标准";
                CkdDT.Columns[14].ColumnName = "扣亏金额";
                CkdDT.Columns[15].ColumnName = "已付油卡";
                CkdDT.Columns[16].ColumnName = "应付运费";
            }
            
            //ExportExcelByDataTable(dt,"test");

            CreateExcel(CkdDT, "application/ms-excel", $"{kh.Text}出库单费用明细{cxsjQ.Text}-{cxsjZ.Text}");



        }

        DataTable SelectSQL(QueryClass qc, PageChangedEventArgs e)
        {
            PagerParameter pagepara = new PagerParameter();
            pagepara.DbConn = GlabalString.DBString;
            //pagepara.Sql = _htglLogic.QueryQyxsckdOrder();
            pagepara.OrderBy = "dwmc";
            return xsPageHelper.BindPager(pagepara);
        }

        /// <summary>
        /// DataTable中的数据导出到Excel并下载
        /// </summary>
        /// <param name="dt">要导出的DataTable</param>
        /// <param name="FileType">类型</param>
        /// <param name="FileName">Excel的文件名</param>
        public void CreateExcel(DataTable dt, string FileType, string FileName)
        {
            Response.Clear();
            Response.Charset = "UTF-8";
            Response.Buffer = true;
            Response.ContentEncoding = System.Text.Encoding.GetEncoding("GB2312");
            Response.AppendHeader("Content-Disposition", "attachment;filename=\"" + System.Web.HttpUtility.UrlEncode(FileName, System.Text.Encoding.UTF8) + ".xls\"");
            Response.ContentType = FileType;
            string colHeaders = string.Empty;
            string ls_item = string.Empty;
            DataRow[] myRow = dt.Select();
            int i = 0;
            int cl = dt.Columns.Count;
            for (int j = 0; j < dt.Columns.Count; j++)
            {
                if (j == (cl - 1))
                {
                    colHeaders += dt.Columns[j].ToString() + "\n";
                }
                else
                {
                    colHeaders += dt.Columns[j].ToString() + "\t";
                }
            }
            Response.Output.Write(colHeaders);
            foreach (DataRow row in myRow)
            {
                for (i = 0; i < cl; i++)
                {
                    if (i == (cl - 1))
                    {
                        ls_item += row[i].ToString() + "\n";
                    }
                    else
                    {
                        ls_item += row[i].ToString() + "\t";
                    }
                }
                Response.Output.Write(ls_item);
                ls_item = string.Empty;
            }
            Response.Output.Flush();
            Response.End();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (cxsjQ.Text.Trim() == "" || cxsjZ.Text.Trim() == "")
            {
                AlertMessage("请输入查询时间段！");
                return;
            }
            if (kh.Text.Trim() == "")
            {
                AlertMessage("请输入查询客户！");
                return;
            }
            QueryClass qc = new QueryClass();
            LoginModel model = Session["LoginModel"] as LoginModel;
            qc.user_no = model.LoginUser;
            qc.qdrqQ = Convert.ToDateTime(cxsjQ.Text.Trim());
            qc.qdrqZ = Convert.ToDateTime(cxsjZ.Text.Trim());
            qc.selectedItem = kh.Text.Trim();
            GetCkd(qc);
            GridView1.DataSource = CkdDT;

            GridView1.DataBind();
        }

        private void GetAllData()
        {
            foreach (DataRow val in RkdDT.Rows)
            {
                CkdDT.ImportRow(val);
            }

        }

        private void GetCkd(QueryClass qc)
        {
            PagerParameter pagepara = new PagerParameter();
            pagepara.DbConn = GlabalString.DBString;
            if (droplist_table.SelectedItem.Value == "1")
            {
                pagepara.Sql = _htglLogic.QueryCkdmxOrder(qc);
            }
            else
            {
                pagepara.Sql = _htglLogic.QueryRkdmxOrder(qc);
            }
            pagepara.OrderBy = "ch";
            CkdDT = xsPageHelper.BindPager(pagepara);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            QueryClass qc = new QueryClass();
            LoginModel model = Session["LoginModel"] as LoginModel;
            qc.user_no = model.LoginUser;
            qc.IsAll = 1;

            GetCkd(qc);
            //GetRkd(qc);
            //GetAllData();
            if (droplist_table.SelectedItem.Value == "1")
            {
                GridView1.DataSource = CkdDT;
                GridView1.DataBind();
            }
            else
            {
                GridView2.DataSource = CkdDT;
                GridView2.DataBind();
            }
            
        }

        protected void droplist_table_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (droplist_table.SelectedItem.Value == "1")
            {
                GridView1.Visible = true;
                GridView2.Visible = false;
            }
            else
            {
                GridView1.Visible = false;
                GridView2.Visible = true;
            }
        }
    }
}