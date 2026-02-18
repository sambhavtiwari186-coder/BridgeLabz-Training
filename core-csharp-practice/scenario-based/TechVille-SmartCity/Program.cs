using System;
using TechVilleSmartCity.Services;

namespace TechVilleSmartCity
{
    class Program
    {
        static void Main(string[] args)
        {
            CitizenRegistrationService registrationService = new CitizenRegistrationService();
            CitizenDatabaseService databaseService = new CitizenDatabaseService(100);

            // MODULE 2 LOGIC
            registrationService.RegisterMultipleCitizens();

            // MODULE 3 LOGIC
            Console.WriteLine("\n=== Smart Citizen Database Module ===");

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter Citizen ID: ");
                int id = Convert.ToInt32(Console.ReadLine());

                databaseService.AddCitizenId(id);

                Console.Write("Enter Zone (0-4): ");
                int zone = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Sector (0-4): ");
                int sector = Convert.ToInt32(Console.ReadLine());

                databaseService.AssignZoneSector(zone, sector);
            }

            databaseService.DisplayCitizenIds();
            databaseService.SortCitizenIds();
            databaseService.DisplayCitizenIds();

            Console.Write("Enter ID to Search: ");
            int searchId = Convert.ToInt32(Console.ReadLine());
            databaseService.SearchCitizen(searchId);

            databaseService.CopyCitizenIds();
            databaseService.DisplayZoneSectorData();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
