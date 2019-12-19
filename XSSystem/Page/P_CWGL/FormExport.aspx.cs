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
        static DataTable TyxsckdDT;
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

        private void GetAllData()
        {
            foreach (DataRow val in MkzxDT.Rows)
            {
                QyxsckdDT.ImportRow(val);
            }
            foreach (DataRow val in TyxsckdDT.Rows)
            {
                QyxsckdDT.ImportRow(val);
            }

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {

            //QueryClass qc = new QueryClass();
            //qc.tableName = "xs_QyxsckdTable";
            //PageChangedEventArgs pe = new PageChangedEventArgs(1);
            ////DataTable dt = new DataTable();
            ////foreach (DataRow dataRow in Jgxx_dataTable.Rows)
            ////{
            ////    dt.Rows.Add(dataRow);
            ////}
            //QyxsckdDT.Rows.Clear();
            //GetMkzxzcd();
            //GetTyxsckd();
            //DataRow emRow = QyxsckdDT.NewRow();
            //emRow[0] = " ";
            //QyxsckdDT.Rows.Add(emRow);
            //foreach (DataRow val in MkzxDT.Rows)
            //{
            //    QyxsckdDT.ImportRow(val);
            //}
            //QyxsckdDT.ImportRow(emRow);
            //foreach (DataRow val in TyxsckdDT.Rows)
            //{
            //    QyxsckdDT.ImportRow(val);
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
            if (QyxsckdDT.Columns.Contains("PID"))
            {
                QyxsckdDT.Columns.Remove("PID");
            }
            DataRow row = QyxsckdDT.NewRow();
            row[0] = "合计";
            row[3] = QyxsckdDT.Compute("sum(出库吨位)", "TRUE");
            row[4] = QyxsckdDT.Compute("sum(到货吨位)", "TRUE");
            row[6] = QyxsckdDT.Compute("sum(销售结算吨位)", "TRUE");
            row[8] = QyxsckdDT.Compute("sum(销售结算金额)", "TRUE");
            QyxsckdDT.Rows.Add(row);
            CreateExcel(QyxsckdDT, "application/ms-excel", $"{kh.Text}销售明细{cxsjQ.Text}-{cxsjZ.Text}");



        }

        DataTable SelectSQL(QueryClass qc, PageChangedEventArgs e)
        {
            PagerParameter pagepara = new PagerParameter();
            pagepara.DbConn = GlabalString.DBString;
           // pagepara.Sql = _htglLogic.QueryQyxsckdOrder();
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
            //PageChangedEventArgs ex = new PageChangedEventArgs(1);
            //QueryClass qc = new QueryClass();
            //QyxsckdDT= SelectSQL(qc, ex);
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
            qc.qdrqQ = Convert.ToDateTime(cxsjQ.Text.Trim());
            qc.qdrqZ = Convert.ToDateTime(cxsjZ.Text.Trim());
            qc.selectedItem = kh.Text.Trim();
            GetQyxsckd(qc);
            GetMkzxzcd(qc);
            GetTyxsckd(qc);
            GetAllData();
            GridView1.DataSource = QyxsckdDT;

            GridView1.DataBind();
        }

        private void GetQyxsckd(QueryClass qc)
        {
            PagerParameter pagepara = new PagerParameter();
            pagepara.DbConn = GlabalString.DBString;
            pagepara.Sql = _htglLogic.QueryQyxsckdOrder(qc);
            pagepara.OrderBy = "dwmc";
            QyxsckdDT = xsPageHelper.BindPager(pagepara);
        }

        private void GetMkzxzcd(QueryClass qc)
        {
            PagerParameter pagepara = new PagerParameter();
            pagepara.DbConn = GlabalString.DBString;
            pagepara.Sql = _htglLogic.QueryMkzxzcdOrder(qc);
            pagepara.OrderBy = "dwmc";
            MkzxDT= xsPageHelper.BindPager(pagepara);
        }

        private void GetTyxsckd(QueryClass qc)
        {
            PagerParameter pagepara = new PagerParameter();
            pagepara.DbConn = GlabalString.DBString;
            pagepara.Sql = _htglLogic.QueryTyxsckdOrder(qc);
            pagepara.OrderBy = "dwmc";
            TyxsckdDT = xsPageHelper.BindPager(pagepara);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            QueryClass qc = new QueryClass();
            qc.IsAll = 1;
            GetQyxsckd(qc);
            GetMkzxzcd(qc);
            GetTyxsckd(qc);
            GetAllData();
            GridView1.DataSource = QyxsckdDT;

            GridView1.DataBind();
        }

        double ckdwSum, dhdwSum, xsjsdwSum, xsjsjeSum;
        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            try
            {
                if (e.Row.RowIndex >= 0)
                {
                    ckdwSum += Convert.ToDouble(e.Row.Cells[4].Text);
                    dhdwSum += Convert.ToDouble(e.Row.Cells[5].Text);
                    xsjsdwSum += Convert.ToDouble(e.Row.Cells[7].Text);
                    xsjsjeSum += Convert.ToDouble(e.Row.Cells[9].Text);
                }
                else if (e.Row.RowType == DataControlRowType.Footer)
                {
                    e.Row.Cells[1].Text = "汇总合计";
                    e.Row.Cells[4].Text = ckdwSum.ToString();
                    e.Row.Cells[5].Text = dhdwSum.ToString();
                    e.Row.Cells[7].Text = xsjsdwSum.ToString();
                    e.Row.Cells[9].Text = xsjsjeSum.ToString();
                }
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "script", "<script>alert('" + ex.Message + "')</script>", false);
            }
        }
    }
}