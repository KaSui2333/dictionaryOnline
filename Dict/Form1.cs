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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form login = new Form2();
            this.Hide();
            login.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn c = new conn();
            String sqlStr = "select * from xhdict where word='" + textBox1.Text.ToString() + "'";
            //清空datagridview中数据
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            DataTable d1 = new DataTable();
            d1 = c.ExecuteQuery(sqlStr);
            dataGridView1.DataSource = d1;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "WORD";
            dataGridView1.Columns[2].HeaderText = "PRON";
            dataGridView1.Columns[3].HeaderText = "MEAN";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn c = new conn();
            String sqlStr = "select * from xhdict where pron='" + textBox2.Text.ToString() + "'";
            //清空datagridview中数据
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            DataTable d2 = new DataTable();
            d2 = c.ExecuteQuery(sqlStr);
            dataGridView1.DataSource = d2;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "WORD";
            dataGridView1.Columns[2].HeaderText = "PRON";
            dataGridView1.Columns[3].HeaderText = "MEAN";
        }
    }
}
