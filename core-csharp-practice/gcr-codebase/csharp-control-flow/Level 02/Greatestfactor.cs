using System;
public class Greatestfactor{
	public static void Main(){
		// Take number as input from the user
		 Console.WriteLine("Enter a number:");
        int num = Convert.ToInt32(Console.ReadLine());
        int greatestFactor = 1;
       // Loop from number-1 to 1
        for (int i = num - 1; i >= 1; i--){
            if (num % i == 0){
                greatestFactor = i;
                break; // stop after finding the greatest factor
            }
        }
        Console.WriteLine("Greatest factor of " + num  + " (beside itself) is " + greatestFactor);
	}
}