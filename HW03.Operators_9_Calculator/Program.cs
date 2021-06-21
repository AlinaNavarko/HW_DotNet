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
                double number1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Number2:");
                double number2 = Convert.ToDouble(Console.ReadLine());
                double sumN1N2 = number1 + number2;
                Console.WriteLine($"Sum of {number1} and {number2} is {sumN1N2}");
                return sumN1N2;
            }

          public double Minus()
            {
                Console.WriteLine("DIFFERENCE"); 
                Console.WriteLine("Enter Number1:");
                double number1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Number2:");
                double number2 = Convert.ToDouble(Console.ReadLine());
                double difN1N2 = number1 - number2;
                Console.WriteLine($"Difference between {number1} and {number2} is {difN1N2}");
                return difN1N2;
            }

          public double Multiple()
            {
                Console.WriteLine("MULTIPLICATION");
                Console.WriteLine("Enter Number1:");
                double number1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Number2:");
                double number2 = Convert.ToDouble(Console.ReadLine());
                double multN1N2 = number1 * number2;
                Console.WriteLine($"The product of {number1} and {number2} is {multN1N2}");
                return multN1N2;
            }

           public double Divide()
            {
                Console.WriteLine("DIVISION");
                Console.WriteLine("Enter Number1:");
                double number1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Number2:");
                double number2 = double.Parse(Console.ReadLine());
                double divN1N2 = (number1 / number2);
                Console.WriteLine($"The result of division of {number1} by {number2} is {divN1N2}");
                return divN1N2;
            }

          public double RemainderOfDivision()
            {
                Console.WriteLine("GET REMAINDER OF DIVISION");
                Console.WriteLine("Enter Number1:");
                double number1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Number2:");
                double number2 = double.Parse(Console.ReadLine());
                double remN1N2 = number1 % number2;
                Console.WriteLine($"The remainder of division of {number1} by {number2} is {remN1N2}");
                return remN1N2;
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
