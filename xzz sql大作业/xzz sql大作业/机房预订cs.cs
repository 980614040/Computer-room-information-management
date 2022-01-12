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
    public partial class 机房预订cs : Form
    {
        public string z;
        public 机房预订cs()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 机房预订cs_Load(object sender, EventArgs e)
        {
            DataSet c = DB.GetDs("select * from syllabus");
            dataGridView1.DataSource = c.Tables[0].DefaultView;
            DataSet c1 = DB.GetDs("select cmroomid from cmroom where cmroomid like 'T[0-9][0-9]'");
            comboBox1.DataSource = c1.Tables[0].DefaultView;
            comboBox1.DisplayMember = "cmroomid";
            comboBox1.ValueMember = "cmroomid";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("请输入你准备预订的机房");
                comboBox1.Focus();
                return;
            }
            if (comboBox2.Text == "")
            {
                MessageBox.Show("请输入你准备上课的时间");
                comboBox2.Focus();
                return;
            }
            object result = DB.GetData("select * from syllabus where cmroomid='" + comboBox1.Text + "' and schooltime='" + comboBox2.Text + "'");
            if (result != null)
            {
                MessageBox.Show("当前时间已被占用，请重新预订");
                comboBox1.Focus();
                return;
            }
            else
            {
                DB.Execute("insert into syllabus values('" + comboBox1.Text + "',(select classid from class,management where management.manaid=class.manaid and management.manaid='"+z+"'),'" + comboBox2.Text + "','0')");
                MessageBox.Show("预订成功");
                DataSet c = DB.GetDs("select * from syllabus");
                dataGridView1.DataSource = c.Tables[0].DefaultView;
            }
        }
    }
}
