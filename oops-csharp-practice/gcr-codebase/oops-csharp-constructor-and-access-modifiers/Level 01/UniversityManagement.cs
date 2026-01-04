using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Constructor
{
    internal class UniversityManagement
    {
        
        public class Student
        {
            // Public variable
            public int rollNumber;

            // Protected variable
            protected string name;

            // Private variable
            private double CGPA;

            // Constructor
            public Student(int rollNumber, string name, double cgpa)
            {
                this.rollNumber = rollNumber;
                this.name = name;
                this.CGPA = cgpa;
            }

            // Public method to access CGPA
            public double GetCGPA()
            {
                return CGPA;
            }

            // Public method to modify CGPA
            public void SetCGPA(double cgpa)
            {
                if (cgpa >= 0 && cgpa <= 10)
                {
                    CGPA = cgpa;
                }
                else
                {
                    Console.WriteLine("Invalid CGPA value");
                }
            }

            // Public method to display basic details
            public void DisplayStudent()
            {
                Console.WriteLine("Roll Number : " + rollNumber);
                Console.WriteLine("Name        : " + name);
                Console.WriteLine("CGPA        : " + CGPA);
            }
        }
        public void Display()
        {
            Student st = new Student(27,"Sambhav",7.22);
            st.DisplayStudent();
          double CGPA=  st.GetCGPA();
            st.SetCGPA(8.93);
            st.DisplayStudent();


        }
    }
}
