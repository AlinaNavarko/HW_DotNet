using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_07_Task2
{
    class Person
    {
        string _name;
        public string Name 
        { 
            get { return _name; } 
            set { _name = value; } 
        }
        public House PersonHouse { get; set; }

        public Person(string name)
        {
            Name = name;
        }
        public void ShowData()
        {
            Console.WriteLine($"Hi, My Name is {Name}");
            PersonHouse.ShowData();
            PersonHouse.GetDoor().ShowData();
        }
    }
}
