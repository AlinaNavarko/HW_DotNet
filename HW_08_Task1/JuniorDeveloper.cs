using System;
using System.Collections.Generic;

namespace HW_08_Task1
{
    class JuniorDeveloper : Engineer
    {
        int _rate = 1;
        float _bonus = 0;
        List<string> _respJunior = new List<string>(4) { "JunTask2", "JunTask3", "JunTask4", "JunTask5" };

        public int Rate { get { return _rate; } }
        public float Bonus { get { return _bonus; } }
        public override float Salary
        {
            get { return BaseSalary * Rate + Bonus; }
        }
        public List<string> RespJunior { get { return _respJunior; } }

        public JuniorDeveloper(string firstName, string lastName, int experienceYears, string gitHub) : base(firstName, lastName, experienceYears, gitHub)
        {
        }

        public override void ShowResponsibilities()
        {
            base.ShowResponsibilities();
            for (int i = 0; i < RespJunior.Count; i++)
            {
                Console.WriteLine(RespJunior[i]);
            }
        }
    }
}
