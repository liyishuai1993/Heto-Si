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
using xsFramework.Web.WebPage;
using XSSystem.Class;

namespace XSSystem.Page.P_CWGL
{
    public partial class FormExport : AuthWebPage
    {
        HTGLLogic _htglLogic = new HTGLLogic();
        static DataTable QyxsckdDT;
        static DataTable MkzxDT;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InitDataTableJgxx();

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
            QyxsckdDT = new DataTable();
            QyxsckdDT.Columns.Add("dwmc", Type.GetType("System.String"));
            QyxsckdDT.Columns.Add("rq", Type.GetType("System.String"));
            QyxsckdDT.Columns.Add("ch", Type.GetType("System.String"));
            QyxsckdDT.Columns.Add("ckdw", Type.GetType("System.Double"));
            QyxsckdDT.Columns.Add("dhdw", Type.GetType("System.Double"));
            QyxsckdDT.Columns.Add("kd", Type.GetType("System.Double"));
            QyxsckdDT.Columns.Add("xsjsdw", Type.GetType("System.Double"));
            QyxsckdDT.Columns.Add("mj", Type.GetType("System.Double"));
            QyxsckdDT.Columns.Add("xsjsje", Type.GetType("System.Double"));
            GridView1.DataSource = QyxsckdDT;
            GridView1.DataBind();
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {

            QueryClass qc = new QueryClass();
            qc.tableName = "xs_QyxsckdTable";
            PageChangedEventArgs pe = new PageChangedEventArgs(1);
            //DataTable dt = new DataTable();
            //foreach (DataRow dataRow in Jgxx_dataTable.Rows)
            //{
            //    dt.Rows.Add(dataRow);
            //}
            QyxsckdDT.Columns[0].ColumnName = "单位名称";
            QyxsckdDT.Columns[1].ColumnName = "日期";
            QyxsckdDT.Columns[2].ColumnName = "车号";
            QyxsckdDT.Columns[3].ColumnName = "出库吨位";
            QyxsckdDT.Columns[4].ColumnName = "到货吨位";
            QyxsckdDT.Columns[5].ColumnName = "扣吨";
            QyxsckdDT.Columns[6].ColumnName = "销售结算吨位";
            QyxsckdDT.Columns[7].ColumnName = "煤价";
            QyxsckdDT.Columns[8].ColumnName = "销售结算金额";

            //ExportExcelByDataTable(dt,"test");
            CreateExcel(QyxsckdDT, "application/ms-excel", "test");



        }

        DataTable SelectSQL(QueryClass qc, PageChangedEventArgs e)
        {
            PagerParameter pagepara = new PagerParameter();
            pagepara.DbConn = GlabalString.DBString;
            pagepara.Sql = _htglLogic.QueryQyxsckdOrder(qc);
            pagepara.OrderBy = "dwmc";
            return xsPageHelper.BindPager(pagepara);
        }

        //protected void ExportExcel(DataTable dt)
        //{
        //    if (dt == null || dt.Rows.Count == 0) return;
        //    Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

        //    if (xlApp == null)
        //    {
        //        return;
        //    }
        //    System.Globalization.CultureInfo CurrentCI = System.Threading.Thread.CurrentThread.CurrentCulture;
        //    System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        //    Microsoft.Office.Interop.Excel.Workbooks workbooks = xlApp.Workbooks;
        //    Microsoft.Office.Interop.Excel.Workbook workbook = workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
        //    Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];
        //    Microsoft.Office.Interop.Excel.Range range;
        //    long totalCount = dt.Rows.Count;
        //    long rowRead = 0;
        //    float percent = 0;
        //    for (int i = 0; i < dt.Columns.Count; i++)
        //    {
        //        worksheet.Cells[1, i + 1] = dt.Columns[i].ColumnName;
        //        range = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[1, i + 1];
        //        range.Interior.ColorIndex = 15;
        //        range.Font.Bold = true;
        //    }
        //    for (int r = 0; r < dt.Rows.Count; r++)
        //    {
        //        for (int i = 0; i < dt.Columns.Count; i++)
        //        {
        //            worksheet.Cells[r + 2, i + 1] = dt.Rows[r][i].ToString();
        //        }
        //        rowRead++;
        //        percent = ((float)(100 * rowRead)) / totalCount;
        //    }
        //    xlApp.Visible = true;
        //}

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
            for(int j = 0; j < dt.Columns.Count; j++)
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
            PageChangedEventArgs ex = new PageChangedEventArgs(1);
            QueryClass qc = new QueryClass();
            QyxsckdDT= SelectSQL(qc, ex);
            GridView1.DataSource = QyxsckdDT;

            GridView1.DataBind();
        }

        private void GetKhhd()
        {
            PagerParameter pagepara = new PagerParameter();
            pagepara.DbConn = GlabalString.DBString;
            pagepara.Sql = _htglLogic.QueryMkzxzcdOrder();
            pagepara.OrderBy = "dwmc";
            MkzxDT= xsPageHelper.BindPager(pagepara);
        }
    }
}