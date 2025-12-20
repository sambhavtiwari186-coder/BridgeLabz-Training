using System;
public class RunningAthlete{
	public static void Main(){
		// Take the sides of triangle as input from user
		Console.WriteLine("Enter All Three Sides of Triangle in m");
		Double s1= Convert.ToDouble(Console.ReadLine());
		Double s2= Convert.ToDouble(Console.ReadLine());
		Double s3 = Convert.ToDouble(Console.ReadLine());
		// Calculating the Perimeter of triangle
		Double Perimeter =s1+s2+s3;
		// Converting Perimeter in Km
	  Perimeter = Perimeter/1000.0;
	  // Taking no of distance Runner has to Cover in Km
	  Double DistanceToBeCovered= 5.00;
	  // Calculating the no of round runner has to  complete to cover this Distance
	  Double NoOfRounds = DistanceToBeCovered/Perimeter;
	  // Printing the NoOfRounds
	  Console.WriteLine($"The total number of rounds the athlete will run is {NoOfRounds} to complete 5 km");
	}
}