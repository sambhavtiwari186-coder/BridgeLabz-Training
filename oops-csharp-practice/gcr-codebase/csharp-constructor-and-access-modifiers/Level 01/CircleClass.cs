using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace BridgeLabzTraining.Constructor
{
    internal class CircleClass
    {

        public class Circle
        {
            double radius;
            // Writing a Default Constructor of the Circle class
            public Circle()
            {
                this.radius = 4.56;
            }
            // Writing a Parameterized Constructor of the Circle class
            public Circle(double radius)
            {
                this.radius = radius;
            }
            // Writing a Method to display the result
            public void display()
            {
                Console.WriteLine("The Radius of the Circle is " + this.radius);
            }
        }
        // Writing a Method to make the object of the above class 
        public void DisplayRadius()
        {
            Circle circle = new Circle(4.00);
            circle.display();
            Circle circle1 = new Circle();
            circle1.display();
        }
    }
}
