using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Common.DB.Core
{
    /// <summary>
    /// UPDATE ������
    /// </summary>
    public class Update
    {
        readonly string SPACE_CHARACTER = " ";
        readonly string UPDATE_CHARACTER = "UPDATE";
        readonly string SET_CHARACTER = "SET";
        readonly string WHERE_CHARACTER = "WHERE";

        /// <summary>
        /// ժҪ���Ƿ����WHERE����
        /// </summary>
        bool _HasWhere = true;
        public bool HasWhere
        {
            get { return _HasWhere; }
            set { _HasWhere = value; }
        }
        /// <summary>
        /// ժҪ������������������������������
        /// </summary>
        string _TableName = string.Empty;
        public string TableName
        {
            get { return _TableName; }
            set { _TableName = value; }
        }
        /// <summary>
        /// ժҪ�������ֶα��ʽ����
        /// </summary>
        StringBuilder _UpdateColumns = new StringBuilder();
        public StringBuilder UpdateColumns
        {
            get { return _UpdateColumns; }
            set { _UpdateColumns = value; }
        }
        /// <summary>
        /// ժҪ���������
        /// </summary>
        StringBuilder _UpdateWhere = new StringBuilder();
        public StringBuilder UpdateWhere
        {
            get { return _UpdateWhere; }
            set
            {
                if (_UpdateWhere.ToString().Equals(String.Empty))
                {
                    _UpdateWhere.Append("1=1");
                }
                else
                {
                    _UpdateWhere = value;
                }
            }
        }
        /// <summary>
        /// ժҪ������
        /// </summary>
        public Update()
        { }
        public Update(bool hasWhere)
        {
            this._HasWhere = hasWhere;
        }
        public Update(bool hasWhere, string tableName, StringBuilder updateColumns, StringBuilder updateWhere)
        {
            this._HasWhere = hasWhere;
            this._UpdateColumns = updateColumns;
            this._TableName = tableName;
            this._UpdateWhere = updateWhere;
        }
        /// <summary>
        /// ժҪ��ƴ��UPDATE���
        /// </summary>
        /// <returns>UPDATE���</returns>
        public string ConnectUpdateString()
        {
            StringBuilder sbUpdate = new StringBuilder();
            sbUpdate.Append(UPDATE_CHARACTER);
            sbUpdate.Append(SPACE_CHARACTER);
            sbUpdate.Append(_TableName.ToString());
            sbUpdate.Append(SPACE_CHARACTER);
            sbUpdate.Append(SET_CHARACTER);
            sbUpdate.Append(_UpdateColumns.ToString());
            sbUpdate.Append(SPACE_CHARACTER);
            if (_HasWhere)
            {
                sbUpdate.Append(WHERE_CHARACTER);
                sbUpdate.Append(SPACE_CHARACTER);
                sbUpdate.Append(_UpdateWhere);
                sbUpdate.Append(SPACE_CHARACTER);
            }
            return sbUpdate.ToString();
        }
    }
}
