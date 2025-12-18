using System;

public class DistanceConversion {
    static void Main() {
        Console.WriteLine("Enter The Distance in KM");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Converted Distance into Miles");
        Console.WriteLine(x*0.621371);
    }
}