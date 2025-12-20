using System;

public class EricTravels
{
    public static void Main()
    {
        // Taking user details
        Console.Write("Enter traveler name: ");
        string name = Console.ReadLine();
        Console.Write("Enter starting city: ");
        string fromCity = Console.ReadLine();
        Console.Write("Enter via city: ");
        string viaCity = Console.ReadLine();
        Console.Write("Enter destination city: ");
        string toCity = Console.ReadLine();
        // Taking distance inputs
        Console.Write("Enter distance from " + fromCity + " to " + viaCity + " (in km): ");
        double fromToVia = Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter distance from " + viaCity + " to " + toCity + " (in km): ");
        double viaToFinalCity = Convert.ToDouble(Console.ReadLine());
        // Taking time inputs
        Console.Write("Enter hours taken from " + fromCity + " to " + viaCity + ": ");
        int hours1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter minutes taken from " + fromCity + " to " + viaCity + ": ");
        int minutes1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter hours taken from " + viaCity + " to " + toCity + ": ");
        int hours2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter minutes taken from " + viaCity + " to " + toCity + ": ");
        int minutes2 = Convert.ToInt32(Console.ReadLine());
        // Calculations
        double totalDistance = fromToVia + viaToFinalCity;
        int totalMinutes = minutes1 + minutes2;
        int extraHours = totalMinutes / 60;
        int remainingMinutes = totalMinutes % 60;
        int totalHours = hours1 + hours2 + extraHours;
        // Printing results
        Console.WriteLine(
            "The results of the trip are: " +
            totalDistance + " km, " +
            totalHours + " hours " + remainingMinutes + " minutes, and journey from " +
            fromCity + " to " + toCity + " via " + viaCity
        );
    }
}
