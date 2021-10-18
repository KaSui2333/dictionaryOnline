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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form main = new Form1();
            this.Hide();
            main.ShowDialog();
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Blue;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn c = new conn();
            String sqlStr = "select id, password from admint where id = '" + textBox1.Text.ToString() + "' and password = '" + textBox2.Text.ToString() + "'";
            int rst = c.ExecuteLogin(sqlStr);
            if (rst != 0)
            {
                MessageBox.Show("登录成功！", "登录结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form admin = new Form3();
                this.Hide();
                admin.ShowDialog();
            }
            else
            {
                MessageBox.Show("登录失败！请检查用户名和密码！", "登录结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
