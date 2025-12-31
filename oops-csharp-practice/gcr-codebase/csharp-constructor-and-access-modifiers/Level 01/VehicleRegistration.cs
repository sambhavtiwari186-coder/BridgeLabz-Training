using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace BridgeLabzTraining.Constructor
{
    internal class VehicleRegistration
    {
        class Vehicle
        {
            public static int registrationFee = 3000;
            string ownerName;
            string vehicleType;
            public Vehicle(string ownerName, string vehicleType)
            {
                this.ownerName = ownerName;
                this.vehicleType = vehicleType;
            }   
            public void DisplayVehicleDetails()
            {
                Console.WriteLine("The Owner of the Car is " + ownerName);
                Console.WriteLine("The Type of Vehicle is " + vehicleType);
            }
            public static void UpdateRegistrationFee(int newRegistrationFee) { 
                registrationFee=newRegistrationFee;
            }

        }
        public void Display()
        {
            Vehicle vehicle = new Vehicle("SambhavTiwari","Bike");
            vehicle.DisplayVehicleDetails();
            Console.WriteLine("The RegistrationFees is " + Vehicle.registrationFee);
            Vehicle.UpdateRegistrationFee(5000);
            Console.WriteLine("Updated Registration Fees");
            Console.WriteLine(Vehicle.registrationFee);
        }
    }
}
