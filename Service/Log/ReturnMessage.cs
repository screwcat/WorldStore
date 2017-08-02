using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Common.Log
{
    /// <summary>
    /// ����ִ�з�����Ϣ
    /// </summary>
    [Serializable]
    public class ReturnMessage
    {
        /// <summary>
        /// ժҪ�������Ƿ�ɹ�
        /// </summary>
        bool _IsSucessed = true;
        public bool IsSucessed
        {
            get { return _IsSucessed; }
            set { _IsSucessed = value; }
        }
        /// <summary>
        /// ժҪ������������ϸ��Ϣ
        /// </summary>
        string _Message=string.Empty;
        public string Message
        {
            get { return _Message; }
            set { _Message = value; }
        }
        /// <summary>
        /// ժҪ������
        /// </summary>
        public ReturnMessage()
        { }
        public ReturnMessage(bool isSucessed)
        {
            _IsSucessed = isSucessed;
        }
        public ReturnMessage(bool isSucessed, string message)
        {
            _IsSucessed = isSucessed;
            _Message = message;
        }
    }
}
