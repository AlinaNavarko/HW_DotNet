using System;

namespace HW03.Operators_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            int sumN1N2;

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
            int sum_of_N1_N2 = number1 + number2;

            Console.WriteLine($"What {number1} + {number2} is?:");
            while (!int.TryParse(Console.ReadLine(), out sumN1N2))
            {
                Console.WriteLine("Error: entered symbol(s) is not Integer Number. Please Try once again. ");
                Console.WriteLine($"Enter Integer value for the sum of {number1} and {number2}");
            }

            if (sumN1N2 == sum_of_N1_N2)
                Console.WriteLine("Correct!");
            
            else if (sum_of_N1_N2 > sumN1N2)
                Console.WriteLine("Incorrect! The correct sum should be greater");
            
            else
                 Console.WriteLine("Incorrect! The correct sum should be less");
        }
    }
}