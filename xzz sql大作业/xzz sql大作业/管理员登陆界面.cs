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
    public partial class 管理员登陆界面 : Form
    {
        public 管理员登陆界面()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("请输入账号");
                textBox1.Focus();
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("请输入密码");
                textBox2.Focus();
                return;
            }
            object result = DB.GetData("select manaid from management where manaid='" + textBox1.Text + "'and pass='" + textBox2.Text + "'");
            if (result == null)
            {
                MessageBox.Show("账号或密码错误");
                textBox1.Focus();
                return;
            }
            else
            {
                管理员界面 a = new 管理员界面();
                a.z = textBox1.Text;
                a.ShowDialog();

            }
        }
    }
}
