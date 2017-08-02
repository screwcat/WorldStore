using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Common.DB.Core
{
    /// <summary>
    /// ���ʽ��ʽ��
    /// </summary>
    public class ExpressFormat
    {
        /// <summary>
        /// ժҪ����ʽ���ַ������Բ����
        /// </summary>
        /// <param name="formatString">����ʽ�����ַ���</param>
        /// <returns>��ʽ������ַ���</returns>
        public static string AddParentheses(string formatString)
        {
            return String.Format("({0})", formatString);
        }
        /// <summary>
        /// ժҪ����ʽ���ַ�����ӵ�����
        /// </summary>
        /// <param name="formatString">����ʽ�����ַ���</param>
        /// <returns>��ʽ������ַ���</returns>
        public static string AddSingleQuotationMarks(string formatString)
        {
            return String.Format("'{0}'", formatString);
        }
    }
}
