using System;
public class HarshadNumber{
    public static void Main(){
        // Step 1: Take input as number from input
        Console.WriteLine("Enter a number:");
        int num = Convert.ToInt32(Console.ReadLine());
        int OriginalNumber = num;
        int sum = 0;
        // Step 2: Find sum of digits
        while (num != 0){
            int rem = num % 10; // Get last digit
            sum = sum + rem;       // Add digit to sum
            num = num / 10;        // Remove last digit
        }
        // Step 3: Check Harshad condition
        if (sum != 0 && OriginalNumber % sum == 0){
            Console.WriteLine(OriginalNumber + " is a Harshad Number");
        }else{
            Console.WriteLine(OriginalNumber + " is NOT a Harshad Number");
        }
    }
}
