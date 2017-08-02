using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Common.DB.Core
{
    /// <summary>
    /// SELECT ������
    /// </summary>
    public class Select
    {
        readonly string SPACE_CHARACTER = " ";
        readonly string SELECT_CHARACTER = "SELECT";
        readonly string FROM_CHARACTER = "FROM";
        readonly string WHERE_CHARACTER = "WHERE";
        readonly string ORDER_BY_CHARACTER = "ORDER BY";
        readonly string GROUP_BY_CHARACTER = "GROUP BY";

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
        /// ժҪ���Ƿ����ORDERBY����
        /// </summary>
        bool _HasOrder = false;
        public bool HasOrder
        {
            get { return _HasOrder; }
            set { _HasOrder = value; }
        }
        /// <summary>
        /// ժҪ���Ƿ����GROUPBY����
        /// </summary>
        bool _HasGroup = false;
        public bool HasGroup
        {
            get { return _HasGroup; }
            set { _HasGroup = value; }
        }
        /// <summary>
        /// ժҪ��Ҫ��ѯ���ֶ�
        /// </summary>
        StringBuilder _SelectColumns = new StringBuilder();
        public StringBuilder SelectColumns
        {
            get { return _SelectColumns; }
            set { _SelectColumns = value; }
        }
        /// <summary>
        /// ժҪ������������������������������
        /// </summary>
        StringBuilder _TableName = new StringBuilder();
        public StringBuilder TableName
        {
            get { return _TableName; }
            set { _TableName = value; }
        }
        /// <summary>
        /// ժҪ���������
        /// </summary>
        StringBuilder _SelectWhere = new StringBuilder();
        public StringBuilder SelectWhere
        {
            get { return _SelectWhere; }
            set { _SelectWhere = value; }
        }
        /// <summary>
        /// ժҪ�������ֶ�
        /// </summary>
        StringBuilder _SelectOrder = new StringBuilder();
        public StringBuilder SelectOrder
        {
            get { return _SelectOrder; }
            set { _SelectOrder = value; }
        }
        /// <summary>
        /// ժҪ������ʽ�������������
        /// </summary>
        OrderBy _OrderMode = 0;
        public OrderBy OrderMode
        {
            get { return _OrderMode; }
            set { _OrderMode = value; }
        }
        /// <summary>
        /// ժҪ�������ֶ�
        /// </summary>
        StringBuilder _SelectGroup = new StringBuilder();
        public StringBuilder SelectGroup
        {
            get { return _SelectGroup; }
            set { _SelectGroup = value; }
        }
        /// <summary>
        /// ժҪ������
        /// </summary>
        public Select()
        { }
        public Select(bool hasWhere, bool hasOrder, bool hasGroup)
        {
            this._HasWhere = hasWhere;
            this._HasOrder = hasOrder;
            this._HasGroup = hasGroup;
        }
        public Select(bool hasWhere, bool hasOrder, bool hasGroup, StringBuilder selectColumns, StringBuilder tableName,
            StringBuilder selectWhere, StringBuilder selectOrder, OrderBy orderMode, StringBuilder selectGroup)
        {
            this._HasWhere = hasWhere;
            this._HasOrder = hasOrder;
            this._HasGroup = hasGroup;
            this._SelectColumns = selectColumns;
            this._TableName = tableName;
            this._SelectWhere = selectWhere;
            this._SelectOrder = selectOrder;
            this._OrderMode = orderMode;
            this._SelectGroup = selectGroup;
        }
        /// <summary>
        /// ժҪ��ƴ��SELECT���
        /// </summary>
        /// <returns>SELECT���</returns>
        public string ConnectSelectString()
        {
            StringBuilder sbSelect=new StringBuilder ();
            sbSelect.Append(SELECT_CHARACTER);
            sbSelect.Append(SPACE_CHARACTER);
            sbSelect.Append(_SelectColumns.ToString());
            sbSelect.Append(SPACE_CHARACTER);
            sbSelect.Append(FROM_CHARACTER);
            sbSelect.Append(SPACE_CHARACTER);
            sbSelect.Append(_TableName.ToString());
            if (_HasWhere)
            {
                sbSelect.Append(SPACE_CHARACTER);
                sbSelect.Append(WHERE_CHARACTER);
                sbSelect.Append(SPACE_CHARACTER);
                sbSelect.Append(_SelectWhere.ToString());
            }
            if (_HasOrder)
            {
                 sbSelect.Append(SPACE_CHARACTER);
                sbSelect.Append(ORDER_BY_CHARACTER);
                sbSelect.Append(SPACE_CHARACTER);
                sbSelect.Append(_SelectOrder.ToString());
                sbSelect.Append(SPACE_CHARACTER);
                sbSelect.Append(_OrderMode.ToString());
            }
            if (_HasGroup)
            {
                        sbSelect.Append(SPACE_CHARACTER);
                sbSelect.Append(GROUP_BY_CHARACTER);
                sbSelect.Append(SPACE_CHARACTER);
                sbSelect.Append(_SelectGroup.ToString());
            }
            return sbSelect.ToString();
        }
    }
}
