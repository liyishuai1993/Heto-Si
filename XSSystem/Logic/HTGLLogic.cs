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

        public bool InsertWtjght(DirModel dml, List<DirModel> child1)
        {
            List<xsSqlParameter> xsSqls = new List<xsSqlParameter>();
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into xs_WtjgTable (user_no,htbh,htlx,qdrq,wtf,stf,kplx,zxqxQ,zxqxZ)" +
                "values(@userid,@htbh,@htlx,@qdrq,@wtf,@stf,@kplx,@zxqxQ,@zxqxZ)";
            xsSqls.Add(sqlpara);

            foreach (var val in child1)
            {
                sqlpara = new xsSqlParameter();
                sqlpara.AddSqlParameter(val);
                sqlpara.SqlConnectString = GlabalString.DBString;
                sqlpara.SQL = "insert into xs_WtjghtTable_Jgxx (user_no,htbh,wlmc,jgf,cmzb,bz)" +
                "values(@user_no,@htbh,@wlmc,@jgf,@cmzb,@bz)";
                xsSqls.Add(sqlpara);
            }
            SqlHelper.Execute(xsSqls);
            return true;
        }

        public string  InsertMkzxzcd(DirModel dml,List<DirModel>child1)
        {
            List<xsSqlParameter> xsSqls = new List<xsSqlParameter>();
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into xs_MkzxzcdTable (user_no,djbh,zcsj,cghth,ghf,shf,mkmc,wlmc,cydw,yj,cgmj,xsmj)" +
                "values(@user_no,@djbh,@zcsj,@cghth,@ghf,@shf,@mkmc,@wlmc,@cydw,@yj,@cgmj,@xsmj)";
            xsSqls.Add(sqlpara);
            foreach (var val in child1)
            {
                sqlpara = new xsSqlParameter();
                sqlpara.AddSqlParameter(val);
                sqlpara.SqlConnectString = GlabalString.DBString;
                sqlpara.SQL = "insert into xs_MkzxzcdTable_Clxx (user_no,djbh,bdh,thdh,ch,zcmz,zcpz,zcjz,yfyf,cgjsje,xsjsje,bz,zt)" +
                "values(@user_no,@djbh,@bdh,@thdh,@ch,@zcmz,@zcpz,@zcjz,@yfyf,@cgjsje,@xsjsje,@bz,@zt)";
                xsSqls.Add(sqlpara);
            }
            return SqlHelper.Execute(xsSqls);
        }

        public string InsertTydbckd(DirModel dml,List<DirModel>child1)
        {
            List<xsSqlParameter> xsSqls = new List<xsSqlParameter>();
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into xs_TydbckdTable (user_no,bh,htbh,gsmc,fmmc,wlmc,zcz,zdz,xlx,xhdw)" +
                "values(@user_no,@bh,@htbh,@gsmc,@fmmc,@wlmc,@zcz,@zdz,@xlx,@xhdw)";
            xsSqls.Add(sqlpara);
            foreach (var val in child1)
            {
                sqlpara = new xsSqlParameter();
                sqlpara.AddSqlParameter(val);
                sqlpara.SqlConnectString = GlabalString.DBString;
                sqlpara.SQL = "insert into xs_Tydbckd_Jzxxx (user_no,bh,xh,sxds,zxrq,fcrq,dcmj,xhds,dzrq,xhck,zbxsf,fzdlf,fzzxf,fzddf,tlyf,dzzxf,dzmcddf,dzdlf,drmj)" +
                "values(@user_no,@bh,@xh,@sxds,@zxrq,@fcrq,@dcmj,@xhds,@dzrq,@xhck,@zbxsf,@fzdlf,@fzzxf,@fzddf,@tlyf,@dzzxf,@dzmcddf,@dzdlf,@drmj)";
                xsSqls.Add(sqlpara);
            }

            return SqlHelper.Execute(xsSqls);
        }

        public bool InsertYuanLiao(DirModel dml)
        {
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into xs_YuanLiaoTable (yl) values (@yl)";
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

        public bool InsertChanPing(DirModel dml)
        {
            
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into xs_ChanPingTable (cp) values (@cp)";
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
        

        public bool InsertWangLaiDanWei(DirModel dml)
        {

            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into xs_WangLaiDanWei (wldw,type) values (@wldw,@type)";
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

        public bool InsertQydbhd(DirModel dml)
        {
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into xs_QydbhdTable (user_no,rkbdh,rksj,smmc,rkmz,rkpz,rkjz,ksds,yyds,yslhbz,yfkkbz,yfkkds,yfkkje,yfjsdw,yfyf,fykk,jsyf,drje,drmj,shzt,yfjszt)" +
                "values(@user_no,@rkbdh,@rksj,@smmc,@rkmz,@rkpz,@rkjz,@ksds,@yyds,@yslhbz,@yfkkbz,@yfkkds,@yfkkje,@yfjsdw,@yfyf,@fykk,@jsyf,@drje,@drmj,@shzt,@yfjszt)";
            SqlHelper.Execute(sqlpara);

            sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "update xs_QydbckdTable set rkbdh =@rkbdh where ckbdh=@ckbdh";
            SqlHelper.Execute(sqlpara);
            return true;
        }

        public bool InsertQydbckd(DirModel dml)
        {
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into xs_QydbckdTable (user_no,bh,ckbdh,zcsj,gsmc,fmmc,ch,jsy,lxdh,wlmc,ckmz,ckpz,ckjz,dcmj,dbje,yj,yfyk,fkzh)" +
                "values(@user_no,@bh,@ckbdh,@zcsj,@gsmc,@fmmc,@ch,@jsy,@lxdh,@wlmc,@ckmz,@ckpz,@ckjz,@dcmj,@dbje,@yj,@yfyk,@fkzh)";
            SqlHelper.Execute(sqlpara);
            return true;
        }

        public string InsertTyxsckd(DirModel dml,List<DirModel>child1)
        {
            List<xsSqlParameter> xsSqls = new List<xsSqlParameter>();
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into xs_TyxsckdTable (user_no,bh,htbh,wtf,stf,fmmc,wlmc,mj,zcz,zdz,xlx,tcbz,tcje,ywy,xhdw)" +
                "values(@user_no,@bh,@htbh,@wtf,@stf,@fmmc,@wlmc,@mj,@zcz,@zdz,@xlx,@tcbz,@tcje,@ywy,@xhdw)";
            xsSqls.Add(sqlpara);
            foreach(var val in child1)
            {
                sqlpara = new xsSqlParameter();
                sqlpara.AddSqlParameter(val);
                sqlpara.SqlConnectString = GlabalString.DBString;
                sqlpara.SQL = "insert into xs_Tyxsckd_Jzxxx (user_no,htbh,bh,xh,sxds,zxrq,fcrq,xhds,dzrq,jshk,zbxsf,fzdlf,fzzxf,fzddf,tlyf,dzzxf,dzmcddf,dzdlf,tlyfxj)" +
                "values(@user_no,@htbh,@bh,@xh,@sxds,@zxrq,@fcrq,@xhds,@dzrq,@jshk,@zbxsf,@fzdlf,@fzzxf,@fzddf,@tlyf,@dzzxf,@dzmcddf,@dzdlf,@tlyfxj)";
                xsSqls.Add(sqlpara);
            }
            return SqlHelper.Execute(xsSqls);
        }

        public bool InsertQykhhdlr(DirModel dml)
        {
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into xs_QykhhdlrTable (user_no,rkbdh,rksj,rkmz,rkpz,rkjz,ksds,yyds,kd,yfhllh,yflhbz,yfkkds,yfkkje,yfjsdw,yfyf,fykk,jsyf,hkjsdw,jshk,tcbz,tcje,ywy,yfjszt,shzt)" +
                "values(@user_no,@rkbdh,@rksj,@rkmz,@rkpz,@rkjz,@ksds,@yyds,@kd,@yfhllh,@yflhbz,@yfkkds,@yfkkje,@yfjsdw,@yfyf,@fykk,@jsyf,@hkjsdw,@jshk,@tcbz,@tcje,@ywy,@yfjszt,@shzt)";
            SqlHelper.Execute(sqlpara);

            sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "update xs_QyxsckdTable set rkbdh =@rkbdh where ckbdh=@ckbdh";
            SqlHelper.Execute(sqlpara);
            return true;
        }

        public bool InsertQyxsckd(DirModel dml)
        {
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into xs_QyxsckdTable (user_no,ckbdh,htbh,zcsj,fmmc,gf,xf,ch,jsy,lxdh,wlmc,ckmz,ckpz,jbds,ckjz1,ckjz2,mj,hkgsje,yfyk,yj,fkzh)" +
                "values(@user_no,@ckbdh,@htbh,@zcsj,@fmmc,@gf,@xf,@ch,@jsy,@lxdh,@wlmc,@ckmz,@ckpz,@jbds,@ckjz1,@ckjz2,@mj,@hkgsje,@yfyk,@yj,@fkzh)";
            SqlHelper.Execute(sqlpara);
            return true;
        }

        public bool InsertCgrkd(DirModel dml)
        {
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into xs_CgrkdTable (user_no,hth,mkmc,gf,xf,wlmc,mj,yshtbh,cycd,zcbdh,tmdh,zcrq,ch,zcmz,zcpz,zcjz,jsmk,rkrq,rkbdh,rkmc,rkmz,rkpz,rkjz,ksds,yyds,yslhbz,kkbz,kkds,kkje,yfjsdw,yj,yfyf,yfyk,fkzh,jsyf,zfzh,shzt,yfjszt)" +
                "values(@user_no,@hth,@mkmc,@gf,@xf,@wlmc,@mj,@yshtbh,@cycd,@zcbdh,@tmdh,@zcrq,@ch,@zcmz,@zcpz,@zcjz,@jsmk,@rkrq,@rkbdh,@rkmc,@rkmz,@rkpz,@rkjz,@ksds,@yyds,@yslhbz,@kkbz,@kkds,@kkje,@yfjsdw,@yj,@yfyf,@yfyk,@fkzh,@jsyf,@zfzh,@shzt,@yfjszt)";
            SqlHelper.Execute(sqlpara);
            return true;
        }

       

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dml"></param>
        /// <returns></returns>
        public string InsertCght(DirModel dml,List<DirModel>child1, List<DirModel> child2)
        {
            List<xsSqlParameter> xsSqls = new List<xsSqlParameter>();
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into xs_CghtTable (user_no,htbh,htlx,qdrq,dfhth,gfmc,xfmc,hkjsyj,hklhlx,hklhbz,kpxx,jhsjQ,jhsjZ,hkjsfs,jhdd,yffkfs,mkmc,bz)"+
                "values(@userid,@htbh,@htlx,@qdrq,@dfhth,@gfmc,@xfmc,@hkjsyj,@hklhlx,@hklhbz,@kpxx,@jhsjQ,@jhsjZ,@hkjsfs,@jhdd,@yffkfs,@mkmc,@bz)";
            xsSqls.Add(sqlpara);
            foreach(var val in child1)
            {
                sqlpara = new xsSqlParameter();
                sqlpara.AddSqlParameter(val);
                sqlpara.SqlConnectString = GlabalString.DBString;
                sqlpara.SQL = "insert into xs_CghtTable_Jgxx (user_no,htbh,mkmc,mzmc,frl,lf,kpmj,htmj,ksl,qdds,qdje,zt)" +
                    "values(@user_no,@htbh,@mkmc,@mzmc,@frl,@lf,@kpmj,@htmj,@ksl,@qdds,@qdje,@zt)";
                xsSqls.Add(sqlpara);
            }
            foreach (var val in child2)
            {
                sqlpara = new xsSqlParameter();
                sqlpara.AddSqlParameter(val);
                sqlpara.SqlConnectString = GlabalString.DBString;
                sqlpara.SQL = "insert into xs_CghtTable_Zlbz (user_no,htbh,mz,ld,hf,hff,gdt,njzs,sf,tie,lv,gai,lin,tai,liu)" +
                "values(@user_no,@htbh,@mz,@ld,@hf,@hff,@gdt,@njzs,@sf,@tie,@lv,@gai,@lin,@tai,@liu)";
                xsSqls.Add(sqlpara);
            }
            return SqlHelper.Execute(xsSqls);
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

        public bool InsertTyxsJzxxx(DirModel dml)
        {
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into xs_Tyxsckd_Jzxxx (user_no,htbh,bh,xh,sxds,zxrq,fcrq,xhds,dzrq,jshk,zbxsf,fzdlf,fzzxf,fzddf,tlyf,dzzxf,dzmcddf,dzdlf,tlyfxj)" +
                "values(@user_no,@htbh,@bh,@xh,@sxds,@zxrq,@fcrq,@xhds,@dzrq,@jshk,@zbxsf,@fzdlf,@fzzxf,@fzddf,@tlyf,@dzzxf,@dzmcddf,@dzdlf,@tlyfxj)";
            SqlHelper.Execute(sqlpara);
            return true;
        }

        public bool InsertTydbckdJzxxx(DirModel dml)
        {
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into xs_Tydbckd_Jzxxx (user_no,bh,xh,sxds,zxrq,fcrq,dcmj,xhds,dzrq,xhck,zbxsf,fzdlf,fzzxf,fzddf,tlyf,dzzxf,dzmcddf,dzdlf,drmj)" +
                "values(@user_no,@bh,@xh,@sxds,@zxrq,@fcrq,@dcmj,@xhds,@dzrq,@xhck,@zbxsf,@fzdlf,@fzzxf,@fzddf,@tlyf,@dzzxf,@dzmcddf,@dzdlf,@drmj)";
            SqlHelper.Execute(sqlpara);
            return true;
        }

        public bool InsertMkzxzcdClxx(DirModel dml)
        {
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into xs_MkzxzcdTable_Clxx (user_no,djbh,bdh,thdh,ch,zcmz,zcpz,zcjz,yfyf,cgjsje,xsjsje,bz,zt)" +
                "values(@user_no,@djbh,@bdh,@thdh,@ch,@zcmz,@zcpz,@zcjz,@yfyf,@cgjsje,@xsjsje,@bz,@zt)";
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

        public bool InsertXsht(DirModel dml,List<DirModel>child1,List<DirModel>child2)
        {
            List<xsSqlParameter> xsSqls = new List<xsSqlParameter>();
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into xs_XshtTable (user_no,htbh,htlx,qdrq,dfhth,gfmc,xfmc,hkjsyj,hklhlx,hklhbz,kpxx,jhsjQ,jhsjZ,hkjsfs,fhdd,yffkfs,mkmc,kzbz,lxdh,bz)" +
                "values(@userid,@htbh,@htlx,@qdrq,@dfhth,@gfmc,@xfmc,@hkjsyj,@hklhlx,@hklhbz,@kpxx,@jhsjQ,@jhsjZ,@hkjsfs,@fhdd,@yffkfs,@mkmc,@kzbz,@lxdh,@bz)";
            xsSqls.Add(sqlpara);

            foreach (var val in child1)
            {
                sqlpara = new xsSqlParameter();
                sqlpara.AddSqlParameter(val);
                sqlpara.SqlConnectString = GlabalString.DBString;
                sqlpara.SQL = "insert into xs_XshtTable_Jgxx (user_no,htbh,mkmc,mzmc,frl,lf,kpmj,htmj,ksl,qdds,qdje,zt)" +
                "values(@user_no,@htbh,@mkmc,@mzmc,@frl,@lf,@kpmj,@htmj,@ksl,@qdds,@qdje,@zt)";
                xsSqls.Add(sqlpara);
            }
            foreach (var val in child2)
            {
                sqlpara = new xsSqlParameter();
                sqlpara.AddSqlParameter(val);
                sqlpara.SqlConnectString = GlabalString.DBString;
                sqlpara.SQL = "insert into xs_XshtTable_Zlbz (user_no,htbh,mz,ld,hf,hff,gdt,njzs,sf,tie,lv,gai,lin,tai,liu)" +
                "values(@user_no,@htbh,@mz,@ld,@hf,@hff,@gdt,@njzs,@sf,@tie,@lv,@gai,@lin,@tai,@liu)";
                xsSqls.Add(sqlpara);
            }

            SqlHelper.Execute(xsSqls);
            return true;
        }

        public bool InsertXshtJgxx(DirModel dml)
        {
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into xs_XshtTable_Jgxx (user_no,htbh,mkmc,mzmc,frl,lf,kpmj,htmj,ksl,qdds,qdje)" +
                "values(@user_no,@htbh,@mkmc,@mzmc,@frl,@lf,@kpmj,@htmj,@ksl,@qdds,@qdje)";
            SqlHelper.Execute(sqlpara);
            return true;
        }

        public bool InsertXshtZlbz(DirModel dml)
        {
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into xs_XshtTable_Zlbz (user_no,htbh,mz,ld,hf,hff,gdt,njzs,sf,tie,lv,gai,lin,tai,liu)" +
                "values(@user_no,@htbh,@mz,@ld,@hf,@hff,@gdt,@njzs,@sf,@tie,@lv,@gai,@lin,@tai,@liu)";
            SqlHelper.Execute(sqlpara);
            return true;
        }

        public bool InsertQyht(DirModel dml,List<DirModel> child1)
        {
            List<xsSqlParameter> xsSqls = new List<xsSqlParameter>();
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into xs_QyhtTable (user_no,htbh,htlx,qdrq,dfhth,wtf,stf,kplx,zxqxQ,zxqxZ)" +
                "values(@userid,@htbh,@htlx,@qdrq,@dfhth,@wtf,@stf,@kplx,@zxqxQ,@zxqxZ)";
            xsSqls.Add(sqlpara);

            foreach (var val in child1)
            {
                sqlpara = new xsSqlParameter();
                sqlpara.AddSqlParameter(val);
                sqlpara.SqlConnectString = GlabalString.DBString;
                sqlpara.SQL = "insert into xs_QyhtTable_Jgxx (user_no,htbh,wlmc,qyd,mdd,yj,yflhbz,zxzt,bz)" +
                "values(@user_no,@htbh,@wlmc,@qyd,@mdd,@yj,@yflhbz,@zxzt,@bz)";
                xsSqls.Add(sqlpara);
            }

            SqlHelper.Execute(xsSqls);
            return true;
        }

        public bool InsertQyhtJgxx(DirModel dml)
        {
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into xs_QyhtTable_Jgxx (user_no,htbh,wlmc,qyd,mdd,yj,yflhbz,bz)" +
                "values(@user_no,@htbh,@wlmc,@qyd,@mdd,@yj,@yflhbz,@bz)";
            SqlHelper.Execute(sqlpara);
            return true;
        }

        public bool InsertTyht(DirModel dml,List<DirModel> child1)
        {
            List<xsSqlParameter> xsSqls = new List<xsSqlParameter>();
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into xs_TyhtTable (user_no,htbh,htlx,qdrq,wtf,stf,fmmc,wlmc,zxqxQ,zxqxZ,zcz,zdz,xlx,sl)" +
                "values(@userid,@htbh,@htlx,@qdrq,@wtf,@stf,@fmmc,@wlmc,@zxqxQ,@zxqxZ,@zcz,@zdz,@xlx,@sl)";
            xsSqls.Add(sqlpara);

            foreach(var val in child1)
            {
                sqlpara = new xsSqlParameter();
                sqlpara.AddSqlParameter(val);
                sqlpara.SqlConnectString = GlabalString.DBString;
                sqlpara.SQL = "insert into xs_TyhtTable_Jgxx (user_no,htbh,gsmc,dfhth,kplx,zbxsf,dlf,zxf,sfzdd,tlyf,dzzxf,dzmcddf,dzdlf)" +
                "values(@user_no,@htbh,@gsmc,@dfhth,@kplx,@zbxsf,@dlf,@zxf,@sfzdd,@tlyf,@dzzxf,@dzmcddf,@dzdlf)";
                xsSqls.Add(sqlpara);
            }
            SqlHelper.Execute(xsSqls);
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

        

        public bool InsertWtjghtJgxx(DirModel dml)
        {
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into xs_WtjghtTable_Jgxx (user_no,htbh,wlmc,jgf,cmzb,bz)" +
                "values(@user_no,@htbh,@wlmc,@jgf,@cmzb,@bz)";
            SqlHelper.Execute(sqlpara);
            return true;
        }

        public bool InsertZlht(DirModel dml,List<DirModel>child1)
        {
            List<xsSqlParameter> xsSqls = new List<xsSqlParameter>();
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into xs_ZlhtTable (user_no,htbh,htlx,qdrq,czf,czf2,czdd,zlqxQ,zlqxZ,yj)" +
                "values(@userid,@htbh,@htlx,@qdrq,@czf,@czf2,@czdd,@zlqxQ,@zlqxZ,@yj)";
            xsSqls.Add(sqlpara);
            foreach(var val in child1)
            {
                sqlpara = new xsSqlParameter();
                sqlpara.AddSqlParameter(val);
                sqlpara.SqlConnectString = GlabalString.DBString;
                sqlpara.SQL = "insert into xs_ZlhtTable_Zjxx (user_no,htbh,qsrq,zzrq,zj,fktk,zxzt,bz)" +
                "values(@user_no,@htbh,@qsrq,@zzrq,@zj,@fktk,@zxzt,@bz)";
                xsSqls.Add(sqlpara);
            }
            SqlHelper.Execute(xsSqls);
            return true;
        }

        public bool InsertZlhtZjxx(DirModel dml)
        {
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into xs_ZlhtTable_Zjxx (user_no,htbh,qsrq,zzrq,zj,fktk,zxzt,bz)" +
                "values(@user_no,@htbh,@qsrq,@zzrq,@zj,@fktk,@zxzt,@bz)";
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

        public bool InsertMeZhong(DirModel dml)
        {
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into xs_MeiZhongTable (mzmc) values (@mzmc)";
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

        public string QueryCghtOrder(QueryClass qc)
        {
            string sql = @"select * from xs_CghtTable where htbh='"+qc.htbh+"' or ( qdrq>='"+ qc.qdrqQ+
                "' and qdrq<='"+ qc.qdrqZ+"' ) or gfmc='"+qc.gfmc+
                 "' or htbh in(select htbh from xs_CghtTable_Jgxx where  kpmj>="+qc.kpmj+" or zt='"+ qc.zt+"')";
            return sql;
        }

        public string QueryCghtChildTable(QueryClass qc)
        {
            string sql=@"select * from  "+qc.tableName+ " where user_no='"+qc.user_no+"' and htbh='"+qc.htbh+"'";
            return sql;
        }

        public string QueryThdbckdChildTable(QueryClass qc)
        {
            string sql = @"select * from  " + qc.tableName + " where user_no='" + qc.user_no + "' and bh='" + qc.bh + "'";
            return sql;
        }

        public string QueryMkzxzcdChildTable(QueryClass qc)
        {
            string sql = @"select * from  " + qc.tableName + " where user_no='" + qc.user_no + "' and djbh='" + qc.djbh + "'";
            return sql;
        }

        public string QueryQyhtOrder(QueryClass qc)
        {
            string sql = @"select * from xs_QyhtTable where htbh='" + qc.htbh + "' or ( qdrq>='" + qc.qdrqQ +
                "' and qdrq<='" + qc.qdrqZ + "' )  or stf='" +
                qc.stf + "' or htbh in(select htbh from xs_QyhtTable_Jgxx where qyd='" + qc.qyd +
                "' or mdd='" + qc.mdd + "' or yj>="+qc.yj+  " or zxzt='" + qc.zt + "')";
            return sql;
        }

        public string QueryTyhtOrder(QueryClass qc)
        {
            string sql = @"select * from xs_TyhtTable where htbh='" + qc.htbh + "' or ( qdrq>='" + qc.qdrqQ +
                "' and qdrq<='" + qc.qdrqZ + "' ) or shzt='" + qc.zt + "' or stf='" +
                qc.stf +  "' or zcz='"+qc.zcz+"' or zdz='"+qc.zdz+"'";
            return sql;
        }

        public string QueryWtjgOrder(QueryClass qc)
        {
            string sql = @"select * from xs_WtjgTable where htbh='" + qc.htbh + "' or ( qdrq>='" + qc.qdrqQ +
                "' and qdrq<='" + qc.qdrqZ + "' ) or shzt='" + qc.zt + "' or stf='" +
                qc.stf  + "' or htbh in(select htbh from xs_WtjghtTable_Jgxx where jgf>=" + qc.jgf + ")";
            return sql;
        }

        public string QueryXshtOrder(QueryClass qc)
        {
            string sql = @"select * from xs_XshtTable where htbh='" + qc.htbh + "' or ( qdrq>='" + qc.qdrqQ +
                "' and qdrq<='" + qc.qdrqZ + "' ) or xfmc='" + qc.xfmc + "' or htbh in(select htbh from xs_XshtTable_Jgxx where kpmj>=" + qc.kpmj + " or zt='" + qc.zt + "')";
            return sql;
        }

        public string QueryZlhtOrder(QueryClass qc)
        {
            string sql = @"select * from xs_ZlhtTable where htbh='" + qc.htbh + "' or ( qdrq>='" + qc.qdrqQ +
                "' and qdrq<='" + qc.qdrqZ + "' ) or czf='" + qc.czf + "' or czdd='" +
                qc.czdd + "' or shzt='"+qc.zt+"' or htbh in(select htbh from xs_ZlhtTable_Zjxx where zj='" + qc.zj + "')";
            return sql;
        }

        public string QueryMkzxzcd(QueryClass qc)
        {
            string sql = @"select * from xs_MkzxzcdTable where cghth='" + qc.cghth + "' or ( zcsj>='" + qc.qdrqQ +
                "' and zcsj<='" + qc.qdrqZ + "' ) or ghf='" + qc.ghf + "' or shf='" +
                qc.shf + "'";
            return sql;
        }

        public string QueryCgrkd(QueryClass qc)
        {
            string sql = @"select * from xs_CgrkdTable where rkbdh='" + qc.rkbdh + "' or  hth>='" + qc.hth +"' or ( zcrq>='" + qc.qdrqQ +
                "' and zcrq<='" + qc.qdrqZ + "' ) or gf='" + qc.gfmc + "' or mj=" +
                qc.mj + " or zcjz=" + qc.zcjz + " or rkjz=" + qc.rkjz + " or wlmc='" + qc.wlmc+"' or rkmc='"+qc.rkmc+"'";
            return sql;
        }

        public string QueryQyxsckdOrder(QueryClass qc)
        {
            string sql = @"select * from xs_QyxsckdTable where ckbdh='" + qc.ckbdh + "' or ( zcsj>='" + qc.qdrqQ +
                "' and zcsj<='" + qc.qdrqZ + "' ) or fmmc='" + qc.fmmc + "' or xf='" +
                qc.xfmc + "' or ch='" + qc.ch + "' or ckjz2="+qc.ckjz2+" or mj="+qc.mj; 
            return sql;
        }

        public string QueryQykhhdlrOrder(QueryClass qc)
        {
            string sql = @"select * from xs_QykhhdlrTable where rkbdh= '" + qc.rkbdh + "' or ( rksj>='" + qc.qdrqQ +
                "' and rksj<='" + qc.qdrqZ + "') or rkjz=" + qc.rkjz;
            return sql;
        }

        public string QueryTyxsckdOrder(QueryClass qc)
        {
            string sql = @"select * from xs_TyxsckdTable where stf= '" + qc.stf + "'or htbh='"+qc.htbh+ "' or zcz='" + qc.zcz+"' or zdz='"+qc.zdz+
                "' or htbh in(select htbh from xs_Tyxsckd_Jzxxx where xh='" + qc.xh + "' or ( fcrq>='" + qc.qdrqQ +"' and fcrq<='" + qc.qdrqZ +"'))";
            return sql;
        }

        public string QueryQydbckdOrder(QueryClass qc)
        {
            string sql = @"select * from xs_QydbckdTable where ckbdh='" + qc.ckbdh + "' or ( zcsj>='" + qc.qdrqQ +
                "' and zcsj<='" + qc.qdrqZ + "' ) or fmmc='" + qc.fmmc + "' or ch='" +
                qc.ch + "' or wlmc='" + qc.wlmc + "' or ckjz=" + qc.ckjz;
            return sql;
        }

        public string QueryQydbhdOrder(QueryClass qc)
        {
            string sql = @"select * from xs_QydbhdTable where rkbdh='" + qc.rkbdh + "' or ( rksj>='" + qc.qdrqQ +
                "' and rksj<='" + qc.qdrqZ + "' ) or smmc='" + qc.smmc  + "' or rkjz=" + qc.rkjz;
            return sql;
        }

        public string QueryTydbckdOrder(QueryClass qc)
        {
            string sql = @"select * from xs_TydbckdTable where fmmc='" + qc.fmmc + "' or wlmc='" + qc.wlmc + "' or bh='" + qc.bh + "' or zcz='" +
                qc.zcz + "' or zdz='" + qc.zdz + "' or xlx='" + qc.xlx+
                "' or bh in(select bh from xs_Tydbckd_Jzxxx where xh='" + qc.xh + "' or xhck='"+qc.xhck+"' or fcrq='"+qc.qdrqQ+"')";
            return sql;
        }

        public string QueryMkzxzcdOrder(QueryClass qc)
        {
            string sql = @"select * from xs_MkzxzcdTable where ghf='" + qc.ghf + "' or shf='" + qc.shf + "' or wlmc='" +
                qc.wlmc + "' or ( zcsj>='" + qc.qdrqQ + "' and zcsj<='" + qc.qdrqZ +"' or djbh='"+qc.djbh+
                "') or djbh in(select djbh from xs_MkzxzcdTable_Clxx where ch='" + qc.ch + "' or zcjz=" + qc.zcjz+")";
            return sql;
        }
        


        public bool DeleteData(DirModel dml, string tablename,string key)
        {
            string[] ckb = dml.GetValue<string[]>("@htbhArr");
            string sql = "";
            xsSqlParameter sqlpara = new xsSqlParameter();
          //  sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sql = @"delete from [" + tablename + "]where "+key+"='";
            for (int i = 0; i < ckb.Length; i++)
            {
                sql += ckb[i];
                if (i == ckb.Length - 1)
                    sql += "'";
                else
                    sql += "' or "+key+"='";
            }
            sqlpara.SQL = sql;
            SqlHelper.Execute(sqlpara);
            
            return true;
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

        public bool DeleteChildTable(DirModel dml, string tablename)
        {
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = @"delete from [" + tablename + "]where [htbh]=@htbh and bh=@bh";
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

        public bool ZhiXingOrder(DirModel dml, string tablename)
        {
            xsSqlParameter sql = new xsSqlParameter();
            sql.AddSqlParameter(dml);
            sql.SqlConnectString = GlabalString.DBString;
            sql.SQL = "update " + tablename + " set zxzt='已执行' where htbh=@htbh";
            SqlHelper.Execute(sql);
            return true;
        }

    }
}