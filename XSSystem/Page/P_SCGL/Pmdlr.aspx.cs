﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;
using xs_System.Logic;
using xsFramework.UserControl.Pager;
using xsFramework.Web.Login;
using xsFramework.Web.WebPage;
using XSSystem.Class;
using XSSystem.Logic;

namespace XSSystem.Page.P_Order
{
    public partial class Pmdlr : AuthWebPage
    {
        CWGLLogic _cwglLogic = new CWGLLogic();
        static DataTable YLdataTable;
        static DataTable CPdataTable;
        protected void Page_Load(object sender, EventArgs e)
        {          
            if (!IsPostBack)
            {
                //       bh.Text = DateTime.Now.ToString("yyyyMMddHHmmss");
                DropListInit();
                if (Session["pmdlr"] != null)
                {
                    InitData(Session["pmdlr"]);
                }
                else
                {
                    bh.Text = DateTime.Now.ToString("yyyyMMddHHmmss");
                }
                InitDataTableYL();
                InitDataTableCP();
                InitGridView();
                InitGridView2();


            }
        }

        public void InitData(object mk)
        {
            DataTable dt = mk as DataTable;
            bh.Text = dt.Rows[0][1].ToString();
            pmrq.Text = dt.Rows[0][2].ToString();
            tk_scmc.Text = dt.Rows[0][3].ToString();
            tk_gsmc.Text = dt.Rows[0][4].ToString();
            Session.Remove("pmdlr");
        }

        public void InitGridView()
        {
            PagerParameter pagepara = new PagerParameter();
            pagepara.DbConn = GlabalString.DBString;
            QueryClass2 qc = new QueryClass2();
            LoginModel model = Session["LoginModel"] as LoginModel;
            qc.user_no = model.LoginUser;
            qc.bh = bh.Text;
            qc.tableName = "xs_PmdlrTable_Ylmz";
            pagepara.Sql = _cwglLogic.QueryChildTable(qc);
            pagepara.OrderBy = "bh";
            PageChangedEventArgs e = new PageChangedEventArgs(0);
            var temp = xsPageHelper.BindPager(pagepara, e);
            foreach (DataRow val in temp.Rows)
            {
                DataRow dr = YLdataTable.NewRow();
                dr[0] = val[2];
                dr[1] = val[3];
                dr[2] = val[4];
                dr[3] = val[5];
                dr[4] = val[6];
                YLdataTable.Rows.Add(dr);

            }
            this.GridView_YLMZ.DataSource = YLdataTable;
            this.GridView_YLMZ.DataBind();
        }

        public void InitGridView2()
        {
            PagerParameter pagepara = new PagerParameter();
            pagepara.DbConn = GlabalString.DBString;
            QueryClass2 qc = new QueryClass2();
            LoginModel model = Session["LoginModel"] as LoginModel;
            qc.user_no = model.LoginUser;
            qc.bh = bh.Text;
            qc.tableName = "xs_PmdlrTable_Ccmz";
            pagepara.Sql = _cwglLogic.QueryChildTable(qc);
            pagepara.OrderBy = "bh";
            PageChangedEventArgs e = new PageChangedEventArgs(0);
            var temp = xsPageHelper.BindPager(pagepara, e);
            foreach (DataRow val in temp.Rows)
            {
                DataRow dr = CPdataTable.NewRow();
                dr[0] = val[2];
                dr[1] = val[3];
                dr[2] = val[4];
                dr[3] = val[5];
                CPdataTable.Rows.Add(dr);

            }
            this.CPGridView.DataSource = CPdataTable;
            this.CPGridView.DataBind();
        }


        private void InitDataTableYL()
        {
            YLdataTable = new DataTable();
            YLdataTable.Columns.Add("yl", System.Type.GetType("System.String"));
            YLdataTable.Columns.Add("ylds", System.Type.GetType("System.Double"));
            YLdataTable.Columns.Add("cbdj", System.Type.GetType("System.Double"));
            YLdataTable.Columns.Add("pmf", System.Type.GetType("System.Double"));
            YLdataTable.Columns.Add("je", System.Type.GetType("System.Double"));


        }

        private void InitDataTableCP()
        {
            CPdataTable = new DataTable();
            CPdataTable.Columns.Add("cp", System.Type.GetType("System.String"));
            CPdataTable.Columns.Add("ccds", System.Type.GetType("System.Double"));
            CPdataTable.Columns.Add("je", System.Type.GetType("System.Double"));
            CPdataTable.Columns.Add("cbdj2", System.Type.GetType("System.Double"));
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            if (!DataChecked(1))
            {
                return;
            }
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;
            try
            {
                dml.Add("@user_no", model.LoginUser);
                dml.Add("@bh", bh.Text.Trim());
                dml.Add("@pmrq", Convert.ToDateTime(pmrq.Text.ToString()));
                dml.Add("@scmc", tk_scmc.Text.Trim());
                dml.Add("@gsmc", tk_gsmc.Text.Trim());
            }
            catch
            {
                AlertMessage("数据存在错误，请检查");
                return;
            }
            List<DirModel> Child1 = new List<DirModel>();
            DirModel temp;
            foreach (DataRow dr in YLdataTable.Rows)
            {
                
                    temp = new DirModel();
                    temp.Add("@user_no", model.LoginUser);
                    temp.Add("@bh", bh.Text);
                    temp.Add("@yl", dr[0]);
                    temp.Add("@ylds", dr[1]);
                    temp.Add("@cbdj", dr[2]);
                    temp.Add("@pmf", dr[3]);
                    temp.Add("@je", dr[4]);
                    Child1.Add(temp);
                    
            }
            List<DirModel> Child2 = new List<DirModel>();
            foreach (DataRow dr in CPdataTable.Rows)
            {
                
                    temp = new DirModel();
                    temp.Add("@user_no", model.LoginUser);
                    temp.Add("@bh", bh.Text);
                    temp.Add("@cp", dr[0]);
                    temp.Add("@ccds", dr[1]);
                    temp.Add("@je", dr[2]);
                    temp.Add("@cbdj2", dr[3]);
                    Child2.Add(temp);
            }
            string reply = _cwglLogic.InsertPmdlr(dml, Child1, Child2);
            if (reply=="")
            {
                AlertMessage("修改成功");
            }
            else
            {
                AlertMessage(reply);
            }

        }

        protected void DropListInit()
        {
            RadComboBoxItem radcbItem;
            RadComboBoxItem radcbItem2;
            DataTable dt = GlabalString.GetGongSi();
            if (dt.Rows.Count != 0)
            {

                foreach (DataRow val in dt.Rows)
                {
                    radcbItem = new RadComboBoxItem(val[0].ToString());
                    tk_gsmc.Items.Add(radcbItem);
                }
                tk_gsmc.SelectedIndex = 1;

            }

            dt = GlabalString.GetCangKu();
            if (dt.Rows.Count != 0)
            {
                foreach (DataRow val in dt.Rows)
                {
                    radcbItem = new RadComboBoxItem(val[0].ToString());
                    tk_scmc.Items.Add(radcbItem);
                }
                tk_scmc.SelectedIndex = 1;
            }

        }

        //private bool InsertTjje(DataRow dr)
        //{
        //    DirModel dml = new DirModel();
        //    LoginModel model = Session["LoginModel"] as LoginModel;

        //    dml.Add("@user_no", model.LoginUser);
        //    dml.Add("@bh", bh.Text);
        //    dml.Add("@yl", dr[0]);
        //    dml.Add("@ylds", dr[1]);
        //    dml.Add("@cbdj", dr[2]);
        //    dml.Add("@pmf", dr[3]);
        //    dml.Add("@je", dr[4]);
        //    return _cwglLogic.InsertPmdlr_Ylmz(dml);

        //}

        protected void ylmz_tjje_Click(object sender, EventArgs e)
        {
            DataRow dr = YLdataTable.NewRow();
            try
            {
                dr[0] = YLDropDownList.SelectedValue;
                dr[1] = double.Parse(ylds.Text.Trim());
                dr[2] = double.Parse(cbdj.Text.Trim());
                dr[3] = double.Parse(pmf.Text.Trim());
                dr[4] = double.Parse(je.Text.Trim());
            }
            catch
            {
                AlertMessage("数据存在错误，请检查");
                return;
            }
            YLdataTable.Rows.Add(dr);
            GridView_YLMZ.DataSource = YLdataTable;
            GridView_YLMZ.DataBind();
        }

        //private bool InsertCcmz(DataRow dr)
        //{
        //    DirModel dml = new DirModel();
        //    LoginModel model = Session["LoginModel"] as LoginModel;
        //    dml.Add("@user_no", model.LoginUser);
        //    dml.Add("@bh", bh.Text);
        //    dml.Add("@cp", dr[0]);
        //    dml.Add("@ccds", dr[1]);
        //    dml.Add("@je", dr[2]);
        //    dml.Add("@cbdj2", dr[3]);
        //    return _cwglLogic.InsertPmdlr_Ccmz(dml);
        //}

        protected void ccmz_tjje_Click(object sender, EventArgs e)
        {          
            DataRow dr = CPdataTable.NewRow();
            try
            {
                dr[0] = CPDropDownList.SelectedValue;
                dr[1] = double.Parse(ccds.Text.Trim());
                dr[2] = double.Parse(je2.Text.Trim());
                dr[3] = double.Parse(cbdj2.Text.Trim());
            }
            catch
            {
                AlertMessage("数据存在错误，请检查");
                return;
            }
            CPdataTable.Rows.Add(dr);
            CPGridView.DataSource = CPdataTable;
            CPGridView.DataBind();
        }

        protected void close_Click(object sender, EventArgs e)
        {
            JavaScript("window.location.href='PmdlrGl.aspx'");

        }

        protected void update_Click(object sender, EventArgs e)
        {
            if (!DataChecked(1))
            {
                return;
            }
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;
            try
            {
                dml.Add("@user_no", model.LoginUser);
                dml.Add("@bh", bh.Text.Trim());
                dml.Add("@pmrq", Convert.ToDateTime(pmrq.Text.ToString()));
                dml.Add("@scmc", tk_scmc.Text.Trim());
                dml.Add("@gsmc", tk_gsmc.Text.Trim());
            }
            catch
            {
                AlertMessage("数据存在错误，请检查");
                return;
            }
            List<DirModel> Child1 = new List<DirModel>();
            DirModel temp;
            foreach (DataRow dr in YLdataTable.Rows)
            {

                    temp = new DirModel();
                    temp.Add("@user_no", model.LoginUser);
                    temp.Add("@bh", bh.Text);
                    temp.Add("@yl", dr[0]);
                    temp.Add("@ylds", dr[1]);
                    temp.Add("@cbdj", dr[2]);
                    temp.Add("@pmf", dr[3]);
                    temp.Add("@je", dr[4]);
                    Child1.Add(temp);

            }
            List<DirModel> Child2 = new List<DirModel>();
            foreach (DataRow dr in CPdataTable.Rows)
            {

                    temp = new DirModel();
                    temp.Add("@user_no", model.LoginUser);
                    temp.Add("@bh", bh.Text);
                    temp.Add("@cp", dr[0]);
                    temp.Add("@ccds", dr[1]);
                    temp.Add("@je", dr[2]);
                    temp.Add("@cbdj2", dr[3]);
                    Child2.Add(temp);
            }
            string reply = _cwglLogic.UpdatePmdlr(dml, Child1, Child2);
            if (reply == "")
            {
                AlertMessage("修改成功");
            }
            else
            {
                AlertMessage(reply);
            }
        }

        protected void DelJgxx(object sender, EventArgs e)
        {
            int index = int.Parse((sender as Button).CommandArgument);
            YLdataTable.Rows.Remove(YLdataTable.Rows[index]);

            //for (int i = 0; i < dataTable.Rows.Count; i++)
            //{
            //    if (dataTable.Rows[i][0].ToString().Equals(id))
            //    {
            //        dataTable.Rows.Remove(dataTable.Rows[i]);
            //        break;
            //    }
            //    else
            //    {
            //        continue;
            //    }
            //}
            GridView_YLMZ.DataSource = YLdataTable;
            GridView_YLMZ.DataBind();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int index = int.Parse((sender as Button).CommandArgument);
            CPdataTable.Rows.Remove(CPdataTable.Rows[index]);

            //for (int i = 0; i < dataTable.Rows.Count; i++)
            //{
            //    if (dataTable.Rows[i][0].ToString().Equals(id))
            //    {
            //        dataTable.Rows.Remove(dataTable.Rows[i]);
            //        break;
            //    }
            //    else
            //    {
            //        continue;
            //    }
            //}
            CPGridView.DataSource = CPdataTable;
            CPGridView.DataBind();
        }
    }
}