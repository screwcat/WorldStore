using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Common.DB.Core
{
    /// <summary>
    /// INSERT ������
    /// </summary>
    public class Insert
    {
        readonly string SPACE_CHARACTER = " ";
        readonly string INSERT_CHARACTER = "INSERT INTO";
        readonly string VALUES_CHARACTER = "VALUES";

        /// <summary>
        /// ժҪ������
        /// </summary>
        string _TableName = string.Empty;
        public string TableName
        {
            get { return _TableName; }
            set { _TableName = value; }
        }
        /// <summary>
        /// ժҪ��Ҫ�������ݵ���
        /// </summary>
        StringBuilder _InsertColumns = new StringBuilder();
        public StringBuilder InsertColumns
        {
            get { return _InsertColumns; }
            set { _InsertColumns = value; }
        }
        /// <summary>
        /// ժҪ��Ҫ�������ݵ�ֵ
        /// </summary>
        StringBuilder _InsertValues = new StringBuilder();
        public StringBuilder InsertValues
        {
            get { return _InsertValues; }
            set { _InsertValues = value; }
        }
        /// <summary>
        /// ժҪ������
        /// </summary>
        public Insert()
        { }
        public Insert(string tableName, StringBuilder insertColumns, StringBuilder insertValues)
        {
            _TableName=tableName;
            _InsertColumns=insertColumns;
            _InsertValues=insertValues;
        }
        /// <summary>
        /// ժҪ��ƴ��INSERT���
        /// </summary>
        /// <returns>INSERT���</returns>
        public string ConnectInsertString()
        {
            StringBuilder sbInsert = new StringBuilder();
            sbInsert.Append(INSERT_CHARACTER);
            sbInsert.Append(SPACE_CHARACTER);
            sbInsert.Append(_TableName.ToString());
            sbInsert.Append(SPACE_CHARACTER);
            sbInsert.Append(ExpressFormat.AddParentheses(_InsertColumns.ToString()));
            sbInsert.Append(SPACE_CHARACTER);
            sbInsert.Append(VALUES_CHARACTER);
            sbInsert.Append(SPACE_CHARACTER);
            sbInsert.Append(ExpressFormat.AddParentheses(_InsertValues.ToString()));
            return sbInsert.ToString();
        }
    }
}
