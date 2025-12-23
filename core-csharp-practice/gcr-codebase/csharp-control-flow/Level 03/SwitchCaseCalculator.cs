using System;
public class SwitchCaseCalculator{
    public static void Main(){
		// Take two number as input from user
        Console.WriteLine("Enter first number:");
        double First = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        double Second = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter operator (+, -, *, /):");
        string Operators = Console.ReadLine();
		// Implying the Switch Case To Consider All Cases And Make Calculator
        switch (Operators){
            case "+":
                Console.WriteLine("Result: " + (First + Second));
                break;
             case "-":
                Console.WriteLine("Result: " + (First - Second));
                break;
             case "*":
                Console.WriteLine("Result: " + (First * Second));
                break;
             case "/":
                if (Second != 0)
                {
                    Console.WriteLine("Result: " + (First / Second));
                }
                else
                {
                    Console.WriteLine("Division by zero is not allowed.");
                }
                break;
             default:
                Console.WriteLine("Invalid Operator");
                break;
        }
    }
}
