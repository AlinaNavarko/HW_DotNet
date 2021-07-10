using System;

namespace HW_07_Task4_Booking.Com.Models
{
    class Search
    {
        string _destination;
        DateTime _checkIn;
        DateTime _checkOut;
        int _amountAdults;
        int _amountChildren;
        int _amountRooms;
        bool _forWork;

        bool isValidDestination = false;
        public string Destination
        {
            get { return _destination; }
            set
            {
                while (!isValidDestination)
                {
                    if (value.Length > 0)
                    {
                        isValidDestination = true;
                        _destination = value;
                    }
                    else
                    {
                        Console.Write("The Destination can't be empty.Try Once Again:");
                        value = Console.ReadLine();
                    }
                }
            }
        }

        bool isCheckInValid = false;
        public DateTime CheckIn
        {
            get { return _checkIn; }
            set
            {
                while (!isCheckInValid)
                {
                    if (value >= DateTime.Today)
                    {
                        isCheckInValid = true;
                        _checkIn = value;
                    }
                    else
                    {
                        Console.Write("The Check In date can't be less than Today's date:");
                        value = DateTime.Parse(Console.ReadLine());
                    }
                }
            }
        }
        bool isCheckOutValid = false;
        public DateTime CheckOut
        {
            get { return _checkOut; }
            set
            {
                while (!isCheckOutValid)
                {
                    if (value >= DateTime.Today)
                    {
                        isCheckOutValid = true;
                        _checkOut = value;
                    }
                    else
                    {
                        Console.Write("The Check Out date can't be less than Today's date:");
                        value = DateTime.Parse(Console.ReadLine());
                    }
                }
            }
        }
        public int AmountAdults
        {
            get { return _amountAdults; }
            set { AmountAdults = value; }
        }
        public int AmountChildren
        {
            get { return _amountChildren; }
            set { AmountChildren = value; }
        }
        public int AmountRooms
        {
            get { return _amountRooms; }
            set { AmountRooms = value; }
        }
        public bool ForWork
        {
            get { return _forWork; }
            set { ForWork = value; }
        }
        public void ResetSearchFilter()
        {
            Destination = default;
            CheckIn = default;
            CheckOut = default;
            ForWork = default;
            AmountAdults = 1;
            AmountChildren = default;
            AmountRooms = 1;
        }
        public void ReturnResults()
        {
        }
        public Search(string destination, DateTime checkIn, DateTime checkOut, int amountAdults, int amountChildren, int amountRooms)
        {
            _destination = destination;
            _checkIn = checkIn;
            _checkOut = checkOut;
            _amountAdults = amountAdults;
            _amountChildren = amountChildren;
            _amountRooms = amountRooms;
        }
    }
}
