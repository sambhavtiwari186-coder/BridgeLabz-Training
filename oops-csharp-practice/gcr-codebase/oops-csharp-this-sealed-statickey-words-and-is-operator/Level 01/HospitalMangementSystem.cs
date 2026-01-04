using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.keywords_and_instances_in_oops
{
    internal class HospitalMangementSystem
    {
        // Creating a Hospital class 
        class Hospital
        {
            public static string hospitalName = "Apex Hospital";
            public static int totalPatient;
            string patientName;
            int age;
            string aliment;
            readonly int patientID;
            //Creating a Constructor of the Class
            public Hospital(int age, string patientName, int patientID,string aliment)
            {
                this.patientID = patientID;
                this.age = age;
                this.patientName = patientName;
                this.aliment = aliment;
                totalPatient++;
            }
            // Creating a Method to Display total number of patients
            public static void DisplayTotalPatient()
            {
                Console.WriteLine("The total number of patients is " + totalPatient);
            }
            // Creating a Method to Display Patients Details
            public void DisplayStudentDetails()
            {
                Console.WriteLine("The Name of the patient is " + this.patientName);
                Console.WriteLine("The age of the patient is  " + this.age);
                Console.WriteLine("The Patient ID is " + this.patientID);
                Console.WriteLine("The aliment of the Patient is " + this.aliment);
            }
        }
        // Creating a Display Method to Create the object of the Class

        public void Display()
        {
            Console.WriteLine("The Name of the Hospital is " + Hospital.hospitalName);
            Hospital student = new Hospital(32,"Raghav",1234,"Viral Fever");
            student.DisplayStudentDetails();
            Console.WriteLine();
            Hospital student1 = new Hospital(40,"Sundar",1456,"Bone Fracture");
            student1.DisplayStudentDetails();

            bool show = student is Hospital;
            if (show)
            {
                Console.WriteLine("This obj is the instance of the Hospital");

            }
            Hospital.DisplayTotalPatient();
        }
    }
}
