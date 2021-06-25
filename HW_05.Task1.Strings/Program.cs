using System;
using System.Linq;

namespace HW_05.Task1.Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "gdfgdf234dg54gf*23oP42";

            char[] symbols = "+-*/".ToCharArray();
            char[] numbers = "0123456789".ToCharArray();
            string num1 = "";
            string num2 = "";
            char symbol = ' ';
            int result = 0;

            foreach (char strChar in str)
                foreach (char symbolChar in symbols)
                    if (strChar.Equals(symbolChar))
                        {
                        symbol = symbolChar;
                        break;
                        }

            string[] strArray = str.Split(symbol);
       
            foreach (char strChar in strArray[0])
                foreach (char numberChar in numbers)
                    if (strChar.Equals(numberChar))
                        {
                        num1 += numberChar;
                        break;
                        }

            foreach (char strChar in strArray[1])
                foreach (char numberChar in numbers)
                     if (strChar.Equals(numberChar))
                         {
                         num2 += numberChar;
                         break;
                         }

            int numValue1 = Int32.Parse(num1);
            int numValue2 = Int32.Parse(num2);

            switch (symbol)
            {
                case '+':
                    result = numValue1 + numValue2;
                    break;
                case '-':
                    result = numValue1 - numValue2;
                    break;
                case '*':
                    result = numValue1 * numValue2;
                    break;
                case '/':
                    result = numValue1 / numValue2;
                    break;
            }
            
            Console.WriteLine($"{numValue1}{symbol}{numValue2}={result}");
        }
    }
}
