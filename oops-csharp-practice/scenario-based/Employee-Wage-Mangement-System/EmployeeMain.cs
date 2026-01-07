using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.scenario_based.EmployeeWageMangement
{
    class EmployeeMain
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");


            EmployeeMenu empMenu;
            empMenu = new EmployeeMenu();


            // UC:01
            empMenu.EmployeeChoice();
            // UC:02
            empMenu.EmployeeWage();
            //UC:03

            empMenu.EmployeePartTimeWage();
        }
    }
}
