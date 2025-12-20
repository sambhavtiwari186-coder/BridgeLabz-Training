using System;
public class AreaOfTriangle{
	public static void Main(){
		// Taking height and base as input from user
		Console.WriteLine("Enter the height of the triangle");
		Double Height = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter the base of the triangle");
		Double BaseOfTriangle=Convert.ToDouble(Console.ReadLine());
		// Finding the Area of the Traingle
		Double Area= 0.5d * Height * BaseOfTriangle;
		// Printig the answer
		Console.WriteLine("Area of the triangle is "+ Area);
	}
}