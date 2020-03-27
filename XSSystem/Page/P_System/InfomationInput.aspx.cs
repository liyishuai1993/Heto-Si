using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using xs_System.Logic;
using System.Web.UI.WebControls;
using xsFramework.Web.WebPage;
using xsFramework.Web.Login;
using System.IO;
using System.Data;
using System.Data.OleDb;

namespace XSSystem.Page.P_System
{
    public partial class InfomationInput : AuthWebPage
    {
        HTGLLogic _htglLogic = new HTGLLogic();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 物料名称
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void submit1_Click(object sender, EventArgs e)
        {
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;
            dml.Add("@user_no", model.LoginUser);
            dml.Add("@mzmc", MZ.Text.Trim());
            if (_htglLogic.InsertMeZhong(dml))
            {
                AlertMessage("新增成功");
            }
            else
            {
                AlertMessage("已存在，添加失败！");
            }
        }

        /// <summary>
        /// 煤场
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void submit2_Click(object sender, EventArgs e)
        {
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;
            dml.Add("@user_no", model.LoginUser);
            dml.Add("@yl", YL.Text.Trim());
            if (_htglLogic.InsertYuanLiao(dml))
            {
                AlertMessage("新增成功");
            }
            else
            {
                AlertMessage("已存在，添加失败！");
            }
        }

        //protected void submit3_Click(object sender, EventArgs e)
        //{
        //    DirModel dml = new DirModel();
        //    LoginModel model = Session["LoginModel"] as LoginModel;
        //    dml.Add("@user_no", model.LoginUser);
        //    dml.Add("@cp", CP.Text.Trim());
        //    if (_htglLogic.InsertChanPing(dml))
        //    {
        //        AlertMessage("新增成功");
        //    }
        //    else
        //    {
        //        AlertMessage("已存在，添加失败！");
        //    }
        //}

            /// <summary>
            /// 往来单位
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
        protected void submit4_Click(object sender, EventArgs e)
        {
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;
            dml.Add("@user_no", model.LoginUser);
            dml.Add("@wldw", WLDW.Text.Trim());
            dml.Add("@type", DWType.SelectedValue);
            if (_htglLogic.InsertWangLaiDanWei(dml))
            {
                AlertMessage("新增成功");
            }
            else
            {
                AlertMessage("已存在，添加失败！");
            }
        }

        /// <summary>
        /// 账户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;
            dml.Add("@user_no", model.LoginUser);
            dml.Add("@zh", ZH.Text.Trim());
            dml.Add("@zhm", ZHM.Text.Trim());
            dml.Add("@khh", KHH.Text.Trim());
            if (_htglLogic.InsertZhangHu(dml))
            {
                AlertMessage("新增成功");
                GlabalString.GetZH();
            }
            else
            {
                AlertMessage("已存在，添加失败！");
            }
        }

        /// <summary>
        /// 人员
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void submit5_Click(object sender, EventArgs e)
        {
            DirModel dml = new DirModel();
            dml.Add("@yg", YG.Text.Trim());
            if (_htglLogic.InsertYuanGong(dml))
            {
                AlertMessage("新增成功");
            }
            else
            {
                AlertMessage("已存在，添加失败！");
            }
        }

        protected void UploadBtn_Click(object sender,EventArgs e)
        {
            if (ExcelFileUpload.HasFile == false)
            {
                AlertMessage("请选择Excel文件");
                return;
            }
            string isXls = Path.GetExtension(ExcelFileUpload.FileName).ToString().ToLower();
            if(isXls!=".xlsx" && isXls != ".xls")
            {
                AlertMessage("只能上传Excel文件");
                return;
            }
            string filename = ExcelFileUpload.FileName;
            string savePath = Server.MapPath(filename);//Server.MapPath 服务器上的指定虚拟路径相对应的物理文件路径
            ExcelFileUpload.SaveAs(savePath);//将文件保存到指定路径
            DataTable dt = GetExcelDatat(savePath);
            File.Delete(savePath);
            AlertMessage("上传文件读取数据成功！");
        }

        private static DataTable GetExcelDatat(string fileUrl)
        {
            string cmdText = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileUrl + "; Extended Properties=\"Excel 12.0;HDR=Yes\"";
            DataTable dt = null;
            OleDbConnection conn = new OleDbConnection(cmdText);
            try
            {
                if (conn.State == ConnectionState.Broken || conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                DataTable data = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                string strSql = "select * from [Sheet1$]";
                OleDbDataAdapter da = new OleDbDataAdapter(strSql, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dt = ds.Tables[0];
                return dt;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }
    }
}