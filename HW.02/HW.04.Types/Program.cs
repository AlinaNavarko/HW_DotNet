using System;

namespace HW._04.Types
{
    class Program
    {
        static void Main(string[] args)
        {
            int A1 = 1;
            Int32 A2 = 2;
            Console.WriteLine("TypeA1: " + A1.GetType());
            Console.WriteLine("TypeA2: " + A2.GetType());

            Console.WriteLine();

            long B1 = 3;
            Int64 B2 = 4;
            Console.WriteLine("TypeB1: " + B1.GetType());
            Console.WriteLine("TypeB2: " + B2.GetType());

            Console.WriteLine();

            ushort C1 = 5;
            UInt16 C2 = 6;
            Console.WriteLine("TypeC1: " + C1.GetType());
            Console.WriteLine("TypeC2: " + C2.GetType());

            Console.WriteLine();

            int firstValue = 7;
            int secondValue = 8;
            object D1 = firstValue;
            Object D2 = secondValue;

            Console.WriteLine("TypeD1: " + D1.GetType());
            Console.WriteLine("TypeD2: " + D2.GetType());

            Console.WriteLine();

            string E1 = "Good morning";
            String E2 = "Good evening";
            Console.WriteLine("TypeE1: " + E1.GetType());
            Console.WriteLine("TypeE2: " + E2.GetType());


            Console.ReadKey();
        }
    }
}
