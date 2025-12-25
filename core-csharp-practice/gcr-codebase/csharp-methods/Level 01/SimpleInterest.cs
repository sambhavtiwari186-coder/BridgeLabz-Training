using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Methods.Level01
{
    internal class SimpleInterest
    {
        public void CalInterest() {
            // Taking Principal ,Rate,Time as Input from the User
            Console.WriteLine("Enter The Principal Amount Here");
            int PrincipalAmount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Time  Here");
            int Time = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Rate of Interest  Here");
            int Rate = Convert.ToInt32(Console.ReadLine());
            int SI = Interest(PrincipalAmount, Time, Rate);
            Console.WriteLine("The Simple Interest is " + SI + " for Principal " + PrincipalAmount + " Rate of Interest " + Rate + " and Time " + Time);

        }
        public int Interest(int a, int b, int c) {
            int SI = (a * b * c) / 100;
            return SI;
        }
    }
}
