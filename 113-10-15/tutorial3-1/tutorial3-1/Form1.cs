using Microsoft.VisualBasic.ApplicationServices;

namespace tutorial3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtdayweek_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnshowday_Click(object sender, EventArgs e)
        {
            String output;

            output = "����" + txtyear.Text + "�~" + txtmounth.Text + "��" + txtday.Text + "��" + "�P��" + txtweek.Text;

            lblshow.Text = output;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtweek.Text = "";
            txtday.Text = "";
            txtmounth.Text = "";
            txtyear.Text = "";
            lblshow.Text = "";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
