using Service.BLL;
using Service.Common;
using Service.Common.Data;
using Service.Entity;
using System;
using System.Data;
using System.Windows.Forms;

namespace WorldStore.Controls.Sales
{
    public partial class UC_Sale : UserControl
    {
        SaleDtlInfo Product = new SaleDtlInfo();
        BLL_Sale_Detail BLL_sDtl = new BLL_Sale_Detail();
        bool IsChanged = false;
        public UC_Sale()
        {
            InitializeComponent();
        }

        private void UC_Sale_Load(object sender, EventArgs e)
        {
            ControlCommon.BindDept(cbDept);
            ControlCommon.BindEmployee(cbEmployee);
            ControlCommon.BindStoreHouse(cbStoreHouse);
            ControlCommon.BindCustomer(cbCustomer);
            //cbGatheringWay.SelectedItem = cbGatheringWay.Items[0];
            //cbAccount.SelectedItem = cbAccount.Items[0];
            dataGridView1.AutoGenerateColumns = false;
            LoadInfo(233);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frm_SearchProducts fsp = new frm_SearchProducts();
            DialogResult drPro = fsp.ShowDialog();
            if (drPro == DialogResult.OK)
            {
                Product = fsp.SaleInfo;
            }
            DataTable dt = (DataTable)(dataGridView1.DataSource);
            DataRow dr = dt.NewRow();
            dr["ProId"] = fsp.SaleInfo.ProId;
            dr["ProName"] = fsp.SaleInfo.ProName;
            dr["SupplierName"] = fsp.SaleInfo.SupplierName;
            dr["SpecName"] = fsp.SaleInfo.SpecName;
            dr["UnitName"] = fsp.SaleInfo.UnitName;
            dr["Quanity"] = fsp.SaleInfo.Quanity;
            dr["UnitPrice"] = fsp.SaleInfo.UnitPrice;
            dt.Rows.Add(dr);//显示的内容
            IsChanged = true;
        }
        private void LoadInfo(Int32 SaleID)
        {

            //DataGridViewComboBoxColumn dgvComboBoxColumn = dataGridView1.Columns["Discount"] as DataGridViewComboBoxColumn;
            DataGridViewComboBoxColumn dgvComboBoxColumn = (DataGridViewComboBoxColumn)this.dataGridView1.Columns["Discount"];
            dgvComboBoxColumn.DataPropertyName = "Discount";
            dgvComboBoxColumn.DataSource = ExecuteSql.ExeComSqlForDataSet("SELECT DiscountRate,DisName FROM Discount WHERE Available = 1").Tables[0];
            dgvComboBoxColumn.DisplayMember = "DisName";
            dgvComboBoxColumn.ValueMember = "DiscountRate";

            //string strSql = "SELECT[Name],[ProductListName],[SpecName],[UnitName],[SupplierName],[spell],[shortname],[Price],[Offering_Price],[Product_ID],[ProductList_ID],[s_spell] FROM [ProInfoList]";
            if (SaleID != 0)
            {
                /*this.Text = SaleID.ToString();
                SaleInfo.FindbyPK(SaleID.ToString());
                lbTradeNo.Text = SaleInfo.TradeNo;
                tbxOrderNo.Text = SaleInfo.OrderNo;
                tbxCustomer.Text = SaleInfo.Customer.ToString();
                tbxCustomer.ReadOnly = true;
                tbxStoreHouse_ID.Text = SaleInfo.StoreHouse_ID.ToString();
                lbSaleDate.Text = SaleInfo.SaleDate.ToString("yyyy-MM-dd HH:mm:ss");

                List<string[]> where = new List<string[]>();
                List<string[]> order = new List<string[]>();
                where.Add(new string[] { "SaleOrder_ID = {0}", SaleID.ToString() });
                order.Add(new string[] { "Sale_Detail_ID", "ASC" });
                DataTable dt = Product.GetDataSet(strSql, where, order);
                dataGridView1.DataSource = dt;*/
                DataTable dt = BLL_sDtl.GetDetailAll(SaleID).Tables[0];
                dataGridView1.DataSource = dt;
            }
            else
            {
                DataTable dt = BLL_sDtl.GetDetailAll(SaleID).Tables[0];
                dataGridView1.DataSource = dt;
            }
            ((DataTable)dataGridView1.DataSource).Columns["PaidInAmount"].Expression = "Convert(Price*Quantity*Discount, 'System.Decimal')";
            ((DataTable)dataGridView1.DataSource).Columns["PaidIn1"].Expression = "Convert(Price*Discount, 'System.Decimal')";
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            frm_SearchProducts fs = new frm_SearchProducts();
            if (fs.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(fs.SaleInfo.ProName);
            }
        }
    }
}
