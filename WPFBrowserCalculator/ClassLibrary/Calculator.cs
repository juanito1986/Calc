using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NCalc;

namespace ClassLibrary
{
    public class Calculator
    {
        public static string EvaluateExpression(string expression)
        {
            string result = string.Empty;

            NCalc.Expression exp = new NCalc.Expression(expression);
            if (!exp.HasErrors())
            {
                result = exp.Evaluate().ToString();
            }
            else
            {
                result = "Syntax Error !";
            }

            return result;
        }
    }
}
