using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_08_Task1
{
    class TeamLeader: Engineer
    {
        int _rate = 8;
        float _bonus = 500;
        List<string> _respLead = new List<string>(4) { "LeadTask2", "LeadTask3", "LeadTask4", "LeadTask5" };

        public int Rate { get { return _rate; } }
        public float Bonus { get { return _bonus; } }
        public override float Salary { get { return BaseSalary * Rate + Bonus; } }
        public List<string> RespLead { get { return _respLead; } }

        public override void GetSalary()
        {
            Console.WriteLine($"The Salary of the TeamLeader is {Salary}");
        }
        public TeamLeader(string firstName, string lastName, int experienceYears, string gitHub) : base(firstName, lastName, experienceYears, gitHub)
        {
        }
        public override void ShowResponsibilities()
        {
            base.ShowResponsibilities();
            for (int i = 0; i < RespLead.Count; i++)
            {
                Console.WriteLine(RespLead[i]);
            }
        }
    }
}
