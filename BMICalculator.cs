using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculatorApp
{
    public partial class BMICalculator : Form
    {
        public BMICalculator()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler to limit the MyHeight only receive numeric Values. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyHeightextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Event handler to limit the MyWeight only receive numeric Values.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyWeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Event handler for the Calculate BMI Button. Parse the values
        /// from the Height and Weight and compute the BMI
        /// Also display the BMI Calculation result. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {
            double heigh = 0;
            double weigh = 0;
            double bmi = 0;
            String result = ""; 

            heigh = double.Parse(MyHeightextBox.Text);
            weigh = double.Parse(MyWeightTextBox.Text); 

            // Based on Unit group
            if(ImperialRadioButton.Checked)
            {
                bmi = (weigh * 703) / (heigh * heigh);
            }
            else
            {
                bmi = weigh / (heigh * heigh);
            }

            // Result
            if(bmi < 18.5)
            {
                result = "You are Underweight";
            }
            else if (bmi < 24.9)
            {
                result = "You are Normal";
            }
            else if (bmi < 29.9)
            {
                result = "You are Overweight";
            }
            else
            {
                result = "You are Obese";
            }

            // Display BMI & Result
            BMITextBox.Text = bmi.ToString("F02");
            BMIResultTextBox.Text = result;
        }
    }
}
