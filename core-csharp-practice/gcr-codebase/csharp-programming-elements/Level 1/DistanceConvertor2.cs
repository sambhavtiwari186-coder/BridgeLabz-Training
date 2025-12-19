using System;
public class DistanceConvertor2{
	public static void Main(){
		// Distance in Km
		float DistanceInKm = 10.6f;
		// Converting The Distance In Km to Miles
		float DistanceInMiles= DistanceInKm*1.6f;
		// Print the Answer In Miles
		Console.WriteLine("The Distance" +  DistanceInKm + "km in miles is"+ DistanceInMiles);
	}
}