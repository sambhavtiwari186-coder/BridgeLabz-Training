using System;
public class SumOfNaturalNumbers{
    public static void Main(){
        Console.WriteLine("Enter a natural number:");
        int n = Convert.ToInt32(Console.ReadLine());
        // Check if number is natural number or not
        if (n <= 0){
            Console.WriteLine("Please enter a valid natural number (greater than 0).");
            return;
        }
       // Sum using while loop
        int sum = 0;
        int i = 1;
        while (i <= n){
            sum += i;
            i++;
        }
        // Sum using formula
        int Formula = n * (n + 1) / 2;
        // Display results
        Console.WriteLine("Sum using while loop: " + sum);
        Console.WriteLine("Sum using formula: " + Formula);
        // Comparing  results of both the ways
        if (sum == Formula){
            Console.WriteLine("Result is CORRECT! Both computations match.");
        }
        else{
            Console.WriteLine("Result is INCORRECT! Computations do not match.");
        }
    }
}
