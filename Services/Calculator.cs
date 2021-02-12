using System;
using System.Linq;

namespace Services
{
    public class Calculator : ICalculator
    {

        public double Add(params double[] numbers)
        {
            total = 0;
            if(numbers.Length = 0)
            {
                 Console.WriteLine("Numbers is empty!");
            }
            else
            {
                for(double i =0; i< numbers.Length; i++)
                {
                    Console.Write(numbers[i] + " ")
                    total += numbers[i]
                }
            }
            return total;
        }

        public double Subtract(params double[] numbers)
        {
            throw new NotImplementedException();
        }

        public double Multiply(params double[] numbers)
        {
            throw new NotImplementedException();
        }

        public double Divide(params double[] numbers)
        {
            throw new NotImplementedException();
        }

        public double Factorial(double number)
        {
            throw new NotImplementedException();
        }
    }
}
