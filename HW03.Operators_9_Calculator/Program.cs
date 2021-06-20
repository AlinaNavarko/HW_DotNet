using System;

namespace HW03.Operators_9_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calcul = new Calculator();

            calcul.Plus();
            calcul.Minus();
            calcul.Multiple();
            calcul.Divide();
            calcul.RemainderOfDivision();
            calcul.AreaOfCircle();
        }

        class Calculator
        {
          public double Plus()
            {
                Console.WriteLine("SUM");
                Console.WriteLine("Enter Number1:");
                double Number1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Number2:");
                double Number2 = Convert.ToDouble(Console.ReadLine());
                double SumN1N2 = Number1 + Number2;
                Console.WriteLine($"Sum of {Number1} and {Number2} is {SumN1N2}");
                return SumN1N2;
            }

          public double Minus()
            {
                Console.WriteLine("DIFFERENCE"); 
                Console.WriteLine("Enter Number1:");
                double Number1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Number2:");
                double Number2 = Convert.ToDouble(Console.ReadLine());
                double DifN1N2 = Number1 - Number2;
                Console.WriteLine($"Difference between {Number1} and {Number2} is {DifN1N2}");
                return DifN1N2;
            }

          public double Multiple()
            {
                Console.WriteLine("MULTIPLICATION");
                Console.WriteLine("Enter Number1:");
                double Number1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Number2:");
                double Number2 = Convert.ToDouble(Console.ReadLine());
                double MultN1N2 = Number1 * Number2;
                Console.WriteLine($"The product of {Number1} and {Number2} is {MultN1N2}");
                return MultN1N2;
            }

           public double Divide()
            {
                Console.WriteLine("DIVISION");
                Console.WriteLine("Enter Number1:");
                double Number1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Number2:");
                double Number2 = double.Parse(Console.ReadLine());
                double DivN1N2 = (Number1 / Number2);
                Console.WriteLine($"The result of division of {Number1} by {Number2} is {DivN1N2}");
                return DivN1N2;
            }

          public double RemainderOfDivision()
            {
                Console.WriteLine("GET REMAINDER OF DIVISION");
                Console.WriteLine("Enter Number1:");
                double Number1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Number2:");
                double Number2 = double.Parse(Console.ReadLine());
                double RemN1N2 = Number1 % Number2;
                Console.WriteLine($"The remainder of division of {Number1} by {Number2} is {RemN1N2}");
                return RemN1N2;
            }
            
          public double AreaOfCircle()
            {
                Console.WriteLine("AREA of CIRCLE");
                Console.WriteLine("Enter the value of radius:");
                double radius = double.Parse(Console.ReadLine());
                double area = 3.14 * radius * radius;
                Console.WriteLine($"The area of circle with radius {radius} is {area}");
                return area;
            }
        }
}
}
