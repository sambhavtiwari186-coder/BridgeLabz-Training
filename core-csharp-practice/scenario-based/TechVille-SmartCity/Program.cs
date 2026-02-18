using System;
using TechVilleSmartCity.Services;
using TechVilleSmartCity.Models;

namespace TechVilleSmartCity
{
    class Program
    {
        static void Main(string[] args)
        {
            CitizenRegistrationService service = new CitizenRegistrationService();
            
            Citizen citizen = service.RegisterCitizen();

            if (citizen != null)
            {
                citizen.DisplayCitizenInfo();
            }
            else
            {
                Console.WriteLine("Registration Failed Due to Invalid Input.");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

