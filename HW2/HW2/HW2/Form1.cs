using System.Runtime.InteropServices;

namespace HW2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxA.Text = "";
            textBoxB.Text = "";
            textBoxC.Text = "";
            lblclassA.Text = "";
            lblclassB.Text = "";
            lblclassC.Text = "";
            lblTotal.Text = "";


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            try
            {

               int ticketA = int.Parse(textBoxA.Text);
               int ticketB = int.Parse(textBoxB.Text);
               int ticketC = int.Parse(textBoxC.Text);

                const decimal priceA = 15m;
                const decimal priceB = 12m;
                const decimal priceC = 9m;


                
                decimal ClassA = ticketA * priceA;
                decimal ClassB = ticketB * priceB;
                decimal ClassC = ticketC * priceC;
                decimal Total = ClassA + ClassB + ClassC ;

                lblclassA.Text = ClassA.ToString("c");
                lblclassB.Text = ClassB.ToString("c");
                lblclassC.Text = ClassC.ToString("c");
                lblTotal.Text = Total.ToString("c");
                


                
                
                
                
                


            }

            catch (Exception ) { }
            

        }
    }
}
