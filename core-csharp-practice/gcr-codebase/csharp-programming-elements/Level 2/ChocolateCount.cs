using System;
public class ChocolateCount{
	public static void Main(){
		// Taking No of Students and No of Chocolate as Input from User
		Console.WriteLine("Enter the No of Chocolate here : ");
		int NoofChocolate = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter the No of Students here : ");
		int NoofStudents = Convert.ToInt32(Console.ReadLine());
		// Calculating no of chocolates given to each child and remaining  chocolates
		int NoofReamainingChocolates = NoofChocolate%NoofStudents;
		int NoOfChocolateGiven = NoofChocolate/NoofStudents;
		// Printing The Output
		Console.WriteLine($"The number of chocolates each child gets is {NoOfChocolateGiven} and the number of remaining chocolates is {NoofReamainingChocolates}");
		
	}
}