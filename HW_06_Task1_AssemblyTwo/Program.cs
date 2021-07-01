using System;
using HW_06_Task1_AssemblyOne; // need to add reference in order to use a public class from other dll

namespace HW_06_Task1_AssemblyTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle motorcycle = new Motorcycle();

            Console.WriteLine(motorcycle.odometerPublic);

            // Console.WriteLine(motorcycle.odometerProtected); недоступен, тк. это не производный класс

            // Console.WriteLine(motorcycle.odometerInternal); это другая сбока, поэтому недоступен

            // Console.WriteLine(motorcycle.odometerProtectedInternal); это другая сборка и не производный класс

            // Console.WriteLine(motorcycle.odometerPrivate); доступен только внутри проектируемого типа

            // Console.WriteLine(motorcycle.odometerPrivateProtected); доступен либо для текущего класса в лю,ой сборке лиюо для производного класса в той же сборке
        }
    }
}
