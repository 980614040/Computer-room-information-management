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
    public partial class 余额充值 : Form
    {
        public 余额充值()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("请输入你要充值的学号");
                textBox1.Focus();
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("请输入你要充值的金额");
                textBox2.Focus();
                return;
            }
            object result = DB.GetData("select * from student where stuid='" + textBox1.Text + "'");
            if (result == null)
            {
                MessageBox.Show("没有您所要充值的学号");
                textBox1.Focus();
                return;
            }
            else
            {
                DB.Execute("update student set balance=balance+'" + textBox2.Text + "' where stuid='" + textBox1.Text + "'");
                MessageBox.Show("充值成功");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
