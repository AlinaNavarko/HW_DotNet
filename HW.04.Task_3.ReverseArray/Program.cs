using System;
using System.Diagnostics;

namespace HW._04.Task_3.ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = 100_000_000;

            Console.WriteLine("Please wait several seconds...");
            long[] arrayRandom = new long[arraySize];
            Random rand1 = new Random();
            for (int i = 0; i < arrayRandom.Length; i++)
                arrayRandom[i] = rand1.Next();
            
            long[] arrayReverse1 = new long[arraySize];
            int k = arrayRandom.Length - 1;

            // Option1
            Stopwatch sw1 = new Stopwatch();
            sw1.Start();
            for (int i = 0; i < arrayReverse1.Length; i++)
            {
                arrayReverse1[i] = arrayRandom[k];
                k--;
            }
            sw1.Stop();
            Console.WriteLine($"Option1. Completed for {sw1.ElapsedMilliseconds}ms");

            // Option2
            Stopwatch sw2 = new Stopwatch();
            sw2.Start();
            Array.Reverse(arrayRandom);
            sw2.Stop();
            Console.WriteLine($"Option2: Completed for {sw2.ElapsedMilliseconds}ms");
        }
    }
}
