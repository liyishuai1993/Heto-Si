using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using xs_System.Logic;
using xsFramework.Function.Thumbnail;
using xsFramework.Web.WebPage;
using System.Data;
using xsFramework.Web.Login;
using System.Globalization;

namespace XSSystem.Page.P_Order
{
    public partial class Cght : AuthWebPage
    {
        HTGLLogic _htglLogic = new HTGLLogic();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InitGridView();
                InitGridView2();
            }

            
        }

        static DataTable dtzlbz = new DataTable();
        public void InitGridView() 
        {

            if (dtzlbz.Columns.Count == 0)
            {
                dtzlbz.Columns.Add("xh");
                dtzlbz.Columns.Add("mz");
                dtzlbz.Columns.Add("ld");
                dtzlbz.Columns.Add("hf");
                dtzlbz.Columns.Add("hff");
                dtzlbz.Columns.Add("gdt");
                dtzlbz.Columns.Add("njzs");
                dtzlbz.Columns.Add("sf");
                dtzlbz.Columns.Add("tie");
                dtzlbz.Columns.Add("lv");
                dtzlbz.Columns.Add("gai");
                dtzlbz.Columns.Add("lin");
                dtzlbz.Columns.Add("tai");
                dtzlbz.Columns.Add("liu");
            }


            dtzlbz.Rows.Add(dtzlbz.NewRow());
            this.GridView_ZLBZ.DataSource = dtzlbz;
            this.GridView_ZLBZ.DataBind();



        }

        static DataTable dtjgxx = new DataTable();
        public void InitGridView2()
        {
            if (dtjgxx.Columns.Count == 0)
            {

                dtjgxx.Columns.Add("xh");
                dtjgxx.Columns.Add("mkmc");
                dtjgxx.Columns.Add("mzmc");
                dtjgxx.Columns.Add("frl");
                dtjgxx.Columns.Add("lf");
                dtjgxx.Columns.Add("kpmj");
                dtjgxx.Columns.Add("htmj");
                dtjgxx.Columns.Add("ksl");
                dtjgxx.Columns.Add("qdds");
                dtjgxx.Columns.Add("qdje");
                dtjgxx.Columns.Add("zt");
                dtjgxx.Columns.Add("cz");
            }


            dtjgxx.Rows.Add(dtjgxx.NewRow());
            this.GridView_JGXX.DataSource = dtjgxx;
            this.GridView_JGXX.DataBind();



        }

        Random ran = new Random();
        protected void submit_Click(object sender, EventArgs e)
        {
            DirModel dml = new DirModel();
            LoginModel model = Session["LoginModel"] as LoginModel;
            dml.Add("@htbh", ran.Next(0, 100000).ToString());// ??????
            dml.Add("@userid", model.LoginUser);
            dml.Add("@htlx", htlx.SelectedItem.Text.Trim());
            dml.Add("@qdrq", Convert.ToDateTime(qdrq.Text.Trim()));//????
            dml.Add("@dfhth", dfhth.Text.Trim());
            dml.Add("@gfmc",gfmc.Text.Trim());
            dml.Add("@xfmc", xfmc.Text.Trim());
            dml.Add("@hkjsyj", hkjsyj.SelectedItem.Text.Trim());
            dml.Add("@hklhlx", hklhlx.SelectedItem.Text.Trim());
            dml.Add("@hklhbz", hklhbz.Text.Trim());
            dml.Add("@kpxx", kpxx.SelectedItem.Text.Trim());
            dml.Add("@jhsjQ", Convert.ToDateTime(jhsjQ.Text));
            dml.Add("@jhsjZ", Convert.ToDateTime(jhsjZ.Text));
            dml.Add("@hkjsfs", hkjsfs.SelectedItem.Text.Trim());
            dml.Add("@jhdd", jhdd.Text.Trim());
            dml.Add("@yffkfs", yffkfs.SelectedItem.Text.Trim());
            dml.Add("@mkmc", mkmc.Text.Trim());
            dml.Add("@bz", bz.Text.Trim());


            if (_htglLogic.InsertCght(dml))
            {
                  AlertMessageAndGoTo("新增成功", "Cght.aspx");
                AlertMessage("新增成功");
              //  xsPage.RefreshPage();
            }
            //dml.Add("@dzdje", StrToFloat(dzdje.Text.Trim()));
            //dml.Add("@skje", StrToFloat(skje.Text.Trim()));
            //dml.Add("@kpje", StrToFloat(kpje.Text.Trim()));
            //dml.Add("@gsjy", StrToFloat(gsjy.Text.Trim()));
            //dml.Add("@kphsksj", Convert.ToDateTime(kphsksj.Text));
        }

        int rownum = 0;
        DataRow r;
        protected void Button2_Click(object sender, EventArgs e)
        {
            r = dtjgxx.NewRow();
            for (int i = 0; i < 12; i++)
                r[i] = "text";
            dtjgxx.Rows.Add(r);
            //r = dtjgxx.NewRow();
            //for (int i = 0; i < 12; i++)
            //    r[i] = "text2";
            //dtjgxx.Rows.Add(r);
            // rownum++;
            GridView_JGXX.DataSource = dtjgxx;
            GridView_JGXX.DataBind();
        }
    }
}