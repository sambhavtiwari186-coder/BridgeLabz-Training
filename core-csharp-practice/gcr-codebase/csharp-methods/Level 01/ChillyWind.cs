using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Methods.Level01
{
    internal class ChillyWind
    {
        public void CalWindSpeed() {
            //taking temperature and Speed from the user
            Console.Write("Enter the temperature: ");
            double Temperature = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter wind speed: ");
            double Speed = Convert.ToDouble(Console.ReadLine());
            //Calling the method
            double ans = FindWindChill(Temperature, Speed);
            Console.WriteLine("Wind chill:" + ans);
        }
        public static double FindWindChill(double temp, double speed)
        {
            double WindChill = 35.74 + (0.6215 * temp) + (0.4275 * temp - 35.75) * Math.Pow(speed, 0.16);
            return WindChill;
        }
    }
}
