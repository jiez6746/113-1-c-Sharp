using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Load_Event
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            exitButton.Text = "離開";
            try
            {
                StreamReader inputFile; //讀取檔案
                string countryName;     //存取檔案
                if (openFile.ShowDialog() == DialogResult.OK)
                {

                    inputFile = File.OpenText(openFile.FileName); //開啟檔案
                    countriesListBox.Items.Clear();

                    while (!inputFile.EndOfStream)               //  未達檔案結尾(?)
                    {
                        countryName = inputFile.ReadLine();     //  讀取一航資料
                        countriesListBox.Items.Add(countryName);//  將資料加入listbox
                    }

                    inputFile.Close();

                }

                else
                {

                    MessageBox.Show("未選擇檔案!");

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void countriesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(countriesListBox.SelectedItem.ToString());
        }
    }

       
        
            
           
        }
    

