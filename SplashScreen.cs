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
    public partial class SplashScreen : Form
    {
        private Timer _timer;
        public SplashScreen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Display the Splash Screen for 3 Seconds. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashScreen_Shown(object sender, EventArgs e)
        {
            _timer = new Timer();
            _timer.Interval = 3000;
            _timer.Start();
            _timer.Tick += Timer_Tick;
        }

        /// <summary>
        /// Timer event handler. Once the timer reaches 3 seconds
        /// hide the splash screen and display the BMI Calcualtor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer_Tick(object sender, EventArgs e)
        {
            _timer.Stop();
            //display BMI Form
            Program.BMIcalculator.Show();
            this.Hide();
        }
    }
}
