using System;
  public class NumberCheck{
    public static void Main(){
        // Taking input from the user
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());
        // Checking whether the number is positive, negative, or zero
        if (number > 0)
        {
            Console.WriteLine("Positive");
        }
        else if (number < 0)
        {
            Console.WriteLine("Negative");
        }
        else
        {
            Console.WriteLine("Zero");
        }
    }
}
