namespace LINQ_作业.Controls
{
    partial class UCPager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCPager));
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.tslInfo = new System.Windows.Forms.ToolStripLabel();
            this.tsbFirst = new System.Windows.Forms.ToolStripButton();
            this.tsbPrev = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbNext = new System.Windows.Forms.ToolStripButton();
            this.tsbLast = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tscbPageSize = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tstbCurrentPage = new System.Windows.Forms.ToolStripTextBox();
            this.tsbGo = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BackColor = System.Drawing.Color.White;
            this.bindingNavigator1.CountItem = this.tslInfo;
            this.bindingNavigator1.CountItemFormat = "页码/总页码";
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbFirst,
            this.tsbPrev,
            this.bindingNavigatorSeparator,
            this.tslInfo,
            this.bindingNavigatorSeparator1,
            this.tsbNext,
            this.tsbLast,
            this.bindingNavigatorSeparator2,
            this.toolStripLabel1,
            this.tscbPageSize,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.tstbCurrentPage,
            this.tsbGo});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.tsbFirst;
            this.bindingNavigator1.MoveLastItem = this.tsbLast;
            this.bindingNavigator1.MoveNextItem = this.tsbNext;
            this.bindingNavigator1.MovePreviousItem = this.tsbPrev;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(1230, 33);
            this.bindingNavigator1.TabIndex = 31;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // tslInfo
            // 
            this.tslInfo.Name = "tslInfo";
            this.tslInfo.Size = new System.Drawing.Size(108, 28);
            this.tslInfo.Text = "页码/总页码";
            this.tslInfo.ToolTipText = "总项数";
            // 
            // tsbFirst
            // 
            this.tsbFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFirst.Image = ((System.Drawing.Image)(resources.GetObject("tsbFirst.Image")));
            this.tsbFirst.Name = "tsbFirst";
            this.tsbFirst.RightToLeftAutoMirrorImage = true;
            this.tsbFirst.Size = new System.Drawing.Size(34, 28);
            this.tsbFirst.Text = "移到第一条记录";
            // 
            // tsbPrev
            // 
            this.tsbPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPrev.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrev.Image")));
            this.tsbPrev.Name = "tsbPrev";
            this.tsbPrev.RightToLeftAutoMirrorImage = true;
            this.tsbPrev.Size = new System.Drawing.Size(34, 28);
            this.tsbPrev.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // tsbNext
            // 
            this.tsbNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNext.Image = ((System.Drawing.Image)(resources.GetObject("tsbNext.Image")));
            this.tsbNext.Name = "tsbNext";
            this.tsbNext.RightToLeftAutoMirrorImage = true;
            this.tsbNext.Size = new System.Drawing.Size(34, 28);
            this.tsbNext.Text = "移到下一条记录";
            // 
            // tsbLast
            // 
            this.tsbLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLast.Image = ((System.Drawing.Image)(resources.GetObject("tsbLast.Image")));
            this.tsbLast.Name = "tsbLast";
            this.tsbLast.RightToLeftAutoMirrorImage = true;
            this.tsbLast.Size = new System.Drawing.Size(34, 28);
            this.tsbLast.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(136, 28);
            this.toolStripLabel1.Text = "每页显示条数：";
            // 
            // tscbPageSize
            // 
            this.tscbPageSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscbPageSize.Items.AddRange(new object[] {
            "2",
            "10",
            "20",
            "30",
            "40",
            "50"});
            this.tscbPageSize.Name = "tscbPageSize";
            this.tscbPageSize.Size = new System.Drawing.Size(121, 33);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(64, 28);
            this.toolStripLabel2.Text = "页码：";
            // 
            // tstbCurrentPage
            // 
            this.tstbCurrentPage.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.tstbCurrentPage.Name = "tstbCurrentPage";
            this.tstbCurrentPage.Size = new System.Drawing.Size(100, 33);
            this.tstbCurrentPage.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tsbGo
            // 
            this.tsbGo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbGo.Image = ((System.Drawing.Image)(resources.GetObject("tsbGo.Image")));
            this.tsbGo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGo.Name = "tsbGo";
            this.tsbGo.Size = new System.Drawing.Size(50, 28);
            this.tsbGo.Text = "跳转";
            // 
            // UCPager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bindingNavigator1);
            this.Name = "UCPager";
            this.Size = new System.Drawing.Size(1230, 34);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel tslInfo;
        private System.Windows.Forms.ToolStripButton tsbFirst;
        private System.Windows.Forms.ToolStripButton tsbPrev;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton tsbNext;
        private System.Windows.Forms.ToolStripButton tsbLast;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox tscbPageSize;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox tstbCurrentPage;
        private System.Windows.Forms.ToolStripButton tsbGo;
    }
}
