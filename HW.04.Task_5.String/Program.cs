using System;
using System.Linq;

namespace HW._04.Task_5.String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a line of symbols. Separate words by one space:");
            string str = Console.ReadLine();
            MethodPart1(str);
            MethodPart2(str);
            MethodPart3(str);
        }
        private static void MethodPart1(string str)
        {
            string[] strArray = str.Split(' ');

            int positionMax = 0;
            for (int i = 0; i < strArray.Length; i++)
            {
                if (strArray[i].Length > strArray[positionMax].Length)
                    positionMax = i;
            }

            Console.WriteLine("SUBTASK_1: An array splitted by rows without an element of max length"); // if there several elements of max Length - program will exclude the first of them)
            for (int i = 0; i < strArray.Length; i++)
            {
                if (i == positionMax) continue;
                Console.WriteLine(strArray[i]);
            }
        }

        private static void MethodPart2(string str)
        {
            string[] strArray2 = str.Split(' ');

            int positionMax2 = 0;
            int positionMin2 = 0;

            for (int i = 0; i < strArray2.Length; i++)
            {
                if (strArray2[i].Length > strArray2[positionMax2].Length)
                    positionMax2 = i;

                if (strArray2[i].Length < strArray2[positionMin2].Length)
                    positionMin2 = i;
            }

            Console.WriteLine("SUBTASK_2: An array splitted by rows where the element of the greatest length is switched with element of the lowest length"); // if there several elements of max/min Length - program will use the first of them)

            for (int i = 0; i < strArray2.Length; i++)
            {
                if (i == positionMin2)
                    Console.WriteLine(strArray2[positionMax2]); //все равно что-то не то, выводится лишний символ
                if (i == positionMax2)
                    Console.WriteLine(strArray2[positionMin2]);
                else
                    Console.WriteLine(strArray2[i]);
            }
        }

        private static void MethodPart3(string str)
         {
            Console.WriteLine("SUBTASK_3:");
            
            int amountPunct = str.Count(char.IsPunctuation);
            Console.WriteLine($"The amount of punctuation marks is: {amountPunct}");

             char[] numbers = "0123456789".ToCharArray();
             int amountNumbers = 0;
             foreach (char strChar in str)
             {
                 foreach (char numberChar in numbers)
                 {
                     if (strChar.Equals(numberChar))
                     {
                         amountNumbers++;
                         break;
                     }
                 }
             }

            string str3 = str.Replace(" ", string.Empty);
            int amountLetters = str3.Length - amountNumbers - amountPunct;
            Console.WriteLine($"The amount of letters is: {amountLetters}");
         }

        private static void MethodPart4(string str)
       /* {
            Console.WriteLine("SUBTASK_4:");

        }*/
    }
    }
}
