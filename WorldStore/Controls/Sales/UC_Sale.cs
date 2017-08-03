using Service.BLL;
using Service.Common;
using Service.Common.Data;
using Service.Entity;
using System;
using System.Data;
using System.Drawing;
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

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (this.dataGridView1.CurrentCell.OwningColumn.Name == "Discount")
            {
                ((ComboBox)e.Control).SelectionChangeCommitted += new EventHandler(FormSale_SelectedIndexChanged);
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            StatisticsAmount();
        }
        private void StatisticsAmount()
        {
            decimal TotalAmount = 0;
            DataTable dt = (DataTable)dataGridView1.DataSource;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //TotalAmount += Convert.ToDecimal(dt.Rows[i]["PaidInAmount"]);
                TotalAmount += 1;
            }
            lbTotal.Text = Math.Floor(Convert.ToDouble(TotalAmount) + 0.5).ToString("f2");
        }
        void FormSale_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = dataGridView1.DataSource as DataTable;
            dt.Rows[dataGridView1.CurrentCell.RowIndex]["Discount"] = ((ComboBox)sender).SelectedValue;
            IsChanged = true;
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (e.RowIndex >= dataGridView1.FirstDisplayedScrollingRowIndex)
            {
                using (SolidBrush b = new SolidBrush(dataGridView1.RowHeadersDefaultCellStyle.ForeColor))
                {
                    int linen = 0;
                    linen = e.RowIndex + 1;
                    string line = linen.ToString();
                    e.Graphics.DrawString(line, e.InheritedRowStyle.Font, b, e.RowBounds.Location.X, e.RowBounds.Location.Y + 5);
                    SolidBrush B = new SolidBrush(Color.Red);
                }
            }
        }
    }
}
