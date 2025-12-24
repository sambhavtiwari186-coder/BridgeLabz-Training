using System;
public class MultiplicationTable{
	public static void Main(){
		//Take number as Input From User
		Console.WriteLine("Enter The Number Here :: ");
		int a = Convert.ToInt32(Console.ReadLine());
		// Intalise the array
		int [] multiplication = new int[11];
		for(int i=0;i<multiplication.Length;i++){
			multiplication[i]= i*a;
		}
		for(int i=0;i<multiplication.Length;i++){
			Console.WriteLine(a+" * "+ i +" = "+ multiplication[i]);
		}
}
}