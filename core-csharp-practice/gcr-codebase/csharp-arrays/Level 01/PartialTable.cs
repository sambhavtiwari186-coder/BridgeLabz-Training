using System;
public class Partialtable{
	public static void Main(){
		// Intalise The Array
		int[] arr = new int[4];
		// Taking Input from The user
		Console.WriteLine("Enter The Number Here :: ");
		int a = Convert.ToInt32(Console.ReadLine());
		for(int i= 0; i<arr.Length;i++ ){
			arr[i]= a*(i+6);
		}
		for(int i=0; i<arr.Length;i++){
			Console.WriteLine(" " + (i+6) + " * " + a + " = " + arr[i]);
		}
	}
}