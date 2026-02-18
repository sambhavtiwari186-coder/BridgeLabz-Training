using System;
using TechVilleSmartCity.Models;
using TechVilleSmartCity.Utilities;

namespace TechVilleSmartCity.Services
{
    public class CitizenProfileService
    {
        public Citizen CreateProfile()
        {
            Console.WriteLine("\n=== Create Citizen Profile ===");

            Console.Write("Enter Name: ");
            string name = StringUtilities.FormatName(Console.ReadLine());

            Console.Write("Enter Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Income: ");
            double income = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Residency Years: ");
            int residency = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            if (!StringUtilities.ValidateEmail(email))
            {
                Console.WriteLine("Invalid Email Format.");
                return null;
            }

            Console.Write("Enter Address (Include 6 digit PIN): ");
            string address = Console.ReadLine();

            string pin = StringUtilities.ExtractPin(address);
            Console.WriteLine("Extracted PIN: " + pin);

            Citizen citizen = new Citizen(name, age, income, residency, email, address);

            citizen.CalculateEligibility();
            citizen.DetermineServicePackage();

            return citizen;
        }

        public void SearchCitizenByName(Citizen citizen)
        {
            Console.Write("Enter name keyword to search: ");
            string keyword = Console.ReadLine();

            if (StringUtilities.NameContains(citizen.Name, keyword))
            {
                Console.WriteLine("Match Found!");
                citizen.DisplayCitizenInfo();
            }
            else
            {
                Console.WriteLine("No Match Found.");
            }
        }
    }
}
