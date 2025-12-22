using System;
public class CountDown{
	public static void Main(){
		// Taking The Number as Input From User
		Console.WriteLine("Enter the number here :: ");
		int counter = Convert.ToInt32(Console.ReadLine());
		// Printing the number till 1
		while(counter>=1){
			Console.WriteLine(counter);
			counter--;
		}
		
	}
}