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
                
                decimal ClassA;
                decimal ClassB;
                decimal ClassC;
                

                ClassA = decimal.Parse(textBoxA.Text);
                ClassB = decimal.Parse(textBoxB.Text);
                ClassC = decimal.Parse(textBoxC.Text);


                //�P����B

                decimal  saleA = ClassA * 15.0m;
                decimal  saleB = ClassB * 12.0m;
                decimal  saleC = ClassC * 9.0m;
                decimal  total = saleA + saleB + saleC;


               




                
               
            }

            catch (Exception ex)
            {
             
            MessageBox.Show(ex.Message);
               
            }






        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxA.Text= "";
            textBoxB.Text = "";
            textBoxC.Text = "";
        }
    }
}
