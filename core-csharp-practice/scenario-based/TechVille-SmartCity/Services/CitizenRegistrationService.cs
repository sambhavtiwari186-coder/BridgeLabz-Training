using System;
using TechVilleSmartCity.Models;
using TechVilleSmartCity.Utilities;

namespace TechVilleSmartCity.Services
{
    public class CitizenRegistrationService
    {
        public void RegisterMultipleCitizens()
        {
            Console.Write("How many family members to register? ");
            int count = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= count; i++)
            {
                Console.WriteLine($"\n--- Registering Member {i} ---");

                Console.Write("Enter Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                if (!Validator.ValidateAge(age))
                {
                    Console.WriteLine("Invalid Age. Skipping this member...");
                    continue; // continue used here
                }

                Console.Write("Enter Annual Income: ");
                double income = Convert.ToDouble(Console.ReadLine());

                if (!Validator.ValidateIncome(income))
                {
                    Console.WriteLine("Invalid Income. Stopping Registration.");
                    break; // break used here
                }

                Console.Write("Enter Residency Years: ");
                int residency = Convert.ToInt32(Console.ReadLine());

                if (!Validator.ValidateResidency(residency))
                {
                    Console.WriteLine("Invalid Residency. Skipping...");
                    continue;
                }

                Citizen citizen = new Citizen(name, age, income, residency);

                citizen.CalculateEligibility();
                citizen.DetermineServicePackage();

                citizen.DisplayCitizenInfo();

                ServicePackage.ShowPackageBenefits(citizen.ServicePackage);
            }
        }
    }
}
