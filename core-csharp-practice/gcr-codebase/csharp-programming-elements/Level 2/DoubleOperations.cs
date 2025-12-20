using System;
public class DoubleOperation{
	public static void Main(){
         // Declare Double variables
         Double a, b, c;
         // Take user input
         Console.Write("Enter value of a: ");
         a = Convert.ToDouble(Console.ReadLine());
         Console.Write("Enter value of b: ");
         b = Convert.ToDouble(Console.ReadLine());
         Console.Write("Enter value of c: ");
         c = Convert.ToDouble(Console.ReadLine());
       // Perform integer operations (operator precedence applied automatically)
        Double res1 = a + b * c;
        Double res2 = a * b + c;
        Double res3 = c + a / b;
        Double res4 = a % b + c;
        // Print the results
        Console.WriteLine(
            "The results of Int Operations are " +
            res1 + ", " + res2 + ", " + res3 + ", and " + res4);
    }
}