using System;

namespace HW_06_Task2_Motorcycle
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = 3;
            Motorcycle[] motoArray = new Motorcycle[arraySize];

            for (int i = 0; i < motoArray.Length; i++)
            {
                motoArray[i] = new Motorcycle();

                Console.WriteLine($"Fill out the info about Motocycle Number {i + 1}:");
                Console.Write("Producer: ");
                motoArray[i].Producer = Console.ReadLine();
                Console.Write("Model: ");
                motoArray[i].Model = Console.ReadLine();
                Console.Write("Odometer: ");
                motoArray[i].Odometer = Int32.Parse(Console.ReadLine());

                motoArray[i].engine = new Motorcycle.Engine();
                
                Console.Write("Engine Volume: ");
                motoArray[i].engine.Volume = Int32.Parse(Console.ReadLine());
                Console.Write("Engine Power: ");
                motoArray[i].engine.Power = Int32.Parse(Console.ReadLine());
                Console.Write("Engine Type: ");
                motoArray[i].engine.Type = Console.ReadLine();
            }

            for (int i = 0; i < motoArray.Length; i++)
            {
                Console.WriteLine($"{i + 1}. Motorcycle (Producer): {motoArray[i].Producer}, Model: {motoArray[i].Model}, Vin Number (ID): {motoArray[i].Id}, Year: {motoArray[i].ModelYear}");
                Console.WriteLine($"  {i + 1}.1.  Engine (Volume): {motoArray[i].engine.Volume}, Power: {motoArray[i].engine.Power}");
            }
        }
    }
}
