namespace WorldStore.Controls
{
    partial class UCPage
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbRecCount = new System.Windows.Forms.Label();
            this.btnJump = new System.Windows.Forms.Button();
            this.pbNext = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pbFirst = new System.Windows.Forms.PictureBox();
            this.pbPrevious = new System.Windows.Forms.PictureBox();
            this.tbxGo = new System.Windows.Forms.TextBox();
            this.pbLast = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbCurPage = new System.Windows.Forms.Label();
            this.lbPageCount = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFirst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrevious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLast)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbRecCount);
            this.groupBox1.Controls.Add(this.btnJump);
            this.groupBox1.Controls.Add(this.pbNext);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.pbFirst);
            this.groupBox1.Controls.Add(this.pbPrevious);
            this.groupBox1.Controls.Add(this.tbxGo);
            this.groupBox1.Controls.Add(this.pbLast);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbCurPage);
            this.groupBox1.Controls.Add(this.lbPageCount);
            this.groupBox1.Location = new System.Drawing.Point(7, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 35);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // lbRecCount
            // 
            this.lbRecCount.AutoSize = true;
            this.lbRecCount.Location = new System.Drawing.Point(2, 16);
            this.lbRecCount.Name = "lbRecCount";
            this.lbRecCount.Size = new System.Drawing.Size(71, 12);
            this.lbRecCount.TabIndex = 8;
            this.lbRecCount.Text = "共{0}条记录";
            // 
            // btnJump
            // 
            this.btnJump.Location = new System.Drawing.Point(490, 10);
            this.btnJump.Name = "btnJump";
            this.btnJump.Size = new System.Drawing.Size(37, 23);
            this.btnJump.TabIndex = 10;
            this.btnJump.Text = "跳转";
            this.btnJump.UseVisualStyleBackColor = true;
            this.btnJump.Click += new System.EventHandler(this.btnJump_Click);
            // 
            // pbNext
            // 
            this.pbNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbNext.Image = global::WorldStore.Properties.Resources.IconNext;
            this.pbNext.InitialImage = null;
            this.pbNext.Location = new System.Drawing.Point(334, 14);
            this.pbNext.Name = "pbNext";
            this.pbNext.Size = new System.Drawing.Size(16, 16);
            this.pbNext.TabIndex = 0;
            this.pbNext.TabStop = false;
            this.pbNext.Click += new System.EventHandler(this.pbNext_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(467, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "页";
            // 
            // pbFirst
            // 
            this.pbFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFirst.Image = global::WorldStore.Properties.Resources.IconFirst;
            this.pbFirst.InitialImage = null;
            this.pbFirst.Location = new System.Drawing.Point(266, 14);
            this.pbFirst.Name = "pbFirst";
            this.pbFirst.Size = new System.Drawing.Size(16, 16);
            this.pbFirst.TabIndex = 1;
            this.pbFirst.TabStop = false;
            this.pbFirst.Click += new System.EventHandler(this.pbFirst_Click);
            // 
            // pbPrevious
            // 
            this.pbPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbPrevious.Image = global::WorldStore.Properties.Resources.IconPrevious;
            this.pbPrevious.InitialImage = null;
            this.pbPrevious.Location = new System.Drawing.Point(301, 14);
            this.pbPrevious.Name = "pbPrevious";
            this.pbPrevious.Size = new System.Drawing.Size(16, 16);
            this.pbPrevious.TabIndex = 2;
            this.pbPrevious.TabStop = false;
            this.pbPrevious.Click += new System.EventHandler(this.pbPrevious_Click);
            // 
            // tbxGo
            // 
            this.tbxGo.Location = new System.Drawing.Point(439, 11);
            this.tbxGo.MaxLength = 9;
            this.tbxGo.Name = "tbxGo";
            this.tbxGo.Size = new System.Drawing.Size(25, 21);
            this.tbxGo.TabIndex = 7;
            this.tbxGo.Text = "1";
            this.tbxGo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxGo_KeyPress);
            // 
            // pbLast
            // 
            this.pbLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLast.Image = global::WorldStore.Properties.Resources.IconLast;
            this.pbLast.InitialImage = null;
            this.pbLast.Location = new System.Drawing.Point(366, 14);
            this.pbLast.Name = "pbLast";
            this.pbLast.Size = new System.Drawing.Size(16, 16);
            this.pbLast.TabIndex = 3;
            this.pbLast.TabStop = false;
            this.pbLast.Click += new System.EventHandler(this.pbLast_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(420, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "第";
            // 
            // lbCurPage
            // 
            this.lbCurPage.AutoSize = true;
            this.lbCurPage.Location = new System.Drawing.Point(112, 16);
            this.lbCurPage.Name = "lbCurPage";
            this.lbCurPage.Size = new System.Drawing.Size(47, 12);
            this.lbCurPage.TabIndex = 4;
            this.lbCurPage.Text = "第{0}页";
            // 
            // lbPageCount
            // 
            this.lbPageCount.AutoSize = true;
            this.lbPageCount.Location = new System.Drawing.Point(184, 16);
            this.lbPageCount.Name = "lbPageCount";
            this.lbPageCount.Size = new System.Drawing.Size(47, 12);
            this.lbPageCount.TabIndex = 6;
            this.lbPageCount.Text = "共{0}页";
            // 
            // UCPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UCPage";
            this.Size = new System.Drawing.Size(543, 42);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFirst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrevious)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLast)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbRecCount;
        private System.Windows.Forms.Button btnJump;
        private System.Windows.Forms.PictureBox pbNext;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbFirst;
        private System.Windows.Forms.PictureBox pbPrevious;
        private System.Windows.Forms.TextBox tbxGo;
        private System.Windows.Forms.PictureBox pbLast;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbCurPage;
        private System.Windows.Forms.Label lbPageCount;
    }
}
