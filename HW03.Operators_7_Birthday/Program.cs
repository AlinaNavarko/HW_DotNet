using System;

namespace HW03.Operators_7_Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            int userAge;

            Console.WriteLine("Enter the year of birth");
            int userYear = int.Parse(Console.ReadLine());
            while (userYear < 1)
            {
                Console.WriteLine("The number of Year should be positive integer. Please try once again");
                userYear = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the number of Month of birth");
            int userMonth = int.Parse(Console.ReadLine());
            while (userMonth > 12 || userMonth < 1)
            {
                Console.WriteLine("The number of Month should be from 1 to 12. Please try once again");
                userMonth = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the current year");
            int currentYear = int.Parse(Console.ReadLine());
            while (currentYear < 1)
            {
                Console.WriteLine("The number of Year should be positive integer. Please try once again");
                currentYear = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the current month");
            int currentMonth = int.Parse(Console.ReadLine());
            while (currentMonth > 12 || userMonth < 1)
            {
                Console.WriteLine("The number of Month should be from 1 to 12. Please try once again");
                currentMonth = int.Parse(Console.ReadLine());
            }

            if (userYear > currentYear || ((userYear == currentYear) && (userMonth > currentMonth)))
                Console.WriteLine("Your birthdate can't be greater than current date");

            else
            {
                if (userMonth <= currentMonth)
                    userAge = currentYear - userYear;
                else
                    userAge = currentYear - userYear - 1;
                Console.WriteLine($"Your full years = {userAge}");
            }
        }
    }
}
