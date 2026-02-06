using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Railway_Reservation_System
{
       class SeniorPassenger
    {
        private string name;
        private int PNR;
        private int age;
        public SeniorPassenger(string name,int PNR,int age)
        {
            this.name = name;
            this.PNR = PNR;
            this.age = age;
        }
         public void Display()
        {
            Console.WriteLine("The Name of the Passenger is " + this.name);
            Console.WriteLine("The PNR of the Passenger is " + this.PNR);
            Console.WriteLine("The Age f the Passenger is " + this.age);
        }
          public int CalculateFare(int fare)
        {
            int originalFare = fare - 100;
            return originalFare;
        }
        }
    }
