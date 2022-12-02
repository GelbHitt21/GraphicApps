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
    public partial class Second : Form
    {
        public Second()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime start = new DateTime(1990, 1, 1);
            int m, n;
            m = Convert.ToInt32(textBox1.Text);
            n = Convert.ToInt32(textBox2.Text);
            
            DateTime finish = start.AddMonths(m);
            finish = finish.AddDays(n);
            int month = finish.Month;
            string s_month = "";
            switch (month)
            {
                case 1: s_month = "Январь"; break;
                case 2: s_month = "Февраль"; break;
                case 3: s_month = "Март"; break;
                case 4: s_month = "Апрель"; break;
                case 5: s_month = "Май"; break;
                case 6: s_month = "Июнь"; break;
                case 7: s_month = "Июль"; break;
                case 8: s_month = "Август"; break;
                case 9: s_month = "Сентябрь"; break;
                case 10: s_month = "Октябрь"; break;
                case 11: s_month = "Ноябрь"; break;
                case 12: s_month = "Декабрь"; break;
            }
            textBox3.Text = s_month;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
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
