using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Common.Entity
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true), Serializable]
    public class PropertyAttribute : Attribute
    {
        #region ����
        string _ColumnName = string.Empty;
        bool _IsStorage = true;
        #endregion

        #region ����
        public PropertyAttribute()
        { }
        public PropertyAttribute(string columnName)
        { _ColumnName = columnName; }
        public PropertyAttribute(bool isStorage)
        { _IsStorage = isStorage; }
        #endregion 

        #region ����
        public string ColumnName
        {
            get
            {
                return _ColumnName;
            }
            set
            {
                _ColumnName = value;
            }
        }
        public bool IsStorage
        {
            get
            {
                return _IsStorage;
            }
            set
            {
                _IsStorage = value;
            }
        }
        #endregion
    }
}
