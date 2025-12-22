using System;
public class UntilZero{
	public static void Main(){
		// Taking Number as Input from user
		Console.WriteLine("Enter the Number here");
		double a = Convert.ToDouble(Console.ReadLine());
		double b = a;
		double sum=0;
		while(b!=0){
			sum+=b;
		  Console.WriteLine("Enter Your Number Again");
		  b= Convert.ToDouble(Console.ReadLine());
		}
		Console.WriteLine("The Sum of Numbers until the user entered zero is " + sum);
	}
}