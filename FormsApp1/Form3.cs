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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num, a, sum;
            Console.WriteLine("Двузначное число: ");
            num = int.Parse(textBox1.Text);
            if (num > 9 && num < 100)
            {
                a = int.Parse(textBox2.Text);
                sum = num % 10 + (num / 10) % 10;
                textBox3.Text = ((sum % a) == 0 ? "Кратно" : "Не кратно");
            }
            else
            {
                MessageBox.Show("Введите двузначное число", "Сообщение", MessageBoxButtons.OK);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 45)
                e.Handled = true;
        }
    }
}
