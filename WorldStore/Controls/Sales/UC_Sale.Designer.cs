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
            this.cbDept = new System.Windows.Forms.ComboBox();
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.cbStoreHouse = new System.Windows.Forms.ComboBox();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbTotal = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PaidIn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaidInAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.Red;
            this.lbTotal.Location = new System.Drawing.Point(801, 121);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(87, 36);
            this.lbTotal.TabIndex = 8;
            this.lbTotal.Text = "label1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.ProCode,
            this.ProductName,
            this.Price,
            this.Quantity,
            this.Discount,
            this.PaidIn1,
            this.PaidInAmount,
            this.ServerName});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(80, 69);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(618, 433);
            this.dataGridView1.TabIndex = 9;
            // 
            // Code
            // 
            this.Code.DataPropertyName = "ListNO";
            this.Code.HeaderText = "序号";
            this.Code.Name = "Code";
            this.Code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Code.Width = 40;
            // 
            // ProCode
            // 
            this.ProCode.DataPropertyName = "Code";
            this.ProCode.HeaderText = "代码";
            this.ProCode.Name = "ProCode";
            this.ProCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ProCode.Width = 50;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName1";
            this.ProductName.HeaderText = "名称";
            this.ProductName.Name = "ProductName";
            this.ProductName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "单价";
            this.Price.Name = "Price";
            this.Price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Price.Width = 70;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "数量";
            this.Quantity.Name = "Quantity";
            this.Quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Quantity.Width = 50;
            // 
            // Discount
            // 
            this.Discount.DataPropertyName = "Discount";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            this.Discount.DefaultCellStyle = dataGridViewCellStyle1;
            this.Discount.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Discount.HeaderText = "折扣";
            this.Discount.Name = "Discount";
            this.Discount.Width = 80;
            // 
            // PaidIn1
            // 
            this.PaidIn1.DataPropertyName = "PaidIn1";
            this.PaidIn1.HeaderText = "实收单价";
            this.PaidIn1.Name = "PaidIn1";
            this.PaidIn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PaidIn1.Width = 70;
            // 
            // PaidInAmount
            // 
            this.PaidInAmount.DataPropertyName = "PaidInAmount";
            this.PaidInAmount.HeaderText = "实收金额";
            this.PaidInAmount.Name = "PaidInAmount";
            this.PaidInAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PaidInAmount.Width = 70;
            // 
            // ServerName
            // 
            this.ServerName.DataPropertyName = "Name";
            this.ServerName.HeaderText = "服务人员";
            this.ServerName.Name = "ServerName";
            this.ServerName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ServerName.Width = 80;
            // 
            // UC_Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbCustomer);
            this.Controls.Add(this.cbStoreHouse);
            this.Controls.Add(this.cbEmployee);
            this.Controls.Add(this.cbDept);
            this.Name = "UC_Sale";
            this.Size = new System.Drawing.Size(947, 577);
            this.Load += new System.EventHandler(this.UC_Sale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDept;
        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.ComboBox cbStoreHouse;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewComboBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaidIn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaidInAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServerName;
    }
}
