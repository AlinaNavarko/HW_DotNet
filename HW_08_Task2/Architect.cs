using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_08_Task2
{
    class Architect: Engineer
    {
        int _rate = 12;
        float _bonus = 1000;
        List<string> _personalResponsibilities = new List<string>(4) { "ArchTask2", "ArchTask3", "ArchTask4", "ArchTask5" };

        public override int Rate { get { return _rate; } }
        public override float Bonus { get { return _bonus; } }
        public override float Salary { get { return BaseSalary * Rate + Bonus; } }
        public override List<string> PersonalResponsibilities { get { return _personalResponsibilities; } }

        public override void GetSalary()
        {
            Console.WriteLine($"Salary of Architect is {Salary}");
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Company:{Company}, Full Name: {FirstName} {LastName}, Title: {this.GetType()}, Experience: {ExperienceYears}, Salary: {Salary}");
        }

        public Architect(string firstName, string lastName, int experienceYears, string gitHub)
        {
            Id = new Guid();
            Company = "SaM Solutions";
            FirstName = firstName;
            LastName = lastName;
            ExperienceYears = experienceYears;
            GitHub = gitHub;
        }
        public override void ShowResponsibilities()
        {
            for (int i = 0; i < Responsibilities.Count; i++)
            {
                Console.WriteLine(Responsibilities[i]);
            }
            for (int i = 0; i < PersonalResponsibilities.Count; i++)
            {
                Console.WriteLine(PersonalResponsibilities[i]);
            }
        }
    }
}
