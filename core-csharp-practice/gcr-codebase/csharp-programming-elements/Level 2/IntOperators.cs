using System;
public class IntOperators{
	public static void Main(){
         // Declare integer variables
         int a, b, c;
         // Take user input
         Console.Write("Enter value of a: ");
         a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter value of b: ");
        b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter value of c: ");
        c = Convert.ToInt32(Console.ReadLine());

        // Perform integer operations (operator precedence applied automatically)
        int result1 = a + b * c;
        int result2 = a * b + c;
        int result3 = c + a / b;
        int result4 = a % b + c;

        // Print the results
        Console.WriteLine(
            "The results of Int Operations are " +
            result1 + ", " + result2 + ", " + result3 + ", and " + result4
        );
    }
}