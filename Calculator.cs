using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal static class Calculator
    {

        
        private static double result;

        public static double calculate(double x, double y, char operation)
        {

            switch (operation)
            {
                case '+':
                    result = x + y;  
                    break;
                case '-':
                    result = x - y;
                    break;
                case '*':
                    result = x * y;
                    break;
                case '/':
                    result = x / y;
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }

            return result;
        }




    }



}
