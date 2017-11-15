using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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
}
