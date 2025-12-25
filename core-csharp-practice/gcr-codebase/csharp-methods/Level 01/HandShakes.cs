using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Methods.Level01
{
    internal class HandShakes
    {
        public void CalHandShake() {
            // Taking no of Students as Input
            Console.WriteLine("Enter no of Students");
            int Students = Convert.ToInt32(Console.ReadLine());
            // Calaculating The no of HandShakes	
            int NoofHandShakes = (Students * (Students - 1)) / 2;
            // Printing NoofHandShakes as Output
            Console.WriteLine("No of HandShakes are " + NoofHandShakes);

        }
    }
}
