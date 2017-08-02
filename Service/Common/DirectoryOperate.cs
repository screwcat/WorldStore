using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Service.Common.IO
{
    public class DirectoryOperate
    {

        /// <summary>
        /// 获取文件（表名、路径）集合
        /// </summary>
        /// <param name="FilePath">文件夹路径</param>
        /// <param name="Extends">扩展名，*.txt</param>
        /// <returns></returns>
        public static FileInfo[] getAllFile(String FilePath, String Extends)
        {
            DirectoryInfo fo = new DirectoryInfo(FilePath);//路径     
            FileInfo[] files = new FileInfo[0];
            //如果Extends 传的是*.bmp
            if (fo.Exists)
            {
                files = fo.GetFiles(Extends);//路径下的所有bmp文件  

            }
            return files;
        }
        /// <summary>
        /// 摘要：清空文件夹
        /// </summary>
        /// <param name="path">路径</param>
        public static void ClearDirectory(string path)
        {
            DeleteDirectory(path);
            Directory.CreateDirectory(path);

        }
        /// <summary>
        /// 摘要：删除文件夹
        /// </summary>
        /// <param name="path">路径</param>
        public static void DeleteDirectory(string path)
        {
            string[] fileList = Directory.GetFileSystemEntries(path);
            // 遍历所有的文件和目录
            foreach (string fileOrPath in fileList)
            {
                // 先当作目录处理如果存在这个目录就递归Copy该目录下面的文件
                if (Directory.Exists(fileOrPath))
                    DeleteDirectory(fileOrPath);
                // 否则直接Copy文件
                else
                    File.Delete(fileOrPath);
            }
            Directory.Delete(path);
        }
        /// <summary>
        /// 摘要：拷贝文件夹
        /// </summary>
        /// <param name="oPath">原路径</param>
        /// <param name="tPath">目标路径</param>
        public static void CopyDirectory(string oPath, string tPath)
        {
            //// 检查目标目录是否以目录分割字符结束如果不是则添加之
            if (tPath[tPath.Length - 1] != Path.DirectorySeparatorChar)
                tPath += Path.DirectorySeparatorChar;
            // 判断目标目录是否存在如果不存在则新建之
            if (!Directory.Exists(tPath)) Directory.CreateDirectory(tPath);
            // 得到源目录的文件列表，该里面是包含文件以及目录路径的一个数组
            // 如果你指向copy目标文件下面的文件而不包含目录请使用下面的方法
            string[] fileList = Directory.GetFileSystemEntries(oPath);
            // 遍历所有的文件和目录
            foreach (string file in fileList)
            {
                // 先当作目录处理如果存在这个目录就递归Copy该目录下面的文件
                if (Directory.Exists(file))
                    CopyDirectory(file, tPath + Path.GetFileName(file));
                // 否则直接Copy文件
                else
                    File.Copy(file, tPath + Path.GetFileName(file), true);
            }
        }
        /// <summary>
        /// 要：拷贝文件
        /// </summary>
        /// <param name="oPath"></param>
        /// <param name="tPath"></param>
        public static void CopyFile(string fPath, string tPath)
        {
            //// 检查目标目录是否以目录分割字符结束如果不是则添加之
            if (tPath[tPath.Length - 1] != Path.DirectorySeparatorChar)
                tPath += Path.DirectorySeparatorChar;
            // 判断目标目录是否存在如果不存在则新建之
            if (!Directory.Exists(tPath)) Directory.CreateDirectory(tPath);

            //如果目标文件存在则直接Copy
            if (File.Exists(fPath)) File.Copy(fPath, tPath + Path.GetFileName(fPath), true);
        }
        /// <summary>
        /// 获取文件夹集合
        /// </summary>
        /// <param name="FilePath">路径</param>
        /// <param name="SubName">文件夹名关键字</param>
        /// <param name="BeginDate">创建时间</param>
        /// <param name="EndDate">创建时间</param>
        /// <returns></returns>
        public static DirectoryInfo[] GetAllDirectory(String FilePath, String SubName)
        {
            DirectoryInfo fo = new DirectoryInfo(FilePath);//路径     
            DirectoryInfo[] directorys = new DirectoryInfo[0];
            if (fo.Exists)
            {
                directorys = fo.GetDirectories(SubName + "*", SearchOption.TopDirectoryOnly);
            }
            return directorys;
        }
    }
}
