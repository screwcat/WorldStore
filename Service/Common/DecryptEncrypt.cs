using System;
using System.Web.Security;
using System.Data;
using System.IO;
using System.Text;
using System.Security.Cryptography;

namespace Service.Common
{
	/// <summary>
	/// ���ܽ�����
	/// </summary>
    public static class DecryptEncrypt
    {
        /// <summary>
        /// ժҪ���ԳƼ�����Կ
        /// </summary>
        private const string Key = ")(*&^%$#@!adsfsfddfghfyt";
        /// <summary>
        /// ժҪ���ԳƼ���-�����㷨
        /// </summary>
        /// <param name="strText">����</param>
        /// <returns>����</returns>
        public static string EncryptText(String text)
        {
            return Encrypt(text,Key);

        }
        /// <summary>
        /// ժҪ���ԳƼ���-�����㷨
        /// </summary>
        /// <param name="strText">����</param>
        /// <returns>����</returns>
        public static String DecryptText(String text)
        {
            return Decrypt(text, Key );
        }
        /// <summary>
        /// ժҪ�����ܺ���
        /// </summary>
        /// <param name="strText">����</param>
        /// <param name="strEncrKey">��Կ</param>
        /// <returns>����</returns>
        private static String Encrypt(String strText, String strEncrKey)
        {
            Byte[] byKey = { };
            Byte[] IV = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };
            try
            {
                byKey = System.Text.Encoding.UTF8.GetBytes(strEncrKey.Substring(0, 8));
                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                Byte[] inputByteArray = Encoding.UTF8.GetBytes(strText);
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(byKey, IV), CryptoStreamMode.Write);
                cs.Write(inputByteArray, 0, inputByteArray.Length);
                cs.FlushFinalBlock();
                return Convert.ToBase64String(ms.ToArray());
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        /// <summary>
        /// ժҪ�����ܺ���
        /// </summary>
        /// <param name="strText">����</param>
        /// <param name="sDecrKey">��Կ</param>
        /// <returns>����</returns>
        private static String Decrypt(String strText, String sDecrKey)
        {
            Byte[] byKey = { };
            Byte[] IV = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };
            Byte[] inputByteArray = new byte[strText.Length];
            try
            {
                byKey = System.Text.Encoding.UTF8.GetBytes(sDecrKey.Substring(0, 8));
                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                inputByteArray = Convert.FromBase64String(strText);
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(byKey, IV), CryptoStreamMode.Write);
                cs.Write(inputByteArray, 0, inputByteArray.Length);
                cs.FlushFinalBlock();
                System.Text.Encoding encoding = System.Text.Encoding.UTF8;
                return encoding.GetString(ms.ToArray());
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        /// <summary>
        /// ժҪ�����������MD5���ܵĺ���(�����ֵ��&%#@?,:*)
        /// ��System.Web.dll֧��
        /// </summary>
        /// <param name="Password">��������</param>
        /// <returns>��������</returns>
        public static string GetEncryPassword(string password)
        {
            string EncryedPassword = FormsAuthentication.HashPasswordForStoringInConfigFile(
                password + Key, "md5"); // Or "sha1"
            return EncryedPassword;
        }
        /// <summary>
        /// ժҪ���ļ�����
        /// </summary>
        /// <param name="inFilePath">�������ļ�·��</param>
        /// <param name="outFilePath">���������ļ�·��</param>
        /// <param name="encryptKey">��Կ</param>
        /// <returns>�Ƿ�ɹ�</returns>
        public static bool EncryptDES(string inFilePath, string outFilePath, string encryptKey)
        {
            byte[] rgbIV = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };
            try
            {
                byte[] rgbKey = Encoding.UTF8.GetBytes(encryptKey.Substring(0, 8));
                //�������
                FileStream inFs = new FileStream(inFilePath, FileMode.Open, FileAccess.Read);
                //��д����
                FileStream outFs = new FileStream(outFilePath, FileMode.OpenOrCreate, FileAccess.Write);
                outFs.SetLength(0);
                //����һ��������������д
                byte[] byteIn = new byte[100]; //��ʱ��Ŷ������
                long readLen = 0;              //�������ĳ���
                long totalLen = inFs.Length;    //�ܹ��������ĳ���
                int everyLen;                  //ÿ�ζ�����������
                //����InFs�����ܺ�д��OutFs
                DES des = new DESCryptoServiceProvider();
                CryptoStream encStream = new CryptoStream(outFs, des.CreateEncryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
                while (readLen < totalLen)
                {
                    everyLen = inFs.Read(byteIn, 0, 100);
                    encStream.Write(byteIn, 0, everyLen);
                    readLen = readLen + everyLen;
                }
                encStream.Close();
                outFs.Close();
                inFs.Close();
                return true;//���ܳɹ�
            }
            catch
            {
                return false;//����ʧ�� 
            }
        }
        /// <summary>
        /// ժҪ���ļ�����
        /// </summary>
        /// <param name="inFilePath">�������ļ�·��</param>
        /// <param name="outFilePath">���������ļ�·��</param>
        /// <param name="decryptKey">��Կ</param>
        /// <returns>�Ƿ�ɹ�</returns>
        public static bool DecryptDES(string inFilePath, string outFilePath, string decryptKey)
        {
            byte[] rgbIV = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };
            try
            {
                byte[] rgbKey = Encoding.UTF8.GetBytes(decryptKey.Substring(0, 8));
                //�������
                FileStream inFs = new FileStream(inFilePath, FileMode.Open, FileAccess.Read);
                //��д����
                FileStream outFs = new FileStream(outFilePath, FileMode.OpenOrCreate, FileAccess.Write);
                outFs.SetLength(0);
                //����һ��������������д
                byte[] byteIn = new byte[100]; //��ʱ��Ŷ������
                long readLen = 0;              //�������ĳ���
                long totalLen = inFs.Length;    //�ܹ��������ĳ���
                int everyLen;                  //ÿ�ζ�����������
                //����InFs�����ܺ�д��OutFs
                DES des = new DESCryptoServiceProvider();
                CryptoStream encStream = new CryptoStream(outFs, des.CreateDecryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
                while (readLen < totalLen)
                {
                    everyLen = inFs.Read(byteIn, 0, 100);
                    encStream.Write(byteIn, 0, everyLen);
                    readLen = readLen + everyLen;
                }
                encStream.Close();
                outFs.Close();
                inFs.Close();
                return true;//���ܳɹ�
            }
            catch
            {
                return false;//����ʧ�� 
            }
        }
	}
}
