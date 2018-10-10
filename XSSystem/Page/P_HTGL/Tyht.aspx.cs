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

namespace XSSystem.Page.P_Order
{
    public partial class Tyht : AuthWebPage
    {

        HTGLLogic _htglLogic = new HTGLLogic();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                DropListInit();
                if (Session["tyht"] != null)
                {
                    InitData(Session["tyht"]);
                }
                InitGridView();
            }
            
        }

        public void InitData(object mk)
        {
            DataTable dt = mk as DataTable;
            htbh.Text = dt.Rows[0][1].ToString();
            htlx.SelectedItem.Text = dt.Rows[0][2].ToString();
            qdrq.Text = dt.Rows[0][3].ToString();
            wtf.SelectedItem.Text = dt.Rows[0][4].ToString();
            stf.SelectedItem.Text = dt.Rows[0][5].ToString();
            fmmc.SelectedItem.Text = dt.Rows[0][6].ToString();
            wlmc.SelectedItem.Text = dt.Rows[0][7].ToString();
            zxqxQ.Text = dt.Rows[0][8].ToString();
            zxqxZ.Text = dt.Rows[0][9].ToString();
            zcz.SelectedItem.Text = dt.Rows[0][10].ToString();
            zdz.SelectedItem.Text = dt.Rows[0][11].ToString();
            xlx.SelectedItem.Text = dt.Rows[0][12].ToString();
            sl.Text = dt.Rows[0][13].ToString();
            Session.Remove("tyht");
        }

        public void InitGridView()
        {
            PagerParameter pagepara = new PagerParameter();
            pagepara.DbConn = GlabalString.DBString;
            QueryClass qc = new QueryClass();
            LoginModel model = Session["LoginModel"] as LoginModel;
            qc.user_no = model.LoginUser;
            qc.htbh = htbh.Text;
            qc.tableName = "xs_TyhtTable_Jgxx";
            pagepara.Sql = _htglLogic.QueryCghtChildTable(qc);
            pagepara.OrderBy = "htbh";

            PageChangedEventArgs e = new PageChangedEventArgs(0);
            this.GridView1.DataSource = xsPageHelper.BindPager(pagepara, e);
            this.GridView1.DataBind();
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;
            dml.Add("@htbh", htbh.Text.Trim());// ??????
            dml.Add("@userid", model.LoginUser);
            dml.Add("@htlx", htlx.SelectedItem.Text.Trim());
            dml.Add("@qdrq", Convert.ToDateTime(qdrq.Text.Trim()));
            if (wtf_xz.Text.Equals(""))
                dml.Add("@wtf", wtf.SelectedItem.Text.Trim());
            else
                dml.Add("@wtf", wtf_xz.Text.Trim());
            if (stf_xz.Text.Equals(""))
                dml.Add("@stf", stf.SelectedItem.Text.Trim());
            else
                dml.Add("@stf", stf_xz.Text.Trim());
            if (fmmc_xz.Text.Equals(""))
                dml.Add("@fmmc", fmmc.SelectedItem.Text.Trim());
            else
                dml.Add("@fmmc", fmmc_xz.Text.Trim());
            if (wlmc_xz.Text.Equals(""))
                dml.Add("@wlmc", wlmc.SelectedItem.Text.Trim());
            else
                dml.Add("@wlmc", wlmc.Text.Trim());
            dml.Add("@zxqxQ", Convert.ToDateTime(zxqxQ.Text));
            dml.Add("@zxqxZ", Convert.ToDateTime(zxqxZ.Text));
            if (zcz_xz.Text.Equals(""))
                dml.Add("@zcz", zcz.SelectedItem.Text.Trim());
            else
                dml.Add("@zcz", zcz_xz.Text.Trim());
            if (zdz_xz.Text.Equals(""))
                dml.Add("@zdz", zdz.SelectedItem.Text.Trim());
            else
                dml.Add("@zdz", zdz_xz.Text.Trim());
            dml.Add("@xlx", xlx.SelectedItem.Text.Trim());
            dml.Add("@sl", int.Parse(sl.Text.Trim()));


            if (_htglLogic.InsertTyht(dml))
            {
                AlertMessageAndGoTo("新增成功", "Tyht.aspx");
            }
        }

        protected void btnShengHe_Click(object sender, EventArgs e)
        {
            DirModel dml = new DirModel();
            dml.Add("@htbh", htbh.Text.Trim());
            if (_htglLogic.ShengHeOrder(dml, "xs_TyhtTable"))
            {
                // AlertMessage("审核订单成功");
                AlertMessageAndGoTo("审核成功", "TyhtGl.aspx");
            }
            else
            {
                AlertMessage("审核订单失败");
            }
        }

        protected void btnZhiXing_Click(object sender, EventArgs e)
        {
            DirModel dml = new DirModel();
            dml.Add("@htbh", htbh.Text.Trim());
            if (_htglLogic.ZhiXingOrder(dml, "xs_TyhtTable"))
            {
                // AlertMessage("审核订单成功");
                AlertMessageAndGoTo("执行成功", "TyhtGl.aspx");
            }
            else
            {
                AlertMessage("执行订单失败");
            }
        }

        protected void update_Click(object sender, EventArgs e)
        {
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;
            dml.Add("@htbh", htbh.Text.Trim());// ??????
            dml.Add("@userid", model.LoginUser);
            dml.Add("@htlx", htlx.SelectedItem.Text.Trim());
            dml.Add("@qdrq", Convert.ToDateTime(qdrq.Text.Trim()));//????
            dml.Add("@wtf", wtf.SelectedItem.Text.Trim());
            dml.Add("@stf", stf.SelectedItem.Text.Trim());
            dml.Add("@fmmc", fmmc.SelectedItem.Text.Trim());
            dml.Add("@wlmc", wlmc.SelectedItem.Text.Trim());
            dml.Add("@zxqxQ", Convert.ToDateTime(zxqxQ.Text));
            dml.Add("@zxqxZ", Convert.ToDateTime(zxqxZ.Text));
            dml.Add("@zcz", zcz.SelectedItem.Text.Trim());
            dml.Add("@zdz", zdz.SelectedItem.Text.Trim());
            dml.Add("@xlx", xlx.SelectedItem.Text.Trim());
            dml.Add("@sl", int.Parse(sl.Text.Trim()));
            if (_htglLogic.UpdateTyht(dml))
            {
                AlertMessageAndGoTo("修改成功", "TyhtGl.aspx");
            }
        }

        protected void AddJgxx(object sender, EventArgs e)
        {
            string shtbh = htbh.Text;
            Response.Write("<script>window.showModelessDialog('TyhtJgxx.aspx?transmissionInfo=" + shtbh + "')</script>");
        }

        protected void DelJgxx(object sender, EventArgs e)
        {
            string shtbh = htbh.Text;
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;
            dml.Add("@bh", (sender as Button).CommandArgument);
            dml.Add("@htbh", shtbh);
            dml.Add("@user_no", model.LoginUser);
            if (_htglLogic.DeleteChildTable(dml, "xs_TyhtTable_Jgxx"))
            {
                AlertMessage("订单删除成功");

            }
            else AlertMessage("订单删除失败");
        }


        protected void DropListInit()
        {
            PagerParameter pagepara = new PagerParameter();
            QueryClass qc = new QueryClass();
            pagepara.DbConn = GlabalString.DBString;
            //pagepara.XsPager=
            HTGLLogic ht = new HTGLLogic();
            string[] arrList = new string[6];
            arrList[0] = "wtf";
            arrList[1] = "stf";
            arrList[2] = "fmmc";
            arrList[3] = "wlmc";
            arrList[4] = "zcz";
            arrList[5] = "zdz";
            pagepara.Sql = ht.QueryDropList("xs_TyhtTable", arrList);
            pagepara.OrderBy = "wtf";
            PageChangedEventArgs e = new PageChangedEventArgs(1);
            DataTable dt = xsPageHelper.BindPager(pagepara, e);
            if (dt.Rows.Count != 0)
            {
                wtf.DataSource = dt.DefaultView;
                wtf.DataTextField = dt.Columns[0].ToString();
                wtf.DataBind();
                stf.DataSource = dt.DefaultView;
                stf.DataTextField = dt.Columns[1].ToString();
                stf.DataBind();
                fmmc.DataSource = dt.DefaultView;
                fmmc.DataTextField = dt.Columns[2].ToString();
                fmmc.DataBind();
                wlmc.DataSource = dt.DefaultView;
                wlmc.DataTextField = dt.Columns[3].ToString();
                wlmc.DataBind();
                zcz.DataSource = dt.DefaultView;
                zcz.DataTextField = dt.Columns[4].ToString();
                zcz.DataBind();
                zdz.DataSource = dt.DefaultView;
                zdz.DataTextField = dt.Columns[5].ToString();
                zdz.DataBind();
            }
            htbh.Text = "HTTY" + DateTime.Now.ToString("yyyyMMdd") + "-" + dt.Rows.Count;
        }
    }
}