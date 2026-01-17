using System;
using System.Collections.Generic;
using System.Text;

namespace Review.Fit_App_Tracker
{
    class FitnessUtility : IFitness
    {
        private User[] user;
        int count;
        public FitnessUtility()
        {
            user = new User[19];
            count = 0;
            User use1 = new User(101, "Sambhav", 2000);
            user[count] = use1;
            count++;
            User use2 = new User(102, "Aditey", 3000);
            user[count] = use2;
            count++;
            User use3 = new User(103, "Shyam", 2500);
            user[count] = use3;
            count++;
        }
        public void AddUser()
        {
            Console.WriteLine("Enter the UserId of the User");
            int userId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Name of the User");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the Intial Steps of the User");
            int intialSteps = Convert.ToInt32(Console.ReadLine());
            user[count] = new User(userId, name, intialSteps);
            count++;
        }
        public void UpdateSteps(int userId, int steps)
        {

            for (int i = 0; i < count; i++)
            {
                if (user[i].GetUserId() == userId)
                {
                    int originalSteps = user[i].GetInitialSteps() + steps;
                    user[i].SetInitialStep(originalSteps);
                    Console.WriteLine("\nUser Steps is Updated!!!");
                    return;
                }
            }
            Console.WriteLine("User-Id Not Found");
        }
        public void BubbleSort()
        {
            for (int i = count - 1; i > 0; i--)
            {
                for (int j = 0; j <= i - 1; j++)
                {
                    if (user[j].GetInitialSteps() < user[j + 1].GetInitialSteps())
                    {
                        // swap
                        User temp = user[j + 1];
                        user[j + 1] = user[j];
                        user[j] = temp;
                    }
                }
            }
        }
        public void DisplayLeader()
        {
            BubbleSort();
            for (int i = 0; i < count; i++)
            {
                user[i].Display();
            }

        }
    }
}
