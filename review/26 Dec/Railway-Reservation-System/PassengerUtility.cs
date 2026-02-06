using System;

namespace ConsoleApp2.Railway_Reservation_System
{
    internal class PassengerUtility : IPassenger
    {
        private NormalPassenger[] normalPassengers;
        private int count;
        public int fare = 1000;

        public PassengerUtility()
        {
            normalPassengers = new NormalPassenger[50];
            count = 0;
            normalPassengers[count] = new NormalPassenger("ram", 103, 30);
            count++;
        }

        public void AddPassenger()
        {
            Console.WriteLine("Enter Passenger Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Passenger PNR:");
            int pnr = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Passenger Age:");
            int age = Convert.ToInt32(Console.ReadLine());

            normalPassengers[count] = new NormalPassenger(name, pnr, age);
            count++;
        }

        public void BinarySort()
        {
            for (int i = count - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (normalPassengers[j].GetPnr() > normalPassengers[j + 1].GetPnr())
                    {
                        NormalPassenger temp = normalPassengers[j];
                        normalPassengers[j] = normalPassengers[j + 1];
                        normalPassengers[j + 1] = temp;
                    }
                }
            }
        }

        public void Display()
        {
            BinarySort();

            for (int i = 0; i < count; i++)
            {
                normalPassengers[i].Display();
            }
            Console.WriteLine();
        }

        public void SearchPassenger(string name)
        {
            for (int i = 0; i < count; i++)
            {
                if (normalPassengers[i].GetName().Equals(name))
                {
                    normalPassengers[i].Display();
                    return;
                }
            }
            Console.WriteLine("Passenger not found.");
        }

        public void CalculateFare()
        {
            for(int i = 0; i < count; i++)
            {
                if (normalPassengers[i].GetAge() > 60)
                {
                    Console.WriteLine("The Fare of The " + normalPassengers[i].GetName() + " is " + (fare - 100));
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("The Fare of The " + normalPassengers[i].GetName()+" is " + fare);
                    Console.WriteLine();
                }
            }
        }
    }
}
