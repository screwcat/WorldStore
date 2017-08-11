namespace WorldStore
{
    partial class FormMain
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("密码修改");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("权限管理");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("系统设置", 0, 0, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("进货管理");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("仓库库存情况");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("售货单修改");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("入库单修改");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("管理流程", 1, 1, new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("前台开单");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("前台退货");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("销售记录");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("退货记录");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("销售开单", 2, 2, new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("仓库调拔");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("填写入库");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("物品出库");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("进货记录");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("出库记录");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("仓库调拔记录");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("查询出入记录");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("库存开单", 3, 3, new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("销售汇总");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("销售明细");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("入库汇总");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("入库明细");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("库存盘点");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("查看历史报表");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("报表", 5, 5, new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode23,
            treeNode24,
            treeNode25,
            treeNode26,
            treeNode27});
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("客户资料", 7, 7);
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("供应商管理", 6, 6);
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("商品资料");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("商品规格管理");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("商品单位管理");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("商品总分类");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("商品详细分类");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("部门管理");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("仓库管理");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("基础信息维护", 7, 7, new System.Windows.Forms.TreeNode[] {
            treeNode29,
            treeNode30,
            treeNode31,
            treeNode32,
            treeNode33,
            treeNode34,
            treeNode35,
            treeNode36,
            treeNode37});
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("数据备份");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("系统设置", new System.Windows.Forms.TreeNode[] {
            treeNode39});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.Window;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(1438, 793);
            this.splitContainer1.SplitterDistance = 211;
            this.splitContainer1.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.ItemHeight = 40;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "密码修改";
            treeNode1.NodeFont = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            treeNode1.Tag = "PassWordEdit";
            treeNode1.Text = "密码修改";
            treeNode1.ToolTipText = "密码修改";
            treeNode2.Name = "权限管理";
            treeNode2.NodeFont = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            treeNode2.Tag = "PowerManage";
            treeNode2.Text = "权限管理";
            treeNode2.ToolTipText = "权限管理";
            treeNode3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            treeNode3.ForeColor = System.Drawing.Color.White;
            treeNode3.ImageIndex = 0;
            treeNode3.Name = "系统设置";
            treeNode3.NodeFont = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            treeNode3.SelectedImageIndex = 0;
            treeNode3.Tag = "0";
            treeNode3.Text = "系统设置";
            treeNode3.ToolTipText = "系统设置";
            treeNode4.Name = "节点4";
            treeNode4.NodeFont = new System.Drawing.Font("宋体", 12F);
            treeNode4.Tag = "BuyOrder";
            treeNode4.Text = "进货管理";
            treeNode4.ToolTipText = "进货管理";
            treeNode5.Name = "节点5";
            treeNode5.NodeFont = new System.Drawing.Font("宋体", 12F);
            treeNode5.Tag = "StockView";
            treeNode5.Text = "仓库库存情况";
            treeNode5.ToolTipText = "仓库库存情况";
            treeNode6.Name = "节点6";
            treeNode6.NodeFont = new System.Drawing.Font("宋体", 12F);
            treeNode6.Tag = "SaleModify";
            treeNode6.Text = "售货单修改";
            treeNode6.ToolTipText = "售货单修改";
            treeNode7.Name = "节点7";
            treeNode7.NodeFont = new System.Drawing.Font("宋体", 12F);
            treeNode7.Tag = "EnterStockEdit";
            treeNode7.Text = "入库单修改";
            treeNode7.ToolTipText = "入库单修改";
            treeNode8.BackColor = System.Drawing.SystemColors.MenuHighlight;
            treeNode8.ForeColor = System.Drawing.Color.White;
            treeNode8.ImageIndex = 1;
            treeNode8.Name = "节点3";
            treeNode8.NodeFont = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            treeNode8.SelectedImageIndex = 1;
            treeNode8.Tag = "0";
            treeNode8.Text = "管理流程";
            treeNode8.ToolTipText = "管理流程";
            treeNode9.Name = "节点8";
            treeNode9.NodeFont = new System.Drawing.Font("宋体", 12F);
            treeNode9.Tag = "Sale";
            treeNode9.Text = "前台开单";
            treeNode9.ToolTipText = "前台开单";
            treeNode10.Name = "节点9";
            treeNode10.NodeFont = new System.Drawing.Font("宋体", 12F);
            treeNode10.Tag = "BackSale";
            treeNode10.Text = "前台退货";
            treeNode10.ToolTipText = "前台退货";
            treeNode11.Name = "节点10";
            treeNode11.NodeFont = new System.Drawing.Font("宋体", 12F);
            treeNode11.Tag = "SaleReport";
            treeNode11.Text = "销售记录";
            treeNode11.ToolTipText = "销售记录";
            treeNode12.Name = "节点11";
            treeNode12.NodeFont = new System.Drawing.Font("宋体", 12F);
            treeNode12.Tag = "BackSaleRecord";
            treeNode12.Text = "退货记录";
            treeNode12.ToolTipText = "退货记录";
            treeNode13.BackColor = System.Drawing.SystemColors.MenuHighlight;
            treeNode13.ForeColor = System.Drawing.Color.White;
            treeNode13.ImageIndex = 2;
            treeNode13.Name = "节点2";
            treeNode13.NodeFont = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            treeNode13.SelectedImageIndex = 2;
            treeNode13.Tag = "0";
            treeNode13.Text = "销售开单";
            treeNode13.ToolTipText = "销售开单";
            treeNode14.Name = "节点12";
            treeNode14.NodeFont = new System.Drawing.Font("宋体", 12F);
            treeNode14.Tag = "AddLeaveStock";
            treeNode14.Text = "仓库调拔";
            treeNode14.ToolTipText = "仓库调拔";
            treeNode15.Name = "节点13";
            treeNode15.NodeFont = new System.Drawing.Font("宋体", 12F);
            treeNode15.Tag = "AddStockContract";
            treeNode15.Text = "填写入库";
            treeNode15.ToolTipText = "填写入库";
            treeNode16.Name = "节点14";
            treeNode16.NodeFont = new System.Drawing.Font("宋体", 12F);
            treeNode16.Tag = "AddBackStock";
            treeNode16.Text = "物品出库";
            treeNode16.ToolTipText = "物品出库";
            treeNode17.Name = "节点15";
            treeNode17.NodeFont = new System.Drawing.Font("宋体", 12F);
            treeNode17.Tag = "EnterStockRecord";
            treeNode17.Text = "进货记录";
            treeNode17.ToolTipText = "进货记录";
            treeNode18.Name = "节点16";
            treeNode18.NodeFont = new System.Drawing.Font("宋体", 12F);
            treeNode18.Tag = "BackStockRecord";
            treeNode18.Text = "出库记录";
            treeNode18.ToolTipText = "出库记录";
            treeNode19.Name = "节点17";
            treeNode19.NodeFont = new System.Drawing.Font("宋体", 12F);
            treeNode19.Tag = "TransferRecord";
            treeNode19.Text = "仓库调拔记录";
            treeNode19.ToolTipText = "仓库调拔记录";
            treeNode20.Name = "节点18";
            treeNode20.NodeFont = new System.Drawing.Font("宋体", 12F);
            treeNode20.Tag = "productflowing";
            treeNode20.Text = "查询出入记录";
            treeNode20.ToolTipText = "查询出入记录";
            treeNode21.BackColor = System.Drawing.SystemColors.MenuHighlight;
            treeNode21.ForeColor = System.Drawing.Color.White;
            treeNode21.ImageIndex = 3;
            treeNode21.Name = "节点4";
            treeNode21.NodeFont = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            treeNode21.SelectedImageIndex = 3;
            treeNode21.Tag = "0";
            treeNode21.Text = "库存开单";
            treeNode21.ToolTipText = "库存开单";
            treeNode22.Name = "节点19";
            treeNode22.NodeFont = new System.Drawing.Font("宋体", 12F);
            treeNode22.Tag = "SaleGather";
            treeNode22.Text = "销售汇总";
            treeNode22.ToolTipText = "销售汇总";
            treeNode23.Name = "节点20";
            treeNode23.NodeFont = new System.Drawing.Font("宋体", 12F);
            treeNode23.Tag = "SaleDefinite";
            treeNode23.Text = "销售明细";
            treeNode23.ToolTipText = "销售明细";
            treeNode24.Name = "节点21";
            treeNode24.NodeFont = new System.Drawing.Font("宋体", 12F);
            treeNode24.Tag = "EnterStockGather";
            treeNode24.Text = "入库汇总";
            treeNode24.ToolTipText = "入库汇总";
            treeNode25.Name = "节点22";
            treeNode25.NodeFont = new System.Drawing.Font("宋体", 12F);
            treeNode25.Tag = "EnterStockDefinite";
            treeNode25.Text = "入库明细";
            treeNode25.ToolTipText = "入库明细";
            treeNode26.Name = "节点23";
            treeNode26.NodeFont = new System.Drawing.Font("宋体", 12F);
            treeNode26.Tag = "CheckStock";
            treeNode26.Text = "库存盘点";
            treeNode26.ToolTipText = "库存盘点";
            treeNode27.Name = "节点24";
            treeNode27.NodeFont = new System.Drawing.Font("宋体", 12F);
            treeNode27.Tag = "HisTab";
            treeNode27.Text = "查看历史报表";
            treeNode27.ToolTipText = "查看历史报表";
            treeNode28.BackColor = System.Drawing.SystemColors.MenuHighlight;
            treeNode28.ForeColor = System.Drawing.Color.White;
            treeNode28.ImageIndex = 5;
            treeNode28.Name = "节点6";
            treeNode28.NodeFont = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            treeNode28.SelectedImageIndex = 5;
            treeNode28.Tag = "0";
            treeNode28.Text = "报表";
            treeNode28.ToolTipText = "报表";
            treeNode29.ImageIndex = 7;
            treeNode29.Name = "费率设置";
            treeNode29.NodeFont = new System.Drawing.Font("宋体", 12F);
            treeNode29.SelectedImageIndex = 7;
            treeNode29.Tag = "Customer";
            treeNode29.Text = "客户资料";
            treeNode29.ToolTipText = "客户资料";
            treeNode30.ImageIndex = 6;
            treeNode30.Name = "时间点";
            treeNode30.NodeFont = new System.Drawing.Font("宋体", 12F);
            treeNode30.SelectedImageIndex = 6;
            treeNode30.Tag = "Supplier";
            treeNode30.Text = "供应商管理";
            treeNode30.ToolTipText = "供应商管理";
            treeNode31.Name = "节点25";
            treeNode31.NodeFont = new System.Drawing.Font("宋体", 12F);
            treeNode31.Tag = "product";
            treeNode31.Text = "商品资料";
            treeNode31.ToolTipText = "商品资料";
            treeNode32.Name = "节点26";
            treeNode32.NodeFont = new System.Drawing.Font("宋体", 12F);
            treeNode32.Tag = "ProductSpec";
            treeNode32.Text = "商品规格管理";
            treeNode32.ToolTipText = "商品规格管理";
            treeNode33.Name = "节点27";
            treeNode33.NodeFont = new System.Drawing.Font("宋体", 12F);
            treeNode33.Tag = "ProductUnit";
            treeNode33.Text = "商品单位管理";
            treeNode33.ToolTipText = "商品单位管理";
            treeNode34.Name = "节点28";
            treeNode34.NodeFont = new System.Drawing.Font("宋体", 12F);
            treeNode34.Tag = "ProductClass";
            treeNode34.Text = "商品总分类";
            treeNode34.ToolTipText = "商品总分类";
            treeNode35.Name = "节点29";
            treeNode35.NodeFont = new System.Drawing.Font("宋体", 12F);
            treeNode35.Tag = "ProductList";
            treeNode35.Text = "商品详细分类";
            treeNode35.ToolTipText = "商品详细分类";
            treeNode36.Name = "节点30";
            treeNode36.NodeFont = new System.Drawing.Font("宋体", 12F);
            treeNode36.Tag = "Dept";
            treeNode36.Text = "部门管理";
            treeNode36.ToolTipText = "部门管理";
            treeNode37.Name = "节点31";
            treeNode37.NodeFont = new System.Drawing.Font("宋体", 12F);
            treeNode37.Tag = "StoreHouse";
            treeNode37.Text = "仓库管理";
            treeNode37.ToolTipText = "仓库管理";
            treeNode38.BackColor = System.Drawing.SystemColors.MenuHighlight;
            treeNode38.ForeColor = System.Drawing.Color.White;
            treeNode38.ImageIndex = 7;
            treeNode38.Name = "节点8";
            treeNode38.NodeFont = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            treeNode38.SelectedImageIndex = 7;
            treeNode38.Tag = "0";
            treeNode38.Text = "基础信息维护";
            treeNode38.ToolTipText = "基础信息维护";
            treeNode39.Name = "数据备份";
            treeNode39.NodeFont = new System.Drawing.Font("宋体", 12F);
            treeNode39.Tag = "DataBackup";
            treeNode39.Text = "数据备份";
            treeNode39.ToolTipText = "数据备份";
            treeNode40.BackColor = System.Drawing.SystemColors.MenuHighlight;
            treeNode40.ForeColor = System.Drawing.Color.White;
            treeNode40.Name = "节点0";
            treeNode40.NodeFont = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            treeNode40.Tag = "0";
            treeNode40.Text = "系统设置";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode8,
            treeNode13,
            treeNode21,
            treeNode28,
            treeNode38,
            treeNode40});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(207, 789);
            this.treeView1.TabIndex = 1;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "场内车辆.png");
            this.imageList1.Images.SetKeyName(1, "车辆放行.png");
            this.imageList1.Images.SetKeyName(2, "结算记录.png");
            this.imageList1.Images.SetKeyName(3, "控制总台.png");
            this.imageList1.Images.SetKeyName(4, "数据统计.png");
            this.imageList1.Images.SetKeyName(5, "数据总表.png");
            this.imageList1.Images.SetKeyName(6, "下班结算.png");
            this.imageList1.Images.SetKeyName(7, "值班记录.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(547, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "欢迎使用";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel,
            this.tsslTime,
            this.toolStripStatusLabel3});
            this.statusStrip.Location = new System.Drawing.Point(0, 771);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1438, 22);
            this.statusStrip.TabIndex = 6;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(56, 17);
            this.toolStripStatusLabel1.Text = "欢迎使用";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(23, 17);
            this.toolStripStatusLabel2.Text = "{0}";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(68, 17);
            this.toolStripStatusLabel.Text = "当前时间：";
            // 
            // tsslTime
            // 
            this.tsslTime.Name = "tsslTime";
            this.tsslTime.Size = new System.Drawing.Size(23, 17);
            this.tsslTime.Text = "{1}";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(23, 17);
            this.toolStripStatusLabel3.Text = "{2}";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1438, 793);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.VisibleChanged += new System.EventHandler(this.FormMain_VisibleChanged);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel tsslTime;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Label label1;
    }
}

