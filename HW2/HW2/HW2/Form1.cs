namespace HW2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void �w�����_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {


            try
            {
                //�Ⲽ�ƶq
                decimal ClassA = 15.0m;
                decimal ClassB = 12.0m;
                decimal ClassC = 9.0m;

                textBox1.Text = ("");
                textBox2.Text = ("");
                textBox3.Text = ("");

                int lblticketa = int.Parse(textBox1.Text);
                int lblticjetb = int.Parse(textBox2.Text);
                int lblticketc = int.Parse(textBox3.Text);

                //�P����B
                
                    
                



                 
                



            }

            catch { }

            







        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text= "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
