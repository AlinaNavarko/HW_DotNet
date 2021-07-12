using System;

namespace HW_07_Task1
{
    class Student : Person
    {
        public void GoToClasses()
        {
            Console.WriteLine("I'm going to class.");                   
        }

        public void ShowAge()
        {
            Console.WriteLine($"My age is: {Age}");
        }

        public override void SayHello()
        {
            base.SayHello();
        }
    }
}

