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
    public partial class First : Form
    {
        public First()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, y;
            while (true)
            {
                try
                {
                    x = Convert.ToDouble(textBox1.Text);
                    y = Convert.ToDouble(textBox2.Text);
                    break;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Некорректное значение, введите число");
                }
            }
            if (x < -40 || x > 40 || y < -40 || y > 40)
                textBox3.Text = "внутри области";
            else if (x == -40 || x == 40 || y == -40 || y == 40)
                textBox3.Text = "на границе области";
            else if (x > -40 || x < 40 || y > -40 || y < 40)
                textBox3.Text = "вне области";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new();
            form1.Show();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 45)
                e.Handled = true;
        }
    }
}
