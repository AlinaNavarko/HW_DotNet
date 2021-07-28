using Serilog;

namespace HW_11_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
             .MinimumLevel.Debug()
             .WriteTo.Console()
             .WriteTo.File("logs/CRUDlogs.txt", rollingInterval: RollingInterval.Hour)
             .CreateLogger();

            Log.Information("App has started");

            Motorcycle motorcycle1 = new Motorcycle(1, "Name1", "Java", 2000, 100);
            Motorcycle motorcycle2 = new Motorcycle(2, "Name2", "Yamaha", 1999, 200);

            MotorcycleRepository motos = new MotorcycleRepository();
            motos.CreateMotorcycle(motorcycle1);
            motos.CreateMotorcycle(motorcycle2);
            motos.GetMotorcycles();
            motos.DeleteMotorcycle(motorcycle2);
            motos.UpdateMotorcycle(motorcycle1, "UpdatedName", "UpdatedModel", 500);
            motos.GetMotorcycleByID(1);

            Log.Information("CRUD operations have been finished");
        }
    }
}
