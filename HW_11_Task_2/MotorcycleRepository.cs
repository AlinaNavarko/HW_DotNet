using Serilog;
using System.Collections.Generic;

namespace HW_11_Task_2
{
    class MotorcycleRepository : IMotorcycleRepository
    {
        private static List<Motorcycle> _motorcycles = new List<Motorcycle>();

        public Motorcycle GetMotorcycleByID(int Id)
        {
            Log.Information($"Getting motorycle with Id{Id}:");
            Motorcycle moto = _motorcycles.Find(motorcycle => motorcycle.Id == Id);
            if (moto == null)
                Log.Error("Moto with such Id doesn't exist");
            else
                Log.Information($"Motorcycle with Id{Id} is returned.");
            return moto;
        }

        public List<Motorcycle> GetMotorcycles()
        {
            Log.Information("Getting the list of motos:");
            if (_motorcycles == null)
                Log.Error("There are no any motos in the list.");
            else
                Log.Information("The list of motos is returned.");
            return _motorcycles;
        }

        public void CreateMotorcycle(Motorcycle motorcycle)
        {
            Log.Information("Adding a moto to the List..");
            _motorcycles.Add(motorcycle);
            Log.Information($"Moto with Id{motorcycle.Id} was added to list.");
        }

        public void DeleteMotorcycle(Motorcycle motorcycle)
        {
            Log.Information("Deleting the moto..");
            _motorcycles.Remove(motorcycle);
            Log.Information($"The moto was removed from the list.");
        }


        public void UpdateMotorcycle(Motorcycle motorcycle, string newName, string newModel, int newOdometer)
        {
            Log.Information("Updating the moto..");

            motorcycle.Name = newName;
            motorcycle.Model = newModel;
            motorcycle.Odometer = newOdometer;
            Log.Information($"The updates of the moto item have been finished.");
        }
    }
}