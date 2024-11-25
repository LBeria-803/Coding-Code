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
    public partial class DigitCounterForm : Form
    {
        public DigitCounterForm()
        {
            InitializeComponent();
        }

        private void DigitCounterForm_Load(object sender, EventArgs e)
        {
            OutputLabel.Items.Add("");
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            OutputLabel.Items.Clear();

            string strMinNumber = MinNumberTextBox.Text;
            string strMaxNumber = MaxNumberTextBox.Text;
            try
            {
                int minNumber = int.Parse(strMinNumber);
                int maxNumber = int.Parse(strMaxNumber);

                
                for (int currentNumber = minNumber; currentNumber <= maxNumber; currentNumber++)
                {
                    int currentNumberCopy = currentNumber;

                    int digitCount = 0;
                    do
                    {
                        minNumber /= 10;
                        digitCount++;
                    } while (minNumber != 0);
                    OutputLabel.Items.Add("There are " + digitCount + " digits in the number " + currentNumber);
                }
            
            }
            catch (FormatException fe)
            {
            Debug.WriteLine(fe);
            MessageBox.Show("Stop it, moron");
            }
            catch (Exception ex)
            {
            Debug.WriteLine(ex);
            }       
        }
    }
}
