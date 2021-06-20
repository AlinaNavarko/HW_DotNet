using System;

namespace HW._05.Quadratic.Formula
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number value for 'a':");
            string NumberA = Console.ReadLine();

            Console.WriteLine("Enter number value for 'b':");
            string NumberB = Console.ReadLine();

            Console.WriteLine("Enter number value for 'c':");
            string NumberC = Console.ReadLine();

            double A = Double.Parse(NumberA);
            double B = Double.Parse(NumberB);
            double C = Double.Parse(NumberC);

            //calculate discriminant D
            double D = B * B - 4 * A * C;

            Console.WriteLine();

            Console.WriteLine($"Your quadratic equation: ({A})x*x + ({B})x + ({C}) = 0");
            Console.WriteLine("Solution:");
            Console.WriteLine($"D = {D}");


            if (D < 0)

            {
                Console.WriteLine("Quadratic equation has no solutions because D < 0 ");
            }


            else
            {
                double x1 = (-B + Math.Sqrt(D)) / (2 * A);
                double x2 = (-B - Math.Sqrt(D)) / (2 * A);
                Console.WriteLine($"x1 = {x1}");
                Console.WriteLine($"x2 = {x2}");
            }

            Console.ReadLine();
        }
    }
}
