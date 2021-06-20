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
            int Number1;
            int Number2;

            Console.WriteLine("Enter Integer Number1:");
            while (!int.TryParse(Console.ReadLine(), out Number1))
            {
                Console.WriteLine("Error: entered symbol(s) is not Integer Number. Please Try once again. ");
                Console.WriteLine("Enter Integer Number1:");
            }

            Console.WriteLine("Enter Integer Number2:");
            while (!int.TryParse(Console.ReadLine(), out Number2))
            {
                Console.WriteLine("Error: entered symbol(s) is not Integer Number. Please Try once again. ");
                Console.WriteLine("Enter Integer Number2:");
            }

            //calculate sum
            double Sum_of_N1_N2 = Number1 + Number2;

            Console.WriteLine($"Number1 + Number2 = {Number1} + {Number2} = {Sum_of_N1_N2}");
        }
    }
}
