using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using xsFramework.Web.WebPage;
using xsFramework.SqlServer;

namespace xs_System.Logic
{
    public class HTGLLogic
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dml"></param>
        /// <returns></returns>
        public bool InsertCght(DirModel dml)
        {
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into xs_CghtTable (user_no,htbh,htlx,qdrq,dfhth,gfmc,xfmc,hkjsyj,hklhlx,hklhbz,kpxx,jhsjQ,jhsjZ,hkjsfs,jhdd,yffkfs,mkmc,bz)"+
                "values(@userid,@htbh,@htlx,@qdrq,@dfhth,@gfmc,@xfmc,@hkjsyj,@hklhlx,@hklhbz,@kpxx,@jhsjQ,@jhsjZ,@hkjsfs,@jhdd,@yffkfs,@mkmc,@bz)";
            SqlHelper.Execute(sqlpara);
            return true;
        }

        public bool InsertXsht(DirModel dml)
        {
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into xs_XshtTable (user_no,htbh,htlx,qdrq,dfhth,gfmc,xfmc,hkjsyj,hklhlx,hklhbz,kpxx,jhsjQ,jhsjZ,hkjsfs,fhdd,yffkfs,mkmc,kzbz,lxdh,bz)" +
                "values(@userid,@htbh,@htlx,@qdrq,@dfhth,@gfmc,@xfmc,@hkjsyj,@hklhlx,@hklhbz,@kpxx,@jhsjQ,@jhsjZ,@hkjsfs,@fhdd,@yffkfs,@mkmc,@kzbz,@lxdh,@bz)";
            SqlHelper.Execute(sqlpara);
            return true;
        }

        public bool InsertQyht(DirModel dml)
        {
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into xs_QyhtTable (user_no,htbh,htlx,qdrq,dfhth,wtf,stf,kplx,zxqxQ,zxqxZ)" +
                "values(@userid,@htbh,@htlx,@qdrq,@dfhth,@wtf,@stf,@kplx,@zxqxQ,@zxqxZ)";
            SqlHelper.Execute(sqlpara);
            return true;
        }

        public bool InsertTyht(DirModel dml)
        {
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into xs_TyhtTable (user_no,htbh,htlx,qdrq,wtf,stf,fmmc,wlmc,zxqxQ,zxqxZ,zcz,zdz,xlx,sl)" +
                "values(@userid,@htbh,@htlx,@qdrq,@wtf,@stf,@fmmc,@wlmc,@zxqxQ,@zxqxZ,@zcz,@zdz,@xlx,@sl)";
            SqlHelper.Execute(sqlpara);
            return true;
        }

        public bool InsertWtjght(DirModel dml)
        {
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into xs_WtjgTable (user_no,htbh,htlx,qdrq,wtf,stf,kplx,zxqxQ,zxqxZ)" +
                "values(@userid,@htbh,@htlx,@qdrq,@wtf,@stf,@kplx,@zxqxQ,@zxqxZ)";
            SqlHelper.Execute(sqlpara);
            return true;
        }

        public bool InsertZlht(DirModel dml)
        {
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into xs_ZlhtTable (user_no,htbh,htlx,qdrq,czf,czf2,czdd,zlqxQ,zlqxZ,yj)" +
                "values(@userid,@htbh,@htlx,@qdrq,@czf,@czf2,@czdd,@zlqxQ,@zlqxZ,@yj)";
            SqlHelper.Execute(sqlpara);
            return true;
        }



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
        public string QueryOrder(string strType,string strName,string tablename)
        {
            string sql = @"select * from "+ tablename +" where 1=1";
            if(!string.IsNullOrEmpty(strName))sql+= " and htbh='"+strName +"'";
            return sql;
        }

        /// <summary>
        /// 删除订单
        /// </summary>
        /// <param name="dml"></param>
        /// <returns></returns>
        public bool DeleteUser(DirModel dml,string tablename)
        {
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = @"delete from ["+tablename +"]where [htbh]=@htbh";
            SqlHelper.Execute(sqlpara);
            return true;
        }

    }
}