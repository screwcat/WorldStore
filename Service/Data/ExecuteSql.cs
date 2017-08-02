using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;
using System.Data.Common;
using Service.Common.Log;
using System.Data.OleDb;
using Service.DBUtility;
using System.Data.SqlClient;

namespace Service.Common.Data
{
    /// <summary>
    /// ִ��SQL���
    /// </summary>
    public class ExecuteSql
    {
        static Database dbInstance;
        static Exception NoInstanceException = new Exception("DataBaseʵ�������ڣ���ȷ�ϵ���CreateInstance��̬����");
        #region ִ�в���������SQL���
        /// <summary>
        /// ժҪ��ִ���޷���ֵһ��SQL���
        /// </summary>
        /// <param name="conString">���Ӵ����ƣ���Ĭ�����Ӵ����ƿ���Ϊnull</param>
        /// <param name="sql">SQL���</param>
        /// <returns>Ӱ������</returns>
        public static int ExeComSqlForNonQuery(string conString, string sql)
        {
            dbInstance = DBInstance.CreateInstance(conString);
            return dbInstance.ExecuteNonQuery(CommandType.Text, sql); ;
        }
        /// <summary>
        /// ժҪ��ִ���޷���ֵһ��SQL���
        /// </summary>
        /// <param name="sql">SQL���</param>
        /// <returns>Ӱ������</returns>
        public static int ExeComSqlForNonQuery(string sql)
        {
            return ExeComSqlForNonQuery(null, sql);
        }
        /// <summary>
        /// ժҪ��ִ��һ��SQL��䷵�����ݼ� 
        /// </summary>
        /// <param name="conString">���Ӵ����ƣ���Ĭ�����Ӵ����ƿ���Ϊnull</param>
        /// <param name="sql">SQL���</param>
        /// <returns>���ݼ� </returns>
        public static DataSet ExeComSqlForDataSet(string conString, string sql)
        {
            dbInstance = DBInstance.CreateInstance(conString);
            return dbInstance.ExecuteDataSet(CommandType.Text, sql);
        }
        /// <summary>
        /// ժҪ��ִ��һ��SQL��䷵�����ݼ� 
        /// </summary>
        /// <param name="sql">SQL���</param>
        /// <returns>���ݼ� </returns>
        public static DataSet ExeComSqlForDataSet(string sql)
        {
            return ExeComSqlForDataSet(null, sql);
        }
        /// <summary>
        /// ժҪ��ִ��һ��SQL��䷵�ؾۺϺ���ֵ����һ�е�һ�У� 
        /// </summary>
        /// <param name="conString">���Ӵ����ƣ���Ĭ�����Ӵ����ƿ���Ϊnull</param>
        /// <param name="sql">SQL���</param>
        /// <returns>���ݼ���һ�е�һ��</returns>
        public static object ExeComSqlForScalar(string conString, string sql)
        {
            dbInstance = DBInstance.CreateInstance(conString);
            return dbInstance.ExecuteScalar(CommandType.Text, sql);
        }
        /// <summary>
        /// ժҪ��ִ��һ��SQL��䷵�ؾۺϺ���ֵ����һ�е�һ�У� 
        /// </summary>
        /// <param name="sql">SQL���</param>
        /// <returns>���ݼ���һ�е�һ��</returns>
        public static object ExeComSqlForScalar(string sql)
        {
            return ExeComSqlForScalar(null, sql);
        }
        #endregion

        #region ִ�д�������SQL���
        /// <summary>
        /// ����sql���Ĳ���
        /// </summary>
        /// <param name="stVariables">��������</param>
        /// <param name="parameterValues">����ֵ</param>
        /// <param name="cmd"></param>
        private static void CommandParametersAdd(string[] stVariables, object[] parameterValues, ref DbCommand cmd, bool isbool = false)
        {
            for (int i = 0; i < stVariables.Length; i++)
            {
                DbParameter DbP = cmd.CreateParameter() as DbParameter;
                DbP.DbType = DbType.String;
                DbP.ParameterName = stVariables[i];
                if (isbool && DbP.ParameterName == "@return")
                    DbP.Direction = ParameterDirection.ReturnValue;
                DbP.Value = parameterValues[i];
                cmd.Parameters.Add(DbP);
            }
        }
        /// <summary>
        /// ����sql���Ĳ���
        /// </summary>
        /// <param name="stVariables">��������</param>
        /// <param name="parameterValues">����ֵ</param>
        /// <param name="cmd"></param>
        private static void CommandParametersAdd(List<string> stVariables, List<object> parameterValues, ref DbCommand cmd)
        {
            for (int i = 0; i < stVariables.Count; i++)
            {
                DbParameter DbP = cmd.CreateParameter() as DbParameter;

                if (parameterValues[i].GetType().FullName == "System.Byte[]")
                {
                    DbP.DbType = DbType.Binary;
                }
                else
                {
                    DbP.DbType = DbType.String;
                }
                DbP.ParameterName = stVariables[i];
                DbP.Value = parameterValues[i];
                cmd.Parameters.Add(DbP);
            }
        }
        /// <summary>
        /// ժҪ��ִ���޷���ֵ�̶���������SQL��䣨��������
        /// </summary>
        /// <param name="conString">���Ӵ����ƣ���Ĭ�����Ӵ����ƿ���Ϊnull</param>
        /// <param name="sql">SQL���</param>
        /// <param name="parameterNames">��������</param>
        /// <param name="parameterValues">����ֵ</param>
        /// <returns>Ӱ������</returns>
        public static int ExeParaSqlForNonQuery(string conString, string sql, string[] parameterNames, params object[] parameterValues)
        {
            dbInstance = DBInstance.CreateInstance(conString);
            int iReturn = 0;
            DbConnection dbconnection = dbInstance.CreateConnection() as DbConnection;
            DbCommand dbcommand = dbconnection.CreateCommand() as DbCommand;
            dbcommand.Connection = dbconnection;
            dbconnection.Open();
            try
            {
                dbcommand.CommandText = sql;
                CommandParametersAdd(parameterNames, parameterValues, ref dbcommand);
                iReturn = dbcommand.ExecuteNonQuery();
            }
            catch (Exception ex) { throw ex; }
            finally
            {
                dbconnection.Close();
            }
            return iReturn;
        }
        /// <summary>
        /// ժҪ��ִ���޷���ֵ�̶���������SQL��䣨��������
        /// </summary>
        /// <param name="sql">SQL���</param>
        /// <param name="parameterNames">��������</param>
        /// <param name="parameterValues">����ֵ</param>
        /// <returns>Ӱ������</returns>
        public static int ExeParaSqlForNonQuery(string sql, string[] parameterNames, params object[] parameterValues)
        {
            return ExeParaSqlForNonQuery(null, sql, parameterNames, parameterValues);
        }
        /// <summary>
        /// ժҪ��ִ���޷���ֵ���̶���������SQL��䣨��������
        /// </summary>
        /// <param name="conString">���Ӵ����ƣ���Ĭ�����Ӵ����ƿ���Ϊnull</param>
        /// <param name="sql">SQL���</param>
        /// <param name="parameterNames">��������</param>
        /// <param name="parameterValues">����ֵ</param>
        /// <returns>Ӱ������/������е�һ�еĵ�һ��</returns>
        public static int ExeParaSqlForNonQuery(string conString, string sql, List<string> parameterNames, List<object> parameterValues)
        {
            dbInstance = DBInstance.CreateInstance(conString);
            int iReturn = 0;
            DbConnection dbconnection = dbInstance.CreateConnection() as DbConnection;
            DbCommand dbcommand = dbconnection.CreateCommand() as DbCommand;
            dbcommand.Connection = dbconnection;
            dbconnection.Open();
            try
            {
                dbcommand.CommandText = sql;
                CommandParametersAdd(parameterNames, parameterValues, ref dbcommand);
                //iReturn = dbcommand.ExecuteNonQuery();
                iReturn = Convert.ToInt32(dbcommand.ExecuteScalar());
            }
            catch (Exception ex) { throw ex; }
            finally
            {
                dbconnection.Close();
            }
            return iReturn;
        }
        /// <summary>
        /// ժҪ��ִ���޷���ֵ�̶���������SQL��䣨��������
        /// </summary>
        /// <param name="sql">SQL���</param>
        /// <param name="parameterNames">��������</param>
        /// <param name="parameterValues">����ֵ</param>
        /// <returns>Ӱ������</returns>
        public static int ExeParaSqlForNonQuery(string sql, List<string> parameterNames, List<object> parameterValues)
        {
            return ExeParaSqlForNonQuery(null, sql, parameterNames, parameterValues);
        }
        /// <summary>
        /// ժҪ��ִ���޷���ֵ�̶���������SQL���(������)
        /// </summary> 
        /// <param name="sql">SQL���</param>
        /// <param name="conString">���ݿ�����</param>
        /// <param name="transaction">�������</param>
        /// <param name="parameterNames">��������</param>
        /// <param name="parameterValues">����ֵ</param>
        /// <returns>Ӱ������</returns>
        public static int ExeParaSqlForNonQuery(string sql, DbConnection dbConnection, DbTransaction transaction, string[] parameterNames, params object[] parameterValues)
        {
            DbCommand dbcommand = dbConnection.CreateCommand() as DbCommand;
            dbcommand.Connection = dbConnection;
            dbcommand.Transaction = transaction;
            dbcommand.CommandText = sql;
            CommandParametersAdd(parameterNames, parameterValues, ref dbcommand);
            return dbcommand.ExecuteNonQuery();
        }
        /// <summary>
        /// ժҪ��ִ���޷���ֵ����SQL���
        /// </summary>
        /// <param name="conString">���Ӵ����ƣ���Ĭ�����Ӵ����ƿ���Ϊnull</param>
        /// <param name="sql">SQL���</param>
        /// <param name="parameterNames">��������</param>
        /// <param name="parameterValues">����ֵ</param>
        /// <returns>Ӱ������</returns>
        public static int ExeParaSqlForScalar(string conString, string sql, string[] parameterNames, params object[] parameterValues)
        {
            dbInstance = DBInstance.CreateInstance(conString);
            int iResult = 0;
            DbConnection dbconnection = dbInstance.CreateConnection() as DbConnection;
            DbCommand dbcommand = dbconnection.CreateCommand() as DbCommand;
            dbcommand.Connection = dbconnection;
            dbconnection.Open();
            try
            {
                dbcommand.CommandText = sql;
                CommandParametersAdd(parameterNames, parameterValues, ref dbcommand);
                iResult = (int)dbcommand.ExecuteScalar();
            }
            catch (Exception ex) { throw ex; }
            finally
            {
                dbconnection.Close();
            }
            return iResult;
        }
        /// <summary>
        /// ժҪ��ִ���޷���ֵ���̶���������SQL��䣨��������
        /// </summary>
        /// <param name="conString">���Ӵ����ƣ���Ĭ�����Ӵ����ƿ���Ϊnull</param>
        /// <param name="sql">SQL���</param>
        /// <param name="parameterNames">��������</param>
        /// <param name="parameterValues">����ֵ</param>
        /// <returns>Ӱ������</returns>
        public static int ExeParaSqlForScalar(string conString, string sql, List<string> parameterNames, List<object> parameterValues)
        {
            dbInstance = DBInstance.CreateInstance(conString);
            int iReturn = 0;
            DbConnection dbconnection = dbInstance.CreateConnection() as DbConnection;
            DbCommand dbcommand = dbconnection.CreateCommand() as DbCommand;
            dbcommand.Connection = dbconnection;
            dbconnection.Open();
            try
            {
                if (!sql.ToUpper().Contains("COUNT"))
                    sql = "Select Count(*) " + sql.Substring(sql.ToUpper().IndexOf("FROM"));
                dbcommand.CommandText = sql;
                CommandParametersAdd(parameterNames, parameterValues, ref dbcommand);
                iReturn = (int)dbcommand.ExecuteScalar();
            }
            catch (Exception ex) { throw ex; }
            finally
            {
                dbconnection.Close();
            }
            return iReturn;
        }
        /// <summary>
        /// ժҪ��ִ���޷���ֵ����SQL���
        /// </summary>
        /// <param name="sql">SQL���</param>
        /// <param name="parameterNames">��������</param>
        /// <param name="parameterValues">����ֵ</param>
        /// <returns>Ӱ������</returns>
        public static int ExeParaSqlForScalar(string sql, List<string> parameterNames, List<object> parameterValues)
        {
            return ExeParaSqlForScalar(null, sql, parameterNames, parameterValues);
        }
        /// <summary>
        /// ժҪ��ִ���޷���ֵ����SQL���
        /// </summary>
        /// <param name="sql">SQL���</param>
        /// <param name="parameterNames">��������</param>
        /// <param name="parameterValues">����ֵ</param>
        /// <returns>Ӱ������</returns>
        public static int ExeParaSqlForScalar(string sql, string[] parameterNames, params object[] parameterValues)
        {
            return ExeParaSqlForScalar(null, sql, parameterNames, parameterValues);
        }
        /// <summary>
        /// ժҪ��ִ�в���SQL��䷵�����ݼ�
        /// </summary>
        /// <param name="conString">���Ӵ����ƣ���Ĭ�����Ӵ����ƿ���Ϊnull</param>
        /// <param name="sql">SELECT SQL���</param>
        /// <param name="parameterNames">��������</param>
        /// <param name="parameterValues">����ֵ</param>
        /// <returns>���ݼ�</returns>
        public static DataSet ExeParaSqlForDataSet(string conString, string sql, string[] parameterNames, params object[] parameterValues)
        {
            DataSet dsResult = new DataSet();
            dbInstance = DBInstance.CreateInstance(conString);
            DbConnection dbconnection = dbInstance.CreateConnection() as DbConnection;
            DbCommand dbcommand = dbconnection.CreateCommand() as DbCommand;
            dbcommand.Connection = dbconnection;
            dbconnection.Open();
            try
            {
                dbcommand.CommandText = sql;
                CommandParametersAdd(parameterNames, parameterValues, ref dbcommand);
                dsResult = dbInstance.ExecuteDataSet(dbcommand);
            }
            catch (Exception ex) { throw ex; }
            finally
            {
                dbconnection.Close();
            }
            return dsResult;
        }
        public static DataSet ExeParaSqlForDataSet(string sql, string[] parameterNames, params object[] parameterValues)
        {
            return ExeParaSqlForDataSet(null, sql, parameterNames, parameterValues);
        }
        /// <summary>
        /// ժҪ��ִ�з������ݼ����̶���������SQL��䣨��������
        /// </summary>
        /// <param name="conString">���Ӵ����ƣ���Ĭ�����Ӵ����ƿ���Ϊnull</param>
        /// <param name="sql">SELECT SQL���</param>
        /// <param name="parameterNames">��������</param>
        /// <param name="parameterValues">����ֵ</param>
        /// <returns>���ݼ�</returns>
        public static DataSet ExeParaSqlForDataSet(string conString, string sql, List<string> parameterNames, List<object> parameterValues)
        {
            DataSet dsResult = new DataSet();
            dbInstance = DBInstance.CreateInstance(conString);
            if (object.Equals(null, dbInstance))
            {
                return null;
            }
            DbConnection dbconnection = dbInstance.CreateConnection() as DbConnection;
            DbCommand dbcommand = dbconnection.CreateCommand() as DbCommand;
            dbcommand.Connection = dbconnection;
            dbconnection.Open();
            try
            {
                dbcommand.CommandText = sql;
                CommandParametersAdd(parameterNames, parameterValues, ref dbcommand);
                dsResult = dbInstance.ExecuteDataSet(dbcommand);
            }
            catch (Exception ex) { throw ex; }
            finally
            {
                dbconnection.Close();
            }
            return dsResult;
        }
        /// <summary>
        /// ժҪ��ִ�з������ݼ����̶���������SQL��䣨��������
        /// </summary>
        /// <param name="sql">SELECT SQL���</param>
        /// <param name="parameterNames">��������</param>
        /// <param name="parameterValues">����ֵ</param>
        /// <returns>���ݼ�</returns>
        public static DataSet ExeParaSqlForDataSet(string sql, List<string> parameterNames, List<object> parameterValues)
        {
            return ExeParaSqlForDataSet(null, sql, parameterNames, parameterValues);
        }


        /// <summary>
        /// ִ�д洢����
        /// </summary>
        /// <param name="procedureName">�洢������</param>
        /// <param name="parameterValues">����</param>
        /// <returns>Ӱ������</returns>
        public static int ExeProcedureNonQuery(string procedureName, params object[] parameterValues)
        {
            ReturnMessage rm = new ReturnMessage(true);
            if (object.Equals(null, dbInstance))
                throw NoInstanceException;
            int iReturn = dbInstance.ExecuteNonQuery(procedureName, parameterValues);
            return iReturn;
        }
        public static int ExeProcedureNonQuery(string procedureName, string[] parameterNames, params object[] parameterValues)
        {
            dbInstance = DBInstance.CreateInstance(null);
            int iResult = 0;
            DbConnection dbconnection = dbInstance.CreateConnection() as DbConnection;
            DbCommand dbcommand = dbconnection.CreateCommand() as DbCommand;
            dbcommand.Connection = dbconnection;
            dbconnection.Open();
            try
            {
                dbcommand.CommandText = procedureName;
                dbcommand.CommandType = CommandType.StoredProcedure;
                CommandParametersAdd(parameterNames, parameterValues, ref dbcommand, true);
                //iResult = (int)dbcommand.ExecuteScalar();
                dbcommand.ExecuteScalar();
                iResult = (int)dbcommand.Parameters["@return"].Value;
            }
            catch (Exception ex) { throw ex; }
            finally
            {
                dbconnection.Close();
            }
            return iResult;
        }

        /// <summary>
        /// ժҪ��ִ�з������ݼ����̶���������SQL��䣨��������
        /// </summary>
        /// <param name="conString">���Ӵ����ƣ���Ĭ�����Ӵ����ƿ���Ϊnull</param>
        /// <param name="sql">SELECT SQL���</param>
        /// <param name="parameterNames">��������</param>
        /// <param name="parameterValues">����ֵ</param>
        /// <returns>���ݼ�</returns>
        public static DataSet ExeParaSqlForDataSetAccess(string sql, List<string> parameterNames, List<object> parameterValues)
        {
            DataSet dsResult = new DataSet();
            List<OleDbParameter> cmdParms = new List<OleDbParameter>();
            for (int i = 0; i < parameterNames.Count; i++)
            {
                cmdParms.Add(new OleDbParameter(parameterNames[i], parameterValues[i]));
            }
            dsResult = DbHelperACE.Query(sql, cmdParms.ToArray());

            return dsResult;
        }


        /// <summary>
        /// ժҪ��ִ���޷���ֵ���̶���������SQL��䣨��������
        /// </summary>
        /// <param name="conString">���Ӵ����ƣ���Ĭ�����Ӵ����ƿ���Ϊnull</param>
        /// <param name="sql">SQL���</param>
        /// <param name="parameterNames">��������</param>
        /// <param name="parameterValues">����ֵ</param>
        /// <returns>Ӱ������</returns>
        public static int ExeParaSqlForNonQueryAccess(string sql, List<string> parameterNames, List<object> parameterValues)
        {
            int iReturn = 0;
            List<OleDbParameter> cmdParms = new List<OleDbParameter>();
            for (int i = 0; i < parameterNames.Count; i++)
            {
                cmdParms.Add(new OleDbParameter(parameterNames[i], parameterValues[i]));
            }
            iReturn = DbHelperACE.ExecuteSql(sql, cmdParms.ToArray());
            return iReturn;
        }
        
        /// <summary>
        /// ժҪ��ִ���޷���ֵ���̶���������SQL��䣨��������
        /// </summary>
        /// <param name="conString">���Ӵ����ƣ���Ĭ�����Ӵ����ƿ���Ϊnull</param>
        /// <param name="sql">SQL���</param>
        /// <param name="parameterNames">��������</param>
        /// <param name="parameterValues">����ֵ</param>
        /// <returns>Ӱ������</returns>
        public static int ExeParaSqlForNonQueryAccUp(string sql, List<string> parameterNames, List<object> parameterValues)
        {
            int iReturn = 0;
            List<OleDbParameter> cmdParms = new List<OleDbParameter>();
            if (parameterNames.Count > 1)
            {
                for (int i = 1; i < parameterNames.Count; i++)
                {
                    cmdParms.Add(new OleDbParameter(parameterNames[i], parameterValues[i]));
                }
                cmdParms.Add(new OleDbParameter(parameterNames[0], parameterValues[0]));
            }
            else
            {
                for (int i = 0; i < parameterNames.Count; i++)
                {
                    cmdParms.Add(new OleDbParameter(parameterNames[i], parameterValues[i]));
                }
            }


            iReturn = DbHelperACE.ExecuteSql(sql, cmdParms.ToArray());
            return iReturn;
        }
        #endregion


    }
}
