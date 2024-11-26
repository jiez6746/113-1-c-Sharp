using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ending_Balance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the TextBoxes, the endingBalanceLabel control,
            // and the ListBox.
            startingBalTextBox.Text = "";
            monthsTextBox.Text = "";
            endingBalanceLabel.Text = "";
            detailListBox.Items.Clear();

            // Reset the focus.
            startingBalTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            const decimal INTEREST_RATE = 0.005m;
            decimal balance;
            int months;

            if (decimal.TryParse(startingBalTextBox.Text, out balance))

            {

                if (int.TryParse(monthsTextBox.Text, out months))
                {

                    int count = 1;
                    do
                    {

                        balance = balance + (INTEREST_RATE * balance);
                        count += 1;
                        detailListBox.Items.Add("第" + count + "個月的餘額是" + balance.ToString("c"));
                    } while (count <= months);

                    endingBalanceLabel.Text = balance.ToString("c");

                }

                else
                {

                    MessageBox.Show("顯示「月份數量」資料錯誤");
                }

            }
            else
            {

                MessageBox.Show("顯示「起始餘額」資料錯誤");

            }
        }
    }
}
