using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024_25_02_02_02
{
    public partial class FizzBuzzForm : Form
    {
        public FizzBuzzForm()
        {
            InitializeComponent();
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            string strNum = NumberTextBox.Text;
            int num = 0;
            int givennum = int.Parse(strNum);
            while (givennum > 0) 
            {
                try
                {
                    if (givennum % 15 == 0)
                    {
                        OutcomeBox.Items.Add("FIZZBUZZ");
                    }
                    else if (num % 3 == 0)
                    {
                        OutcomeBox.Items.Add("FIZZ");
                    }
                    else if (num % 5 == 0)
                    {
                        OutcomeBox.Items.Add("BUZZ");
                    }
                    else
                    {
                        OutcomeBox.Items.Add(strNum);
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
                givennum = givennum - 1;
            }
            
        }

        private void FizzBuzzForm_Load(object sender, EventArgs e)
        {
            OutcomeBox.Items.Clear();
        }
    }
}
