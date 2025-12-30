using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Classes_And_Objects
{
    internal class AreaOfCircle
    {
        class Circle
        {
            double radius;

            public Circle(double radius)
            {
                this.radius = radius;
            }
            public double Circumference(double radius)
            {
                double Circum = 2 * 3.14 * radius;
                return Circum;
            }
            public double Area(double radius) {
                double area = 3.14 * radius * radius;
                return area;
            }
            public void display()
            {
                double circum = Circumference(this.radius);
                double areaOfCircle = Area(this.radius);
                Console.WriteLine("The radius of the circle " + this.radius + " and the circumference is " + circum + " . Area of the circle " + areaOfCircle);
            }
        }
        public void DisplayCircle()
        {
            Circle obj = new Circle(6.17);
            obj.display();
        }
    }
}
