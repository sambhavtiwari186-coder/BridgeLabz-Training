using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace BridgeLabzTraining.Constructor
{
    internal class PersonClass
    {
        public class Person
        {
            int height;
            string name;
            double weight;
            // Creating a Parameterized Constructor
            public Person(int height, string name, double weight)
            {
                this.height = height;
                this.name = name;
                this.weight = weight;
            }
            //Creating a Copy Constructor
            public Person(Person previousPerson)
            {
                name = previousPerson.name;
                weight = previousPerson.weight;
                height = previousPerson.height;
            }
            public void display()
            {
                Console.WriteLine("This is the copy of the Previous Person");
            }
            public void display1()
            {
                Console.WriteLine("The name of the Person is " + this.name);
            }
        }
        // Creating a Method To Create The Object Of the Class
        public void DisplayDetails()
        {
            Person first = new Person(178, "Sambhav", 75.2);
            first.display1();
            Person second = new Person(first);
            second.display1();
            second.display();
        }
    }
}
