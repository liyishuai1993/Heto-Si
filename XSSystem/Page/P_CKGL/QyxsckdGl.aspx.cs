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

namespace XSSystem.Page.P_CKGL
{
    public partial class QyxsckdGl : AuthWebPage
    {
        HTGLLogic _htglLogic = new HTGLLogic();
        static bool IsAll = true;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                tjz.Text = Session["selectedItemQyxsckd"]?.ToString();

                qdfwQ.Text = DateTime.Now.AddMonths(-6).ToShortDateString();
                qdfwZ.Text = DateTime.Now.AddMonths(6).ToShortDateString();
               // xsPage.StartShowPage();
                SelectedAll(1);

            }


        }

        protected void xsPage_PageChanged(object sender, PageChangedEventArgs e)
        {
            QueryClass qc = new QueryClass();
            if (IsAll)
            {
                SelectedAll(e.CurrentPage);
            }
            else
            {
                qc.tableName = "xs_QyxsckdTable";
                if (qdfwQ.Text != "")
                    qc.qdrqQ = Convert.ToDateTime(qdfwQ.Text.Trim());
                if (qdfwZ.Text != "")
                    qc.qdrqZ = Convert.ToDateTime(qdfwZ.Text.Trim());
                qc.selectedTimeKey = "zcsj";
                qc.selectedKey = sxtj.SelectedValue;
                qc.selectedItem = tjz.Text.Trim();
                qc.selectedCon = con.SelectedValue;

                GridOrder.DataSource = SelectSQL(qc, e, 1);
                GridOrder.DataBind();
            }
        }

        DataTable SelectSQL(QueryClass qc, PageChangedEventArgs e,int flag)
        {
            PagerParameter pagepara = new PagerParameter();
            LoginModel model = Session["LoginModel"] as LoginModel;
            qc.user_no = model.LoginUser;

            pagepara.DbConn = GlabalString.DBString;
            pagepara.XsPager = xsPage;
            if (flag == 1)
            {
                pagepara.Sql = _htglLogic.QueryHt2Order(qc);
                pagepara.OrderBy = "ckbdh";
            }
            else
            {
                pagepara.Sql = _htglLogic.QueryHt2Order(qc);
                pagepara.OrderBy = "rkbdh";
            }
            
            return xsPageHelper.BindPager(pagepara, e);
        }

        protected void btnDel_Click(object sender, EventArgs e)
        {
            string str = "";
            DirModel dml = new DirModel();
            string[] ckb = null;

            str = Request.Form.Get("checkboxname");
            if (str == null)
            {
                AlertMessage("当前未选中订单");
                return;
            }
            ckb = str.Split(new char[] { ',' });



            dml.Add("@htbhArr", ckb);
            if (_htglLogic.DeleteData(dml, "xs_QyxsckdTable","ckbdh"))
            {
                AlertMessage("订单删除成功");
            }
            else
            {
                AlertMessage("订单删除失败");
            }
            xsPage.RefreshPage();
            //    Response.Write("直接在页面中得到的值为：" + str + "<br>");

            // Response.Write("处理后存放在数组中，如下：<br>");
            //for (int i = 0; i < ckb.Length; i++)
            //{
            //    sql += ckb[i];
            //}
        }




        protected void btnAdd_Click(object sender, EventArgs e)
        {
             JavaScript("window.location.href='Qyxsckd.aspx'");
           // Response.Redirect("'Cght.aspx");
        }
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            QueryClass qc = new QueryClass();
            QueryClass qc2 = new QueryClass();
            string[] estr = (sender as Button).CommandArgument.ToString().Split(',');
            qc.selectedItem = estr[0];
            qc.selectedKey = "ckbdh";
            qc.tableName = "xs_QyxsckdTable";
            qc.selectedTimeKey = "zcsj";
            qc.selectedCon = "or";

            qc2.selectedItem = estr[1];
            qc2.selectedKey = "rkbdh";
            qc2.tableName = "xs_QykhhdlrTable";
            qc2.selectedCon = "or";
            qc2.selectedTimeKey = "rksj";
            PageChangedEventArgs ex = new PageChangedEventArgs(1);
            DataTable dt = SelectSQL(qc, ex,1);
            DataTable dt2 = SelectSQL(qc2, ex, 2);
            Session["qyxsckd"] = dt;
            if (dt2.Rows.Count > 0)
            {
                Session["qykhhdlr"] = dt2;
            }
            JavaScript("window.location.href='Qyxsckd.aspx'");
        }

        protected void btnViewHD_Click(object sender, EventArgs e)
        {
            QueryClass qc = new QueryClass();
            qc.rkbdh= (sender as Button).CommandArgument;
            
            PageChangedEventArgs ex = new PageChangedEventArgs(1);
            DataTable dt = SelectSQL(qc, ex,2);
            if (dt.Rows.Count == 0)
            {
                AlertMessage("无对应客户回单");
            }
            else
            {
                Session["qykhhdlr"] = dt;
                JavaScript("window.location.href='Qykhhdlr.aspx'");
            }    
            
        }
        


        protected void btnQuery_Click(object sender, EventArgs e)
        {
            Session["selectedItemQyxsckd"] = tjz.Text.Trim();
            IsAll = false;
            xsPage.RefreshPage();
        }


        protected void ddlnewtype_selectedindexchanged(object sender, EventArgs e)
        {
            xsPage.StartShowPage();
        }

        protected void allQuery_Click(object sender, EventArgs e)
        {
            IsAll = true;
            SelectedAll(1);
        }

        private void SelectedAll(int page)
        {
            PageChangedEventArgs ex = new PageChangedEventArgs(page);
            QueryClass qc = new QueryClass();
            qc.tableName = "xs_QyxsckdTable";
            qc.selectedTimeKey = "zcsj";
            qc.selectedKey = "ckbdh";
            qc.IsAll = 1;
            GridOrder.DataSource = SelectSQL(qc, ex, 1);

            GridOrder.DataBind();
        }

        protected void Tj_Btn_Click(object sender, EventArgs e)
        {
            
            List<DirModel> list = new List<DirModel>();
            LoginModel model = Session["LoginModel"] as LoginModel;
            DirModel temp;
            string str = "";
            string[] ckb = null;


            str = Request.Form.Get("checkboxname");
            if (str == null)
            {
                AlertMessage("当前未选中订单");
                return;
            }
            ckb = str.Split(new char[] { ',' });

            foreach (var val in ckb)
            {
                temp = new DirModel();
                temp.Add("@user_no", model.LoginUser);
                temp.Add("@key", val);
                temp.Add("@zxj", tj.Text.Trim());
                list.Add(temp);
            }
            var reply = _htglLogic.UpdatePrice("xs_QyxsckdTable", "ckbdh", "mj", list);
            if (reply == "")
            {
                xsPage.RefreshPage();
                AlertMessage("改价成功！");
            }
            else
            {
                AlertMessage(reply);
            }
        }


        #region 批量

        /// <summary>
        /// 出库单上传
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            DataTable dt = ImportTool.ExcelToTable(savePath,0);
            List<DirModel> dirs = ReadExcel(dt);
            var ret = _htglLogic.BatchInsertQyxsckd(dirs);
            File.Delete(savePath);
            if (ret == "")
            {
                AlertMessage("上传文件读取数据成功！");
                SelectedAll(1);
            }
            else
            {
                AlertMessage(ret);
            }
            
        }

        /// <summary>
        /// 解析出库单
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        private List<DirModel> ReadExcel(DataTable dt)
        {
            LoginModel model = Session["LoginModel"] as LoginModel;
            List<DirModel> dirs = new List<DirModel>();
            DirModel dml;
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                dml = new DirModel();
                dml.Add("@user_no", model.LoginUser);
                dml.Add("@ckbdh", dt.Rows[i][0].ToString());
                dml.Add("@htbh", dt.Rows[i][1].ToString());
                dml.Add("@zcsj", Convert.ToDateTime(dt.Rows[i][2].ToString()));
                dml.Add("@fmmc", dt.Rows[i][3].ToString());
                dml.Add("@gf", dt.Rows[i][4].ToString());
                dml.Add("@xf", dt.Rows[i][5].ToString());
                dml.Add("@ch", dt.Rows[i][6].ToString());
                dml.Add("@wlmc", dt.Rows[i][7].ToString());
                dml.Add("@ckpz", float.Parse(dt.Rows[i][8].ToString()));
                dml.Add("@ckmz", float.Parse(dt.Rows[i][9].ToString()));
                dml.Add("@jbds", float.Parse(dt.Rows[i][10].ToString()));
                dml.Add("@ckjz1", float.Parse(dt.Rows[i][11].ToString()));
                dml.Add("@ckjz2", float.Parse(dt.Rows[i][12].ToString()));
                dml.Add("@mj", float.Parse(dt.Rows[i][13].ToString()));
                dml.Add("@hkgsje", float.Parse(dt.Rows[i][14].ToString()));
                dml.Add("@yfyk", float.Parse(dt.Rows[i][15].ToString()));
                dml.Add("@yj", float.Parse(dt.Rows[i][16].ToString()));
                dml.Add("@fkzh", dt.Rows[i][17].ToString());
                dml.Add("@jsy", dt.Rows[i][18].ToString());
                dml.Add("@lxdh", dt.Rows[i][19].ToString());
                dirs.Add(dml);
            }
            return dirs;
        }

        /// <summary>
        /// 回单上传
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void HdBtn_Click(object sender, EventArgs e)
        {
            if (HDFileUpload.HasFile == false)
            {
                AlertMessage("请选择Excel文件");
                return;
            }
            string isXls = Path.GetExtension(HDFileUpload.FileName).ToString().ToLower();
            if (isXls != ".xlsx" && isXls != ".xls")
            {
                AlertMessage("只能上传Excel文件");
                return;
            }
            string filename = HDFileUpload.FileName;
            string savePath = Server.MapPath(filename);//Server.MapPath 服务器上的指定虚拟路径相对应的物理文件路径
            HDFileUpload.SaveAs(savePath);//将文件保存到指定路径
            DataTable dt = ImportTool.ExcelToTable(savePath, 0);
            List<DirModel> dirs = ReadHDExcel(dt);
            var ret = _htglLogic.BatchInsertQyhdlr(dirs);
            File.Delete(savePath);
            if (ret == "")
            {
                AlertMessage("上传文件读取数据成功！");
                SelectedAll(1);
            }
            else
            {
                AlertMessage(ret);
            }
        }

        /// <summary>
        /// 解析出库单
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        private List<DirModel> ReadHDExcel(DataTable dt)
        {
            DataTable ckdDt = GetAllData();
            LoginModel model = Session["LoginModel"] as LoginModel;
            List<DirModel> dirs = new List<DirModel>();
            DirModel dml=new DirModel();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                var rows = ckdDt.Select($"ckbdh='{dt.Rows[i][2].ToString()}'");
                if (rows.Count() == 0)
                {
                    continue;
                }
                //不引用
                if (dt.Rows[i][0].ToString() == "")
                {
                    var row = rows.FirstOrDefault();
                    var hd = CalRowNormal(row, dt.Rows[i]);
                    dml = new DirModel();
                    dml.Add("@user_no", model.LoginUser);
                    dml.Add("@rkbdh", dt.Rows[i][1].ToString());
                    dml.Add("@ckbdh", dt.Rows[i][2].ToString());
                    dml.Add("@rksj", Convert.ToDateTime(dt.Rows[i][3].ToString()));
                    dml.Add("@rkpz",float.Parse(dt.Rows[i][4].ToString()));
                    dml.Add("@rkmz",float.Parse(dt.Rows[i][5].ToString()));
                    dml.Add("@kd", float.Parse(dt.Rows[i][6].ToString()));
                    dml.Add("@yfhllh",float.Parse(dt.Rows[i][7].ToString()));
                    dml.Add("@yflhbz",float.Parse(dt.Rows[i][8].ToString()));
                    dml.Add("@fykk", float.Parse(dt.Rows[i][9].ToString()));
                    dml.Add("@tcbz", dt.Rows[i][10].ToString());
                    dml.Add("@rkjz", float.Parse(hd[11].ToString()));
                    dml.Add("@ksds", float.Parse(hd[12].ToString()));
                    dml.Add("@yyds", float.Parse(hd[13].ToString()));
                    dml.Add("@yfkkds", float.Parse(hd[14].ToString()));
                    dml.Add("@yfkkje", float.Parse(hd[15].ToString()));
                    dml.Add("@yfjsdw", float.Parse(hd[16].ToString()));
                    dml.Add("@yfyf", float.Parse(hd[17].ToString()));
                    dml.Add("@jsyf",float.Parse(hd[18].ToString()));
                    dml.Add("@hkjsdw",float.Parse(hd[19].ToString()));
                    dml.Add("@jshk",float.Parse(hd[20].ToString()));
                    dml.Add("@tcje",float.Parse(hd[21].ToString()));
                    dml.Add("@yfjszt", dt.Rows[i][22].ToString());
                    dml.Add("@shzt", dt.Rows[i][23].ToString());
                    dml.Add("@ywy", dt.Rows[i][24].ToString());
                }
                else
                {
                    //var rows = ckdDt.Select($"ckbdh='{dt.Rows[i][2].ToString()}'");

                    var row = rows.FirstOrDefault();
                    var hd = CalRow(row, dt.Rows[i]);
                    dml = new DirModel();
                    dml.Add("@user_no", model.LoginUser);
                    dml.Add("@rkbdh", dt.Rows[i][1].ToString());
                    dml.Add("@ckbdh", row[1].ToString());
                    dml.Add("@rksj", Convert.ToDateTime(dt.Rows[i][3].ToString()));
                    dml.Add("@rkpz", float.Parse(row[12].ToString()));
                    dml.Add("@rkmz", float.Parse(row[11].ToString()));
                    dml.Add("@kd", 0);
                    dml.Add("@yfhllh", 0);
                    dml.Add("@yflhbz", 0);
                    dml.Add("@fykk", 0);
                    dml.Add("@tcbz", 0);
                    dml.Add("@rkjz", float.Parse(hd[11].ToString()));
                    dml.Add("@ksds", float.Parse(hd[12].ToString()));
                    dml.Add("@yyds", float.Parse(hd[13].ToString()));
                    dml.Add("@yfkkds", float.Parse(hd[14].ToString()));
                    dml.Add("@yfkkje", 0);
                    dml.Add("@yfjsdw", float.Parse(hd[16].ToString()));
                    dml.Add("@yfyf", float.Parse(hd[17].ToString()));
                    dml.Add("@jsyf", float.Parse(hd[18].ToString()));
                    dml.Add("@hkjsdw", float.Parse(hd[19].ToString()));
                    dml.Add("@jshk", float.Parse(row[17].ToString()));
                    dml.Add("@tcje", 0);
                    dml.Add("@yfjszt", dt.Rows[i][22].ToString());
                    dml.Add("@shzt", dt.Rows[i][23].ToString());
                    dml.Add("@ywy", dt.Rows[i][24].ToString());
                }
                
                dirs.Add(dml);
            }
            return dirs;
        }

        private DataRow CalRow(DataRow ckd,DataRow hd)
        {
            var rkjz = Sub(ckd[11].ToString(), ckd[12].ToString());
            var ksds = Sub(ckd[15].ToString(), rkjz);
            var yyds= Sub(rkjz,ckd[15].ToString());
            var yfkkds = ksds;
            var yfjsdw = rkjz;
            var yfyf = Mul(yfjsdw, ckd[19].ToString());
            var jsyf = Sub(yfyf, ckd[18].ToString());
            var hkjsdw = rkjz;
            hd[11] = rkjz;
            hd[12] = ksds;
            hd[13] = yyds;
            hd[14] = yfkkds;
            hd[16] = yfjsdw;
            hd[17] = yfyf;
            hd[18] = jsyf;
            hd[19] = hkjsdw;
            return hd;
        }

        private DataRow CalRowNormal(DataRow ckd,DataRow hd)
        {
            var rkjz = Sub(hd[5].ToString(), hd[4].ToString());
            var ksds= AbsSub(ckd[15].ToString(), rkjz);
            var yyds = Sub(rkjz, ckd[15].ToString());
            string yfkkds, yfkkje;
            if (double.Parse(yyds) >= 0)
            {
                yfkkds = "0";
                yfkkje = "0";
            }
            else
            {
                yfkkds = Sub(ksds, hd[7].ToString());
                yfkkje = Mul(hd[8].ToString(), yfkkds);
            }

            double temp = double.Parse(ckd[15].ToString()) - double.Parse(rkjz);
            var yfjsdw = temp > 0 ? rkjz : ckd[15].ToString();
            var yfyf = Sub(Mul(yfjsdw, ckd[19].ToString()), yfkkje);
            var jsyf = Sub(Sub(yfyf, ckd[18].ToString()), hd[9].ToString());
            var hkjsdw = Sub(rkjz, hd[6].ToString());
            var jshk = Mul(hkjsdw, ckd[16].ToString());
            var tcje = Mul(hkjsdw, hd[10].ToString());

            hd[11] = rkjz;
            hd[12] = ksds;
            hd[13] = yyds;
            hd[14] = yfkkds;
            hd[15] = yfkkje;
            hd[16] = yfjsdw;
            hd[17] = yfyf;
            hd[18] = jsyf;
            hd[19] = hkjsdw;
            hd[20] = jshk;
            hd[21] = tcje;
            return hd;
        }

        private DataTable GetAllData()
        {
            QueryClass qc = new QueryClass();
            LoginModel model = Session["LoginModel"] as LoginModel;
            qc.tableName = "xs_QyxsckdTable";
            qc.selectedTimeKey = "zcsj";
            qc.selectedKey = "ckbdh";
            qc.IsAll = 1;
            PagerParameter pagepara = new PagerParameter();
            qc.user_no = model.LoginUser;

            pagepara.DbConn = GlabalString.DBString;
            pagepara.XsPager = xsPage;
            pagepara.Sql = _htglLogic.QueryHt2Order(qc);
            pagepara.OrderBy = "ckbdh";


            return xsPageHelper.BindPager(pagepara);
        }

        #endregion


    }
}