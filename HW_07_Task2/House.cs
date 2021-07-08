using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_07_Task2
{
    class House
    {
        float _area;
        Door _door;

        public float Area
        {
            get { return _area; }
            set
            {
                _area = value;
            }        
        }

        public House()
        {
        }

        public House(int area, string color)
        {
            _area = area;
            SetDoor(new Door());
            GetDoor().Color = color;
        }

        public void ShowData()
        {
            Console.WriteLine($"I am a house, my area is {Area} m2");
        }
        
        public Door GetDoor()
        {
            return _door;
        }

        public void SetDoor(Door door)
        {
            _door = door;
        }
    }
}
