using System;

namespace HW_07_Task1
{
    class ProStudentAndTeacherTest
    {
        private static int _studentAge = 21;
        private static int _teacherAge = 30;

        public static void Main(string[] args)
        {
            Person person = new Person();
            person.SayHello();

            Person student = new Student();
            student.SetAge(_studentAge);
            student.SayHello();
            student.DisplayAge();

            Person teacher = new Teacher();
            teacher.SetAge(_teacherAge);
            teacher.SayHello();
            teacher.DisplayAge();
            ((Teacher)teacher).Explain();

            Console.ReadKey();
        }
    }
}
