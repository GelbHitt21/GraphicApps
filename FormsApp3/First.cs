using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp3
{
    public partial class First : Form
    {
        public First()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n;
            n = Convert.ToInt32(textBox1.Text);
            if (n > 9 && n < 100)
            {
                string str = Convert.ToString(n);
                char[] arr = str.ToCharArray();
                Array.Reverse(arr);
                str = new string(arr);
                textBox2.Text = str;
                
            }
            else
            {
                textBox2.Text = Convert.ToString(n);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
