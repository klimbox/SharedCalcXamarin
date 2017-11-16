using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedCalc
{
    public interface ICalculation
    {
        int Calculate(string num1, string num2, string op);
    }
}
