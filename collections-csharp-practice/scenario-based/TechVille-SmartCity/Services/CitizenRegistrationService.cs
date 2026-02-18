using System;
using System.Collections.Generic;
using TechVilleSmartCity.Models;
using TechVilleSmartCity.Utilities;
using TechVilleSmartCity.Exceptions;

namespace TechVilleSmartCity.Services
{
    public class CitizenRegistrationService
    {
        private static HashSet<string> registeredEmails = new HashSet<string>();

        public void RegisterMultipleCitizens()
        {
            try
            {
                Console.Write("How many family members to register? ");
                int count = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= count; i++)
                {
                    Console.WriteLine($"\n--- Registering Member {i} ---");

                    Console.Write("Enter Name: ");
                    string name = StringUtilities.FormatName(Console.ReadLine());

                    Console.Write("Enter Age: ");
                    int age = Convert.ToInt32(Console.ReadLine());

                    if (!Validator.ValidateAge(age))
                        throw new InvalidAgeException("Age must be between 1 and 120.");

                    Console.Write("Enter Annual Income: ");
                    double income = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter Residency Years: ");
                    int residency = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Email: ");
                    string email = Console.ReadLine();

                    if (!StringUtilities.ValidateEmail(email))
                        throw new ArgumentException("Invalid Email Format.");

                    if (registeredEmails.Contains(email))
                        throw new DuplicateCitizenException("Citizen with this email already exists.");

                    Console.Write("Enter Address: ");
                    string address = Console.ReadLine();

                    Citizen citizen = new Citizen(name, age, income, residency, email, address);

                    citizen.CalculateEligibility();
                    citizen.DetermineServicePackage();

                    citizen.DisplayCitizenInfo();
                    ServicePackage.ShowPackageBenefits(citizen.ServicePackage);

                    registeredEmails.Add(email);
                }
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine("Custom Age Exception: " + ex.Message);
                ExceptionLogger.Log(ex);
            }
            catch (DuplicateCitizenException ex)
            {
                Console.WriteLine("Duplicate Exception: " + ex.Message);
                ExceptionLogger.Log(ex);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Invalid number format entered.");
                ExceptionLogger.Log(ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected Error Occurred.");
                ExceptionLogger.Log(ex);
            }
            finally
            {
                Console.WriteLine("\nRegistration process finished safely.");
            }
        }
    }
}
