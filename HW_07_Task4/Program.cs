using HW_07_Task4_Booking.Com.Models;
using System;

namespace HW_07_Task4
{
    class Program
    {
        static void Main(string[] args)
        {        
            Login newUser = new Login("Alina", "Navarko", "alinawtbwd@gmail.com", "Alina123");
            Search search = new Search("Barcelona", 1/8/2021 12:00:00 AM, 3/8/2021 12:00:00 AM, 2, 0, 1);
            Book book = new Book("Barcelona Princess", "Double", 1/8/2021 12:00:00 AM, 3/8/2021 12:00:00 AM, 500);
            Purchase purchase = new Purchase(7c9e6679-7425-40de-944b-e07fc1f90ae7, "alinawtbwd@gmail.com", true);
        }
    }
}
