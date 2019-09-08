using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kalkulator.Logic
{
    public class InterpretExpression
    {
        private string expression;

        //tworzymy konstruktor z parametrem
        public InterpretExpression(string _expression)
        {
            expression = _expression;
        }
        // metoda widoczna dla konsumentów tworzacych obiekt
        public string Result()
        {
            var result = Interpret(expression);

            return result.ToString();
        }

        private int Interpret(string exp)
        {
            int result = 0;
            String pattern = @"^\s*([-+]?)(\d+\.?|\.\d+|\d+\.\d+)(.)(\d+\.?|\.\d+|\d+\.\d+)\s*$";

            foreach(System.Text.RegularExpressions.Match m in
                System.Text.RegularExpressions.Regex.Matches(exp, pattern))
            {
                int value1 = Int16.Parse(m.Groups[2].Value);
                int value2 = Int16.Parse(m.Groups[4].Value);

                string operation = m.Groups[3].Value;

                if (operation == "+")
                {
                    return value1 + value2;
                }
                else if (operation =="-")
                {
                    return value1 - value2;
                }
                else if (operation == "/")
                {
                    return value1 / value2;
                }
                else if (operation == "*")
                {
                    return value1 * value2;
                }
            }
            return 0;
        }
    }
}