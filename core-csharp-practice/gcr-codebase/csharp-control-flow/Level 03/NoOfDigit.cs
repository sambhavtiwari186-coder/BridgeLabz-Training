using System;
public class NoOfDigit{
    public static void Main(){
        // Step 1: Take input as number from user
        Console.WriteLine("Enter a number:");
        int num = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        // Step 2: Loop until number becomes 0
        while (num != 0){
            num = num / 10; // Remove last digit of the number
            count++;        // Increase count
        }
        // Step 3: Displaying  the result
        Console.WriteLine("Number of digits: " + count);
    }
}
