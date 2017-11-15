using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using xsFramework.Web.WebPage;
using xsFramework.SqlServer;

namespace xs_System.Logic
{
    public class OrderLogic
    {
        public bool InsertOrder(DirModel dml) 
        {
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into xs_order(oid,userid,ch,fkck,pm,fhrq,ckzz,ckmz,jb,ckdjz,ckjz2,dhrq,shdw,dhdw,jsds,dj,gsje,dzdje,skje,kpje,gsjy,kphsksj)"+
               "values(@oid,@userid,@ch,@fkck,@pm,@fhrq,@ckzz,@ckmz,@jb,@ckdjz,@ckjz2,@dhrq,@shdw,@dhdw,@jsds,@dj,@gsje,@dzdje,@skje,@kpje,@gsjy,@kphsksj)";
            SqlHelper.Execute(sqlpara);
            return true;
        }
        /// <summary>
        /// 查询订单
        /// </summary>
        /// <returns></returns>
        public string QueryOrder(string strType,string strName)
        {
            string sql = @"select * from xs_order where 1=1";
            if(!string.IsNullOrEmpty(strName))sql+= " and oid='"+strName +"'";
            return sql;
        }

        /// <summary>
        /// 删除订单
        /// </summary>
        /// <param name="dml"></param>
        /// <returns></returns>
        public bool DeleteUser(DirModel dml)
        {
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = @"delete from [xs_order ]where [oid]=@oid";
            SqlHelper.Execute(sqlpara);
            return true;
        }

    }
}