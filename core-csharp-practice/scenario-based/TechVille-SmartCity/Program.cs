using System;
using TechVilleSmartCity.Services;
using TechVilleSmartCity.Models;

namespace TechVilleSmartCity
{
    class Program
    {
        static void Main(string[] args)
        {
            CitizenProfileService profileService = new CitizenProfileService();

            Citizen citizen = profileService.CreateProfile();

            if (citizen != null)
            {
                citizen.DisplayCitizenInfo();

                profileService.SearchCitizenByName(citizen);

                // Pass by Value
                citizen.UpdateIncome(50000);

                // Pass by Reference
                string newAddress = "Updated Street, TechVille - 560001";
                citizen.UpdateAddress(ref newAddress);

                Console.WriteLine("\nAfter Updates:");
                citizen.DisplayCitizenInfo();
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
