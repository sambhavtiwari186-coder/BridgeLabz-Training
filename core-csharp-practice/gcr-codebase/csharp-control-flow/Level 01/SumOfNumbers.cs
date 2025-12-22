using System;
public class SumOfNumbers{
	public static void Main(){
		// Taking Number as Input from User
		Console.WriteLine("Enter the Number here :");
		int a = Convert.ToInt32(Console.ReadLine());
		// Find if the number is natural number
		bool Natural = (a>=0);
		// Calculating the sum if number is natural number
		int sum =0;
		if(Natural){
			sum= (a*(a+1))/2;
			Console.WriteLine("The sum of " + a + "natural numbers is "+ sum);
		}
	    Console.WriteLine("The number " + a +" is not a natural number");
	  
		
	}
}