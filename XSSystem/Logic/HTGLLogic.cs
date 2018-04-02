using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using xsFramework.Web.WebPage;
using xsFramework.SqlServer;
using XSSystem.Class;
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

        public bool InsertCghtJgxx(DirModel dml)
        {
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into xs_CghtTable_Jgxx (user_no,htbh,mkmc,mzmc,frl,lf,kpmj,htmj,ksl,qdds,qdje)" +
                "values(@user_no,@htbh,@mkmc,@mzmc,@frl,@lf,@kpmj,@htmj,@ksl,@qdds,@qdje)";
            SqlHelper.Execute(sqlpara);
            return true;
        }

        public bool InsertCghtZlbz(DirModel dml)
        {
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into xs_CghtTable_Zlbz (user_no,htbh,mz,ld,hf,hff,gdt,njzs,sf,tie,lv,gai,lin,tai,liu)" +
                "values(@user_no,@htbh,@mz,@ld,@hf,@hff,@gdt,@njzs,@sf,@tie,@lv,@gai,@lin,@tai,@liu)";
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

        public bool InsertQyhtJgxx(DirModel dml)
        {
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into xs_QyhtTable_Jgxx (user_no,htbh,wlmc,qyd,mdd,yj,yhlhbz,bz)" +
                "values(@user_no,@htbh,@wlmc,@qyd,@mdd,@yj,@yhlhbz,@bz)";
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

        public bool InsertTyhtJgxx(DirModel dml)
        {
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into xs_TyhtTable_Jgxx (user_no,htbh,gsmc,dfhth,kplx,zbxsf,dlf,zxf,sfzdd,tlyf,dzzxf,dzmcddf,dzdlf)" +
                "values(@user_no,@htbh,@gsmc,@dfhth,@kplx,@zbxsf,@dlf,@zxf,@sfzdd,@tlyf,@dzzxf,@dzmcddf,@dzdlf)";
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


        #region  Update
        public bool UpdateCght(DirModel dml)
        {
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "update xs_CghtTable set htlx=@htlx,qdrq=@qdrq,dfhth=@dfhth,gfmc=@gfmc,xfmc=@xfmc,hkjsyj=@hkjsyj,hklhlx=@hklhlx,hklhbz=@hklhbz,kpxx=@kpxx,jhsjQ=@jhsjQ,jhsjZ=@jhsjZ,hkjsfs=@hkjsfs,"+
                "jhdd=@jhdd,yffkfs=@yffkfs,mkmc=@mkmc,bz=@bz where htbh=@htbh and user_no=@userid";
            SqlHelper.Execute(sqlpara);
            return true;
        }

        public bool UpdateQyht(DirModel dml)
        {
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "update xs_QyhtTable set htlx=@htlx,qdrq=@qdrq,dfhth=@dfhth,wtf=@wtf,stf=@stf,kplx=@kplx,zxqxQ=@zxqxQ,zxqxZ=@zxqxZ where htbh=@htbh and user_no=@userid";
            SqlHelper.Execute(sqlpara);
            return true;
        }

        public bool UpdateTyht(DirModel dml)
        {
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "update xs_TyhtTable set htlx=@htlx,qdrq=@qdrq,wtf=@wtf,stf=@stf,fmmc=@fmmc,wlmc=@wlmc,zxqxQ=@zxqxQ,zxqxZ=@zxqxZ,zcz=@zcz,zdz=@zdz,xlx=@xlx,sl=@sl where htbh=@htbh and user_no=@userid";
            SqlHelper.Execute(sqlpara);
            return true;
        }

        public bool UpdateWtjghtht(DirModel dml)
        {
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "update xs_WtjgTable set htlx=@htlx,qdrq=@qdrq,wtf=@wtf,stf=@stf,kplx=@kplx,zxqxQ=@zxqxQ,zxqxZ=@zxqxZ where htbh=@htbh and user_no=@userid";
            SqlHelper.Execute(sqlpara);
            return true;
        }

        public bool UpdateXsht(DirModel dml)
        {
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "update xs_XshtTable set htlx=@htlx,qdrq=@qdrq,dfhth=@dfhth,gfmc=@gfmc,xfmc=@xfmc,hkjsyj=@hkjsyj,hklhlx=@hklhlx,hklhbz=@hklhbz,kpxx=@kpxx,jhsjQ=@jhsjQ,jhsjZ=@jhsjZ,"+
                "hkjsfs=@hkjsfs,fhdd=@fhdd,yffkfs=@yffkfs,mkmc=@mkmc,kzbz=@kzbz,lxdh=@lxdh,bz=@bz where htbh=@htbh and user_no=@userid";
            SqlHelper.Execute(sqlpara);
            return true;
        }

        public bool UpdateZlht(DirModel dml)
        {
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "update xs_ZlhtTable set htlx=@htlx,qdrq=@qdrq,czf=@czf,czf2=@czf2,czdd=@czdd,zlqxQ=@zlqxQ,zlqxZ=@zlqxZ,yj=@yj where htbh=@htbh and user_no=@userid";
            SqlHelper.Execute(sqlpara);
            return true;
        }


        #endregion


        public string QueryDropList(string tableName, string[] arrList)
        {
            string sql = @"select ";
            for (int i = 0; i < arrList.Length-1; i++)
            {
                sql += arrList[i] + " , ";
            }
            sql+= arrList[arrList.Length-1] + " from " + tableName;
            return sql;
        }

        /// <summary>
        /// 查询订单
        /// </summary>
        /// <returns></returns>
        public string QueryOrder(string strType,string strName,string tablename)
        {
            string sql = @"select * from "+ tablename +" where 1=1";
            if (!string.IsNullOrEmpty(strType)) sql += " and htlx='" + strType + "'";
            if (!string.IsNullOrEmpty(strName))sql+= " and htbh='"+strName +"'";
            if (!string.IsNullOrEmpty(strName)) sql += " and htbh='" + strName + "'";
            return sql;
        }

        public string QueryOrder(QueryClass qc)
        {
            string sql = @"select * from " + qc.tableName + " where 1=1";
            if (!string.IsNullOrEmpty(qc.htlx)) sql += " and htlx='" + qc.htlx + "'";
            if (!string.IsNullOrEmpty(qc.shzt)) sql += " and shzt='" + qc.shzt + "'";
            if (!string.IsNullOrEmpty(qc.cxrqQ)) sql += " and qdrq>='" + Convert.ToDateTime(qc.cxrqQ) + "'";
            if (!string.IsNullOrEmpty(qc.cxrqZ)) sql += " and qdrq<='" + Convert.ToDateTime(qc.cxrqZ) + "'";
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

        public bool ShengHeOrder(DirModel dml, string tablename)
        {
            xsSqlParameter sql = new xsSqlParameter();
            sql.AddSqlParameter(dml);
            sql.SqlConnectString = GlabalString.DBString;
            sql.SQL = "update " + tablename + " set shzt='已审核' where htbh=@htbh";
            SqlHelper.Execute(sql);
            return true;
        }

    }
}