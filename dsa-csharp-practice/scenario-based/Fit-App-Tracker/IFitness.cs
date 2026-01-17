using System;
using System.Collections.Generic;
using System.Text;

namespace Review.Fit_App_Tracker
{
     interface IFitness
    {
        public void AddUser();
        public void UpdateSteps(int userId,int steps);
        public void DisplayLeader();
    }
}
