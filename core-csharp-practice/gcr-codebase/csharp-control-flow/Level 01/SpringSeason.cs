using System;
public class SpringSeason{
    public static void Main(){
        Console.WriteLine("Enter the Month and Day:");
        int month = Convert.ToInt32(Console.ReadLine());
        int day = Convert.ToInt32(Console.ReadLine());
       // Check for invalid month or day first
        if (month < 1 || month > 12 || day < 1 || day > 31)
        {
            Console.WriteLine("Invalid Day or Month");
        }
        // Check for Spring Season
        else if (
            (month == 3 && day >= 20) ||
            (month == 4) ||
            (month == 5) ||
            (month == 6 && day <= 20)
        )
        {
            Console.WriteLine("It's a Spring Season");
        }
        else
        {
            Console.WriteLine("Not a Spring Season");
        }
    }
}
