using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Test
{
    [TestFixture]
    public class TestClass
    {
        [Test]
            public void Add01()
            {
                ICalculator add = new Calculator();
                //   [TestFixtureSetUp];
                double value1 = 12;
                double value2 = 15;
                double expectedResult = add.Addition(value1, value2);
                Assert.That(expectedResult, Is.EqualTo(27));
            }

            [Test]
            public void Add02()
            {
                ICalculator add = new Calculator();
                double value1 = 5;
                double value2 = 6;
                double expectedResult = add.Addition(value1, value2);
                Assert.That(expectedResult, Is.EqualTo(11));
            }

            [Test]
            public void Subtract01()
            {
                ICalculator subtract = new Calculator();
                double value1 = 89;
                double value2 = 6;
                double expectedResult = subtract.Subtraction(value1, value2);
                Assert.That(expectedResult, Is.EqualTo(83));
            }

            [Test]
            public void Subtract02()
            {
                ICalculator subtract = new Calculator();
                double value1 = 5;
                double value2 = 14;
                double expectedResult = subtract.Subtraction(value1, value2);
                Assert.That(expectedResult, Is.EqualTo(-9));
            }

            [Test]
            public void Multiply01()
            {
                ICalculator multiply = new Calculator();
                double value1 = 5;
                double value2 = 17;
                double expectedResult = multiply.Multiplication(value1, value2);
                Assert.That(expectedResult, Is.EqualTo(85));
            }

            [Test]
            public void Multiply02()
            {
                ICalculator multiply = new Calculator();
                double value1 = 125;
                double value2 = 415;
                double expectedResult = multiply.Multiplication(value1, value2);
                Assert.That(expectedResult, Is.EqualTo(51875));
            }

            [Test]
            public void Divide01()
            {
                ICalculator divide = new Calculator();
                double value1 = 125;
                double value2 = 5;
                double expectedResult = divide.Division(value1, value2);
                Assert.That(expectedResult, Is.EqualTo(25));
            }

            [Test]
            public void Divide02()
            {
                ICalculator divide = new Calculator();
                double value1 = 5;
                double value2 = 8.7;
                double expectedResult = divide.Division(value1, value2);
                Assert.That(expectedResult, Is.EqualTo(43.5));
            }
        

    }
}
