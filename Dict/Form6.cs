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
    public partial class Form6 : Form
    {
        public Form6()
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
            string sql= "";
            if (textBox2.Text == "" && textBox3.Text != "")
            {
                sql = "update xhdict set mean='" + textBox3.Text + "' where word='" + textBox1.Text + "'";
            }
            else if (textBox3.Text == "" && textBox2.Text != "")
            {
                sql = "update xhdict set pron='" + textBox2.Text + "' where word='" + textBox1.Text + "'";
            }
            else if (textBox3.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("音和意不能同时为空！", "错误输入", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (textBox3.Text != "" && textBox2.Text != "")
            {
                sql = "update xhdict set pron='" + textBox2.Text + "',mean='" + textBox3.Text + "' where word='" + textBox1.Text + "'";
            }
            try{
                int rst = c.ExecuteUpdate(sql);
                if (rst != 0)
                {
                    MessageBox.Show("修改成功！", "修改结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("修改失败！请重新修改！", "修改结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
