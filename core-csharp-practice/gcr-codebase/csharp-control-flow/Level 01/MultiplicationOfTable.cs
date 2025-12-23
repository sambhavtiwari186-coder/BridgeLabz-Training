using System;
public class MultiplicationOfTable{
    public static void Main(){
		// Take the number as input from user
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());
       // Print multiplication table from 6 to 9
        for (int i = 6; i <= 9; i++){
            Console.WriteLine(number + " * " + i + " = " + (number * i));
        }
    }
}
