using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_08_Task1
{
    class Architect: Engineer
    {
        int _rate = 12;
        float _bonus = 1000;
        List<string> _respArch = new List<string>(4) { "ArchTask2", "ArchTask3", "ArchTask4", "ArchTask5" };

        public int Rate { get { return _rate; } }
        public float Bonus { get { return _bonus; } }
        public override float Salary { get { return BaseSalary * Rate + Bonus; } }
        public List<string> RespArch { get { return _respArch; } }

        public override void GetSalary()
        {
            Console.WriteLine($"The Salary of the Architect is {Salary}");
        }
        public Architect(string firstName, string lastName, int experienceYears, string gitHub) : base(firstName, lastName, experienceYears, gitHub)
        {
        }
        public override void ShowResponsibilities()
        {
            base.ShowResponsibilities();
            for (int i = 0; i < RespArch.Count; i++)
            {
                Console.WriteLine(RespArch[i]);
            }
        }
    }
}
