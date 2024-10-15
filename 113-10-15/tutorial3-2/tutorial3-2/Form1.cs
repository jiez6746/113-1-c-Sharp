using System.Security.Cryptography;

namespace tutorial3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            double kms;
            double liters;
            double average;

            kms = double.Parse(txbkm.Text);
            liters = double.Parse(txbliter.Text);
            average = kms / liters;

            lblshow.Text = average.ToString();


        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
