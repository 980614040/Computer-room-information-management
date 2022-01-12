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
    public partial class 添加学生 : Form
    {
        public 添加学生()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("请输入学号");
                textBox1.Focus();
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("请输入姓名");
                textBox2.Focus();
                return;
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("请输入性别");
                textBox3.Focus();
                return;
            }
            if (textBox4.Text == "")
            {
                MessageBox.Show("请输入班级编号");
                textBox4.Focus();
                return;
            }
            if (textBox5.Text == "")
            {
                MessageBox.Show("请输入生日");
                textBox5.Focus();
                return;
            }
            if (textBox6.Text == "")
            {
                MessageBox.Show("请输入地址");
                textBox6.Focus();
                return;
            }
            if (textBox7.Text == "")
            {
                MessageBox.Show("请输入密码");
                textBox7.Focus();
                return;
            }
         
            bool x = textBox1.Text.StartsWith("S");
            if(x==false)
            {
                MessageBox.Show("学生编号开头必须为S");
                textBox1.Focus();
                return;
            }
            string x1 = textBox1.Text;
            if (x1.Length != 8)
            {
                MessageBox.Show("学生编号长度必须为8位");
                textBox1.Focus();
                return;
            }
            string x2 = textBox4.Text;
            if (x2.Length != 8)
            {
                MessageBox.Show("班级长度必须为8位");
                textBox4.Focus();
                return;
            }
            object q = DB.GetData("select classid from class where classid='" + textBox4.Text + "'");
            if (q == null)
            {
                MessageBox.Show("没有此班级");
                textBox4.Focus();
                return;
            }
            object q1 = DB.GetData("select stuid from student where stuid='" + textBox1.Text + "'");
            if (q1 != null)
            {
                MessageBox.Show("此学号已经存在");
                textBox1.Focus();
                return;
            }
            string x3 = textBox7.Text;
            if (x3.Length > 11)
            {
                MessageBox.Show("密码过长，请不要超过11位数");
                textBox7.Focus();
                return;
            }
            if (textBox3.Text == "男" || textBox3.Text == "女")
            {
                DB.Execute("insert into student values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "',0,'" + Convert.ToDateTime(textBox5.Text) + "','" + textBox6.Text + "','" + textBox7.Text + "')");
                MessageBox.Show("添加成功");
            }
            else
            {
                MessageBox.Show("性别请输入男或女");
                textBox3.Focus();
                return;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
