using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Methods.Level01
{
    internal class HandShakeMethod
    {
        public void HandShake() {
            // Taking no of Students as Input
            Console.WriteLine("Enter no of Students");
            int Students = Convert.ToInt32(Console.ReadLine());
            int NoofHandShakes = CalHandShake(Students);
            // Printing NoofHandShakes as Output
            Console.WriteLine("No of HandShakes are " + NoofHandShakes);


        }
        public int CalHandShake(int a) {
            // Calaculating The no of HandShakes	
            int NoofHandShakes = (a * (a - 1)) / 2;
            return NoofHandShakes;

        }
    }
}
