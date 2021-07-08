using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_07_Task1
{
    class Person
    {
        int _age;
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public void SetAge(int n)
        {
            Age = n;
        }

        public void DisplayAge()
        {
            Console.WriteLine($"My age is: {Age}");
        }
        public virtual void SayHello()
        {
            Console.WriteLine($"Hello from {this.GetType()}");
        }
    }
}
