using System;
public class Shopping{
	public static void Main(){
		// Taking Product price and Quantity as input
		Console.WriteLine("Enter the UnitPrice of Product");
		Double UnitPrice = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter the Quantity of Product");
		Double Quantity = Convert.ToDouble(Console.ReadLine());
		// Finding Total Cost of Shooping
		Double Cost = UnitPrice*Quantity;
		// Printinng the output
		Console.WriteLine("The total purchase price is INR "+ Cost +  " if the quantity " + Quantity + " and unit price is INR "+ UnitPrice);
	}
}
