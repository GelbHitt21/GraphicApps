using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp2
{
    public partial class Third : Form
    {
        public Third()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);

            while (a <= b)
            {
                if (a % 2 == 0)
                    textBox3.Text += Convert.ToString(a+" ");
                a++;
            }
            do
            {
                if (a % 2 == 0)
                    textBox4.Text += Convert.ToString(a + " ");
                a++;
            }
            while (a <= b);
            for (int i = a; i <= b; i++)
            {
                if (i % 2 == 0)
                 textBox5.Text += Convert.ToString(a + " ");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 45)
                e.Handled = true;
        }
    }
}
