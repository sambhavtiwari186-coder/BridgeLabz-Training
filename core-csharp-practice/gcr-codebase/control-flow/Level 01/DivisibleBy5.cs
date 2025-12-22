using System;
public class DivisibleBy5{
	public static void Main(){
		// Taking number as input from user
		Console.WriteLine("Enter the Number :");
		int a = Convert.ToInt32(Console.ReadLine());
		// Checking if the number is divisible by 5;
		bool b = ((a%5)==0);
		// Printing the output
		Console.WriteLine($" Is the number {a} divisible by 5 ? :: {b}");
	}
}