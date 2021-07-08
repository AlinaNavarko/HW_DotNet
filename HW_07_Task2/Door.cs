using System;

namespace HW_07_Task2
{
    class Door
    {
        string _color = "white";
        public string Color
        {
            get { return _color; }
            set
            {
                _color = value;
            }
        }
        public void ShowData()
        {
            Console.WriteLine($"I am a door, my color is {Color}");
        }
    }
}
