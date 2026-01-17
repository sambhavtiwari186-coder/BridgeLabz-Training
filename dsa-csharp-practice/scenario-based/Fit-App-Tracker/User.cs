using System;
using System.Collections.Generic;
using System.Text;

namespace Review.Fit_App_Tracker
{
     class User
    {
        private int userId;
        private string name;
        private int TotalSteps;
        public User(int userId, string name, int totalSteps)
        {
            this.userId = userId;
            this.name = name;
            this.TotalSteps = totalSteps;
        }
        public int GetUserId()
        {
            return userId;
        }
        public int SetInitialStep(int steps) { 
            TotalSteps = steps;
            return TotalSteps;
        }
        public string GetName() { 
           return name;
        }
        public int GetInitialSteps() { 
          return TotalSteps;
        } 
        public int UpdateSteps(int steps)
        {
            int totalSteps = 0;
            if (steps < 0)
            {
                Console.WriteLine("Invalid Step Count By the User");

            }
            else
            {
               totalSteps = GetInitialSteps() + steps;
            }
            return totalSteps;
        }
        public void Display()
        {
            Console.WriteLine("The User-Id of The Runner is " + this.userId);
            Console.WriteLine("The Name of the User is  "+ this.name);
            Console.WriteLine("The Total steps taken by the User is "+ this.TotalSteps);
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
