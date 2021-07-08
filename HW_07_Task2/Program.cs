using System;

namespace HW_07_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Alina");
            House smallApp = new SmallApartment();
            person.PersonHouse = smallApp;
            person.PersonHouse.SetDoor(new Door());
            person.ShowData();
        }
    }
}
