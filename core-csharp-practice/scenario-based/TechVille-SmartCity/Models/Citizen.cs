using System;

namespace TechVilleSmartCity.Models
{
    public class Citizen
    {
        public string Name;
        public int Age;
        public double Income;
        public int ResidencyYears;
        public double EligibilityScore;
        public string ServicePackage;

        public Citizen(string name, int age, double income, int residencyYears)
        {
            Name = name;
            Age = age;
            Income = income;
            ResidencyYears = residencyYears;
        }

        public void CalculateEligibility()
        {
            EligibilityScore = (Age * 0.3) +
                               (Income / 100000 * 0.4) +
                               (ResidencyYears * 0.3);
        }

        public void DetermineServicePackage()
        {
            // Nested if-else (Multi-level eligibility)
            if (EligibilityScore >= 70)
            {
                ServicePackage = "Platinum";
            }
            else if (EligibilityScore >= 50)
            {
                ServicePackage = "Gold";
            }
            else if (EligibilityScore >= 30)
            {
                ServicePackage = "Silver";
            }
            else
            {
                ServicePackage = "Basic";
            }
        }

        public void DisplayCitizenInfo()
        {
            Console.WriteLine("\n----- Citizen Information -----");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Income: {Income}");
            Console.WriteLine($"Residency Years: {ResidencyYears}");
            Console.WriteLine($"Eligibility Score: {EligibilityScore:F2}");

            // Ternary Operator
            string status = EligibilityScore >= 30 ? "Eligible" : "Not Eligible";
            Console.WriteLine($"Eligibility Status: {status}");

            Console.WriteLine($"Service Package: {ServicePackage}");
        }
    }
}
