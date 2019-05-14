using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using xs_System.Logic;
using System.Web.UI.WebControls;
using xsFramework.Web.WebPage;
using xsFramework.Web.Login;

namespace XSSystem.Page.P_System
{
    public partial class InfomationInput : AuthWebPage
    {
        HTGLLogic _htglLogic = new HTGLLogic();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

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
    }
}