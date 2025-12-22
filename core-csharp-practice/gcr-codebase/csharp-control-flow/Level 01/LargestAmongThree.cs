using System;

public class LargestAmongThree
{
    public static void Main()
    {
        // Taking three numbers as input
        Console.WriteLine("Enter Three Numbers Here :");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());

        // Finding the largest number
        bool FirstLargest = (a > b) && (a > c);
        bool SecondLargest = (b > a) && (b > c);
        bool ThirdLargest = (c > a) && (c > b);

        // Printing the result
        Console.WriteLine(
            "Is the first number the largest? : " + FirstLargest +
            "\nIs the second number the largest? : " + SecondLargest +
            "\nIs the third number the largest? : " + ThirdLargest
        );
    }
}
