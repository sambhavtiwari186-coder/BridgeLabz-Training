using System;
public class AbundantNumber{
    public static void Main(){
        // Step 1: Take input as number from user
        Console.WriteLine("Enter a number:");
        int num = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
       // Step 2: Find sum of proper divisors
        for (int i = 1; i < num; i++){
            if (num % i == 0){
                sum = sum + i;
            }
        }
       // Step 3: Check Abundant condition
        if (sum > num){
            Console.WriteLine(num + " is an Abundant Number");
        }
        else{
            Console.WriteLine(num + " is NOT an Abundant Number");
        }
    }
}
