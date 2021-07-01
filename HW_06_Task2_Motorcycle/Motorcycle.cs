using System;

namespace HW_06_Task2_Motorcycle
{
    class Motorcycle // 'Internal' - Тип Motorcycle может использоваться только в той сборке, где он был создан.

    {
        // Private fields:
        readonly Guid _id = Guid.NewGuid(); 
        string _model;
        string _producer;
        int _modelYear;
        int _odometer;
        public Engine engine;

        public class Engine // Вложенный тип ('Private' по умолчанию, сделала Public)
        {
            int _volume;
            int _power;
            string _type;

            public int Volume
            {
                get { return _volume; }
                set
                {
                    if (value < 125)
                    {
                        Console.WriteLine("The volume should not be less than 125.");
                        _volume = 125;
                    }
                    else if (value > 3200)
                    {
                        Console.WriteLine("The volume should not be more than 3200.");
                        _volume = 3200;
                    }
                    else
                        _volume = value;
                }
            }
            public int Power
            {
                get { return _power; }
                set
                {
                    if (value < 50)
                    {
                        Console.WriteLine("The power should not be less than 50");
                        _power = 50;
                    }
                    else if (value > 300)
                    {
                        Console.WriteLine("The power should not be more than 300");
                        _power = 300;
                    }
                    else
                        _power = 300;
                }
            }
            public string Type
            {
                get { return _type; }
                set
                {
                    if (value.Equals("petrol") || value.Equals("electro") || value.Equals("hybrid"))
                        _type = value;
                    else
                        Console.WriteLine("The type should be one of the following: petrol, electro, hybrid. 'Unknown' will be set");
                }
            }
        }

        // Public properties:
        public Guid Id { get { return _id; } }
        public string Model
        {
            get { return _model; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    Console.WriteLine("The Model can't be empty. 'Unknown' will be set. ");
                    _model = "Unknown";
                }
                else _model = value;
            }
        }
        public string Producer
        {
            get { return _producer; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    Console.WriteLine("The Producer can't be empty. 'Unknown' will be set. ");
                    _producer = "Unknown";
                }
                else _producer = value;
            }
        }
        public int ModelYear 
        {
            get { return _modelYear; }
            set
            {
                if (value != DateTime.Today.Year)
                    Console.WriteLine("The modelYear should be equal to the current year");
                else _modelYear = value;
            }
        }
        public int Odometer 
        { 
            get { return _odometer; } 
            set 
            {
                if (value > 100)
                {
                    Console.WriteLine("The odometer can't exceed 100 km. 100 will be set.");
                    _odometer = 100;
                }
                else _odometer = value;
            } 
        }

        private void ResetSettings() // метод, который используется лишь внутри самого типа
        {
            Console.WriteLine("Reset Settings");
        }

        public Motorcycle () // Конструктор
        {
            _modelYear = DateTime.Today.Year;
        }
    }
}
