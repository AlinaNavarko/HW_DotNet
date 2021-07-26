using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_08_Task3
{
    interface ISalary
    {
        float BaseSalary { get; }
        int Rate { get; }
        float Bonus { get;  }
        void GetSalary()
        {
            Console.WriteLine($"Salary is {BaseSalary * Rate + Bonus}");
        }
    }
}
