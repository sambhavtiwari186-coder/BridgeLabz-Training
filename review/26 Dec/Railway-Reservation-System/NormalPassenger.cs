using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Railway_Reservation_System
{
     class NormalPassenger
    {
        private string name;
        private double pnr;
        private int age;
        public NormalPassenger(string name,double pnr,int age)
        {
            this.name = name;
            this.pnr = pnr;
            this.age = age;
        }
        public void Display()
        {
            Console.WriteLine("The name of the Passenger is " + this.name);
            Console.WriteLine("The PNR of the Passenger is " + this.pnr);
            Console.WriteLine("The Age of the Passenger is  " + this.age);
        }
        public string GetName()
        {
            return name;
        }
        public int GetAge()
        {
            return age;
        }
        public double GetPnr()
        {
            return pnr;
        }
        public int CalculateFare(int fare)
        {
            return fare;
        }
    }
}
