namespace FormsApp3
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
    }
}