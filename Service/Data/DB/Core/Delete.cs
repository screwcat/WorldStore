using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Common.DB.Core
{
    /// <summary>
    /// DELETE ������
    /// </summary>
    public class Delete
    {
        readonly string SPACE_CHARACTER = " ";
        readonly string DELETE_CHARACTER = "DELETE";
        readonly string FROM_CHARACTER = "FROM";
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
        /// ժҪ��ǰ�ñ�������DELETE ����б��б���ʱ������DELETE �� FROM ֮���һ��ǰ�ñ�������ָ��ɾ���ı�
        /// </summary>
        string _FrontTableName = string.Empty;
        public string FrontTableName
        {
            get { return _FrontTableName; }
            set { _FrontTableName = value; }
        }
        /// <summary>
        /// ժҪ���������
        /// </summary>
        StringBuilder _DeleteWhere = new StringBuilder();
        public StringBuilder DeleteWhere
        {
            get { return _DeleteWhere; }
            set
            {
                if (_DeleteWhere.ToString().Equals(String.Empty))
                {
                    _DeleteWhere.Append("1=1");
                }
                else
                {
                    _DeleteWhere = value;
                }
            }
        }
        /// <summary>
        /// ժҪ������
        /// </summary>
        public Delete()
        { }
        public Delete(bool hasWhere)
        {
            this._HasWhere = hasWhere;
        }
        public Delete(bool hasWhere, string frontTableName, string tableName, StringBuilder deleteWhere)
        {
            this._HasWhere = hasWhere;
            _FrontTableName = frontTableName;
            _TableName = tableName;
            _DeleteWhere = deleteWhere;
        }
        /// <summary>
        /// ժҪ��ƴ��DELETE���
        /// </summary>
        /// <returns>DELETE���</returns>
        public string ConnectDeleteString()
        {
            StringBuilder sbDelete = new StringBuilder();
            sbDelete.Append(DELETE_CHARACTER);
            sbDelete.Append(SPACE_CHARACTER);
            sbDelete.Append(_FrontTableName.ToString());
            sbDelete.Append(SPACE_CHARACTER);
            sbDelete.Append(FROM_CHARACTER.ToString());
            sbDelete.Append(SPACE_CHARACTER);
            sbDelete.Append(_TableName.ToString());
            sbDelete.Append(SPACE_CHARACTER);
            if (_HasWhere)
            {
                sbDelete.Append(WHERE_CHARACTER);
                sbDelete.Append(SPACE_CHARACTER);
                sbDelete.Append(_DeleteWhere.ToString());
            }
            return sbDelete.ToString();
        }
    }
}
