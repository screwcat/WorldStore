namespace WorldStore
{
    partial class frm_SearchProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_SearchProducts));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ucPage1 = new WorldStore.Controls.UCPage();
            this.tbxProduct_ID = new System.Windows.Forms.TextBox();
            this.cbProductClass = new System.Windows.Forms.ComboBox();
            this.tbxSpecName = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxS_spell = new System.Windows.Forms.TextBox();
            this.tbxSpell = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductListName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpecName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shortname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_spell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ucPage1
            // 
            this.ucPage1.CurPage = 1;
            this.ucPage1.DataSetSql = "";
            this.ucPage1.LiOrder = ((System.Collections.Generic.List<string[]>)(resources.GetObject("ucPage1.LiOrder")));
            this.ucPage1.LiWhere = ((System.Collections.Generic.List<string[]>)(resources.GetObject("ucPage1.LiWhere")));
            this.ucPage1.Location = new System.Drawing.Point(69, 513);
            this.ucPage1.Name = "ucPage1";
            this.ucPage1.PageSize = 20;
            this.ucPage1.Size = new System.Drawing.Size(543, 42);
            this.ucPage1.TabIndex = 0;
            this.ucPage1.PageEvent += new WorldStore.Controls.PageEntrust(this.ucPage1_PageEvent);
            // 
            // tbxProduct_ID
            // 
            this.tbxProduct_ID.Location = new System.Drawing.Point(85, 11);
            this.tbxProduct_ID.Name = "tbxProduct_ID";
            this.tbxProduct_ID.Size = new System.Drawing.Size(169, 21);
            this.tbxProduct_ID.TabIndex = 1;
            this.tbxProduct_ID.TextChanged += new System.EventHandler(this.tbxProduct_ID_TextChanged);
            // 
            // cbProductClass
            // 
            this.cbProductClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductClass.FormattingEnabled = true;
            this.cbProductClass.Location = new System.Drawing.Point(587, 38);
            this.cbProductClass.Name = "cbProductClass";
            this.cbProductClass.Size = new System.Drawing.Size(121, 20);
            this.cbProductClass.TabIndex = 3;
            // 
            // tbxSpecName
            // 
            this.tbxSpecName.Location = new System.Drawing.Point(85, 38);
            this.tbxSpecName.Name = "tbxSpecName";
            this.tbxSpecName.Size = new System.Drawing.Size(169, 21);
            this.tbxSpecName.TabIndex = 1;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(328, 12);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(169, 21);
            this.tbxName.TabIndex = 1;
            // 
            // tbxS_spell
            // 
            this.tbxS_spell.Location = new System.Drawing.Point(328, 39);
            this.tbxS_spell.Name = "tbxS_spell";
            this.tbxS_spell.Size = new System.Drawing.Size(169, 21);
            this.tbxS_spell.TabIndex = 1;
            // 
            // tbxSpell
            // 
            this.tbxSpell.Location = new System.Drawing.Point(587, 12);
            this.tbxSpell.Name = "tbxSpell";
            this.tbxSpell.Size = new System.Drawing.Size(169, 21);
            this.tbxSpell.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "编    号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "规    格：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "名    称：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "拼音简写：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(519, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "拼    音：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(519, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "类    别：";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 28;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MB,
            this.Name_x,
            this.ProductListName,
            this.SpecName,
            this.UnitName,
            this.SupplierName,
            this.shortname,
            this.spell,
            this.Price,
            this.Product_ID,
            this.s_spell});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.dataGridView1.Location = new System.Drawing.Point(12, 75);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(845, 432);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // MB
            // 
            this.MB.DataPropertyName = "MB";
            this.MB.HeaderText = "编号";
            this.MB.Name = "MB";
            this.MB.ReadOnly = true;
            this.MB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MB.Width = 39;
            // 
            // Name_x
            // 
            this.Name_x.DataPropertyName = "Name";
            this.Name_x.HeaderText = "名称";
            this.Name_x.Name = "Name_x";
            this.Name_x.ReadOnly = true;
            this.Name_x.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Name_x.Width = 110;
            // 
            // ProductListName
            // 
            this.ProductListName.DataPropertyName = "ProductListName";
            this.ProductListName.HeaderText = "分类";
            this.ProductListName.Name = "ProductListName";
            this.ProductListName.ReadOnly = true;
            this.ProductListName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ProductListName.Width = 80;
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
            this.UnitName.Width = 80;
            // 
            // SupplierName
            // 
            this.SupplierName.DataPropertyName = "SupplierName";
            this.SupplierName.HeaderText = "供应商";
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.ReadOnly = true;
            this.SupplierName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SupplierName.Width = 90;
            // 
            // shortname
            // 
            this.shortname.DataPropertyName = "shortname";
            this.shortname.HeaderText = "简称";
            this.shortname.Name = "shortname";
            this.shortname.ReadOnly = true;
            this.shortname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.shortname.Width = 90;
            // 
            // spell
            // 
            this.spell.DataPropertyName = "spell";
            dataGridViewCellStyle2.Format = "F";
            dataGridViewCellStyle2.NullValue = null;
            this.spell.DefaultCellStyle = dataGridViewCellStyle2;
            this.spell.HeaderText = "拼音";
            this.spell.Name = "spell";
            this.spell.ReadOnly = true;
            this.spell.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.spell.Width = 90;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "单价";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Price.Width = 60;
            // 
            // Product_ID
            // 
            this.Product_ID.DataPropertyName = "Product_ID";
            this.Product_ID.HeaderText = "商品ID";
            this.Product_ID.Name = "Product_ID";
            this.Product_ID.ReadOnly = true;
            this.Product_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Product_ID.Width = 50;
            // 
            // s_spell
            // 
            this.s_spell.DataPropertyName = "s_spell";
            this.s_spell.HeaderText = "拼音简写";
            this.s_spell.Name = "s_spell";
            this.s_spell.ReadOnly = true;
            this.s_spell.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.s_spell.Width = 70;
            // 
            // frm_SearchProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 588);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbProductClass);
            this.Controls.Add(this.tbxSpell);
            this.Controls.Add(this.tbxS_spell);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.tbxSpecName);
            this.Controls.Add(this.tbxProduct_ID);
            this.Controls.Add(this.ucPage1);
            this.Name = "frm_SearchProducts";
            this.Text = "frm_SearchProducts";
            this.Load += new System.EventHandler(this.frm_SearchProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.UCPage ucPage1;
        private System.Windows.Forms.TextBox tbxProduct_ID;
        private System.Windows.Forms.ComboBox cbProductClass;
        private System.Windows.Forms.TextBox tbxSpecName;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxS_spell;
        private System.Windows.Forms.TextBox tbxSpell;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_x;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductListName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpecName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn shortname;
        private System.Windows.Forms.DataGridViewTextBoxColumn spell;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_spell;
    }
}