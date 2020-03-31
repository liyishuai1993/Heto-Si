using System;
using System.Collections.Generic;
using xs_System.Logic;
using xsFramework.Web.WebPage;
using xsFramework.Web.Login;
using System.IO;
using System.Data;
using NPOI.HSSF.UserModel;
using NPOI.HPSF;
using NPOI.POIFS.FileSystem;

using DataTable = System.Data.DataTable;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

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

        protected void UploadBtn_Click(object sender, EventArgs e)
        {
            if (ExcelFileUpload.HasFile == false)
            {
                AlertMessage("请选择Excel文件");
                return;
            }
            string isXls = Path.GetExtension(ExcelFileUpload.FileName).ToString().ToLower();
            if (isXls != ".xlsx" && isXls != ".xls")
            {
                AlertMessage("只能上传Excel文件");
                return;
            }
            string filename = ExcelFileUpload.FileName;
            string savePath = Server.MapPath(filename);//Server.MapPath 服务器上的指定虚拟路径相对应的物理文件路径
            ExcelFileUpload.SaveAs(savePath);//将文件保存到指定路径
            DataTable dt = ExcelToTable(savePath);
            File.Delete(savePath);
            AlertMessage("上传文件读取数据成功！");
        }

        /// <summary>
        /// Excel导入成Datable
        /// </summary>
        /// <param name="file">导入路径(包含文件名与扩展名)</param>
        /// <returns></returns>
        public static DataTable ExcelToTable(string file)
        {
            DataTable dt = new DataTable();
            IWorkbook workbook;
            string fileExt = Path.GetExtension(file).ToLower();
            using (FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read))
            {
                //XSSFWorkbook 适用XLSX格式，HSSFWorkbook 适用XLS格式
                if (fileExt == ".xlsx")
                {
                    workbook = new XSSFWorkbook(fs);
                }
                else if (fileExt == ".xls")
                {
                    workbook = new HSSFWorkbook(fs);
                }
                else { workbook = null; }
                if (workbook == null) { return null; }
                ISheet sheet = workbook.GetSheetAt(0);

                //表头  
                IRow header = sheet.GetRow(sheet.FirstRowNum);
                List<int> columns = new List<int>();
                for (int i = 0; i < header.LastCellNum; i++)
                {
                    object obj = GetValueType(header.GetCell(i));
                    if (obj == null || obj.ToString() == string.Empty)
                    {
                        dt.Columns.Add(new DataColumn("Columns" + i.ToString()));
                    }
                    else
                        dt.Columns.Add(new DataColumn(obj.ToString()));
                    columns.Add(i);
                }
                //数据  
                for (int i = sheet.FirstRowNum + 1; i <= sheet.LastRowNum; i++)
                {
                    DataRow dr = dt.NewRow();
                    bool hasValue = false;
                    foreach (int j in columns)
                    {
                        dr[j] = GetValueType(sheet.GetRow(i).GetCell(j));
                        if (dr[j] != null && dr[j].ToString() != string.Empty)
                        {
                            hasValue = true;
                        }
                    }
                    if (hasValue)
                    {
                        dt.Rows.Add(dr);
                    }
                }
            }
            return dt;
        }

        /// <summary>
         /// 获取单元格类型
         /// </summary>
         /// <param name="cell"></param>
         /// <returns></returns>
         private static object GetValueType(ICell cell)
         {
             if (cell == null)
                 return null;
             switch (cell.CellType)
             {
                 case CellType.Blank: //BLANK:  
                     return null;
                case CellType.Boolean: //BOOLEAN:  
                    return cell.BooleanCellValue;
                 case CellType.Numeric: //NUMERIC:  
                     return cell.NumericCellValue;
                 case CellType.String: //STRING:  
                     return cell.StringCellValue;
                 case CellType.Error: //ERROR:  
                     return cell.ErrorCellValue;
                 case CellType.Formula: //FORMULA:  
                 default:
                     return "=" + cell.CellFormula;
 
             }
         }
    }
}