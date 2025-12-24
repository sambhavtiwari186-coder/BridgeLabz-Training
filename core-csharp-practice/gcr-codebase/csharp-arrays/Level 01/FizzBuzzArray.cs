using System;
public class FizzBuzzArray{
    public static void Main(){
        Console.WriteLine("Enter the number:");
        int a = Convert.ToInt32(Console.ReadLine());
        if (a <= 0){
            Console.WriteLine("Please enter a positive number.");
            return;
        }
        // Initializing the array
        string[] arr = new string[a + 1];
       // Applying FizzBuzz logic (start from 1)
        for (int i = 1; i <= a; i++){
            if (i % 3 == 0 && i % 5 == 0){
                arr[i] = "FizzBuzz";
            }
            else if (i % 3 == 0){
                arr[i] = "Fizz";
            }
            else if (i % 5 == 0){
                arr[i] = "Buzz";
            }
            else{
                arr[i] = i.ToString();
            }
        }
        // Printing the array
        for (int i = 1; i <= a; i++){
            Console.WriteLine("Position " + i + " : " + arr[i]);
        }
    }
}
