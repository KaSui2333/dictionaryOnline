using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dict
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn c = new conn();
            String sqlStr1 = "select * from xhdict order by id";
            //清空datagridview中数据
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            DataTable d1 = new DataTable();
            d1 = c.ExecuteQuery(sqlStr1);
            dataGridView1.DataSource = d1;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "WORD";
            dataGridView1.Columns[2].HeaderText = "PRON";
            dataGridView1.Columns[3].HeaderText = "MEAN";
            String prc = "countnum";
            String cs = "num";
            label1.Text = "共有"+c.ExecutePrc(prc,cs)+"条数据。";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form add = new Form4();
            this.Hide();
            add.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form upd = new Form6();
            this.Hide();
            upd.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form del = new Form5();
            this.Hide();
            del.ShowDialog();
        }
    }
}
