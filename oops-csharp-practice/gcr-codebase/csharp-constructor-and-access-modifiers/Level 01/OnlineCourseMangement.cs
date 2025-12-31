using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Constructor
{
    internal class OnlineCourseMangement
    {
        // Making Course Class to Make Enteries
        class Course
        {
            public static string instituteName ="GLA University";
            string CourseName;
            string duration;
            double fees;

            // Creating Constructor of The Class
            public Course(string courseName, string duration, double fees)
            {
                this.CourseName = courseName;
                this.duration = duration;
                this.fees = fees;
            }
            // Creating the method To Display the Content of Course Class
            public void DisplayCourseDetails()
            {
                Console.WriteLine("The Course of The Student is " + CourseName);
                Console.WriteLine("The Duration of The Course is" + duration);
                Console.WriteLine("The Fees of The Course is " + fees);
                Console.WriteLine("Name of the Institute is " + instituteName);
            }
            // Method to Update Institute 
            public static void UpdateInstituteName(string newInstitute)
            {
                instituteName=newInstitute;
            }
        }
        // Method to Create the Object of the Class 
        public void Display()
        {
            Course course = new Course("Btech" , " 4 Years", 30000);
            course.DisplayCourseDetails();
            Course.UpdateInstituteName("BHU");
            Console.WriteLine();
            Console.WriteLine("Updated Institute");
            Console.WriteLine(Course.instituteName);

        }
    }
}
