using System;
public class Voting{
    public static void Main(){
        // Taking age input from the user
        Console.WriteLine("Enter the age:");
        int age = Convert.ToInt32(Console.ReadLine());
        // Checking voting eligibility
        if (age >= 18)
        {
            Console.WriteLine("The person's age is " + age + " and can vote.");
        }
        else
        {
            Console.WriteLine("The person's age is " + age + " and cannot vote.");
        }
    }
}
