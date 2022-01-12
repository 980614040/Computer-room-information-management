using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace xzz_sql大作业
{
    public partial class 学生窗体 : Form
    {
        public string z;

        public 学生窗体()
        {
            InitializeComponent();
        }

        private void 个人信息查询ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            学生信息 a = new 学生信息();
            a.z = z;
            a.ShowDialog();

        }

        private void 上课时间查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            上课时间 a = new 上课时间();
            a.z = z;
            a.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 余额充值ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new 余额充值().ShowDialog();
        }

        private void 学生窗体_Load(object sender, EventArgs e)
        {
            label1.Text = "欢迎使用此窗体，学号为" + z + "的同学";
        }

        private void 娱乐上机ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            学生娱乐上机 a = new 学生娱乐上机();
            a.z = z;
            a.ShowDialog();
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            修改密码_学生_ a = new 修改密码_学生_();
            a.z = z;
            a.ShowDialog();
        }
    }
}
