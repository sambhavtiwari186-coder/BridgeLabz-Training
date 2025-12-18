
using System;
public class AvgOfThreeNumber {
    static void Main(String[] args) {
		Console.WriteLine("Enter The First Number");
        int num1 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter The Second Number");
        int num2 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter The Third Number");
        int num3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("The Average Of Three Numbers is" + (num1+num2+num3)/3);
    }
    
    
}