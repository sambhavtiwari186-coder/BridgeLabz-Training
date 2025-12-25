using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Methods.Level01
{
    internal class TriangularRun
    {
        public void Run() {
            // Taking sides as Input from User 
            Console.Write("Enter 1st side: ");
            double Side1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter 2nd side: ");
            double Side2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter 3rd side: ");
            double Side3 = Convert.ToDouble(Console.ReadLine());

            //calling the method rounds to Calculate the no of rounds
            double rounds = RoundsCalculate(Side1, Side2, Side3);

            Console.WriteLine("The total number of rounds is " + rounds);
        }
        public static double RoundsCalculate(double s1, double s2, double s3)
        {
            double Perimeter = s1 + s2 + s3;
            double Distance = 5000;
            double NoOfRounds = Distance / Perimeter;
            return NoOfRounds;
        }
    }
}
