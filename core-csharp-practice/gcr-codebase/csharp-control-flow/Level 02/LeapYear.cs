using System;
public class LeapYear{
	public static void Main(){
		// Take number as input from the user
		Console.WriteLine("Enter the Year here");
		int a = Convert.ToInt32(Console.ReadLine());
		// Checking if the year is leap year or not
		if((a%400 == 0) || ((a%4==0) && (a%100!=0))){
			Console.WriteLine("The given year is a Leap Year");
		}else{
			Console.WriteLine("The given year is not a Leap Year");
		}
		
		
	}
}