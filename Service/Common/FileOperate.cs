using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Service.Common.IO
{
    public class FileOperate
    {
        /// <summary>
        /// 读取文件编码
        /// </summary>
        /// <param name="stream">文件流</param>
        /// <param name="defaultEncoding">默认编码</param>
        /// <returns></returns>
        public static Encoding GetEncoding(FileStream stream, Encoding defaultEncoding)
        {
            Encoding targetEncoding = defaultEncoding;
            if (stream != null && stream.Length >= 2)
            {
                //保存文件流的前4个字节
                byte byte1 = 0;
                byte byte2 = 0;
                byte byte3 = 0;
                byte byte4 = 0;
                //保存当前Seek位置
                long origPos = stream.Seek(0, SeekOrigin.Begin);
                stream.Seek(0, SeekOrigin.Begin);

                int nByte = stream.ReadByte();
                byte1 = Convert.ToByte(nByte);
                byte2 = Convert.ToByte(stream.ReadByte());
                if (stream.Length >= 3)
                {
                    byte3 = Convert.ToByte(stream.ReadByte());
                }
                if (stream.Length >= 4)
                {
                    byte4 = Convert.ToByte(stream.ReadByte());
                }
                //根据文件流的前4个字节判断Encoding
                //Unicode {0xFF, 0xFE};
                //BE-Unicode {0xFE, 0xFF};
                //UTF8 = {0xEF, 0xBB, 0xBF};
                if (byte1 == 0xFE && byte2 == 0xFF)//UnicodeBe
                {
                    targetEncoding = Encoding.BigEndianUnicode;
                }
                if (byte1 == 0xFF && byte2 == 0xFE && byte3 != 0xFF)//Unicode
                {
                    targetEncoding = Encoding.Unicode;
                }
                if (byte1 == 0xEF && byte2 == 0xBB && byte3 == 0xBF)//UTF8
                {
                    targetEncoding = Encoding.UTF8;
                }
                else
                {
                    if (fileSplit(stream))
                        targetEncoding = Encoding.UTF8;
                }
                //恢复Seek位置       
                stream.Seek(origPos, SeekOrigin.Begin);
            }
            return targetEncoding;
        }
        private static bool fileSplit(Stream stream)
        {
            int icount;
            int.TryParse(stream.Length.ToString(), out icount);
            BinaryReader r = new BinaryReader(stream, System.Text.Encoding.Default);
            int SplitSize = 1024;
            int CurrentSize = 0;
            byte[] data = new byte[SplitSize];
            bool result = true;
            int charByteCounter = 1;　 //计算当前正分析的字符应还有的字节数
            while (true)
            {
                if (result)
                {
                    CurrentSize = r.Read(data, 0, SplitSize);
                    result = IsUTF8Bytes(data, CurrentSize, ref charByteCounter);
                    if (CurrentSize < SplitSize)
                        break;
                }
                else
                    break;
            }
            //if (charByteCounter > 1)
            //{
            //    throw new Exception("非预期的byte格式!");
            //}
            return result;
        }
        /// <summary>
        /// 判断是否是不带 BOM 的 UTF8 格式
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private static bool IsUTF8Bytes(byte[] data, int CurrentSize, ref int charByteCounter)
        {
            byte curByte; //当前分析的字节.
            for (int i = 0; i < CurrentSize; i++)
            {
                curByte = data[i];
                if (charByteCounter == 1)
                {
                    if (curByte >= 0x80)
                    {
                        //判断当前
                        while (((curByte <<= 1) & 0x80) != 0)
                        {
                            charByteCounter++;
                        }
                        //标记位首位若为非0 则至少以2个1开始 如:110XXXXX...........1111110X　
                        if (charByteCounter == 1 || charByteCounter > 6)
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    //若是UTF-8 此时第一位必须为1
                    if ((curByte & 0xC0) != 0x80)
                    {
                        return false;
                    }
                    charByteCounter--;
                }
            }
            return true;
        }
        /// <summary>
        /// 判断是否为中文字符
        /// </summary>
        /// <param name="charinfo">字符信息</param>
        /// <returns></returns>
        public static bool IsChineseChar(string charinfo)
        {
            if (System.Text.Encoding.Default.GetByteCount(charinfo) == charinfo.Length)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// 判断文件类型
        /// </summary>
        /// <param name="Spath">源文件路径</param>
        /// <returns></returns>
        public static string GetFileType(string Spath)
        {
            string name = Spath.Substring(Spath.LastIndexOf('.') + 1);
            switch (name.ToLower())
            {
                case "txt":
                    return "TXT";
                case "xls":
                    return "XLS";
                case "xml":
                    return "XML";
            }
            return null;
        }
        /// <summary>
        /// 清空文件夹
        /// </summary>
        /// <param name="directoryPath">文件夹路径</param>
        /// <returns></returns>
        public static bool ClearDirectory(string directoryPath)
        {
            if (!Directory.Exists(directoryPath))
            {
                return false;
            }
            System.Threading.Thread.Sleep(500);
            string[] stFileList = Directory.GetFiles(directoryPath);
            foreach (string stFileName in stFileList)
            {
                File.Delete(stFileName);
            }
            string[] stDirectorys = Directory.GetDirectories(directoryPath);
            foreach (string stDirectory in stDirectorys)
            {
                Directory.Delete(stDirectory, true);
            }
            return true;
        }
        /// <summary>
        /// 拷贝文件至指定路径
        /// </summary>
        /// <param name="sourcePath">原文件路径</param>
        /// <param name="objectPath">目标文件路径</param>
        /// <returns>bool</returns>
        public static bool CopyFile(string sourcePath, string objectPath)
        {
            string stDirectoryPath = String.Empty;
            if (!Directory.Exists(sourcePath))
            {
                return false;
            }
            stDirectoryPath = GetDirectory(objectPath);
            if (String.IsNullOrEmpty(stDirectoryPath))
            {
                return false;
            }
            if (!Directory.Exists(stDirectoryPath))
            {
                Directory.CreateDirectory(stDirectoryPath);
            }
            File.Copy(sourcePath, objectPath);
            return true;
        }
        /// <summary>
        /// 分割字符串以取出文件路径中的路径名
        /// </summary>
        /// <param name="filePath">文件路径</param>
        /// <returns>string</returns>
        public static string GetDirectory(string filePath)
        {
            string stDirectoryPath = String.Empty;
            string[] stsFolder = filePath.Split('\\');
            if (stsFolder.Length != 0)
            {
                stDirectoryPath = filePath.Replace(stsFolder[stsFolder.Length - 1], String.Empty);
            }
            return stDirectoryPath;
        }

    }
}
