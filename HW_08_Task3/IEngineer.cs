using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_08_Task3
{
    interface IEngineer
    {
         Guid Id { get; set; }
         string Company { get;  }
         string FirstName { get; set; }
         string LastName { get; set; }
         int ExperienceYears { get; set; }
         string Technologies { get; set; }
         string GitHub { get; set; }
         string Responsibilities { get;  }
        float Salary { get; }
        int Rank { get; }
        void GetInfo()
        {
            Console.WriteLine($"Company:{Company}, Full Name: {FirstName} {LastName}, Experience: {ExperienceYears}, Salary: {Salary}"); 
        }
    }
}
