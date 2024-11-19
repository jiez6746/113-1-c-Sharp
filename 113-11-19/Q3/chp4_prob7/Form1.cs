using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace chp4_prob7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal income;    //收入
            decimal taxrate;   //稅率
            decimal payable;   //應交稅額
            decimal netIncome; //淨收入

            //以下作答

            try
            {
                income = decimal.Parse(incomeTextBox.Text);
                taxrate = 0;
                netIncome = 0;


                if (income <= 590000)
                {
                    
                    payable = income * 0.05m;
                }
                else if (income <= 1330000)
                {
                    
                    payable = (income - 590000) * 0.12m + (590000 * 0.05m);
                }
                else if (income <= 2660000)
                {
                    
                    payable = (income - 1330000) * 0.20m + (740000 * 0.12m) + (590000 * 0.05m);
                }
                else if (income <= 4980000)
                {

                    payable = (income - 2660000) * 0.30m + (1330000 * 0.20m) + (740000 * 0.12m) + (590000 * 0.05m);
                }
                else
                {
                    payable = (income - 4980000) * 0.40m + (2320000 * 0.30m) + (1330000 * 0.20m) + (740000 * 0.12m) + (590000 * 0.05m);
                }


                netIncome = income - payable;

                label2.Text = payable.ToString("c"); 
                label3.Text = netIncome.ToString("c");


            }

            catch (Exception ex) 
            {
            
            }



            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
