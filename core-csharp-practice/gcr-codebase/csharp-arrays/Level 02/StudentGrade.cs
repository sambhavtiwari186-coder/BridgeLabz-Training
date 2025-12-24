using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Arrays.level2
{
    internal class StudentGrade
    {
        public static void Student()
        {
            // Getting input from the user
            Console.Write("Enter number of students: ");
            int num = Convert.ToInt32(Console.ReadLine());
            double[] Physics = new double[num];
            double[] Chemistry = new double[num];
            double[] Maths = new double[num];
            double[] PercentageArray = new double[num];
            char[] GradeArray = new char[num];
            for (int i = 0; i < num; i++){
                Console.Write("Physics: ");
                Physics[i] = Convert.ToDouble(Console.ReadLine());
                if (Physics[i] < 0)
                {
                    Console.WriteLine("Enter positive marks");
                    i--;
                    continue;
                }
                Console.Write("Chemistry: ");
                Chemistry[i] = Convert.ToDouble(Console.ReadLine());
                if (Chemistry[i] < 0)
                {
                    Console.WriteLine("Enter positive marks");
                    i--;
                    continue;
                }
                Console.Write("Maths: ");
                Maths[i] = Convert.ToDouble(Console.ReadLine());
                if (Maths[i] < 0)
                {
                    Console.WriteLine("Enter positive marks");
                    i--;
                    continue;
                }
              // Calculations
                double total = Physics[i] + Chemistry[i] + Maths[i];
                PercentageArray[i] = total / 3;
                if (PercentageArray[i] >= 80) GradeArray[i] = 'A';
                else if (PercentageArray[i] >= 70) GradeArray[i] = 'B';
                else if (PercentageArray[i] >= 60) GradeArray[i] = 'C';
                else if (PercentageArray[i] >= 50) GradeArray[i] = 'D';
                else if (PercentageArray[i] >= 40) GradeArray[i] = 'E';
                else GradeArray[i] = 'R';
            }
            // Displaying the result
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"Student {i + 1} Percentage = {PercentageArray[i]}%, Grade = {GradeArray[i]}");
            }
        }
    }
}