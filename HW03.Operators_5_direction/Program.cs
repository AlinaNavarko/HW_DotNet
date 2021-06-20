using System;

namespace HW03.Operators_6_direction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the symbol of direction (w/s/a/d)");
            string userSymbol = Console.ReadLine();

            switch (userSymbol)
            {
                case "w":
                    Console.WriteLine("Up");
                    break;

                case "s":
                    Console.WriteLine("Down");
                    break;

                case "a":
                    Console.WriteLine("Left");
                    break;

                case "d":
                    Console.WriteLine("Right");
                    break;

                default:
                    Console.WriteLine("The direction will not be changed");
                    break;
            }
        }
    }
}
