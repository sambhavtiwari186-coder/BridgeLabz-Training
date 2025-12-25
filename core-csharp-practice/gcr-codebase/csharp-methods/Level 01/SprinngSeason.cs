using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Methods.Level01
{
    internal class SprinngSeason
    {
        public void SpringSeason()
        {
            //getting input from Command Line
            int Month = Convert.ToInt32(args[0]);
            int Day = Convert.ToInt32(args[1]);

            bool ans = SpringCheck(Month, Day);//Calling the method

            if (ans)
            {
                Console.WriteLine("Spring Season");
            }
            else
            {
                Console.WriteLine("Not Spring Season");
            }
        }
    //Method to check spring season
     public static bool SpringCheck(int month, int day)
        {
            if ((month == 3 && day >= 20) || (month == 4) || (month == 5) || (month == 6 && day <= 20))
            {
                return true;
            }
            return false;

        }
    }
}
