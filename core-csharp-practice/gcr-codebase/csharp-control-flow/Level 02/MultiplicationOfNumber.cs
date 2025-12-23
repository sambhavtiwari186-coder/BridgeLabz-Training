using System;

public class MultiplicationOfNumber{
    public static void Main(){
		// Taking number as input from user
        Console.WriteLine("Enter a number:");
        int num = Convert.ToInt32(Console.ReadLine());
		// Printing the Multiples Here
        Console.WriteLine("Multiples of " + num + " below 100 are:");
        for (int i = 100; i >= 1; i--){
            if (i % num == 0){
                Console.WriteLine(i);
                continue;
            }
        }
    }
}
