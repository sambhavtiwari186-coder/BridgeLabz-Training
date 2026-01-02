using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.keywords_and_instances_in_oops
{
    internal class EmplyeeMangemnetSystem
    {
        // Creating a Employees Class
        class Employees
        {
            public static string companyName = "ABC Private Limited";
                public static int totalEmployees = 0;
            string name;
           readonly int id;
            string designation;
            public Employees(string name, int id, string designation)
            {
                this.name = name;       
                this.id = id;
                this.designation = designation;
                totalEmployees++;
            }
            public static void DisplayTotalEmployees()
            {
                Console.WriteLine("The total no of Employees is " +  totalEmployees);
            }
            public void EmployeesDetails()
            {
                Console.WriteLine("The name of the Employee is " + this.name);
                Console.WriteLine("The id of the Employee " + this.id);
                Console.WriteLine("The Designation of the Employee is " + this.designation);
            }
        }
        // Craeting a Display Method to make the Object of the Class
        public void Display()
        {
            Employees em = new Employees("Sambhav", 2103, "Intern");
            Employees em1 = new Employees("Aditey", 2204, "Intern");
            bool show = em is Employees;
            if (show) {
                Console.WriteLine("This object is the instance of EmployeeClass");
                    }
            Console.WriteLine("The Name of the Company is " + Employees.companyName);
            em.EmployeesDetails();
            Console.WriteLine();
            em1.EmployeesDetails();
            Employees.DisplayTotalEmployees();



        }
    }
}
