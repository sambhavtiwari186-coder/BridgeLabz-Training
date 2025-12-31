using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Constructor
{
    internal class CarRentalSystem
    {
        // Intalise a Car Class to Calculate the Rental Charges
        public class Car{
            string customerName;
            string carModel;
            int rentalDays;
            double rent;
            // Crrating The Constructor of this Class
            public Car(string customerName, string carModel, int rentalDays)
            {
                this.customerName = customerName;
                this.carModel = carModel;
                this.rentalDays = rentalDays;
                 int rent = Rent();
            }
            // Making a Method to Calculate The Rent 
             public int Rent()
            {
                int rent = 10*(this.rentalDays);
                return rent;
            }
            //Method to display the results
            public void display()
            {
                Console.WriteLine("The Cost of Rental Service is " + Rent());
            }

        }
        // Creating a Method To Make an Object of the Above Car Class
        public void CarSystem()
        {
            Console.WriteLine("------------Welcome to Car Rental Service-----------");
            Car car = new Car("Sambhav", "Wagnor VXI", 34);
            Console.WriteLine("Rent for Per Day is 10 ruppees ");
            car.Rent();
            car.display();
        }

    }
}
