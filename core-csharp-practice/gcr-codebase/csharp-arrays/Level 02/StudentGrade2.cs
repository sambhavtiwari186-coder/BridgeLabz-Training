using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Arrays.level2
{
    internal class StudentRecord2
    {
        public static void Student()
        {
            //Getting input from the user
            Console.Write("Enter number of students: ");
            int number = Convert.ToInt32(Console.ReadLine());
            double[,] MarksArray = new double[number, 3];
            double[] PercentageArray = new double[number];
            char[] GradeArray = new char[number];

            for (int i = 0; i < number; i++)
            {
                Console.Write("Physics: ");
                MarksArray[i, 0] = Convert.ToDouble(Console.ReadLine());
                if (MarksArray[i, 0] < 0)
                {
                    Console.WriteLine("Enter positive marks");
                    i--;
                    continue;
                }
                Console.Write("Chemistry: ");
                MarksArray[i, 1] = Convert.ToDouble(Console.ReadLine());
                if (MarksArray[i, 1] < 0)
                {
                    Console.WriteLine("Enter positive marks");
                    i--;
                    continue;
                }
                Console.Write("Maths: ");
                MarksArray[i, 2] = Convert.ToDouble(Console.ReadLine());
                if (MarksArray[i, 2] < 0)
                {
                    Console.WriteLine("Enter positive marks");
                    i--;
                    continue;
                }
               //Calculations
                double total = MarksArray[i, 0] + MarksArray[i, 1] + MarksArray[i, 2];
                PercentageArray[i] = total / 3;
                if (PercentageArray[i] >= 80) GradeArray[i] = 'A';
                else if (PercentageArray[i] >= 70) GradeArray[i] = 'B';
                else if (PercentageArray[i] >= 60) GradeArray[i] = 'C';
                else if (PercentageArray[i] >= 50) GradeArray[i] = 'D';
                else if (PercentageArray[i] >= 40) GradeArray[i] = 'E';
                else GradeArray[i] = 'R';
            }
            //Displaying the result
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"Student {i + 1} Percentage = {PercentageArray[i]}%, Grade = {GradeArray[i]}");
            }
        }
    }
}