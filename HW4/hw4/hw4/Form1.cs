namespace hw4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int initialbacteria = 600;
            int doublingtime = 4;

            listBox1.Items.Clear();

            for (int day = 1; day <= 10; day++)
            {
                double bacterialcount = initialbacteria * Math.Pow(2, (double)day / doublingtime);
                listBox1.Items.Add($"²Ä{day}¤Ñ:{Math.Round(bacterialcount):F0}­Ó²Óµß");

            }

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
