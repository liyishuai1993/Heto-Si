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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {

            QueryClass qc = new QueryClass();
            qc.tableName = "xs_CghtTable";
            PageChangedEventArgs pe = new PageChangedEventArgs(1);
            DataTable dt = SelectSQL(qc, pe);
            dt.Columns[0].ColumnName = "用户名";
            dt.Columns[1].ColumnName = "合同编号";
            dt.Columns[2].ColumnName = "合同类型";
            dt.Columns[3].ColumnName = "签订日期";
            //ExportExcelByDataTable(dt,"test");
            CreateExcel(dt, "application/ms-excel", "test");



        }

        DataTable SelectSQL(QueryClass qc, PageChangedEventArgs e)
        {
            PagerParameter pagepara = new PagerParameter();
            pagepara.DbConn = GlabalString.DBString;
            pagepara.Sql = _htglLogic.QueryCghtOrder(qc);
            pagepara.OrderBy = "htbh";
            return xsPageHelper.BindPager(pagepara, e);
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
        /// 将DataTable 导出为EXCEL，并直接提供下载
        /// </summary>
        /// <param name="ds">需要导处的DataTable</param>
        /// <param name="fileName">到处生成的文件名</param>
        /// 
        public bool ExportExcelByDataTable(DataTable dt, string fileName)
        {
            try
            {
                HttpContext.Current.Response.Clear();
                HttpContext.Current.Response.Charset = "utf-7";
                HttpContext.Current.Response.ContentEncoding = System.Text.Encoding.GetEncoding("utf-7");

                HttpContext.Current.Response.ContentType = "application/vnd.ms-excel";
                StringWriter stringWrite = new StringWriter();
                HtmlTextWriter htmlWrite = new HtmlTextWriter(stringWrite);
                DataGrid dg = new DataGrid();
                dg.HeaderStyle.CssClass = "dgHead";
                dg.DataSource = dt;
                dg.DataBind();
                dg.RenderControl(htmlWrite);
                //            GridView gv = new GridView();
                //            gv.HeaderStyle.CssClass = "gvHead";
                //            gv.DataSource = dt;
                //            gv.DataBind();
                //            gv.RenderControl(htmlWrite);
                HttpContext.Current.Response.Write(stringWrite.ToString());
                HttpContext.Current.Response.AddHeader("content-disposition", "attachment; filename=" + HttpUtility.UrlEncode(fileName, System.Text.Encoding.UTF8) + ".xls");
                HttpContext.Current.Response.Charset = "gb2312";
                HttpContext.Current.Response.ContentEncoding = System.Text.Encoding.GetEncoding("gb2312");
                HttpContext.Current.Response.End();
                return true;
            }
            catch
            {
                return false;
            }
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
    }
}