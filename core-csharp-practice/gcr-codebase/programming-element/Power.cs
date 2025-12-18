using System;
public class Power {
    static void Main() {
         Console.WriteLine("Enter the  Number");
        int x = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter the Power");
        int pow = Convert.ToInt32(Console.ReadLine());

        double result = Math.Pow(x, pow);
		// Print the Result
        Console.WriteLine("The Result is"+ result);
    }
}