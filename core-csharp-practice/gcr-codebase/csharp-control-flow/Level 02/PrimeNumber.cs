using System;
public class PrimeNumber{
	public static void Main(){
		// Taking the number as Input from User
        Console.WriteLine("Enter a number here :");
        int num = Convert.ToInt32(Console.ReadLine());
         bool IsAPrime = true;
      // Prime numbers are greater than 1
        if (num <= 1)
        {
            IsAPrime = false;
        }
        else
        {
            // Checking  divisibility
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    IsAPrime = false;
                    break; // number is divisible by another number
                }
            }
        }
      // Printing the  result
        if (IsAPrime)
        {
            Console.WriteLine(num + " is a Prime Number");
        }
        else
        {
            Console.WriteLine(num + " is NOT a Prime Number");
        }
    }
}
