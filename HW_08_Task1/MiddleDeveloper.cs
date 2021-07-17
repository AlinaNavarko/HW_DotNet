using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_08_Task1
{
    class MiddleDeveloper: Engineer
    {
        int _rate = 3;
        float _bonus = 0;
        List<string> _respMiddle = new List<string>(4) { "MiddleTask2", "MiddleTask3", "MiddleTask4", "MiddleTask5" };

        public int Rate { get { return _rate; } }
        public float Bonus { get { return _bonus; } }
        public override float Salary { get { return BaseSalary * Rate + Bonus; } }
        public List<string> RespMiddle { get { return _respMiddle; } }

        public override void GetSalary()
        {
            Console.WriteLine($"The Salary of the MiddleDeveloper is {Salary}");
        }

        public MiddleDeveloper(string firstName, string lastName, int experienceYears, string gitHub) : base(firstName, lastName, experienceYears, gitHub)
        {
        }

        public override void ShowResponsibilities()
        {
            base.ShowResponsibilities();
            for (int i = 0; i < RespMiddle.Count; i++)
            {
                Console.WriteLine(RespMiddle[i]);
            }
        }
    }
}
