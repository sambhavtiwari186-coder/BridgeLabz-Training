using System;
public class ArmStrongNumber{
    public static void Main(){
        // Step 1: Take input of number from user
        Console.WriteLine("Enter a number:");
        int num = Convert.ToInt32(Console.ReadLine());
        // Step 2: Initialize variables
        int OriginalNumber = num;
        int sum = 0;
        // Step 3: Loop until originalNumber becomes 0
        while (OriginalNumber != 0){
            // Step 4: Get the last digit
            int rem = OriginalNumber % 10;
           // Step 5: Find cube of the digit and add to sum
            sum = sum + (rem * rem * rem);
           // Step 6: Remove last digit
            OriginalNumber = OriginalNumber / 10;
        }
          // Step 7: Compare sum with original number
        if (sum == num){
            Console.WriteLine(num + " is an Armstrong Number");
        }
        else{
            Console.WriteLine(num + " is NOT an Armstrong Number");
        }
    }
}
