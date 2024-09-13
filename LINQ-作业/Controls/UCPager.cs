using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace LINQ_作业.Controls
{
    public partial class UCPager : UserControl
    {
        #region 自定义分页委托和分页事件
        /// <summary>
        /// 分页委托PagerDeletegate
        /// </summary>
        /// <param name="currentPage">当前页码</param>
        /// <param name="pageSize">每页显示条数</param>
        /// <param name="totalCount">总记录数，用来求总页码</param>
        public delegate void PagerDeletegate(int currentPage, int pageSize, out int totalCount);
        /// <summary>
        /// 使用分页委托PagerDeletegate类型，创建分页事件PagerEvent，用来绑定分页逻辑
        /// </summary>
        public event PagerDeletegate PagerEvent;
        #endregion

        #region 构造函数
        public UCPager()
        {
            InitializeComponent();
            Load += UCPager_Load;
            tsbFirst.Click += TsbFirst_Click;
            tsbPrev.Click += TsbPrev_Click;
            tsbNext.Click += TsbNext_Click;
            tsbLast.Click += TsbLast_Click;
            tscbPageSize.SelectedIndexChanged += TscbPageSize_SelectedIndexChanged;
            tstbCurrentPage.KeyPress += TstbCurrentPage_KeyPress;
            tsbGo.Click += TsbGo_Click;
        }
        #endregion

        #region 窗体加载事件
        private void UCPager_Load(object sender, EventArgs e)
        {
            tscbPageSize.SelectedIndex = 3; // 默认每页显示10条
        }
        #endregion

        #region 公开属性
        private int pageSize = 10;
        [Browsable(true), Category("杂项"), Description("每页显示的条数")]
        public int PageSize
        {
            get { return pageSize; }
            set { pageSize = value; Invalidate(); }
        }

        private int currentPage = 1;
        [Browsable(true), Category("杂项"), Description("当前页码")]
        public int CurrentPage
        {
            get { return currentPage; }
            set { currentPage = value; Invalidate(); }
        }

        private int totalCount = 0;
        [Browsable(true), Category("杂项"), Description("总记录数")]
        public int TotalCount
        {
            get { return totalCount; }
            set { totalCount = value; Invalidate(); }
        }

        private int totalPage = 0;
        [Browsable(true), Category("杂项"), Description("总页数=总记录数/每页显示的条数")]
        public int TotalPage
        {
            get { return totalPage; }
            set { totalPage = value; Invalidate(); }
        }
        #endregion

        #region 首页、上一页、下一页、尾页事件
        private void TsbFirst_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            GetPagerData();
        }

        private void TsbPrev_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
                currentPage = currentPage - 1;
            else
                currentPage = 1;
            GetPagerData();
        }

        private void TsbNext_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPage)
                currentPage = currentPage + 1;
            else
                currentPage = totalPage;
            GetPagerData();
        }

        private void TsbLast_Click(object sender, EventArgs e)
        {
            currentPage = totalPage;
            GetPagerData();
        }
        #endregion

        #region 每页显示条数变化事件
        private void TscbPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            pageSize = Convert.ToInt32(tscbPageSize.SelectedItem);
            currentPage = 1;
            if (PagerEvent != null) GetPagerData();
        }
        #endregion

        #region 页码只能输入数字事件
        private void TstbCurrentPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8 || e.KeyChar == 13 || e.KeyChar == 127)
            {
                e.Handled = false;
                if (e.KeyChar == 13)
                {
                    if (!string.IsNullOrEmpty(tstbCurrentPage.Text))
                        tsbGo.PerformClick();
                    else
                    {
                        tstbCurrentPage.Text = "1";
                        tsbGo.PerformClick();
                    }
                }
            }
            else
            {
                e.Handled = true;
            }
        }
        #endregion

        #region 跳转到指定页事件
        private void TsbGo_Click(object sender, EventArgs e)
        {
            currentPage = Convert.ToInt32(tstbCurrentPage.Text);
            GetPagerData();
        }
        #endregion

        #region 触发PagerEvent事件的入口GetPagerData()方法
        public void GetPagerData()
        {
            if (PagerEvent == null) throw new Exception("需要设置分页事件");
            PagerEvent(currentPage, pageSize, out totalCount);

            totalPage = totalCount % pageSize == 0 ? totalCount / pageSize : totalCount / pageSize + 1;

            #region 禁用或启用按钮
            if (totalPage == 0 || totalPage == 1)
            {
                tsbFirst.Enabled = false;
                tsbPrev.Enabled = false;
                tsbNext.Enabled = false;
                tsbLast.Enabled = false;
            }
            else
            {
                if (currentPage == 1)
                {
                    tsbFirst.Enabled = false;
                    tsbPrev.Enabled = false;
                    tsbNext.Enabled = true;
                    tsbLast.Enabled = true;
                }

                if (currentPage > 1 && currentPage < totalPage)
                {
                    tsbFirst.Enabled = true;
                    tsbPrev.Enabled = true;
                    tsbNext.Enabled = true;
                    tsbLast.Enabled = true;
                }

                if (currentPage == totalPage)
                {
                    tsbFirst.Enabled = true;
                    tsbPrev.Enabled = true;
                    tsbNext.Enabled = false;
                    tsbLast.Enabled = false;
                }
            }
            #endregion

            tslInfo.Text = $"{currentPage}/{totalPage}";// 显示当前页码和总页数
            tstbCurrentPage.Text = currentPage.ToString();// 显示当前页码
        }
        #endregion
    }
}
