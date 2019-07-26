﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculatorApp
{
    public static class Program
    {
        public static BMICalculator BMIcalculator;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BMIcalculator = new BMICalculator();
            Application.Run(new SplashScreen());
        }
    }
}
