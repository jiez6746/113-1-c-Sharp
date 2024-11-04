using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sale_Price_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void outputDescriptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void originalPricePromptLabel_Click(object sender, EventArgs e)
        {

        }

        private void discPercentagePromptLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void originalPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void salePriceLabel_Click(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal originalPrice;
            decimal discountPercentage;
            decimal salePrice;
            try
            {
                originalPrice = decimal.Parse(originalPriceTextBox.Text);
                discountPercentage = decimal.Parse(discountPercentageTextBox.Text);
                salePrice = originalPrice - (originalPrice * discountPercentage / 100);

                salePriceLabel.Text = salePrice.ToString("c");
            }
            catch { }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
         
         

        }
    }
}
