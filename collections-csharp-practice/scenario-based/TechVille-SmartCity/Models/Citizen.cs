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
        public string Email;
        public string Address;

        public Citizen(string name, int age, double income, int residencyYears,
                       string email, string address)
        {
            Name = name;
            Age = age;
            Income = income;
            ResidencyYears = residencyYears;
            Email = email;
            Address = address;
        }

        public void CalculateEligibility()
        {
            EligibilityScore = (Age * 0.3) +
                               (Income / 100000 * 0.4) +
                               (ResidencyYears * 0.3);
        }

        public void DetermineServicePackage()
        {
            if (EligibilityScore >= 70)
                ServicePackage = "Platinum";
            else if (EligibilityScore >= 50)
                ServicePackage = "Gold";
            else if (EligibilityScore >= 30)
                ServicePackage = "Silver";
            else
                ServicePackage = "Basic";
        }

        // Pass By Value Example
        public void UpdateIncome(double newIncome)
        {
            newIncome += 1000; // this change won’t affect original outside
            Income = newIncome;
        }

        // Pass By Reference Example
        public void UpdateAddress(ref string newAddress)
        {
            Address = newAddress;
        }

        public void DisplayCitizenInfo()
        {
            Console.WriteLine("\n----- Citizen Profile -----");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Income: {Income}");
            Console.WriteLine($"Residency Years: {ResidencyYears}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Eligibility Score: {EligibilityScore:F2}");

            string status = EligibilityScore >= 30 ? "Eligible" : "Not Eligible";
            Console.WriteLine($"Eligibility Status: {status}");
            Console.WriteLine($"Service Package: {ServicePackage}");
        }
    }
}
