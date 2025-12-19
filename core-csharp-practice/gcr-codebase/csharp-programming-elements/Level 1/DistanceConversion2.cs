using System;
public class DistanceConvertor2{
	public static void Main(){
		//Taking distance in Km as input
		Console.WriteLine("The Distance in Km is");
		Double DistanceInKm = Convert.ToDouble(Console.ReadLine());
		// Converting The Distance In Km to Miles
		Double DistanceInMiles= DistanceInKm*1.6D;
		// Print the Answer In Miles
		Console.WriteLine("The Distance" +  DistanceInKm + "km in miles is"+ DistanceInMiles);
	}
}