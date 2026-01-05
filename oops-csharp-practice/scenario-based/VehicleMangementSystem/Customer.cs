using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.scenario_based.VehicleMangementSystem
{
    class Customer
    {
        private int customerId;
        private string customerName;
        public Customer(int id, string name)
        {
            customerId = id;
            customerName = name;
        }
        public void RentVehicle(Vehicle vehicle, int days)
        {
            Console.WriteLine("Customer Name : " + customerName);
            vehicle.DisplayDetails();
            Console.WriteLine("Total Rent    : " + vehicle.CalculateRent(days));
            Console.WriteLine("--------------------------------");
        }
    }

}
