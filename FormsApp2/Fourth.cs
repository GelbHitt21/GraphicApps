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
    public partial class Fourth : Form
    {
        public Fourth()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num = 5;
            for (int i = 1; i <= num; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    textBox1.Text += Convert.ToString(j + "  ");
                }
                textBox1.Text += Environment.NewLine;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }
    }
}
