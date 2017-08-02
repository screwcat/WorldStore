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
    /// �������ݿ�ʵ��
    /// </summary>
    public class DBInstance : EntityBase<DBInstance>
    {
        /// <summary>
        /// ժҪ�����Ӵ�����
        /// </summary>
        static string CONNECTIONSTRING_NAME = "APPDBSTRING";
        /// <summary>
        /// ժҪ���������ݿ�ʵ��
        /// </summary>
        /// <param name="connectionName">���Ӵ�����</param>
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
        /// ժҪ���������ݿ�����
        /// </summary>
        /// <param name="conString">���Ӵ�����</param>
        /// <returns>���ݿ�����</returns>
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
        ///  ժҪ���������ݿ�����
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
