using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator : ICalculator
    {
        public double sum;
        public double difference;
        public double product;
        public double quotient;

        public double Addition(double val1, double val2)
        {
            sum = val1 + val2;
            return sum;
        }

        public double Subtraction(double val1, double val2)
        {
            difference = val1 - val2;
            return difference;
        }

        public double Multiplication(double val1, double val2)
        {
            product = val1 * val2;
            return product;
        }

        public double Division(double val1, double val2)
        {
            quotient = val1 / val2;
            return quotient;
        }
    }
}
