using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using xs_System.Logic;
using xsFramework.UserControl.Pager;

public class GlabalString
{
    private static string dbString = System.Configuration.ConfigurationManager.ConnectionStrings["DbCon"].ConnectionString;
    public static string ProductPicPath = "/Resource/Products/pic/";
    /// <summary>
    /// 数据库连接
    /// </summary>
    public static string DBString
    {
        get
        {
            return dbString;
        }
    }

    public static float StrToFloat(object FloatString)
    {
        float result;
        if (FloatString != null)
        {
            if (float.TryParse(FloatString.ToString(), out result))
                return result;
            else
            {
                return (float)0.000;
            }
        }
        else
        {
            return (float)0.000;
        }
    }

    /// <summary>
    /// 获取煤种名称
    /// </summary>
    /// <returns></returns>
    public static DataTable GetMZMC()
    {
        PagerParameter pagepara = new PagerParameter();
        pagepara.DbConn = GlabalString.DBString;
        //pagepara.XsPager=
        HTGLLogic ht = new HTGLLogic();
        string[] arrList = new string[1];
        arrList[0] = "mzmc";
        pagepara.Sql = ht.QueryDropList("xs_MeiZhongTable", arrList);
        pagepara.OrderBy = "mzmc";
        DataTable dt = xsPageHelper.BindPager(pagepara);
        return dt;
    }

    /// <summary>
    /// 获取账户
    /// </summary>
    /// <returns></returns>
    public static DataTable GetZH()
    {
        PagerParameter pagepara = new PagerParameter();
        pagepara.DbConn = GlabalString.DBString;
        //pagepara.XsPager=
        HTGLLogic ht = new HTGLLogic();
        string[] arrList = new string[1];
        arrList[0] = "zh";
        pagepara.Sql = ht.QueryDropList("xs_ZhangHu", arrList);
        pagepara.OrderBy = "zh";
        DataTable dt = xsPageHelper.BindPager(pagepara);
        return dt;
    }

    /// <summary>
    /// 获取煤场
    /// </summary>
    /// <returns></returns>
    public static DataTable GetMeiCang()
    {
        PagerParameter pagepara = new PagerParameter();
        pagepara.DbConn = GlabalString.DBString;
        //pagepara.XsPager=
        HTGLLogic ht = new HTGLLogic();
        string[] arrList = new string[1];
        arrList[0] = "cp";
        pagepara.Sql = ht.QueryDropList("xs_ChanPingTable", arrList);
        pagepara.OrderBy = "cp";
        DataTable dt = xsPageHelper.BindPager(pagepara);
        return dt;
    }

    /// <summary>
    /// 获取仓库
    /// </summary>
    /// <returns></returns>
    public static DataTable GetCangKu()
    {
        PagerParameter pagepara = new PagerParameter();
        pagepara.DbConn = GlabalString.DBString;
        //pagepara.XsPager=
        HTGLLogic ht = new HTGLLogic();
        string[] arrList = new string[1];
        arrList[0] = "yl";
        pagepara.Sql = ht.QueryDropList("xs_YuanLiaoTable", arrList);
        pagepara.OrderBy = "yl";
        DataTable dt = xsPageHelper.BindPager(pagepara);
        return dt;
    }

    /// <summary>
    /// 获取公司
    /// </summary>
    /// <returns></returns>
    public static DataTable GetGongSi()
    {
        PagerParameter pagepara = new PagerParameter();
        pagepara.DbConn = GlabalString.DBString;
        //pagepara.XsPager=
        HTGLLogic ht = new HTGLLogic();
        string[] arrList = new string[2];
        arrList[0] = "wldw";
        arrList[1] = "type";
        pagepara.Sql = ht.QueryDropList("xs_WangLaiDanWei", arrList);
        pagepara.OrderBy = "wldw";
        DataTable dt = xsPageHelper.BindPager(pagepara);
        return dt;
    }

    /// <summary>
    /// 获取员工
    /// </summary>
    /// <returns></returns>
    public static DataTable GetYuanGong()
    {
        PagerParameter pagepara = new PagerParameter();
        pagepara.DbConn = GlabalString.DBString;
        //pagepara.XsPager=
        HTGLLogic ht = new HTGLLogic();
        string[] arrList = new string[1];
        arrList[0] = "yg";
        pagepara.Sql = ht.QueryDropList("xs_YuanGong", arrList);
        pagepara.OrderBy = "yg";
        DataTable dt = xsPageHelper.BindPager(pagepara);
        return dt;
    }
}
