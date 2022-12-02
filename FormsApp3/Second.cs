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
    public partial class Second : Form
    {
        public Second()
        {
            InitializeComponent();
        }
        static double F(double x)
        {
            double y;
            if (x <= 5) y = Math.Pow(x, 2) + 5;
            else if (x > 5 && x < 20) y = 0;
            else y = 1;
            return y;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, h;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            h = Convert.ToDouble(textBox3.Text);
            
            for (double i = a; i <= b; i += h)
                textBox4.Text += Convert.ToString("f("+i+") = " + F(i) + '\r' + '\n');
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 45)
                e.Handled = true;
        }
    }
}
