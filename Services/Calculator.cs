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
                for(double i =0; i< numbers.Length; i++) {
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
           variable = 2;
           if(numbers.Length = 0)
           {
                Console.WriteLine("Numbers is empty!");
           }
           else
           {
               for(double i =0; i< numbers.Length; i++) {
                   Console.Write(numbers[i] + " ")
                   if (i = 0) {
                        variable = numbers[i]
                   } else if (i = 1 && numbers.Length = 2) {
                        Console.WriteLine("The result of multiplying is: " + variable * numbers[i]);
                   } else {
                        Console.WriteLine("Invalid parameters entered")
                   }
               }
           }
           return variable * numbers[i];
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
