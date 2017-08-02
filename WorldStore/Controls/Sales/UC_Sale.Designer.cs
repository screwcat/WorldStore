namespace WorldStore.Controls.Sales
{
    partial class UC_Sale
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbDept = new System.Windows.Forms.ComboBox();
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.cbStoreHouse = new System.Windows.Forms.ComboBox();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ProId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpecName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quanity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // cbDept
            // 
            this.cbDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDept.FormattingEnabled = true;
            this.cbDept.Location = new System.Drawing.Point(183, 4);
            this.cbDept.Name = "cbDept";
            this.cbDept.Size = new System.Drawing.Size(121, 20);
            this.cbDept.TabIndex = 0;
            // 
            // cbEmployee
            // 
            this.cbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmployee.FormattingEnabled = true;
            this.cbEmployee.Location = new System.Drawing.Point(183, 30);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(121, 20);
            this.cbEmployee.TabIndex = 0;
            // 
            // cbStoreHouse
            // 
            this.cbStoreHouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStoreHouse.FormattingEnabled = true;
            this.cbStoreHouse.Location = new System.Drawing.Point(410, 4);
            this.cbStoreHouse.Name = "cbStoreHouse";
            this.cbStoreHouse.Size = new System.Drawing.Size(121, 20);
            this.cbStoreHouse.TabIndex = 0;
            // 
            // cbCustomer
            // 
            this.cbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(410, 30);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(121, 20);
            this.cbCustomer.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(573, 531);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "新  增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeight = 28;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProId,
            this.ProName,
            this.SupplierName,
            this.SpecName,
            this.UnitName,
            this.Quanity,
            this.UnitPrice,
            this.Total,
            this.delete});
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.dataGridView2.Location = new System.Drawing.Point(34, 90);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView2.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView2.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            this.dataGridView2.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.RowTemplate.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(700, 422);
            this.dataGridView2.TabIndex = 7;
            // 
            // ProId
            // 
            this.ProId.DataPropertyName = "ProId";
            this.ProId.HeaderText = "ID";
            this.ProId.Name = "ProId";
            this.ProId.ReadOnly = true;
            this.ProId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ProId.Width = 39;
            // 
            // ProName
            // 
            this.ProName.DataPropertyName = "ProName";
            this.ProName.HeaderText = "品名";
            this.ProName.Name = "ProName";
            this.ProName.ReadOnly = true;
            this.ProName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ProName.Width = 120;
            // 
            // SupplierName
            // 
            this.SupplierName.DataPropertyName = "SupplierName";
            this.SupplierName.HeaderText = "供应商";
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.ReadOnly = true;
            this.SupplierName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SupplierName.Width = 120;
            // 
            // SpecName
            // 
            this.SpecName.DataPropertyName = "SpecName";
            this.SpecName.HeaderText = "规格";
            this.SpecName.Name = "SpecName";
            this.SpecName.ReadOnly = true;
            this.SpecName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SpecName.Width = 80;
            // 
            // UnitName
            // 
            this.UnitName.DataPropertyName = "UnitName";
            this.UnitName.HeaderText = "单位";
            this.UnitName.Name = "UnitName";
            this.UnitName.ReadOnly = true;
            this.UnitName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.UnitName.Width = 59;
            // 
            // Quanity
            // 
            this.Quanity.DataPropertyName = "Quanity";
            this.Quanity.HeaderText = "数量";
            this.Quanity.Name = "Quanity";
            this.Quanity.ReadOnly = true;
            this.Quanity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Quanity.Width = 59;
            // 
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "UnitPrice";
            this.UnitPrice.HeaderText = "单价";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            this.UnitPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.UnitPrice.Width = 80;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            dataGridViewCellStyle2.Format = "F";
            dataGridViewCellStyle2.NullValue = null;
            this.Total.DefaultCellStyle = dataGridViewCellStyle2;
            this.Total.HeaderText = "合计";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Total.Width = 80;
            // 
            // delete
            // 
            this.delete.HeaderText = "删除";
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Width = 59;
            // 
            // UC_Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbCustomer);
            this.Controls.Add(this.cbStoreHouse);
            this.Controls.Add(this.cbEmployee);
            this.Controls.Add(this.cbDept);
            this.Name = "UC_Sale";
            this.Size = new System.Drawing.Size(947, 577);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDept;
        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.ComboBox cbStoreHouse;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpecName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quanity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
    }
}
