using System.Collections.Generic;

namespace HW_11_Task_2
{
    interface IMotorcycleRepository
    {
        Motorcycle GetMotorcycleByID(int Id);
        List<Motorcycle> GetMotorcycles();
        void CreateMotorcycle(Motorcycle motorcycle);
        void UpdateMotorcycle(Motorcycle motorcycle, string newName, string newModel, int newOdometer);
        void DeleteMotorcycle(Motorcycle motorcycle);
    }
}
