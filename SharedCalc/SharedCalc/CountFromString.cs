using System;

namespace SharedCalc
{
    public class CountFromString
    {
        public static int Operation(int a, int b, char o)
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


        public static int Input(string s)
        {
            string[] str = s.Split(' ');
            if (str.Length > 3)
                throw new ArgumentException();
            int a, b;
            char o;
            int res = 0;

            try
            {
                a = Convert.ToInt32(str[0]);
                b = Convert.ToInt32(str[2]);
                o = Convert.ToChar(str[1]);
                res = Operation(a, b, o);
            }
            catch (Exception)
            {
                throw new ArgumentException();
            }
            return res;
        }

        public static int Input(string sa, string sb, string operation)
        {
            int a, b;
            char o;
            int res = 0;

            try
            {
                a = Convert.ToInt32(sa);
                b = Convert.ToInt32(sb);
                o = Convert.ToChar(operation);
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

