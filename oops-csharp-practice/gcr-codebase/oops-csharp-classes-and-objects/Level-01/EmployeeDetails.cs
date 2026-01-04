using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Classes_And_Objects
{
    internal class EmployeeDetails
    {
        class Employee
        {
            string name;
            int id;
            double salary;
            public  Employee(string name,int id,double salary)
            {
                this.name = name;
                this.id=id;
                this.salary = salary;
            }
            public void Display()
            {
                Console.WriteLine("The Name of The Employee is " +  this.name);
                Console.WriteLine("The Id of The Employee is " + this.id);
                Console.WriteLine("The Salary of The Employee is " + this.salary);
            }
        }
        public void DisplayResult()
        {
            Employee obj = new Employee("Sambhav",1200,25000);
            obj.Display();
        }
    }
}
