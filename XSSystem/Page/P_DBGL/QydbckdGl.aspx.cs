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

namespace XSSystem.Page.P_DBGL
{
    public partial class QydbckdGl : AuthWebPage
    {
        HTGLLogic _htglLogic = new HTGLLogic();
        static bool IsAll = true;


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                tjz.Text = Session["selectedItemQydbckd"]?.ToString();
                qdfwQ.Text = DateTime.Now.AddMonths(-6).ToShortDateString();
                qdfwZ.Text = DateTime.Now.AddMonths(6).ToShortDateString();
                //xsPage.StartShowPage();
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
                qc.tableName = "xs_QydbckdTable";
                if (qdfwQ.Text != "")
                    qc.qdrqQ = Convert.ToDateTime(qdfwQ.Text.Trim());
                if (qdfwZ.Text != "")
                    qc.qdrqZ = Convert.ToDateTime(qdfwZ.Text.Trim());
                qc.selectedKey = sxtj.SelectedValue;
                qc.selectedTimeKey = "zcsj";
                qc.selectedItem = tjz.Text.Trim();
                qc.selectedCon = con.SelectedValue;


                //if (!"G001".Equals(LoginUser.LoginUserGroup))
                //{
                //    gvUser.Columns[2].Visible = false;
                //}
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
            if (_htglLogic.DeleteData(dml, "xs_QydbckdTable", "bh"))
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
             JavaScript("window.location.href='Qydbckd.aspx'");
           // Response.Redirect("'Cght.aspx");
        }
       // QydbckdClass qydbckdClass;
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            QueryClass qc = new QueryClass();
            QueryClass qc2 = new QueryClass();
            string[] estr = (sender as Button).CommandArgument.ToString().Split(',');
            qc.selectedItem = estr[0];
            qc.tableName = "xs_QydbckdTable";
            qc.selectedKey = "ckbdh";
            qc.selectedTimeKey = "zcsj";
            qc.selectedCon = "or";
            qc2.tableName = "xs_QydbhdTable";
            qc2.selectedKey = "rkbdh";
            qc2.selectedTimeKey = "rksj";
            qc2.selectedCon = "or";
            qc2.selectedItem = estr[1];

            PageChangedEventArgs ex = new PageChangedEventArgs(1);
            DataTable dt = SelectSQL(qc, ex,1);
            DataTable dt2 = SelectSQL(qc2, ex, 2);
            Session["qydbckd"] = dt;
            if (dt2.Rows.Count > 0)
            {
                Session["qydbhd"] = dt2;
            }
            JavaScript("window.location.href='Qydbckd.aspx'");
        }

        protected void btnViewHD_Click(object sender, EventArgs e)
        {
            QueryClass qc = new QueryClass();
            qc.rkbdh = (sender as Button).CommandArgument;

            PageChangedEventArgs ex = new PageChangedEventArgs(1);
            DataTable dt = SelectSQL(qc, ex, 2);
            if (dt.Rows.Count == 0)
            {
                AlertMessage("无对应客户回单");
            }
            else
            {
                Session["qydbhd"] = dt;
                JavaScript("window.location.href='Qydbhd.aspx'");
            }

        }




        protected void btnQuery_Click(object sender, EventArgs e)
        {
            Session["selectedItemQydbckd"] = tjz.Text.Trim();
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
            qc.tableName = "xs_QydbckdTable";
            qc.selectedKey = "ckbdh";
            qc.selectedTimeKey = "zcsj";
            qc.IsAll = 1;
            GridOrder.DataSource = SelectSQL(qc, ex,1);

            GridOrder.DataBind();
        }

        double ckjzSum = 0;
        double dbjeSum = 0;
        protected void GridOrder_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            
            //for(int i = -1; i < GridOrder.Rows.Count; i++)
            //{
            //    if (e.Row.RowType == DataControlRowType.DataRow)
            //    {
            //        e.Row.Attributes.Add("onmouseover", "c=this.style.backgroundColor,this.style.backgroundColor='#00A9FF'");
            //        e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=c");
            //    }
            //}

            try
            {
                if (e.Row.RowIndex >= 0)
                {
                    ckjzSum += Convert.ToDouble(e.Row.Cells[7].Text);
                    dbjeSum += Convert.ToDouble(e.Row.Cells[9].Text);
                }
                else if (e.Row.RowType == DataControlRowType.Footer)
                {
                    e.Row.Cells[1].Text = "汇总";
                    e.Row.Cells[6].Text = "出库净重合计：";
                    e.Row.Cells[7].Text = ckjzSum.ToString();
                    e.Row.Cells[8].Text = "调拨金额合计：";
                    e.Row.Cells[9].Text = dbjeSum.ToString();

                }
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "script", "<script>alert('" + ex.Message + "')</script>", false);
            }
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
            var reply = _htglLogic.UpdatePrice("xs_QydbckdTable", "bh", "dcmj", list);
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
    }
}