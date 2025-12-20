using System;
public class DistanceConvertor3{
	public static void Main(){
		// Taking distance in feet as input
		Console.WriteLine("Enter the Distance in Feet");
		Double DistanceInFeet = Convert.ToDouble(Console.ReadLine());
		// Finding Distance in Yards
		Double DistanceInYards = DistanceInFeet/3;
		// Finding Distance in Mile
		Double DistanceInMile= DistanceInYards/1760;
		// Printinng the output
		Console.WriteLine("Distance in Yards is " + DistanceInYards+ " Distance in Miles is "+ DistanceInMile);
	}
}