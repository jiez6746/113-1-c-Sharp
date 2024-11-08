﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Score_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double test1, test2, test3, average;
            const double HIGHT_SCORE = 95.0;



            try
            {
                test1 = double.Parse(test1TextBox.Text);
                test2 = double.Parse(test2TextBox.Text);
                test3 = double.Parse(test3TextBox.Text);

                average = (test1 + test2 + test3) / 3;

                averageLabel.Text = average.ToString("n1");

                if (average > HIGHT_SCORE)
                {
                    MessageBox.Show("恭喜!幹的好!");
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                }

            }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the TextBoxes and the averageLabel control.
            

            // Reset the focus to test1.
           
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.

            
        }

        private void clearButton_Click_1(object sender, EventArgs e)
        {
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";
            averageLabel.Text = "";
        }

        private void exitButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
