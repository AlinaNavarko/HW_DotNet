using System;
using System.Linq;
using System.Text;

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
            MethodPart4(str);
        }

        private static void MethodPart1(string str)
        {
            StringBuilder sb = new StringBuilder();
            string[] strArray = str.Split(' ');
            int positionMax = 0;
            
            for (int i = 0; i < strArray.Length; i++)
            {
                if (strArray[i].Length > strArray[positionMax].Length)
                    positionMax = i;
            }

            for (int i = 0; i < strArray.Length; i++)
            {
                if (i == positionMax) continue;
                sb.Append(strArray[i]);
                sb.Append(" ");
            }
            sb.Remove(sb.Length - 1, 1);
            Console.WriteLine("SUBTASK_1: updated string without Max element:"); // if there several elements of max Length - program will exclude the first of them)
            Console.WriteLine(sb);
        }

        private static void MethodPart2(string str)
        {
            StringBuilder sb = new StringBuilder();
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

            string tempMin = strArray2[positionMin2];
            string tempMax = strArray2[positionMax2];

            for (int i = 0; i < strArray2.Length; i++)
            {
                if (i == positionMin2)
                    sb.Append(tempMax);
                else if (i == positionMax2)
                    sb.Append(tempMin);
                else
                    sb.Append(strArray2[i]);
                sb.Append(" ");
            }

            Console.WriteLine("SUBTASK_2: updated string where the elements of the lowest and greatest length are switched:"); // if there several elements of max/min Length - program will use the first of them)
            sb.Remove(sb.Length - 1, 1);
            Console.WriteLine(sb);
        }

        private static void MethodPart3(string str)
        {
            Console.WriteLine("SUBTASK_3:");
            string str3 = str.Replace(" ", string.Empty);
            int amountPunct = str.Count(char.IsPunctuation);
            int amountLetters = str.Count(char.IsLetter);
            Console.WriteLine($"The amount of punctuation marks is: {amountPunct}");
            Console.WriteLine($"The amount of letters is: {amountLetters}");
        }

        private static void MethodPart4(string str)
        {
            Console.WriteLine("SUBTASK_4:");
            Array.ForEach(str.Split(' ').OrderByDescending(x => x.Length).ToArray(), x => Console.Write(x + " "));
        }
    }
}
