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

        public string InsertWtjght(DirModel dml, List<DirModel> child1)
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
            return SqlHelper.Execute(xsSqls);
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
        
        public bool InsertYuanGong(DirModel dml)
        {
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into xs_YuanGong (yg) values (@yg)";

            return SqlHelper.Execute(sqlpara);
        }

        public bool InsertZhangHu(DirModel dml)
        {
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into xs_ZhangHu (zh,zhm,khh) values (@zh,@zhm,@khh)";

            return SqlHelper.Execute(sqlpara);
        }

        public bool InsertQydbhd(DirModel dml)
        {
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into xs_QydbhdTable (user_no,rkbdh,rksj,smmc,rkmz,rkpz,rkjz,ksds,yyds,yslhbz,yfkkbz,yfkkds,yfkkje,yfjsdw,yfyf,fykk,jsyf,drje,drmj,shzt,yfjszt)" +
                "values(@user_no,@rkbdh,@rksj,@smmc,@rkmz,@rkpz,@rkjz,@ksds,@yyds,@yslhbz,@yfkkbz,@yfkkds,@yfkkje,@yfjsdw,@yfyf,@fykk,@jsyf,@drje,@drmj,@shzt,@yfjszt)";
            bool a=SqlHelper.Execute(sqlpara);
            if (!a)
                return a;

            sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "update xs_QydbckdTable set rkbdh =@rkbdh where ckbdh=@ckbdh";
            return SqlHelper.Execute(sqlpara)&&a;
             
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
                sqlpara.SQL = "insert into xs_Tyxsckd_Jzxxx (user_no,htbh,bh,xh,sxds,zxrq,fcrq,xhds,dzrq,jshk,zbxsf,fzdlf,fzzxf,fzddf,tlyf,dzzxf,dzmcddf,dzdlf,tlyfxj,jshk_qkr,zbxsf_qkr,fzdlf_qkr,fzzxf_qkr,fzddf_qkr,tlyf_qkr,dzzxf_qkr,dzmcddf_qkr,dzdlf_qkr)" +
                "values(@user_no,@htbh,@bh,@xh,@sxds,@zxrq,@fcrq,@xhds,@dzrq,@jshk,@zbxsf,@fzdlf,@fzzxf,@fzddf,@tlyf,@dzzxf,@dzmcddf,@dzdlf,@tlyfxj,@jshk_qkr,@zbxsf_qkr,@fzdlf_qkr,@fzzxf_qkr,@fzddf_qkr,@tlyf_qkr,@dzzxf_qkr,@dzmcddf_qkr,@dzdlf_qkr)";
                xsSqls.Add(sqlpara);
            }

            //foreach (var val in child2)
            //{
            //    sqlpara = new xsSqlParameter();
            //    sqlpara.AddSqlParameter(val);
            //    sqlpara.SqlConnectString = GlabalString.DBString;
            //    sqlpara.SQL = "insert into xs_QkrxxTable (user_no,name,zqkje,yhkje,syqkje,qkxm,phone,bz)" +
            //    "values(@user_no,@name,@zqkje,@yhkje,@syqkje,@qkxm,@phone,@bz)";
            //    xsSqls.Add(sqlpara);
            //}
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
            return SqlHelper.Execute(sqlpara);
        }

        public bool InsertQyxsckd(DirModel dml)
        {
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into xs_QyxsckdTable (user_no,ckbdh,htbh,zcsj,fmmc,gf,xf,ch,jsy,lxdh,wlmc,ckmz,ckpz,jbds,ckjz1,ckjz2,mj,hkgsje,yfyk,yj,fkzh)" +
                "values(@user_no,@ckbdh,@htbh,@zcsj,@fmmc,@gf,@xf,@ch,@jsy,@lxdh,@wlmc,@ckmz,@ckpz,@jbds,@ckjz1,@ckjz2,@mj,@hkgsje,@yfyk,@yj,@fkzh)";
            return SqlHelper.Execute(sqlpara);
        }

        public bool InsertCgrkd(DirModel dml)
        {
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into xs_CgrkdTable (user_no,hth,mkmc,gf,xf,wlmc,mj,yshtbh,cycd,zcbdh,tmdh,zcrq,ch,zcmz,zcpz,zcjz,jsmk,rkrq,rkbdh,rkmc,rkmz,rkpz,rkjz,ksds,yyds,yslhbz,kkbz,kkds,kkje,yfjsdw,yj,yfyf,yfyk,fkzh,jsyf,zfzh,shzt,yfjszt)" +
                "values(@user_no,@hth,@mkmc,@gf,@xf,@wlmc,@mj,@yshtbh,@cycd,@zcbdh,@tmdh,@zcrq,@ch,@zcmz,@zcpz,@zcjz,@jsmk,@rkrq,@rkbdh,@rkmc,@rkmz,@rkpz,@rkjz,@ksds,@yyds,@yslhbz,@kkbz,@kkds,@kkje,@yfjsdw,@yj,@yfyf,@yfyk,@fkzh,@jsyf,@zfzh,@shzt,@yfjszt)";
            return SqlHelper.Execute(sqlpara);
        }

        internal string UpdateMkzxzcd(DirModel dml, List<DirModel> child1)
        {
            List<xsSqlParameter> xsSqls = new List<xsSqlParameter>();
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "update xs_MkzxzcdTable set zcsj=@zcsj,cghth=@cghth,ghf=@ghf,shf=@shf,mkmc=@mkmc,wlmc=@wlmc,cydw=@cydw,yj=@yj,cgmj=@cgmj,xsmj=@xsmj where user_no=@user_no and djbh=@djbh";
            xsSqls.Add(sqlpara);

            sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "delete xs_MkzxzcdTable_Clxx  where user_no=@user_no and djbh=@djbh";
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

        internal string UpdateQydbckd(DirModel dml)
        {
            List<xsSqlParameter> xsSqls = new List<xsSqlParameter>();
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "delete xs_QydbckdTable where user_no=@user_no and ckbdh=@ckbdh and bh=@bh";
            xsSqls.Add(sqlpara);

            sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into xs_QydbckdTable (user_no,bh,ckbdh,zcsj,gsmc,fmmc,ch,jsy,lxdh,wlmc,ckmz,ckpz,ckjz,dcmj,dbje,yj,yfyk,fkzh,rkbdh)" +
                "values(@user_no,@bh,@ckbdh,@zcsj,@gsmc,@fmmc,@ch,@jsy,@lxdh,@wlmc,@ckmz,@ckpz,@ckjz,@dcmj,@dbje,@yj,@yfyk,@fkzh,@rkbdh)";
            xsSqls.Add(sqlpara);

            return SqlHelper.Execute(xsSqls);
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

        internal string UpdateTydbckd(DirModel dml, List<DirModel> child1)
        {
            List<xsSqlParameter> xsSqls = new List<xsSqlParameter>();
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "update xs_TydbckdTable set htbh=@htbh,gsmc=@gsmc,fmmc=@fmmc,wlmc=@wlmc,zcz=@zcz,zdz=@zdz,xlx=@xlx,xhdw=@xhdw where user_no=@user_no and bh=@bh";
            xsSqls.Add(sqlpara);

            sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "delete xs_Tydbckd_Jzxxx where user_no=@user_no and bh=@bh";
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

        public bool UpdateTydbcdkJzxxx(DirModel dml)
        {
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "update xs_Tydbckd_Jzxxx set xh=@xh,sxds=@sxds,zxrq=@zxrq,fcrq=@fcrq,dcmj=@dcmj,xhds=@xhds," +
                "dzrq=@dzrq,xhck=@xhck,zbxsf=@zbxsf,fzdlf=@fzdlf,fzzxf=@fzzxf,fzddf=@fzddf,tlyf=@tlyf,dzzxf=@dzzxf,dzmcddf=@dzmcddf,dzdlf=@dzdlf,drmj=@drmj" +
            " where user_no=@user_no and  bh=@bh and id=@id";
            return SqlHelper.Execute(sqlpara);
        }

        internal string UpdateQydbhd(DirModel dml)
        {
            List<xsSqlParameter> xsSqls = new List<xsSqlParameter>();
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "delete xs_QydbhdTable where user_no=@user_no and rkbdh=@rkbdh";
            xsSqls.Add(sqlpara);

            sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into xs_QydbhdTable (user_no,rkbdh,rksj,smmc,rkmz,rkpz,rkjz,ksds,yyds,yslhbz,yfkkbz,yfkkds,yfkkje,yfjsdw,yfyf,fykk,jsyf,drje,drmj,shzt,yfjszt)" +
                "values(@user_no,@rkbdh,@rksj,@smmc,@rkmz,@rkpz,@rkjz,@ksds,@yyds,@yslhbz,@yfkkbz,@yfkkds,@yfkkje,@yfjsdw,@yfyf,@fykk,@jsyf,@drje,@drmj,@shzt,@yfjszt)";
            xsSqls.Add(sqlpara);

            return SqlHelper.Execute(xsSqls);
        }

        public  string UpdateQyxsckd(DirModel dml)
        {
            List<xsSqlParameter> xsSqls = new List<xsSqlParameter>();
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "delete xs_QyxsckdTable where user_no=@user_no and ckbdh=@ckbdh";
            xsSqls.Add(sqlpara);

            sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into xs_QyxsckdTable (user_no,ckbdh,htbh,zcsj,fmmc,gf,xf,ch,jsy,lxdh,wlmc,ckmz,ckpz,jbds,ckjz1,ckjz2,mj,hkgsje,yfyk,yj,fkzh,rkbdh)" +
                "values(@user_no,@ckbdh,@htbh,@zcsj,@fmmc,@gf,@xf,@ch,@jsy,@lxdh,@wlmc,@ckmz,@ckpz,@jbds,@ckjz1,@ckjz2,@mj,@hkgsje,@yfyk,@yj,@fkzh,@rkbdh)";
            xsSqls.Add(sqlpara);

            return SqlHelper.Execute(xsSqls);
        }

        public string UpdateQykhhdlr(DirModel dml)
        {
            List<xsSqlParameter> xsSqls = new List<xsSqlParameter>();
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "delete xs_QykhhdlrTable where user_no=@user_no and rkbdh=@rkbdh";
            xsSqls.Add(sqlpara);

            sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into xs_QykhhdlrTable (user_no,rkbdh,rksj,rkmz,rkpz,rkjz,ksds,yyds,kd,yfhllh,yflhbz,yfkkds,yfkkje,yfjsdw,yfyf,fykk,jsyf,hkjsdw,jshk,tcbz,tcje,ywy,yfjszt,shzt)" +
                 "values(@user_no,@rkbdh,@rksj,@rkmz,@rkpz,@rkjz,@ksds,@yyds,@kd,@yfhllh,@yflhbz,@yfkkds,@yfkkje,@yfjsdw,@yfyf,@fykk,@jsyf,@hkjsdw,@jshk,@tcbz,@tcje,@ywy,@yfjszt,@shzt)";
            xsSqls.Add(sqlpara);

            return SqlHelper.Execute(xsSqls);
        }

        public string UpdateCgrkd(DirModel dml)
        {
            List<xsSqlParameter> xsSqls = new List<xsSqlParameter>();
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "delete xs_CgrkdTable where user_no=@user_no and hth=@hth";
            xsSqls.Add(sqlpara);

            sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "insert into xs_CgrkdTable (user_no,hth,mkmc,gf,xf,wlmc,mj,yshtbh,cycd,zcbdh,tmdh,zcrq,ch,zcmz,zcpz,zcjz,jsmk,rkrq,rkbdh,rkmc,rkmz,rkpz,rkjz,ksds,yyds,yslhbz,kkbz,kkds,kkje,yfjsdw,yj,yfyf,yfyk,fkzh,jsyf,zfzh,shzt,yfjszt)" +
                "values(@user_no,@hth,@mkmc,@gf,@xf,@wlmc,@mj,@yshtbh,@cycd,@zcbdh,@tmdh,@zcrq,@ch,@zcmz,@zcpz,@zcjz,@jsmk,@rkrq,@rkbdh,@rkmc,@rkmz,@rkpz,@rkjz,@ksds,@yyds,@yslhbz,@kkbz,@kkds,@kkje,@yfjsdw,@yj,@yfyf,@yfyk,@fkzh,@jsyf,@zfzh,@shzt,@yfjszt)";
            xsSqls.Add(sqlpara);
            
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

        public string UpdateTyxsckd(DirModel dml, List<DirModel> child1)
        {
            List<xsSqlParameter> xsSqls = new List<xsSqlParameter>();
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "update xs_TyxsckdTable  set htbh=@htbh,wtf=@wtf,stf=@stf,fmmc=@fmmc,wlmc=@wlmc,mj=@mj,zcz=@zcz,zdz=@zdz,xlx=@xlx,tcbz=@tcbz,tcje=@tcje,ywy=@ywy,xhdw=@xhdw where user_no=@user_no and bh=@bh and htbh=@htbh ";
            xsSqls.Add(sqlpara);

            sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "delete xs_Tyxsckd_Jzxxx  where user_no=@user_no and bh=@bh and htbh=@htbh";
            xsSqls.Add(sqlpara);

            foreach (var val in child1)
            {
                sqlpara = new xsSqlParameter();
                sqlpara.AddSqlParameter(val);
                sqlpara.SqlConnectString = GlabalString.DBString;
                sqlpara.SQL = "insert into xs_Tyxsckd_Jzxxx (user_no,htbh,bh,xh,sxds,zxrq,fcrq,xhds,dzrq,jshk,zbxsf,fzdlf,fzzxf,fzddf,tlyf,dzzxf,dzmcddf,dzdlf,tlyfxj,jshk_qkr,zbxsf_qkr,fzdlf_qkr,fzzxf_qkr,fzddf_qkr,tlyf_qkr,dzzxf_qkr,dzmcddf_qkr,dzdlf_qkr)" +
                "values(@user_no,@htbh,@bh,@xh,@sxds,@zxrq,@fcrq,@xhds,@dzrq,@jshk,@zbxsf,@fzdlf,@fzzxf,@fzddf,@tlyf,@dzzxf,@dzmcddf,@dzdlf,@tlyfxj,@jshk_qkr,@zbxsf_qkr,@fzdlf_qkr,@fzzxf_qkr,@fzddf_qkr,@tlyf_qkr,@dzzxf_qkr,@dzmcddf_qkr,@dzdlf_qkr)";
                xsSqls.Add(sqlpara);
            }
            return SqlHelper.Execute(xsSqls);
        }

        public bool UpdateTyxscdkJzxxx(DirModel dml)
        {
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "update xs_Tyxsckd_Jzxxx set xh=@xh,sxds=@sxds,zxrq=@zxrq,fcrq=@fcrq,xhds=@xhds,dzrq=@dzrq,jshk=@jshk,zbxsf=@zbxsf,fzdlf=@fzdlf,fzzxf=@fzzxf,fzddf=@fzddf," +
                "tlyf=@tlyf,dzzxf=@dzzxf,dzmcddf=@dzmcddf,dzdlf=@dzdlf,tlyfxj=@tlyfxj" +
            " where user_no=@user_no and htbh=@htbh and bh=@bh and id=@id";
            return SqlHelper.Execute(sqlpara);
        }

        public string InsertXsht(DirModel dml,List<DirModel>child1,List<DirModel>child2)
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

            return SqlHelper.Execute(xsSqls);
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

        public string InsertQyht(DirModel dml,List<DirModel> child1)
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

            return SqlHelper.Execute(xsSqls);
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

        public string InsertTyht(DirModel dml,List<DirModel> child1)
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
            return SqlHelper.Execute(xsSqls);
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

        public string InsertZlht(DirModel dml,List<DirModel>child1)
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
            return SqlHelper.Execute(xsSqls);
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
        public string UpdateCght(DirModel dml, List<DirModel> child1, List<DirModel> child2)
        {

            List<xsSqlParameter> xsSqls = new List<xsSqlParameter>();
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "update xs_CghtTable set htlx=@htlx,qdrq=@qdrq,dfhth=@dfhth,gfmc=@gfmc,xfmc=@xfmc,hkjsyj=@hkjsyj,hklhlx=@hklhlx,hklhbz=@hklhbz,kpxx=@kpxx,jhsjQ=@jhsjQ,jhsjZ=@jhsjZ,hkjsfs=@hkjsfs," +
                "jhdd=@jhdd,yffkfs=@yffkfs,mkmc=@mkmc,bz=@bz where htbh=@htbh and user_no=@userid";
            xsSqls.Add(sqlpara);

            sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "delete xs_CghtTable_Jgxx  where htbh=@htbh and user_no=@userid";
            xsSqls.Add(sqlpara);

            sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "delete xs_CghtTable_Jgxx  where htbh=@htbh and user_no=@userid";
            xsSqls.Add(sqlpara);

            sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "delete xs_CghtTable_Zlbz  where htbh=@htbh and user_no=@userid";
            xsSqls.Add(sqlpara);

            foreach (var val in child1)
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

        public string UpdateQyht(DirModel dml, List<DirModel> child1)
        {
            List<xsSqlParameter> xsSqls = new List<xsSqlParameter>();
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "update xs_QyhtTable set htlx=@htlx,qdrq=@qdrq,dfhth=@dfhth,wtf=@wtf,stf=@stf,kplx=@kplx,zxqxQ=@zxqxQ,zxqxZ=@zxqxZ where htbh=@htbh and user_no=@userid";
            xsSqls.Add(sqlpara);

            sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "delete xs_QyhtTable_Jgxx  where htbh=@htbh and user_no=@userid";
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

            return SqlHelper.Execute(xsSqls);
        }

        public string UpdateTyht(DirModel dml, List<DirModel> child1)
        {
            List<xsSqlParameter> xsSqls = new List<xsSqlParameter>();
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "update xs_TyhtTable set htlx=@htlx,qdrq=@qdrq,wtf=@wtf,stf=@stf,fmmc=@fmmc,wlmc=@wlmc,zxqxQ=@zxqxQ,zxqxZ=@zxqxZ,zcz=@zcz,zdz=@zdz,xlx=@xlx,sl=@sl where htbh=@htbh and user_no=@userid";
            xsSqls.Add(sqlpara);

            sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "delete xs_TyhtTable_Jgxx  where htbh=@htbh and user_no=@userid";
            xsSqls.Add(sqlpara);

            foreach (var val in child1)
            {
                sqlpara = new xsSqlParameter();
                sqlpara.AddSqlParameter(val);
                sqlpara.SqlConnectString = GlabalString.DBString;
                sqlpara.SQL = "insert into xs_TyhtTable_Jgxx (user_no,htbh,gsmc,dfhth,kplx,zbxsf,dlf,zxf,sfzdd,tlyf,dzzxf,dzmcddf,dzdlf)" +
                "values(@user_no,@htbh,@gsmc,@dfhth,@kplx,@zbxsf,@dlf,@zxf,@sfzdd,@tlyf,@dzzxf,@dzmcddf,@dzdlf)";
                xsSqls.Add(sqlpara);
            }
            return SqlHelper.Execute(xsSqls);
        }

        public string UpdateWtjghtht(DirModel dml, List<DirModel> child1)
        {
            List<xsSqlParameter> xsSqls = new List<xsSqlParameter>();
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "update xs_WtjgTable set htlx=@htlx,qdrq=@qdrq,wtf=@wtf,stf=@stf,kplx=@kplx,zxqxQ=@zxqxQ,zxqxZ=@zxqxZ where htbh=@htbh and user_no=@userid";
            xsSqls.Add(sqlpara);

            sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "delete xs_WtjghtTable_Jgxx  where htbh=@htbh and user_no=@userid";
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
            return SqlHelper.Execute(xsSqls);
        }

        public string UpdateXsht(DirModel dml, List<DirModel> child1, List<DirModel> child2)
        {
            List<xsSqlParameter> xsSqls = new List<xsSqlParameter>();
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "update xs_XshtTable set htlx=@htlx,qdrq=@qdrq,dfhth=@dfhth,gfmc=@gfmc,xfmc=@xfmc,hkjsyj=@hkjsyj,hklhlx=@hklhlx,hklhbz=@hklhbz,kpxx=@kpxx,jhsjQ=@jhsjQ,jhsjZ=@jhsjZ," +
                "hkjsfs=@hkjsfs,fhdd=@fhdd,yffkfs=@yffkfs,mkmc=@mkmc,kzbz=@kzbz,lxdh=@lxdh,bz=@bz where htbh=@htbh and user_no=@userid";
            xsSqls.Add(sqlpara);

            sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "delete xs_XshtTable_Jgxx  where htbh=@htbh and user_no=@userid";

            sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "delete xs_XshtTable_Zlbz  where htbh=@htbh and user_no=@userid";
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

            return SqlHelper.Execute(xsSqls);
        }

        public string UpdateZlht(DirModel dml, List<DirModel> child1)
        {
            List<xsSqlParameter> xsSqls = new List<xsSqlParameter>();
            xsSqlParameter sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "update xs_ZlhtTable set htlx=@htlx,qdrq=@qdrq,czf=@czf,czf2=@czf2,czdd=@czdd,zlqxQ=@zlqxQ,zlqxZ=@zlqxZ,yj=@yj where htbh=@htbh and user_no=@userid";
            xsSqls.Add(sqlpara);

            sqlpara = new xsSqlParameter();
            sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sqlpara.SQL = "delete xs_ZlhtTable_Zjxx  where htbh=@htbh and user_no=@userid";
            xsSqls.Add(sqlpara);

            foreach (var val in child1)
            {
                sqlpara = new xsSqlParameter();
                sqlpara.AddSqlParameter(val);
                sqlpara.SqlConnectString = GlabalString.DBString;
                sqlpara.SQL = "insert into xs_ZlhtTable_Zjxx (user_no,htbh,qsrq,zzrq,zj,fktk,zxzt,bz)" +
                "values(@user_no,@htbh,@qsrq,@zzrq,@zj,@fktk,@zxzt,@bz)";
                xsSqls.Add(sqlpara);
            }
            return SqlHelper.Execute(xsSqls);
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

        public string QueryGongSiDropList(string tableName, string[] arrList,int type)
        {
            string sql = @"select ";
            for (int i = 0; i < arrList.Length - 1; i++)
            {
                sql += arrList[i] + " , ";
            }
            sql += arrList[arrList.Length - 1] + " from " + tableName;
            if (type == 1)
            {
                sql = string.Format("{0} where type='客户(需方)'", sql);
            }
            else if (type == 2)
            {
                sql = string.Format("{0} where type='供应商(供方)'", sql);
            }
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

        public string QueryHtOrder(QueryClass qc)
        {
            //string sql = @"select * from xs_CghtTable where htbh='"+qc.htbh+"' or ( qdrq>='"+ qc.qdrqQ+
            //    "' and qdrq<='"+ qc.qdrqZ+"' ) or gfmc='"+qc.gfmc+
            //     "' or htbh in(select htbh from xs_CghtTable_Jgxx where  kpmj>="+qc.kpmj+" or zt='"+ qc.zt+"')";

            string sql = string.Format(@"select * from {0} where ({1}='{2}' {6} (qdrq>='{3}' and qdrq<='{4}')) or 1={5}", qc.tableName, qc.selectedKey, qc.selectedItem, qc.qdrqQ, qc.qdrqZ,qc.IsAll,qc.selectedCon);
            return sql;
        }

        public string QueryHt2Order(QueryClass qc)
        {
            //string sql = @"select * from xs_CghtTable where htbh='"+qc.htbh+"' or ( qdrq>='"+ qc.qdrqQ+
            //    "' and qdrq<='"+ qc.qdrqZ+"' ) or gfmc='"+qc.gfmc+
            //     "' or htbh in(select htbh from xs_CghtTable_Jgxx where  kpmj>="+qc.kpmj+" or zt='"+ qc.zt+"')";

            string sql = string.Format(@"select * from {0} where  ({1}='{2}' {7} ({6}>='{3}' and  {6}<='{4}')) or 1={5}", qc.tableName, qc.selectedKey, qc.selectedItem, qc.qdrqQ, qc.qdrqZ, qc.IsAll,qc.selectedTimeKey,qc.selectedCon);
            return sql;
        }

        public string QueryHt3Order(QueryClass qc)
        {
            //string sql = @"select * from xs_CghtTable where htbh='"+qc.htbh+"' or ( qdrq>='"+ qc.qdrqQ+
            //    "' and qdrq<='"+ qc.qdrqZ+"' ) or gfmc='"+qc.gfmc+
            //     "' or htbh in(select htbh from xs_CghtTable_Jgxx where  kpmj>="+qc.kpmj+" or zt='"+ qc.zt+"')";

            string sql = string.Format(@"select * from {0} where ({1}='{2}') or 1={5}", qc.tableName, qc.selectedKey, qc.selectedItem, qc.qdrqQ, qc.qdrqZ, qc.IsAll, qc.selectedTimeKey, qc.selectedCon);
            return sql;
        }

        public string QueryCghtChildTable(QueryClass qc)
        {
            string sql=@"select * from  "+qc.tableName+ " where user_no='"+qc.user_no+"' and htbh='"+qc.htbh+"'";
            return sql;
        }

        public string QueryQkrxxTable(QueryClass qc)
        {
            string sql = @"select * from  " + qc.tableName + " where user_no='" + qc.user_no  + "'";
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
            string sql = string.Format(@"select * from (select xf dwmc,zcsj rq,ch,ckjz1 ckdw,rkjz dhdw,kd,hkjsdw xsjsdw,mj, jshk xsjsje  
                        from xs_QyxsckdTable a left join xs_QykhhdlrTable b on a.rkbdh=b.rkbdh) tb where (tb.dwmc='{0}' and rq>='{1}' and rq<='{2}') or 1={3}", qc.selectedItem, qc.qdrqQ, qc.qdrqZ,qc.IsAll); 
            return sql;
        }

        public string QueryQykhhdlrOrder(QueryClass qc)
        {
            string sql = @"select xf dwmc,zcsj rq,ch,ckjz1 ckdw,rkjz dhdw,kd,hkjsdw xsjsdw,mj, jshk xsjsje  
                        from xs_QyxsckdTable a left join xs_QykhhdlrTable b on a.rkbdh=b.rkbdh
                        ";
            return sql;
        }

        public string QueryTyxsckdOrder(QueryClass qc)
        {
            string sql = string.Format(@"select * from (select stf dwmc,zxrq rq,xh ch,sxds ckdw,xhds dhdw,null kd,xhds xsjsdw,mj,jshk xsjsje  
        from xs_Tyxsckd_Jzxxx a right join xs_TyxsckdTable b on a.bh=b.bh) tb where 1={3} or (tb.dwmc='{0}' and rq>='{1}' and rq<='{2}')", qc.selectedItem,qc.qdrqQ,qc.qdrqZ,qc.IsAll);
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
            string sql = string.Format(@"select * from (select shf dwmc,zcsj rq,ch,zcjz ckdw,null dhdw,null kd,zcjz xsjsdw,xsmj mj,xsjsje  
                            from xs_MkzxzcdTable a right join xs_MkzxzcdTable_Clxx b on a.djbh=b.djbh) tb  where (tb.dwmc='{0}' and rq>='{1}' and rq<='{2}') or 1={3}", qc.selectedItem,qc.qdrqQ,qc.qdrqZ,qc.IsAll);
            return sql;
        }

        public string QuerySkdOrder(QueryClass qc)
        {
            string sql = string.Format(@"select * from (select fkdw dwmc,ldrq rq,zy,je skje,jsfs skfs,skzhbh skzh  
                            from xs_SkdTable a right join xs_SkdTable_Fb b on a.bh=b.bh and a.user_no=b.user_no) tb where (tb.dwmc='{0}' and rq>='{1}' and rq<='{2}') or 1={3}", qc.selectedItem, qc.qdrqQ, qc.qdrqZ,qc.IsAll);
            return sql;
        }

        public string QueryFkdOrder(QueryClass qc)
        {
            string sql = string.Format(@"select * from (select skdw dwmc,ldrq rq,zy,je skje,jsfs skfs,fkzhbh skzh  
                            from xs_FkdTable a right join xs_FkdTable_Fb b on a.bh=b.bh and a.user_no=b.user_no) tb where 1={3} or (tb.dwmc='{0}' and rq>='{1}' and rq<='{2}')", qc.selectedItem, qc.qdrqQ, qc.qdrqZ,qc.IsAll);
            return sql;
        }
        


        public bool DeleteData(DirModel dml, string tablename,string key)
        {
            string[] ckb = dml.GetValue<string[]>("@htbhArr");
            string sql = "";
            xsSqlParameter sqlpara = new xsSqlParameter();
          //  sqlpara.AddSqlParameter(dml);
            sqlpara.SqlConnectString = GlabalString.DBString;
            sql = @"delete from " + tablename + " where "+key+ "='@htbhArr'";
            for (int i = 0; i < ckb.Length; i++)
            {
                //sql += ckb[i];
                //if (i == ckb.Length - 1)
                //    sql += "'";
                //else
                //    sql += "' or "+key+"='";
                sql = @"delete from " + tablename + " where " + key + "='"+ ckb[i]+"'";
                sqlpara.SQL = sql;
                SqlHelper.Execute(sqlpara);
            }
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