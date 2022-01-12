namespace xzz_sql大作业
{
    partial class 学生窗体
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.个人信息查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上课时间查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.余额充值ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.娱乐上机ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.个人信息查询ToolStripMenuItem,
            this.上课时间查询ToolStripMenuItem,
            this.余额充值ToolStripMenuItem,
            this.娱乐上机ToolStripMenuItem,
            this.修改密码ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 个人信息查询ToolStripMenuItem
            // 
            this.个人信息查询ToolStripMenuItem.Name = "个人信息查询ToolStripMenuItem";
            this.个人信息查询ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.个人信息查询ToolStripMenuItem.Text = "个人信息查询";
            this.个人信息查询ToolStripMenuItem.Click += new System.EventHandler(this.个人信息查询ToolStripMenuItem_Click_1);
            // 
            // 上课时间查询ToolStripMenuItem
            // 
            this.上课时间查询ToolStripMenuItem.Name = "上课时间查询ToolStripMenuItem";
            this.上课时间查询ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.上课时间查询ToolStripMenuItem.Text = "上课时间查询";
            this.上课时间查询ToolStripMenuItem.Click += new System.EventHandler(this.上课时间查询ToolStripMenuItem_Click);
            // 
            // 余额充值ToolStripMenuItem
            // 
            this.余额充值ToolStripMenuItem.Name = "余额充值ToolStripMenuItem";
            this.余额充值ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.余额充值ToolStripMenuItem.Text = "余额充值";
            this.余额充值ToolStripMenuItem.Click += new System.EventHandler(this.余额充值ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 1;
            // 
            // 娱乐上机ToolStripMenuItem
            // 
            this.娱乐上机ToolStripMenuItem.Name = "娱乐上机ToolStripMenuItem";
            this.娱乐上机ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.娱乐上机ToolStripMenuItem.Text = "娱乐上机";
            this.娱乐上机ToolStripMenuItem.Click += new System.EventHandler(this.娱乐上机ToolStripMenuItem_Click);
            // 
            // 修改密码ToolStripMenuItem
            // 
            this.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            this.修改密码ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.修改密码ToolStripMenuItem.Text = "修改密码";
            this.修改密码ToolStripMenuItem.Click += new System.EventHandler(this.修改密码ToolStripMenuItem_Click);
            // 
            // 学生窗体
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "学生窗体";
            this.Text = "学生窗体";
            this.Load += new System.EventHandler(this.学生窗体_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 个人信息查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 上课时间查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 余额充值ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem 娱乐上机ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem;
    }
}