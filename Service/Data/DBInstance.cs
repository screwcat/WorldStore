using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Configuration;
using System.Data.Common;
using System.Data.OleDb;
using Service.Common.Entity;

namespace Service.Common.Data
{
    /// <summary>
    /// 创建数据库实例
    /// </summary>
    public class DBInstance : EntityBase<DBInstance>
    {
        /// <summary>
        /// 摘要：连接串名称
        /// </summary>
        static string CONNECTIONSTRING_NAME = "APPDBSTRING";
        /// <summary>
        /// 摘要：创建数据库实例
        /// </summary>
        /// <param name="connectionName">连接串名称</param>
        public static Database CreateInstance(string conString)
        {
            if (object.Equals(null, conString))
            {
                return DatabaseFactory.CreateDatabase(CONNECTIONSTRING_NAME);
            }
            else if (conString != string.Empty)
            {
                return DatabaseFactory.CreateDatabase(conString);
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 摘要：创建数据库连接
        /// </summary>
        /// <param name="conString">连接串名称</param>
        /// <returns>数据库连接</returns>
        public static DbConnection CreateDbConnection(string conString)
        {
            Database dbInstance;
            if (object.Equals(null, conString))
            {
                dbInstance = DBInstance.CreateInstance(CONNECTIONSTRING_NAME); ;
            }
            else
            {
                dbInstance = DBInstance.CreateInstance(conString);
            }
            return dbInstance.CreateConnection() as DbConnection;
        }
        /// <summary>
        ///  摘要：创建数据库连接
        /// </summary>
        /// <returns></returns>
        public static DbConnection CreateDbConnection()
        { 
            return CreateDbConnection(null);

        }
        public static OleDbConnection CreateOleDbConnection()
        {
            return new OleDbConnection(ConfigurationManager.ConnectionStrings[CONNECTIONSTRING_NAME].ToString());
        }
    }
}
