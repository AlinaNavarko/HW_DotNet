using System;

namespace HW03.Operators_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number1;
            int Number2;
            int SumN1N2;

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
            int Sum_of_N1_N2 = Number1 + Number2;

            Console.WriteLine($"What {Number1} + {Number2} is?:");
            while (!int.TryParse(Console.ReadLine(), out SumN1N2))
            {
                Console.WriteLine("Error: entered symbol(s) is not Integer Number. Please Try once again. ");
                Console.WriteLine($"Enter Integer value for the sum of {Number1} and {Number2}");
            }

            if (SumN1N2 == Sum_of_N1_N2) 
            {
                Console.WriteLine("Correct!");
                                        
            }

            else
            {
                Console.WriteLine($"You are wrong! The correct answer is {Sum_of_N1_N2}");

            }

        }
    }
}
