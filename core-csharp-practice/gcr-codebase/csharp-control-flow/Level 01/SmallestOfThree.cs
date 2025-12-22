using System;
public class SmallestOfThree{
	public static void Main(){
		// Taking three numbers as input from the user
		Console.WriteLine("Enter the three numbers here");
		int a = Convert.ToInt32(Console.ReadLine());
		int b= Convert.ToInt32(Console.ReadLine());
		int c= Convert.ToInt32(Console.ReadLine());
		// Checking if the first number is smallest of 3 
		bool SmallestCheck = ((a<b)&& (b<c)) ;
		// Printing the output
		Console.WriteLine($"Is the first number the smallest? :: {SmallestCheck}");
	}
}