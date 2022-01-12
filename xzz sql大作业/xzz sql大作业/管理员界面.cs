using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xzz_sql大作业
{
    public partial class 管理员界面 : Form
    {
        public string z;
        public 管理员界面()
        {
            InitializeComponent();
        }

        private void 管理员界面_Load(object sender, EventArgs e)
        {
            label1.Text = "欢迎使用此系统，编号为" + z + "的老师";
        }

        private void 管理员信息查看ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            管理员信息 a = new 管理员信息();
            a.z = z;
            a.ShowDialog();
            
        }

        private void 班级学生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            班级学生信息 a = new 班级学生信息();
            a.z = z;
            a.ShowDialog();
        }

        private void 班级上课时间查看ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            教师上课时间 a = new 教师上课时间();
            a.z = z;
            a.ShowDialog();
            
        }

        private void 机房预订ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            机房预订cs a = new 机房预订cs();
            a.z = z;
            a.ShowDialog();
        }

        private void 学生娱乐机房记录查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            娱乐机房查询 a = new 娱乐机房查询();
            a.z = z;
            a.ShowDialog();
        }

        private void 添加学生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new 添加学生().ShowDialog();
        }

        private void 删除学生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new 删除学生().ShowDialog();
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            修改密码_管理员_ a = new 修改密码_管理员_();
            a.z = z;
            a.ShowDialog();
        }
    }
}
