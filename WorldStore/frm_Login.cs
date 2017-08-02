using Service.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorldStore.DataBase;

namespace WorldStore
{
    public partial class frm_Login : Form
    {
        Employee employee = new Employee();

        public Employee Employee
        {
            get { return employee; }
            set { employee = value; }
        }
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btnLonin_Click(object sender, EventArgs e)
        {
            string name = tbxName.Text.Trim();
            string password = DecryptEncrypt.EncryptText(tbxPassword.Text.Trim());
            if (name.Length == 0)
            {
                MessageBox.Show("登录名不能为空！请重新填写。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbxName.Focus();
                return;
            }

            List<string[]> liWhere = new List<string[]>();
            liWhere.Add(new string[] { "UserName = {0}", name });
            liWhere.Add(new string[] { "PassWord = {0}", password });
            DataTable dt = employee.GetDataSet("SELECT Employee_ID FROM Employee", liWhere);
            if (dt.Rows.Count > 0)
            {
                employee.FindbyPK(dt.Rows[0][0].ToString());
                GenericIdentity GenIdentity = new GenericIdentity(employee.Employee_ID.ToString());
                GenericPrincipal GenPrincipal = new GenericPrincipal(GenIdentity, null);
                Thread.CurrentPrincipal = GenPrincipal;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                lbLoginFailed.Visible = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }


        const int AW_VER_NEGATIVE = 0x0008;
        const int AW_CENTER = 0x0010;
        const int AW_HIDE = 0x10000;
        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnimateWindow(this.Handle, 1000, AW_CENTER | AW_HIDE | AW_VER_NEGATIVE);
        }
        [System.Runtime.InteropServices.DllImport("user32")]
        private static extern bool AnimateWindow(IntPtr hwnd, int dwTime, int dwFlags);
    }
}
