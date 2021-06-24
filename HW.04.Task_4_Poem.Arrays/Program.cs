using System;

namespace HW._04.Task_4_Poem.Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a text of a poem in one line. Use ';' to separate rows of the poem");
            string poem = Console.ReadLine().ToUpper();
            poem = poem.Replace("O", "A");

            string[] poemSpl = poem.Split(';');
          
            Console.WriteLine("A poem splitted by rows:");
            for (int i = 0; i < poemSpl.Length; i++)
             Console.WriteLine(poemSpl[i].Trim());
        }
    }
}