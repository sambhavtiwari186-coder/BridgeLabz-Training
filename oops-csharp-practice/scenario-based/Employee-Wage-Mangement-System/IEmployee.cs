using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.scenario_based.EmployeeWageMangement
{
     interface IEmployee
    {
        Employee AddEmployee();

        bool EmployeePresentOrNot(); //UC 1
        int DailyWageCalculate(); //UC 2

        
      }
}
