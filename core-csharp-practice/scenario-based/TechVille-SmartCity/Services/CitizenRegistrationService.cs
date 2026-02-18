using System;
using TechVilleSmartCity.Models;
using TechVilleSmartCity.Utilities;

namespace TechVilleSmartCity.Services
{
    public class CitizenRegistrationService
    {
        public Citizen RegisterCitizen()
        {
            Console.WriteLine("=== TechVille Citizen Registration ===");

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (!Validator.ValidateAge(age))
            {
                Console.WriteLine("Invalid Age Entered.");
                return null;
            }

            Console.Write("Enter Annual Income: ");
            double income = Convert.ToDouble(Console.ReadLine());

            if (!Validator.ValidateIncome(income))
            {
                Console.WriteLine("Invalid Income Entered.");
                return null;
            }

            Console.Write("Enter Residency Years in TechVille: ");
            int residency = Convert.ToInt32(Console.ReadLine());

            if (!Validator.ValidateResidency(residency))
            {
                Console.WriteLine("Invalid Residency Years.");
                return null;
            }

            Citizen citizen = new Citizen(name, age, income, residency);
            citizen.CalculateEligibility();

            return citizen;
        }
    }
}
