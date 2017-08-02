using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using WorldStore.Properties;
using Service.Common.DB;
using Service.Common;

namespace WorldStore.Controls
{
    public delegate void PageEntrust();//定义委托
    public partial class UCPage : UserControl
    {
        public event PageEntrust PageEvent; //定义事件
        Int32 pageSize = 20;
        Int32 RecCount = 0;
        Int32 PageCount = 0;
        Int32 curPage = 1;

        string dataSetSql = "";
        List<string[]> liWhere = new List<string[]>();
        List<string[]> liorder = new List<string[]>();

        public Int32 PageSize
        {
            get { return pageSize; }
            set { pageSize = value; }
        }
        public Int32 CurPage
        {
            get { return curPage; }
            set { curPage = value; }
        }
        public string DataSetSql
        {
            get { return dataSetSql; }
            set { dataSetSql = value; }
        }
        public List<string[]> LiWhere
        {
            get { return liWhere; }
            set { liWhere = value; }
        }
        public List<string[]> LiOrder
        {
            get { return liorder; }
            set { liorder = value; }
        }
        public UCPage()
        {
            InitializeComponent();
        }


        public DataTable GetDataTable()
        {
            MSSqlCore msc = new MSSqlCore();
            RecCount = msc.GetDataSetCount(dataSetSql, liWhere);
            lbRecCount.Text = "共" + RecCount + "条记录";
            double dbCount = (double)RecCount / (double)pageSize;
            PageCount = Convert.ToInt32(Math.Ceiling(dbCount));
            lbPageCount.Text = "共" + PageCount + "页";
            lbCurPage.Text = "第" + curPage + "页";

            if (PageCount < 2)
            {
                tbxGo.Enabled = false;
                btnJump.Enabled = false;
            }
            else
            {
                tbxGo.Enabled = true;
                btnJump.Enabled = true;
            }

            if (curPage < 2)
            {
                pbFirst.Image = Resources.IconFirst1;
                pbFirst.Cursor = Cursors.Arrow;

                pbPrevious.Image = Resources.IconPrevious1;
                pbPrevious.Cursor = Cursors.Arrow;

            }
            else
            {
                pbFirst.Image = Resources.IconFirst;
                pbFirst.Cursor = Cursors.Hand;

                pbPrevious.Image = Resources.IconPrevious;
                pbPrevious.Cursor = Cursors.Hand;
            }

            if (curPage == PageCount)
            {
                pbLast.Image = Resources.IconLast1;
                pbLast.Cursor = Cursors.Arrow;

                pbNext.Image = Resources.IconNext1;
                pbNext.Cursor = Cursors.Arrow;
            }
            else
            {
                pbLast.Image = Resources.IconLast;
                pbLast.Cursor = Cursors.Hand;

                pbNext.Image = Resources.IconNext;
                pbNext.Cursor = Cursors.Hand;
            }

            if (PageCount == 0)
            {
                pbFirst.Image = Resources.IconFirst1;
                pbFirst.Cursor = Cursors.Arrow;
                pbPrevious.Image = Resources.IconPrevious1;
                pbPrevious.Cursor = Cursors.Arrow;
                pbNext.Image = Resources.IconNext1;
                pbNext.Cursor = Cursors.Arrow;
                pbLast.Image = Resources.IconLast1;
                pbLast.Cursor = Cursors.Arrow;
            }


            Int32 rowBegin = (curPage - 1) * pageSize;
            Int32 rowEnd = curPage * pageSize;
            return msc.GetDataSet(dataSetSql, liWhere, liorder, rowBegin, rowEnd);
        }

        private void pbPrevious_Click(object sender, EventArgs e)
        {
            if (curPage <= 1)
            {
                return;
            }
            curPage--;
            tbxGo.Text = curPage.ToString();
            PageEvent();
        }

        private void pbNext_Click(object sender, EventArgs e)
        {
            if (curPage >= PageCount)
            {
                return;
            }
            curPage++;
            tbxGo.Text = curPage.ToString();
            PageEvent();
        }

        private void pbFirst_Click(object sender, EventArgs e)
        {
            if (curPage <= 1)
            {
                return;
            }
            curPage = 1;
            tbxGo.Text = curPage.ToString();
            PageEvent();
        }

        private void pbLast_Click(object sender, EventArgs e)
        {
            if (curPage >= PageCount)
            {
                return;
            }
            curPage = PageCount;
            tbxGo.Text = curPage.ToString();
            PageEvent();
        }

        private void tbxGo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlCommon.VerDigital(e);
        }

        private void btnJump_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^[0-9]*$");
            if (regex.IsMatch(tbxGo.Text))
            {
                Int32 JumpPage = Convert.ToInt32(tbxGo.Text);
                if (1 <= JumpPage && JumpPage <= PageCount)
                {
                    curPage = JumpPage;
                    PageEvent();
                }
            }
        }
    }
}
