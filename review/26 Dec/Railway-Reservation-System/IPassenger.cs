using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Railway_Reservation_System
{
     interface IPassenger
    {
        public void AddPassenger();
        // public void AddNormalPassenger();
        public void  CalculateFare();
        public void SearchPassenger(string name);
        public void Display();
    }
}
