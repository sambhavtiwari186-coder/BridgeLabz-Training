using System;
using TechVilleSmartCity.Services;

namespace TechVilleSmartCity
{
    class Program
    {
        static void Main(string[] args)
        {
            CitizenRegistrationService service = new CitizenRegistrationService();
            service.RegisterMultipleCitizens();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
