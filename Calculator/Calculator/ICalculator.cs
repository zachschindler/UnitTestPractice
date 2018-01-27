using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public interface ICalculator
    {
        double Addition(double val1, double val2);

        double Subtraction(double val1, double val2);

        double Multiplication(double val1, double val2);

        double Division(double val1, double val2);
    }
}
