using System;
using System.Runtime.InteropServices;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Configuration;
using System.Text;
using Service.Common.Data;

namespace Service.Common
{
    public class PrintCommon
    {
        private IntPtr iHandle;
        private FileStream fs;
        private StreamWriter sw;

        private string prnPort = ConfigurationManager.AppSettings.Get("PrintPort");
        public PrintCommon()
        {

        }

        private const uint GENERIC_READ = 0x80000000;
        private const uint GENERIC_WRITE = 0x40000000;
        private const int OPEN_EXISTING = 3;

        /// <summary>
        /// 打开一个vxd(设备)
        /// </summary>
        [DllImport("kernel32.dll", EntryPoint = "CreateFile", CharSet = CharSet.Auto)]
        private static extern IntPtr CreateFile(string lpFileName, uint dwDesiredAccess, int dwShareMode, int lpSecurityAttributes,
                                                int dwCreationDisposition, int dwFlagsAndAttributes, int hTemplateFile);

        /// <summary>
        /// 开始连接打印机
        /// </summary>
        private bool PrintOpen()
        {
            iHandle = CreateFile(prnPort, GENERIC_READ | GENERIC_WRITE, 0, 0, OPEN_EXISTING, 0, 0);

            if (iHandle.ToInt32() == -1)
            {
                MessageBox.Show("没有开启打印机或者没有连接打印机或者打印机端口配置不正确！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                fs = new FileStream(iHandle, FileAccess.ReadWrite);
                sw = new StreamWriter(fs, System.Text.Encoding.Default);   //写数据
                return true;
            }
        }

        /// <summary>
        /// 打印字符串
        /// </summary>
        /// <param name="str">要打印的字符串</param>
        private void PrintLine(string str)
        {
            sw.WriteLine(str); ;
        }

        /// <summary>
        /// 关闭打印连接
        /// </summary>
        private void PrintEnd()
        {
            sw.Close();
            fs.Close();
        }

        /// <summary>
        /// 打印票据
        /// </summary>
        /// <param name="ds">tb_Temp 全部字段数据集合</param>
        /// <returns>true：打印成功 false：打印失败</returns>
        /*public bool PrintDataSet(DataSet dsPrint, Sale SaleInfo)
        {
            try
            {
                if (PrintOpen())
                {
                    PrintLine(" ");
                    PrintLine("        [XXXXXXXX饭店]");
                    PrintLine(" ");
                    PrintLine("单号：" +SaleInfo.TradeNo);
                    PrintLine("--------------------------------");
                    PrintLine("商品名称      单价 数量  　金额");
                    for (int i = 0; i < dsPrint.Tables[0].Rows.Count; i++)
                    {
                        PrintLine(AlignCharacters(dsPrint.Tables[0].Rows[i]["ProductName"].ToString(), 10) + "|" + AlignCharactersBefore(Convert.ToDecimal(dsPrint.Tables[0].Rows[i]["PaidIn1"]).ToString("f2"), 7) + "|" + AlignCharactersBefore((Convert.ToInt32(dsPrint.Tables[0].Rows[i]["Quantity"])).ToString(), 3) + "|" + AlignCharactersBefore(Convert.ToDecimal(dsPrint.Tables[0].Rows[i]["PaidInAmount"]).ToString("f2"), 8));
                    }
                    PrintLine("--------------------------------");
                    PrintLine("合计：" + SaleInfo.TotalAmount.ToString("f2") + "元");

                    string msg = "";
                    if (SaleInfo.Cash > 0)
                    {
                        msg += "现金：" + SaleInfo.Cash.ToString("f2") + "元 ";
                    }
                    if (SaleInfo.UnionPay > 0)
                    {
                        msg += "银联卡支付：" + SaleInfo.UnionPay.ToString("f2") + "元 ";
                    }
                    if (SaleInfo.MemCard > 0)
                    {
                        msg += "会员卡支付：" + SaleInfo.MemCard.ToString("f2") + "元 ";
                    }
                    if (SaleInfo.OtherPayment > 0)
                    {
                        msg += "其他方式支付：" + SaleInfo.OtherPayment.ToString("f2") + "元 ";
                    }

                    PrintLine(msg);

                    PrintLine("--------------------------------");
                    if (SaleInfo.Account!="0000")
                    {
                        MemberCard mc = new MemberCard();
                        mc.FindbyPK(ExecuteSql.ExeComSqlForDataSet("SELECT ID FROM MemberCard WHERE CardNO = " + SaleInfo.Account).Tables[0].Rows[0][0].ToString());
                        PrintLine("会员卡号：" + SaleInfo.Account);

                        PrintLine("卡内余额：" + mc.Balance.ToString("f2"));
                        PrintLine("--------------------------------");
                    }
                    PrintLine("开单时间：" + SaleInfo.SaleDate.ToString("yyyy-M-d HH:mm:ss"));
                    PrintLine("结帐时间：" + SaleInfo.CheckoutTime.ToString("yyyy-M-d HH:mm:ss"));
                    Employee emp = new Employee();
                    emp.FindbyPK(SaleInfo.Employee_ID.ToString());
                    PrintLine("操作员: " + emp.Name);
                    PrintLine("地址：沈阳市皇姑区歧山中路00号  ");
                    PrintLine("联系电话：18888888888           ");
                    PrintLine("--------------------------------");
                    PrintLine("      感 谢 您 的 惠 顾 ！      ");
                    PrintLine("      欢 迎 再 次 光 临 ！      ");
                    PrintLine("");
                    PrintLine("");
                    PrintLine("");
                    PrintLine("");
                }
                PrintEnd();
                return true;
            }
            catch
            {
                return false;
            }
        }*/

        private string AlignCharacters(string Text,Int32 ChLenth)
        {
            string AlText = "";
            Int32 TextLength = GetLength(Text);
            Int32 AddCount = 0;
            if (TextLength <= ChLenth)
            {
                AddCount = ChLenth - TextLength;
                AlText += Text;
                for (int i = 0; i < AddCount; i++)
                {
                    AlText += " ";
                }
            }
            else
            {
                for (int i = 0; i < TextLength; i++)
                {
                    AlText += Text.Substring(i, 1);
                    if (GetLength(AlText) == ChLenth)
                    {
                        break;
                    }
                    if (GetLength(AlText) > ChLenth)
                    {
                        AlText = AlText.Substring(0, AlText.Length - 1);
                        AlText += " ";
                        break;
                    }
                }
            }
            return AlText;
        }

        private string AlignCharactersBefore(string Text, Int32 ChLenth)
        {
            string AlText = "";
            Int32 TextLength = GetLength(Text);
            Int32 AddCount = 0;
            if (TextLength <= ChLenth)
            {
                AddCount = ChLenth - TextLength;
                AlText += Text;
                for (int i = 0; i < AddCount; i++)
                {
                    AlText = " " + AlText;
                }
            }
            else
            {
                for (int i = 0; i < TextLength; i++)
                {
                    AlText += Text.Substring(i, 1);
                    if (GetLength(AlText) == ChLenth)
                    {
                        break;
                    }
                    if (GetLength(AlText) > ChLenth)
                    {
                        AlText = AlText.Substring(0, AlText.Length - 1);
                        AlText = " " + AlText;
                        break;
                    }
                }
            }
            return AlText;
        }



        public int GetLength(string str)
        {
            if (str.Length == 0) return 0;
            ASCIIEncoding ascii = new ASCIIEncoding();
            int tempLen = 0; byte[] s = ascii.GetBytes(str);
            for (int i = 0; i < s.Length; i++)
            {
                if ((int)s[i] == 63)
                {
                    tempLen += 2;
                }
                else
                {
                    tempLen += 1;
                }
            }
            return tempLen;
        } 


        /// <summary>
        /// ESC/P 指令
        /// </summary>
        /// <param name="iSelect">0：退纸命令 1：进纸命令 2：换行命令</param>
        public void PrintESC(int iSelect)
        {
            string send;

            iHandle = CreateFile(prnPort, GENERIC_READ | GENERIC_WRITE, 0, 0, OPEN_EXISTING, 0, 0);

            if (iHandle.ToInt32() == -1)
            {
                MessageBox.Show("没有连接打印机或者打印机端口不是LPT1！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                fs = new FileStream(iHandle, FileAccess.ReadWrite);
            }

            byte[] buf = new byte[80];

            switch (iSelect)
            {
                case 0:
                    send = "" + (char)(27) + (char)(64) + (char)(27) + 'j' + (char)(255);    //退纸1 255 为半张纸长
                    send = send + (char)(27) + 'j' + (char)(125);    //退纸2
                    break;
                case 1:
                    send = "" + (char)(27) + (char)(64) + (char)(27) + 'J' + (char)(255);    //进纸
                    break;
                case 2:
                    send = "" + (char)(27) + (char)(64) + (char)(12);   //换行
                    break;
                default:
                    send = "" + (char)(27) + (char)(64) + (char)(12);   //换行
                    break;
            }

            for (int i = 0; i < send.Length; i++)
            {
                buf[i] = (byte)send[i];
            }

            fs.Write(buf, 0, buf.Length);
            fs.Close();
        }


    }
}
