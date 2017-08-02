using System;
using System.Web.Security;
using System.Data;
using System.IO;
using System.Text;
using System.Security.Cryptography;

namespace Service.Common
{
	/// <summary>
	/// 加密解密类
	/// </summary>
    public static class DecryptEncrypt
    {
        /// <summary>
        /// 摘要：对称加密密钥
        /// </summary>
        private const string Key = ")(*&^%$#@!adsfsfddfghfyt";
        /// <summary>
        /// 摘要：对称加密-加密算法
        /// </summary>
        /// <param name="strText">明文</param>
        /// <returns>密文</returns>
        public static string EncryptText(String text)
        {
            return Encrypt(text,Key);

        }
        /// <summary>
        /// 摘要：对称加密-解密算法
        /// </summary>
        /// <param name="strText">密文</param>
        /// <returns>明文</returns>
        public static String DecryptText(String text)
        {
            return Decrypt(text, Key );
        }
        /// <summary>
        /// 摘要：加密函数
        /// </summary>
        /// <param name="strText">明文</param>
        /// <param name="strEncrKey">密钥</param>
        /// <returns>密文</returns>
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
        /// 摘要：解密函数
        /// </summary>
        /// <param name="strText">密文</param>
        /// <param name="sDecrKey">密钥</param>
        /// <returns>明文</returns>
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
        /// 摘要：对密码进行MD5加密的函数(添加盐值：&%#@?,:*)
        /// 需System.Web.dll支持
        /// </summary>
        /// <param name="Password">明文密码</param>
        /// <returns>密文密码</returns>
        public static string GetEncryPassword(string password)
        {
            string EncryedPassword = FormsAuthentication.HashPasswordForStoringInConfigFile(
                password + Key, "md5"); // Or "sha1"
            return EncryedPassword;
        }
        /// <summary>
        /// 摘要：文件加密
        /// </summary>
        /// <param name="inFilePath">待加密文件路径</param>
        /// <param name="outFilePath">处理后加密文件路径</param>
        /// <param name="encryptKey">密钥</param>
        /// <returns>是否成功</returns>
        public static bool EncryptDES(string inFilePath, string outFilePath, string encryptKey)
        {
            byte[] rgbIV = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };
            try
            {
                byte[] rgbKey = Encoding.UTF8.GetBytes(encryptKey.Substring(0, 8));
                //读入的流
                FileStream inFs = new FileStream(inFilePath, FileMode.Open, FileAccess.Read);
                //待写的流
                FileStream outFs = new FileStream(outFilePath, FileMode.OpenOrCreate, FileAccess.Write);
                outFs.SetLength(0);
                //创建一个变量来帮助读写
                byte[] byteIn = new byte[100]; //临时存放读入的流
                long readLen = 0;              //读入流的长度
                long totalLen = inFs.Length;    //总共读入流的长度
                int everyLen;                  //每次读入流动长度
                //读入InFs，加密后写入OutFs
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
                return true;//加密成功
            }
            catch
            {
                return false;//加密失败 
            }
        }
        /// <summary>
        /// 摘要：文件加密
        /// </summary>
        /// <param name="inFilePath">待解密文件路径</param>
        /// <param name="outFilePath">处理后解密文件路径</param>
        /// <param name="decryptKey">密钥</param>
        /// <returns>是否成功</returns>
        public static bool DecryptDES(string inFilePath, string outFilePath, string decryptKey)
        {
            byte[] rgbIV = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };
            try
            {
                byte[] rgbKey = Encoding.UTF8.GetBytes(decryptKey.Substring(0, 8));
                //读入的流
                FileStream inFs = new FileStream(inFilePath, FileMode.Open, FileAccess.Read);
                //待写的流
                FileStream outFs = new FileStream(outFilePath, FileMode.OpenOrCreate, FileAccess.Write);
                outFs.SetLength(0);
                //创建一个变量来帮助读写
                byte[] byteIn = new byte[100]; //临时存放读入的流
                long readLen = 0;              //读入流的长度
                long totalLen = inFs.Length;    //总共读入流的长度
                int everyLen;                  //每次读入流动长度
                //读入InFs，解密后写入OutFs
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
                return true;//解密成功
            }
            catch
            {
                return false;//解密失败 
            }
        }
	}
}
