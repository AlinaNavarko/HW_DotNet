﻿namespace HW_11_Task_2
{
    class Motorcycle
    {
        //private static int count = 1;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }

        public int Year { get; set; }

        public int Odometer { get; set; }

        public Motorcycle(int id, string name, string model, int year, int odometer)
        {
            Id = id;
            Name = name;
            Model = model;
            Year = year;
            Odometer = odometer;
        }
    }
}
