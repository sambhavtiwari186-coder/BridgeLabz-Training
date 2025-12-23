using System;
public class FizzBuzz2{
	public static void Main(){
		Console.WriteLine("Enter a positive integer:");
        int num = Convert.ToInt32(Console.ReadLine());
       // Checking if the number is   positive integer or not
        if (num <= 0){
            Console.WriteLine("Please enter a positive integer.");
            return;
        }
       // Loop from 0 to number 
	   int i=0;
        while (i<=num){
            if (i % 3 == 0 && i % 5 == 0){
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 3 == 0){
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0){
                Console.WriteLine("Buzz");
            }
            else{
                Console.WriteLine(i);
            }
			i++;
        }
	}
}