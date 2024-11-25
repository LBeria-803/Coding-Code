using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024_25_02_02_02
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void LaunchFizzBuzzForm_Click(object sender, EventArgs e)
        {
            FizzBuzzForm fizzBuzzForm = new FizzBuzzForm();
            fizzBuzzForm.ShowDialog(this);
        }

        private void LaunchDigitCounterForm_Click(object sender, EventArgs e)
        {
            DigitCounterForm digitCounterForm = new DigitCounterForm();
            digitCounterForm.ShowDialog(this);
        }

        private void LaunchSecretNumberForm_Click(object sender, EventArgs e)
        {
            SecretNumberForm secretNumberForm = new SecretNumberForm();
            secretNumberForm.ShowDialog(this);
        }

        private void LaunchEvenOddForm_Click(object sender, EventArgs e)
        {
            EvenOddForm evenOddForm = new EvenOddForm();
            evenOddForm.ShowDialog(this);
        }
    }
}
