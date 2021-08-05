using System.Collections.Generic;

namespace HW_11_Task_2
{
    interface IMotorcycleRepository<T>
    {
        T GetMotorcycleByID(int Id);
        List<T> GetMotorcycles();
        void CreateMotorcycle(T motorcycle);
        void UpdateMotorcycle(T motorcycle, string newName, string newModel, int newOdometer);
        void DeleteMotorcycle(T motorcycle);
    }
}
