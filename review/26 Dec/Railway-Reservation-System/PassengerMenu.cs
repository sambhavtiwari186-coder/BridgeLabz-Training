using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ConsoleApp2.Railway_Reservation_System
{
     class PassengerMenu
    {
        private PassengerUtility passengerUtility;
       public  void Start()
        {
            passengerUtility = new PassengerUtility();
            Console.WriteLine("-------Welcome to Railway- Reservation System------ ");
            int choice;

            do
            {
                Console.WriteLine("1 . Add a Passenger");
                Console.WriteLine("2. Display the Passengers");
                Console.WriteLine("3. Search the Passengers ");
                Console.WriteLine("4..Display the Fares of Passengers");
                Console.WriteLine("5. Exit ");
                Console.WriteLine("----Enter Your Choice-----");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        passengerUtility.AddPassenger();
                        Console.WriteLine("Passenger added Successfully !!!");
                        break;
                    case 2:
                        passengerUtility.Display();
                        break;
                    case 3:
                        Console.WriteLine("Enter the Name to be Searched in List");
                        string name = Console.ReadLine();
                        passengerUtility.SearchPassenger(name);
                        break;
                    case 4:
                        passengerUtility.CalculateFare();
                        break;
                    default:
                        Console.WriteLine("Enter the Valid Number ");
                        break;
                }
            } while (choice != 5);
        }
    }
}
