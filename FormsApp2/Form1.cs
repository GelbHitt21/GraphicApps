namespace FormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            First first = new First();
            first.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Second second = new Second();
            second.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Third third = new Third();
            third.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fourth fourth = new Fourth();
            fourth.Show();
        }
    }

}