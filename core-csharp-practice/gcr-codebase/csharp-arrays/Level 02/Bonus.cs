using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Array.Level__2
{
    internal class Bonus
    {
        public void CalculateBonus()
        {
            int size = 10;
         // Arrays to store employee data
            double[] salary = new double[size];
            double[] yearsOfService = new double[size];
            double[] bonus = new double[size];
            double[] newSalary = new double[size];
            double totalBonus = 0;
            double totalOldSalary = 0;
            double totalNewSalary = 0;
            // Step 1: Taking input from user
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter salary for employee " + (i + 1) + ":");
                double sal = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter years of service for employee " + (i + 1) + ":");
                double years = Convert.ToDouble(Console.ReadLine());
            // Input validation
                if (sal <= 0 || years < 0)
                {
                    Console.WriteLine("Invalid input. Please enter again.");
                    i--; // decrement index to repeat input
                    continue;
                }
                salary[i] = sal;
                yearsOfService[i] = years;
            }
            // Step 2: Calculate bonus and new salary
            for (int i = 0; i < size; i++)
            {
                if (yearsOfService[i] > 5)
                {
                    bonus[i] = salary[i] * 0.05;
                }
                else
                {
                    bonus[i] = salary[i] * 0.02;
                }

                newSalary[i] = salary[i] + bonus[i];

                totalBonus += bonus[i];
                totalOldSalary += salary[i];
                totalNewSalary += newSalary[i];
            }
             // Step 3: Display results
            Console.WriteLine("\n--- Salary Summary ---");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(
                    "Employee " + (i + 1) +
                    " | Old Salary: " + salary[i] +
                    " | Bonus: " + bonus[i] +
                    " | New Salary: " + newSalary[i]
                );
            }

            Console.WriteLine("\n--- Company Summary ---");
            Console.WriteLine("Total Old Salary: " + totalOldSalary);
            Console.WriteLine("Total Bonus Paid: " + totalBonus);
            Console.WriteLine("Total New Salary: " + totalNewSalary);

        }
    }
}

