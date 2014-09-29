using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class calculatorForm : Form
    {
        public calculatorForm()
        {
            InitializeComponent();
        }

        private  double firstNumber = 0.0;
        private  double secondNumber = 0.0;

        private void addButton_Click(object sender, EventArgs e)
        {

            calc();

            resultLabel.Text = Convert.ToString(firstNumber + secondNumber);

        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            calc();

            resultLabel.Text = Convert.ToString(firstNumber - secondNumber);
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            calc();

            resultLabel.Text = Convert.ToString(firstNumber * secondNumber);
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            calc();

            resultLabel.Text = Convert.ToString(firstNumber / secondNumber);
        }

         void calc()
         {

             firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
             secondNumber = Convert.ToDouble(secondNumberTextBox.Text);

         }

        
    }
}
