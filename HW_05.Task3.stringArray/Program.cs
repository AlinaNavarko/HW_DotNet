using System;
using System.Collections.Generic;

namespace HW_05.Task3.stringArray

{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = { "live", "arp",  "strong" };
            string[] array2 = { "lively", "alive", "harp", "sharp", "armstrong" };
            string str2 = String.Concat<string>(array2);

            var listOfStrings = new List<string>();

            for (int i = 0; i < array1.Length; i++)
              {
                  if (str2.Contains(array1[i]))
                    listOfStrings.Add(array1[i]);
              }

            string[] arrayOfStrings = listOfStrings.ToArray();
            Array.Sort(arrayOfStrings);

            Console.Write("new array is [");
            for (int i = 0; i < arrayOfStrings.Length; i++)
            {
                if (i == arrayOfStrings.Length - 1)
                Console.Write(arrayOfStrings[i]);
                else
                Console.Write(arrayOfStrings[i] + ",");
            }
            Console.Write("]");
        }
    }
}
