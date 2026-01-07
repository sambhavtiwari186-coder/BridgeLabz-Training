using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.scenario_based.VehicleMangementSystem
{
    // Writing a Class to Make the Program a Menu Drien Program
    class Display
    {
        public void DisplayInfo()
        {
            int choice;
            do
            {
                Console.WriteLine("\n--- Vehicle Rental Menu ---");
                Console.WriteLine("1. Rent Bike");
                Console.WriteLine("2. Rent Car");
                Console.WriteLine("3. Rent Truck");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 4)
                {
                    Console.WriteLine("Thank you for using Vehicle Rental System!");
                    break;
                }

                Console.Write("Enter Customer Name: ");
                string customerName = Console.ReadLine();
                Customer customer = new Customer(1, customerName);

                Console.Write("Enter Number of Days: ");
                int days = Convert.ToInt32(Console.ReadLine());

                Vehicle vehicle = null;

                switch (choice)
                {
                    case 1:
                        vehicle = new Bike(101, "Honda", "Activa", 300);
                        break;

                    case 2:
                        vehicle = new Car(102, "Tata", "Nexon", 1500);
                        break;

                    case 3:
                        vehicle = new Truck(103, "Ashok Leyland", "1616", 4000);
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        continue;
                }

                customer.RentVehicle(vehicle, days);

            } while (choice != 4);
        }
    }
}
