using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Methods.Level01
{
    internal class Trignometry
    {
        public void CalTrignometry() {
            // Taking  Angle from the user
            Console.Write("Enter angle: ");
            double Angle = Convert.ToDouble(Console.ReadLine());
            //Calling the function
            double[] Answer = FindTrigonometricFunctions(Angle);
            Console.WriteLine("Sine value: " + Answer[0]);
            Console.WriteLine("Cosine value: " + Answer[1]);
            Console.WriteLine("Tangent value: " + Answer[2]);
        }
        public static double[] FindTrigonometricFunctions(double ang)
        {
            //Doing all the calculations 
            double radians = ang * Math.PI / 180;
            double sine = Math.Sin(radians);
            double cosine = Math.Cos(radians);
            double tangent = Math.Tan(radians);
           return new double[] { sine, cosine, tangent };

        }
    }
}
