using System;

namespace HW._03.Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            //explicit conversion

            long longNumber1a = 2_147_483_647;
            int intNumber1a = (int)(longNumber1a);

            double doubleNumber2a = 1.5;
            decimal decimalNumber2a = (decimal)doubleNumber2a;

            int intNumber3a = 255;
            byte byteNumber3a = (byte)intNumber3a;

            double doubleNumber4a = 200;
            int intNumber4a = Convert.ToInt32(doubleNumber4a);

            string stringNumber5a = "50"; //make sure it is a number if we want to use .Parse
            int intNumber5a = Int32.Parse(stringNumber5a);

           //implicit conversion

            byte byteNumber1b = 255;
            ushort ushortNumber1b = byteNumber1b;

            ushort ushortNumber2b = 55000;
            int intNumber2b = ushortNumber2b;

            sbyte sbyteNumber3b = -128;
            short shortNumber3b = sbyteNumber3b;

            int intNumber4b = 2_000_000_000;
            long longNumber4b = intNumber4b;

            uint uintNumber5b = 4_000_000_000;
            long ulongNumber5b = uintNumber5b;

            //boxing

            int intA = 3;
            object A = intA; //boxing

            double doubleB = 0.5;
            object B = doubleB; //boxing

            string stringC = "Hello";
            object C = stringC; //boxing

            byte byteD = 255;
            object D = byteD; //boxing

            ulong ulongE = 9_999_999_999;
            object E = ulongE; //boxing

            //unboxing
            int intA2 = (int)A;
            double doubleB2 = (double)B;
            string stringC2 = (string)C;
            byte byteD2 = (byte)D;
            ulong ulongE2 = (ulong)E;

            Console.WriteLine("Completed!");
        }
    }
}
