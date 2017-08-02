using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ICSharpCode.SharpZipLib.Checksums;
using ICSharpCode.SharpZipLib.Zip;
using ICSharpCode.SharpZipLib.GZip;
using System.IO;
using System.ComponentModel;

namespace Service.Common.IO
{
    /// <summary>
    /// 压缩、解压缩文件类
    /// 需要ICSharpCode.SharpZipLib.dll支持
    /// </summary>
    public class Zip
    {
        public void ZipFile(string FileToZip, string ZipedFile, int CompressionLevel, int BlockSize)
        {
            //如果文件没有找到，则报错
            if (!System.IO.File.Exists(FileToZip))
            {
                throw new System.IO.FileNotFoundException("The specified file " + FileToZip + " could not be found. Zipping aborderd");
            }

            System.IO.FileStream StreamToZip = new System.IO.FileStream(FileToZip, System.IO.FileMode.Open, System.IO.FileAccess.Read);
            System.IO.FileStream ZipFile = System.IO.File.Create(ZipedFile);
            ZipOutputStream ZipStream = new ZipOutputStream(ZipFile);
            ZipEntry ZipEntry = new ZipEntry("ZippedFile");
            ZipStream.PutNextEntry(ZipEntry);
            ZipStream.SetLevel(CompressionLevel);
            byte[] buffer = new byte[BlockSize];
            System.Int32 size = StreamToZip.Read(buffer, 0, buffer.Length);
            ZipStream.Write(buffer, 0, size);
            try
            {
                while (size < StreamToZip.Length)
                {
                    int sizeRead = StreamToZip.Read(buffer, 0, buffer.Length);
                    ZipStream.Write(buffer, 0, sizeRead);
                    size += sizeRead;
                }
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            ZipStream.Finish();
            ZipStream.Close();
            StreamToZip.Close();
        }

        public void ZipFile(string[] args)
        {
            Crc32 crc = new Crc32();
            ZipOutputStream s = new ZipOutputStream(File.Create(args[0]));

            s.SetLevel(6); // 0 - store only to 9 - means best compression
            s.UseZip64 = UseZip64.On;

            for (int i = 1; i < args.Length; i++)
            {
                //打开压缩文件
                string file = args[i];
                FileStream fs = File.OpenRead(file);

                byte[] buffer = new byte[fs.Length];
                fs.Read(buffer, 0, buffer.Length);
                ZipEntry entry = new ZipEntry(file);

                entry.DateTime = DateTime.Now;

                // set Size and the crc, because the information
                // about the size and crc should be stored in the header
                // if it is not set it is automatically written in the footer.
                // (in this case size == crc == -1 in the header)
                // Some ZIP programs have problems with zip files that don't store
                // the size and crc in the header.
                entry.Size = fs.Length;
                fs.Close();

                crc.Reset();
                crc.Update(buffer);

                entry.Crc = crc.Value;

                s.PutNextEntry(entry);

                s.Write(buffer, 0, buffer.Length);

            }

            s.Finish();
            s.Close();
        }

        public void UnZip(string[] args)
        {
            ZipInputStream s = new ZipInputStream(File.OpenRead(args[0]));


            ZipEntry theEntry;
            while ((theEntry = s.GetNextEntry()) != null)
            {

                //   string directoryName = Path.GetDirectoryName(args[1]);

                string fileName = Path.GetFileName(theEntry.Name);
                string directoryName = args[1];
                //生成解压目录
                //Directory.CreateDirectory(directoryName);

                if (fileName != String.Empty)
                {
                    //解压文件到指定的目录
                    string temp = fileName;
                    FileStream streamWriter = File.Create(args[1] + temp);

                    int size = 2048;
                    byte[] data = new byte[2048];
                    while (true)
                    {
                        size = s.Read(data, 0, data.Length);
                        if (size > 0)
                        {
                            streamWriter.Write(data, 0, size);
                        }
                        else
                        {
                            break;
                        }
                    }

                    streamWriter.Close();
                }
            }
            s.Close();
        }

        /// <summary>
        /// 压缩目录
        /// </summary>
        /// <param name="args">数组(数组[0]: 要压缩的文件数组)</param>
        /// <param name="stBackPath">备份的路径</param>
        public void ZipFileDictory(DirectoryInfo dinfo, string stBackPath)
        {

            FileInfo[] fileinfo = dinfo.GetFiles();
            Crc32 crc = new Crc32();
            ZipOutputStream s = new ZipOutputStream(File.Create(stBackPath));
            s.SetLevel(6);
            s.UseZip64 = UseZip64.On;
            foreach (FileInfo fi in fileinfo)
            {
                //打开压缩文件               
                FileStream fs = File.OpenRead(fi.FullName);
                int BlockSize = 134217728;

                byte[] buffer = new byte[BlockSize];
                int DataSize = 0;
                int num = fi.FullName.LastIndexOf('\\');
                ZipEntry entry = new ZipEntry(fi.FullName.Substring(num, fi.FullName.Length - num).Remove(0, 1));
                entry.DateTime = DateTime.Now;
                s.PutNextEntry(entry);
                while (DataSize < fs.Length)
                {
                    int sizeRead = fs.Read(buffer, 0, buffer.Length);
                    // s.PutNextEntry(entry);
                    s.Write(buffer, 0, sizeRead);

                    DataSize += sizeRead;
                }
                fs.Close();
            }

            s.Finish();
            s.Close();
        }

        /// <summary>
        /// 压缩目录
        /// </summary>
        /// <param name="dinfo">文件夹信息</param>
        /// <param name="stBackPath">输出路径</param>
        /// <param name="bgw">线程控件</param>
        public void ZipFileDictory(DirectoryInfo dinfo, string stBackPath, BackgroundWorker bgw)
        {

            Crc32 crc = new Crc32();
            ZipOutputStream s = new ZipOutputStream(File.Create(stBackPath));
            s.SetLevel(6);
            s.UseZip64 = UseZip64.On;
            decimal dAllK = 0;
            foreach (FileInfo fi in dinfo.GetFiles())
            {
                if (!fi.Name.ToLower().Contains(".zip"))
                {
                    FileStream fs = new FileStream(fi.FullName, FileMode.Open);
                    dAllK += fs.Length;
                    fs.Flush();
                    fs.Close();
                    fs.Dispose();
                }
            }
            int BlockSize = 134217728;
            decimal rate = 0;



            foreach (FileInfo fi in dinfo.GetFiles())
            {
                if (!fi.Name.ToLower().Contains(".zip"))
                {
                    //打开压缩文件               
                    FileStream fs = File.OpenRead(fi.FullName);


                    byte[] buffer = new byte[BlockSize];
                    long DataSize = 0;
                    int num = fi.FullName.LastIndexOf('\\');
                    ZipEntry entry = new ZipEntry(fi.FullName.Substring(num, fi.FullName.Length - num).Remove(0, 1));
                    entry.DateTime = DateTime.Now;
                    s.PutNextEntry(entry);
                    while (DataSize < fs.Length)
                    {
                        int sizeRead = fs.Read(buffer, 0, buffer.Length);
                        ///计算进度块
                        decimal dAgglomeration = (dAllK * 100 / (decimal)sizeRead) / 100;
                        dAgglomeration = (50 / dAgglomeration);
                        ///
                        // s.PutNextEntry(entry);
                        s.Write(buffer, 0, sizeRead);

                        DataSize += sizeRead;
                        ///计算进度块
                        rate += dAgglomeration;
                        if (Convert.ToInt64(rate) > 50)
                        {
                            bgw.ReportProgress(50);
                        }
                        {
                            bgw.ReportProgress(Convert.ToInt16(rate));
                        }
                    }
                    fs.Close();
                }
            }

            s.Finish();
            s.Close();
        }
    }
}

