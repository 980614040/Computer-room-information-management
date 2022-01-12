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
    public partial class 学生信息 : Form
    {
        public string z;
        public 学生信息()
        {
            InitializeComponent();
        }

        private void botton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 学生信息_Load(object sender, EventArgs e)
        {
            DataSet c = DB.GetDs("select * from student where stuid='" + z + "'");
            dataGridView1.DataSource = c.Tables[0].DefaultView;
        }
    }
}
