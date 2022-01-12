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
    public partial class 删除学生 : Form
    {
        public 删除学生()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            object x = DB.GetData("select * from student where stuid='" + textBox1.Text + "'");
            if (x == null)
            {
                MessageBox.Show("不存在这个学生");
                textBox1.Focus();
                return;
            }
            else
            {
                if (MessageBox.Show("确定删除该学生？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    DB.Execute("delete from student where stuid='" + textBox1.Text + "'");
                    MessageBox.Show("删除成功");
                }
                else
                {
                    return;
                }
            }
        }
    }
}
