﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_Economy_with_TryParse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double kms;
            double litres;

            if (double.TryParse(milesTextBox.Text, out kms))
              {       
                
               if(double.TryParse(gallonsTextBox.Text,out litres))
                {


                    double mpg = kms/litres;
                    mpgLabel.Text = mpg.ToString("n1");


                }
              
               else
                {

                    MessageBox.Show("耗油量輸入格是錯誤");

                }

            }

            else
                {

                MessageBox.Show("里程數輸入資料格式錯誤");

                    }




        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
