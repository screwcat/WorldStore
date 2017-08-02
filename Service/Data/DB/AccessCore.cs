using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Data;
using System.Data.OleDb;
using Service.Common.DB.Core;
using Service.Common.Data;

namespace Service.Common.DB
{
    /// <summary>
    /// Access数据库操作相关类
    /// </summary>
    public class AccessCore : DBCoreBase
    {
        /// <summary>
        /// 摘要：Access 构造函数
        /// </summary>
        public AccessCore()
        {
            this._Transfer_B = "[";
            this._Transfer_E = "]";
            this._VariableC = "@";
            this._FrontDataRow = "select Top {1} * from [{0}]";
        }

        #region 方法


        /// <summary>
        /// 摘要：插入一条记录
        /// </summary>
        /// <param name="T">实体类对象</param>
        /// <returns>自增长主键时返回主键值</returns>
        public override string Insert(object T)
        {
            base.Insert(T);
            StringBuilder sbColumnName = new StringBuilder();
            StringBuilder sbValues = new StringBuilder();
            List<string> lisParameter = new List<string>();
            List<object> lisParameterValues = new List<object>();
            foreach (Record drTemp in base._Records)
            {
                if (drTemp.IsAuto == 0)
                {
                    sbColumnName.Append(_Transfer_B);
                    sbColumnName.Append(drTemp.Name);
                    sbColumnName.Append(_Transfer_E);
                    sbColumnName.Append(",");
                    sbValues.Append(_VariableC + drTemp.Name);
                    sbValues.Append(",");
                    lisParameter.Add(_VariableC + drTemp.Name);
                    lisParameterValues.Add(drTemp.Value);
                }
                else
                {
                    //自增长列的处理，如何返回自增长的值。
                }
            }
            Insert insertSql = new Insert(base._TableName, sbColumnName.Remove(sbColumnName.Length - 1, 1), sbValues.Remove(sbValues.Length - 1, 1));
            int iResult = ExecuteSql.ExeParaSqlForNonQueryAccess(insertSql.ConnectInsertString(), lisParameter, lisParameterValues);
            return string.Empty;
        }

        /// <summary>
        /// 摘要：数据库读取
        /// </summary>
        /// <param name="connectionString">连接串</param>
        /// <param name="sql">sql语句</param>
        /// <returns></returns>
        public override DbDataReader GetReader(string sql)
        {
            return base.GetReader(sql);
        }
        /// <summary>
        /// 摘要：数据库预览表数据
        /// </summary>
        /// <param name="connectionString">连接串</param>
        /// <param name="sql">sql语句</param>
        /// <returns></returns>
        public override DataTable GetPreviewData(string sql)
        {
            return base.GetPreviewData(sql);
        }
        /// <summary>
        /// 摘要：获取数据库表名（包括视图）
        /// </summary>
        public override DataTable GetTableNames()
        {
            return base.GetTableNames();
        }

        /// <summary>
        /// 摘要：根据条件查询数据集
        /// </summary>
        /// <param name="dataSetSql">查询语句（包括列名、表等信息，支持表关联）</param>
        /// <param name="where">条件组，二维数据【0】为包括字段名的语句段模板，【1】为取值</param>
        /// <returns></returns>
        public override DataTable GetDataSet(string dataSetSql, List<string[]> where)
        {
            return GetDataSet(dataSetSql, where, new List<string[]>());
        }
        /// <summary>
        /// 摘要：根据条件查询数据集
        /// </summary>
        /// <param name="dataSetSql">查询语句（包括列名、表等信息，支持表关联）</param>
        /// <param name="where">条件组，二维数据【0】为包括字段名的语句段模板，【1】为取值</param>
        /// <param name="orderByColumn">排序列，二维数据【0】为字段名，【1】为ASC（升序）或DESC（降序）</param>
        /// <returns></returns>
        public override DataTable GetDataSet(string dataSetSql, List<string[]> where, List<string[]> orderByColumn)
        {
            string stCmd = dataSetSql + "{1} {0}";
            string stOrderby = ConstructOrderBy(orderByColumn);
            List<string> para = new List<string>();
            List<object> value = new List<object>();
            string stWhere = ConstructWhere(where, out para, out value);
            if (where.Count == 0)
                stCmd = string.Format(stCmd, string.IsNullOrEmpty(stOrderby) ? "" : "Order by " + stOrderby, "");
            else
                stCmd = string.Format(stCmd, string.IsNullOrEmpty(stOrderby) ? "" : "Order by " + stOrderby, " where " + stWhere);

            return ExecuteSql.ExeParaSqlForDataSetAccess(stCmd, para, value).Tables[0];
        }
        /// <summary>
        /// 摘要：对数据进行分页
        /// </summary>
        /// <param name="dataSetSql">查询语句（包括列名、表等信息，支持表关联）</param>
        /// <param name="where">条件组，二维数据【0】为包括字段名的语句段模板，【1】为取值</param>
        /// <param name="orderByColumn">排序列，二维数据【0】为字段名，【1】为ASC（升序）或DESC（降序）</param>
        /// <param name="rowBegin">排序后数据集的行开始索引</param>
        /// <param name="rowEnd">排序后数据集的行结束索引</param>
        /// <returns></returns>
        public override DataTable GetDataSet(string dataSetSql, List<string[]> where, List<string[]> orderByColumn, int rowBegin, int rowEnd)
        {
            string stCmd = "SELECT * FROM (SELECT ROW_NUMBER() Over(order by {0}) as MB,y.*  FROM  (" + dataSetSql + " {1}) y )  t WHERE MB>{2} and MB<={3}";
            string stOrderby = ConstructOrderBy(orderByColumn);
            List<string> para = new List<string>();
            List<object> value = new List<object>();
            string stWhere = ConstructWhere(where, out para, out value);
            if (where.Count == 0)
                stCmd = string.Format(stCmd, stOrderby, "", rowBegin, rowEnd);
            else
                stCmd = string.Format(stCmd, stOrderby, " where " + stWhere, rowBegin, rowEnd);

            return ExecuteSql.ExeParaSqlForDataSet(stCmd, para, value).Tables[0];
        }

        /// <summary>
        /// 更新一条记录
        /// </summary>
        /// <param name="T">实体类对象</param>
        public override void Update(object T)
        {
            base.Update(T);
            StringBuilder sbColumnName = new StringBuilder();
            StringBuilder sbValues = new StringBuilder();
            StringBuilder sbUpdateWhere = new StringBuilder();//Where 条件
            List<string> lisParameter = new List<string>();
            List<object> lisParameterValues = new List<object>();
            bool HasWhere = false;//是否有主键
            foreach (Record drTemp in base._Records)
            {
                if (drTemp.IsPK == 0)
                {
                    if (!drTemp.Value.Equals(string.Empty))
                    {
                        if (sbColumnName.Length > 0)
                            sbColumnName.Append(",");
                        sbColumnName.Append(_Transfer_B);
                        sbColumnName.Append(drTemp.Name);
                        sbColumnName.Append(_Transfer_E);
                        sbColumnName.Append("=");
                        sbColumnName.Append(_VariableC + drTemp.Name);


                        lisParameter.Add(_VariableC + drTemp.Name);
                        lisParameterValues.Add(drTemp.Value);
                    }
                }
                else
                {
                    //Where条件 主键的值(必须有主键)。
                    HasWhere = true;
                    sbUpdateWhere.Append(_Transfer_B);
                    sbUpdateWhere.Append(drTemp.Name);
                    sbUpdateWhere.Append(_Transfer_E);
                    sbUpdateWhere.Append("=");
                    sbUpdateWhere.Append(_VariableC + drTemp.Name);

                    lisParameter.Add(_VariableC + drTemp.Name);
                    lisParameterValues.Add(drTemp.Value);
                }
            }

            Update UpdateSql = new Update(HasWhere, base._TableName, sbColumnName, sbUpdateWhere);
            int iResult = ExecuteSql.ExeParaSqlForNonQueryAccUp(UpdateSql.ConnectUpdateString(), lisParameter, lisParameterValues);
        }

        /// <summary>
        /// 根据主键值数组删除记录
        /// </summary>
        /// <param name="T">实体类对象</param>
        /// <param name="value">要删除的主键值数组</param>
        public override void Delete(string PK, string tableName, List<string> value)
        {
            base.Delete(PK, tableName, value);
            StringBuilder sbColumnName = new StringBuilder();
            StringBuilder sbValues = new StringBuilder();
            StringBuilder sbUpdateWhere = new StringBuilder();//Where 条件
            List<string> lisParameter = new List<string>();
            List<object> lisParameterValues = new List<object>();

            //Where条件 主键的值(必须有主键)。
            sbUpdateWhere.Append(_Transfer_B);
            sbUpdateWhere.Append(PK);
            sbUpdateWhere.Append(_Transfer_E);
            sbUpdateWhere.Append("IN");
            sbUpdateWhere.Append("(");
            for (int i = 0; i < value.Count; i++)
            {
                if (i != 0)
                    sbUpdateWhere.Append(",");
                sbUpdateWhere.Append(_VariableC + PK + "_" + i.ToString());
                lisParameter.Add(_VariableC + PK + "_" + i.ToString());
                lisParameterValues.Add(value[i]);
            }
            sbUpdateWhere.Append(")");
            Delete DeleteSql = new Delete(true, base._FrontTableName, base._TableName, sbUpdateWhere);
            int iResult = ExecuteSql.ExeParaSqlForNonQueryAccess(DeleteSql.ConnectDeleteString(), lisParameter, lisParameterValues);
        }


        /// <summary>
        /// 摘要：构造order by 排序
        /// </summary>
        /// <param name="orderByParam">排序字段集合</param>
        /// <returns>排序语句</returns>
        private string ConstructOrderBy(List<string[]> orderByParam)
        {
            string stOrderBy = string.Empty;
            List<string> Sql = new List<string>();
            for (int i = 0; i < orderByParam.Count; i++)
            {
                Sql.Add(orderByParam[i][0] + " " + orderByParam[i][1]);
            }
            stOrderBy = string.Join(",", Sql.ToArray());
            return stOrderBy;
        }
        /// <summary>
        /// 摘要：构造where条件
        /// </summary>
        /// <param name="whereParam">条件集合</param>
        /// <returns>条件语句</returns>
        private string ConstructWhere(List<string[]> whereParam, out List<string> para, out List<object> value)
        {
            para = new List<string>();
            value = new List<object>();
            string stWhere = string.Empty;
            List<string> Sql = new List<string>();
            for (int i = 0; i < whereParam.Count; i++)
            {
                if (!string.IsNullOrEmpty(whereParam[i][1].Trim()))
                {
                    string Kye = "@" + whereParam[i].GetHashCode();
                    Sql.Add(string.Format(whereParam[i][0].Replace("'%{", "'%'+{").Replace("}%'", "}+'%'").Replace("'{", "{").Replace("}'", "}"), Kye));
                    para.Add(Kye);
                    value.Add(whereParam[i][1]);
                }
            }
            stWhere = string.Join(" and ", Sql.ToArray());
            return stWhere;
        }
        #endregion
    }
}
