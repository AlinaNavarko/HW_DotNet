using System.Collections.Generic;
using System.Linq;

namespace HW_08_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IEngineer> Developers = new List<IEngineer>();

            Developers.Add(new JuniorDeveloper("Alina", "Navarko", 1, "https://github.com/AlinaNavarko"));
            Developers.Add(new JuniorDeveloper("Petr", "Petrov", 1, "https://github.com/PetrPetrov"));
            Developers.Add(new MiddleDeveloper("Ivan", "Ivanov", 3, "https://github.com/IvanIvanov"));
            Developers.Add(new SeniorDeveloper("Roma", "Romashkin", 4, "https://github.com/RomaRomashkin"));
            Developers.Add(new TeamLeader("Kuzia", "Kuzmin", 7, "https://github.com/KuziaKuzmin"));
            Developers.Add(new Architect("Sidr", "Sidorov", 6, "https://github.com/SidrSidorov"));

            var sortedDevelopers = Developers.OrderBy(u => u.Rank);
            foreach (var item in sortedDevelopers)
            {
                item.GetInfo();
            }
        }
    }
}
