using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.scenario_based.EmployeeWageMangement
{
    class EmployeeMenu
    {
        private IEmployee Iemployee;


        public void EmployeeChoice()
        {
            Iemployee = new EmployeeUtilityImpl();

            // UC:01
            bool presentOrNot = Iemployee.EmployeePresentOrNot();

            if (presentOrNot)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");

            
        }

        public void EmployeeWage()
        {
            bool presentOrNot = Iemployee.EmployeePresentOrNot();
            // UC:02
            if (presentOrNot)
            {
                int dailyWage = Iemployee.DailyWageCalculate();
                Console.WriteLine($"Daily Employee Wage: {dailyWage}");
            }
        }
}
}
