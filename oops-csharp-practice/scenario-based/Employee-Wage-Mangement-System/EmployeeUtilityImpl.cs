using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace BridgeLabzTraining.scenario_based.EmployeeWageMangement
{
     class EmployeeUtilityImpl:IEmployee
    {
        private Employee employee;
        private int wagePerHour = 20;
        private int fullDayHrs = 8;

        public Employee AddEmployee()
        {
            employee = new Employee();
            return employee;
        }

        // UC:01
        public bool EmployeePresentOrNot()
        {
            Random random = new Random();
            int attendance = random.Next(2);
            return attendance == 1;
        }
            //UC2
        public int DailyWageCalculate()
        {
            return wagePerHour * fullDayHrs;
        }
    }
    }

