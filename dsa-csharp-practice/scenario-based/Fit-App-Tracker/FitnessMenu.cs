using System;
using System.Collections.Generic;
using System.Text;

namespace Review.Fit_App_Tracker
{
    internal class FitnessMenu
    {
        FitnessUtility fit = new FitnessUtility();
       public  void Start()
        {
            Console.WriteLine("----Welcome to Fitness Tracker----\n");
            int choice;
            do
            {
                Console.WriteLine("1. Add The User");
                Console.WriteLine("2. Update the Steps of the User");
                Console.WriteLine("3. Display the LeaderBoard");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter Your Choice Here");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice) {
                    case 1:
                        fit.AddUser();
                        break;
                    case 2:
                        Console.WriteLine("Enter the User Id");
                        int userId=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Steps");
                        int steps = Convert.ToInt32(Console.ReadLine());
                       fit.UpdateSteps(userId, steps);
                        break;
                        case 3:
                        fit.DisplayLeader();
                        break;
                }
            } while (choice != 4);
        }
    }
}
