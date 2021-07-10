using System;

namespace HW_07_Task4_Booking.Com.Models
{
    class Login
    {
        string _firstName;
        string _lastName;
        string _loginName;
        string _password;
        Guid _id;

        bool isValidFirstName = false;
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                while (!isValidFirstName)
                {
                    if (value.Length > 0)
                    {
                        isValidFirstName = true;
                        _firstName = value;
                    }
                    else
                    {
                        Console.Write("The First Name can't be empty.Try Once Again:");
                        value = Console.ReadLine();
                    }
                }
            }
        }
        bool isValidLastName = false;
        public string LastName
        {
            get { return _lastName; }
            set
            {
                while (!isValidLastName)
                {
                    if (value.Length > 0)
                    {
                        isValidLastName = true;
                        _lastName = value;
                    }
                    else
                    {
                        Console.Write("The First Name can't be empty.Try Once Again:");
                        value = Console.ReadLine();
                    }
                }
            }
        }
        bool isValidLogin = false;
        public string LoginName
        {
            get { return _loginName; }
            set
            {
                while (!isValidLogin)
                {
                    if (value.Length > 5 && value.Contains("@"))
                    {
                        isValidLogin = true;
                        _loginName = value;
                    }

                    else
                    {
                        Console.Write("The Login should be your email.Try Once Again:");
                        value = Console.ReadLine();
                    }
                }
            }
        }
        bool isValid = false;
        public string Password
        {
            get { return _password; }
            set
            {
                while (!isValid)
                {
                    if (value.Length == 8)
                    {
                        isValid = true;
                        _password = value;
                    }
                    else
                    {
                        Console.Write("The length of password should be equal to 8 symbols.Try Once Again:");
                        value = Console.ReadLine();
                    }
                }
            }
        }
        public Guid Id
        {
            get { return _id; }
            set { Id = value; }
        }
        public Login(string firstName, string lastName, string loginName, string password) // Конструктор
        {
            Id = new Guid();
            FirstName = firstName;
            LastName = lastName;
            LoginName = loginName;
            Password = password;
        }
    }
}
