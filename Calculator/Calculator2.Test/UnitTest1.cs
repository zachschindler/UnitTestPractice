using System;
using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator2.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add01()
        {
            ICalculator add = new CalculatorClass();
            double value1 = 12;
            double value2 = 15;
            double actual = 27;
            double tolerance = 0.001;

            double expectedResult = add.Addition(value1, value2);
            Assert.AreEqual(expectedResult, actual, tolerance);
        }

        [TestMethod]
        public void Add02()
        {
            ICalculator add = new CalculatorClass();
            double value1 = 5;
            double value2 = 6;
            double actual = 11;
            double tolerance = 0.001;

            double expectedResult = add.Addition(value1, value2);
            Assert.AreEqual(expectedResult, actual, tolerance);
        }

        [TestMethod]
        public void Subtract01()
        {
            ICalculator subtract = new CalculatorClass();
            double value1 = 89;
            double value2 = 6;
            double actual = 83;
            double tolerance = 0.001;

            double expectedResult = subtract.Subtraction(value1, value2);
            Assert.AreEqual(expectedResult, actual, tolerance);
        }

        [TestMethod]
        public void Subtract02()
        {
            ICalculator subtract = new CalculatorClass();
            double value1 = 5;
            double value2 = 14;
            double actual = -9;
            double tolerance = 0.001;

            double expectedResult = subtract.Subtraction(value1, value2);
            Assert.AreEqual(expectedResult, actual, tolerance);
        }

        [TestMethod]
        public void Multiply01()
        {
            ICalculator multiply = new CalculatorClass();
            double value1 = 5;
            double value2 = 17;
            double actual = 85;
            double tolerance = 0.001;

            double expectedResult = multiply.Multiplication(value1, value2);
            Assert.AreEqual(expectedResult, actual, tolerance);
        }

        [TestMethod]
        public void Multiply02()
        {
            ICalculator multiply = new CalculatorClass();
            double value1 = 125;
            double value2 = 415;
            double actual = 51875;
            double tolerance = 0.001;

            double expectedResult = multiply.Multiplication(value1, value2);
            Assert.AreEqual(expectedResult, actual, tolerance);
        }

        [TestMethod]
        public void Divide01()
        {
            ICalculator divide = new CalculatorClass();
            double value1 = 125;
            double value2 = 5;
            double actual = 25;
            double tolerance = 0.001;

            double expectedResult = divide.Division(value1, value2);
            Assert.AreEqual(expectedResult, actual, tolerance);
        }

        [TestMethod]
        public void Divide02()
        {
            ICalculator divide = new CalculatorClass();
            double value1 = 55;
            double value2 = 8.7;
            double actual = 6.322;
            double tolerance = 0.001;

            double expectedResult = divide.Division(value1, value2);
            Assert.AreEqual(expectedResult, actual, tolerance);
        }
    }
}
