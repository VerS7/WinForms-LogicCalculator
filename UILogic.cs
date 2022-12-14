using BooleanAlgebra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_AAC_LogicCalculator
{
    internal class UILogic
    {
        public static char[] variables = new char[] { 'A', 'B' };
        public static int[] values = new int[] { 0, 1 };

        public static string getReplacedFormula(string formula)
        {
            formula = formula.Replace('0', 'A');
            formula = formula.Replace('1', 'B');
            return formula;
        }
    }
}
