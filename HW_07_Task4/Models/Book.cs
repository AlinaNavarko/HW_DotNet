using System;

namespace HW_07_Task4_Booking.Com.Models
{
    class Book
    {
        string _appartmentName;
        string _roomType;
        DateTime _checkIn;
        DateTime _checkOut;
        int _amountRooms;
        float _price;
        Guid _id;

        public Guid Id
        {
            get { return _id; }
            set { Id = value; }
        }
        public string AppartmentName
        {
            get { return _appartmentName; }
            set { _appartmentName = value; }
        }
        public string RoomType
        {
            get { return _roomType; }
            set { _roomType = value; }
        }
        public DateTime CheckIn
        {
            get { return _checkIn; }
            set { _checkIn = value; }
        }
        public DateTime CheckOut
        {
            get { return _checkOut; }
            set { _checkOut = value; }
        }
        public float Price
        {
            get { return _price; }
            set { _price = value; }
        }
        bool isValidAmount = false;
        public int AmountRooms
        {
            get { return _amountRooms; }
            set
            {
                while (!isValidAmount)
                {
                    if (_amountRooms > 0)
                    {
                        isValidAmount = true;
                        _amountRooms = value;
                    }
                    else
                    {
                        Console.Write("The amount of rooms can't be '0'");
                        value = Int32.Parse(Console.ReadLine());
                    }
                }
            }
        }
        public Book()
        {
        }
        public Book(string appartmentName, string roomType, DateTime checkIn, DateTime checkOut, float price)
        {
           AppartmentName = appartmentName;
            RoomType = roomType;
            CheckIn = checkIn;
            CheckOut = checkOut;
            Price = price;
            Id = new Guid();
        }
        public void StartBooking()
        {
        }
    }
}