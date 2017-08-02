using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using WorldStore.DataBase;
using Service.Common.Data;

namespace Service.Common
{
    public static class ControlCommon
    {
        /// <summary>
        /// 绑定部门（门店）
        /// </summary>
        /// <param name="cb">ComboBox控件</param>
        public static void BindDept(ComboBox cb)
        {
            /*List<string[]> liWhere = new List<string[]>();
            List<string[]> liOrder = new List<string[]>();
            liWhere.Add(new string[] { "1 = '{0}'", "1" });
            liOrder.Add(new string[] { "VehOrder", "ASC" });*/
            DataTable dt = ExecuteSql.ExeComSqlForDataSet("SELECT Dept_ID,Name,Remark FROM Dept ").Tables[0];
            cb.DisplayMember = "Name";
            cb.ValueMember = "Dept_ID";
            cb.DataSource = dt;
        }

        /// <summary>
        /// 绑定人员
        /// </summary>
        /// <param name="cb">ComboBox控件</param>
        public static void BindEmployee(ComboBox cb)
        {
            DataTable dt = ExecuteSql.ExeComSqlForDataSet("SELECT Employee_ID,Name FROM Employee ").Tables[0];
            cb.DisplayMember = "Name";
            cb.ValueMember = "Employee_ID";
            cb.DataSource = dt;
        }


        /// <summary>
        /// 绑定仓库
        /// </summary>
        /// <param name="cb">ComboBox控件</param>
        public static void BindStoreHouse(ComboBox cb)
        {
            DataTable dt = ExecuteSql.ExeComSqlForDataSet("SELECT StoreHouse_ID,Address FROM StoreHouse ").Tables[0];
            cb.DisplayMember = "Address";
            cb.ValueMember = "StoreHouse_ID";
            cb.DataSource = dt;
        }

        /// <summary>
        /// 绑定客户
        /// </summary>
        /// <param name="cb">ComboBox控件</param>
        public static void BindCustomer(ComboBox cb)
        {
            DataTable dt = ExecuteSql.ExeComSqlForDataSet("SELECT Customer_ID,Name FROM Customer ").Tables[0];
            cb.DisplayMember = "Name";
            cb.ValueMember = "Customer_ID";
            cb.DataSource = dt;
        }

        /// <summary>
        /// 绑定大分类
        /// </summary>
        /// <param name="cb">ComboBox控件</param>
        public static void BindProductClass(ComboBox cb)
        {
            DataTable dt = ExecuteSql.ExeComSqlForDataSet("SELECT ProductClass_ID,Name FROM ProductClass").Tables[0];
            cb.DisplayMember = "Name";
            cb.ValueMember = "ProductClass_ID";
            DataRow dr = dt.NewRow();
            dr["ProductClass_ID"] = 0;
            dr["Name"] = "<—全部—>";
            dt.Rows.InsertAt(dr, 0);
            cb.DataSource = dt;
            cb.SelectedIndex = 0;
        }



        /// <summary>
        /// 正整数和负整数
        /// </summary>
        /// <param name="tb"></param>
        /// <param name="e"></param>
        public static void VerDigitalHL(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8 && e.KeyChar != (char)45)
            {
                e.Handled = true;
            }
            else
            {
                if (e.KeyChar == (char)45)
                {
                    if (((TextBox)sender).Text.StartsWith("-"))
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        /// <summary>
        /// 只能输入正整数
        /// </summary>
        /// <param name="e"></param>
        public static void VerDigital(KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// 只能输入两位小数的数字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void VerDecimal(object sender, KeyPressEventArgs e)
        {
            //判断按键是不是要输入的类型。
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 46)
            {
                e.Handled = true;  //小数点的处理。
            }
            else
            {
                if ((int)e.KeyChar != 8)
                {
                    if (((TextBox)sender).Text.Contains("."))
                    {
                        string[] SectionText = ((TextBox)sender).Text.Split(new char[] { '.' });
                        if (SectionText[1].Length > 1)
                        {
                            e.Handled = true;
                        }
                    }

                }
            }
            if ((int)e.KeyChar == 46)                           //小数点
            {
                if (((TextBox)sender).Text.Length <= 0)
                { e.Handled = true; }   //小数点不能在第一位
                else
                {
                    float f;
                    float oldf;
                    bool b1 = false, b2 = false;
                    b1 = float.TryParse(((TextBox)sender).Text, out oldf);
                    b2 = float.TryParse(((TextBox)sender).Text + e.KeyChar.ToString(), out f);
                    if (b2 == false)
                    {
                        if (b1 == true)
                        { e.Handled = true; }
                        else
                        { e.Handled = false; }
                    }
                }
            }
        }
    }
}
