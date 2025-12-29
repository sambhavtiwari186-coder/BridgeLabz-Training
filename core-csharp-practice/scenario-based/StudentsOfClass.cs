using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BridgeLabzTraining.scenario_based.SentenceFormatter
{
    internal class StudentsOfClass
    {
        public void Student()
        {
            // Inatalize the Student array here
            Console.WriteLine("No of Student in the Class ");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] studnet = new double[n];

            Console.WriteLine("Marks Of Each Students");

            for (int i = 0; i < n; i++)
            {
                studnet[i] = Convert.ToDouble(Console.ReadLine());
            }
            double High = Highest(studnet);
            Console.WriteLine("Highest Marks in the Class is " + High);
            double Low = Smallest(studnet);
            Console.WriteLine("Lowest  Marks in the Class is  " + Low);
            double Avg = Average(studnet);
            Console.WriteLine("Average Marks Of The Student is " + Avg);
            Console.WriteLine("The Marks Above the Average Marks are");
            DisplayStudent(studnet);
        }
        // Calculating highest marks of the class
        public double Highest(double[] Studnet)
        {
            double highest = 0;
            for (int i = 0; i < Studnet.Length; i++)
            {
                if (Studnet[i] > highest)
                {
                    highest = Studnet[i];
                }
            }
            return highest;
        }
        // Calculating Lowest Marks in The Class
        public double Smallest(double[] Student)
        {
            double small = Student[0];
            for (int i = 0; i < Student.Length; i++)
            {
                if (Student[i] < small)
                {
                    small = Student[i];
                }
            }
            return small;
        }
        // Calculating the average Marks of the Student
        public double Average(double[] Student)
        {
            double sum = 0;
            for (int i = 0; i < Student.Length; i++)
            {
                sum += Student[i];
            }
            double average = sum / (Student.Length);
            return average;
        }
        // Method to display the Student above
        public void DisplayStudent(double [] Student)
        {
            double avg = Average(Student);
             for(int i = 0;i < Student.Length; i++)
            {
                if(Student[i] > avg)
                {
                    Console.WriteLine(Student[i]);
                }
            }
        }
    }
}
