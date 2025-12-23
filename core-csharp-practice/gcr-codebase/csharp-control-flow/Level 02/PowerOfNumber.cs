using System;
public class PowerOfNumber{
    public static void Main(){
		// Take the Input from the User
        Console.WriteLine("Enter the number:");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the power:");
        int pow = Convert.ToInt32(Console.ReadLine());
       int res = 1;
       // Calculate power using loop
        for (int i = 1; i <= pow; i++){
            res = res* num;
        }
       Console.WriteLine(num + " raised to the power " + pow + " is " + res);
    }
}
