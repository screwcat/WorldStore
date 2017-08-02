using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;
using System.Data;

namespace Service.Common.Data
{
    /// <summary>
    /// ִ�д洢����
    /// </summary>
    public class ExecuteProcedure
    {
        static Database dbInstance;
        /// <summary>
        /// ժҪ��ִ���޷���ֵ�洢����
        /// </summary>
        /// <param name="conString">���Ӵ����ƣ���Ĭ�����Ӵ����ƿ���Ϊnull</param>
        /// <param name="procedureName">�洢��������</param>
        /// <param name="parameterValues">����ֵ����</param>
        /// <returns>Ӱ������</returns>
        public static int ExeProcedureNonQuery(string conString, string procedureName, params object[] parameterValues)
        {
            dbInstance = DBInstance.CreateInstance(conString);
            if (object.Equals(null, dbInstance))
            {
                return -1;
            }
            int iReturn = dbInstance.ExecuteNonQuery(procedureName, parameterValues);
            return iReturn;
        }
        /// <summary>
        /// ժҪ��ִ���޷���ֵ�洢����
        /// </summary>
        /// <param name="procedureName">�洢��������</param>
        /// <param name="parameterValues">����ֵ����</param>
        /// <returns>Ӱ������</returns>
        public static int ExeProcedureNonQuery(string procedureName, params object[] parameterValues)
        {
            return ExeProcedureNonQuery(null, procedureName, parameterValues);
        }
        /// <summary>
        /// ժҪ��ִ�д洢���̻�ȡ���ݼ�
        /// </summary>
        /// <param name="conString">���Ӵ����ƣ���Ĭ�����Ӵ����ƿ���Ϊnull</param>
        /// <param name="procedureName">�洢��������</param>
        /// <param name="parameterValues">����ֵ����</param>
        /// <returns>���ݼ�</returns>
        public static DataSet ExeProcedureForDataSet(string conString, string procedureName, params object[] parameterValues)
        {
            dbInstance = DBInstance.CreateInstance(conString);
            if (object.Equals(null, dbInstance))
            {
                return null;
            }
            DbCommand dbcommand = dbInstance.GetStoredProcCommand(procedureName, parameterValues);
            DataSet dsReturn = dbInstance.ExecuteDataSet(dbcommand);
            return dsReturn;
        }
        /// <summary>
        /// ժҪ��ִ�д洢���̻�ȡ���ݼ�
        /// </summary>
        /// <param name="procedureName">�洢��������</param>
        /// <param name="parameterValues">����ֵ����</param>
        /// <returns></returns>
        public static DataSet ExeProcedureForDataSet(string procedureName, params object[] parameterValues)
        {
            return ExeProcedureForDataSet(null, procedureName, parameterValues);
        }
        /// <summary>
        /// ժҪ��ִ�з��ز����洢����
        /// </summary>
        /// <param name="conString">���Ӵ����ƣ���Ĭ�����Ӵ����ƿ���Ϊnull</param>
        /// <param name="procedureName">�洢��������</param>
        /// <param name="parameterValues">����ֵ����</param>
        /// <returns>Ӱ������</returns>
        public static object ExeProcedureForParameter(string conString, string procedureName, params DbParameter[] commandParameters)
        {
            dbInstance = DBInstance.CreateInstance(conString);
            if (object.Equals(null, dbInstance))
            {
                return null;
            }
            DbCommand cmd = dbInstance.GetStoredProcCommand(procedureName);
            foreach (DbParameter parm in commandParameters)
            {
                if(parm.Value!=null)
                dbInstance.AddInParameter(cmd, parm.ParameterName, parm.DbType, parm.Value);
            }
            dbInstance.AddOutParameter(cmd, commandParameters[commandParameters.Length - 1].ParameterName, commandParameters[commandParameters.Length - 1].DbType, 10);
            dbInstance.ExecuteNonQuery(cmd);
            object iReturn = dbInstance.GetParameterValue(cmd, "return");
            return iReturn;
        }
        /// <summary>
        /// ժҪ��ִ���޷���ֵ�洢����
        /// </summary>
        /// <param name="procedureName">�洢��������</param>
        /// <param name="parameterValues">����ֵ����</param>
        /// <returns>Ӱ������</returns>
        public static object ExeProcedureForParameter(string procedureName, params DbParameter[] commandParameters)
        {
            return ExeProcedureForParameter(null, procedureName, commandParameters);
        }
    }
}
