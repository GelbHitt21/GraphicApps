using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x1, x2, x3, y1, y2, y3;
            double res, a, b, c, p;
            
            x1 = Convert.ToInt32(textBox1.Text);
            y1 = Convert.ToInt32(textBox2.Text);
            x2 = Convert.ToInt32(textBox4.Text);
            y2 = Convert.ToInt32(textBox3.Text);
            x3 = Convert.ToInt32(textBox6.Text);
            y3 = Convert.ToInt32(textBox5.Text);

            a = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            b = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            c = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));
            if (a == 0 || b == 0 || c == 0)
            {
                MessageBox.Show("Такого треугольника не существует", "Сообщение", MessageBoxButtons.OK);
            }
            else
            {
                p = (a + b + c) / 2;

                res = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

                textBox7.Text = Convert.ToString(res);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 45)
                e.Handled = true;
        }
    }
}
