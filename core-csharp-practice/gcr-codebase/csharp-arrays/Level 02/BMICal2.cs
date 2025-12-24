using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Array.Level__2
{
    internal class BMICal2
    {
        public void BMICalculator2() {
            // Step 1: Take input for number of persons
            Console.WriteLine("Enter number of persons:");
            int num = Convert.ToInt32(Console.ReadLine());
            // Step 2: Create multi-dimensional array
            double[][] PersonData = new double[num][];
            string[] WeightStatus = new string[num];
            // Initialize inner arrays
            for (int i = 0; i < num; i++)
            {
                PersonData[i] = new double[3]; // weight, height, BMI
            }
             // Step 3: Take input for weight and height
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("\nEnter details for Person " + (i + 1));
             double weight, height;
                // Validating weight
                do
                {
                    Console.WriteLine("Enter weight (kg):");
                    weight = Convert.ToDouble(Console.ReadLine());
                    if (weight <= 0)
                    {
                        Console.WriteLine("Invalid weight. Enter a positive value.");
                    }
                } while (weight <= 0);

                // Validating  height
                do
                {
                    Console.WriteLine("Enter height (meters):");
                    height = Convert.ToDouble(Console.ReadLine());
                    if (height <= 0)
                    {
                        Console.WriteLine("Invalid height. Enter a positive value.");
                    }
                } while (height <= 0);

                PersonData[i][0] = weight;
                PersonData[i][1] = height;
            }
               // Step 4: Calculate BMI and weight status
            for (int i = 0; i < num; i++)
            {
                double bmi = PersonData[i][0] / (PersonData[i][1] * PersonData[i][1]);
                PersonData[i][2] = bmi;

                if (bmi < 18.5)
                {
                    WeightStatus[i] = "Underweight";
                }
                else if (bmi < 25)
                {
                    WeightStatus[i] = "Normal";
                }
                else if (bmi < 30)
                {
                    WeightStatus[i] = "Overweight";
                }
                else
                {
                    WeightStatus[i] = "Obese";
                }
            }
              // Step 5: Display results
            Console.WriteLine("\n--- BMI REPORT ---");
            Console.WriteLine("Person\tWeight\tHeight\tBMI\t\tStatus");
           for (int i = 0; i < num; i++)
            {
                Console.WriteLine(
                    (i + 1) + "\t" +
                    PersonData[i][0] + "\t" +
                    PersonData[i][1] + "\t" +
                    PersonData[i][2].ToString("F2") + "\t\t" +
                    WeightStatus[i]
                );
            }
        }
    }
}

