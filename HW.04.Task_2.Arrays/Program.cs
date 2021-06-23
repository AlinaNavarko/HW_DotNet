using System;

namespace HW._04.Task_2.Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = 5;
            int addValue;
            int addPosition;

            Console.WriteLine($"There is an Array of {arraySize} elements. Please fill out integer values for all elements except for one");

            int[] arrayKeypad = new int[arraySize];
            for (int i = 0; i < arrayKeypad.Length - 1; i++)
            {
               bool isConvertable1 = Int32.TryParse(Console.ReadLine(), out arrayKeypad[i]);
                if (isConvertable1 == false)
                    Console.WriteLine($"This value will be replaced by the default value ('0')");
            }

            Console.WriteLine("Enter the value for additional element:");
            bool isConvertable2 = Int32.TryParse(Console.ReadLine(), out addValue);
            if (isConvertable2 == false)
                Console.WriteLine($"This value will be replaced by the default value ('0')");

            Console.WriteLine($"Enter the position from 1 to {arraySize} for additional element:");
            while (!int.TryParse(Console.ReadLine(), out addPosition) || (addPosition > arrayKeypad.Length) || (addPosition < 1))
                {
                Console.WriteLine($"Enter the position from 1 to {arraySize} for additional element:");
                }

            Console.WriteLine("The updated array looks like:");

            int[] arrayNew = new int[arraySize];
            for (int i = 0; i < arrayKeypad.Length; i++)
            {
                if (i < addPosition - 1)
                    arrayNew[i] = arrayKeypad[i];
                else if (i==addPosition - 1)
                    arrayNew[i] = addValue;
                else 
                    arrayNew[i] = arrayKeypad[i-1];

                Console.WriteLine(arrayNew[i]);
            }          
        }
    }
}
