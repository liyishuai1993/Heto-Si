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
    public partial class Khtzmx : AuthWebPage
    {
        HTGLLogic _htglLogic = new HTGLLogic();
        static DataTable KhtzDT;

        static DataTable QyxsckdDT;
        static DataTable MkzxDT;
        static DataTable TyxsckdDT;
        static DataTable SkdDT;
        static DataTable FkdDT;
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
            KhtzDT = new DataTable();
            KhtzDT.Columns.Add("dwmc", Type.GetType("System.String"));
            KhtzDT.Columns.Add("rq", Type.GetType("System.String"));
            KhtzDT.Columns.Add("ch", Type.GetType("System.String"));
            KhtzDT.Columns.Add("ckdw", Type.GetType("System.Double"));
            KhtzDT.Columns.Add("dhdw", Type.GetType("System.Double"));
            KhtzDT.Columns.Add("kd", Type.GetType("System.Double"));
            KhtzDT.Columns.Add("xsjsdw", Type.GetType("System.Double"));
            KhtzDT.Columns.Add("mj", Type.GetType("System.Double"));
            KhtzDT.Columns.Add("xsjsje", Type.GetType("System.Double"));
            KhtzDT.Columns.Add("skje", Type.GetType("System.Double"));
            KhtzDT.Columns.Add("skfs", Type.GetType("System.Double"));
            GridView1.DataSource = KhtzDT;
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
            foreach (DataRow val in FkdDT.Rows)
            {
                SkdDT.ImportRow(val);
            }
            QyxsckdDT.Merge(SkdDT);
            

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {

            KhtzDT.Columns[0].ColumnName = "单位名称";
            KhtzDT.Columns[1].ColumnName = "日期";
            KhtzDT.Columns[2].ColumnName = "车号";
            KhtzDT.Columns[3].ColumnName = "出库吨位";
            KhtzDT.Columns[4].ColumnName = "到货吨位";
            KhtzDT.Columns[5].ColumnName = "扣吨";
            KhtzDT.Columns[6].ColumnName = "销售结算吨位";
            KhtzDT.Columns[7].ColumnName = "煤价";
            KhtzDT.Columns[8].ColumnName = "销售结算金额";
            KhtzDT.Columns[2].ColumnName = "摘要";
            KhtzDT.Columns[3].ColumnName = "收款金额";
            KhtzDT.Columns[4].ColumnName = "收款方式";
            KhtzDT.Columns[5].ColumnName = "收款账户";

            //ExportExcelByDataTable(dt,"test");
            if (KhtzDT.Columns.Contains("PID"))
            {
                KhtzDT.Columns.Remove("PID");
            }
            CreateExcel(KhtzDT, "application/ms-excel", "test");



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
            //PageChangedEventArgs ex = new PageChangedEventArgs(1);
            //QueryClass qc = new QueryClass();
            //QyxsckdDT= SelectSQL(qc, ex);
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
            MkzxDT = xsPageHelper.BindPager(pagepara);
        }

        private void GetTyxsckd(QueryClass qc)
        {
            PagerParameter pagepara = new PagerParameter();
            pagepara.DbConn = GlabalString.DBString;
            pagepara.Sql = _htglLogic.QueryTyxsckdOrder(qc);
            pagepara.OrderBy = "dwmc";
            TyxsckdDT = xsPageHelper.BindPager(pagepara);
        }

        private void GetSkd(QueryClass qc)
        {
            PagerParameter pagepara = new PagerParameter();
            pagepara.DbConn = GlabalString.DBString;
            pagepara.Sql = _htglLogic.QuerySkdOrder(qc);
            pagepara.OrderBy = "dwmc";
            SkdDT = xsPageHelper.BindPager(pagepara);
        }

        private void GetFkd(QueryClass qc)
        {
            PagerParameter pagepara = new PagerParameter();
            pagepara.DbConn = GlabalString.DBString;
            pagepara.Sql = _htglLogic.QueryFkdOrder(qc);
            pagepara.OrderBy = "dwmc";
            FkdDT = xsPageHelper.BindPager(pagepara);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            QueryClass qc = new QueryClass();
            qc.IsAll = 1;
            GetQyxsckd(qc);
            GetMkzxzcd(qc);
            GetTyxsckd(qc);
            GetSkd(qc);
            GetFkd(qc);
            GetAllData();
            GridView1.DataSource = QyxsckdDT;

            GridView1.DataBind();
        }
    }
}