using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_08_Task3
{
    class SeniorDeveloper: IEngineer, ISalary
    {
        float _baseSalary = 500;
        int _rate = 5;
        float _bonus = 300;
        int _rank = 3;
        public Guid Id { get; set; }
        public string Company { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ExperienceYears { get; set; }
        public string Technologies { get; set; }
        public string GitHub { get; set; }
        public string Responsibilities { get; }
        public float BaseSalary { get { return _baseSalary; } }
        public int Rate { get { return _rate; } }
        public float Bonus { get { return _bonus; } }
        public float Salary { get { return (BaseSalary * Rate + Bonus); } }
        public int Rank { get { return _rank; } }
        public SeniorDeveloper(string firstName, string lastName, int experienceYears, string gitHub)
        {
            Id = new Guid();
            Company = "SaM Solutions";
            FirstName = firstName;
            LastName = lastName;
            ExperienceYears = experienceYears;
            GitHub = gitHub;
        }

       public void GetSalary()
        {
            Console.WriteLine($"Salary is {Salary}");
        }
        public void GetInfo()
        {
            Console.WriteLine($"Company:{Company}, Full Name: {FirstName} {LastName}, Title: {this.GetType()}, Experience: {ExperienceYears}, Salary: {Salary}");
        }
    }
}
