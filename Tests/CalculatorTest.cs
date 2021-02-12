using NUnit.Framework;
using Calculator.cs;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Calculator calculator;
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
        public void AddTwoPositiveNumbers(int num1, int num2, int expected)
        {
            calculator = new Calculator();
            int result = calculator.Add(num1, num2);
            Assert.AreEqual(expected, result);
        }


        [Test]
        [TestCase(-15, -35, -50)]
        [TestCase(-10, -45, -55)]
        [TestCase(-20, -50, -60)]  // will fail
        public void AddTwoNegativeNumbers()
        {
            calculator = new Calculator();
            int result = calculator.Add(num1, num2);
            Assert.AreEqual(expected, result);
        }


        [Test]
        [TestCase(15, 35, 20, 70)]
        [TestCase(10, 45, 8, 63)]
        [TestCase(20, 50, 11, 60)]  // will fail
        public void AddThreePositiveNumbers()
        {
            calculator = new Calculator();
            int result = calculator.Add(num1, num2, num3);
            Assert.AreEqual(expected, result);
        }


        [Test]
        [TestCase(-15, -35, -20, -70)]
        [TestCase(-10, -45, -8, -63)]
        [TestCase(-20, -50, -11 -60)]  // will fail
        public void AddThreeNegativeNumbers()
        {
            calculator = new Calculator();
            int result = calculator.Add(num1, num2, num3);
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
        public void DivideTwoPositiveNumbers()
        {
            calculator = new Calculator();
            int result = calculator.Divide(num1, num2);
            Assert.AreEqual(expected, result);
        }


        [Test]
        [TestCase(-30, -15, 2)]
        [TestCase(-110, -2, 55)]
        [TestCase(-20, -50, 60)]  // will fail
        public void DivideTwoNegativeNumbers()
        {
            calculator = new Calculator();
            int result = calculator.Divide(num1, num2);
            Assert.AreEqual(expected, result);
        }


        [Test]
        [TestCase(30, 15, 0, 0)] //not sure
        [TestCase(-110, 55, 0, 0)] //not sure
        [TestCase(-20, 60, 0, 5)]  // will fail
        public void DivideTwoNumbersWithZero()
        {
            calculator = new Calculator();
            int result = calculator.Divide(num1, num2, num3);
            Assert.AreEqual(expected, result);
        }


        [Test]
        [TestCase(30, 15, 2, 0, 0)] //not sure
        [TestCase(-110, 55, 0, 0)] //not sure
        [TestCase(-20, 60, 0, 5)]  // will fail
        public void DivideThreeNumbersWithZero()
        {
            calculator = new Calculator();
            int result = calculator.Divide(num1, num2, num3);
            Assert.AreEqual(expected, result);
        }


        [Test]
        [TestCase(5, 120)]
        public void FactorialOfFive()
        {
            calculator = new Calculator();
            int result = calculator.FactorialOfFive(num1);
            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase(200, 120)]
        public void FactorialOf200()
        {
            calculator = new Calculator();
            int result = calculator.FactorialOf200(num1);
            Assert.AreEqual(expected, result);
        }


        [Test]
        [TestCase(0, 0)]
        public void FactorialOfZero()
        {
            calculator = new Calculator();
            int result = calculator.FactorialOfZero(num1);
            Assert.AreEqual(expected, result);
        }


        [Test]
        [TestCase(-5, -120)]
        public void FactorialOfNegativeNumber()
        {
            calculator = new Calculator();
            int result = calculator.FactorialOfNegativeNumber(num1);
            Assert.AreEqual(expected, result);
        }
    }

}
