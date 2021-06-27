using System;
using System.Text;

namespace HW_05.Task2.sb
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "1a!2.3!!.. 4.!.?6 7! ..?";
            char[] arrayChar = str.ToCharArray();
            int secondPartPosiotion = 0;
            StringBuilder sb = new StringBuilder("");

            for (int i = 0; i < arrayChar.Length; i++)
            {
                if (arrayChar[i].Equals('!') || arrayChar[i].Equals('.'))
                {   arrayChar[i] = ' ';
                    sb.Append(arrayChar[i]);
                 }
                else if (arrayChar[i].Equals('?'))
                {
                    sb.Append(arrayChar[i]);
                    secondPartPosiotion = i + 1;
                    break;
                }
                 else 
                    sb.Append(arrayChar[i]);
            }

            for (int i = secondPartPosiotion; i < arrayChar.Length; i++)
            {
                if (arrayChar[i].Equals(' '))
                {
                    arrayChar[i] = '_';
                    sb.Append(arrayChar[i]);
                }
                else                
                    sb.Append(arrayChar[i]);
            }
            Console.WriteLine($"initial string: {str}");
            Console.WriteLine($"updated string: {sb}");
        }
    }
}
