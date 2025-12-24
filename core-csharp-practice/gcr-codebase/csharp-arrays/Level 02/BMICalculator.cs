using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Array.Level__2
{
    internal class BMICalculator
    {
           public void BMICalc() {
            // Step 1: Take input for number of persons
            Console.WriteLine("Enter number of persons:");
            int n = Convert.ToInt32(Console.ReadLine());
          // Step 2: Creating arrays
            double[] Weight = new double[n];
            double[] Height = new double[n];
            double[] bmi = new double[n];
            string[] status = new string[n];
          // Step 3: Take input for height and weight
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nEnter weight (kg) of person " + (i + 1) + ":");
                Weight[i] = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter height (meters) of person " + (i + 1) + ":");
                Height[i] = Convert.ToDouble(Console.ReadLine());
            }
           // Step 4: Calculate BMI and weight status
            for (int i = 0; i < n; i++)
            {
                bmi[i] = Weight[i] / (Height[i] * Height[i]);
                if (bmi[i] < 18.5)
                {
                    status[i] = "Underweight";
                }
                else if (bmi[i] < 25)
                {
                    status[i] = "Normal";
                }
                else if (bmi[i] < 30)
                {
                    status[i] = "Overweight";
                }
                else
                {
                    status[i] = "Obese";
                }
            }
            // Step 5: Display results
            Console.WriteLine("\n--- BMI Report ---");
            Console.WriteLine("Person\tHeight(m)\tWeight(kg)\tBMI\t\tStatus");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(
                    (i + 1) + "\t" +
                    Height[i] + "\t\t" +
                    Weight[i] + "\t\t" +
                    bmi[i].ToString("F2") + "\t\t" +
                    status[i]
                );
            }
        }
    }
}
    

