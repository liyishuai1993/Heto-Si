using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using xsFramework.SqlServer;
using xsFramework.Web.WebPage;
using XSSystem.Class;

namespace XSSystem.Logic
{
    public class CWGLLogic
    {
        internal bool InsertFkd(DirModel dml)
        {
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into xs_FkdTable (user_no,bh,ldrq,skdw,jsr,bm,htbh,zy,fjsm,yfye)" +
                "values(@user_no,@bh,@ldrq,@skdw,@jsr,@bm,@htbh,@zy,@fjsm,@yfye)";
            try
            {
                SqlHelper.Execute(sqlpara);
            }
            catch
            {
                return false;
            }
            
            return true;
        }

        internal bool InsertFyd(DirModel dml)
        {
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into xs_FydTable (user_no,bh,ldrq,sfdw,jsr,bm,zy,fjsm)" +
                "values(@user_no,@bh,@ldrq,@sfdw,@jsr,@bm,@zy,@fjsm)";
            try
            {
                SqlHelper.Execute(sqlpara);
            }
            catch
            {
                return false;
            }

            return true;
        }

        internal bool InsertRsclr(DirModel dml)
        {
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into xs_RsclrTable (user_no,ssmc,rq,kjsj,gjsj,bc,ydzs,yddh,ymzs,gsmc)" +
                "values(@user_no,@ssmc,@rq,@kjsj,@gjsj,@bc,@ydzs,@yddh,@ymzs,@gsmc)";
            try
            {
                SqlHelper.Execute(sqlpara);
            }
            catch
            {
                return false;
            }

            return true;
        }

        internal bool InsertRsclr_Scxx(DirModel dml)
        {
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into xs_RsclrTable_Scxx (user_no,bh,sl,je,klcl,hhmcl,mmcl,zmcl,nmcl,gscl,shl)" +
                "values(@user_no,@bh,@sl,@je,@klcl,@hhmcl,@mmcl,@zmcl,@nmcl,@gscl,@shl)";
            try
            {
                SqlHelper.Execute(sqlpara);
            }
            catch
            {
                return false;
            }

            return true;
        }

        internal bool InsertRsclr_Ccxx(DirModel dml)
        {
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into xs_RsclrTable_Ccxx (user_no,bh,sl,je,cl)" +
                "values(@user_no,@bh,@sl,@je,@cl)";
            try
            {
                SqlHelper.Execute(sqlpara);
            }
            catch
            {
                return false;
            }

            return true;
        }

        internal string QueryJxfpqsdOrder(QueryClass2 qc)
        {
            string sql = @"select * from JxfpqsdTbale";

            return sql;
        }

        internal string QueryXxfpyjdOrder(QueryClass2 qc)
        {
            string sql = @"select * from XxfpyjdTbale";

            return sql;
        }

        internal string QuerySkdOrder(QueryClass2 qc)
        {
            string sql = @"select * from xs_SkdTable";

            return sql;
        }

        internal string QueryFydOrder(QueryClass2 qc)
        {
            string sql = @"select * from xs_FydTable";

            return sql;
        }

        internal string QueryFkdOrder(QueryClass2 qc)
        {
            string sql = @"select * from xs_FkdTable";

            return sql;
        }

        internal string QueryXshydlrOrder(QueryClass2 qc)
        {
            string sql = @"select * from XshydlrTbale";

            return sql;
        }

        internal string QuerycghydlrOrder(QueryClass2 qc)
        {
            string sql = @"select * from cghydlrTbale";

            return sql;
        }

        internal string QueryRsclrOrder(QueryClass2 qc)
        {
            string sql = @"select * from xs_RsclrTable";

            return sql;
        }

        internal string QueryPmdlrOrder(QueryClass2 qc)
        {
            string sql = @"select * from xs_PmdlrTable";
                
            return sql;
        }

        internal bool InsertPmdlr(DirModel dml)
        {
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into xs_PmdlrTable (user_no,pmbh,pmrq,scmc,gsmc)" +
                "values(@user_no,@pmbh,@pmrq,@scmc,@gsmc)";
            try
            {
                SqlHelper.Execute(sqlpara);
            }
            catch
            {
                return false;
            }

            return true;
        }

        internal bool InsertPmdlr_Ylmz(DirModel dml)
        {
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into xs_PmdlrTable_Ylmz (user_no,bh,ylds,cbdj,pmf,je)" +
                "values(@user_no,@bh,@ylds,@cbdj,@pmf,@je)";
            try
            {
                SqlHelper.Execute(sqlpara);
            }
            catch
            {
                return false;
            }

            return true;
        }

        internal bool InsertPmdlr_Ccmz(DirModel dml)
        {
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into xs_PmdlrTable_Ccmz (user_no,bh,cp,ccds,je,cbdj2)" +
                "values(@user_no,@bh,@cp,@ccds,@je,@cbdj2)";
            try
            {
                SqlHelper.Execute(sqlpara);
            }
            catch
            {
                return false;
            }

            return true;
        }

        internal bool InsertXshydlr(DirModel dml)
        {
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into XshydlrTbale (user_no,hydbh,hyrq,kh,mcmc,wlmc,cyr,hyr)" +
                "values(@user_no,@hydbh,@hyrq,@kh,@mcmc,@wlmc,@cyr,@hyr)";
            try
            {
                SqlHelper.Execute(sqlpara);
            }
            catch
            {
                return false;
            }

            return true;
        }

        internal bool InsertCghydlr(DirModel dml)
        {
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into cghydlrTbale (user_no,hydbh,hyrq,gys,mcmc,wlmc,cyr,hyr)" +
                "values(@user_no,@hydbh,@hyrq,@gys,@mcmc,@wlmc,@cyr,@hyr)";
            try
            {
                SqlHelper.Execute(sqlpara);
            }
            catch
            {
                return false;
            }

            return true;
        }

        internal bool InsertSkd(DirModel dml)
        {
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into xs_SkdTable (user_no,bh,ldrq,fkdw,jsr,bm,htbh,zy,fjsm,ysye,yfye)" +
                "values(@user_no,@bh,@ldrq,@fkdw,@jsr,@bm,@htbh,@zy,@fjsm,@ysye,@yfye)";
            try
            {
                SqlHelper.Execute(sqlpara);
            }
            catch
            {
                return false;
            }

            return true;
        }

        internal bool InsertJxfpqsd(DirModel dml)
        {
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into JxfpqsdTbale (user_no,dh,ldrq,hth,gfmc,xfmc,kprq,ph,pm,shuliang,dj_hs,je,sl,se,sjhj,yhs,hyhshj,bz)" +
                "values(@user_no,@dh,@ldrq,@hth,@gfmc,@xfmc,@kprq,@ph,@pm,@shuliang,@dj_hs,@je,@sl,@se,@sjhj,@yhs,@hyhshj,@bz)";
            try
            {
                SqlHelper.Execute(sqlpara);
            }
            catch
            {
                return false;
            }

            return true;
        }

        internal bool InsertXsfpyjd(DirModel dml)
        {
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into XxfpyjdTbale (user_no,dh,ldrq,hth,gfmc,xfmc,kprq,ph,pm,shuliang,dj_hs,je,sl,se,sjhj,yhs,kddh,bz,sqzt)" +
                "values(@user_no,@dh,@ldrq,@hth,@gfmc,@xfmc,@kprq,@ph,@pm,@shuliang,@dj_hs,@je,@sl,@se,@sjhj,@yhs,@kddh,@bz,@sqzt)";
            try
            {
                SqlHelper.Execute(sqlpara);
            }
            catch
            {
                return false;
            }

            return true;
        }
    }
}