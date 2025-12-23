using System;
public class LeapYearBasic{
	public static void Main(){
		// Enter the Year as Input from User
		Console.WriteLine("Enter The Year Here :: ");
		int year = Convert.ToInt32(Console.ReadLine());
		if(year <= 1582){
			Console.WriteLine("The entered year is not a leap year");
		}
		if(year%4==0){
			if(year%100!=0){
				Console.WriteLine("The entered year is not a leap year");
			}else if (year%400==0){
				Console.WriteLine("The entered year is a leap year ");
			}
		}else{
			Console.WriteLine("The entered year is not a leap year");
		}
		
	}
}