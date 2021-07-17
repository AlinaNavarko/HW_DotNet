using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_08_Task1
{
    class SeniorDeveloper: Engineer
    {
        int _rate = 5;
        float _bonus = 300;
        List<string> _respSenior = new List<string>(4) { "SeniorTask2", "SeniorTask3", "SeniorTask4", "SeniorTask5" };

        public int Rate { get { return _rate; } }
        public float Bonus { get { return _bonus; } }
        public override float Salary { get { return BaseSalary * Rate + Bonus; } }
        public List<string> RespSenior{ get { return _respSenior; } }
    
        public override void GetSalary()
        {
            Console.WriteLine($"The Salary of the SeniorDeveloper is {Salary}");
        }
        public SeniorDeveloper(string firstName, string lastName, int experienceYears, string gitHub) : base(firstName, lastName, experienceYears, gitHub)
        {
        }
        public override void ShowResponsibilities()
        {
            base.ShowResponsibilities();
            for (int i = 0; i < RespSenior.Count; i++)
            {
                Console.WriteLine(RespSenior[i]);
            }
        }
    }
}
