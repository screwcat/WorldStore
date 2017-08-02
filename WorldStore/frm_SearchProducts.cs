using Service.Common;
using Service.Entity;
using System;
using System.Windows.Forms;
using WorldStore.DataBase;

namespace WorldStore
{
    public partial class frm_SearchProducts : Form
    {
        //v_ProInfoList _product = new v_ProInfoList();
        SaleDtlInfo saleInfo = new SaleDtlInfo();

        public SaleDtlInfo SaleInfo { get => saleInfo; set => saleInfo = value; }

        public frm_SearchProducts()
        {
            InitializeComponent();
        }

        private void frm_SearchProducts_Load(object sender, EventArgs e)
        {
            ucPage1.DataSetSql = "SELECT * FROM v_ProInfoList";
            ucPage1.LiOrder.Add(new string[] { "Product_ID", "DESC" });
            dataGridView1.AutoGenerateColumns = false;
            ControlCommon.BindProductClass(cbProductClass);
            SearchProducts();
        }
        private void tbxProduct_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlCommon.VerDigital(e);
        }

        private void tbxProduct_ID_KeyUp(object sender, KeyEventArgs e)
        {
            SearchProducts();
        }
        private void cbProductClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchProducts();
        }
        private void cbProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchProducts();
        }
        private void tbxSpecName_TextChanged(object sender, EventArgs e)
        {
            SearchProducts();
        }
        private void tbxName_TextChanged(object sender, EventArgs e)
        {
            SearchProducts();
        }
        private void tbxS_spell_TextChanged(object sender, EventArgs e)
        {
            SearchProducts();
        }
        private void tbxSpell_TextChanged(object sender, EventArgs e)
        {
            SearchProducts();
        }
        private void SearchProducts()
        {
            ucPage1.LiWhere.Clear();
            ucPage1.LiWhere.Add(new string[] { "1 = {0}", "1" });
            if (!string.IsNullOrEmpty(tbxProduct_ID.Text.Trim()))
            {
                ucPage1.LiWhere.Add(new string[] { "Product_ID LIKE {0} + '%'", tbxProduct_ID.Text.Trim() });
            }
            if (cbProductClass.SelectedValue.ToString() != "0")
            {
                ucPage1.LiWhere.Add(new string[] { "ProductList_ID = {0}", cbProductClass.SelectedValue.ToString() });
            }
            if (!string.IsNullOrEmpty(tbxSpecName.Text.Trim()))
            {
                ucPage1.LiWhere.Add(new string[] { "SpecName LIKE '%' + {0} + '%'", tbxSpecName.Text.Trim() });
            }
            //if (!string.IsNullOrEmpty(tbxSpecName.Text.Trim()))
            //{
            //    ucPage1.LiWhere.Add(new string[] { "SpecName LIKE '%' + {0} + '%'", tbxSpecName.Text.Trim() });
            //}
            if (!string.IsNullOrEmpty(tbxName.Text.Trim()))
            {
                ucPage1.LiWhere.Add(new string[] { "Name LIKE '%' + {0} + '%'", tbxName.Text.Trim() });
            }
            if (!string.IsNullOrEmpty(tbxS_spell.Text.Trim()))
            {
                ucPage1.LiWhere.Add(new string[] { "s_spell LIKE '%' + {0} + '%'", tbxS_spell.Text.Trim() });
            }
            if (!string.IsNullOrEmpty(tbxSpell.Text.Trim()))
            {
                ucPage1.LiWhere.Add(new string[] { "s_spell LIKE '%' + {0} + '%'", tbxSpell.Text.Trim() });
            }
            ucPage1.CurPage = 1;
            dataGridView1.DataSource = ucPage1.GetDataTable();
        }

        private void ucPage1_PageEvent()
        {
            dataGridView1.DataSource = ucPage1.GetDataTable();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            saleInfo.ProId = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["Product_ID"].Value);
            saleInfo.ProName = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["Name_x"].Value.ToString();//品名
            saleInfo.SupplierName = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["SupplierName"].Value.ToString();
            saleInfo.SpecName = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["SpecName"].Value.ToString();
            saleInfo.UnitName = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["UnitName"].Value.ToString();
            saleInfo.Quanity = 0;
            saleInfo.UnitPrice = Convert.ToDecimal(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["Price"].Value);
            this.DialogResult = DialogResult.OK;
        }

        private void tbxProduct_ID_TextChanged(object sender, EventArgs e)
        {
            SearchProducts();
        }
    }
}
