using System;

namespace HW03.Operators_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number1;
            int Number2;
            int customResult;
            int resultN1N2;

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

            Console.WriteLine("Enter operator '+' or '-':");
            string operatorX = Console.ReadLine();
            while (operatorX != "+" && operatorX != "-")
            {
                Console.WriteLine("You entered incorrect operator! Please enter '+' or '-':");
                operatorX = Console.ReadLine();
            }

            Console.WriteLine($"What {Number1} {operatorX} {Number2} is?:");
            while (!int.TryParse(Console.ReadLine(), out customResult))
            {
                Console.WriteLine("Error: entered symbol(s) is not Integer Number. Please Try once again. ");
                Console.WriteLine("Enter Integer value:");
            }

            if (operatorX == "+")
              resultN1N2 = Number1 + Number2; 
            else
               resultN1N2 = Number1 - Number2;
                      
            if (customResult == resultN1N2)
              Console.WriteLine("Correct!");
            if (resultN1N2 > customResult)
              Console.WriteLine("Incorrect! The correct result should be greater");
            if (resultN1N2 < customResult)
              Console.WriteLine("Incorrect! The correct result should be less");
        }
    }
}