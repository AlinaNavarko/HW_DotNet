using System;

namespace HW._04.Task_1.Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = 10;

            Console.WriteLine("The following array is filled out automatically:");

            int[] arrayRandom = new int[arraySize];
            Random rand1 = new Random();

            for (int i = 0; i < arrayRandom.Length; i++)
            {
                arrayRandom[i] = rand1.Next();
                Console.WriteLine(arrayRandom[i]);
            }

            Console.WriteLine("The next array you should fill out manually from keypad:");

            int[] arrayKeypad = new int[arraySize];
            for (int i = 0; i < arrayKeypad.Length; i++)
            {
                arrayKeypad[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The last array is filled out with sums of coresponding elements from first and secod arrays:");
           
            int[] arraySum = new int[arraySize];
            for (int i = 0; i < arraySum.Length; i++)
            {
                arraySum[i] = arrayRandom[i] + arrayKeypad[i];
                Console.WriteLine(arraySum[i]);
            }
        }
    }
}
