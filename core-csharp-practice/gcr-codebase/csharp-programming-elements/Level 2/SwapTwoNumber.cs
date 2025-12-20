using System;
public class SwapTwoNumber{
	public static void Main(){
		// Taking two numbber as Input from User
		Console.WriteLine("Enter the two numbers here");
		int num1=Convert.ToInt32(Console.ReadLine());
		int num2=Convert.ToInt32(Console.ReadLine());
		// Taking a third variable for swapping two numbers
		int num3=0;
		// Logic to swap Two Numbers
		num3=num1;
		num1=num2;
		num2=num3;
		// Printing the swapped Number
		Console.WriteLine($"{num1} ,{num2}");
	}
}