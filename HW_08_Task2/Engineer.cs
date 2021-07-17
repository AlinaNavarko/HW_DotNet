using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_08_Task2
{
    abstract class Engineer
    {

        float _baseSalary = 500;
        List<string> _responsibilities = new List<string>(1) { "English" };
        public Guid Id { get; set; }
        public string Company { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ExperienceYears { get; set; }
        public string Technologies { get; set; }
        public string GitHub { get; set; }
        public float BaseSalary { get { return _baseSalary; } }
        public List<string> Responsibilities { get { return _responsibilities; } set { _responsibilities = value; } }
        public abstract List<string> PersonalResponsibilities { get; }

        public abstract int Rate { get; }
        public abstract float Bonus { get; }
        public abstract float Salary { get; }
        // public virtual List<string> Responsibilities { get { return _baseResponsibilities; } set { _baseResponsibilities = value; } }

        public abstract void GetSalary();

        public abstract void GetInfo();
        public abstract void ShowResponsibilities();
    }
}
