using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double test1;
                double test2;
                double test3;
                double average;

                test1 = double.Parse(testBox1.Text);
                test2 = double.Parse(testBox2.Text);
                test3 = double.Parse(testBox3.Text);

                average = (test1 + test2 + test3) / 3.0;

                averageLabel.Text = average.ToString("n1");
                    }

            catch {Exception  }

            {
                MessageBox.Show(ex.Message);

            }
        
        
        }
    }
}
