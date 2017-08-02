using Service.Common;
using System;
using System.Threading;
using System.Windows.Forms;
using WorldStore.Controls;
using WorldStore.Controls.Sales;
using WorldStore.DataBase;

namespace WorldStore
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            switch (e.Node.Tag.ToString())
            {
                case "PassWordEdit"://密码修改
                    {
                        splitContainer1.Panel2.Controls.Clear();
                        splitContainer1.Panel2.Controls.Add(new UC_PassWordEdit());
                        break;
                    }
                case "PowerManage"://权限管理
                    {
                        /*frm_PowerManage powerManage = new frm_PowerManage();
                        powerManage.ShowDialog();*/
                        splitContainer1.Panel2.Controls.Clear();
                        splitContainer1.Panel2.Controls.Add(new UC_PowerManage());
                        break;
                    }
                case "BuyOrder"://进货管理
                    {
                        splitContainer1.Panel2.Controls.Clear();
                        splitContainer1.Panel2.Controls.Add(new UC_BuyOrder());
                        break;
                    }
                case "StockView"://仓库库存情况
                    {
                        splitContainer1.Panel2.Controls.Clear();
                        splitContainer1.Panel2.Controls.Add(new UC_StockView());
                        break;
                    }
                case "SaleModify"://售货单修改
                    {
                        splitContainer1.Panel2.Controls.Clear();
                        splitContainer1.Panel2.Controls.Add(new UC_SaleModify());
                        break;
                    }
                case "EnterStockEdit"://入库单修改
                    {
                        splitContainer1.Panel2.Controls.Clear();
                        splitContainer1.Panel2.Controls.Add(new UC_EnterStockEdit());
                        break;
                    }
                case "Sale"://销售开单
                    {
                        splitContainer1.Panel2.Controls.Clear();
                        splitContainer1.Panel2.Controls.Add(new UC_Sale());
                        break;
                    }
                case "BackSale"://前台退货
                    {
                        splitContainer1.Panel2.Controls.Clear();
                        splitContainer1.Panel2.Controls.Add(new UC_BackSale());
                        break;
                    }
                case "SaleReport"://销售记录
                    {
                        splitContainer1.Panel2.Controls.Clear();
                        splitContainer1.Panel2.Controls.Add(new UC_SaleReport());
                        break;
                    }
                case "BackSaleRecord"://退货记录
                    {
                        splitContainer1.Panel2.Controls.Clear();
                        splitContainer1.Panel2.Controls.Add(new UC_BackSaleRecord());
                        break;
                    }
                case "AddLeaveStock"://仓库调拔
                    {
                        splitContainer1.Panel2.Controls.Clear();
                        splitContainer1.Panel2.Controls.Add(new UC_AddLeaveStock());
                        break;
                    }
                case "AddStockContract"://填写入库
                    {
                        splitContainer1.Panel2.Controls.Clear();
                        splitContainer1.Panel2.Controls.Add(new UC_AddStockContract());
                        break;
                    }
                case "AddBackStock"://物品出库
                    {
                        splitContainer1.Panel2.Controls.Clear();
                        splitContainer1.Panel2.Controls.Add(new UC_AddBackStock());
                        break;
                    }
                case "EnterStockRecord"://进货记录
                    {
                        splitContainer1.Panel2.Controls.Clear();
                        splitContainer1.Panel2.Controls.Add(new UC_EnterStockRecord());
                        break;
                    }
                case "BackStockRecord"://出库记录
                    {
                        splitContainer1.Panel2.Controls.Clear();
                        splitContainer1.Panel2.Controls.Add(new UC_BackStockRecord());
                        break;
                    }
                case "TransferRecord"://仓库调拔记录
                    {
                        splitContainer1.Panel2.Controls.Clear();
                        splitContainer1.Panel2.Controls.Add(new UC_TransferRecord());
                        break;
                    }
                case "productflowing"://查询出入记录
                    {
                        splitContainer1.Panel2.Controls.Clear();
                        splitContainer1.Panel2.Controls.Add(new UC_productflowing());
                        break;
                    }
                case "SaleGather"://销售汇总
                    {
                        splitContainer1.Panel2.Controls.Clear();
                        splitContainer1.Panel2.Controls.Add(new UC_SaleGather());
                        break;
                    }
                case "SaleDefinite"://销售明细
                    {
                        splitContainer1.Panel2.Controls.Clear();
                        splitContainer1.Panel2.Controls.Add(new UC_SaleDefinite());
                        break;
                    }
                case "EnterStockGather"://入库汇总
                    {
                        splitContainer1.Panel2.Controls.Clear();
                        splitContainer1.Panel2.Controls.Add(new UC_EnterStockGather());
                        break;
                    }
                case "EnterStockDefinite"://入库明细
                    {
                        splitContainer1.Panel2.Controls.Clear();
                        splitContainer1.Panel2.Controls.Add(new UC_EnterStockDefinite());
                        break;
                    }
                case "CheckStock"://库存盘点
                    {
                        splitContainer1.Panel2.Controls.Clear();
                        splitContainer1.Panel2.Controls.Add(new UC_CheckStock());
                        break;
                    }
                case "HisTab"://查看历史报表
                    {
                        splitContainer1.Panel2.Controls.Clear();
                        splitContainer1.Panel2.Controls.Add(new UC_HisTab());
                        break;
                    }
                case "Customer"://客户资料
                    {
                        splitContainer1.Panel2.Controls.Clear();
                        splitContainer1.Panel2.Controls.Add(new UC_Customer());
                        break;
                    }
                case "Supplier"://供应商管理
                    {
                        splitContainer1.Panel2.Controls.Clear();
                        splitContainer1.Panel2.Controls.Add(new UC_Supplier());
                        break;
                    }
                case "product"://商品资料
                    {
                        splitContainer1.Panel2.Controls.Clear();
                        splitContainer1.Panel2.Controls.Add(new UC_product());
                        break;
                    }
                case "ProductSpec"://商品规格管理
                    {
                        splitContainer1.Panel2.Controls.Clear();
                        splitContainer1.Panel2.Controls.Add(new UC_ProductSpec());
                        break;
                    }
                case "ProductUnit"://商品单位管理
                    {
                        splitContainer1.Panel2.Controls.Clear();
                        splitContainer1.Panel2.Controls.Add(new UC_ProductUnit());
                        break;
                    }
                case "ProductClass"://商品总分类
                    {
                        splitContainer1.Panel2.Controls.Clear();
                        splitContainer1.Panel2.Controls.Add(new UC_ProductClass());
                        break;
                    }
                case "ProductList"://商品详细分类
                    {
                        splitContainer1.Panel2.Controls.Clear();
                        splitContainer1.Panel2.Controls.Add(new UC_ProductList());
                        break;
                    }
                case "Dept"://部门管理
                    {
                        splitContainer1.Panel2.Controls.Clear();
                        splitContainer1.Panel2.Controls.Add(new UC_Dept());
                        break;
                    }
                case "StoreHouse"://仓库管理
                    {
                        splitContainer1.Panel2.Controls.Clear();
                        splitContainer1.Panel2.Controls.Add(new UC_StoreHouse());
                        break;
                    }
                case "DataBackup"://数据备份
                    {
                        splitContainer1.Panel2.Controls.Clear();
                        splitContainer1.Panel2.Controls.Add(new UC_DataBackup());
                        break;
                    }

                default:
                    break;
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("确定要退出程序吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                System.Environment.Exit(0);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            frm_Login frmLogin = new frm_Login();
            DialogResult dr = frmLogin.ShowDialog();
        }

        private void FormMain_VisibleChanged(object sender, EventArgs e)
        {
            tsslTime.Text = DateTime.Now.ToString("yyyy年M月d日 ") + DateTimeCommon.getWeek(Convert.ToInt32(DateTime.Now.DayOfWeek)) + " 农历：" + DateTimeCommon.GetChineseDate(DateTime.Now);
            Employee emp = new Employee();
            emp.FindbyPK(Thread.CurrentPrincipal.Identity.Name);
            toolStripStatusLabel2.Text = emp.Name;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = DateTime.Now.ToString("HH:mm:ss:ff");
        }
    }
}
