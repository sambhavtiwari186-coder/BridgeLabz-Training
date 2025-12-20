using System;

 public class Calculator{
  public  static void Main()
    {
        // Declare variables
        float num1, num2;

        // Taking two number as input from user
        Console.WriteLine("Enter first number: ");
        num1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number: ");
        num2 = float.Parse(Console.ReadLine());

        // Performing arithmetic operations
        float addition = num1 + num2;
        float subtraction = num1 - num2;
        float multiplication = num1 * num2;
        float division = num1 / num2;

        // Printing the results
        Console.WriteLine(
            "The addition, subtraction, multiplication and division value of 2 numbers {0} and {1} is {2}, {3}, {4}, and {5}",
            num1, num2, addition, subtraction, multiplication, division
        );
    }
}
