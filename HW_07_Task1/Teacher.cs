using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_07_Task1
{
    class Teacher: Person
    {
        string _subject;
        public string Subject { get; } = "Math";
        public void Explain()
        {
            Console.WriteLine($"Explanation of {Subject} begins");
        }
        public override void SayHello()
        {
            Console.WriteLine($"Hello from {this.GetType()}");
        }
    }
}
