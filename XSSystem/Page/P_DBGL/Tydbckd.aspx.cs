using System;
using System.Collections.Generic;
using System.Data;
using xsFramework.Web.WebPage;
using xs_System.Logic;
using xsFramework.Web.Login;
using xsFramework.UserControl.Pager;
using XSSystem.Class;
using Telerik.Web.UI;
using System.Web.UI.WebControls;

namespace XSSystem.Page.P_Order
{
    public partial class Tydbckd : AuthWebPage
    {
        HTGLLogic _htglLogic = new HTGLLogic();
        static DataTable dataTable;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                DropListInit();
                if (Session["tydbckd"] != null)
                {
                    InitData(Session["tydbckd"]);
                }
                InitDataTable();
                InitGridView();
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
                    tk_fmmc.Items.Add(radcbItem);
                }
                tk_fmmc.SelectedIndex = 1;
            }

            dt = GlabalString.GetCangKu();
            if (dt.Rows.Count != 0)
            {
                foreach (DataRow val in dt.Rows)
                {
                    radcbItem = new RadComboBoxItem(val[0].ToString());
                    radcbItem2 = new RadComboBoxItem(val[0].ToString());
                    tk_zcz.Items.Add(radcbItem);
                    tk_zdz.Items.Add(radcbItem2);

                }
                tk_zcz.SelectedIndex = 1;
                tk_zdz.SelectedIndex = 1;
            }
        }

        private void InitDataTable()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("id", System.Type.GetType("System.Int32"));
            dataTable.Columns.Add("xh", System.Type.GetType("System.String"));
            dataTable.Columns.Add("sxds", System.Type.GetType("System.Double"));
            dataTable.Columns.Add("zxrq", System.Type.GetType("System.String"));
            dataTable.Columns.Add("fcrq", System.Type.GetType("System.String"));
            dataTable.Columns.Add("dcmj", System.Type.GetType("System.Double"));
            dataTable.Columns.Add("xhds", System.Type.GetType("System.Double"));

            dataTable.Columns.Add("dzrq", System.Type.GetType("System.String"));
            dataTable.Columns.Add("xhck", System.Type.GetType("System.String"));
            dataTable.Columns.Add("zbxsf", System.Type.GetType("System.Double"));
            dataTable.Columns.Add("fzdlf", System.Type.GetType("System.Double"));
            dataTable.Columns.Add("fzzxf", System.Type.GetType("System.Double"));

            dataTable.Columns.Add("fzddf", System.Type.GetType("System.Double"));
            dataTable.Columns.Add("tlyf", System.Type.GetType("System.Double"));
            dataTable.Columns.Add("dzzxf", System.Type.GetType("System.Double"));
            dataTable.Columns.Add("dzmcddf", System.Type.GetType("System.Double"));
            dataTable.Columns.Add("dzdlf", System.Type.GetType("System.Double"));
            dataTable.Columns.Add("drmj", System.Type.GetType("System.Double"));

        }

        void InitData(object mk)
        {
            DataTable dt = mk as DataTable;
            bh.Text = dt.Rows[0][1].ToString();
            htbh.Text = dt.Rows[0][2].ToString();
            tk_gsmc.Text = dt.Rows[0][3].ToString();
            tk_fmmc.Text = dt.Rows[0][4].ToString();

            wlmc.Text = dt.Rows[0][5].ToString();
            tk_zcz.Text = dt.Rows[0][6].ToString();
            tk_zdz.Text = dt.Rows[0][7].ToString();
            xlx.Text = dt.Rows[0][8].ToString();
            xhdw.Text = dt.Rows[0][9].ToString();
            Session.Remove("tydbckd");
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
                dml.Add("@htbh", htbh.Text.Trim());
                dml.Add("@gsmc", tk_gsmc.SelectedItem.Text.Trim());
                dml.Add("@fmmc", tk_fmmc.SelectedItem.Text.Trim());
                dml.Add("@wlmc", wlmc.Text.Trim());
                dml.Add("@zcz", tk_zcz.SelectedItem.Text.Trim());
                dml.Add("@zdz", tk_zdz.SelectedItem.Text.Trim());
                dml.Add("@xlx", xlx.Text.Trim());
                dml.Add("@xhdw", float.Parse(xhdw.Text.Trim()));
            }
            catch
            {
                AlertMessage("数据存在错误，请检查");
                return;
            }
            List<DirModel> Child1 = new List<DirModel>();
            DirModel temp;
            foreach(DataRow val in dataTable.Rows)
            {
                    temp = new DirModel();
                    temp.Add("@bh", bh.Text.Trim());
                    temp.Add("@user_no", model.LoginUser);
                    temp.Add("@xh", val[1]);
                    temp.Add("@sxds", val[2]);
                    temp.Add("@zxrq", val[3]);
                    temp.Add("@fcrq", val[4]);
                    temp.Add("@dcmj", val[5]);
                    temp.Add("@xhds", val[6]);
                    temp.Add("@dzrq", val[7]);
                    temp.Add("@xhck", val[8]);
                    temp.Add("@zbxsf", val[9]);
                    temp.Add("@fzdlf", val[10]);
                    temp.Add("@fzzxf", val[11]);
                    temp.Add("@fzddf", val[12]);
                    temp.Add("@tlyf", val[13]);
                    temp.Add("@dzzxf", val[14]);
                    temp.Add("@dzmcddf", val[15]);
                    temp.Add("@dzdlf", val[16]);
                    temp.Add("@drmj", val[17]);
                    Child1.Add(temp);
            }
            string reply = _htglLogic.InsertTydbckd(dml, Child1);
            if (reply=="")
            {
                AlertMessage("新增成功");
            }
            else
            {
                AlertMessage(string.Format("新增失败：{0}",reply));
            }
        }


        public void InitGridView()
        {
            dataTable.Clear();
            PagerParameter pagepara = new PagerParameter();
            pagepara.DbConn = GlabalString.DBString;
            QueryClass qc = new QueryClass();
            LoginModel model = Session["LoginModel"] as LoginModel;
            qc.user_no = model.LoginUser;
            qc.bh = bh.Text;
            qc.tableName = "xs_Tydbckd_Jzxxx";
            pagepara.Sql = _htglLogic.QueryThdbckdChildTable(qc);
            pagepara.OrderBy = "bh";
            var temp = xsPageHelper.BindPager(pagepara);
            foreach (DataRow val in temp.Rows)
            {
                DataRow dr = dataTable.NewRow();
                dr[0] = val[2];
                dr[1] = val[3];
                dr[2] = val[4];
                dr[3] = val[5];
                dr[4] = val[6];
                dr[5] = val[7];
                dr[6] = val[8];
                dr[7] = val[9];
                dr[8] = val[10];
                dr[9] = val[11];
                dr[10] = val[12];
                dr[11] = val[13];
                dr[12] = val[14];
                dr[13] = val[15];
                dr[14] = val[16];
                dr[15] = val[17];
                dr[16] = val[18];
                dr[17] = val[19];
                dataTable.Rows.Add(dr);

            }
            this.GridView1.DataSource = dataTable;
            this.GridView1.DataBind();
        }

        protected void AddJgxx(object sender, EventArgs e)
        {
            if (!DataChecked(2))
            {
                return;
            }
            DataRow dr = dataTable.NewRow();
            try
            {
                dr[1] = xh.Text;
                dr[2] = double.Parse(sxds.Text);
                dr[3] = zxrq.Text;
                dr[4] = fcrq.Text;
                dr[5] = double.Parse(dcmj.Text.Trim());
                dr[6] = double.Parse(xhds.Text.Trim());
                dr[7] = dzrq.Text;
                dr[8] = xhck.Text;
                dr[9] = double.Parse(zbxsf.Text.Trim());
                dr[10] = double.Parse(fzdlf.Text.Trim());
                dr[11] = double.Parse(fzzxf.Text.Trim());
                dr[12] = double.Parse(fzddf.Text.Trim());
                dr[13] = double.Parse(tlyf.Text.Trim());
                dr[14] = double.Parse(dzzxf.Text.Trim());
                dr[15] = double.Parse(dzmcddf.Text.Trim());
                dr[16] = double.Parse(dzdlf.Text.Trim());
                dr[17] = double.Parse(drmj.Text.Trim());
            }
            catch
            {
                AlertMessage("数据存在错误，请检查");
                return;
            }
            dataTable.Rows.Add(dr);
            GridView1.DataSource = dataTable;
            GridView1.DataBind();
        }

        

        protected void close_Click(object sender, EventArgs e)
        {
            JavaScript("window.location.href='TydbckdGl.aspx'");

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
                dml.Add("@htbh", htbh.Text.Trim());
                dml.Add("@gsmc", tk_gsmc.SelectedItem.Text.Trim());
                dml.Add("@fmmc", tk_fmmc.SelectedItem.Text.Trim());
                dml.Add("@wlmc", wlmc.Text.Trim());
                dml.Add("@zcz", tk_zcz.SelectedItem.Text.Trim());
                dml.Add("@zdz", tk_zdz.SelectedItem.Text.Trim());
                dml.Add("@xlx", xlx.Text.Trim());
                dml.Add("@xhdw", float.Parse(xhdw.Text.Trim()));
            }
            catch
            {
                AlertMessage("数据存在错误，请检查");
                return;
            }
            List<DirModel> Child1 = new List<DirModel>();
            DirModel temp;
            foreach (DataRow val in dataTable.Rows)
            {
               
                    temp = new DirModel();
                    temp.Add("@bh", bh.Text.Trim());
                    temp.Add("@user_no", model.LoginUser);
                    temp.Add("@xh", val[1]);
                    temp.Add("@sxds", val[2]);
                    temp.Add("@zxrq", val[3]);
                    temp.Add("@fcrq", val[4]);
                    temp.Add("@dcmj", val[5]);
                    temp.Add("@xhds", val[6]);
                    temp.Add("@dzrq", val[7]);
                    temp.Add("@xhck", val[8]);
                    temp.Add("@zbxsf", val[9]);
                    temp.Add("@fzdlf", val[10]);
                    temp.Add("@fzzxf", val[11]);
                    temp.Add("@fzddf", val[12]);
                    temp.Add("@tlyf", val[13]);
                    temp.Add("@dzzxf", val[14]);
                    temp.Add("@dzmcddf", val[15]);
                    temp.Add("@dzdlf", val[16]);
                    temp.Add("@drmj", val[17]);
                    Child1.Add(temp);
            }
            string reply = _htglLogic.UpdateTydbckd(dml, Child1);
            if (reply == "")
            {
                AlertMessage("修改成功");
            }
            else
            {
                AlertMessage(string.Format("修改失败：{0}", reply));
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!CalDataChecked(1))
            {
                return;
            }
            foreach (GridViewRow row in GridView1.Rows)
            {
                row.Cells[18].Text = ((Num(row.Cells[3].Text) * Num(row.Cells[6].Text) + Num(row.Cells[10].Text) / 2f + Num(row.Cells[11].Text) / 2f +
                Num(row.Cells[12].Text) * Num(row.Cells[3].Text) + Num(row.Cells[13].Text) * Num(row.Cells[3].Text) + Num(row.Cells[14].Text) / 2f +
                Num(row.Cells[15].Text) / 2f + Num(row.Cells[16].Text) / 2f + Num(row.Cells[17].Text) * Num(xhdw.Text)) / Num(xhdw.Text)).ToString();
            }
            //drmj.Text = ((Num(sxds.Text) * Num(dcmj.Text) + Num(zbxsf.Text) / 2f + Num(fzdlf.Text) / 2f +
            //    Num(fzzxf.Text) * Num(sxds.Text) + Num(fzddf.Text) * Num(sxds.Text) + Num(tlyf.Text) / 2f +
            //    Num(dzzxf.Text) / 2f + Num(dzmcddf.Text) / 2f + Num(dzdlf.Text) * Num(xhdw.Text)) / Num(xhdw.Text)).ToString();
            //GridView1.Rows[0].Cells[18].Text = "123";
        }

        protected void GridView1_RowEditing(object sender, System.Web.UI.WebControls.GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            //((TextBox)(GridView1.Rows[e.NewEditIndex].Cells[18].Controls[0])).Text = "123";
            InitGridView();
        }

        protected void GridView1_RowUpdating(object sender, System.Web.UI.WebControls.GridViewUpdateEventArgs e)
        {
            DirModel temp = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;
            temp.Add("@bh", bh.Text.Trim());
            temp.Add("@user_no", model.LoginUser);
            temp.Add("@id", GridView1.DataKeys[e.RowIndex].Value.ToString());
            temp.Add("@xh", ((TextBox)(GridView1.Rows[e.RowIndex].Cells[2].Controls[0])).Text.ToString().Trim());
            temp.Add("@sxds", ((TextBox)(GridView1.Rows[e.RowIndex].Cells[3].Controls[0])).Text.ToString().Trim());
            temp.Add("@zxrq", ((TextBox)(GridView1.Rows[e.RowIndex].Cells[4].Controls[0])).Text.ToString().Trim());
            temp.Add("@fcrq", ((TextBox)(GridView1.Rows[e.RowIndex].Cells[5].Controls[0])).Text.ToString().Trim());
            temp.Add("@dcmj", ((TextBox)(GridView1.Rows[e.RowIndex].Cells[6].Controls[0])).Text.ToString().Trim());
            temp.Add("@xhds", ((TextBox)(GridView1.Rows[e.RowIndex].Cells[7].Controls[0])).Text.ToString().Trim());
            temp.Add("@dzrq", ((TextBox)(GridView1.Rows[e.RowIndex].Cells[8].Controls[0])).Text.ToString().Trim());
            temp.Add("@xhck", ((TextBox)(GridView1.Rows[e.RowIndex].Cells[9].Controls[0])).Text.ToString().Trim());
            temp.Add("@zbxsf", ((TextBox)(GridView1.Rows[e.RowIndex].Cells[10].Controls[0])).Text.ToString().Trim());
            temp.Add("@fzdlf", ((TextBox)(GridView1.Rows[e.RowIndex].Cells[11].Controls[0])).Text.ToString().Trim());
            temp.Add("@fzzxf", ((TextBox)(GridView1.Rows[e.RowIndex].Cells[12].Controls[0])).Text.ToString().Trim());
            temp.Add("@fzddf", ((TextBox)(GridView1.Rows[e.RowIndex].Cells[13].Controls[0])).Text.ToString().Trim());
            temp.Add("@tlyf", ((TextBox)(GridView1.Rows[e.RowIndex].Cells[14].Controls[0])).Text.ToString().Trim());
            temp.Add("@dzzxf", ((TextBox)(GridView1.Rows[e.RowIndex].Cells[15].Controls[0])).Text.ToString().Trim());
            temp.Add("@dzmcddf", ((TextBox)(GridView1.Rows[e.RowIndex].Cells[16].Controls[0])).Text.ToString().Trim());
            temp.Add("@dzdlf", ((TextBox)(GridView1.Rows[e.RowIndex].Cells[17].Controls[0])).Text.ToString().Trim());
            temp.Add("@drmj", ((TextBox)(GridView1.Rows[e.RowIndex].Cells[18].Controls[0])).Text.ToString().Trim());
            bool reply = _htglLogic.UpdateTydbcdkJzxxx(temp);
            GridView1.EditIndex = -1;
            InitGridView();
            if (reply == false)
            {
                AlertMessage("更新失败");
            }
        }

        protected void GridView1_RowCancelingEdit(object sender, System.Web.UI.WebControls.GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            InitGridView();
        }

        protected void DelJgxx(object sender, EventArgs e)
        {
            int index = int.Parse((sender as Button).CommandArgument);
            dataTable.Rows.Remove(dataTable.Rows[index]);

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
            GridView1.DataSource = dataTable;
            GridView1.DataBind();
        }
    }
}