using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;
using System.IO;
using System.Text;


namespace Service.Common
{
    /// <summary>
    ///XmlMethod 的摘要说明
    /// </summary>
    public static class XmlMethod
    {
        static XmlMethod() { }
        public static ExcelModel FromFile(string filePath)
        {
            ExcelModel excel = new ExcelModel();
            XmlSerializer serializer = new XmlSerializer(excel.GetType());
            using (TextReader tr = new StreamReader(filePath, Encoding.UTF8))
            {
                excel = (ExcelModel)serializer.Deserialize(tr);
            }
            return excel;
        }

        public static void SaveToFile(string filePath, ExcelModel excel)
        {
            XmlSerializer serializer = new XmlSerializer(excel.GetType());

            using (TextWriter tw = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                serializer.Serialize(tw, excel);
            }
        }
    }
}