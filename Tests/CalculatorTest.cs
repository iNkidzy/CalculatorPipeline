using NUnit.Framework;
using Services;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            //Calculator calculator = new Calculator();r;
        }

        [Test]
        [TestCase()]
        public void AddNumbersWithNoInput()
        {
            //int result = add.Add();
            //Assert.That(result, Is.EqualTo(throw()));
        }

        [Test]
        [TestCase(15, 35, 50)]
        [TestCase(10, 45, 55)]
        [TestCase(20, 50, 60)]  // will fail
        public void AddTwoPositiveNumbers(double num1, double num2, double expected)
        {
            Calculator calculator = new Calculator();
            double result = calculator.Add(num1, num2);
            Assert.AreEqual(expected, result);
        }


        [Test]
        [TestCase(-15, -35, -50)]
        [TestCase(-10, -45, -55)]
        [TestCase(-20, -50, -60)]  // will fail
        public void AddTwoNegativeNumbers(double num1, double num2, double expected)
        {
            Calculator calculator = new Calculator();
            double result = calculator.Add(num1, num2, expected);
            Assert.AreEqual(expected, result);
        }


        [Test]
        [TestCase(15, 35, 20, 70)]
        [TestCase(10, 45, 8, 63)]
        [TestCase(20, 50, 11, 60)]  // will fail
        public void AddThreePositiveNumbers(double num1, double num2, double num3, double expected)
        {
            Calculator calculator = new Calculator();
            double result = calculator.Add(num1, num2, num3);
            Assert.AreEqual(expected, result);
        }


        [Test]
        [TestCase(-15, -35, -20, -70)]
        [TestCase(-10, -45, -8, -63)]
        [TestCase(-20, -50, -11 - 60)]  // will fail
        public void AddThreeNegativeNumbers(double num1, double num2, double num3, double expected)
        {
            Calculator calculator = new Calculator();
            double result = calculator.Add(num1, num2, num3);
            Assert.AreEqual(expected, result);
        }


        [Test]
        public void SubtractNumbersWithNoInput()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void SubtractTwoPositiveNumbers()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void SubtractTwoNegativeNumbers()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void SubtractThreePositiveNumbers()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void SubtractThreeNegativeNumbers()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void MultiplyNumbersWithNoInput()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void MultiplyTwoPositiveNumbers()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void MultiplyTwoNegativeNumbers()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void MultiplyThreePositiveNumbers()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void MultiplyThreeNegativeNumbers()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void DivideNumbersWithNoInput()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        [TestCase(30, 15, 2)]
        [TestCase(110, 2, 55)]
        [TestCase(20, 50, 60)]  // will fail
        public void DivideTwoPositiveNumbers(double num1, double num2, double expected)
        {
            Calculator calculator = new Calculator();
            double result = calculator.Divide(num1, num2);
            Assert.AreEqual(expected, result);
        }


        [Test]
        [TestCase(-30, -15, 2)]
        [TestCase(-110, -2, 55)]
        [TestCase(-20, -50, 60)]  // will fail
        public void DivideTwoNegativeNumbers(double num1, double num2, double expected)
        {
            Calculator calculator = new Calculator();
            double result = calculator.Divide(num1, num2);
            Assert.AreEqual(expected, result);
        }


        [Test]
        [TestCase(30, 15, 0, 0)] //not sure
        [TestCase(-110, 55, 0, 0)] //not sure
        [TestCase(-20, 60, 0, 5)]  // will fail
        public void DivideTwoNumbersWithZero(double num1, double num2, double num3, double expected)
        {
            Calculator calculator = new Calculator();
            double result = calculator.Divide(num1, num2, num3);
            Assert.AreEqual(expected, result);
        }


        [Test]
        [TestCase(30, 15, 2, 0, 0)] //not sure
        [TestCase(-110, 55, 0, 0)] //not sure
        [TestCase(-20, 60, 0, 5)]  // will fail
        public void DivideThreeNumbersWithZero(double num1, double num2, double num3, double expected)
        {
            Calculator calculator = new Calculator();
            double result = calculator.Divide(num1, num2, num3);
            Assert.AreEqual(expected, result);
        }


        [Test]
        [TestCase(5, 120)]
        public void FactorialOfFive(double num1, double expected)
        {
            Calculator calculator = new Calculator();
            double result = calculator.Factorial(num1);
            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase(200, 120)]
        public void FactorialOf200(double num1, double expected)
        {
            Calculator calculator = new Calculator();
            double result = calculator.Factorial(num1);
            Assert.AreEqual(expected, result);
        }


        [Test]
        [TestCase(0, 0)]
        public void FactorialOfZero(double num1, double expected)
        {
            Calculator calculator = new Calculator();
            double result = calculator.Factorial(num1);
            Assert.AreEqual(expected, result);
        }


        [Test]
        [TestCase(-5, -120)]
        public void FactorialOfNegativeNumber(double num1, double expected)
        {
            Calculator calculator = new Calculator();
            double result = calculator.Factorial(num1);
            Assert.AreEqual(expected, result);
        }
    }

}
