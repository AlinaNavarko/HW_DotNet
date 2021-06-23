using System;

namespace HW._04.Task_4_Poem.Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a text of a poem in one line. Use ';' to separate rows of the poem");
            string[] arrayPoem = new string[1];
            for (int i = 0; i < arrayPoem.Length ; i++)
            {
                arrayPoem[i] = Console.ReadLine();
                Console.WriteLine(arrayPoem[i]);
            }
                        
            string[] arrayPoem2 = new string[1];
            for (int i = 0; i < arrayPoem.Length; i++)
            {
                arrayPoem[i] = Console.ReadLine();
                Console.WriteLine(arrayPoem[i]);
            }
        }
    }
}