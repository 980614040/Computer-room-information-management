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
    public partial class 教师上课时间 : Form
    {
        public string z;
        public 教师上课时间()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 教师上课时间_Load(object sender, EventArgs e)
        {
            DataSet c = DB.GetDs("select syllabus.*  from syllabus,class,management where syllabus.classid=class.classid and management.manaid=class.manaid and management.manaid='" + z + "'");
            dataGridView1.DataSource = c.Tables[0].DefaultView;
        }
    }
}
