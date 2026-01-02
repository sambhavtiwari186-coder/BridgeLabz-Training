using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.keywords_and_instances_in_oops
{
    internal class UniversityMangementSystem
    {
        // Creating a Student class 
        class Student
        {
            public static string UniversityName = "GLA University";
            public static int totalStudent;
            string studentName;
            string grade;
            readonly int rollNumber;
            //Creating a Constructor of the Class
            public Student(string grade, string studentName, int rollNumber)
            {
                this.rollNumber = rollNumber;
                this.grade = grade;
                this.studentName = studentName;
                totalStudent++;
            }
            // Creating a Method to Display total number of students
            public static void DisplayTotalStudent()
            {
                Console.WriteLine("The total number of students is " + totalStudent);
            }
            // Creating a Method to Display Student Details
            public void DisplayStudentDetails()
            {
                Console.WriteLine("The Name of the student is " + this.studentName);
                Console.WriteLine("The grade of the student is  " + this.grade);
                Console.WriteLine("The Roll No is " + this.rollNumber);
            }
        }
        // Creating a Display Method to Create the object of the Class

        public void Display()
        {
            Console.WriteLine("The Name of The University is " + Student.UniversityName);
            Student student = new Student("A", "Sambhav Tiwari", 39);
            student.DisplayStudentDetails();
            Console.WriteLine();
            Student student1 = new Student("A+","Aditey Rai",40);
            student1.DisplayStudentDetails();

            bool show = student is Student;
            if (show)
            {
                Console.WriteLine("This obj is the instance of the Student");

            }
            Student.DisplayTotalStudent();
        }
    }
}
