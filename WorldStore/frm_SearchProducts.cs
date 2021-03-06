﻿using Service.Common;
using Service.Entity;
using System;
using System.Data;
using System.IO;
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
            ControlCommon.BindDiscount(cbDiscount);
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
            SetSaleInfo();
        }

        private void SetSaleInfo()
        {
            if (dataGridView1.Rows.Count > 0 && lbAmount.Text != "--")
            {
                if (Convert.ToDecimal(lbAmount.Text) >= 0)
                {
                    saleInfo.ProId = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["Product_ID"].Value);
                    saleInfo.ProName = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["Name_x"].Value.ToString();//品名
                    saleInfo.SupplierName = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["SupplierName"].Value.ToString();
                    saleInfo.SpecName = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["SpecName"].Value.ToString();
                    saleInfo.UnitName = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["UnitName"].Value.ToString();
                    saleInfo.Quantity = Convert.ToDecimal(tbxQty.Text);
                    saleInfo.UnitPrice = Convert.ToDecimal(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["Price"].Value);
                    saleInfo.Discount = Convert.ToDecimal(cbDiscount.SelectedValue);
                    saleInfo.PaidIn = Convert.ToDecimal(lbAmount.Text);
                    this.DialogResult = DialogResult.OK;
                }
            }
        }
        private void tbxProduct_ID_TextChanged(object sender, EventArgs e)
        {
            SearchProducts();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //FileStream file1 = new FileStream(Environment.CurrentDirectory + "\\Images\\timg.jpg", FileMode.Open, FileAccess.Read);
            pictureBox1.ImageLocation = Environment.CurrentDirectory + "\\Images\\timg.jpg";
        }
        private void CalcAmount()
        {
            if (((DataTable)(dataGridView1.DataSource)).Rows.Count > 0 && tbxQty.Text.Length > 0 && tbxQty.Text != "-")
            {
                decimal Price = Convert.ToDecimal(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["Price"].Value);
                decimal Amount = Price * Convert.ToDecimal(cbDiscount.SelectedValue) * Convert.ToInt32(tbxQty.Text);
                lbAmount.Text = Math.Round(Amount, 2).ToString();
                //lbAmount.Text = ((Int32)((double)Amount + 0.5)).ToString();
            }
            else
            {
                lbAmount.Text = "--";
            }
        }

        private void tbxQty_TextChanged(object sender, EventArgs e)
        {
            CalcAmount();
        }

        private void btnDetermine_Click(object sender, EventArgs e)
        {
            SetSaleInfo();
        }

        private void tbxQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlCommon.VerDigitalHL(sender, e);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            CalcAmount();
        }
    }
}
