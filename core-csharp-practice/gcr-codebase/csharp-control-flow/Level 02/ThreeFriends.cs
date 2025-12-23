using System;
public class ThreeFriends{
    public static void Main(){
        // Input the age of Three Friends
        Console.WriteLine("Enter Amar's age:");
        int AmarAge = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Akbar's age:");
        int AkbarAge = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Anthony's age:");
        int AnthonyAge = Convert.ToInt32(Console.ReadLine());
        // Input heights of three friends
        Console.WriteLine("Enter Amar's height:");
        int AmarHeight = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Akbar's height:");
        int AkbarHeight = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Anthony's height:");
        int AnthonyHeight = Convert.ToInt32(Console.ReadLine());
        // Finding youngest friends among three friends
        if (AmarAge <= AkbarAge && AmarAge <= AnthonyAge)
        {
            Console.WriteLine("Amar is the youngest.");
        }
        else if (AkbarAge <= AmarAge && AkbarAge <= AnthonyAge)
        {
            Console.WriteLine("Akbar is the youngest.");
        }
        else
        {
            Console.WriteLine("Anthony is the youngest.");
        }
      // Finding tallest friend among three friends
        if (AmarHeight >= AkbarHeight && AmarHeight >= AnthonyHeight)
        {
            Console.WriteLine("Amar is the tallest.");
        }
        else if (AkbarHeight >= AmarHeight && AkbarHeight >= AnthonyHeight)
        {
            Console.WriteLine("Akbar is the tallest.");
        }
        else
        {
            Console.WriteLine("Anthony is the tallest.");
        }
    }
}
