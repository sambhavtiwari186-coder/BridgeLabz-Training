using System;
 public class SimpleInterest{
	 public static void Main(){
		 Console.WriteLine("Enter the Principal Amount");
		 Double Principal = Convert.ToDouble(Console.ReadLine());
		 Console.WriteLine("Enter the Rate");
		 Double Rate =Convert.ToDouble(Console.ReadLine());
		 Console.WriteLine("Enter The Time taken");
		 Double Time=Convert.ToDouble(Console.ReadLine());
		 Double Amount= (Principal*Rate*Time)/100.00;
		 // Print The Output
		 Console.WriteLine("The Amount is" + Amount);		 
 }
 }