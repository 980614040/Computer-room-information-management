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
    public partial class 学生娱乐上机 : Form
    {
        public string z;
        public 学生娱乐上机()
        {
            InitializeComponent();
        }

        private void 学生娱乐上机_Load(object sender, EventArgs e)
        {
            DataSet c = DB.GetDs("select cmroomid from cmroom where cmroomid like 'Y[0-9][0-9]'");
            comboBox1.DataSource = c.Tables[0].DefaultView;
            comboBox1.DisplayMember = "cmroomid";
            comboBox1.ValueMember = "cmroomid";
            button2.Enabled = false;
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataSet c = DB.GetDs("select comid from computer where cmroomid='" + comboBox1.Text + "'");
            comboBox2.DataSource = c.Tables[0].DefaultView;
            comboBox2.DisplayMember = "comid";
            comboBox2.ValueMember = "comid";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_DisplayMemberChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_ValueMemberChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("请选择要上机的机房");
                comboBox1.Focus();
                return;
            }
            if (comboBox2.Text == "")
            {
                MessageBox.Show("请选择要电脑");
                comboBox2.Focus();
                return;
            }
            object result = DB.GetDs("select comid from computer where cmroomid='" + comboBox1.Text + "'");
            if (result == null)
            {
                MessageBox.Show("所选机器不再此机房");
                comboBox1.Focus();
                return;
            }
            else
            {

                DB.Execute("insert into cmrecord (stuid,cmroomid,comid,cmroomtype,price,sjtime,state) values ('" + z + "','" + comboBox1.Text + "','" + comboBox2.Text + "','娱乐教室',(select price from cmroom where cmroomid='" + comboBox1.Text + "'),'" + DateTime.Now.ToLongTimeString() + "','0')");
                button2.Enabled = true;
                button1.Enabled = false;
                button3.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DB.Execute("update cmrecord set xitime='" + DateTime.Now.ToLongTimeString().ToString() + "' where state=0");
            DB.Execute("update cmrecord set allmoney=datediff(ss,xitime,sjtime)*price,state=1 where state=0");
            MessageBox.Show("下机成功");
            button2.Enabled = false;
            button1.Enabled = true;
            button3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
