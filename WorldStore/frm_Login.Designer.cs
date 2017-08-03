namespace WorldStore
{
    partial class frm_Login
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
            this.lbLoginFailed = new System.Windows.Forms.Label();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLonin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbLoginFailed
            // 
            this.lbLoginFailed.AutoSize = true;
            this.lbLoginFailed.BackColor = System.Drawing.SystemColors.Control;
            this.lbLoginFailed.ForeColor = System.Drawing.Color.Red;
            this.lbLoginFailed.Location = new System.Drawing.Point(401, 252);
            this.lbLoginFailed.Name = "lbLoginFailed";
            this.lbLoginFailed.Size = new System.Drawing.Size(131, 12);
            this.lbLoginFailed.TabIndex = 20;
            this.lbLoginFailed.Text = "*用户名或密码不正确！";
            this.lbLoginFailed.Visible = false;
            // 
            // tbxPassword
            // 
            this.tbxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPassword.Location = new System.Drawing.Point(410, 226);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '*';
            this.tbxPassword.Size = new System.Drawing.Size(114, 21);
            this.tbxPassword.TabIndex = 15;
            this.tbxPassword.Text = "123456";
            this.tbxPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Location = new System.Drawing.Point(351, 229);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 12);
            this.lblPassword.TabIndex = 19;
            this.lblPassword.Text = "密  码：";
            // 
            // tbxName
            // 
            this.tbxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxName.Location = new System.Drawing.Point(410, 189);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(114, 21);
            this.tbxName.TabIndex = 14;
            this.tbxName.Text = "zhangwei";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Location = new System.Drawing.Point(351, 192);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 12);
            this.lblName.TabIndex = 18;
            this.lblName.Text = "登录名：";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(470, 268);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(54, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "取 消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLonin
            // 
            this.btnLonin.BackColor = System.Drawing.Color.Transparent;
            this.btnLonin.Location = new System.Drawing.Point(410, 268);
            this.btnLonin.Name = "btnLonin";
            this.btnLonin.Size = new System.Drawing.Size(54, 23);
            this.btnLonin.TabIndex = 16;
            this.btnLonin.Text = "登 录";
            this.btnLonin.UseMnemonic = false;
            this.btnLonin.UseVisualStyleBackColor = false;
            this.btnLonin.Click += new System.EventHandler(this.btnLonin_Click);
            // 
            // frm_Login
            // 
            this.AcceptButton = this.btnLonin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(595, 366);
            this.Controls.Add(this.lbLoginFailed);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLonin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户登录";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLoginFailed;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLonin;
    }
}