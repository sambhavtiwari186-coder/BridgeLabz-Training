using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.keywords_and_instances_in_oops
{
    internal class VehicleMangementSystem
    {
        // Creating a Vehicle class 
        class Vehicle
        {
            public static int registrationFees = 2000;
            string ownerName;
            string vehicleType;
            readonly int registrationNumber;
            //Creating a Constructor of the Class
            public Vehicle(string vehicleType, string ownerName, int registrationNumber)
            {
                this.registrationNumber = registrationNumber;
                this.vehicleType = vehicleType;
                this.ownerName = ownerName;
            }
            // Creating a Method to Update Registration Fees
            public static int UpdateRegistrationFees(int newRegistrationFess)
            {
                registrationFees = newRegistrationFess;
                return registrationFees;
            }
            // Creating a Method to Display Car Details
            public void DisplayProduct()
            {
                Console.WriteLine("The Name of the owner is " + this.ownerName);
                Console.WriteLine("The type of vehicle is  " + this.vehicleType);
                Console.WriteLine("The Registration Number is " + this.registrationNumber);
            }
        }
        // Creating a Display Method to Create the object of the Class

        public void Display()
        {
            Vehicle p1 = new Vehicle("Bike","Sambhav Tiwari",101);
            p1.DisplayProduct();
            bool show = p1 is Vehicle;
            if (show)
            {
                Console.WriteLine("This obj is the instance of the Vehicle");

            }
            int registrationFees = Vehicle.registrationFees;
            int newregistrationfees = Vehicle.UpdateRegistrationFees(2500);
            Console.WriteLine("The old Registration Fees is " + registrationFees + " and the new registrationFees is " + newregistrationfees); ;
        }
    }
}
