using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Constructor
{
    internal class EmployeeRecord
    {
     
        // Base Class
        public  class Employee
        {
            // Access Modifiers
            public int employeeID;           // Accessible everywhere
            protected string department;     // Accessible in derived class
            private double salary;            // Accessible only within Employee

            // Constructor
            public Employee(int employeeID, string department, double salary)
            {
                this.employeeID = employeeID;
                this.department = department;
                this.salary = salary;
            }

            // Public method to modify salary
            public void UpdateSalary(double amount)
            {
                if (amount > 0)
                {
                    salary = amount;
                }
                else
                {
                    Console.WriteLine("Invalid salary amount");
                }
            }

            // Public method to access salary
            public double GetSalary()
            {
                return salary;
            }

            // Display basic employee details
            public void DisplayEmployee()
            {
                Console.WriteLine("Employee ID : " + employeeID);
                Console.WriteLine("Department  : " + department);
                Console.WriteLine("Salary      : ₹" + salary);
            }
        }

        // Derived Class
        internal class Manager : Employee
        {
            private string role;

            public Manager(int employeeID, string department, double salary, string role)
                : base(employeeID, department, salary)
            {
                this.role = role;
            }

            // Accessing public and protected members
            public void DisplayManager()
            {
                Console.WriteLine("Manager Details");
                Console.WriteLine("Employee ID : " + employeeID);   // public access
                Console.WriteLine("Department  : " + department);   // protected access
                Console.WriteLine("Role        : " + role);
                Console.WriteLine("Salary      : ₹" + GetSalary());
            }
        }

        // Display Class
        internal class Program
        {
          public   static void Display()
            {
                Employee emp = new Employee(101, "IT", 45000);
                emp.DisplayEmployee();

                Console.WriteLine();

                emp.UpdateSalary(52000);
                Console.WriteLine("Updated Salary : ₹" + emp.GetSalary());

                Console.WriteLine();

                Manager mgr = new Manager(201, "HR", 75000, "Team Lead");
                mgr.DisplayManager();
            }
        }
    }
}
