//****************************************************************************************
//author xiaoshuai
//blog：http://www.cnblogs.com/xiaoshuai1992
//create: 2014/6/20
//function： operate db whith sql
//*****************************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace xsFramework.SqlServer
{
    public class SqlHelper
    {
        /// <summary>
        /// get dataset
        /// </summary>
        /// <param name="strsql">sql string</param>
        /// <param name="SqlPara">parameter</param>
        /// <returns></returns>
        public static DataSet GetDataSet(xsSqlParameter sqlparm)
        {
            DbInParameter dbInPara = new DbInParameter();
            dbInPara.SQL = sqlparm.SQL;

            //add sql parameter
            dbInPara.AddParameter(sqlparm.SqlPara);

            DbAccess Dao = new DbAccess();
            Dao.Open(sqlparm.SqlConnectString);
            DataSet dsRtn = Dao.ExecuteQuery(dbInPara).ReturnDataSet;
            Dao.Close();
            return dsRtn;
        }

        /// <summary>
        /// get datatable
        /// </summary>
        /// <param name="sqlparm"></param>
        /// <returns></returns>
        public static DataTable GetDataTable(xsSqlParameter sqlparm)
        {
            DataSet ds = GetDataSet(sqlparm);
            if (ds.Tables.Count > 0)
            {
                return ds.Tables[0];
            }
            else
            {
                return new DataTable();
            }
        }

        /// <summary>
        /// exist data
        /// </summary>
        /// <param name="sqlparm">exist:true,else:false</param>
        /// <returns></returns>
        public static bool Exist(xsSqlParameter sqlparm)
        {
            return GetDataTable(sqlparm).Rows.Count > 0;
        }

        /// <summary>
        /// execute sql 
        /// </summary>
        /// <param name="sqlparm"></param>
        /// <returns></returns>
        public static bool Execute(xsSqlParameter sqlparm)
        {
            DbInParameter dbInPara = new DbInParameter
            {
                SQL = sqlparm.SQL
            };

            //add sql parameter
            dbInPara.AddParameter(sqlparm.SqlPara);

            DbAccess Dao = new DbAccess();
            try
            {
                Dao.Open(sqlparm.SqlConnectString);
                Dao.BeginTrans();
                Dao.ExecuteNoQuery(dbInPara);
                Dao.Commit();
                Dao.Close();
                return true;
            }
            catch(Exception e)
            {
                Dao.RollBack();
                return false;
            }            
        }

        /// <summary>
        /// execute sql 
        /// </summary>
        /// <param name="sqlparm"></param>
        /// <returns></returns>
        public static string Execute(List<xsSqlParameter> sqlparmList)
        {
            DbInParameter dbInPara;
            DbAccess Dao = new DbAccess();
            try
            {
                Dao.Open(sqlparmList[0].SqlConnectString);
                Dao.BeginTrans();
                foreach(var val in sqlparmList)
                {
                    dbInPara = new DbInParameter
                    {
                        SQL = val.SQL
                    };
                    dbInPara.AddParameter(val.SqlPara);
                    Dao.ExecuteNoQuery(dbInPara);
                }
                
                Dao.Commit();
                Dao.Close();
                return "";
            }
            catch(Exception e)
            {
                Dao.RollBack();
                return e.Message.Replace("\r", string.Empty).Replace("\n", string.Empty);
            }
        }
    }
}
