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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form admin = new Form3();
            this.Hide();
            admin.ShowDialog();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Blue;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn c = new conn();
            string sql = "insert into xhdict(word,pron,mean) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
            try
            {
                int rst = c.ExecuteUpdate(sql);
                if (rst != 0)
                {
                    MessageBox.Show("添加成功！", "添加结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("添加失败！请重新添加！", "添加结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
