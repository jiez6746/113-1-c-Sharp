namespace Poker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LblShow.Text = "���P";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LblShow.Text = "����J";
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            LblShow.Text = "����5";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            LblShow.Text = "����A";
        }
    }
}
