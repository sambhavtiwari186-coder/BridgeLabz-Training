using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.scenario_based.VehicleMangementSystem
{
    abstract class Vehicle : IRentable
    {
        // Protected fields
        protected int vehicleId;
        protected string brand;
        protected string model;
        protected double rentPerDay;
        protected bool isAvailable;

        // Constructor
        public Vehicle(int vehicleId, string brand, string model, double rentPerDay)
        {
            this.vehicleId = vehicleId;
            this.brand = brand;
            this.model = model;
            this.rentPerDay = rentPerDay;
            this.isAvailable = true;
        }

        // Abstract method
        public abstract double CalculateRent(int days);

        // Concrete method
        public void DisplayDetails()
        {
            Console.WriteLine("Vehicle ID : " + vehicleId);
            Console.WriteLine("Brand      : " + brand);
            Console.WriteLine("Model      : " + model);
            Console.WriteLine("Rent/Day   : " + rentPerDay);
            Console.WriteLine("Available  : " + isAvailable);
        }
    }

}
