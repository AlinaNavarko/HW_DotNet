using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_08_Task1
{
    class Engineer
    {
        float _baseSalary = 500;

        List<string> _responsibilities = new List<string>(5) { "English"};
        
        public Guid Id { get; private set; }
        public string Company { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ExperienceYears { get; set; }
        public string Technologies { get; set; }
        public string GitHub { get; set; }
        public float BaseSalary { get { return _baseSalary; } }
        public  virtual float Salary { get; }

        public virtual List<string> Responsibilities { get { return _responsibilities; } set { _responsibilities = value; } }

        public Engineer(string firstName, string lastName, int experienceYears, string gitHub)
        {
            Id = new Guid();
            Company = "SaM Solutions";
            FirstName = firstName;
            LastName = lastName;
            ExperienceYears = experienceYears;
            GitHub = gitHub;
        }

        public virtual void GetSalary()
        {
            Console.WriteLine($"The Salary of the {this.GetType()} is {Salary}");
        }
        public virtual void GetInfo()
        {
            Console.WriteLine($"Company:{Company}, Full Name: {FirstName} {LastName}, Title: {this.GetType()}, Experience: {ExperienceYears}, Salary: {Salary}");
        }
        public virtual void ShowResponsibilities()
        {
            for (int i = 0; i < Responsibilities.Count; i++)
            {
                Console.WriteLine(Responsibilities[i]);
            }
        }
    }
}
