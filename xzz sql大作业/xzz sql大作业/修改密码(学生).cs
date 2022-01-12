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
    public partial class 修改密码_学生_ : Form
    {
        public string z;
        public 修改密码_学生_()
        {
            InitializeComponent();
        }

        private void 修改密码_学生__Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("请输入旧密码");
                textBox1.Focus();
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("请输入新密码");
                textBox2.Focus();
                return;
            }
            string q = textBox2.Text;
            if (q.Length > 11)
            {
                MessageBox.Show("密码必须小于11位");
                textBox2.Focus();
                return;
            }
            object x = DB.GetData("select * from student where stuid='" + z + "' and pass='" + textBox1.Text + "'");
            if (x == null)
            {
                MessageBox.Show("原密码不对");
                textBox1.Focus();
                return;
            }
            else
            {
                DB.Execute("update student set pass='" + textBox2.Text + "' where stuid='" + z + "'");
                MessageBox.Show("修改成功");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
