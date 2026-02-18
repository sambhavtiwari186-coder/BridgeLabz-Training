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

            Console.WriteLine("\nRegistration Session Completed.");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
