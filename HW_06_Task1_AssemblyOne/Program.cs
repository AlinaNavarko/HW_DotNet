using System;

namespace HW_06_Task1_AssemblyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle motorcycle = new Motorcycle();

            Console.WriteLine(motorcycle.odometerPublic); // ок, так как общедоступный

            // Console.WriteLine(motorcycle.odometerProtected); доступен внутри проектируемого типа и у класcа наследника внутри

            Console.WriteLine(motorcycle.odometerInternal); // ок, так как доступен для той же сборки

            Console.WriteLine(motorcycle.odometerProtectedInternal); // ок, так как доступен для той же сборки (И производных классов)

            // Console.WriteLine(motorcycle.odometerPrivate); доступен только внутри типа

            // Console.WriteLine(motorcycle.odometerPrivateProtected); в текущем классе или производных в той же сборке
        }
    }
}
