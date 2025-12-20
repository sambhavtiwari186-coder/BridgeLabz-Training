using System;
public class WeightConvertor{
	public static void Main(){
		// Taking Weight as Input in Pounds form User
     Console.WriteLine("Enter the Weight in Pounds");
     Double Weight = Convert.ToDouble(Console.ReadLine());
      // Converting Weight in Pound into Km
      Double WeightInKm = Weight/2.2;
      // Printing The Output
      Console.WriteLine($"The weight of the person in pounds is {Weight} and in kg is {WeightInKm}");	  
	}
}