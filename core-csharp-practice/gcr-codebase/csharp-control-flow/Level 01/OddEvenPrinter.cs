using System;
public class OddEvenPrinter{
    public static void Main(){
        Console.WriteLine("Enter a natural number:");
        int number = Convert.ToInt32(Console.ReadLine());
      // Check if number is natural number or not
        if (number <= 0){
            Console.WriteLine("Please enter a valid natural number (greater than 0).");
            return;
        }
       // Loop from 1 to number
        for (int i = 1; i <= number; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i + " is an Even number");
            }
            else
            {
                Console.WriteLine(i + " is an Odd number");
            }
        }
    }
}
