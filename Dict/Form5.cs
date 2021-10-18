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
    public partial class Form5 : Form
    {
        public Form5()
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
            string sql = "delete from xhdict where word='" + textBox1.Text + "'";
            int rst = c.ExecuteUpdate(sql);
            if (rst != 0)
            {
                MessageBox.Show("删除成功！", "删除结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("删除失败！请重新删除！", "删除结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
