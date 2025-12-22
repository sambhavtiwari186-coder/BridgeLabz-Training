using System;
public class CountDown2{
	public static void Main(){
		// Taking The Number as Input From User
		Console.WriteLine("Enter the number here :: ");
		int counter = Convert.ToInt32(Console.ReadLine());
		// Printing the number till 1
		for(int i=counter; i>=1;i--){
			Console.WriteLine(counter);
			counter--;
		}
		
	}
}