using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using Service.Common.Log;
using Service.Common.DB;
using System.Configuration;
using System.Data;



namespace Service.Common.Entity
{
    /// <summary>
    /// ʵ�巺����
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [Serializable]
    public class EntityBase<T> where T : new()
    {
        #region ����
        /// <summary>
        /// ժҪ�����ݿ�������������˶�Ӧ��Ӧ�ó��������ļ�<appSettings>�ڵ���Ӧ������keyΪ"DBType"��<add>�ڡ�
        /// �ý�ֵ��Ϊ���¼��֣�SQL SERVER���ݿ��á�MSSql����ʾ��ORACLE���ݿ��á�Oracle����ʾ��XML���ݿ��á�XML����ʾ��
        /// </summary>
        //public string DATABASE_TYPE = ConfigurationSettings.AppSettings.Get("DBType");
        /// <summary>
        /// ժҪ����ǩ���ݣ���ΪXML���ݿ�ʱΪ·������Ϊ��ϵ�����ݿ�ʱΪ���ݿ����Ӵ��������ļ��е����ƣ�����Ϊ�գ���
        /// </summary>
        private string _TagData = string.Empty;
        public string TagData
        {
            get { return _TagData; }
            set { _TagData = value; }
        }

        #endregion

        #region ����
        /// <summary>
        /// ժҪ��ͨ����������
        /// </summary>
        /// <returns>ִ�н��������Ϊ���������ͣ��ɹ�ʱ����ֵ��messageΪ����������ֵ</returns>
        public ReturnMessage Insert()
        {
            ReturnMessage rm = new ReturnMessage(true);
            string stTableName = string.Empty;
            try
            {
                T obj = (T)this.MemberwiseClone();
                stTableName = ((TableAttribute)obj.GetType().GetCustomAttributes(true)[0]).TableName;
                IDBCore iDB = DBFactory.CreateDB();
                /*if (DATABASE_TYPE == "XML")
                {
                    iDB = new XMLCore(_TagData);
                }
                else
                {
                    iDB = DBFactory.CreateDB();
                }*/
                rm.Message = iDB.Insert(obj).ToString();
            }
            catch (Exception ex)
            {
                rm.IsSucessed = false;
                rm.Message = "��" + stTableName + "����������ʧ�ܣ�ԭ��" + ex.Message;
            }
            return rm;
        }
        /// <summary>
        /// ժҪ������һ����¼
        /// </summary>
        /// <param name="T">ʵ�������</param>
        public ReturnMessage Update()
        {
            ReturnMessage rm = new ReturnMessage(true);
            string stTableName = string.Empty;
            try
            {
                T obj = (T)this.MemberwiseClone();
                stTableName = ((TableAttribute)obj.GetType().GetCustomAttributes(true)[0]).TableName;
                IDBCore iDB = DBFactory.CreateDB();
                /*if (DATABASE_TYPE == "XML")
                {
                    iDB = new XMLCore(_TagData);
                }
                else
                {
                    iDB = DBFactory.CreateDB();
                }*/
                iDB.Update(obj);
            }
            catch (Exception ex)
            {
                rm.IsSucessed = false;
                rm.Message = "��" + stTableName + "����������ʧ�ܣ�ԭ��" + ex.Message;
            }
            return rm;
        }
        /// <summary>
        /// ժҪ��ɾ����¼
        /// </summary>
        /// <param name="value">Ҫɾ��������ֵ����</param>
        public ReturnMessage Delete(List<string> value)
        {
            ReturnMessage rm = new ReturnMessage(true);
            string stTableName = string.Empty;
            try
            {
                T obj = (T)this.MemberwiseClone();
                stTableName = ((TableAttribute)obj.GetType().GetCustomAttributes(true)[0]).TableName;
                string stPK = string.Empty;
                PropertyInfo[] propertyInfos = obj.GetType().GetProperties();
                for (int i = 0; i < propertyInfos.Length; i++)
                {
                    if (propertyInfos[i].GetCustomAttributes(true).Length != 0)
                    {
                        if (propertyInfos[i].GetCustomAttributes(true)[0].GetType().Name == "PrimaryKeyAttribute")
                        {
                            stPK = propertyInfos[i].Name;
                        }
                    }
                }
                IDBCore iDB = DBFactory.CreateDB();
                /*if (DATABASE_TYPE == "XML")
                {
                    iDB = new XMLCore(_TagData);
                }
                else
                {
                    iDB = DBFactory.CreateDB();
                }*/
                iDB.Delete(stPK, stTableName, value);
            }
            catch (Exception ex)
            {
                rm.IsSucessed = false;
                rm.Message = "��" + stTableName + "��ɾ������ʧ�ܣ�ԭ��" + ex.Message;
            }
            return rm;
        }
        /// <summary>
        /// ժҪ�������ݽ��з�ҳ
        /// </summary>
        /// <param name="dataSetSql">��ѯ��䣨���������������Ϣ��֧�ֱ������</param>
        /// <param name="where">�����飬��ά���ݡ�0��Ϊ�����ֶ���������ģ�壬��1��Ϊȡֵ</param>
        /// <param name="orderByColumn">�����У���ά���ݡ�0��Ϊ�ֶ�������1��ΪASC�����򣩻�DESC������</param>
        /// <param name="rowBegin">��������ݼ����п�ʼ����</param>
        /// <param name="rowEnd">��������ݼ����н�������</param>
        /// <returns></returns>
        public DataTable GetDataSet(string dataSetSql, List<string[]> where, List<string[]> orderByColumn, int rowBegin, int rowEnd)
        {
            DataTable dt = new DataTable();
            string stTableName = string.Empty;
            try
            {
                T obj = (T)this.MemberwiseClone();
                stTableName = ((TableAttribute)obj.GetType().GetCustomAttributes(true)[0]).TableName;
                IDBCore iDB = DBFactory.CreateDB();
                /*if (DATABASE_TYPE == "XML")
                {
                    iDB = new XMLCore(_TagData);
                }
                else
                {
                    iDB = DBFactory.CreateDB();
                }*/
                if ((rowBegin == -1 || rowEnd == -1) && orderByColumn != null)
                {
                    dt = iDB.GetDataSet(dataSetSql, where, orderByColumn);
                }
                else if ((rowBegin == -1 || rowEnd == -1) && orderByColumn == null)
                {
                    dt = iDB.GetDataSet(dataSetSql, where);
                }
                else
                {
                    dt = iDB.GetDataSet(dataSetSql, where, orderByColumn, rowBegin, rowEnd);
                }
            }
            catch (Exception ex)
            {
                dt = null;
                throw ex;
            }
            return dt;
        }
        /// <summary>
        /// ժҪ������������ѯ���ݼ�
        /// </summary>
        /// <param name="dataSetSql">��ѯ��䣨���������������Ϣ��֧�ֱ������</param>
        /// <param name="where">�����飬��ά���ݡ�0��Ϊ�����ֶ���������ģ�壬��1��Ϊȡֵ</param>
        /// <param name="orderByColumn">�����У���ά���ݡ�0��Ϊ�ֶ�������1��ΪASC�����򣩻�DESC������</param>
        /// <returns></returns>
        public DataTable GetDataSet(string dataSetSql, List<string[]> where, List<string[]> orderByColumn)
        {
            return GetDataSet(dataSetSql, where, orderByColumn, -1, -1);
        }
        /// <summary>
        /// ժҪ������������ѯ���ݼ�
        /// </summary>
        /// <param name="dataSetSql">��ѯ��䣨���������������Ϣ��֧�ֱ������</param>
        /// <param name="where">�����飬��ά���ݡ�0��Ϊ�����ֶ���������ģ�壬��1��Ϊȡֵ</param>
        /// <returns></returns>
        public DataTable GetDataSet(string dataSetSql, List<string[]> where)
        {
            return GetDataSet(dataSetSql, where, null, -1, -1);
        }
        /// <summary>
        /// ժҪ������������ѯ���ݼ���¼����
        /// </summary>
        /// <param name="dataSetSql">��ѯ��䣨���������������Ϣ��֧�ֱ������</param>
        /// <param name="where">�����飬��ά���ݡ�0��Ϊ�����ֶ���������ģ�壬��1��Ϊȡֵ</param>
        /// <returns></returns>
        public int GetDataSetCount(string dataSetSql, List<string[]> where)
        {
            int iCount = -1;
            string stTableName = string.Empty;
            try
            {
                T obj = (T)this.MemberwiseClone();
                stTableName = ((TableAttribute)obj.GetType().GetCustomAttributes(true)[0]).TableName;
                IDBCore iDB = DBFactory.CreateDB();
                /*if (DATABASE_TYPE == "XML")
                {
                    iDB = new XMLCore(_TagData);
                }
                else
                {
                    iDB = DBFactory.CreateDB();
                }*/
                iCount = iDB.GetDataSetCount(dataSetSql, where);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return iCount;
        }
        /// <summary>
        /// ժҪ������������ѯ�ж���
        /// </summary>
        /// <param name="PK">����ֵ</param>
        public void FindbyPK(string PK)
        {
            string stTableName = ((TableAttribute)this.GetType().GetCustomAttributes(true)[0]).TableName;
            string stPK = string.Empty;
            string stType = string.Empty;
            string stTemp = string.Empty;
            PropertyInfo[] propertyInfos = this.GetType().GetProperties();
            for (int i = 0; i < propertyInfos.Length; i++)
            {
                if (propertyInfos[i].GetCustomAttributes(true).Length != 0)
                {
                    if (propertyInfos[i].GetCustomAttributes(true)[0].GetType().Name == "PrimaryKeyAttribute")
                    {
                        stPK = propertyInfos[i].Name;
                        stType = propertyInfos[i].GetType().ToString();
                        stType = propertyInfos[i].PropertyType.ToString();
                    }
                }
            }
            List<string[]> where = new List<string[]>();
            /*if (DATABASE_TYPE == "MSSql")
            {
                stTemp = "{0}";
            }
            else if (stType.ToString() == "System.String")
            {
                stTemp = "'{0}'";
            }
            else
            {
                stTemp = "{0}";
            }*/
            stTemp = "{0}";
            where.Add(new string[] { stPK + "=" + stTemp, PK });
            DataTable dt = GetDataSet("SELECT * FROM " + stTableName, where);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < propertyInfos.Length; i++)
                {
                    if (propertyInfos[i].Name == "TagData") continue;
                    if (propertyInfos[i].GetCustomAttributes(true)[0].GetType().Name != "PrimaryKeyAttribute" && (!dt.Columns.Contains(((PropertyAttribute)(propertyInfos[i].GetCustomAttributes(true)[0])).ColumnName)) && !dt.Columns.Contains(propertyInfos[i].Name)) continue;
                    if (propertyInfos[i].GetCustomAttributes(true)[0].GetType().Name == "PrimaryKeyAttribute" && !dt.Columns.Contains(propertyInfos[i].Name)) continue;
                    if (propertyInfos[i].GetCustomAttributes(true)[0].GetType().Name != "PrimaryKeyAttribute")
                    {
                        if (((PropertyAttribute)(propertyInfos[i].GetCustomAttributes(true)[0])).ColumnName == string.Empty)
                        {
                            switch (propertyInfos[i].PropertyType.Name)
                            {
                                case "Int32":
                                    {
                                        if (dt.Rows[0][propertyInfos[i].Name] != DBNull.Value)
                                        {
                                            propertyInfos[i].SetValue(this, Convert.ToInt32(dt.Rows[0][propertyInfos[i].Name]), null);
                                        }
                                        break;
                                    }
                                case "Int16":
                                    {
                                        if (dt.Rows[0][propertyInfos[i].Name] != DBNull.Value)
                                        {
                                            propertyInfos[i].SetValue(this, Convert.ToInt16(dt.Rows[0][propertyInfos[i].Name]), null);
                                        }
                                        break;
                                    }
                                case "DateTime":
                                    if (dt.Rows[0][propertyInfos[i].Name] != DBNull.Value)
                                    {
                                        propertyInfos[i].SetValue(this, DateTime.Parse(dt.Rows[0][propertyInfos[i].Name].ToString()), null);
                                    }
                                    break;
                                case "Decimal":
                                    if (dt.Rows[0][propertyInfos[i].Name].ToString() != "")
                                    {
                                        propertyInfos[i].SetValue(this, Decimal.Parse(dt.Rows[0][propertyInfos[i].Name].ToString()), null);
                                    }
                                    break;
                                case "Boolean":
                                    if (dt.Rows[0][propertyInfos[i].Name] != DBNull.Value)
                                    {
                                        propertyInfos[i].SetValue(this, dt.Rows[0][propertyInfos[i].Name], null);
                                    }
                                    break;
                                default:
                                    {
                                        if (dt.Rows[0][propertyInfos[i].Name] != DBNull.Value)
                                        {
                                            propertyInfos[i].SetValue(this, dt.Rows[0][propertyInfos[i].Name], null);
                                        }
                                    }
                                    break;
                            }
                        }
                        else
                        {
                            if (propertyInfos[i].PropertyType.Name == "Int32")
                            {
                                propertyInfos[i].SetValue(this, Convert.ToInt32(dt.Rows[0][((PropertyAttribute)(propertyInfos[i].GetCustomAttributes(true)[0])).ColumnName]), null);
                            }
                            else
                            {
                                propertyInfos[i].SetValue(this, dt.Rows[0][((PropertyAttribute)(propertyInfos[i].GetCustomAttributes(true)[0])).ColumnName], null);

                            }
                        }
                    }
                    else
                    {
                        propertyInfos[i].SetValue(this, dt.Rows[0][((PrimaryKeyAttribute)(propertyInfos[i].GetCustomAttributes(true)[0])).ColumnName], null);
                    }
                }
            }
        }
        #endregion
    }
}
