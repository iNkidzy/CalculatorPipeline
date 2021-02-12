using System;
using System.Linq;

namespace Services
{
    public class Calculator : ICalculator
    {


        public double Add(params double[] numbers)
        {
            double total = 0;
            if(numbers.Length < 0)
            {
                 Console.WriteLine("Numbers is empty!");
            }
            else
            {
                foreach (double num in numbers)
                {
                    total += num;
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
            double total = 0;

            if (numbers.Length < 0)
            {
                Console.WriteLine("Numbers is empty!");
            }
            else
            {
                //    foreach(int num in numbers)
                //    {
                //        total *= num;
                //    }
                //     return total;
                //}
                //return total;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] == 0)
                    {
                        throw new Exception("Cant be divided by 0");
                    }

                    total = numbers[i] / numbers[i + 1];
                }
            }
            return total;
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
