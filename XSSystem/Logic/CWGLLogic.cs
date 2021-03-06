﻿using System;
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
        internal string InsertFkd(DirModel dml,List<DirModel>child1)
        {
            List<xsSqlParameter> xsSqls = new List<xsSqlParameter>();
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into xs_FkdTable (user_no,bh,ldrq,skdw,jsr,bm,htbh,zy,fjsm,jsfs,yhje,hjje)" +
                "values(@user_no,@bh,@ldrq,@skdw,@jsr,@bm,@htbh,@zy,@fjsm,@jsfs,@yhje,@hjje)";
            xsSqls.Add(sqlpara);
            foreach(var val in child1)
            {
                sqlpara = new xsSqlParameter();
                sqlpara.AddSqlParameter(val);
                sqlpara.SqlConnectString = GlabalString.DBString;
                sqlpara.SQL = "insert into xs_FkdTable_Fb (user_no,bh,fkzhbh,fkzhmc,je,bz)" +
                "values(@user_no,@bh,@fkzhbh,@fkzhmc,@je,@bz)";
                xsSqls.Add(sqlpara);
            }

             return SqlHelper.Execute(xsSqls);

        }

        internal string InsertFyd(DirModel dml,List<DirModel>child1)
        {
            List<xsSqlParameter> xsSqls = new List<xsSqlParameter>();
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into xs_FydTable (user_no,bh,ldrq,sfdw,jsr,bm,zy,fjsm,jsfs,hjje,fkzh,sfje)" +
                "values(@user_no,@bh,@ldrq,@sfdw,@jsr,@bm,@zy,@fjsm,@jsfs,@hjje,@fkzh,@sfje)";
            xsSqls.Add(sqlpara);

            foreach (var val in child1)
            {
                sqlpara = new xsSqlParameter();
                sqlpara.AddSqlParameter(val);
                sqlpara.SqlConnectString = GlabalString.DBString;
                sqlpara.SQL = "insert into xs_FydTable_Fb (user_no,bh,fyxmbh,fyxmmc,je,bz)" +
                "values(@user_no,@bh,@fyxmbh,@fyxmmc,@je,@bz)";
                xsSqls.Add(sqlpara);
            }

            return SqlHelper.Execute(xsSqls);

        }

        internal string InsertRsclr(DirModel dml,List<DirModel>child1,List<DirModel>child2)
        {
            List<xsSqlParameter> xsSqls = new List<xsSqlParameter>();
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into xs_RsclrTable (user_no,bh,ssmc,rq,kjsj,gjsj,bc,ydzs,yddh,ymzs,gsmc)" +
                "values(@user_no,@bh,@ssmc,@rq,@kjsj,@gjsj,@bc,@ydzs,@yddh,@ymzs,@gsmc)";
            xsSqls.Add(sqlpara);
            foreach (var val in child1)
            {
                sqlpara = new xsSqlParameter();
                sqlpara.AddSqlParameter(val);
                sqlpara.SqlConnectString = GlabalString.DBString;
                sqlpara.SQL = "insert into xs_RsclrTable_Scxx (user_no,bh,mz,dj,sl,je,klcl,hhmcl,mmcl,zmcl,nmcl,gscl,shl)" +
                "values(@user_no,@bh,@mz,@dj,@sl,@je,@klcl,@hhmcl,@mmcl,@zmcl,@nmcl,@gscl,@shl)";
                xsSqls.Add(sqlpara);
            }
            foreach (var val in child2)
            {
                sqlpara = new xsSqlParameter();
                sqlpara.AddSqlParameter(val);
                sqlpara.SqlConnectString = GlabalString.DBString;
                sqlpara.SQL = "insert into xs_RsclrTable_Ccxx (user_no,bh,mz,sl,je,cl)" +
                "values(@user_no,@bh,@mz,@sl,@je,@cl)";
                xsSqls.Add(sqlpara);
            }


            return SqlHelper.Execute(xsSqls);
        }

        internal bool InsertRsclr_Scxx(DirModel dml)
        {
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into xs_RsclrTable_Scxx (user_no,bh,mz,sl,je,klcl,hhmcl,mmcl,zmcl,nmcl,gscl,shl)" +
                "values(@user_no,@bh,@mz,@sl,@je,@klcl,@hhmcl,@mmcl,@zmcl,@nmcl,@gscl,@shl)";
            try
            {
                SqlHelper.Execute(sqlpara);
            }
            catch(Exception e)
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
            sqlpara.SQL = "insert into xs_RsclrTable_Ccxx (user_no,bh,mz,sl,je,cl)" +
                "values(@user_no,@bh,@mz,@sl,@je,@cl)";
            try
            {
                SqlHelper.Execute(sqlpara);
            }
            catch (Exception e)
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
            string sql;
            if (qc.all == 1)
            {
                sql = @"select * from xs_SkdTable";
            }
            else
            {
                sql= @"select * from xs_SkdTable where bh='"+qc.bh+"'";
            }
            

            return sql;
        }

        internal string QueryFydOrder(QueryClass2 qc)
        {
            string sql = @"select * from xs_FydTable";

            return sql;
        }

        public string QueryHtOrder(QueryClass qc)
        {
            //string sql = string.Format(@"select * from {0} where ({1}='{2}' and (qdrq>='{3}' and qdrq<='{4}')) or 1={5}", qc.tableName, qc.selectedKey, qc.selectedItem, qc.qdrqQ, qc.qdrqZ, qc.IsAll);

            string sql = string.Format(@"select * from {0} where ({1}='{2}') or 1={5}", qc.tableName, qc.selectedKey, qc.selectedItem, qc.qdrqQ, qc.qdrqZ, qc.IsAll);
            return sql;
        }

        internal string QueryFkdOrder(QueryClass2 qc)
        {
            string sql;
            if (qc.all==1)
            {
                sql = @"select * from xs_FkdTable";
            }
            else
            {
                sql= @"select * from xs_FkdTable where bh='"+qc.bh+"'";
            }
           

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
            string sql;
            if (qc.all == 1)
            {
                sql = @"select * from xs_RsclrTable";
            }
            else
            {
                sql = @"select * from xs_RsclrTable where bh='" + qc.bh + "'";
            }
             

            return sql;
        }

        internal string QueryRsclrScxxOrder(string bh)
        {
            string sql = @"select(mz + N'  ' + CONVERT(varchar(50), sl)) as mzsl from xs_RsclrTable_Scxx where bh='"+bh+"'"; 

            return sql;
        }

        internal string QueryRsclrCcxxOrder(string bh)
        {
            string sql = @"select(mz + N'  ' + CONVERT(varchar(50), sl)) as ccsl from xs_RsclrTable_Ccxx where bh='" + bh + "'";

            return sql;
        }

        internal string QueryPmdlrOrder(QueryClass2 qc)
        {
            string sql;
            if (qc.all == 1)
            {
                sql = @"select * from xs_PmdlrTable";
            }
            else
            {
                sql = @"select * from xs_PmdlrTable where bh='" + qc.bh +"'" ;
            }
            
                
            return sql;
        }

        internal string UpdateFyd(DirModel dml, List<DirModel> child1)
        {
            List<xsSqlParameter> xsSqls = new List<xsSqlParameter>();
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "update xs_FydTable set ldrq=@ldrq,sfdw=@sfdw,jsr=@jsr,bm=@bm,zy=@zy,fjsm=@fjsm,jsfs=@jsfs,hjje=@hjje,fkzh=@fkzh,sfje=@sfje where user_no=@user_no and bh=@bh ";
            xsSqls.Add(sqlpara);

            sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "delete xs_FydTable_Fb  where user_no=@user_no and bh=@bh";
            xsSqls.Add(sqlpara);

            foreach (var val in child1)
            {
                sqlpara = new xsSqlParameter();
                sqlpara.AddSqlParameter(val);
                sqlpara.SqlConnectString = GlabalString.DBString;
                sqlpara.SQL = "insert into xs_FydTable_Fb (user_no,bh,fyxmbh,fyxmmc,je,bz)" +
                "values(@user_no,@bh,@fyxmbh,@fyxmmc,@je,@bz)";
                xsSqls.Add(sqlpara);
            }

            return SqlHelper.Execute(xsSqls);
        }

        internal string QueryPmdlrScxxOrder(string bh)
        {
            string sql = @"select(yl + N'  ' + CONVERT(varchar(50), ylds)) as mzsl from xs_PmdlrTable_Ylmz where bh='" + bh + "'";

            return sql;
        }

        internal string QueryPmdlrCcxxOrder(string bh)
        {
            string sql = @"select(cp + N'  ' + CONVERT(varchar(50), ccds)) as ccsl from xs_PmdlrTable_Ccmz where bh='" + bh + "'";

            return sql;
        }

        public string QueryChildTable(QueryClass2 qc)
        {
            string sql = @"select * from  " + qc.tableName + " where user_no='" + qc.user_no + "' and bh='" + qc.bh + "'";
            return sql;
        }

        internal string InsertPmdlr(DirModel dml,List<DirModel>child1,List<DirModel>child2)
        {
            List<xsSqlParameter> xsSqls = new List<xsSqlParameter>();
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into xs_PmdlrTable (user_no,bh,pmrq,scmc,gsmc)" +
                "values(@user_no,@bh,@pmrq,@scmc,@gsmc)";
            xsSqls.Add(sqlpara);
            foreach(var val in child1)
            {
                sqlpara = new xsSqlParameter();
                sqlpara.AddSqlParameter(val);
                sqlpara.SqlConnectString = GlabalString.DBString;
                sqlpara.SQL = "insert into xs_PmdlrTable_Ylmz (user_no,bh,ylds,cbdj,pmf,je,yl)" +
                "values(@user_no,@bh,@ylds,@cbdj,@pmf,@je,@yl)";
                xsSqls.Add(sqlpara);
            }
            foreach(var val in child2)
            {
                sqlpara = new xsSqlParameter();
                sqlpara.AddSqlParameter(val);
                sqlpara.SqlConnectString = GlabalString.DBString;
                sqlpara.SQL = "insert into xs_PmdlrTable_Ccmz (user_no,bh,cp,ccds,je,cbdj2)" +
                "values(@user_no,@bh,@cp,@ccds,@je,@cbdj2)";
                xsSqls.Add(sqlpara);
            }
            return SqlHelper.Execute(xsSqls);
        }

        internal string UpdateSkd(DirModel dml, List<DirModel> child1)
        {
            List<xsSqlParameter> xsSqls = new List<xsSqlParameter>();
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "update xs_SkdTable set ldrq=@ldrq,fkdw=@fkdw,jsr=@jsr,bm=@bm,htbh=@htbh,zy=@zy,fjsm=@fjsm,jsfs=@jsfs,yhje=@yhje,hjje=@hjje where user_no=@user_no and bh=@bh";
            xsSqls.Add(sqlpara);

            sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "delete xs_SkdTable_Fb  where user_no=@user_no and bh=@bh";
            xsSqls.Add(sqlpara);

            foreach (var val in child1)
            {
                sqlpara = new xsSqlParameter();
                sqlpara.AddSqlParameter(val);
                sqlpara.SqlConnectString = GlabalString.DBString;
                sqlpara.SQL = "insert into xs_SkdTable_Fb (user_no,bh,skzhbh,skzhmc,je,bz)" +
                "values(@user_no,@bh,@skzhbh,@skzhmc,@je,@bz)";
                xsSqls.Add(sqlpara);
            }
            return SqlHelper.Execute(xsSqls);
        }

        internal string UpdateFkd(DirModel dml, List<DirModel> child1)
        {
            List<xsSqlParameter> xsSqls = new List<xsSqlParameter>();
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "update xs_FkdTable set ldrq=@ldrq,skdw=@skdw,jsr=@jsr,bm=@bm,htbh=@htbh,zy=@zy,fjsm=@fjsm,jsfs=@jsfs,yhje=@yhje,hjje=@hjje where user_no=@user_no and bh=@bh ";
            xsSqls.Add(sqlpara);

            sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "delete xs_FkdTable_Fb where user_no=@user_no and bh=@bh";
            xsSqls.Add(sqlpara);

            foreach (var val in child1)
            {
                sqlpara = new xsSqlParameter();
                sqlpara.AddSqlParameter(val);
                sqlpara.SqlConnectString = GlabalString.DBString;
                sqlpara.SQL = "insert into xs_FkdTable_Fb (user_no,bh,fkzhbh,fkzhmc,je,bz)" +
                "values(@user_no,@bh,@fkzhbh,@fkzhmc,@je,@bz)";
                xsSqls.Add(sqlpara);
            }

            return SqlHelper.Execute(xsSqls);
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

        internal string UpdatePmdlr(DirModel dml, List<DirModel> child1, List<DirModel> child2)
        {
            List<xsSqlParameter> xsSqls = new List<xsSqlParameter>();
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "update xs_PmdlrTable set pmrq=@pmrq,scmc=@scmc,gsmc=@gsmc where user_no=@user_no and bh=@bh";
            xsSqls.Add(sqlpara);

            sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "delete xs_PmdlrTable_Ylmz  where user_no=@user_no and bh=@bh";
            xsSqls.Add(sqlpara);

            sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "delete xs_PmdlrTable_Ccmz  where user_no=@user_no and bh=@bh";
            xsSqls.Add(sqlpara);

            foreach (var val in child1)
            {
                sqlpara = new xsSqlParameter();
                sqlpara.AddSqlParameter(val);
                sqlpara.SqlConnectString = GlabalString.DBString;
                sqlpara.SQL = "insert into xs_PmdlrTable_Ylmz (user_no,bh,ylds,cbdj,pmf,je,yl)" +
                "values(@user_no,@bh,@ylds,@cbdj,@pmf,@je,@yl)";
                xsSqls.Add(sqlpara);
            }
            foreach (var val in child2)
            {
                sqlpara = new xsSqlParameter();
                sqlpara.AddSqlParameter(val);
                sqlpara.SqlConnectString = GlabalString.DBString;
                sqlpara.SQL = "insert into xs_PmdlrTable_Ccmz (user_no,bh,cp,ccds,je,cbdj2)" +
                "values(@user_no,@bh,@cp,@ccds,@je,@cbdj2)";
                xsSqls.Add(sqlpara);
            }
            return SqlHelper.Execute(xsSqls);
        }

        internal string InsertSkd(DirModel dml,List<DirModel>child1)
        {
            List<xsSqlParameter> xsSqls = new List<xsSqlParameter>();
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into xs_SkdTable (user_no,bh,ldrq,fkdw,jsr,bm,htbh,zy,fjsm,jsfs,yhje,hjje)" +
                "values(@user_no,@bh,@ldrq,@fkdw,@jsr,@bm,@htbh,@zy,@fjsm,@jsfs,@yhje,@hjje)";
            xsSqls.Add(sqlpara);
            foreach (var val in child1)
            {
                sqlpara = new xsSqlParameter();
                sqlpara.AddSqlParameter(val);
                sqlpara.SqlConnectString = GlabalString.DBString;
                sqlpara.SQL = "insert into xs_SkdTable_Fb (user_no,bh,skzhbh,skzhmc,je,bz)" +
                "values(@user_no,@bh,@skzhbh,@skzhmc,@je,@bz)";
                xsSqls.Add(sqlpara);
            }
            return SqlHelper.Execute(xsSqls);

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

        internal string UpdateRsclr(DirModel dml, List<DirModel> child1, List<DirModel> child2)
        {
            List<xsSqlParameter> xsSqls = new List<xsSqlParameter>();
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "update xs_RsclrTable set ssmc=@ssmc,rq=@rq,kjsj=@kjsj,gjsj=@gjsj,bc=@bc,ydzs=@ydzs,yddh=@yddh,ymzs=@ymzs,gsmc=@gsmc where user_no=@user_no and bh=@bh)";
            xsSqls.Add(sqlpara);


            sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "delete xs_RsclrTable_Scxx  where user_no=@user_no and bh=@bh";
            xsSqls.Add(sqlpara);

            sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "delete xs_RsclrTable_Ccxx  where user_no=@user_no and bh=@bh";
            xsSqls.Add(sqlpara);

            foreach (var val in child1)
            {
                sqlpara = new xsSqlParameter();
                sqlpara.AddSqlParameter(val);
                sqlpara.SqlConnectString = GlabalString.DBString;
                sqlpara.SQL = "insert into xs_RsclrTable_Scxx (user_no,bh,mz,dj,sl,je,klcl,hhmcl,mmcl,zmcl,nmcl,gscl,shl)" +
                "values(@user_no,@bh,@mz,@dj,@sl,@je,@klcl,@hhmcl,@mmcl,@zmcl,@nmcl,@gscl,@shl)";
                xsSqls.Add(sqlpara);
            }
            foreach (var val in child2)
            {
                sqlpara = new xsSqlParameter();
                sqlpara.AddSqlParameter(val);
                sqlpara.SqlConnectString = GlabalString.DBString;
                sqlpara.SQL = "insert into xs_RsclrTable_Ccxx (user_no,bh,mz,sl,je,cl)" +
                "values(@user_no,@bh,@mz,@sl,@je,@cl)";
                xsSqls.Add(sqlpara);
            }


            return SqlHelper.Execute(xsSqls);
        }
    }
}