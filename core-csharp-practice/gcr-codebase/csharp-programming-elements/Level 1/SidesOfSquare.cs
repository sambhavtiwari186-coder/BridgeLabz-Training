using System;
public class SideOfSquare{
	public static void Main(){
		// Taking Perimeter of Square as input from user
		Console.WriteLine("Enter the Perimeter of Square");
		Double Perimeter = Convert.ToDouble(Console.ReadLine());
		// Finding side of a Square from Perimeter
		Double Side = Perimeter/4;
		// Printing Side of a Square as Output
		Console.WriteLine("Side of a Square is " + Side);
	}
}