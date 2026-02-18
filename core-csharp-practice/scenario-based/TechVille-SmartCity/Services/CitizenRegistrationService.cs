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

                // NAME
                Console.Write("Enter Name: ");
                string name = StringUtilities.FormatName(Console.ReadLine());

                // AGE
                Console.Write("Enter Age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                if (!Validator.ValidateAge(age))
                {
                    Console.WriteLine("Invalid Age. Skipping this member...");
                    continue;
                }

                // INCOME
                Console.Write("Enter Annual Income: ");
                double income = Convert.ToDouble(Console.ReadLine());

                if (!Validator.ValidateIncome(income))
                {
                    Console.WriteLine("Invalid Income. Stopping Registration.");
                    break;
                }

                // RESIDENCY
                Console.Write("Enter Residency Years: ");
                int residency = Convert.ToInt32(Console.ReadLine());

                if (!Validator.ValidateResidency(residency))
                {
                    Console.WriteLine("Invalid Residency. Skipping...");
                    continue;
                }

                // EMAIL
                Console.Write("Enter Email: ");
                string email = Console.ReadLine();

                if (!StringUtilities.ValidateEmail(email))
                {
                    Console.WriteLine("Invalid Email Format. Skipping...");
                    continue;
                }

                // ADDRESS
                Console.Write("Enter Address (Include 6 digit PIN): ");
                string address = Console.ReadLine();

                string pin = StringUtilities.ExtractPin(address);
                Console.WriteLine("Extracted PIN: " + pin);

                // CREATE CITIZEN OBJECT
                Citizen citizen = new Citizen(
                    name,
                    age,
                    income,
                    residency,
                    email,
                    address
                );

                // CALCULATE ELIGIBILITY
                citizen.CalculateEligibility();
                citizen.DetermineServicePackage();

                // DISPLAY PROFILE
                citizen.DisplayCitizenInfo();

                // SHOW SERVICE BENEFITS
                ServicePackage.ShowPackageBenefits(citizen.ServicePackage);
            }

            Console.WriteLine("\nRegistration Session Completed.");
        }
    }
}
