using System;
using System.Collections.Generic;
using BooleanAlgebra;


namespace WinForms_AAC_LogicCalculator 
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CalculatorForm());
        }
    }
}
