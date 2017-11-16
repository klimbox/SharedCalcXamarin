using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedCalc
{
    public class LocalCalculation : ICalculation
    {
        private int Operation(int a, int b, char o)
        {
            if (!(o == '+' || o == '-' || o == '/' || o == '*'))
                throw new ArgumentException();

            if (o == '/' & b == 0)
                throw new DivideByZeroException();

            int res = 0;
            switch (o)
            {
                case '+':
                    res = a + b;
                    break;
                case '-':
                    res = a - b;
                    break;
                case '*':
                    res = a * b;
                    break;
                case '/':
                    if (b != 0) res = a / b;
                    break;
            }
            return res;
        }

        public int Calculate(string num1, string num2, string op)
        {

            int a, b;
            char o;
            int res = 0;

            try
            {
                a = Convert.ToInt32(num1);
                b = Convert.ToInt32(num2);
                o = Convert.ToChar(op);
                res = Operation(a, b, o);
            }
            catch (Exception)
            {
                throw new ArgumentException();
            }

            return res;
        }
    }
}
