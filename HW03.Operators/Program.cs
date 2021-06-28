using System;

namespace HW03.Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateSumOfTwoIntegers();
        }

        private static void CalculateSumOfTwoIntegers()
        {
            int number1;
            int number2;

            Console.WriteLine("Enter Integer Number1:");
            while (!int.TryParse(Console.ReadLine(), out number1))
            {
                Console.WriteLine("Error: entered symbol(s) is not Integer Number. Please Try once again. ");
                Console.WriteLine("Enter Integer Number1:");
            }

            Console.WriteLine("Enter Integer Number2:");
            while (!int.TryParse(Console.ReadLine(), out number2))
            {
                Console.WriteLine("Error: entered symbol(s) is not Integer Number. Please Try once again. ");
                Console.WriteLine("Enter Integer Number2:");
            }

            //calculate sum
            double sum_of_N1_N2 = number1 + number2;

            Console.WriteLine($"Number1 + Number2 = {number1} + {number2} = {sum_of_N1_N2}");
        }
    }
}
