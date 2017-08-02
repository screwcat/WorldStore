using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;
using System.Text.RegularExpressions;
using NPOI.SS.UserModel;
using NPOI.HSSF.UserModel;
using Service.Common.Log;
using System.Threading;

namespace Service.Common
{
    public delegate void ExcelExportEntrust(Int32 Schedule);
    public class ExcelExport
    {
        public event ExcelExportEntrust ExportEvent;
        public void Export(DataSet ds, string confFile, string SavePath)
        {
            ReturnMessage rm = new ReturnMessage();
            ExcelModel excel = XmlMethod.FromFile(Environment.CurrentDirectory + "\\ExportConf\\" + confFile + ".XML");
            string ExcelTemplate = excel.TemplateName;



            HSSFWorkbook hssfworkbook = new HSSFWorkbook();
            FileStream file1 = new FileStream(Environment.CurrentDirectory + "\\ExportConf\\" + ExcelTemplate, FileMode.Open, FileAccess.Read);
            hssfworkbook = new HSSFWorkbook(file1);
            file1.Close();


            for (int i = 0; i < excel.Sheets.Count; i++)
            {
                HSSFSheet s1 = (HSSFSheet)hssfworkbook.GetSheetAt(i);

                SheetModel sheet = excel.Sheets[i];

                Int32 ExcelStartRow = sheet.ExcelStartRow;


                if (ds.Tables.Count > 0)
                {
                    for (int j = 0; j < sheet.FixedFileds.Count; j++)
                    {
                        if (ds.Tables.Contains(ds.Tables[sheet.FixedFileds[j].DataFieldTable].TableName))
                        {
                            s1.GetRow(GetRowNum(sheet.FixedFileds[j].CellName) - 1).GetCell(GetColumnNum(sheet.FixedFileds[j].CellName)).SetCellValue(ds.Tables[sheet.FixedFileds[j].DataFieldTable].Rows[sheet.FixedFileds[j].DataFieldRow][sheet.FixedFileds[j].DataFieldColumn].ToString());
                        }
                    }
                }
                else
                {
                    rm.Message = "DataSet中没有表！";
                    goto H1;
                }



                HSSFCellStyle style = (HSSFCellStyle)hssfworkbook.CreateCellStyle();
                style.BorderBottom = (NPOI.SS.UserModel.BorderStyle)BorderStyle.Thin;
                style.BorderLeft = (NPOI.SS.UserModel.BorderStyle)BorderStyle.Thin;
                style.BorderRight = (NPOI.SS.UserModel.BorderStyle)BorderStyle.Thin;
                style.BorderTop = (NPOI.SS.UserModel.BorderStyle)BorderStyle.Thin;


                if (sheet.CycleFileds.Count > 0)
                {
                    for (int k = sheet.DataStartRow; k < ds.Tables[sheet.TableIndex].Rows.Count - sheet.DataStartRow; k++)
                    {
                        for (int j = 0; j < sheet.CycleFileds.Count; j++)
                        {
                            if (ds.Tables[sheet.TableIndex].Columns.Contains(sheet.CycleFileds[j].DataFieldName))
                            {
                                s1.GetRow(ExcelStartRow).CreateCell(GetColumnNum(sheet.CycleFileds[j].CellName)).SetCellValue(ds.Tables[sheet.TableIndex].Rows[k][sheet.CycleFileds[j].DataFieldName].ToString());
                                s1.GetRow(ExcelStartRow).GetCell(GetColumnNum(sheet.CycleFileds[j].CellName)).CellStyle = style;
                            }
                            else
                            {
                                rm.Message = "数据表中不存在列名【" + sheet.CycleFileds[j].DataFieldName + "】";
                                goto H1;
                            }
                        }
                        MyInsertRow(s1, ExcelStartRow + 1, 1, (HSSFRow)s1.GetRow(ExcelStartRow));
                        ExcelStartRow++;

                        if (ExportEvent!=null)
                        {
                            ExportEvent(Convert.ToInt32(((double)k / (double)(ds.Tables[sheet.TableIndex].Rows.Count)) * 100));//报告进度
                            Thread.Sleep(5);
                        }
                    }
                }
            }
            string TimeName = DateTime.Now.ToString("yyyyMMddHHmmssfff");
            string path = SavePath + TimeName + ".XLS";
            FileStream file = new FileStream(path, FileMode.Create);
            hssfworkbook.Write(file);
            file.Close();

        H1: return;
        }
        Int32 GetRowNum(string CellName)
        {
            Regex rgx = new Regex(@"[A-Za-z]*");
            Int32 ColumnNum = Convert.ToInt32(rgx.Replace(CellName, ""));
            return ColumnNum;
        }
        Int32 GetColumnNum(string CellName)
        {
            Regex rgx = new Regex(@"[0-9]*");
            Int32 RowNum = TsAry(rgx.Replace(CellName, ""));
            return RowNum;
        }

        Int32 TsAry(string ColName)
        {
            ColName = ColName.ToLower();
            char[] CharArray = ColName.ToCharArray();
            Int32 Sum = 0;
            Int32 j = 1;
            for (int i = CharArray.Length - 1; i > -1; i--)
            {
                Sum += (Convert.ToInt32(CharArray[i]) - 96) * j;
                j = j * 26;
            }
            return Sum - 1;
        }
        private void MyInsertRow(HSSFSheet sheet, int InsertRowNum, int InsertRowCount, HSSFRow InsertSourceRow)
        {
            sheet.ShiftRows(InsertRowNum, sheet.LastRowNum, InsertRowCount, true, false, true);

            for (int i = InsertRowNum; i < InsertRowNum + InsertRowCount - 1; i++)
            {
                HSSFRow targetRow = null;
                HSSFCell sourceCell = null;
                HSSFCell targetCell = null;

                targetRow = (HSSFRow)sheet.CreateRow(i + 1);

                for (int j = InsertSourceRow.FirstCellNum; j < InsertSourceRow.LastCellNum; j++)
                {
                    sourceCell = (HSSFCell)InsertSourceRow.GetCell(j);
                    if (sourceCell == null)
                    {
                        continue;
                    }
                    targetCell = (HSSFCell)targetRow.CreateCell(j);
                    targetCell.CellStyle = sourceCell.CellStyle;
                    targetCell.SetCellType(sourceCell.CellType);
                }
            }
            HSSFRow firstTargetRow = (HSSFRow)sheet.GetRow(InsertRowNum);
            HSSFCell firstSourceCell = null;
            HSSFCell firstTargetCell = null;
            for (int m = InsertSourceRow.FirstCellNum; m < InsertSourceRow.LastCellNum; m++)
            {
                firstSourceCell = (HSSFCell)InsertSourceRow.GetCell(m);
                if (firstSourceCell == null)
                {
                    continue;
                }
                firstTargetCell = (HSSFCell)firstTargetRow.CreateCell(m);
                firstTargetCell.CellStyle = firstSourceCell.CellStyle;
                firstTargetCell.SetCellType(firstSourceCell.CellType);
            }
        }

    }

    public class ExcelModel
    {
        public ExcelModel()
        {
            //
            //TODO: 在此处添加构造函数逻辑
            //
        }
        private List<SheetModel> sheets = new List<SheetModel>();

        private string templateName;

        public List<SheetModel> Sheets
        {
            get { return sheets; }
            set { sheets = value; }
        }
        public string TemplateName
        {
            get { return templateName; }
            set { templateName = value; }
        }
    }

    public class SheetModel
    {
        private string sheetName;

        private int dataStartRow;

        private int excelStartRow;

        private int tableIndex;


        private List<DataCoor> fixedFileds = new List<DataCoor>();

        private List<FieldItem> cycleFileds = new List<FieldItem>();

        public List<DataCoor> FixedFileds
        {
            get { return fixedFileds; }
            set { fixedFileds = value; }
        }

        public List<FieldItem> CycleFileds
        {
            get { return cycleFileds; }
            set { cycleFileds = value; }
        }

        public int DataStartRow
        {
            get { return dataStartRow; }
            set { dataStartRow = value; }
        }

        public int ExcelStartRow
        {
            get { return excelStartRow; }
            set { excelStartRow = value; }
        }

        public string SheetName
        {
            get { return sheetName; }
            set { sheetName = value; }
        }

        public int TableIndex
        {
            get { return tableIndex; }
            set { tableIndex = value; }
        }
    }

    public class FieldItem
    {
        private string dataFieldName;

        private string cellName;

        public string CellName
        {
            get { return cellName; }
            set { cellName = value; }
        }
        public string DataFieldName
        {
            get { return dataFieldName; }
            set { dataFieldName = value; }
        }
    }

    public class DataCoor
    {
        private Int32 dataFieldTable;

        private Int32 dataFieldRow;

        private Int32 dataFieldColumn;

        private string cellName;

        public Int32 DataFieldTable
        {
            get { return dataFieldTable; }
            set { dataFieldTable = value; }
        }

        public string CellName
        {
            get { return cellName; }
            set { cellName = value; }
        }
        public Int32 DataFieldRow
        {
            get { return dataFieldRow; }
            set { dataFieldRow = value; }
        }
        public Int32 DataFieldColumn
        {
            get { return dataFieldColumn; }
            set { dataFieldColumn = value; }
        }
    }
}