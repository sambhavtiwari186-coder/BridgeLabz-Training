using System;
public class Factorial{
    public static void Main(){
        Console.WriteLine("Enter a positive integer:");
        int num = Convert.ToInt32(Console.ReadLine());
		// Check if the number is positive or not 
        if (num < 0){
            Console.WriteLine("Please enter a positive integer.");
            return;
        }
        int factorial = 1;
       // Calculate factorial using for loop
        for (int i=1; i<=num;i++){
            factorial = factorial * i;
        }
		// Print the factorial of the number
        Console.WriteLine("Factorial of " + num + " is " + factorial);
    }
}
