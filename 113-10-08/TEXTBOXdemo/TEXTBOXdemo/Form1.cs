namespace TEXTBOXdemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            string fullName; //變數一定要先宣告型態後才能用
            string firstName;
            string lastName;

            firstName = txtfirst.Text;
            lastName = txtlast.Text;
            fullName = lastName + " " + firstName;

            lblshow.Text = fullName;
        }
    }
}
