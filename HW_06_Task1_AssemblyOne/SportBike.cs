using System;
namespace HW_06_Task1_AssemblyOne
{ 
    class SportBike : Motorcycle
    {
        public void DisplayInfo()
        {
            Console.WriteLine(odometerPublic); 
            Console.WriteLine(odometerProtected); 
            Console.WriteLine(odometerInternal); 
            Console.WriteLine(odometerProtectedInternal); 
            // Console.WriteLine(odometerPrivate); доступен только в том же классе
            Console.WriteLine(odometerPrivateProtected); 
        }
    }
}